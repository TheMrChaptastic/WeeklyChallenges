using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            if (ignoreCase == true)
            {
                foreach (var w in words)
                {
                    if (w != null)
                    {
                        if (word.ToLower() == w.ToLower())
                        {
                            return true;
                        }
                    }
                    
                }
            }
            else
            {
                return words.Contains(word);
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i < num / 2; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var posUnique = new List<char>();
            var duplicates = new List<char>();
            for(int i = 0; i < str.Length; i++)
            {
                if (!posUnique.Contains(str[i]))
                {
                    posUnique.Add(str[i]);
                }
                else
                {
                    duplicates.Add(str[i]);
                }
            }
            foreach(var c in duplicates)
            {
                posUnique.Remove(c);
            }
            return posUnique.Count == 0 ? -1 : str.IndexOf(posUnique[posUnique.Count - 1]);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var fCount = 0;
            var count = 0;
            var cIt = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (cIt == numbers[i])
                {
                    count++;
                    if (fCount < count)
                    {
                        fCount = count;
                    }
                }
                else
                {
                    if (fCount < count)
                    {
                        fCount = count;
                    }
                    count = 1;
                    cIt = numbers[i];
                }
            }

            return fCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var rList = new List<double>();
            if (elements == null || elements.Count == 0 || n < 1) return rList.ToArray();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                rList.Add(elements[i]);
            }
            return rList.ToArray();
        }
    }
}
