using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp19.Models
{
    public static class Dados
    {
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static List<Cliente> TodosOsClientes()
        {
            return LISTA_CLIENTES;
        }

        public static void AdicionarCliente(Cliente cliente)
        {

            int id = 0;

            if (LISTA_CLIENTES.Count() != 0)
                id = LISTA_CLIENTES.Last<Cliente>().Id + 1;

            cliente.Id = id;

            LISTA_CLIENTES.Add(cliente);

        }

        public static Cliente DadosCliente(int id)
        {
            return LISTA_CLIENTES.Where(i => i.Id == id).FirstOrDefault();
        }

        public static void EditarCliente(Cliente c)
        {
            LISTA_CLIENTES.First<Cliente>(i => i.Id == c.Id).Nome = c.Nome;
            LISTA_CLIENTES.First<Cliente>(i => i.Id == c.Id).Telefone = c.Telefone;
        }

        public static void EliminarCliente(int id)
        {
            Cliente c = LISTA_CLIENTES.First<Cliente>(i => i.Id == id);
            LISTA_CLIENTES.Remove(c);
        }
    }
}
