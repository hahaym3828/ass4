using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass4
{
    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            Thread s = new Thread(new ThreadStart(SForm));
            s.Start();
            Thread.Sleep(1000);
            s.Abort();
            InitializeComponent();
        }
        public void SForm()
        {
            Application.Run(new SplashForm());
        }
        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm S = new SelectForm();
            S.Show();
            this.Hide();
        }
    }
}
