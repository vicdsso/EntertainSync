using EntertainSync.Models;
using Microsoft.Data.SqlClient; 
using System.Runtime.ConstrainedExecution;


namespace EntertainSync.Repositories.ADO.SQLServer
{

    public class HomeDAO
    {

        public List<Home> getAllEntertainment()
        {
            List<Home> adicionadas = new List<Home>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, titulo, link, linkImagem from adicionar;";

                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Home adicionar = new Home();

                        adicionar.Id = (int)dr["id"];
                        adicionar.Titulo = dr["titulo"].ToString();
                        adicionar.Link = dr["link"].ToString();
                        adicionar.LinkImagem = dr["linkImagem"].ToString();

                        adicionadas.Add(adicionar);
                    }
                }
            }

            return adicionadas;
        }



        private readonly string connectionString; 

        public HomeDAO(string connectionString) 
        {
            this.connectionString = connectionString; 
                }

        public List<Home> getAll() 
        {
            List<Home> adicionadas = new List<Home>();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {

                
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, titulo, link, linkImagem from adicionar;";

                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Home adicionar = new Home();

                        adicionar.Id = (int)dr["id"];
                        adicionar.Titulo = dr["titulo"].ToString();
                        adicionar.Link = dr["link"].ToString();
                        adicionar.LinkImagem = dr["linkimagem"].ToString();
                        

                        adicionadas.Add(adicionar);
                    }

                }

            }
            return adicionadas;
        }

        public Home getByIdAdicionar(int id) 
        {
            Home adicionar = new Home();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {

                
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, titulo, link, linkImagem from adicionar where id=@id;";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        adicionar.Id = (int)dr["id"];
                        adicionar.Titulo = dr["titulo"].ToString();
                        adicionar.Link = dr["link"].ToString();
                        adicionar.LinkImagem = dr["linkimagem"].ToString();

                    }
                }
            }
            return adicionar;
        }

        public void update(int id, Home adicionar)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
               
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update adicionar set titulo = @titulo, link, linkImagem = @link where id=@id;";
                    command.Parameters.Add(new SqlParameter("@titulo", System.Data.SqlDbType.VarChar)).Value = adicionar.Titulo;
                    command.Parameters.Add(new SqlParameter("@link", System.Data.SqlDbType.VarChar)).Value = adicionar.Link;
                    command.Parameters.Add(new SqlParameter("@linkImagem", System.Data.SqlDbType.VarChar)).Value = adicionar.LinkImagem;
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void add(Home adicionar)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                // Abrir conexão do banco de dados: 
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into adicionar (titulo, link, linkImagem) values (@titulo,@link, @linkImagem); select convert(int,@@identity) as id;;";

                    command.Parameters.Add(new SqlParameter("@titulo", System.Data.SqlDbType.VarChar)).Value = adicionar.Titulo;
                    command.Parameters.Add(new SqlParameter("@link", System.Data.SqlDbType.VarChar)).Value = adicionar.Link;
                    command.Parameters.Add(new SqlParameter("@linkImagem", System.Data.SqlDbType.VarChar)).Value = adicionar.LinkImagem;

                    adicionar.Id = (int)command.ExecuteScalar(); 
                        }
            }
        }

        public void delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                // Abrir conexão do banco de dados: 
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from adicionar where id = @id;";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
