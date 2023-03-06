using System;

  namespace Assignment2
  {
    //this is a model of the Restaurants
      public class restaurants
      {
        public int RestaurantsID {get; set;}// This is the "primary key"
        public string Name {get; set;} = string.Empty;
        public int AddressID {get; set;}
      }
  }