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
            SqlConnection cn = new SqlConnection(Controller.ConexãoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInseririrtimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("nometimes", Time.Nometimes);
                cmd.Parameters.AddWithValue("logotimes", Time.Logotimes);
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
    }
}
