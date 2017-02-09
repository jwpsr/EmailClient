(function () {
    'use strict';

    angular
        .module('app')
        .controller('subController', subController);

    function subController($scope) {
        $scope.email = {
            to: ['employees', 'staff'],
            subject: 'This is a test',
            body: '<h1>Hello World</h1>',
        }
    }
})();