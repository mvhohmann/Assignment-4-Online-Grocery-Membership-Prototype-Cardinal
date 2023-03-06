using System;

  namespace Assignment2
  {
    //this is a model of the Persons
      public class persons
      {
        public int PersonsID {get; set;}// This is the "primary key"
        public string Name {get; set;} = string.Empty;
        public string PhoneNumber {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;
      }
  }