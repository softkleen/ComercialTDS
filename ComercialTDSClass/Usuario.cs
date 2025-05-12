using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComercialTDSClass
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel? Nivel { get; set; }
        public bool Ativo { get; set; }
        public Usuario()
        { 
            Nivel = new(); // composição uml  
        }// construtor vazio
        public Usuario(int id, string? nome, string? email, string? senha, Nivel? nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuario(string? nome, string? email, string? senha, Nivel? nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuario(string? nome, string? email, string? senha, Nivel? nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            
        }
        public Usuario(int id, string? senha)
        {
            Id = id;
            Senha = senha;
        }
        public Usuario(int id, string? nome, string? senha, Nivel? nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsenha",Senha);
            cmd.Parameters.AddWithValue("spnivel",Nivel.Id);
        // usando if ternário, sem fechar conexão
            return cmd.ExecuteNonQuery() > 0 ? true : false;

        // usando if/else e fechando a conexão
            //if (cmd.ExecuteNonQuery() > 0)
            //{
            //    cmd.Connection.Close();
            //    return true;
            //}
            //else
            //    return false;
             
        }
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                usuario = new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        );
            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }
        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return usuarios;
        }
        public static Usuario EfatuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}') ";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        );
            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }
        public static bool AlterarSenha(string email, string senha)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set senha = md5('{senha}') where email = '{email}'";
            return cmd.ExecuteNonQuery()>0? true: false;
        }
    }
}
