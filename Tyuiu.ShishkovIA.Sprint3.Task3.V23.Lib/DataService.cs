﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShishkovIA.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string str = "fdsst siu vsrs";
            foreach (char s in str)
            {
                if (s == replaceable)
                {
                    str = str.Replace(replaceable, replacement);
                }
            }
            return str;
        }
    }
}
