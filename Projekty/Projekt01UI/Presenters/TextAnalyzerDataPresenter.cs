using projekt01.Core.Services;
using projekt01.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt01UI.Presenters
{
    internal class TextAnalyzerDataPresenter
    {

        private TextBox _tb_Length;
        private TextBox _tb_Letters;
        private TextBox _tb_Digits;
        private TextBox _tb_Special;
        private TextBox _tb_Time;

        private ITextAnalyzerService _textAnalyzerService;


        public TextAnalyzerDataPresenter(TextBox textLengthPresenter, TextBox hasLettersPresenter, TextBox hasDigitsPresenter, TextBox hasSpecialCharsPresenter, TextBox timePresenter) {
            _tb_Length = textLengthPresenter;
            _tb_Letters = hasLettersPresenter;
            _tb_Digits = hasDigitsPresenter;
            _tb_Special = hasSpecialCharsPresenter;
            _tb_Time = timePresenter;

            _textAnalyzerService = new TextAnalyzerService();

        }

        public void PerformTextAnalysis(string text)
        {
            // przeprowadzenie analizy
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = _textAnalyzerService.PerformAnalysis(text);
            sw.Stop();

            // drukowanie wyników
            _tb_Length.Text = result.textLength.ToString();
            _tb_Letters.Text = result.hasLetters ? "TAK" : "NIE";
            _tb_Digits.Text = result.hasDigits ? "TAK" : "NIE";
            _tb_Special.Text = result.hasSpecialChars ? "TAK" : "NIE";
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();
        }

    }
}
