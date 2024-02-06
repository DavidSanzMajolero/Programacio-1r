using System;
using System.Runtime.InteropServices;

namespace Activitats
{
    public class Truck : Four_Wheels
    {
        public Truck(int kms, string brand, string license, int wheels, int weight, bool mercancy, int longt  ) : base(kms, brand, license, wheels, weight, mercancy)
        {
            Longt = longt;
        }
        public int Longt { get; set; }
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nWheels: {Wheels}\nWeight: {Weight}\nMercancy {Mercancy}\nLongt: {Longt}";
        }
    }
}
