using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }


            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
             //return vals != null && vals.Length != 0 && vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                   sum += number;
                }

            }

            return sum % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLetter = false;
            bool isDigit = false;
            bool isUpper = false;

            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLetter = true;
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
            }
            return isLetter && isDigit && isUpper;
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
