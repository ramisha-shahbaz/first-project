

using System;

using ToolVehicleTaxSystem;
  
        Car car1 = new Car(1, "CAR123", "Civic", "Honda", 20000);
Bike bike1 = new Bike(2, "BIKE456", "R15", "Yamaha", 1500);
HeavyVehicle hv1 = new HeavyVehicle(3, "HV789", "Actros", "Mercedes", 80000);

car1.PayTax();
bike1.PassWithoutPaying();
hv1.PayTax();

Console.WriteLine($"Total Vehicles: {ToolVehicle.TotalVehicles}");
Console.WriteLine($"Tax Paying Vehicles: {ToolVehicle.TotalTaxPayingVehicles}");
Console.WriteLine($"Non-Tax Paying Vehicles: {ToolVehicle.TotalNonTaxPayingVehicles}");
Console.WriteLine($"Total Tax Collected: ${ToolVehicle.TotalTaxCollected}");
   


  





