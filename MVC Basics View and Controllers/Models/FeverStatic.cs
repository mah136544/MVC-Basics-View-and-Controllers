using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics_View_and_Controllers.Models
{
    public static class FeverStatic
    {
        public static bool IsValid(float? val)
        {
            bool result = true;
            
            if (val==null)
            {
                result = false;
            }
            return result;
    
        }
    }
}