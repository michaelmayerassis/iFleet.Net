using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace pim2.Models
{
    public class EmpresaDAO
    {
        public List<Empresa> ListarEmpresa()
        {
            List<Empresa> empresas = new List<Empresa>();
            MySqlConnection conn = new SqlConnection().Criar();
            MySqlCommand command = new MySqlCommand("SELECT * FROM empresa", conn);
            try
            {
                MySqlDataReader dr = command.ExecuteReader();
                empresas = convertDataReaderToList(dr);
            }
            finally
            {
                conn.Close();
            }
            return empresas;
        }

        public bool RetornarLogin(string email, string senha)
        {
            int registroExiste = 0;
            foreach (Empresa empresa in ListarEmpresa())
            {
                if (empresa.email == email && empresa.senha == senha)
                {
                    registroExiste = 1;
                }
            }

            return registroExiste == 1;
        }

        private List<Empresa> convertDataReaderToList(MySqlDataReader dreader)
        {
            List<Empresa> empresas = new List<Empresa>();
            while (dreader.Read())
            {
                Empresa emp = new Empresa()
                {
                    Id = Convert.ToInt32(dreader["Id"]),
                    email = dreader["email"].ToString(),
                    senha = dreader["senha"].ToString(),
                };
                empresas.Add(emp);
            }
            return empresas;
        }
    }

}
