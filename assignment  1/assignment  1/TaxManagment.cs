using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



        namespace ToolVehicleTaxSystem
    {
        public abstract class ToolVehicle
        {


            // Instance Properties
            public int VehicleID;
            public string RegNo;
            public string Model;
            public string Brand;
            public decimal BasePrice;
            public string VehicleType;
            public static int TotalusersCreated = 0;

            // Static Properties (Overall Statistics)
            public static int TotalVehicles { get; set; }
            public static int TotalTaxPayingVehicles { get; set; }
            public static int TotalNonTaxPayingVehicles { get; set; }
            public static decimal TotalTaxCollected { get; set; }

            // Constructor
            protected ToolVehicle(int vehicleID, string regNo, string model, string brand, decimal basePrice, string vehicleType)
            {
                vehicleID = vehicleID;
                regNo = regNo;
                model = model;
                brand = brand;
                basePrice = basePrice;
                vehicleType = vehicleType;

                TotalVehicles++;
            }

            // Abstract Method
            public abstract void PayTax();

            // Concrete Method
            public void PassWithoutPaying()
            {
                TotalNonTaxPayingVehicles++;
            }
        }


        public class Car : ToolVehicle
        {
            private const decimal CarTax = 2.0m;

            public Car(int vehicleID, string regNo, string model, string brand, decimal basePrice)
                : base(vehicleID, regNo, model, brand, basePrice, "Car")
            {
            }

            public override void PayTax()
            {
                TotalTaxCollected += CarTax;
                TotalTaxPayingVehicles++;
            }
        }

        public class Bike : ToolVehicle
        {
            private const decimal BikeTax = 1.0m;

            public Bike(int vehicleID, string regNo, string model, string brand, decimal basePrice)
                : base(vehicleID, regNo, model, brand, basePrice, "Bike")
            {
            }

            public override void PayTax()
            {
                TotalTaxCollected += BikeTax;
                TotalTaxPayingVehicles++;
            }
        }

        public class HeavyVehicle : ToolVehicle
        {
            private const decimal HeavyVehicleTax = 4.0m;

            public HeavyVehicle(int vehicleID, string regNo, string model, string brand, decimal basePrice)
                : base(vehicleID, regNo, model, brand, basePrice, "Heavy Vehicle")
            {
            }

            public override void PayTax()
            {
                TotalTaxCollected += HeavyVehicleTax;
                TotalTaxPayingVehicles++;
            }
        }
    }



