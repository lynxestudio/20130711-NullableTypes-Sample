using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCoalescing
{
    public class Invoice
    {
        public int InvoiceID { set; get; }
        public DateTime? StartDate { set; get; }
        public string MeasureUnit { set; get; }
        public Decimal? TaxPercent { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
                Invoice[] invoices = { new Invoice {
                InvoiceID = 1,
                StartDate = new DateTime(1999,06,10),
                MeasureUnit = "Box"
                },
                new Invoice {
                InvoiceID = 2,
                StartDate = new DateTime(2012,06,06),
                TaxPercent = 13.00M
                },
                new Invoice {
                        InvoiceID = 3
                    }
                };

                foreach (Invoice i in invoices)
                {
                    PrintInvoice(i);
                }
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
        }

        static void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine("InvoiceID: {0}", invoice.InvoiceID);
            Console.WriteLine("Start Date: {0}", invoice.StartDate ?? DateTime.Today);
            Console.WriteLine("Measure Unit: {0}", invoice.MeasureUnit ?? "NONE");
            Console.WriteLine("Tax percent: {0}", invoice.TaxPercent ?? 16.00M);
            Console.WriteLine("----+----------+-----");
        }

    }

}