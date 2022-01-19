using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                {
                    biz.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            var r = "";
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] != "" && words[i] != " ")
                {
                    r += words[i].Trim();
                    if (i < words.Length - 1)
                    {
                        if (r[r.Length - 1] != ' ')
                        {
                            r += " ";
                        }
                    }
                    else
                    {
                        r += ".";
                    }
                }
            }
            return r;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var rList = new List<double>();
            if (elements == null)
            {
                return rList.ToArray();
            }
            for(int i = 3; i < elements.Count; i += 4)
            {
                rList.Add(elements[i]);
            }
            return rList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int u = i + 1; u < nums.Length; u++)
                {
                    if (nums[i] + nums[u] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
