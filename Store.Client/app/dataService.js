(function () {

    var injectParams = ["$http"];

    var dataService = function ($http) {

        var factory = {};

        factory.getAllProduct = function () {

            return $http.get('Product/GetAllProduct').then(
                function (results) {
                    return results.data
                });
        }

        factory.getAllCategory = function () {
            return $http.get('Category/GetAllCategory').then(
                function (results) {
                    return results.data;
                });
        }

        factory.getProductByCategoryId = function (id) {

            //return $http.post('/Product/GetProductByCategoryId/', id).then(
            //    function (result) {
            //        return result.data;
            //    });
            return $http({
                method: 'POST',
                url: '/Product/GetProductByCategoryId/',
                data: JSON.stringify({ CategoryId: id })
            }).success(function (data, status, headers, config) {
                return data;
            }).error(function (data, status, headers, config) {
                return 'Unexpected Error';
            });
        }

        return factory;
    };

    dataService.$inject = injectParams;
    angular.module('angularApp').factory('dataService', dataService);

}());