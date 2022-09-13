using System;
//This is a Console App used to display hardcoded data for drivers, trucks and cars. Made by
//Tony Tran
namespace TruckAusProgram {
  class Program {
    static void Main() {
      string[] address1 = { "Street", "111 King St", "City", "Melbourne", "State",
        "Vic", "Postcode", "3000" };
      string[] address2 = { "Street", "69 Nice St", "City", "Bunbury", "State", "WA",
        "Postcode", "6230" };
      string[] stateLicensed1 = { "VIC", "NSW", "QLD", "WA", "TAS", "ACT", "SA", "NT" };
      string[] stateLicensed2 = { "VIC", "NSW", "QLD", "WA", "TAS" };

      Driver driver1 = new Driver("12ABC678", "Tombone", "Jonesey", 0393116665, address1,
        stateLicensed1, 3);
      Driver driver2 = new Driver("DEF56781", "Phullon", "Traxex", 0894696969, address2,
        stateLicensed2, 7);

      Car car1 = new Car("123abc", "Toyota", "Corolla", 400, "sedan", "blue", "leather", 5,
        driver1);
      Car car2 = new Car("321cba", "Mazda", "CX-69", 500, "hatchback", "white", "nylon", 3,
        driver2);

      Truck truck1 = new Truck("456def", "Honda", "Smallboy", 444, 6403, 2, 8, driver1);
      Truck truck2 = new Truck("654fed", "Mitsubishi", "BulkTank", 555, 7521, 4, 18, driver2);

      //Display car general details
      car1.DisplayGeneral();

      //Display car specific details
      car1.DisplaySpecific();

      //Display car general and specific details
      car1.DisplayGeneralSpecific();

      //Display driver details
      driver1.DisplayDriverDetails();

      //Display all car and driver details
      car1.DisplayAll();

      //Read and Write driver data to file
      driver1.ReadWriteFile();

      //Update demerit points with overall driver details
      driver1.DisplayDriverDetails();
      driver1.UpdateDemeritPoints(6);
      Console.WriteLine(".....................................");
      driver1.DisplayDriverDetails();

      //Updating km distance traveled and display changes in car details
      car1.DisplayGeneral();
      car1.UpdateKm(800);
      Console.WriteLine(".....................................");
      car1.DisplayGeneral();

      //Updating the car colour and displaying changes in car details 
      car1.DisplaySpecific();
      car1.UpdateColour("red");
      Console.WriteLine(".....................................");
      car1.DisplaySpecific();

      //Updating the car colour, km and demerit points and display all car driver details
      car1.DisplayAll();
      car1.UpdateKm(700);
      Console.WriteLine(".....................................");
      car1.UpdateColour("purplefruit");
      Console.WriteLine(".....................................");
      driver1.UpdateDemeritPoints(3);
      Console.WriteLine(".....................................");
      car1.DisplayAll();

      //Updating with illegal parameters and display all car driver details
      Console.WriteLine("Using illegal parameters");
      driver1.UpdateDemeritPoints(20);
      Console.WriteLine(".....................................");
      car1.UpdateKm(-300);
      Console.WriteLine(".....................................");
      car1.DisplayAll();
    }
  }
}