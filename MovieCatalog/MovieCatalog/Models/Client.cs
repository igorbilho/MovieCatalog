using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCatalog.Models
{
    public class Client
    {
        public int cli_id { get; set; }
        public string cli_name { get; set; }
        public string cli_gender { get; set; }
        public DateTime cli_bdate { get; set; }
        public string cli_email { get; set; }
        public string cli_phone { get; set; }
        public string cli_nickname { get; set; }
        public string cli_password { get; set; }
    }
}