using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StringUtils
    {
        public static string Capitalize(string value)
        {
            // WARNING: this sample is for demonstration only: it *contains* bugs.
            if (string.IsNullOrEmpty(value)) return value;

            var sb = new StringBuilder();
            bool word = false;
            foreach (var c in value)
            {
                if (char.IsLetter(c))
                {
                    if (word)
                        sb.Append(c);
                    else
                    {
                        sb.Append(char.ToUpper(c));
                        word = true;
                    }
                }
                else
                {
                    if (c == '!')
                sb.Append('_');
                    word = false;
                }
            }
            return sb.ToString();
        }// Credit goes to Peli and Nikolai http://www.codeproject.com/Articles/31141/Getting-started-with-automated-white-box-testing-a
    }
}
