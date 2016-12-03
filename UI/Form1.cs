using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace UI
{
    public partial class Form1 : Form
    {
        IndexCtr indexCtr;

        public Form1()
        {
            InitializeComponent();
            indexCtr = new IndexCtr();
        }

        private void CreateIndexBtn_click(object sender, EventArgs e)
        {
            indexCtr.CreateIndex(textBox1.Text);
            textBox1.Clear();
        }

        private void DeleteIndexBtn_click(object sender, EventArgs e)
        {
            indexCtr.DeleteIndex(textBox1.Text);
            textBox1.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
