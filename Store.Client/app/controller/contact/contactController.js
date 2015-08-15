(function () {

    var contactController = function () {

        var vm = this;
        vm.welcome = 'Welcome to contact page, it means that controller is working fine';
    };

    angular.module('angularApp').controller('contactController', contactController);
}());