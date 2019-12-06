using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtension
    {
        public static string capatalize(this string str)
        {

            string first = str[0].ToString().ToUpper();
            return first[0] + str.Substring(1);

        }
        public static string ToCamelCase(this string str)
        {



        }
        public static int WordCount(this string str)
        {

            return str.Split(new char[] { ' ', '.', '\n', '\t' },StringSplitOptions.RemoveEmptyEntries).Length;

        }

        public static string Smurf(this string s, string toreplce)
        {
            return s.Replace(toreplce, "Smurf");
        }
    }
}
