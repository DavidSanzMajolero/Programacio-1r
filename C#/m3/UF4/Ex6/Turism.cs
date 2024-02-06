using System;

namespace Activitats
{
    public class Turism : Four_Wheels
    {
        public Turism(int kms, string brand, string license, int wheels, int weight, bool mercancy, bool deport) : base(kms, brand, license, wheels, weight, mercancy)
        {
            Deport = deport;
        }
        public bool Deport { get; set; }
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nWheels: {Wheels}\nWeight: {Weight}\nMercancy {Mercancy}\nDeport: {Deport}";
        }
    }
}