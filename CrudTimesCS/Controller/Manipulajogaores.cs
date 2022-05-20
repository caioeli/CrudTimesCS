
using System.Data.SqlClient;
using CrudTimesCS.Model;
using System.Windows.Forms;
using CrudTimesCS.View;
using System.Data;
using System;

namespace CrudTimesCS.Controller
{
    class Manipulajogaores
    {
        public void cadastrarjogador()
        {

            SqlConnection cnj = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmdj = new SqlCommand("pInserirjogadores", cnj);
            cmdj.CommandType = CommandType.StoredProcedure;


            try
            {

                cmdj.Parameters.AddWithValue("nomejogadores", jogadores.Nomejogadores);
                cmdj.Parameters.AddWithValue("emailjogadores", jogadores.Emailjogadores);
                cmdj.Parameters.AddWithValue("fonejogadores", jogadores.Fonejogadores);

                SqlParameter nvj = cmdj.Parameters.Add("@idjogadores", SqlDbType.Int);
                nvj.Direction = ParameterDirection.Output;

                cnj.Open();
                cmdj.ExecuteNonQuery();

                var resposta = MessageBox.Show("Seu cadastro efetuado com sucesso, deseja executar um novo cadastro ?", "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {

                    jogadores.Retorno = "sim";
                    return;

                }
                else
                {

                    jogadores.Retorno = "não";
                    return;

                }

            }

            catch (Exception)
            {
                throw;
            }


        }

        public void pesquisarjogadores()
        {
            SqlConnection cn = new SqlConnection(Controller.ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarcodigojogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@idjogadores", jogadores.Idjogadores);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();


                if (arrayDados.Read())
                {
                    
                    jogadores.Idjogadores = Convert.ToInt32(arrayDados["idjogadores"]);
                    jogadores.Nomejogadores = arrayDados["nomejogadores"].ToString();
                    jogadores.Emailjogadores = arrayDados["emailjogadores"].ToString();
                    jogadores.Fonejogadores = arrayDados["fonejogadores"].ToString();
                    jogadores.Retorno = "sim";
                }
                else
                {
                    MessageBox.Show("Código não é Válido", "Atencão!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    jogadores.Retorno = "Não";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
