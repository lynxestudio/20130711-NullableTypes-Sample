using System;
using System.Collections.Generic;
using Samples.Nullables;

string? readResult;
string menuSelection = "";
List<Invoice> collection = new List<Invoice>();
var inv1 = new Invoice 
{
                InvoiceID = 1,
                StartDate = new DateTime(1999,06,10),
                MeasureUnit = "Box"
};
var inv2 = new Invoice 
{
                InvoiceID = 2,
                StartDate = new DateTime(2012,06,06),
                TaxPercent = 13.00M
};
var inv3 = new Invoice 
{
    			InvoiceID = 3
};
collection.Add(inv1);
collection.Add(inv2);
collection.Add(inv3);

do
{
		Console.Clear();
		Console.WriteLine();
		Console.WriteLine(" +--------------------------------------------------------------+");
		Console.WriteLine(" | Welcome to the Nullable sample. Your main menu options are:  |");
		Console.WriteLine(" | 1. Add new invoice                                           |");
		Console.WriteLine(" | 2. Show data                                                 |");
		Console.WriteLine(" +--------------------------------------------------------------+");
		Console.Write("[ Enter your selection number (or type Exit to exit) ] ");
		readResult = Console.ReadLine();
		if (readResult != null)
		{
			menuSelection = readResult.ToLower();	
			if (menuSelection == "exit")
			break;
			//Begin
			switch(menuSelection)
			{
				case "1":
					Add();
				break;
				case "2":
					Show();
				break;
				default:
				break;
			}
			//End
		}
}while(menuSelection != "exit");

void Add()
{
	Console.WriteLine("Add new invoice...");
	var newInv = new Invoice();
	Console.Write("\t[ ID ]\t");
	string? sId = Console.ReadLine();
	Console.Write("\t[ Date (default:today)      ]\t");
	string? sDate = Console.ReadLine();
	Console.Write("\t[ U. Measure (default:NONE) ]\t");
	string? sMeasure = Console.ReadLine();
	Console.Write("\t[ Percent (default: 16%)    ]\t");
	string? sPercent = Console.ReadLine();
	
	int id = 0;
	DateTime dt = DateTime.Now;
	Decimal percent = 16.00M;
	if(!string.IsNullOrEmpty(sId))
		Int32.TryParse(sId, out id);
	if(!string.IsNullOrEmpty(sDate))
		DateTime.TryParse(sDate,out dt);
	if(!string.IsNullOrEmpty(sPercent))
		Decimal.TryParse(sPercent,out percent);
	if(string.IsNullOrEmpty(sMeasure))
		sMeasure = "NONE";
		
	newInv.InvoiceID = id;
	newInv.MeasureUnit = sMeasure;
	newInv.StartDate = dt;
	newInv.TaxPercent = percent;
	collection.Add(newInv);
	Console.WriteLine("Invoice added!");
	Console.WriteLine("Press any key to continue...");
	Console.ReadKey(true);
}

void Show()
{
	Console.WriteLine("Showing data...");
	 foreach (Invoice i in collection)
     {
            PrintInvoice(i);
     }
	 Console.WriteLine("Press any key to continue...");
	 Console.ReadKey(true);
}

static void PrintInvoice(Invoice invoice)
{
    Console.WriteLine("\tInvoiceID: {0}", invoice.InvoiceID);
    Console.WriteLine("\tStart Date: {0:dd/MM/yyyy}", invoice.StartDate ?? DateTime.Today);
    Console.WriteLine("\tMeasure Unit: {0}", invoice.MeasureUnit ?? "NONE");
    Console.WriteLine("\tTax percent: {0}", invoice.TaxPercent ?? 16.00M);
    Console.WriteLine("----------+-------------+---------");
}