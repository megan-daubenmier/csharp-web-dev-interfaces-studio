using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public void SpinDisc() { }
        public void WriteToDisc() { }
        public void PlayAudioFromComputer() { }
    }
}
