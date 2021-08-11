using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class RegexExample
    {
        public const string FIRST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public const string LAST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public bool Regex(string firstName, string lastName)
        {
            Regex regex1 = new Regex(FIRST_NAME_RESTRICTION);
            Regex regex2 = new Regex(LAST_NAME_RESTRICTION);
            if (regex1.IsMatch(firstName) && regex2.IsMatch(lastName))
                return true;
            return false;
        }
    }
}
