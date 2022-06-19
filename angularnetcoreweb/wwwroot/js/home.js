var app = angular.module("HomeAPP", []);

app.controller("HomeController", function ($scope, $http) {

    $http({
        method: "POST",
        headers: { "Content-Type":"Application/json; charset=utf-8"},
        url: "/Home/GetList"
        data:
    }).then(function (result) {

        $scope.KullaniciListem = result.data;

    });

    $scope.Topla = function () {

     $scope.sonuc= $scope.sayi1 + $scope.sayi2;





    }



});