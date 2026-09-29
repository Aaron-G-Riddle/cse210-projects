using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> nums = new List<float>();
        string input;
        float num;
        float sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            input = Console.ReadLine();
            num = float.Parse(input);
            nums.Add(num);
        } while (num != 0);
        float count = nums.Count;
        foreach (float part in nums)
            {
                sum = sum + part;
            }
        float mean = sum / (count - 1);
        float max = nums.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The mean is: {mean:F2}");
        Console.WriteLine($"The greatest value is: {max}");
    }
}