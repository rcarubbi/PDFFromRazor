namespace PdfFromRazor.Invoices;

public class InvoiceItem
{
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal Total => Price * Quantity;
}