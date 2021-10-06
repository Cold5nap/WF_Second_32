using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Second_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                    {
                        InputTextBox.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        private void NewLineButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = Article.getArticle(InputTextBox.Text);
        }
    }
}
