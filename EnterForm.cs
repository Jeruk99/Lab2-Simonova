using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PonomarevLab2
{
    public partial class EnterForm : Form
    {
        int n;
        public int[] parsed;
        public EnterForm(string text,int n)
        {
            InitializeComponent();
            Label.Text = text;
            this.n = n;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var parsed_temp = textBox.Text.Split().Where(a => Int32.TryParse(a, out _)).Select(a => int.Parse(a));
            if (n!=0 && textBox.Text.Split().Length == n && parsed_temp.Count() == n || n == 0 && textBox.Text.Split().Length == parsed_temp.Count())
            {
                parsed = parsed_temp.ToArray();
                this.Close();
            }
            else
                MessageBox.Show("Некорректный ввод, повторите");
        }
    }
}
