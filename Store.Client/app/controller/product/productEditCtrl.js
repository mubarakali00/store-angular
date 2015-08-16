(function () {

    var injectParameters = ["$scope", "$location", "$routeParams", "dataService"];
    var productEditCtrl = function ($scope, $location, $routeParams, dataService) {

        var vm = this,
            productId = ($routeParams.productId) ? parseInt($routeParams.productId) : 0;

        vm.product = {};
        vm.statusMessage = '';
        getCategories();

        function getCategories() {

            dataService.getAllCategory().then(
                function (result) {
                    vm.categories = result;
                });
        }

        vm.saveProduct = function () {
            if (!vm.productId) {
                dataService.saveProduct(vm.product).then(
                    function (results) {
                        vm.statusMessage = "Product created successfully!!";
                });
            }
            else {
                //Update the product.
            }
        }

    }

    productEditCtrl.$inject = injectParameters;
    angular.module('angularApp').controller('productEditCtrl', productEditCtrl);
}());