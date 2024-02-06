using System;
using System.Reflection;

namespace Activitats
{
    public abstract class Vehicle
    {
        public Vehicle(int kms, string brand, string license) 
        { 
            Kms = kms;
            Brand = brand;
            License = license;
        }

        public int Kms { get; set; }
        public string Brand { get; set; }
        public string License { get; set; }
        public virtual string GetInfo()
        {
            return $"KMS: {Kms}\nBrand: {Brand}\nLicense Plate: {License}";
        }
    }
}
