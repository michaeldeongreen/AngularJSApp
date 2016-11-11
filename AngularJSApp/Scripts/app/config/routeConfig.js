app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: '/Scripts/app/views/home.html',
        controller: 'homeController'
    })
    .when('/pageOne', {
        templateUrl: '/Scripts/app/views/pageOne.html',
        controller: 'pageOneController'
    })
    .when('/pageTwo', {
            templateUrl: '/Scripts/app/views/pageTwo.html',
            controller: 'pageTwoController'
    })
    .otherwise({ redirectTo: '/' })
}]);