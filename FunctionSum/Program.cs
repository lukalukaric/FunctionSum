using System;

namespace FunctionSum
{
    class Program
    {
        public string FunctionSum(string str)
        {
            int sum = 0;
            string finalString = "";
            string[] subStrings = str.Split('-');
            int sumForPluses = 1; // counting for + signs

            foreach (var stringInSubStrings in subStrings)
            {
                switch (stringInSubStrings)
                {
                    case "zero":
                        finalString += "0";
                        break;
                    case "one":
                        finalString += "1";
                        sum += 1;
                        break;
                    case "two":
                        finalString += "2";
                        sum += 2;
                        break;
                    case "three":
                        finalString += "3";
                        sum += 3;
                        break;
                    case "four":
                        finalString += "4";
                        sum += 4;
                        break;
                    case "five":
                        finalString += "5";
                        sum += 5;
                        break;
                    case "six":
                        finalString += "6";
                        sum += 6;
                        break;
                    case "seven":
                        finalString += "7";
                        sum += 7;
                        break;
                    case "eight":
                        finalString += "8";
                        sum += 8;
                        break;
                    case "nine":
                        finalString += "9";
                        sum += 9;
                        break;
                    default:
                        return "-1";
                }
                if (sumForPluses++ < subStrings.Length)
                    finalString += "+";
            }
            return finalString += ("=" + sum.ToString());
        }
        static void Main(string[] args)
        {
            Program prog = new Program();

            Console.WriteLine("Converting one-two-seven-four-nine-zero");
            Console.WriteLine(prog.FunctionSum("one-two-seven-four-nine-zero") + "\n");

            
        }
    }
}
