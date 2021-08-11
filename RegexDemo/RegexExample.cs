using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class RegexExample
    {
        public const string FIRST_NAME_RESTRICTION = "^[A-Z]{1}[a-z]{2,}$";
        public bool Regex(string name)
        {
            Regex regex = new Regex(FIRST_NAME_RESTRICTION);
            return regex.IsMatch(name);
        }
    }
}
