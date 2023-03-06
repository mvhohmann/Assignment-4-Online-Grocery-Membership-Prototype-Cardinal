using System;

  namespace Assignment2
  {
    //this is a model of the MenuItems
      public class menuItems
      {
        public int MenuItemsID {get; set;}// This is the "primary key"
        public int RestaurantsID {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public double Price {get; set;}
      }
  }