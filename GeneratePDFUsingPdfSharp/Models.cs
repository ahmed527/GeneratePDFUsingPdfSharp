namespace GeneratePDFUsingPdfSharp
{
    public class ReportData
    {
        public string Title { get; set; } = string.Empty;
        public string GeneratedBy { get; set; } = string.Empty;
        public List<ReportItem> Items { get; set; } = new();
    }

    public class ReportItem
    {
        public string Id { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
    }
}
