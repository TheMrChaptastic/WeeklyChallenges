using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(var val in vals)
            {
                if(val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var count = 0;
            foreach(var n in numbers)
            {
                if (n % 2 == 1 || n % 2 == -1)
                {
                    count++;
                }
            }
            return count % 2 == 1 ? true : false;
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
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
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
