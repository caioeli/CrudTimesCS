using CrudTimesCS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudTimesCS.Controller;
using System.IO;

namespace CrudTimesCS.View
{
    public partial class Pesquisartime : Form
    {
        public Pesquisartime()
        {
            InitializeComponent();
        }

        private void textBoxcodigopes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonpescod_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxcodigopes.Text == "")
                {
                    MessageBox.Show("Digite um Codigo Válido");
                    return;
                }
                else
                {
                    Time.Codtimes = Convert.ToInt32(textBoxcodigopes.Text);
                }

                Time.Codtimes = Convert.ToInt32(textBoxcodigopes.Text);

                ManipulaTimes manipula = new ManipulaTimes();
                manipula.pesquisarcodigojogadores();

                
                    textBoxcodigores.Text = Time.Codtimes.ToString();
                    textBoxtimeres.Text = Time.Nometimes.ToString();
                    textBoxfraseres.Text = Time.Frasetimes.ToString();
                    MemoryStream ms = new MemoryStream((byte[])Time.Logotimes1);
                    pictureBoxlogores.Image = Image.FromStream(ms);
                

            }
            catch(Exception )
            {
                MessageBox.Show("Digite o código novamente");
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
