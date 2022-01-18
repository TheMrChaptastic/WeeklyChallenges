using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var num = 0;
            foreach(var n in numbers)
            {
                if (n % 2 == 0)
                {
                    num += n;
                }
                else
                {
                    num -= n;
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengths = new int[4];
            lengths[0] = str1.Length; lengths[1] = str2.Length; lengths[2] = str3.Length; lengths[3] = str4.Length;
            var smallest = lengths[0];
            foreach(int n in lengths)
            {
                if (smallest > n)
                {
                    smallest = n;
                }
            }
            return smallest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var lengths = new int[4];
            lengths[0] = number1; lengths[1] = number2; lengths[2] = number3; lengths[3] = number4;
            var smallest = lengths[0];
            foreach (int n in lengths)
            {
                if (smallest > n)
                {
                    smallest = n;
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 < sideLength2 + sideLength3 && sideLength2 < sideLength1 + sideLength3 && sideLength3 < sideLength1 + sideLength2)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nCount = 0;
            var notNull = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nCount++;
                }
                else
                {
                    notNull++;
                }
            }
            return nCount > notNull ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double count = 0;
            double sum = 0;
            foreach(var n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                    count++;
                }
            }
            return count > 0 ? sum / count : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number - 1; i > 0; i--)
            {
                number = number * i;
            }
            return number == 0 ? 1 : number;
        }
    }
}
