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
            bool check = Regex.IsMatch(name, regexName);
            if (check)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationFirstNameExcption("invalid First name" + name);
            }
        }
        public static bool CheckLastName(string name)
        {
            string regexLastName = "^([A-Z][a-z]{3}[a-z]+)$";
            bool check = Regex.IsMatch(name, regexLastName);
            if (check)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationLastNameExcption("invalid Last name" + name);
            }
        }
        public static bool CheckMailId(string Id)
        {
            string regexId = "^([a-zA-Z0-9]+)(.?)([a-zA-Z0-9]+)([@][a-z]+)([.][a-z]+)$";
            bool check = Regex.IsMatch(Id, regexId);
            if (check)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationMailIdExcption("invalid MailId" + Id);
            }
        }
        public static bool CheckMobileNumber(string Number)
        {
            string regexNumber = "^[9][1][-][6-9][0-9]{9}$";
            bool check = Regex.IsMatch(Number, regexNumber);
            if (check)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationFirstNameExcption("invalid number" + Number);
            }
        }

        public static bool CheckPassword(string Password)
        {
            string regexPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[@#$^&*])(?=.*?[0-9]).{8,}$";
            bool check = Regex.IsMatch(Password, regexPassword);
            if (check)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationFirstNameExcption("invalid Password" + Password);
            }
        }
    }
}
