(function (angular) {
    'use strict';

    angular
        .module('app-sendEmail')
        .controller('emailController', EmailController);

    function EmailController($scope) {

        $scope.template = { url: '/views/editEmail.html' };

        $scope.email = {
            to: ['employees', 'staff'],
            subject: 'This is a test',
            body: '<h1>Hello World</h1>',
        }
    }
})(window.angular);