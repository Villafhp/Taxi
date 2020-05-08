using System;

public class PrinterWindows
{
	public virtual void Show()
	{
		Console.WriteLine("Sony display dimension : 10*11");
	}
	public virtual void Print()
	{
		Console.WriteLine("Sony Printer is Printing ...");
	}
}
public class Epson : PrinterWindows
{
	public override void Show()
	{
		Console.WriteLine("Epson display dimension : 10*11");
	}
	public override void Print()
	{
		Console.WriteLine("Epson Printer is Printing ...");
	}
	
}

public class Canon : PrinterWindows
{
	public override void Show()
	{
		Console.WriteLine("Canon display dimension : 9.5*12");
	}
	public override void Print()
	{
		Console.WriteLine("Canon Printer is Printing ...");
	}

}

public class LaserJet : PrinterWindows
{
	public override void Show()
	{
		Console.WriteLine("Laserjet display dimension : 12*12");
	}
	public override void Print()
	{
		Console.WriteLine("Laserjet Printer is Printing ...");
	}

}
class Program
    {
	static void Main(string[] args)
	{
		PrinterWindows printer;

		Console.WriteLine("Pilih Printer:");
		Console.WriteLine("1. Epson");
		Console.WriteLine("2. Canon");
		Console.WriteLine("3. LaserJet\n");

		Console.Write("Nomor Printer [1..3]: ");
		int nomorPrinter = Convert.ToInt32(Console.ReadLine());

		if (nomorPrinter == 1)
		{
			printer = new Epson();
		}
		else if (nomorPrinter == 2)
		{
			printer = new Canon();
		}
		else
		{
			printer = new LaserJet();
		}

		printer.Show();
		printer.Print();

	}
}
