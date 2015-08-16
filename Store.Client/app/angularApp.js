(function () {

    var app = angular.module('angularApp', ['ngRoute', 'angular-loading-bar', 'ngAnimate']);

    app.config(['$routeProvider', '$locationProvider', 'cfpLoadingBarProvider', function ($routeProvider, $locationProvider, cfpLoadingBarProvider) {

        var baseUrl = 'app/view/';
        $routeProvider
            .when('/', {
                title: 'Products Page',
                templateUrl: baseUrl + 'product/productPage.html',
                controller: 'productCtrl',
                controllerAs: 'vm'
            })
            .when('/editProduct/:productId', {
                title: 'Product Insert / Update Page',
                templateUrl: baseUrl + 'product/editProductPage.html',
                controller: 'productEditCtrl',
                controllerAs: 'vm'
            })
            .when('/contact', {
                title: 'Contact View Page',
                templateUrl: baseUrl + 'contact/contactView.html',
                controller: 'contactController',
                controllerAs: 'vm'
            })
            .otherwise({
                redirectTo: '/'
            });

        $locationProvider.html5Mode(true);

        cfpLoadingBarProvider.includeSpinner = false;
        cfpLoadingBarProvider.latencyThreshold = 100;

    }]);

    app.run(['$location', '$rootScope', function ($location, $rootScope) {
        $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {  //using success callback of route change
            if (current.$$route && current.$$route.title) { //Checking whether $$route is initialised or not
                $rootScope.title = current.$$route.title;
            }
        });
    }]);

}());