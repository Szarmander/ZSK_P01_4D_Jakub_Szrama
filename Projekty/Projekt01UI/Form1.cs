using projekt01.Core.Services;
using projekt01.Shared.Entities;
using Projekt01UI.Presenters;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt01UI
{
    public partial class Form1 : Form
    {
        private TextAnalyzerDataPresenter textAnalyzerDataPresenter;
        private TextStatisticsServicePresenter textStatisticsServicePresenter;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textAnalyzerDataPresenter.PerformTextAnalysis(richTextBox1.Text);
            openFileDialog1.InitialDirectory = @"./";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string linieTekstu = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = linieTekstu;
                textStatisticsServicePresenter.PerformTextStatistics(linieTekstu);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox3, , textBox5);
            textStatisticsServicePresenter = new TextStatisticsServicePresenter(richTextBox2, textBox1, textBox2, textBox3, textBox5);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}