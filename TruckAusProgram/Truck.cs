using System;
using System.Collections.Generic;
using System.Text;

namespace TruckAusProgram {
  class Truck : Vehicle {
    private int _maxLoadCapacity;
    private int _axles;
    private int _wheels;
    public Truck(string registrationNumber, string make, string model, int kmDriven,
      int maxLoadCapacity, int axles, int wheels, Driver driver)
    : base(registrationNumber, make, model, kmDriven, driver) {
      this._maxLoadCapacity = maxLoadCapacity;
      this._axles = axles;
      this._wheels = wheels;
    }
    // Method to display truck specific details
    public void DisplaySpecific() {
      Console.WriteLine("Specific Details");
      Console.WriteLine($"Max Load Capacity: {this._maxLoadCapacity} KM. Number of _axles:" +
        $" {this._axles}. Number of _wheels: {this._wheels}\n");
    }
    // Method to display truck general and specific details
    public void DisplayGeneralSpecific() { 
      Console.WriteLine($"Truck General & Specific Details\n");
      DisplayGeneral();
      DisplaySpecific();
    }
    // Method to display truck general specific details with driver details
    public override void DisplayAll() {
      Console.WriteLine($"Displaying all {this.driver.FirstName}'s truck and driver details.");
      DisplayGeneral();
      DisplaySpecific();
      driver.DisplayDriverDetails();
    }
  }
}
