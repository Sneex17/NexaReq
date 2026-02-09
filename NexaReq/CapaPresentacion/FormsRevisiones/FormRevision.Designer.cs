namespace CapaPresentacion.FormsRevisiones
{
    partial class FormRevision
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
            label10 = new Label();
            cbxEstadosRequisicion = new ComboBox();
            BuCargarDetalle = new Button();
            textbEstadoRequisicion = new TextBox();
            label8 = new Label();
            textbTotalRequisicion = new TextBox();
            label6 = new Label();
            textbFechaCreacion = new TextBox();
            label7 = new Label();
            textbIdEmpleado = new TextBox();
            label5 = new Label();
            BuBuscarRequisicion = new Button();
            textbDepartamento = new TextBox();
            label4 = new Label();
            textbNombre = new TextBox();
            label3 = new Label();
            textbIdRequisicion = new TextBox();
            label2 = new Label();
            viewDetalleRequisicion = new DataGridView();
            label9 = new Label();
            BuGuardarCambios = new Button();
            panelHeader.SuspendLayout();
            panelContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewDetalleRequisicion).BeginInit();
            SuspendLayout();
            // 
            // panelContext
            // 
            panelContext.Controls.Add(BuGuardarCambios);
            panelContext.Controls.Add(label9);
            panelContext.Controls.Add(viewDetalleRequisicion);
            panelContext.Controls.Add(groupBox1);
            panelContext.Controls.SetChildIndex(BuCerrarVentana, 0);
            panelContext.Controls.SetChildIndex(groupBox1, 0);
            panelContext.Controls.SetChildIndex(viewDetalleRequisicion, 0);
            panelContext.Controls.SetChildIndex(label9, 0);
            panelContext.Controls.SetChildIndex(BuGuardarCambios, 0);
            // 
            // label1
            // 
            label1.Size = new Size(305, 31);
            label1.Text = "Revisiones de requisiciones";
            // 
            // BuCerrarVentana
            // 
            BuCerrarVentana.Click += BuCerrarVentana_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbxEstadosRequisicion);
            groupBox1.Controls.Add(BuCargarDetalle);
            groupBox1.Controls.Add(textbEstadoRequisicion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textbTotalRequisicion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textbFechaCreacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textbIdEmpleado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BuBuscarRequisicion);
            groupBox1.Controls.Add(textbDepartamento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textbIdRequisicion);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 159);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Requisición";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(481, 86);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 17;
            label10.Text = "Proximo Estado";
            // 
            // cbxEstadosRequisicion
            // 
            cbxEstadosRequisicion.FormattingEnabled = true;
            cbxEstadosRequisicion.Location = new Point(481, 109);
            cbxEstadosRequisicion.Name = "cbxEstadosRequisicion";
            cbxEstadosRequisicion.Size = new Size(145, 28);
            cbxEstadosRequisicion.TabIndex = 16;
            // 
            // BuCargarDetalle
            // 
            BuCargarDetalle.BackColor = Color.FromArgb(16, 40, 99);
            BuCargarDetalle.Cursor = Cursors.Hand;
            BuCargarDetalle.FlatStyle = FlatStyle.Popup;
            BuCargarDetalle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuCargarDetalle.ForeColor = Color.White;
            BuCargarDetalle.Location = new Point(712, 89);
            BuCargarDetalle.Name = "BuCargarDetalle";
            BuCargarDetalle.Size = new Size(123, 47);
            BuCargarDetalle.TabIndex = 15;
            BuCargarDetalle.Text = "Cargar detalle";
            BuCargarDetalle.UseVisualStyleBackColor = false;
            BuCargarDetalle.Click += BuCargarDetalle_Click;
            // 
            // textbEstadoRequisicion
            // 
            textbEstadoRequisicion.BorderStyle = BorderStyle.FixedSingle;
            textbEstadoRequisicion.Enabled = false;
            textbEstadoRequisicion.Location = new Point(481, 52);
            textbEstadoRequisicion.Name = "textbEstadoRequisicion";
            textbEstadoRequisicion.Size = new Size(145, 27);
            textbEstadoRequisicion.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(481, 29);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 13;
            label8.Text = "Estado Actual";
            // 
            // textbTotalRequisicion
            // 
            textbTotalRequisicion.BorderStyle = BorderStyle.FixedSingle;
            textbTotalRequisicion.Enabled = false;
            textbTotalRequisicion.Location = new Point(322, 52);
            textbTotalRequisicion.Name = "textbTotalRequisicion";
            textbTotalRequisicion.Size = new Size(145, 27);
            textbTotalRequisicion.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 29);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 11;
            label6.Text = "Total";
            // 
            // textbFechaCreacion
            // 
            textbFechaCreacion.BorderStyle = BorderStyle.FixedSingle;
            textbFechaCreacion.Enabled = false;
            textbFechaCreacion.Location = new Point(322, 109);
            textbFechaCreacion.Name = "textbFechaCreacion";
            textbFechaCreacion.Size = new Size(145, 27);
            textbFechaCreacion.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 86);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 9;
            label7.Text = "Fecha de Creación";
            // 
            // textbIdEmpleado
            // 
            textbIdEmpleado.BorderStyle = BorderStyle.FixedSingle;
            textbIdEmpleado.Enabled = false;
            textbIdEmpleado.Location = new Point(21, 109);
            textbIdEmpleado.Name = "textbIdEmpleado";
            textbIdEmpleado.Size = new Size(101, 27);
            textbIdEmpleado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 86);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 7;
            label5.Text = "Id Empleado";
            // 
            // BuBuscarRequisicion
            // 
            BuBuscarRequisicion.BackColor = Color.FromArgb(16, 40, 99);
            BuBuscarRequisicion.Cursor = Cursors.Hand;
            BuBuscarRequisicion.FlatStyle = FlatStyle.Popup;
            BuBuscarRequisicion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuBuscarRequisicion.ForeColor = Color.White;
            BuBuscarRequisicion.Location = new Point(760, 24);
            BuBuscarRequisicion.Name = "BuBuscarRequisicion";
            BuBuscarRequisicion.Size = new Size(75, 47);
            BuBuscarRequisicion.TabIndex = 6;
            BuBuscarRequisicion.Text = "Buscar";
            BuBuscarRequisicion.UseVisualStyleBackColor = false;
            BuBuscarRequisicion.Click += BuBuscarRequisicion_Click;
            // 
            // textbDepartamento
            // 
            textbDepartamento.BorderStyle = BorderStyle.FixedSingle;
            textbDepartamento.Enabled = false;
            textbDepartamento.Location = new Point(137, 52);
            textbDepartamento.Name = "textbDepartamento";
            textbDepartamento.Size = new Size(170, 27);
            textbDepartamento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 29);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 4;
            label4.Text = "Departamento";
            // 
            // textbNombre
            // 
            textbNombre.BorderStyle = BorderStyle.FixedSingle;
            textbNombre.Enabled = false;
            textbNombre.Location = new Point(137, 109);
            textbNombre.Name = "textbNombre";
            textbNombre.Size = new Size(170, 27);
            textbNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 86);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // textbIdRequisicion
            // 
            textbIdRequisicion.BorderStyle = BorderStyle.FixedSingle;
            textbIdRequisicion.Enabled = false;
            textbIdRequisicion.Location = new Point(20, 52);
            textbIdRequisicion.Name = "textbIdRequisicion";
            textbIdRequisicion.Size = new Size(102, 27);
            textbIdRequisicion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Id Requisición";
            // 
            // viewDetalleRequisicion
            // 
            viewDetalleRequisicion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewDetalleRequisicion.Location = new Point(20, 231);
            viewDetalleRequisicion.Name = "viewDetalleRequisicion";
            viewDetalleRequisicion.Size = new Size(850, 255);
            viewDetalleRequisicion.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 194);
            label9.Name = "label9";
            label9.Size = new Size(268, 21);
            label9.TabIndex = 16;
            label9.Text = "Detalle de los productos / servicios";
            // 
            // BuGuardarCambios
            // 
            BuGuardarCambios.BackColor = Color.FromArgb(44, 206, 117);
            BuGuardarCambios.Cursor = Cursors.Hand;
            BuGuardarCambios.FlatStyle = FlatStyle.Popup;
            BuGuardarCambios.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuGuardarCambios.ForeColor = Color.FromArgb(16, 40, 99);
            BuGuardarCambios.Location = new Point(732, 512);
            BuGuardarCambios.Name = "BuGuardarCambios";
            BuGuardarCambios.Size = new Size(138, 47);
            BuGuardarCambios.TabIndex = 18;
            BuGuardarCambios.Text = "Guardar Cambios";
            BuGuardarCambios.UseVisualStyleBackColor = false;
            BuGuardarCambios.Click += BuGuardarCambios_Click;
            // 
            // FormRevision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 661);
            Location = new Point(890, 661);
            Name = "FormRevision";
            Text = "FormRevision";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContext.ResumeLayout(false);
            panelContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewDetalleRequisicion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BuBuscarRequisicion;
        private TextBox textbDepartamento;
        private Label label4;
        private TextBox textbNombre;
        private Label label3;
        private TextBox textbIdRequisicion;
        private Label label2;
        private TextBox textbIdEmpleado;
        private Label label5;
        private TextBox textbTotalRequisicion;
        private Label label6;
        private TextBox textbFechaCreacion;
        private Label label7;
        private TextBox textbEstadoRequisicion;
        private Label label8;
        private Label label9;
        private DataGridView viewDetalleRequisicion;
        private Button BuCargarDetalle;
        private Label label10;
        private ComboBox cbxEstadosRequisicion;
        private Button BuGuardarCambios;
    }
}