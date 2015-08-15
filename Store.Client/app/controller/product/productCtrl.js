(function () {

    var injectParameters = ["dataService"];

    var productCtrl = function (dataService) {

        var vm = this;
        vm.load = false;
        init();

        function init() {
            dataService.getAllProduct().then(
                function (results) {
                    vm.load = true;
                    return results.data;
                });
        }
    }

    tracksController.$inject = injectParameters;
    angular.module('angularApp').controller('productCtrl', productCtrl);

}());