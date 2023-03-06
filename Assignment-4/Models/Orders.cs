using System;

  namespace Assignment2
  {
    //this is a model of the Orders
      public class orders
      {
        public int OrdersID {get; set;}// This is the "primary key"
        public int RestaurantsID {get; set;}
        public int ShopperID {get; set;}
        public int DriverID {get; set;}
        public DateTime OrderTime {get; set;}
        public DateTime? CompletionTime {get; set;}
        public double Total {get; set;}
      }
  }