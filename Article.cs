using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Second_32
{
    class Article
    {
        public static string getArticle(string text)
        {
            string result = string.Empty;
            string keyWord1 = "наказывается";
            
            int count1 = 0, index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (count1 < keyWord1.Length && Char.ToLower(text[i]) == keyWord1[count1])
                {
                    count1++;
                }
                else
                {
                    count1 = 0;

                }
                if (count1 == keyWord1.Length)
                {
                    break;
                }
                index++;
            }
            if (index - keyWord1.Length > 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    result += text[i];
                    if (i == index - keyWord1.Length)
                    {
                        result += '\n';
                    }
                }
            }
            else
            {
                result += '\n';
                for (int i = 0; i < text.Length; i++)
                {
                    result += text[i];
                }
            }

            return result;
        }
    }
}
