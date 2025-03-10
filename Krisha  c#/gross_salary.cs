using System;
class gross
{
	public void display(ref double basic,out double gross)
	{
		double TA,DA,HRA,PF;
		if(basic>=35000 && basic<=45000)
		{
			TA=(basic*5)/100;
			//Console.WriteLine("TA=",+TA);
			DA=(basic*5)/100;
			HRA=(basic*15)/100;
			PF=(basic*8.5)/100;
			gross=(basic+TA+DA+HRA)-PF;
			Console.WriteLine("TA="+TA);
			Console.WriteLine("DA="+DA);
			Console.WriteLine("HRA="+HRA);
			Console.WriteLine("PF="+PF);
		}
		else if(basic<35000)
		{
			TA=(basic*9)/100;
			DA=(basic*12)/100;
			HRA=(basic*20)/100;
			PF=(basic*8.5)/100;
			gross=(basic+TA+DA+HRA)-PF;
			Console.WriteLine("TA="+TA);
			Console.WriteLine("DA="+DA);
			Console.WriteLine("HRA="+HRA);
			Console.WriteLine("PF="+PF);
		}
		else
		{
			Console.WriteLine("Inavlid Salary... ");
			gross=0;
		}
	}
}
class main_class
{
	public static void Main()
	{
		Console.Write("Enter Your Salary= ");
		double b_salary=Convert.ToInt32(Console.ReadLine());
		double g_salary;
		gross obj=new gross();
		obj.display(ref b_salary,out g_salary);
		Console.WriteLine(" Gross salary=" +g_salary);
		
	}
}