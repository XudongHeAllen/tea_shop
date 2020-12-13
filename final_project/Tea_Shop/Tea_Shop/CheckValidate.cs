using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tea_Shop
{

    /// <summary>
    /// This class was created by Hung-200452314
    /// </summary>
    class CheckValidate
    {
        public static bool checkForType(string type)
        {
            bool IsValid = false;
            Regex r = new Regex(@"([A-Za-z]+)"); // only letter, 1 or more.
            if (r.IsMatch(type))
            {
                IsValid = true;
            }
            return IsValid;
        }

        public static bool checkForPrice(string price)
        {
            bool IsValid = false;
            Regex r = new Regex(@"(?=.*?\d)^\$?(([1-9]\d{0,2}(,\d{3})*)|\d+)?(\.\d{1,2})?$"); //only numbers, dcimal and commas are optional.
            if (r.IsMatch(price))
            {
                IsValid = true;
            }
            return IsValid;
        }

        public static bool checkForInventory(string inventory)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^\d+$"); // must be natural numbers, start with 0.
            if (r.IsMatch(inventory))
            {
                IsValid = true;
            }
            return IsValid;
        }
    }
}
