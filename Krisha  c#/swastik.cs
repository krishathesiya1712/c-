using System;
class demo
{
	public static void Main()
	{
	Console.WriteLine("Enter Dot Number");
	double dot=Convert.ToInt32(Console.ReadLine());
	if(dot%2==0)
	{
		dot++;
		Console.WriteLine("You are enter invalid number so we can increment num" +dot);

	}
	else
	{
		Console.WriteLine("Enter Dot Number");

	}
	if(dot>=4)
	{
		double num=(dot/2)+0.5;
		for(int i=1;i<=dot;i++)
		{
			for(int j=1;j<=dot;j++)
			{
				if(i==num||j==num||(j==1&&i<=num)||(i==1&&j>=num)
					||(j==dot&&i>=num)||(i==dot&&j<=num))
						Console.Write("* ");
				else
					Console.Write("  ");
			}
			Console.WriteLine("");
		}
	}
	else
			Console.WriteLine("Invalid number");
	}
}