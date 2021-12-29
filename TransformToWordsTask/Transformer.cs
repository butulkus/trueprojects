using System;
using System.Globalization;
using System.Text;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (number == double.PositiveInfinity)
            {
                return "Positive Infinity";
            }

            if (number == double.NegativeInfinity)
            {
                return "Negative Infinity";
            }

            if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }

            string[] arraynumber = new string[] { "point", "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "minus", "E", "plus" };
            string stringdouble = " ";
            CultureInfo[] cultures = { new CultureInfo("en-US"), new CultureInfo("fr-FR"), new CultureInfo("it-IT"), new CultureInfo("de-DE") };
            foreach (CultureInfo culture in cultures)
            {
                stringdouble = number.ToString(culture);
            }

            StringBuilder stringBuilder2 = new StringBuilder();
            for (int i = 0; i < stringdouble.Length; i++)
            {
                if (stringdouble[i] == ',' || stringdouble[i] == '.')
                {
                    stringBuilder2.Append(arraynumber[0]);
                }

                if (stringdouble[i] == '0')
                {
                    stringBuilder2.Append(arraynumber[1]);
                }

                if (stringdouble[i] == '1')
                {
                    stringBuilder2.Append(arraynumber[2]);
                }

                if (stringdouble[i] == '2')
                {
                    stringBuilder2.Append(arraynumber[3]);
                }

                if (stringdouble[i] == '3')
                {
                    stringBuilder2.Append(arraynumber[4]);
                }

                if (stringdouble[i] == '4')
                {
                    stringBuilder2.Append(arraynumber[5]);
                }

                if (stringdouble[i] == '5')
                {
                    stringBuilder2.Append(arraynumber[6]);
                }

                if (stringdouble[i] == '6')
                {
                    stringBuilder2.Append(arraynumber[7]);
                }

                if (stringdouble[i] == '7')
                {
                    stringBuilder2.Append(arraynumber[8]);
                }

                if (stringdouble[i] == '8')
                {
                    stringBuilder2.Append(arraynumber[9]);
                }

                if (stringdouble[i] == '9')
                {
                    stringBuilder2.Append(arraynumber[10]);
                }

                if (stringdouble[i] == '-')
                {
                    stringBuilder2.Append(arraynumber[11]);
                }

                if (stringdouble[i] == 'E')
                {
                    stringBuilder2.Append(arraynumber[12]);
                }

                if (stringdouble[i] == '+')
                {
                    stringBuilder2.Append(arraynumber[13]);
                }

                if (i < stringdouble.Length - 1)
                {
                    stringBuilder2.Append(" ");
                }

                if (i == 0)
                {
                    foreach (CultureInfo culture in cultures)
                    {
                        stringBuilder2[0] = char.Parse(stringBuilder2[0].ToString(culture).ToUpper(culture));
                    }
                }
            }

            return stringBuilder2.ToString();
        }
    }
}
