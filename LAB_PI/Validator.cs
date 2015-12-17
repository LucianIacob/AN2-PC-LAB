using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_PI
{
    /// <summary>
    /// Validator Class
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Check if a string is float number and greather than 0
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool isFloatPositiveNumber(string number)
        {
            try
            {
                float tarif = float.Parse(number, CultureInfo.InvariantCulture.NumberFormat);
                if (tarif > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Check if a string is a natural number different than 0
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool isNaturalNumber(string number)
        {
            try
            {
                int nr = Int32.Parse(number);
                if (nr > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}