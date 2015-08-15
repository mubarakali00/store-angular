(function () {

    var injectParams = ["$http"];

    var dataService = function ($http) {

        var factory = {};

        //factory.getAllTracks = function () {

        //    return $http.get('Track/GetAllTracks').then(
        //        function (results) {
        //            return results.data;
        //    });
        //}

        factory.getAllProduct = function () {

            return $http.get('Product/GetAllProduct').then(
                function (results) {
                    return results.data
                });
        }

        return factory;
    };

    dataService.$inject = injectParams;
    angular.module('angularApp').factory('dataService', dataService);

}());