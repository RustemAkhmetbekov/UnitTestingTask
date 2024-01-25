using System.Text;

namespace UnitTestingTask
{
    public class ConsecutiveIdentical
    {
        public int MaximumUnequalConsecutiveChars(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public int MaximumConsecutiveIdenticalLetters(string input)
        {
            int maxCount = 0;
            int currentCount = 1;

            StringBuilder newInput = new StringBuilder();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        newInput.Append(c);
                    }
                }
            }

            for (int i = 1; i < newInput.Length; i++)
            {
                if (char.IsLetter(newInput[i]) && newInput[i] == newInput[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public int MaximumConsecutiveIdenticalDigits(string input)
        {
            int maxCount = 0;
            int currentCount = 1;

            StringBuilder newInput = new StringBuilder();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                    {
                        newInput.Append(c);
                    }
                }
            }

            for (int i = 1; i < newInput.Length; i++)
            {
                if (char.IsDigit(newInput[i]) && newInput[i] == newInput[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }
    }
}
