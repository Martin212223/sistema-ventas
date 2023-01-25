using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("Jorge", "Perez", "perez68@email.com", "2615777777", "Santa Cruz 99", "20318888880");

            Vendedor vendedor = new Vendedor("Juan", "Pereyra", "juanp77@email.com", "2614333333", "Francia 45", "39987654");

            MessageBox.Show("Cliente (Individuo).\n\n-Nombre: " + clienteIndividuo.Nombre + "\n-Apellido: " + clienteIndividuo.Apellido + "\n-Email: " + clienteIndividuo.Email + "\n-Teléfono: " + clienteIndividuo.Telefono + "\n-Dirección: " + clienteIndividuo.Direccion + "\n-CUIT: " + clienteIndividuo.CUIT);

            MessageBox.Show("Vendedor:\n\n-Nombre: " + vendedor.Nombre + "\n-Apellido: " + vendedor.Apellido + "\n-Email: " + vendedor.Email + "\n-Teléfono: " + vendedor.Telefono + "\n-Dirección: " + vendedor.Direccion + "\n-DNI: " + vendedor.DNI);
        }

        private void btnCrearDocComercial_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito("123", new DateTime(2023, 01, 25), "Miguel López", "Cañadita Alegre 35", "Actual", "Efectivo", "Juego de baño", 12986.4m, new DateTime(2023, 01, 25));

            Factura factura = new Factura("123", new DateTime(2023, 01, 25), "Hernán Catalea", "Martínez de Rosas 675", "Actual", "Efectivo", "Juego de cocina", 12986.4m, "A");

            MessageBox.Show("Remito.\n\n-Cliente: " + remito.Cliente + "\n-Condición IVA: " + remito.CondicionIVA + "\n-Condición Venta: " + remito.CondicionVenta + "\n-Detalle: " + remito.Detalle + "\n-Dirección: " + remito.Direccion + "\n-Fecha: " + remito.Fecha.ToString() + "\n-Número: " + remito.Numero + "\n-Total: " + remito.Total.ToString() + "\n-Fecha de entrega: " + remito.FechaEntrega.ToString());

            MessageBox.Show("Factura.\n\n-Cliente: " + factura.Cliente + "\n-Condición IVA: " + factura.CondicionIVA + "\n-Condición Venta: " + factura.CondicionVenta + "\n-Detalle: " + factura.Detalle + "\n-Dirección: " + factura.Direccion + "\n-Fecha: " + factura.Fecha.ToString() + "\n-Número: " + factura.Numero + "\n-Total: " + factura.Total.ToString() + "\n-Fecha de entrega: " + factura.Tipo);
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa("Truchocs S.A.", "123412341", "Miguel", "truchocs@email.com", "2615444444", "Calle altamira 784");

            MessageBox.Show("Empresa.\n\n-Nombre: " + empresa.Nombre + "\n-CUIT: " + empresa.CUIT + "\n-Dirección: " + empresa.Direccion + "\n-Email: " + empresa.Email + "\n-Contacto: " + empresa.Contacto + "\n-Teléfono: " + empresa.Telefono);
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto("Galletas Truchocs", "Galletas con chispas de chocolate", 400.5m, 0.15, 0.21, "Arcor", "Alimentos", "Panadería");

            MessageBox.Show("Producto.\n\n-Nombre: " + producto.Nombre + "\n-Categoría: " + producto.Categoria + "\n-Subcategoría: " + producto.SubCategoria + "\n-Descripción: " + producto.Descripcion + "\n-IVA: " + (100 * producto.IVA).ToString() + "%\n-Márgen: " + (100 * producto.Margen).ToString() + "%\n-Precio bruto: $" + producto.PrecioBruto.ToString() + "\n-Precio costo: $" + producto.PrecioCosto.ToString() + "\n-Precio venta: $" + producto.PrecioVenta.ToString() + "\n-Proveedor: " + producto.Proveedor);
        }
    }
}
