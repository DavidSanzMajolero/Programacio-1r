using System;


namespace Activitats
{
    public class Bike : Wheeled_Vehicle
    {
        public Bike (int kms, string brand, string license, int wheels, bool motor) : base (kms, brand, license, wheels)
        {
            Motor = motor;
        }
        public bool Motor { get; set; }
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nWheels: {Wheels}\nMotor: {Motor}";
        }
    }
}