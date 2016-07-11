using MovieCatalog.EF;
using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCatalog.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetClients()
        {
            DAL _dal = new DAL();
            List<Client> clients = _dal.clients.ToList();
            return Json(clients, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveClient(Client _oClient)
        {
            DAL _oDAL = new DAL();
            _oDAL.clients.Add(_oClient);
            _oDAL.SaveChanges();

            List<Client> ListOfClients = _oDAL.clients.ToList();
            return Json(ListOfClients, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetClientByID(int id)
        {
            DAL _oDAL = new DAL();
            Client _oClient = new Client();
            _oClient = _oDAL.clients.Find(id);
            return Json(_oClient, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateClient(Client _oClient)
        {
            DAL _oDAL = new DAL();
            _oDAL.Entry(_oClient).State = System.Data.Entity.EntityState.Modified;
            _oDAL.SaveChanges();

            List<Client> ListOfClients = _oDAL.clients.ToList();
            return Json(ListOfClients, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteClient(int id)
        {
            DAL _oDAL = new DAL();
            Client _oClient = new Client();
            _oClient = _oDAL.clients.Find(id);
            _oDAL.Entry(_oClient).State = System.Data.Entity.EntityState.Deleted;
            _oDAL.SaveChanges();

            List<Client> ListOfClients = _oDAL.clients.ToList();
            return Json(ListOfClients, JsonRequestBehavior.AllowGet);
        }
    }
}