(function () {
    'use strict';

    angular
        .module('app')
        .controller('subController', subController);

    function subController($scope, $http) {

        $http.get('http://localhost:50001/api/email')
            .then(function (response) {
                //Success
                $scope.templates = response.data;
            }, function (response) {
                //Failure
                $scope.templates = undefined;
            });

        //initialize
        $http.get('http://localhost:50001/api/email/template/1')
            .then(function (response) {
                //Success
                $scope.editor = response.data;
            }, function (response) {
                //Failure
                $scope.editor = 'No data to display!';
            });


        $scope.options = {
            plugins: 'link image code',
            toolbar: 'undo redo | bold italic | alignleft aligncenter alignright | code'
        }
    }
})();