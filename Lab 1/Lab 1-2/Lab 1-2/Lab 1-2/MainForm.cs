using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double Result;
        private void FourMethrodButton_Click(object sender, EventArgs e)
        {
            Methods method = new Methods();
            Result = method.FourMethod();
            MessageBox.Show("R= " + Convert.ToString(Result));
        }
    }
}
