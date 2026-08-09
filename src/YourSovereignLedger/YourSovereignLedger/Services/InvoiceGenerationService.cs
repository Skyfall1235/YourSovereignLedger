using YourSovereignLedger.Data.Context;

namespace YourSovereignLedger.Services;

public class InvoiceGenerationService
{
    private readonly AppDBContext dbContext;
    private readonly EmailService emailService;
    private readonly PDFGenerationService pdfGenerationService;

    public async void GeneratePDFInvoice() { }
    public async void DownloadGeneratedInvoice() { }
    public async void SendEmailWithInvoice() { }
}
