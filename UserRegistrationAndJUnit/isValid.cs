using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationAndJUnit
{
    public class isValid
    {

        public static bool CheckFirstName(string name)
        {
            string regexName = "^([A-Z][a-z]{3}[a-z]+)$";
            return Regex.IsMatch(name, regexName);
           
            
        }
        public static bool CheckLastName(string name)
        {
            string regexLastName = "^([A-Z][a-z]{3}[a-z]+)$";
            return Regex.IsMatch(name, regexLastName);
            
           
        }
        public static bool CheckMailId(string Id)
        {
            string regexId = "^([a-zA-Z0-9]+)(.?)([a-zA-Z0-9]+)([@][a-z]+)([.][a-z]+)$";
           return Regex.IsMatch(Id, regexId);
        }
        public static bool CheckMobileNumber(string Number)
        {
            string regexNumber = "^[9][1][-][6-9][0-9]{9}$";
           return  Regex.IsMatch(Number, regexNumber);
            
        }

        public static bool CheckPassword(string Password)
        {
            string regexPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[@#$^&*])(?=.*?[0-9]).{8,}$";
            return Regex.IsMatch(Password, regexPassword);

            
        }
    }
}
