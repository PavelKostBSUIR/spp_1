using System;
using System.Windows.Forms;
using MyLib_1;
namespace SPP_1_final_version_with_graphics_
{
    public partial class Form1 : Form
    {
        String path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFile_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = openFileDialog.FileName;
            MessageBox.Show("Файл открыт");
        }

        private void SortFile_Click(object sender, EventArgs e)
        {
            if (path != null && path!="")
                Sort.MergeSort(path);
            MessageBox.Show("Файл отсортирован");
        }

        private void GenerateFile_Click(object sender, EventArgs e)
        {
            if(textBox.Text!=null && textBox.Text != "")
            {
                MyFile.generateFile("D://" + textBox.Text,0.1);
                MessageBox.Show("Файл сгенерирован");
            }
        }
    }
}
