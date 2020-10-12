using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Exeptions
{
    public class PhoneNumberNotFoundException: Exception
    {
        public PhoneNumberNotFoundException()
        {
        }

        public PhoneNumberNotFoundException(string phonenumber)
            : base($"The phonenumber : {phonenumber} Doesnot exits ")
        {
        }

        public PhoneNumberNotFoundException(string phonenumber, Exception inner)
            : base($"The phonenumber : {phonenumber} Doesnot exits ", inner)
        {
        }

    }
}
