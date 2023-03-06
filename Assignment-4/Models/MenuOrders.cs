using System;

  namespace Assignment2
  {
    //this is a model of the MenuOrders
      public class menuOrders
      {
        public int MenuOrdersID {get; set;}// This is the "primary key"
        public int OrderID {get; set;}
        public int MenuItemID {get; set;}
        public int Quantity {get; set;}
        public double Subtotal {get; set;}
      }
  }