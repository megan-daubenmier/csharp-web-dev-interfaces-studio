using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc : IOpticalDisc
    {
        public readonly string DiscType;
        public string Name { get; set; }
        public readonly int SpinRate;
        public double StorageCapacity { get; set;  }
        public double StorageAvailable { get; set; }
        public bool IsScratched { get; set; }
        public string DiscContents { get; set; }
        public bool IsPlaying { get; set; }

        public BaseDisc(string name, string DiscType)
        {
            Name = name;
            if(DiscType == "CD")
            {
                SpinRate = 300;
            } else if (DiscType == "DVD")
            {
                SpinRate = 800;
            }
        }

        private bool CheckIfSpaceToStoreData(double dataAmount) 
        {
            if(dataAmount <= StorageAvailable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WriteToDisc(string contents, double dataAmount)
        {
            if (CheckIfSpaceToStoreData(dataAmount))
            {
                DiscContents += "\n" + contents;
                StorageAvailable = StorageAvailable - dataAmount;
            }
        }

        public void PlayAudioFromComputer() 
        {
            Console.WriteLine(CleanDisc());
            if (!IsScratched)
            {
                IsPlaying = true;
            }
        }

        private string CleanDisc() 
        {
            if (IsScratched)
            {
                return "Your disc is beyond hope and will not be playing.";
            } else
            {
                return "Your disc is ready to play!";
            }
        }

        public string GetDiscInfo() 
        {
            string discInfo = this.Name + ":\n" + "Spin Rate: " + this.SpinRate + "\nStorage Capacity: " + this.StorageCapacity + "\nStorage Available: " + this.StorageAvailable + "\nDisc Contents: " + this.DiscContents;
            if (IsScratched)
            {
                discInfo += "\nDisc Condition: Scratched";
            } else
            {
                discInfo += "\nDisc Condition: Good";
            }
            return discInfo;
        }


    }
}
