using System;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.Model;
using System.Windows.Forms;
using CrudTimesCS.View;



namespace CrudTimesCS.Controller
{
    class ManipulaTimes
    {
        public void cadastrotimes()
        {
            SqlConnection cn = new SqlConnection(Controller.ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInseririrtimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("nometimes", Time.Nometimes);
                cmd.Parameters.AddWithValue("logotimes", Time.Logotimes1);
                cmd.Parameters.AddWithValue("frasetimes", Time.Frasetimes);

                SqlParameter nv = cmd.Parameters.Add("@codtimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Seu cadastro efetuado com sucesso, deseja executar um novo cadastro ?",
                    "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (resposta == DialogResult.Yes) 
                {

                    Time.Retorno = "sim";
                    return;
                }
                else
                {
                    Time.Retorno = "Não";
                    return;
                  
                }
            }

            catch(Exception)
            {
                throw;
            }


        }

        public void pesquisarcodigojogadores() 
        {
            SqlConnection cn = new SqlConnection(Controller.ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarCodigoTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", Time.Codtimes);
                cn.Open();

                    var arrayDados = cmd.ExecuteReader();

                if(arrayDados.Read())
                {
                    Time.Codtimes = Convert.ToInt32 (arrayDados["codtimes"]);
                    Time.Nometimes = arrayDados["nometimes"].ToString();
                    Time.Frasetimes = arrayDados["frasetimes"].ToString();
                    Time.Logotimes1 = (System.Array)arrayDados["logotimes"];
                    Time.Retorno = "sim";
                }
                else
                {
                    MessageBox.Show("Código não é Válido", "Atencão!!!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Time.Retorno = "Não";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }  

    }
}
