using System;
namespace Array
{
	class Sumjaggedarr
	{
		public static void Main()
		{
			Console.Write("Enter size of row : ");
			int row=Convert.ToInt32(Console.ReadLine());
			int[][]arr=new int[row][];
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.Write("Enter size of {0} row's column : ",i+1);
				int col=Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("\nEnter value of array : \n");
			for(int i=0;i<arr.Length;i++)
			{
				arr [i]=new int[col];
				for(int j=0;j<arr.Length;j++)
				{
					Console.Write("arr[{0}][{1}] : ",i,j);
					arr[i][j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("Print value of array as a matrix : ");
			for(int i=0;i<arr.Length;i++)
			{
				for(int j=0;j<arr.Length;j++)
				{
					Console.Write(arr[i][j]+ "\t");
				}
				Console.Write("\n");
			}
			for(int i=0;i<arr.Length;i++)
			{
				int sum=0;
				for(int j=0;j<arr.Length;j++)
				{
					sum+=arr[i][j];
				}
				Console.Write("\n Sum of {0} row ={1} \n",i+1,sum);
			}
			Console.ReadLine();
		}
	}
}