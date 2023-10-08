using projekt01.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt01.Core.Services
{
    public class BaseTextStatisticsServicePresenter : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {
            TextStatisticsData data = new TextStatisticsData();

            data.AllSymbolCount = text.Length;
            data.UniqueSymbolCount = text.Distinct().Count();
            data.Entropy = 4412412;

            return data;
            
        }
    }
}
