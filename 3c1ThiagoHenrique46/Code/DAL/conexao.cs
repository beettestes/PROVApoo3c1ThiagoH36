using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3c1ThiagoHenrique46.Code.DAL
{
    class conexao
    {
        MySqlConnection conexaocrud;

        public void Conectar()
        {
            try
            {
                string comando = "Persist Security Info = false; " +
                    "server = localhost; " +
                    "database = provapoo; " +
                    "uid = root; pwd=";

                conexaocrud = new MySqlConnection(comando);
                conexaocrud.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        public void Exe(string sql)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, conexaocrud);
            comando.ExecuteNonQuery();

        }

        public DataTable consulta(string sql)
        {
            Conectar();
            MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexaocrud);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            return dt;
        }
    }
}
