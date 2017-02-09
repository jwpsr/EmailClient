(function () {
    'use strict';

    angular.module('app')
        .config(['$routeProvider', configuration]);

    function configuration($routeProvider){
        $routeProvider.when('/', {
            templateUrl: 'views/editor.html',
            controller: 'subController'
        });
    }
})();