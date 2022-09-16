using System.Data;
using System.Data.SqlClient;

namespace SOAPI.Models
{
    public class SQLServerDAO
    {
        SqlConnection? conexao;
        SqlCommand? comando;
        SqlDataAdapter? da;
        SqlDataReader? dr;

        string strSQL;
        List<Guest> lista;
        Guest gstVO;
        public void conectar()
        {
            conexao = new SqlConnection(@"Server=DESKTOP-O1RA564\SQLEXPRESS;Database=cadastro;Trusted_Connection=true;");
        }

        public string inserir(Guest guest)
        {
            try
            {
                conectar();
                strSQL = "INSERT INTO HOSPEDES (NOME, CPF, TELEFONE, EMAIL) VALUES (@NOME, @CPF,@TELEFONE,@EMAIL)"; 

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", guest.Nome);
                comando.Parameters.AddWithValue("@CPF", guest.Cpf);
                comando.Parameters.AddWithValue("@TELEFONE", guest.Telefone);
                comando.Parameters.AddWithValue("@EMAIL", guest.Email);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return "erro de conexao: " + ex.Message;
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                conexao = null;
                comando = null;
            }

            return "Hospede Cadastrado com Sucesso";
        }

        public List<Guest> getGuests()
        {

            lista = new List<Guest>();
            try
            {
                conectar();
                strSQL = "SELECT * FROM HOSPEDES";

                DataTable dados = new DataTable();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();
                da.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    gstVO = new Guest();
                    gstVO.Nome = linha.Field<string>(0);
                    gstVO.Cpf = linha.Field<string>(1);
                    gstVO.Telefone = linha.Field<string>(2).ToString();
                    gstVO.Email = linha.Field<string>(3);
                    lista.Add(gstVO);
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            return lista;
        }

        public Guest getGuest(string cpf)
        {
            gstVO = new Guest();
            try
            {
                conectar();
                strSQL = "SELECT * FROM HOSPEDES WHERE cpf = @CPF";

                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CPF", cpf);

                conexao.Open();
                dr = comando.ExecuteReader();

                dr.Read();
                gstVO.Nome = dr["NOME"].ToString();
                gstVO.Cpf = dr["CPF"].ToString();
                gstVO.Telefone = dr["TELEFONE"].ToString();
                gstVO.Email = dr["EMAIL"].ToString();

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            return gstVO;
        }

        public string updateGuest(Guest guest)
        {
            gstVO = new Guest();
            try
            {
                conectar();
                strSQL = "UPDATE HOSPEDES SET NOME = @NOME, TELEFONE = @TELEFONE,EMAIL = @EMAIL WHERE CPF = @CPF";



                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", guest.Nome);
                comando.Parameters.AddWithValue("@CPF", guest.Cpf);
                comando.Parameters.AddWithValue("@TELEFONE", guest.Telefone);
                comando.Parameters.AddWithValue("@EMAIL", guest.Email);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return "Erro ao atualizar: " + ex.Message;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            return "Cadastro de hóspede atualizado com sucesso";
        }

        public string Delete(string cpf)
        {
            try
            {
                conectar();
                strSQL = "DELETE FROM HOSPEDES WHERE CPF = @CPF";


                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CPF", cpf);

                conexao.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return "Falha ao deletar";
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            return "Sucesso ao deletar";
        }
    }
}
