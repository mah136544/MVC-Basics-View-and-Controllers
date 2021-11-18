using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics_View_and_Controllers.Models
{
    public class Doctor
    {
        public static string FeverCheck(float temperature, string tempType)
        {

            string message = "";

            if (tempType == "Celsius")
            {
                if (temperature >= 38)
                {
                    message = "You have a fever, go to Doctor!";
                }

                else if (temperature < 35)
                {
                    message = "You have hypothermia!";
                }

                else
                {
                    message = "You don't have a fever, Take it easy.";
                }

            }

            else if (tempType == "Fahrenheit")
            {
                if (temperature >= 95)
                {
                    message = "OBS You have a fever, go to Doctor!";
                }

                else if (temperature < 95)
                {
                    message = "You have hypothermia!";
                }

                else
                {
                    message = "You don't have a fever, Take it easy.";
                }
            }


            return message;
        }
    }
}


