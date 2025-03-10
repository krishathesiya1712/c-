using System;
class demo
{
	private string name;
	public string pr_nm
	{
		set
		{
			name=value;
		}
	}
	public void display()
	{
		//demo o=new demo;
		Console.WriteLine("name=" +name);
	}
}
class main_cls
{
	public static void Main()
	{
		demo obj=new demo();
		obj.pr_nm="Asha";
		obj.display();
	}
}