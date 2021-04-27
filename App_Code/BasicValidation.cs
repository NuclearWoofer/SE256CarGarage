using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE256_Lab_MikeL.App_Code
{
    class BasicValidation
    {

        //pause function to pause screen
        public static void Pause()
        {
            Console.WriteLine("\nPress Any Key to Continue\n");
            Console.ReadKey();
        }


        //Got Poop?
        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
            if (temp.Contains(strBW))
            {
                result = true;
            }
            return result;
        }



        //receives a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;
            if (temp.Length >= minlen)
            {
                result = true;
            }
            return result;
        }




        //receives a string and we can let user know if it has a valid email format
        public static bool IsValidEmail(string temp)
        {
            bool blnResult = true;
            // looks for the "@" and the "." in the amil
            int atLocation = temp.IndexOf("@");
            int NextAtLocation = temp.IndexOf("@", atLocation + 1);
            int periodLocation = temp.LastIndexOf(".");

            //checking for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2) //if it is -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;
            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }




    }
}
