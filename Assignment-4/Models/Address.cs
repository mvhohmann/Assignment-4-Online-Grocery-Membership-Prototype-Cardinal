using System;

  namespace Assignment2
  {
    //this is a model of the Address
      public class address
      {
        public int AddressID {get; set;}// This is the "primary key"
        public string Street {get; set;} = string.Empty;
        public string City {get; set;} = string.Empty;
        public string State {get; set;} = string.Empty;
        public int PostalCode {get; set;}
        public string Country {get; set;} = string.Empty;
      }
  }