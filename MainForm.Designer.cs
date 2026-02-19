namespace Tienda
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView tablaInventario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tablaInventario = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).BeginInit();
            this.SuspendLayout();

            // Titulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Size = new System.Drawing.Size(300, 35);
            this.lblTitulo.Text = "SISTEMA DE INVENTARIO";

            // Buscador
            this.txtBuscar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtBuscar.Location = new System.Drawing.Point(372, 15);
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.PlaceholderText = "🔍 Buscar...";

            // Inputs
            this.txtNombre.Location = new System.Drawing.Point(15, 60);
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.PlaceholderText = "Nombre";

            this.txtPrecio.Location = new System.Drawing.Point(175, 60);
            this.txtPrecio.Size = new System.Drawing.Size(80, 23);
            this.txtPrecio.PlaceholderText = "Precio";

            this.txtStock.Location = new System.Drawing.Point(265, 60);
            this.txtStock.Size = new System.Drawing.Size(60, 23);
            this.txtStock.PlaceholderText = "Stock";

            // Botones
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.FlatStyle = FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(335, 57);
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.Text = "Añadir";

            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.FlatStyle = FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(415, 57);
            this.btnModificar.Size = new System.Drawing.Size(75, 30);
            this.btnModificar.Text = "Editar";

            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(495, 57);
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.Text = "Borrar";

            // Tabla (Responsiva)
            this.tablaInventario.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tablaInventario.BackgroundColor = System.Drawing.Color.White;
            this.tablaInventario.Location = new System.Drawing.Point(15, 100);
            this.tablaInventario.Size = new System.Drawing.Size(555, 250);
            this.tablaInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Total
            this.lblTotal.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(12, 360);
            this.lblTotal.Size = new System.Drawing.Size(400, 25);
            this.lblTotal.Text = "Total: $0.00";

            // Ventana
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.MinimumSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tablaInventario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MainForm";
            this.Text = "Gestor de Tienda Pro";
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}