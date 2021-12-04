using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationAndJUnit
{
    
    
        public class UserRegistrationFirstNameExcption : Exception
        {
            public UserRegistrationFirstNameExcption(string messge) : base("Invalide first name is enterd") { }
        }
        public class UserRegistrationLastNameExcption : Exception
        {
            public UserRegistrationLastNameExcption(string messge) : base("Invalide last name is enterd") { }
        }
        public class UserRegistrationNumberExcption : Exception
        {
            public UserRegistrationNumberExcption(string messge) : base("Invalide Number is enterd") { }
        }
        public class UserRegistrationMailIdExcption : Exception
        {
            public UserRegistrationMailIdExcption(string messge) : base("Invalide MailId is enterd") { }
        }
        public class UserRegistrationPasswordExcption : Exception
        {
            public UserRegistrationPasswordExcption(string messge) : base("Invalide Password is enterd") { }
        }
    
}
