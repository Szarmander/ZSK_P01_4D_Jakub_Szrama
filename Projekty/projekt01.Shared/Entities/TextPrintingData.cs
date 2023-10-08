namespace projekt01.Shared.Entities
{
    public class TextPrintingData
    {
        public string? AllSymbolCount { get; set; }

        public string? UniqueSymbolCount { get; set; }

        public string? Entropy { get; set; }

        public List<SymbolPrintingData>? SymbolStatistics { get; set; }
    }
}
