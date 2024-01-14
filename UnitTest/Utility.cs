using System;

namespace Project.Service
{
    public class Utility
    {
        public static bool Scrabble(string chars, string word)
        {
            Counter<char> symbolsInWord = new Counter<char>(word.ToLower());
            Counter<char> symbolsInChars = new Counter<char>(chars.ToLower());

            foreach (char key in symbolsInWord)
            {
                if (symbolsInChars.TryGetValue(key) < symbolsInWord[key])
                {
                    return false;
                }
            }

            return true;
        }

        public static int CompareVersions(string versionA, string versionB)
        {
            if (versionA == null || versionB == null)
            {
                throw new ArgumentNullException();
            }

            int lengthA = versionA.Length;
            int lengthB = versionB.Length;
            int minLength = lengthA < lengthB ? lengthA : lengthB;

            for (int i = lengthA - minLength, j = lengthB - minLength; i < lengthA; i++, j++)
            {
                char charA = versionA[i];
                char charB = versionB[j];

                if (charA < charB)
                {
                    return -1;
                }
                else if (charA > charB)
                {
                    return 1;
                }
            }

            return 0;
        }

        public static bool IsPrime(int number)
        {
            int n = (int)Math.Sqrt(number);
            for (int divisor = 2; divisor <= n; divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
