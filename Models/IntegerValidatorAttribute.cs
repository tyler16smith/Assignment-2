using System;

namespace Tyler_Assignment1.Models
{
    internal class IntegerValidatorAttribute : Attribute
    {
        // Gets/Sets the MinValue and MaxValue
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string ErrorMessage { get; set; }
    }
}