using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationAndJUnit
{
    class ValidationUsingLambdaFunctions
    {
        public static void CheckMailId(string Id)
        {
            bool val;
                    
            if (val = (Id == "^([A-Z][a-z]{3}[a-z]+)$"))
            {
                Console.WriteLine("The mail Id is valid");
            }
        }
        public static void CheckFirstName(string Name)
        {
            bool val;

            if (val = (Name == "^([A-Z][a-z]{3}[a-z]+)$"))
            {
                Console.WriteLine("The First name Id is valid");
            }
        }
        public static void CheckLastName(string Name)
        {
            bool val;

            if (val = (Name == "^([A-Z][a-z]{3}[a-z]+)$"))
            {
                Console.WriteLine("The last name Id is valid");
            }
        }
        public static void CheckMobileNumber(string Number)
        {
            bool val;

            if (val = (Number == "^[9][1][-][6-9][0-9]{9}$"))
            {
                Console.WriteLine("The number Id is valid");
            }
        }
        public static void CheckPassword(string passord)
        {
            bool val;

            if (val = (passord == "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[@#$^&*])(?=.*?[0-9]).{8,}$"))
            {
                Console.WriteLine("The Password Id is valid");
            }
        }
    }
}
