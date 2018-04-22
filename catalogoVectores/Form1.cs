using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalogoVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Registro catalogoAutos = new Registro();
        Auto CarroDatos;

        private void button1_Click(object sender, EventArgs e)
        {
            string Placa = txtPlacas.Text;
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            string Año = txtAño.Text;
            string Telefono = txtTelefono.Text;
            CarroDatos=new Auto(Placa,Marca,Modelo,Año,Telefono);
            catalogoAutos.Agregar(CarroDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(txtPosicion.Text);
            catalogoAutos.eliminar(posicion);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string Placa = Convert.ToString(txtPlacas.Text);
            string Marca = Convert.ToString(txtMarca.Text);
            string Modelo = Convert.ToString(txtModelo.Text);
            string Telefono = Convert.ToString(txtTelefono.Text);
            string Año =Convert.ToString(txtAño.Text);
            int posicion =Convert.ToUInt16(txtPosicion.Text);
            CarroDatos=new Auto(Placa, Marca, Modelo, Año, Telefono);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = catalogoAutos.listar().ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = Convert.ToString(txtPlacas.Text);
            catalogoAutos.Buscar(placa);
        }
    }
}
