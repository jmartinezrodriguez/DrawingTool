﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Utility
    {        

        public static string[] TextManager(string text, string delimitator)
        {
            string[] stringSeparators = new string[] { delimitator };
            string[] result = text.Split(stringSeparators, StringSplitOptions.None);
            return result;
        }
                    
    }
}
