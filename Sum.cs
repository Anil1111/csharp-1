class Sum
{
  static void Main(string[] args)
  {
    // 0"program to calculate sium
    // ints to hold the number and sum
    int num, sum = 0, r;
    Console.WriteLine("Enter a Number : ");
    num = int.Parse(Console.ReadLine());
    while (num != 0)
    {
      r = num % 10;
      num = num / 10;
      sum = sum + r;
    }
      Console.WriteLine("Sum of Digits of the Number : "+sum);
      Console.ReadLine();
    // end of the program 
  }
}
