using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class admClientes
    {
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            List<ClienteIndividuo> clientesIndividuos = new List<ClienteIndividuo>();

            return clientesIndividuos;
        }

        public static ClienteIndividuo ListarClienteIndividuo(string cuit)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();

            return clienteIndividuo;
        } 

        public static List<Empresa> ListarClienteEmpresa()
        {
            List<Empresa> empresas = new List<Empresa>();

            return empresas;
        }

        public static Empresa ListarClienteEmpresa(string cuit)
        {
            Empresa empresa = new Empresa();

            return empresa;
        }
    }
}
