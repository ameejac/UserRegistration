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
        //string pattern = "^[A-Z]{1}[a-z]{2,30}[ ]*[A-Z]{1}[a-z]{2,20}$";

        //uc3 email Address
        //string pattern = "^[a-zA-Z0-9]+[._+]{0,1}[a-zA-Z0-9]*@[a-zA-Z0-9]{1,15}.[a-zA-Z]{2,10}[.]*[a-zA-Z]*$";

        //uc4 mobile number
        string pattern = "^[0-9]{2}[ ][0-9]{10}$";

        //Validating examples
        //string[] inputs = { "Jaan Cherukuru","Xyz Abc", "jaan cherukuru", "Ameeja Cherukuru", "Abcdef abcsd","reshma cherurukuru", "Reshma Cherukuru", "touhid cherukuru"};
        //string[] inputs = { "ameejacherukuru123@gmail.com","ameeja2.com","ameejac2","@ameeja.com","AMEEJACHERUKURU@GMAIL.COM","ameejacherukuru123a@gamil.com" };
        string[] inputs = {"91 7287047811","9550446571","12347561","917287047811","123645789456","91 1239784556"};

        /// <summary>
        /// Verifying the process
        /// </summary>
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Verifying  : ");
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

