using System;
using System.Collections.Generic;
using System.Text;

namespace TruckAusProgram {
  class Car : Vehicle {
    private string _bodyType;
    private string _colour;
    private string _upholstery;
    private int _doorNumber;
    public Car(string registrationNumber, string make, string model, int kmDriven,
      string bodyType, string colour, string upholstery, int doorNumber, Driver driver)
      : base(registrationNumber, make, model, kmDriven, driver) {
      this._bodyType = bodyType;
      this._colour = colour;
      this._upholstery = upholstery;
      this._doorNumber = doorNumber;
    }
    //method to call car specific details
    public void DisplaySpecific() {
      Console.WriteLine("Specific Details");
      Console.WriteLine($"Body Type: {this._bodyType}. Colour: {this._colour}. Upholsery:" +
        $" {this._upholstery}. Number of doors: {this._doorNumber}\n");
    }
    //method to display car general and specific details
    public void DisplayGeneralSpecific() {
      Console.WriteLine("Car General & Specific Details\n");
      DisplayGeneral();
      DisplaySpecific();
    }
    //method to change car colour
    public void UpdateColour(string newColour) {
      this._colour = newColour;
      Console.WriteLine($"Updating color....\nCar is now in {this._colour} colour!");
    }
    //method to display car general specific details with driver details
    public override void DisplayAll() {
      Console.WriteLine($"Displaying all {this.driver.FirstName}'s car and driver details.");
      DisplayGeneral();
      DisplaySpecific();
      driver.DisplayDriverDetails();
    }
  }
}