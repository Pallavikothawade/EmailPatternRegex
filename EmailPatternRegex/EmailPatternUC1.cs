using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailPatternRegex
{
    class EmailPatternUC1
    {
        public static void Pattern()
        {
            string Pattern = "^([a-z0-9]){3,}?([-,.,+][a-z0-9]{1,})*@([a-z0-9]){1,}[.][a-z]{2,}?([.][a-z]{2,})*$";
            string[] Email = { "abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                "abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com","abc.1@yahoo.co"};


            foreach (string input in Email)
            {
                if(Regex.IsMatch(input,Pattern))
                {
                    Console.WriteLine("{0} is valid Email", input);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid Email", input);
                }
            }
        }
    }
}
