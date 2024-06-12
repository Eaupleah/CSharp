using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.CSharp.Modules;
public class ForLoop
{
    public static int FindMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }
    public static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    public static int FindOdd(int[] array)
    {
        int oddNumbers = 0;
        foreach (int number in array)
        {
            int number2 = Math.Abs(number);
            if (number2 % 2 == 1)
            {
                oddNumbers++;
            }
        }
        return oddNumbers;
    }
    public static int FindEven(int[] array)
    {
        int evenNumbers = 0;
        foreach (int number in array)
        {
            int number2 = Math.Abs(number);
            if (number2 % 2 == 0)
            {
                evenNumbers++;
            }
        }
        return evenNumbers;
    }
    public static int SumOfDigits(int number)
    {
        int digitSum = 0;
        while (number != 0)
        {
            digitSum = digitSum + number % 10;
            number = number - number % 10;
            number = number / 10;
        }
        return digitSum;
    }
    public static void Square(int leng)
    {
        for (int i = 0; i < leng; i++)
        {
            for (int j = 0; j < leng; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

        }
    }
    public static void RightTriangle(int leng)
    {
        int leng2 = 0;
        for (int i = 0; i < leng; i++)
        {
            for (int j = 0; j <= leng2; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            leng2++;
        }
    }
    public static void HollowSquare(int leng)
    {

        for (int i = 0; i < leng; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < leng; j++)
            {
                if (i == 0 || i == leng - 1 || j == 0 || j == leng - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }

            }
        }

    }
    public static void MultiplicationTable()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine();
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} * {j} = {i * j} ");
                Console.WriteLine();

            }
        }
    }
    public static void LoginAttempt()
    {
        Random random = new Random();
        int OTP = random.Next(10000000, 99999999);
        Console.WriteLine($"OTP : {OTP}");
        Console.WriteLine("Enter the Password");
        int enteredNumber;
        int attempts = 3;
        for (int i = 0; i < 3; i++)
        {
            enteredNumber = Convert.ToInt32(Console.ReadLine());
            if (enteredNumber == OTP)
            {
                Console.WriteLine("Successful Process");
                break;
            }
            else
            {
                attempts--;
                if (attempts == 0)
                {
                    Console.WriteLine("Please try again; you have used up all attempts.");
                }
                else
                {
                    Console.WriteLine($"OTP code is not correct! New OTP: {OTP = random.Next(10000000, 99999999)}");
                    Console.WriteLine($"You left {attempts} chance");
                }
            }
        }
    }
}
