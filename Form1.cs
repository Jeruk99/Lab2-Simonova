using System;
using System.Windows.Forms;

namespace PonomarevLab2
{
    public partial class Main : Form
    {
        ListProcessing processing;

        public Main()
        {
            InitializeComponent();
            processing = new ListProcessing(null, listBox1);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processing.list == null)
            {
                processing.list = new SingleLinkedList();
                listBox1.Items.Clear();
                MessageBox.Show("Список создан");
            }
            else
                MessageBox.Show("Список уже создан");
        }
        
        private void вНачалоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.Prepend();
            }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
            
        }

        private void вКонецToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.Append();
            }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
        }

        private void вПроизвольнуюТочкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.Insert();
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Индекс превышает количество элементов"); }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
        }
        
        private void вНачалеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.DeleteFirst();
            }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
        }
        private void вКонцеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.DeleteLast();
            }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
        }

        private void вПроизвольнойТочкеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.Delete();
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Индекс превышает количество элементов"); }
            catch (NullReferenceException) { MessageBox.Show("Вы не создали список"); }
        }

        private void разрушениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                processing.Destroy();
            }
            catch (NullReferenceException) { MessageBox.Show("Список не создан"); }
        }

        private void обработкаСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                processing.FindSub();
            }
            catch (NullReferenceException) { MessageBox.Show("Один или оба списки Null"); }
        }
    }
}
