using System.Globalization;

namespace Shared.UserInputs
{
    public class UserInputs
    {
        ///<summary>
        ///Reads the next line of characters from the standard input stream. Tries to parse and convert it to integer.
        ///</summary>
        ///<returns>
        ///Integer.
        ///</returns>
        static public int TryParseIntUserInput()
        {
            Console.Write("Введите число: ");
            int result;
            var check = false;
            do
            {
                check = Int32.TryParse(Console.ReadLine(), out result);
                if (!check) Console.Write("Not an integer. Try again: ");
            }
            while (!check);
            return result;
        }

        ///<summary>
        ///Reads the next line of characters from the standard input stream. Tries to parse and convert it to array of integers.
        ///</summary>
        ///<param name="limit">
        ///Optional. Limits amount of enries to be taken and processed.
        ///</param>
        ///<returns>
        ///Array of integers.
        ///</returns>
        static public int[] TryParseIntArrayUserInput(int limit = 0)
        {
            char[] separators = { ' ', ',', '|' };
            StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;

            string? input;
            bool check = false;
            List<int> result = new List<int>();
            do
            {
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    System.Console.Write("Invalid input detected. Try again:");
                    continue;
                }

                var inputSplit = input.Split(separators, options);
                
                if(limit !=0)
                {
                    inputSplit = inputSplit.Take(limit).ToArray();
                }

                foreach (var n in inputSplit)
                {
                    if (Int32.TryParse(n, out int number))
                    {
                        result.Add(number);
                        check = true;
                    }
                    else
                    {
                        System.Console.Write("Invalid input detected. Try again:");
                        result.Clear();
                        check = false;
                        break;
                    }
                }
            }
            while (!check);
            return result.ToArray();
        }

        static public T[] TryParseArrayUserInput<T>(int limit = 0)
        {
            char[] separators = { ' ', ',', '|' };
            StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;

            string? input;
            bool check = false;
            List<T> result = new List<T>();
            do
            {
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    System.Console.Write("Invalid input detected. Try again:");
                    continue;
                }

                var inputSplit = input.Split(separators, options);
                
                if(limit !=0)
                {
                    inputSplit = inputSplit.Take(limit).ToArray();
                }

                foreach (var n in inputSplit)
                {
                    
                    var number = (T)Convert.ChangeType(n, typeof(T), CultureInfo.InvariantCulture);
                    if (number != null)
                    {
                        result.Add(number);
                        check = true;
                    }
                    else
                    {
                        System.Console.Write("Invalid input detected. Try again:");
                        result.Clear();
                        check = false;
                        break;
                    }
                }
            }
            while (!check);
            return result.ToArray();
        }

    }
}