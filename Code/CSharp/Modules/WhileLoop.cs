using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Code.CSharp.Modules;
public class WhileLoop
{
    public static void Lottery(int num)
    {

        while (num > 6 || num < 1)
        {
            Console.WriteLine("The number should be between 1 and 6, try again.");
            num = Convert.ToInt32(Console.ReadLine());
        }
        Random random = new Random();
        List<int[]> lotteryNumbers = new List<int[]>();
        int i = 0, j = 0;
        int newNumber;
        int size = 1;
        int[] numbers = new int[size];
        while (i != num)
        {
            j = 0;
            size = 1;
            while (j != num)
            {
                newNumber = random.Next(1, 50);
                numbers[j] = newNumber;
                size++;
                j++;
                Array.Resize(ref numbers, size);
            }
            lotteryNumbers.Add(numbers);
            Array.Resize(ref numbers, 1);
            i++;
        }
        CheckNumbers(lotteryNumbers, num);
    }

    public static void CheckNumbers(List<int[]> list,
                                    int num)
    {
        Random random = new Random();
        int i = 0, j = 0;
        int checkNumber;
        while (i != num)
        {
            j = 0;
            while (j != num)
            {
                checkNumber = list[i][j];
                if (Array.IndexOf(list[i], checkNumber) == Array.LastIndexOf(list[i], checkNumber))
                {
                    j++;
                }
                else
                {
                    list[i][j] = random.Next(1, 50);
                    j++;
                }
            }
            i++;

        }
        ShowList(list, num);
    }
    public static void ShowList(List<int[]> list,
                                int num)
    {
        int i = 0, j = 0;
        while (i != num)
        {
            j = 0;
            while (j != num)
            {
                Console.Write(list[i][j] + " ");
                j++;
            }
            i++;
            Console.WriteLine();
        }
    }
}
