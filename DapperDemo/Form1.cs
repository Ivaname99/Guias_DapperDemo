using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        CustomerRepository customerR = new CustomerRepository();
        private Customers CrearCliente()
        {
            var nuevo = new Customers
            {
                CustomerID = tbxCustomerID.Text,
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                ContactTitle = tbxContactTitle.Text,
                Address = tbxAddress.Text
            };
            return nuevo;
        }
        private void RellenarForm(Customers customers)
        {
            tbxCustomerID.Text = customers.CustomerID;
            tbxCompanyName.Text = customers.CompanyName;
            tbxContactName.Text = customers.ContactName;
            tbxContactTitle.Text = customers.ContactTitle;
            tbxAddress.Text = customers.Address;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodo();
            dgvCustomers.DataSource = cliente;
        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorId(tboxObtenerID.Text);
            dgvCustomers.DataSource = new List<Customers> { cliente };

            if (cliente != null)
            {
                RellenarForm(cliente);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertado = customerR.InsertarCliente(nuevoCliente);
            MessageBox.Show($"{insertado} registros insertados");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var clienteActualizado = CrearCliente();
            var actualizados = customerR.ActualizarCliente(clienteActualizado);
            MessageBox.Show($"{actualizados} filas actualizadas");
        }
    }
}
