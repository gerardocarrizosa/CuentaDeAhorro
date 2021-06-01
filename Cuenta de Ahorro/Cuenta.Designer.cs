namespace Cuenta_de_Ahorro
{
    partial class Cuenta
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroDeCuenta = new System.Windows.Forms.TextBox();
            this.lblNumeroDeCuenta = new System.Windows.Forms.Label();
            this.rbtnDeposito = new System.Windows.Forms.RadioButton();
            this.rbtnRetiro = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.mOVIMIENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.cbxAgregarCliente = new System.Windows.Forms.CheckBox();
            this.ibtnBorrarCliente = new FontAwesome.Sharp.IconButton();
            this.ibtnCargarTabla = new FontAwesome.Sharp.IconButton();
            this.lblNumeroDeCliente = new System.Windows.Forms.Label();
            this.lblMovimientoId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMIENTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(167, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(234, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // txtNumeroDeCuenta
            // 
            this.txtNumeroDeCuenta.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeCuenta.Location = new System.Drawing.Point(167, 93);
            this.txtNumeroDeCuenta.MaxLength = 16;
            this.txtNumeroDeCuenta.Name = "txtNumeroDeCuenta";
            this.txtNumeroDeCuenta.ReadOnly = true;
            this.txtNumeroDeCuenta.Size = new System.Drawing.Size(234, 27);
            this.txtNumeroDeCuenta.TabIndex = 4;
            // 
            // lblNumeroDeCuenta
            // 
            this.lblNumeroDeCuenta.AutoSize = true;
            this.lblNumeroDeCuenta.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeCuenta.Location = new System.Drawing.Point(12, 96);
            this.lblNumeroDeCuenta.Name = "lblNumeroDeCuenta";
            this.lblNumeroDeCuenta.Size = new System.Drawing.Size(149, 19);
            this.lblNumeroDeCuenta.TabIndex = 3;
            this.lblNumeroDeCuenta.Text = "Numero de Cuenta:";
            // 
            // rbtnDeposito
            // 
            this.rbtnDeposito.AutoSize = true;
            this.rbtnDeposito.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDeposito.Location = new System.Drawing.Point(104, 206);
            this.rbtnDeposito.Name = "rbtnDeposito";
            this.rbtnDeposito.Size = new System.Drawing.Size(91, 23);
            this.rbtnDeposito.TabIndex = 5;
            this.rbtnDeposito.TabStop = true;
            this.rbtnDeposito.Text = "Deposito";
            this.rbtnDeposito.UseVisualStyleBackColor = true;
            // 
            // rbtnRetiro
            // 
            this.rbtnRetiro.AutoSize = true;
            this.rbtnRetiro.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRetiro.Location = new System.Drawing.Point(238, 206);
            this.rbtnRetiro.Name = "rbtnRetiro";
            this.rbtnRetiro.Size = new System.Drawing.Size(71, 23);
            this.rbtnRetiro.TabIndex = 6;
            this.rbtnRetiro.TabStop = true;
            this.rbtnRetiro.Text = "Retiro";
            this.rbtnRetiro.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(251, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 27);
            this.dtpFecha.TabIndex = 7;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.DataSource = this.cLIENTESBindingSource;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(397, 353);
            this.dgvClientes.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(103, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 29);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(217, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(186, 247);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 27);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(72, 250);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 19);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(407, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 385);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMovimientos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimientos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AutoGenerateColumns = false;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.DataSource = this.mOVIMIENTOSBindingSource;
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(3, 3);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.Size = new System.Drawing.Size(397, 353);
            this.dgvMovimientos.TabIndex = 0;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActual.Location = new System.Drawing.Point(167, 130);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(182, 27);
            this.txtSaldoActual.TabIndex = 18;
            this.txtSaldoActual.Visible = false;
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(12, 133);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(105, 19);
            this.lblSaldoActual.TabIndex = 17;
            this.lblSaldoActual.Text = "Saldo Actual:";
            this.lblSaldoActual.Visible = false;
            // 
            // cbxAgregarCliente
            // 
            this.cbxAgregarCliente.AutoSize = true;
            this.cbxAgregarCliente.Location = new System.Drawing.Point(12, 9);
            this.cbxAgregarCliente.Name = "cbxAgregarCliente";
            this.cbxAgregarCliente.Size = new System.Drawing.Size(98, 17);
            this.cbxAgregarCliente.TabIndex = 19;
            this.cbxAgregarCliente.Text = "Agregar Cliente";
            this.cbxAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // ibtnBorrarCliente
            // 
            this.ibtnBorrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ibtnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBorrarCliente.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBorrarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnBorrarCliente.IconColor = System.Drawing.Color.Black;
            this.ibtnBorrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBorrarCliente.Location = new System.Drawing.Point(5, 358);
            this.ibtnBorrarCliente.Name = "ibtnBorrarCliente";
            this.ibtnBorrarCliente.Size = new System.Drawing.Size(83, 23);
            this.ibtnBorrarCliente.TabIndex = 20;
            this.ibtnBorrarCliente.Text = "Eliminar Cliente";
            this.ibtnBorrarCliente.UseVisualStyleBackColor = true;
            this.ibtnBorrarCliente.Click += new System.EventHandler(this.ibtnBorrarCliente_Click);
            // 
            // ibtnCargarTabla
            // 
            this.ibtnCargarTabla.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ibtnCargarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCargarTabla.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCargarTabla.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnCargarTabla.IconColor = System.Drawing.Color.Black;
            this.ibtnCargarTabla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCargarTabla.Location = new System.Drawing.Point(349, 358);
            this.ibtnCargarTabla.Name = "ibtnCargarTabla";
            this.ibtnCargarTabla.Size = new System.Drawing.Size(52, 23);
            this.ibtnCargarTabla.TabIndex = 21;
            this.ibtnCargarTabla.Text = "Refresh";
            this.ibtnCargarTabla.UseVisualStyleBackColor = true;
            this.ibtnCargarTabla.Click += new System.EventHandler(this.ibtnCargarTabla_Click);
            // 
            // lblNumeroDeCliente
            // 
            this.lblNumeroDeCliente.AutoSize = true;
            this.lblNumeroDeCliente.Location = new System.Drawing.Point(161, 65);
            this.lblNumeroDeCliente.Name = "lblNumeroDeCliente";
            this.lblNumeroDeCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroDeCliente.TabIndex = 22;
            this.lblNumeroDeCliente.Visible = false;
            // 
            // lblMovimientoId
            // 
            this.lblMovimientoId.AutoSize = true;
            this.lblMovimientoId.Location = new System.Drawing.Point(149, 65);
            this.lblMovimientoId.Name = "lblMovimientoId";
            this.lblMovimientoId.Size = new System.Drawing.Size(0, 13);
            this.lblMovimientoId.TabIndex = 23;
            this.lblMovimientoId.Visible = false;
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 385);
            this.Controls.Add(this.lblMovimientoId);
            this.Controls.Add(this.lblNumeroDeCliente);
            this.Controls.Add(this.ibtnCargarTabla);
            this.Controls.Add(this.ibtnBorrarCliente);
            this.Controls.Add(this.cbxAgregarCliente);
            this.Controls.Add(this.txtSaldoActual);
            this.Controls.Add(this.lblSaldoActual);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.rbtnRetiro);
            this.Controls.Add(this.rbtnDeposito);
            this.Controls.Add(this.txtNumeroDeCuenta);
            this.Controls.Add(this.lblNumeroDeCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(834, 424);
            this.MinimumSize = new System.Drawing.Size(834, 424);
            this.Name = "Cuenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.Cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMIENTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroDeCuenta;
        private System.Windows.Forms.Label lblNumeroDeCuenta;
        private System.Windows.Forms.RadioButton rbtnDeposito;
        private System.Windows.Forms.RadioButton rbtnRetiro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.BindingSource mOVIMIENTOSBindingSource;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.CheckBox cbxAgregarCliente;
        private FontAwesome.Sharp.IconButton ibtnBorrarCliente;
        private FontAwesome.Sharp.IconButton ibtnCargarTabla;
        private System.Windows.Forms.Label lblNumeroDeCliente;
        private System.Windows.Forms.Label lblMovimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAMOVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOMOVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODECUENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDOACTUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDOANTERIOR;

    }
}

        

