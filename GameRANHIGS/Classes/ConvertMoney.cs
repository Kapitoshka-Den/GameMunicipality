using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRANHIGS.Classes
{
    internal class ConvertMoney
    {
        public string ConvertValue(int value)
        {
            string readyValue = "Бюджет : " + value.ToString("C2", CultureInfo.CurrentCulture);
            return readyValue;
        }
    }
}
