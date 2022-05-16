using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTimesCS.View
{
    public partial class TelaMenu : Form
    {
        private DialogResult telacadastrarTimes;

        public TelaMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelacadastrarTimes telacadastrar = new TelacadastrarTimes();
            telacadastrarTimes = telacadastrar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCasdastrarJogadores telaCasdastrar = new TelaCasdastrarJogadores();
            telaCasdastrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
