using System;

class Program {
  public static void Main (string[] args) {
    var speed = 175; // mph
    
    if (speed < 74) { 
      Console.WriteLine("Not a Hurricane");
    } 
    if (speed > 74 && speed < 95) {
      Console.WriteLine("Category One Hurricane");
    }
        if (speed > 96 && speed < 110) {      
      Console.WriteLine("Category Two Hurricane");
    }
    if (speed > 157 && speed < 190) {    
      Console.WriteLine("Category Five Hurricane");
    }}}