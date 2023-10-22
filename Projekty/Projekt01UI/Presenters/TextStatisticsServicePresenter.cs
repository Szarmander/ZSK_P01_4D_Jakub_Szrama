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

            List<string> names = new List<string>();
            names.Add("Zapis binarny");
            names.Add("Zapis dziesiętny");
            names.Add("Symbol");
            names.Add("Częstość");
            names.Add("Prawdopodobieństwo");
            names.Add("Ilość informacji");


            _tb_Statistics.Text = string.Format("{0}| {1}| {2}| {3}| {4}| {5}", names[0].PadRight(30), names[1].PadRight(30), names[2].PadRight(30), names[3].PadRight(30), names[4].PadRight(30), names[5].PadRight(30));

            foreach ( var item in result.SymbolStatistics ) 
            {
                _tb_Statistics.Text += string.Format("\n{0}| {1}| {2}| {3}| {4}| {5}", item.BinaryNotation.PadRight(30), item.DecimalNotation.PadRight(30), item.Symbol.PadRight(30), item.Frequency.PadRight(30), item.Probability.PadRight(30), item.InformationQuantity.PadRight(30));
            }

            _tb_AllSymbolCount.Text = result.AllSymbolCount.ToString();
            _tb_UniqueSymbolCount.Text = result.UniqueSymbolCount.ToString();
            _tb_Entropy.Text = result.Entropy.ToString();
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();

        }

    }
}
