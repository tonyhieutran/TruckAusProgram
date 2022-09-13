using System;
using System.Collections.Generic;
using System.Text;

namespace TruckAusProgram {
  public class Vehicle {
    protected string _registrationNumber;
    protected string _make;
    protected string _model;
    protected int _kmDriven;
    protected Driver driver;     //Vehicle HAS-A Driver
    protected Vehicle(string registrationNumber, string make, string model, int kmDriven,
      Driver driver) {
      this._registrationNumber = registrationNumber;
      this._make = make;
      this._model = model;
      this._kmDriven = kmDriven;
      this.driver = driver;
    }
    // Method to vehicle details. Inherited in derived car and truck class
    public void DisplayGeneral() {
      Console.WriteLine("General Details");
      Console.WriteLine($"Registration Number: {this._registrationNumber}. Make: {this._make}." +
        $" Model: {this._model}. Distance Driven: {this._kmDriven} KM\n");
    }
    public void UpdateKm(int kmDriven) {
      this._kmDriven = kmDriven;
      Console.WriteLine($"Updating distance...\nYour {this._make} {this._model} has driven" +
        $" {this._kmDriven} KM");
      if (this._kmDriven < 0) {
        Console.WriteLine("KM could not be less than zero ");
        this._kmDriven = 0;
        Console.WriteLine($"Your {this._make} {this._model} has driven {this._kmDriven} KM");
      }
    }
    public virtual void DisplayAll() {
      Console.WriteLine($"Display All {this.driver.FirstName}'s Vehicle details.");
      DisplayGeneral();
      driver.DisplayDriverDetails();
    }
  }
}
    
