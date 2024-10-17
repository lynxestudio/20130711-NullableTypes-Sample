
namespace Samples.Nullables;

public class Invoice
{
        public int InvoiceID { set; get; }
        public DateTime? StartDate { set; get; }
        public string? MeasureUnit { set; get; }
        public Decimal? TaxPercent { set; get; }
}