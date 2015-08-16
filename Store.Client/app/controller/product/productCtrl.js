(function () {

    var injectParameters = ["$scope","$location","dataService"];

    var productCtrl = function ($scope, $location, dataService) {

        var vm = this;
        vm.load = false;
        vm.values = null;
        //init();
        getCategories();

        function getCategories() {

            dataService.getAllCategory().then(
                function (result) {
                    vm.categories = result;
                });
        }

        vm.getProducts = function() {
            var id = $scope.category;
            if (id) {
                dataService.getProductByCategoryId(id).then(
                function (results) {
                    vm.values = results.data;
                    vm.load = true;
                });
            }
            else {
                vm.load = false;

            }
            
        }

        vm.navigate = function (url) {
            $location.path(url);
        };

        function init() {
            dataService.getAllProduct().then(
                function (results) {
                    vm.load = true;
                    vm.values = results;
                });
        }
    }

    productCtrl.$inject = injectParameters;
    angular.module('angularApp').controller('productCtrl', productCtrl);

}());