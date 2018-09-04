using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        #region Methods
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim(); //Trim any spaces already there
                        result += " ";
                    }
                    result += letter;
                }
                result = result.Trim();
            }



            return result;
        }
        #endregion
    }
}
