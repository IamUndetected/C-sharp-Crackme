using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CrackmeByMiraii
{
    public partial class YouCrackedIt : Form
    {
        public YouCrackedIt()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCVPMhP_svSMDeUgk2zl307A");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/JustMiraii/");
            Process.Start("https://steamcommunity.com/id/LeMiraii");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/IamUndetected");
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":PepeHappy:");
        }

        private void YouCrackedIt_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! You got it :D I hope you keep learning", ":PepeFat:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://miraiis.great-site.net/");

            Process.Start("http://miraiis-chernobyl.great-site.net/");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want more?", "YES YOU DO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you so much!");
                Process.Start("https://www.youtube.com/watch?v=ZgVPe6j5gkU");
            }
            else
            {

            }
        }
    }
}
