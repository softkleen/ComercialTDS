using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }
        public Endereco(){ }

        public Endereco(int id, int clienteId, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(int clienteId, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        { // este construtor deve ser utilizado para inserir endereço
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static List<Endereco> ObterLista()
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(dr.GetInt32(0),
                            dr.GetInt32(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8),
                            dr.GetString(9)
                            )
                    );
            }
            return enderecos;
        }
        public static List<Endereco> ObterListaPorClienteId(int idCliente)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where cliente_id = {idCliente}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(dr.GetInt32(0),
                            dr.GetInt32(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8),
                            dr.GetString(9)
                            )
                    );
            }
            return enderecos;
        }
        public bool Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

    }
}
