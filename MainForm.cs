using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tienda.Modelos;

namespace Tienda
{
    public partial class MainForm : Form
    {
        BindingList<Producto> listaProductos = new BindingList<Producto>();
        string archivoDb = "inventario.txt";

        public MainForm()
        {
            InitializeComponent();
            tablaInventario.DataSource = listaProductos;
            ConfigurarEventos();
            CargarDatosDesdeArchivo();
            ActualizarTotal();
        }

        private void ConfigurarEventos()
        {
            btnAgregar.Click += BtnAgregar_Click;
            btnModificar.Click += BtnModificar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            tablaInventario.CellClick += TablaInventario_CellClick;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) return;
                listaProductos.Add(new Producto(txtNombre.Text, int.Parse(txtStock.Text), decimal.Parse(txtPrecio.Text)));
                FinalizarCambios("Producto agregado.");
            }
            catch { MessageBox.Show("Error en los datos. Revisa números y precios."); }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (tablaInventario.CurrentRow != null)
            {
                var p = (Producto)tablaInventario.CurrentRow.DataBoundItem;
                p.Nombre = txtNombre.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Stock = int.Parse(txtStock.Text);
                tablaInventario.Refresh();
                FinalizarCambios("Producto modificado.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaInventario.CurrentRow != null)
            {
                var p = (Producto)tablaInventario.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"¿Eliminar {p.Nombre}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listaProductos.Remove(p);
                    FinalizarCambios(null);
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string f = txtBuscar.Text.ToLower();
            var filtrados = listaProductos.Where(x => x.Nombre.ToLower().Contains(f)).ToList();
            tablaInventario.DataSource = string.IsNullOrEmpty(f) ? listaProductos : new BindingList<Producto>(filtrados);
        }

        private void TablaInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaInventario.CurrentRow != null)
            {
                var p = (Producto)tablaInventario.CurrentRow.DataBoundItem;
                txtNombre.Text = p.Nombre;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();
            }
        }

        private void FinalizarCambios(string msg)
        {
            GuardarDatosEnArchivo();
            ActualizarTotal();
            LimpiarCampos();
            if (msg != null) MessageBox.Show(msg);
        }

        private void ActualizarTotal()
        {
            decimal total = listaProductos.Sum(p => p.Precio * p.Stock);
            lblTotal.Text = $"Valor Total Inventario: {total:C2}";
        }

        private void LimpiarCampos() { txtNombre.Clear(); txtPrecio.Clear(); txtStock.Clear(); txtNombre.Focus(); }

        private void GuardarDatosEnArchivo()
        {
            using (StreamWriter sw = new StreamWriter(archivoDb))
                foreach (var p in listaProductos) sw.WriteLine($"{p.Nombre}|{p.Stock}|{p.Precio}");
        }

        private void CargarDatosDesdeArchivo()
        {
            if (!File.Exists(archivoDb)) return;
            foreach (var l in File.ReadAllLines(archivoDb))
            {
                var d = l.Split('|');
                if (d.Length == 3) listaProductos.Add(new Producto(d[0], int.Parse(d[1]), decimal.Parse(d[2])));
            }
        }
    }
}