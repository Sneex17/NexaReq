namespace CapaPresentacion.FormsSolicitudes
{
    partial class FormSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BuBuscarEmpleados = new Button();
            textbDepartamento = new TextBox();
            label4 = new Label();
            textbNombre = new TextBox();
            label3 = new Label();
            textbIdEmpleado = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            BuAplicarItbis = new Button();
            cbxSeleccionITBIS = new ComboBox();
            BuAgregar = new Button();
            textbSubTotal = new TextBox();
            label12 = new Label();
            textbCantidad = new TextBox();
            label9 = new Label();
            textbITBIS = new TextBox();
            label8 = new Label();
            BuBuscarProducto = new Button();
            textbPrecioUnit = new TextBox();
            label5 = new Label();
            textbProducto = new TextBox();
            label6 = new Label();
            textbIdProducto = new TextBox();
            label7 = new Label();
            dataViewDetalleItems = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCantidad = new DataGridViewTextBoxColumn();
            ITBIS = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Opcion = new DataGridViewButtonColumn();
            label10 = new Label();
            BuSolicitar = new Button();
            textbTotal = new TextBox();
            label11 = new Label();
            panelHeader.SuspendLayout();
            panelContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewDetalleItems).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Size = new Size(1017, 65);
            // 
            // panelContext
            // 
            panelContext.Controls.Add(textbTotal);
            panelContext.Controls.Add(label11);
            panelContext.Controls.Add(BuSolicitar);
            panelContext.Controls.Add(label10);
            panelContext.Controls.Add(dataViewDetalleItems);
            panelContext.Controls.Add(groupBox2);
            panelContext.Controls.Add(groupBox1);
            panelContext.Margin = new Padding(3, 2, 3, 2);
            panelContext.Size = new Size(1017, 699);
            panelContext.Controls.SetChildIndex(groupBox1, 0);
            panelContext.Controls.SetChildIndex(groupBox2, 0);
            panelContext.Controls.SetChildIndex(dataViewDetalleItems, 0);
            panelContext.Controls.SetChildIndex(label10, 0);
            panelContext.Controls.SetChildIndex(BuSolicitar, 0);
            panelContext.Controls.SetChildIndex(label11, 0);
            panelContext.Controls.SetChildIndex(textbTotal, 0);
            panelContext.Controls.SetChildIndex(BuCerrarVentana, 0);
            // 
            // label1
            // 
            label1.Location = new Point(99, 17);
            label1.Size = new Size(242, 31);
            label1.Text = "Solicitud de Compras";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Size = new Size(58, 38);
            // 
            // BuCerrarVentana
            // 
            BuCerrarVentana.Click += BuCerrarVentana_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(BuBuscarEmpleados);
            groupBox1.Controls.Add(textbDepartamento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textbIdEmpleado);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // BuBuscarEmpleados
            // 
            BuBuscarEmpleados.BackColor = Color.FromArgb(16, 40, 99);
            BuBuscarEmpleados.Cursor = Cursors.Hand;
            BuBuscarEmpleados.FlatStyle = FlatStyle.Popup;
            BuBuscarEmpleados.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuBuscarEmpleados.ForeColor = Color.White;
            BuBuscarEmpleados.Location = new Point(760, 24);
            BuBuscarEmpleados.Name = "BuBuscarEmpleados";
            BuBuscarEmpleados.Size = new Size(75, 47);
            BuBuscarEmpleados.TabIndex = 6;
            BuBuscarEmpleados.Text = "Buscar";
            BuBuscarEmpleados.UseVisualStyleBackColor = false;
            BuBuscarEmpleados.Click += BuBuscarEmpleados_Click;
            // 
            // textbDepartamento
            // 
            textbDepartamento.BorderStyle = BorderStyle.FixedSingle;
            textbDepartamento.Enabled = false;
            textbDepartamento.Location = new Point(318, 52);
            textbDepartamento.Name = "textbDepartamento";
            textbDepartamento.Size = new Size(140, 27);
            textbDepartamento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 29);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 4;
            label4.Text = "Departamento";
            // 
            // textbNombre
            // 
            textbNombre.BorderStyle = BorderStyle.FixedSingle;
            textbNombre.Enabled = false;
            textbNombre.Location = new Point(127, 52);
            textbNombre.Name = "textbNombre";
            textbNombre.Size = new Size(170, 27);
            textbNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 29);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // textbIdEmpleado
            // 
            textbIdEmpleado.BorderStyle = BorderStyle.FixedSingle;
            textbIdEmpleado.Enabled = false;
            textbIdEmpleado.Location = new Point(20, 52);
            textbIdEmpleado.Name = "textbIdEmpleado";
            textbIdEmpleado.Size = new Size(90, 27);
            textbIdEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 0;
            label2.Text = "Id Empleado";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(BuAplicarItbis);
            groupBox2.Controls.Add(cbxSeleccionITBIS);
            groupBox2.Controls.Add(BuAgregar);
            groupBox2.Controls.Add(textbSubTotal);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textbCantidad);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textbITBIS);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(BuBuscarProducto);
            groupBox2.Controls.Add(textbPrecioUnit);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textbProducto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textbIdProducto);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(20, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(850, 137);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de los Productos";
            // 
            // BuAplicarItbis
            // 
            BuAplicarItbis.BackColor = Color.FromArgb(16, 40, 99);
            BuAplicarItbis.Cursor = Cursors.Hand;
            BuAplicarItbis.FlatStyle = FlatStyle.Popup;
            BuAplicarItbis.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuAplicarItbis.ForeColor = Color.White;
            BuAplicarItbis.Location = new Point(134, 99);
            BuAplicarItbis.Name = "BuAplicarItbis";
            BuAplicarItbis.Size = new Size(91, 28);
            BuAplicarItbis.TabIndex = 15;
            BuAplicarItbis.Text = "Aplicar";
            BuAplicarItbis.UseVisualStyleBackColor = false;
            BuAplicarItbis.Click += BuAplicarItbis_Click;
            // 
            // cbxSeleccionITBIS
            // 
            cbxSeleccionITBIS.FormattingEnabled = true;
            cbxSeleccionITBIS.Location = new Point(16, 98);
            cbxSeleccionITBIS.Name = "cbxSeleccionITBIS";
            cbxSeleccionITBIS.Size = new Size(112, 28);
            cbxSeleccionITBIS.TabIndex = 14;
            cbxSeleccionITBIS.Text = "Elegir itbis";
            // 
            // BuAgregar
            // 
            BuAgregar.BackColor = Color.FromArgb(16, 40, 99);
            BuAgregar.Cursor = Cursors.Hand;
            BuAgregar.FlatStyle = FlatStyle.Popup;
            BuAgregar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuAgregar.ForeColor = Color.White;
            BuAgregar.Location = new Point(760, 76);
            BuAgregar.Name = "BuAgregar";
            BuAgregar.Size = new Size(75, 47);
            BuAgregar.TabIndex = 13;
            BuAgregar.Text = "+";
            BuAgregar.UseVisualStyleBackColor = false;
            BuAgregar.Click += BuAgregar_Click;
            // 
            // textbSubTotal
            // 
            textbSubTotal.BorderStyle = BorderStyle.FixedSingle;
            textbSubTotal.Enabled = false;
            textbSubTotal.Location = new Point(634, 54);
            textbSubTotal.Name = "textbSubTotal";
            textbSubTotal.Size = new Size(91, 27);
            textbSubTotal.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(634, 31);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 11;
            label12.Text = "Subtotal";
            // 
            // textbCantidad
            // 
            textbCantidad.BorderStyle = BorderStyle.FixedSingle;
            textbCantidad.Location = new Point(527, 54);
            textbCantidad.Name = "textbCantidad";
            textbCantidad.Size = new Size(91, 27);
            textbCantidad.TabIndex = 10;
            textbCantidad.TextChanged += textbCantidad_TextChanged;
            textbCantidad.KeyPress += textbCantidad_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(527, 31);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 9;
            label9.Text = "Cantidad";
            // 
            // textbITBIS
            // 
            textbITBIS.BorderStyle = BorderStyle.FixedSingle;
            textbITBIS.Enabled = false;
            textbITBIS.Location = new Point(421, 54);
            textbITBIS.Name = "textbITBIS";
            textbITBIS.Size = new Size(86, 27);
            textbITBIS.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(421, 31);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "ITBIS";
            // 
            // BuBuscarProducto
            // 
            BuBuscarProducto.BackColor = Color.FromArgb(16, 40, 99);
            BuBuscarProducto.Cursor = Cursors.Hand;
            BuBuscarProducto.FlatStyle = FlatStyle.Popup;
            BuBuscarProducto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuBuscarProducto.ForeColor = Color.White;
            BuBuscarProducto.Location = new Point(760, 18);
            BuBuscarProducto.Name = "BuBuscarProducto";
            BuBuscarProducto.Size = new Size(75, 47);
            BuBuscarProducto.TabIndex = 6;
            BuBuscarProducto.Text = "Buscar";
            BuBuscarProducto.UseVisualStyleBackColor = false;
            BuBuscarProducto.Click += BuBuscarProducto_Click;
            // 
            // textbPrecioUnit
            // 
            textbPrecioUnit.BorderStyle = BorderStyle.FixedSingle;
            textbPrecioUnit.Enabled = false;
            textbPrecioUnit.Location = new Point(315, 54);
            textbPrecioUnit.Name = "textbPrecioUnit";
            textbPrecioUnit.Size = new Size(90, 27);
            textbPrecioUnit.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 31);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // textbProducto
            // 
            textbProducto.BorderStyle = BorderStyle.FixedSingle;
            textbProducto.Enabled = false;
            textbProducto.Location = new Point(124, 54);
            textbProducto.Name = "textbProducto";
            textbProducto.Size = new Size(170, 27);
            textbProducto.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 31);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Nombre";
            // 
            // textbIdProducto
            // 
            textbIdProducto.BorderStyle = BorderStyle.FixedSingle;
            textbIdProducto.Enabled = false;
            textbIdProducto.Location = new Point(17, 54);
            textbIdProducto.Name = "textbIdProducto";
            textbIdProducto.Size = new Size(90, 27);
            textbIdProducto.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 31);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 0;
            label7.Text = "Id Producto";
            // 
            // dataViewDetalleItems
            // 
            dataViewDetalleItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewDetalleItems.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, PrecioCantidad, ITBIS, SubTotal, Opcion });
            dataViewDetalleItems.Location = new Point(20, 287);
            dataViewDetalleItems.Name = "dataViewDetalleItems";
            dataViewDetalleItems.RowHeadersWidth = 51;
            dataViewDetalleItems.Size = new Size(850, 195);
            dataViewDetalleItems.TabIndex = 8;
            dataViewDetalleItems.CellClick += dataViewDetalleItems_CellClick;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioCantidad
            // 
            PrecioCantidad.HeaderText = "PrecioCantidad";
            PrecioCantidad.Name = "PrecioCantidad";
            // 
            // ITBIS
            // 
            ITBIS.HeaderText = "ITBIS";
            ITBIS.Name = "ITBIS";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // Opcion
            // 
            Opcion.HeaderText = "Opcion";
            Opcion.Name = "Opcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(20, 259);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 11;
            label10.Text = "Detalle de los Productos";
            // 
            // BuSolicitar
            // 
            BuSolicitar.BackColor = Color.FromArgb(44, 206, 117);
            BuSolicitar.Cursor = Cursors.Hand;
            BuSolicitar.FlatStyle = FlatStyle.Popup;
            BuSolicitar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuSolicitar.ForeColor = Color.FromArgb(16, 40, 99);
            BuSolicitar.Location = new Point(764, 499);
            BuSolicitar.Name = "BuSolicitar";
            BuSolicitar.Size = new Size(106, 47);
            BuSolicitar.TabIndex = 7;
            BuSolicitar.Text = "Solicitar";
            BuSolicitar.UseVisualStyleBackColor = false;
            BuSolicitar.Click += BuSolicitar_Click;
            // 
            // textbTotal
            // 
            textbTotal.BorderStyle = BorderStyle.FixedSingle;
            textbTotal.Enabled = false;
            textbTotal.Font = new Font("Segoe UI", 11F);
            textbTotal.Location = new Point(639, 519);
            textbTotal.Name = "textbTotal";
            textbTotal.Size = new Size(106, 27);
            textbTotal.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(639, 496);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 11;
            label11.Text = "Total";
            // 
            // FormSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 764);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1017, 881);
            MinimumSize = new Size(1017, 764);
            Name = "FormSolicitud";
            Text = "FormSolicitud";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContext.ResumeLayout(false);
            panelContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewDetalleItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textbNombre;
        private Label label3;
        private TextBox textbIdEmpleado;
        private Label label2;
        private GroupBox groupBox2;
        private Button BuBuscarProducto;
        private TextBox textbPrecioUnit;
        private Label label5;
        private TextBox textbProducto;
        private Label label6;
        private TextBox textbIdProducto;
        private Label label7;
        private Button BuBuscarEmpleados;
        private TextBox textbDepartamento;
        private Label label4;
        private TextBox textbITBIS;
        private Label label8;
        private Button BuSolicitar;
        private Label label10;
        private DataGridView dataViewDetalleItems;
        private TextBox textbCantidad;
        private Label label9;
        private TextBox textbTotal;
        private Label label11;
        private TextBox textbSubTotal;
        private Label label12;
        private Button BuAgregar;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCantidad;
        private DataGridViewTextBoxColumn ITBIS;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn Opcion;
        private ComboBox cbxSeleccionITBIS;
        private Button BuAplicarItbis;
    }
}