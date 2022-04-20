using System;

namespace Task1
{

    public static class StringExtension
    {
        public static string CapitalizeFirst(this string s)
        {
            bool IsNewSentense = true;

            string[] str = { "heLlo eVeRYboDy. i aM HeRe" };

            var result = new StringBuilder(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (IsNewSentense && char.IsLetter(s[i]))
                {
                    result.Append(char.ToUpper(s[i]));
                    IsNewSentense = false;
                }
                else
                    result.Append(s[i]);

                if (s[i] == '.' || s[i] == ' ' )
                {
                    IsNewSentense = true;
                    
                }
            }
            
            return result.ToString();

            Console.WriteLine(result);
        }

    }
}
