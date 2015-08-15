(function () {

    var injectParameters = ["dataService"];

    var tracksController = function (dataService) {

        var vm = this;
        vm.Message = 'The controller is working...';
        Initialization();

        function Initialization() {

            dataService.getAllTracks().then(function (results) {
                vm.tracks = results;
            });
        };
    };

    tracksController.$inject = injectParameters;
    angular.module('angularApp').controller('tracksController', tracksController);
}());