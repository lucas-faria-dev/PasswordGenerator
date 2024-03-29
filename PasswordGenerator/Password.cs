﻿using System.Text;

namespace PasswordGenerator
{
    public class Password
    {
        /// <summary>
        /// Generates a random password
        /// </summary>
        /// <param name="length">Password's length</param>
        /// <param name="useLowerAlpha">If the generated password must have lower case characters</param>
        /// <param name="useUpperAlpha">If the  generated password must have upper case characters</param>
        /// <param name="useSymbol">If the generated password must have symbol</param>
        /// <returns>Random string</returns>
        public static string GetRandomPassword(int length, bool useLowerAlpha, bool useUpperAlpha, bool useSymbol)
        {
            const string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()_-+={}[]|:;<>,./?'";

            string chars = numbers;
            if (useLowerAlpha)
            {
                chars += lowerCaseLetters;
            }
            if (useSymbol)
            {
                chars += symbols;
            }
            if (useUpperAlpha)
            {
                chars += upperCaseLetters;
            }

            StringBuilder sb = new();
            Random rnd = new();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                switch (i)
                {
                    case 0:
                        if (useLowerAlpha && length > 1)
                        {
                            int indexAlpha = rnd.Next(lowerCaseLetters.Length);
                            sb.Append(lowerCaseLetters[indexAlpha]);
                        }
                        else
                        {
                            sb.Append(chars[index]);
                        }
                        break;
                    case 1:
                        if (useSymbol && length > 2)
                        {
                            int indexSymbol = rnd.Next(symbols.Length);
                            sb.Append(symbols[indexSymbol]);
                        }
                        else
                        {
                            sb.Append(chars[index]);
                        }
                        break;
                    case 2:
                        if (useUpperAlpha && length > 3)
                        {
                            int indexCaseSensitive = rnd.Next(upperCaseLetters.Length);
                            sb.Append(upperCaseLetters[indexCaseSensitive]);
                        }
                        else
                        {
                            sb.Append(chars[index]);
                        }
                        break;
                    case 3:
                        int indexnumbers = rnd.Next(numbers.Length);
                        sb.Append(numbers[indexnumbers]);
                        break;
                    default:
                        {
                            sb.Append(chars[index]);
                        }
                        break;
                }
            }
            return sb.ToString();
        }
    }
}