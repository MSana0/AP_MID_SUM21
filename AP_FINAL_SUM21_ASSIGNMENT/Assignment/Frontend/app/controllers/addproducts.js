  
app.controller("addproducts",function($scope,ajax,$location){

    ajax.get(API_ROOT+"api/Category/GetAll",
    function(resp){
      $scope.categories = resp.data;
    },
    function(err){
  
    });
  
    $scope.addproducts = function(p){
       ajax.post(API_ROOT+"api/Product/Add",p,
       function(resp){
            $location.path("/products");
       },function(err){});
  
    };
  });