using System;
using System.Collections.Generic;
using System.Text;

namespace NumericSequenceCalculator.Helpers
{
    public class SequenceCalculator
    {
        public const int MIN_SEQUENCE_VALUE = 1;
        public const int MAX_INPUT_VALUE = Int32.MaxValue;

        #region Methods


        public static string GetSequence(int inputValue)
        {
            StringBuilder sb = new StringBuilder();
            var sequence = new List<int>();
            for (int i = MIN_SEQUENCE_VALUE; i <= inputValue; i++)
            {
                sb.Append(i + ", ");
            }
            return TrimEndCharacters(sb);
        }

        public static string GetOddEvenSequence(int inputValue, out string evenSequence)
        {
            StringBuilder sbOdd = new StringBuilder();
            StringBuilder sbEven = new StringBuilder();

            for (int i = MIN_SEQUENCE_VALUE; i <= inputValue; i++)
            {
                if (i % 2 == 1)
                {
                    sbOdd.Append(i + ", ");
                }
                else
                {
                    sbEven.Append(i + ", ");
                }
            }
            evenSequence = TrimEndCharacters(sbEven);
            return TrimEndCharacters(sbOdd);
        }

        public static string GetCEZSequence(int inputValue)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = MIN_SEQUENCE_VALUE; i <= inputValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.Append("Z, ");
                }
                else if (i % 3 == 0)
                {
                    sb.Append("C, ");
                }
                else if (i % 5 == 0)
                {
                    sb.Append("E, ");

                }
                else
                {
                    sb.Append(i + ", ");
                }
            }

            return TrimEndCharacters(sb);
        }

        public static string GetFibonaciSeries(int inputValue)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0, 1, ");//Add initial Values
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;
            for (int i = MIN_SEQUENCE_VALUE; i < inputValue; i++)
            {

                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
                if (result > inputValue)
                {
                    break;
                }
                sb.Append(result + ", ");

            }



            return TrimEndCharacters(sb);

        }


        private static string TrimEndCharacters(StringBuilder sb)
        {
            return sb.ToString().Trim().TrimEnd(',');
        }
        #endregion
    }
}