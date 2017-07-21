using System;
using System.ComponentModel.DataAnnotations;

namespace NumericSequenceCalculator.Models
{
    public class SequenceCalculatorModel
    {
        #region Properties

        [Display(Name = "Enter Number")]
        [Required(ErrorMessage = "Number is Required.")]
        [Range(0,Int32.MaxValue,ErrorMessage ="Number must be positive or whole number.")]

        public int InputValue { get; set; }

        public string Sequence { get; set; }

        public string OddNumberSequence { get; set; }


        public string EvenNumberSequence { get; set; }


        public string CEZSequence { get; set; }


        public string FibonacciSequence { get; set; }


        #endregion
    }
}