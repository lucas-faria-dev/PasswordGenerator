using System.Text;

namespace PasswordGenerator
{
    public class Password
    {
        public static string GetRandomPassword(int length,bool useNumeric, bool useLowerAlpha, bool useUpperAlpha, bool useSymbol)
        {
            if(!useNumeric && !useLowerAlpha && !useUpperAlpha && !useSymbol || length < 1)
            {
                throw new InvalidOperationException("The length must be greater than 0 and at least one character type (Numeric, LowerAlpha, UpperAlpha or Symbol) must be used");
            }
            const string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()_-+={}[]|:;<>,./?'";

            string chars = "";

            if (useNumeric)
            {
                chars += numbers;
            }
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