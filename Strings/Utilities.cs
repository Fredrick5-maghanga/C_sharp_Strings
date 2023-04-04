using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Utilities
    {
        //Manipulating  Strings
        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";

            string lastName = "Smith";
            string fullName = firstName + " " + lastName;
            string employeeIdentification= string.Concat(firstName, lastName);
            string empId = firstName.ToLower() + "-" + lastName.ToLower();
            int length=empId.Length;

            if (fullName.Contains ("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }
            string subString= fullName.Substring (1,3);
            Console.WriteLine("Characters 2 to 4 of fullName are" +" " + subString);
            string userNameWithInterpolation = $"{firstName}-{lastName}";
        }

        public static void UsingSimmpleStrings()
        {
            string firstName = "Bethany";
            
            string lastName = "Smith";
           
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();

            userName = "";//identical to string.Empty;

        }
    }
}
