using projekt01.Shared.Entities;

namespace projekt01.Shared.Interfaces
{
    public interface ITextStatisticsService
    {
        TextStatisticsData CountStatistics(string text);

        TextPrintingData FillPrintingData(TextStatisticsData statistics);
    }
}
