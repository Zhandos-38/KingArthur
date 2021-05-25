using System;

namespace KingArthur
{
    public class KnightApp
    { 
        private int numberOfKnights;
        public KnightApp(int num)
        {
            numberOfKnights = num;
        }
        public int FindBestKnight()
        {
            int[] nums = new int[numberOfKnights];
            int left = numberOfKnights;
            bool leave = true;
            int j = 0;
            for (int i = 0; i < numberOfKnights; i++)
            {
                nums[i] = i + 1;
            }
            while (left != 1)
            {
                if (nums[j] != 0)
                {
                    if (leave)
                    {
                        j++;
                        leave = false;
                    }
                    else
                    {
                        nums[j] = 0;
                        left--;
                        j++;
                        leave = true;
                    }
                }
                else
                {
                    j++;
                }
                if (j >= numberOfKnights)
                {
                    j -= numberOfKnights;
                }
            }
            for (int i = 0; i < numberOfKnights; i++)
            {
                if (nums[i] != 0)
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of knights: ");
            int numberOfKnights = Convert.ToInt32(Console.ReadLine());
            KnightApp app = new KnightApp(numberOfKnights);
            Console.WriteLine(app.FindBestKnight());
        }
    }
}