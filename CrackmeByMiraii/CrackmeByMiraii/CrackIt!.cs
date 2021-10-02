using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackmeByMiraii
{
    public partial class CrackmeByMiraii : Form
    {
        public CrackmeByMiraii()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CrackmeByMiraii_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Have Fun with this crackme btw Password is 123");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "CrackedByYou?" && txtPass.Text == @"6?JWE\$p;ud27wH@" && txtLic.Text == "crmnl-CrackingIsFunJustEzForYou:D")

            {
                MessageBox.Show("WOW! You cracked it :D this one was ez but keep learning");

                YouCrackedIt Cracked = new YouCrackedIt();

                Cracked.Show();

                this.Hide();
            }
        }
    }
}