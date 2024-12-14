namespace PdfFromRazor.Invoices;

public class InvoiceGenerator
{
    public static Invoice Generate()
    {
        var invoice = new Invoice
        {
            InvoiceNumber = "INV-123",
            InvoiceDate = DateTime.Now,
            CustomerName = "John Doe",
            CustomerAddress = "123 Main St, Springfield, IL 62701"
        };

        invoice.Items.Add(new InvoiceItem
        {
            Description = "Widget",
            Quantity = 2,
            Price = 10
        });

        invoice.Items.Add(new InvoiceItem
        {
            Description = "Gadget",
            Quantity = 1,
            Price = 20
        });

        return invoice;
    }
}
