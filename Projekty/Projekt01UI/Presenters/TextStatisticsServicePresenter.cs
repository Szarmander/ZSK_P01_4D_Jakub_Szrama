using projekt01.Shared.Entities;
using projekt01.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projekt01.Core.Services
{

    public class TextStatisticsServicePresenter
    {
        private RichTextBox _tb_Statistics;
        private TextBox _tb_AllSymbolCount;
        private TextBox _tb_UniqueSymbolCount;
        private TextBox _tb_Entropy;
        private TextBox _tb_Time;

        private TextStatisticsService _statisticsService;

        public TextStatisticsServicePresenter(RichTextBox statiscticsPresenter, TextBox allSymbolCountPresenter, TextBox uniqueSymbolCountPresenter, TextBox entropyPresenter, TextBox timePresenter) 
        {
            _tb_Statistics = statiscticsPresenter;
            _tb_AllSymbolCount = allSymbolCountPresenter;
            _tb_UniqueSymbolCount = uniqueSymbolCountPresenter;
            _tb_Entropy = entropyPresenter;
            _tb_Time = timePresenter;

            _statisticsService = new TextStatisticsService();
        }

        public void PerformTextStatistics(string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var countedStatistics = _statisticsService.CountStatistics(text);
            var result = _statisticsService.FillPrintingData(countedStatistics);
            sw.Stop();

            StringBuilder sb = new StringBuilder();
            string mask = "{0}|{1}|{2}|{3}|{4}|{5}";
            int colWidth = 25;
            sb.AppendLine(string.Format(mask,
                    "Zapis binarny".PadRight(colWidth, ' '),
                    "Zapis dziesiętny".PadRight(colWidth, ' '),
                    "Symbol".PadRight(colWidth, ' '),
                    "Częstość".PadRight(colWidth, ' '),
                    "Prawdopodobieństwo".PadRight(colWidth, ' '),
                    "Ilość informacji".PadRight(colWidth, ' ')));

            foreach ( var item in result.SymbolStatistics ) 
            {
                sb.AppendLine(string.Format(mask,
                   item.BinaryNotation?.PadRight(colWidth, ' '),
                   item.DecimalNotation?.ToString().PadRight(colWidth, ' '),
                   item.Symbol?.PadRight(colWidth, ' '),
                   item.Frequency?.ToString().PadRight(colWidth, ' '),
                   item.Probability?.ToString().PadRight(colWidth, ' '),
                   item.InformationQuantity?.ToString().PadRight(colWidth, ' ')));
            }
            _tb_Statistics.Text = sb.ToString();
            _tb_AllSymbolCount.Text = result.AllSymbolCount.ToString();
            _tb_UniqueSymbolCount.Text = result.UniqueSymbolCount.ToString();
            _tb_Entropy.Text = result.Entropy.ToString();
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();

        }

    }
}
