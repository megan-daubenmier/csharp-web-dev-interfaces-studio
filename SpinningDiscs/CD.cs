using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {

        public CD(string name) : base(name, "CD") { }

        public CD(string name, double storageCap, double storageAvail, string contents) : base(name, "CD") 
        {
            StorageCapacity = storageCap;

        }
    }
}
