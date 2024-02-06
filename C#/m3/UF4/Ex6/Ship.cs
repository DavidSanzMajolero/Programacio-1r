using System;

namespace Activitats
{
    public class Ship : Vehicle
    {
        public Ship(int kms, string brand, string license, bool sail, int capacity) : base (kms, brand, license)
        {
            Sail = sail;
            Capacity = capacity;
        }
        public bool Sail { get; set; }
        public int Capacity { get; set; }
        public override string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}\nSail: {Sail}\nCapacity: {Capacity}";
        }
    }
}
