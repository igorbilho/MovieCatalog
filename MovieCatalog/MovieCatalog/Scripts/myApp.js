var myApp = angular.module('myApp', []);

myApp.controller('movieCtrl', function ($scope, $http) {
    
    $scope.movies = '';

    $http.get('/Home/GetMovies')
        .success(function (result) {
            $scope.movies = result;
        })
        .error(function (result) {
            console.log(result);
        });

    $scope.saveMovie = function (movie) {
        $http.post('/Home/SaveMovie', { _oMovie: movie })
            .success(function (result) {
                $scope.movies = result;
            })
            .error(function (result) {
                console.log(result);
            });
    };

    $scope.movie = '';

    $scope.selectMovie = function (id) {
        $http.post('/Home/GetMovieByID', { id: id })
            .success(function (result) {
                $scope.movie = result;
            })
            .error(function (result) {
                console.log(result);
            });
    };

    $scope.updateMovie = function (movie) {
        $http.post('/Home/UpdateMovie', { _oMovie: movie })
            .success(function (result) {
                $scope.movies = result;
            })
            .error(function (result) {
                console.log(result);
            });
    };

    $scope.deleteMovie = function (id) {
        $http.post('/Home/DeleteMovie', { id: id })
            .success(function (result) {
                $scope.movies = result;
            })
            .error(function (result) {
                console.log(result);
            });
    };
});