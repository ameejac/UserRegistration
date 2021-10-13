using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class UserRegistration
    {
        //Uc1 FirstName
        //writing the valid pattern
        //string pattern = "^[A-Z]{1}[a-z]{2,15}$";

        //uc2 FirstName and user needs to add the LastName
        string pattern = "^[A-Z]{1}[a-z]{2,30}[ ]*[A-Z]{1}[a-z]{2,20}$";

        //Validating examples
        string[] inputs = { "Jaan Cherukuru","Xyz Abc", "jaan cherukuru", "Ameeja Cherukuru", "Abcdef abcsd","reshma cherurukuru", "Reshma Cherukuru", "touhid cherukuru"};

        /// <summary>
        /// Verifying the process
        /// </summary>
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Verifying  FirstName starts with capital: ");
            IterationLoop(inputs, regex);
        }
        public static void IterationLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + " It is --->" + "Invalid");
                }
            }
        }
    }
}

