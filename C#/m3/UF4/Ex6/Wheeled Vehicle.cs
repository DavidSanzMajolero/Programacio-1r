using System;

namespace Activitats
{
    public class Wheeled_Vehicle : Vehicle
    {
        public Wheeled_Vehicle(int kms, string brand, string license, int wheels ) : base(kms, brand, license)
        {
            Wheels = wheels;
        }
        public int Wheels { get; set;}
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nWheels: {Wheels}";
        }
    }
}
