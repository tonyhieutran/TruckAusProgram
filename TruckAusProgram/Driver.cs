using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TruckAusProgram {
  public class Driver {
    private string _licenceNumber;
    // FirstName set to public to be used in the Car, Vehicle and Truck during call
    public string FirstName;
    private string _lastName;
    private int _phoneNumber;
    private string[] _address;
    private string[] _stateLicensed;
    private int _demeritPoints;
    static readonly int maxDemeritPoints = 12;
    public Driver(string licenceNumber, string firstName, string lastName, int phoneNumber,
      string[] address, string[] stateLicensed, int demeritPoints) {
      this._licenceNumber = licenceNumber;
      this.FirstName = firstName;
      this._lastName = lastName;
      this._phoneNumber = phoneNumber;
      this._address = address;
      this._stateLicensed = stateLicensed;
      this._demeritPoints = demeritPoints;
    }
    //method to display driver details
    public void DisplayDriverDetails() {
      Console.WriteLine($"Driver {this.FirstName} {this._lastName}. License Number:" +
        $" {this._licenceNumber}");
      Console.WriteLine($"Contact phone number: {this._phoneNumber}");
      Console.Write("Licensed to drive in");
      foreach (string stateElement in this._stateLicensed) {
        Console.Write($": {stateElement} ", this._stateLicensed);
      }
      Console.WriteLine("\nResidential _address");
      for (int i = 0; i < this._address.Length; i += 2) {
        Console.WriteLine("{0}: {1}", this._address[i], this._address[i + 1]);
      }
      Console.WriteLine("Current Demerit Points: {0}\n", this._demeritPoints);
    }
    // Method to update driver's demerit points value will add or subtract
    // if using negative integer.
    // Points exceed 12, warning will appear and will adjust points to 12. 
    // License suspensed Driver warning if points 12 and up.
    // Points adjusted if points fall below zero with adjustment to 0.
    public void UpdateDemeritPoints(int updatePoints) {
      this._demeritPoints += updatePoints;
      Console.WriteLine("Updating demerit points...Demerit points have been adjusted by {0}" +
        " points.", updatePoints);
      Console.WriteLine("Driver {0} now has {1} demerit points.", this.FirstName,
        this._demeritPoints);
      if (this._demeritPoints > maxDemeritPoints) {
        Console.WriteLine("Demerit points can not exceed 12 points");
        this._demeritPoints = maxDemeritPoints;
        Console.WriteLine("Driver {0} now has {1} demerit points. \nLicense Suspended.",
          this.FirstName, this._demeritPoints);
      } else if (this._demeritPoints >= maxDemeritPoints) {
        Console.WriteLine("License Suspended.");
      } else if (this._demeritPoints >= 9) {
        Console.WriteLine("License Suspension imminent.");
      } else if (this._demeritPoints < 0) {
        Console.WriteLine("Demerit points can not subceed 0 points.");
        this._demeritPoints = 0;
        Console.WriteLine("Driver {0} now has {1} demerit points.", this.FirstName,
          this._demeritPoints);
      }
    }
    // Method to read and write driver details. One call only to see the changes in text file.
    // Must sure folder directory is made for temp folder path to create text file
    public void ReadWriteFile()
    {
      String path = "C:\\Temp\\DriversDetailTT.txt";
      File.WriteAllText(path, "");
      File.AppendAllText(path, $"Driver {this.FirstName} {this._lastName}. License Number:" +
        $" {this._licenceNumber}" + Environment.NewLine);
      File.AppendAllText(path, $"Contact Number: {this._phoneNumber}" + Environment.NewLine);
      File.AppendAllLines(path, this._address);
      File.AppendAllLines(path, this._stateLicensed);
      string contents = File.ReadAllText(path);
      Console.WriteLine(contents);
    }
  }
}
