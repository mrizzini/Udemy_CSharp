 // enums are a set of name/value pairs (constants)
 

 const int RegularAirMail = 1;
 const int RegisteredAirMail = 2;
 const int Express = 3;
 

 // OR
 // we can create our own type 

 public enum ShippingMethod
 {
    RegularAirMail = 1;
    RegisteredAirMail = 2;
    Express = 3;
 }


 var method = ShippingMethod.Express;

//  enums are default an integer but you can specify when creating