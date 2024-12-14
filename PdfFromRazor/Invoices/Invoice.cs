namespace PdfFromRazor.Invoices;

public class Invoice
{
    public string InvoiceNumber { get; set; }  
    public DateTime InvoiceDate { get; set; }  
    public string CustomerName { get; set; } 
    public string CustomerAddress { get; set; } 
    public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
    public decimal Subtotal => Items.Sum(i => i.Total);
    public decimal Tax => Subtotal * 0.07m;
    public decimal Total => Subtotal + Tax;
}
