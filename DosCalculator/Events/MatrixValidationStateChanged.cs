using System;

namespace DosCalculator.Events
{
    public class MatrixValidationStateChanged : EventArgs
    {
        public bool Valid { get; set; }
    }
}