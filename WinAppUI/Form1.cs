using ClassLibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAdd_Click(object sender, EventArgs e)
        {
            RekenMachine rekenMachine = new RekenMachine();
            int result = rekenMachine.Add(int.Parse(txtFirstNr.Text), int.Parse(txtSecondNr.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalculateSub_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateDiv_Click(object sender, EventArgs e)
        {
            RekenMachine rekenMachine = new RekenMachine();
            int result = rekenMachine.Div(int.Parse(txtFirstNr.Text), int.Parse(txtSecondNr.Text));
            lblResult.Text = result.ToString(); 
        }
    }
}
