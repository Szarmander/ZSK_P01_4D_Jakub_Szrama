using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projekt01UI
{
    public partial class Form1 : Form
    {
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
            string inputText = richTextBox1.Text;

            textBox1.Text = inputText.Length.ToString();

            textBox2.Text = Regex.IsMatch(inputText, ".*[a-zA-Z].*") ? "TAK" : "NIE";

            textBox3.Text = Regex.IsMatch(inputText, ".*[0-9].*") ? "TAK" : "NIE";

            textBox4.Text = Regex.IsMatch(inputText, ".*[@_!#$%^&*()<>?}{~:].*") ? "TAK" : "NIE";


        }
    }
}