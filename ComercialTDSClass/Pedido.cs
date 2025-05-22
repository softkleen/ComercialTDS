using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente{ get; set; }
        public DateTime Data { get; set; }
        public string? Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Items { get; set; }
        public Pedido() { }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido( Usuario usuario, Cliente cliente)
        {
            Usuario = usuario;
            Cliente = cliente;
        }
        public Pedido(int id, string status, double desconto)
        {
            Id = id;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, 
            Cliente cliente, DateTime data, string? status, 
            double desconto, List<ItemPedido> items)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = items;
        }
        public void Inserir() 
        { 
        
        }
        public bool Atualizar()
        {
            return true;
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();

            return pedido;
        }
        public static List<Pedido> ObterLista()
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
    }
}
