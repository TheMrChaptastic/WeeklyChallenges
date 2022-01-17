using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alph = "abcdefghijklmnopqrstuvwxyz";
            if (alph.Contains(c.ToString().ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 0 ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null)
            {
                var max = 0.0;
                var min = 0.0;
                if (numbers.Count() >= 1)
                {
                    min = numbers.ElementAt(0);
                    max = numbers.ElementAt(0);
                    if (numbers != null)
                    {
                        foreach (var i in numbers)
                        {
                            min = i < min ? i : min;
                            max = i > max ? i : max;
                        }
                    }
                }
                return min + max;
            }
            return 0.0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers != null)
            {
                foreach (var n in numbers)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if (numbers != null)
            {
                foreach (var n in numbers)
                {
                    sum += n % 2 == 0 ? n : 0;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = 0;
            if (numbers != null)
            {
                foreach (var n in numbers)
                {
                    sum += n;
                }
            }
            return sum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number / 2 : 0;
        }
    }
}
