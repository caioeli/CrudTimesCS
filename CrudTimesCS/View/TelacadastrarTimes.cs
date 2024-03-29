﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudTimesCS.Model;
using CrudTimesCS.Controller;
using System.IO;

namespace CrudTimesCS.View
{
    public partial class TelacadastrarTimes : Form
    {
        public TelacadastrarTimes()
        {
            InitializeComponent();
        }

        private void TelacadastrarTimes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if(textBoxtimesnome.Text =="" || textBoxfrasetimes.Text == "")
            {

                MessageBox.Show("Digite todas as informações","Atenção!!!",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
                return;

            }


            Time.Nometimes = textBoxtimesnome.Text;
            Time.Frasetimes = textBoxfrasetimes.Text;

            /* buscar imagem e salvar no banco de dados */

            MemoryStream memorylogo = new MemoryStream();
            pictureBoxlogo.Image.Save(memorylogo, pictureBoxlogo.Image.RawFormat);
            Time.Logotimes1 = memorylogo.ToArray();

            /* buscar imagem e salvar no banco de dados */
            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastrotimes();

            if(Time.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
            else
            {
                fecharcadastro();
                return;
            }

        }

        public void abrirCadastro()
        {
            this.ShowDialog();
        }

        public void fecharcadastro()
        {
            this.Close();
        }

        public void LimparTela()
        {
            foreach(Control ctl in this.Controls)
            {
                if( ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TelacadastrarTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                fecharcadastro();
            }    
        }

        private void buttonblogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha o seu logo (*.jpg; *.jpeg;*.png;) | *.jpg; *.jpeg;*.png;";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               pictureBoxlogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
