namespace PedidosChota
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnRegistrar = new Button();
            txtProducto = new TextBox();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            DgvPedidos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            BtnProcesar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 156);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(128, 255, 255);
            BtnRegistrar.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnRegistrar.Location = new Point(280, 105);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(81, 27);
            BtnRegistrar.TabIndex = 5;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click_1;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProducto.Location = new Point(28, 110);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(219, 22);
            txtProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(117, 16);
            label2.TabIndex = 2;
            label2.Text = "Producto Pedido:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCliente.Location = new Point(28, 44);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(219, 22);
            txtNombreCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(134, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente:";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(DgvPedidos);
            panel2.Location = new Point(12, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 183);
            panel2.TabIndex = 1;
            // 
            // DgvPedidos
            // 
            DgvPedidos.AllowUserToAddRows = false;
            DgvPedidos.AllowUserToDeleteRows = false;
            DgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Producto, Fecha });
            DgvPedidos.Location = new Point(3, 3);
            DgvPedidos.Name = "DgvPedidos";
            DgvPedidos.ReadOnly = true;
            DgvPedidos.Size = new Size(387, 177);
            DgvPedidos.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 40;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = Color.FromArgb(128, 255, 128);
            BtnProcesar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProcesar.Location = new Point(396, 24);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(75, 31);
            BtnProcesar.TabIndex = 3;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += BtnProcesar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Pedidos - Chota";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombreCliente;
        private Label label1;
        private Button BtnRegistrar;
        private TextBox txtProducto;
        private Label label2;
        private Panel panel2;
        private DataGridView DgvPedidos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Fecha;
        private Button BtnProcesar;
    }
}
