using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }

        public static List<Endereco> ObterListaPorClienteId(int idCliente)
        {
            List<Endereco> enderecos = new();

            return enderecos;

        }
    }
}
