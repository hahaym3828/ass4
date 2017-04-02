using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass4
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           // TaxTextBox.Text = (Double.Parse(PriceTextBox.Text) * 0.13).ToString();
          //  TotalTextBox.Text = (double.Parse(PriceTextBox.Text) + double.Parse(TaxTextBox.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox M = new MessageBox();
            M.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm P = new ProductInfoForm();
            P.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 A = new AboutBox1();
            A.Show();
        }
    }
}
