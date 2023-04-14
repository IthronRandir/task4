using System;

namespace ConsoleApp
{
    class Program
    {
        static int Max3(int[] StartNumArr)
        {
            int n = StartNumArr.Length;
            int answer = 0;

            int[] SecNumArr = new int[n - 1];
            int[] EndNumArr = new int[n - 2];

            int max = StartNumArr[0];

            for (int i = 1; i < n; i++)
            {
                if (max < StartNumArr[i]) max = StartNumArr[i];
            }

            int k = 0;

            for (int i = 0; k < n - 1; i++)
            {
                if (StartNumArr[i] != max)
                {
                    SecNumArr[k] = StartNumArr[i]; k++;
                }
            }

            max = SecNumArr[0];

            for (int i = 1; i < n - 1; i++)
            {
                if (max < SecNumArr[i]) max = SecNumArr[i];
            }

            k = 0;

            for (int i = 0; k < n - 2; i++)
            {
                if (SecNumArr[i] != max)
                {
                    EndNumArr[k] = SecNumArr[i]; k++;
                }
            }

            answer = EndNumArr[0];

            for (int i = 1; i < n - 2; i++)
            {
                if (answer < EndNumArr[i]) answer = EndNumArr[i];
            }
            return answer;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            int answer = Max3(nums);
            Console.WriteLine(answer);
        }
    }
}
