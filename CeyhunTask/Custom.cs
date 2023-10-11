using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ceyhun
{
    internal class Custom
    {
        public string Name;
        public bool ContainMethod(char SearchChar)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (SearchChar == Name[i])
                {
                    return true;
                }

            }
            return false;
        }
        public string SubStringElement(int start)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = start; i < Name.Length; i++)
            {
                newString.Append(Name[i]);
            }
            return newString.ToString();
        }
        public string ReplaceChar(char ChangeChar, char GivenChar)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < Name.Length; i++)
            {

                if (ChangeChar == Name[i])
                {
                    newString.Append(GivenChar);
                }
                else
                {
                    newString.Append(Name[i]);
                }
            }
            return newString.ToString();
        }

        public string Trim_Remove_Space()
        {
            StringBuilder newString = new StringBuilder();
            int startIndex = 0;
            int endIndex = - 1;

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                if (Name[i] != ' ')
                {
                    endIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                newString.Append(Name[i]);
            }
            return newString.ToString();



        }
    }
}
