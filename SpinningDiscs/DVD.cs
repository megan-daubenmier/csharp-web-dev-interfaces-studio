using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string name) : base(name, "DVD") { }

        public DVD(string name, double storageCap, double storageAvail, string contents) : base(name, "CD")
        {
            StorageCapacity = storageCap;

        }
    }
}
