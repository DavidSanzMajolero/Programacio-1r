using System;

namespace Activitats
{
    public class Four_Wheels : Wheeled_Vehicle
    {
        public Four_Wheels(int kms, string brand, string license, int wheels, int weight, bool mercancy) : base(kms, brand, license, wheels)
        {
            Weight = weight;
            Mercancy = mercancy;
        }
        public int Weight { get; set; }
        public bool Mercancy { get; set;}
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nWheels: {Wheels}\nWeight: {Weight}\nMecancy: {Mercancy}";
        }
    }
}
