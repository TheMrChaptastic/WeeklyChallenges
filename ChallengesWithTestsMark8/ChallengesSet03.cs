using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null ? numbers.Where(x => x % 2 != 0).Sum() % 2 != 0 ? true : false : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var alphL = "abcdefghijklmnopqrstuvwxyz"; var alphU = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; var nums = "0123456789";
            var lowerC = 0; var upperC = 0; var numsC = 0;
            for (int i = 0; i < password.Length; i++)
            {
                lowerC += alphL.Contains(password[i]) ? 1 : 0;
                upperC += alphU.Contains(password[i]) ? 1 : 0;
                numsC += nums.Contains(password[i]) ? 1 : 0;
            }
            if (lowerC > 0 && upperC > 0 && numsC > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend == 0 || divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for(int i = 1; i < 100; i+=2)
            {
                list.Add(i);
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
