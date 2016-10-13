namespace moduloInventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvInvenario = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarMedida = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbMedida = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnCrearInsumo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCompraInsumo = new System.Windows.Forms.Button();
            this.dateTimePicker_fecCadInsumo = new System.Windows.Forms.DateTimePicker();
            this.txtCantInsumo = new System.Windows.Forms.TextBox();
            this.txtPrecioInsumo = new System.Windows.Forms.TextBox();
            this.lbl_precioInsumo = new System.Windows.Forms.Label();
            this.lbl_feCaduInsumo = new System.Windows.Forms.Label();
            this.lbl_cantInsumo = new System.Windows.Forms.Label();
            this.cBoxSelecInsumo = new System.Windows.Forms.ComboBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvenario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvInvenario);
            this.tabPage1.Controls.Add(this.btnBusqueda);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvInvenario
            // 
            this.dgvInvenario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvenario.Location = new System.Drawing.Point(18, 59);
            this.dgvInvenario.Name = "dgvInvenario";
            this.dgvInvenario.Size = new System.Drawing.Size(492, 204);
            this.dgvInvenario.TabIndex = 3;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(542, 18);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(18, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(492, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarMedida);
            this.tabPage2.Controls.Add(this.btnAgregarCategoria);
            this.tabPage2.Controls.Add(this.cmbMedida);
            this.tabPage2.Controls.Add(this.cmbCategoria);
            this.tabPage2.Controls.Add(this.lbMedida);
            this.tabPage2.Controls.Add(this.lblCategoria);
            this.tabPage2.Controls.Add(this.btnCrearInsumo);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.lblDescripcion);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creacion de Insumos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMedida
            // 
            this.btnAgregarMedida.Location = new System.Drawing.Point(342, 216);
            this.btnAgregarMedida.Name = "btnAgregarMedida";
            this.btnAgregarMedida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarMedida.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMedida.TabIndex = 9;
            this.btnAgregarMedida.Text = "Agregar";
            this.btnAgregarMedida.UseVisualStyleBackColor = true;
            this.btnAgregarMedida.Click += new System.EventHandler(this.btnAgregarMedida_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(342, 149);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(72, 23);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // cmbMedida
            // 
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Location = new System.Drawing.Point(136, 218);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(173, 21);
            this.cmbMedida.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(136, 151);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(173, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // lbMedida
            // 
            this.lbMedida.AutoSize = true;
            this.lbMedida.Location = new System.Drawing.Point(28, 221);
            this.lbMedida.Name = "lbMedida";
            this.lbMedida.Size = new System.Drawing.Size(48, 13);
            this.lbMedida.TabIndex = 5;
            this.lbMedida.Text = "Medida: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(28, 154);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // btnCrearInsumo
            // 
            this.btnCrearInsumo.Location = new System.Drawing.Point(613, 311);
            this.btnCrearInsumo.Name = "btnCrearInsumo";
            this.btnCrearInsumo.Size = new System.Drawing.Size(69, 23);
            this.btnCrearInsumo.TabIndex = 1;
            this.btnCrearInsumo.Text = "Crear";
            this.btnCrearInsumo.UseVisualStyleBackColor = true;
            this.btnCrearInsumo.Click += new System.EventHandler(this.btn_crearInsumo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 94);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.UseMnemonic = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCompraInsumo);
            this.tabPage3.Controls.Add(this.dateTimePicker_fecCadInsumo);
            this.tabPage3.Controls.Add(this.txtCantInsumo);
            this.tabPage3.Controls.Add(this.txtPrecioInsumo);
            this.tabPage3.Controls.Add(this.lbl_precioInsumo);
            this.tabPage3.Controls.Add(this.lbl_feCaduInsumo);
            this.tabPage3.Controls.Add(this.lbl_cantInsumo);
            this.tabPage3.Controls.Add(this.cBoxSelecInsumo);
            this.tabPage3.Controls.Add(this.lblInsumo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(698, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Agregar Insumos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCompraInsumo
            // 
            this.btnCompraInsumo.Location = new System.Drawing.Point(516, 312);
            this.btnCompraInsumo.Name = "btnCompraInsumo";
            this.btnCompraInsumo.Size = new System.Drawing.Size(136, 23);
            this.btnCompraInsumo.TabIndex = 11;
            this.btnCompraInsumo.Text = "Realizar Compra";
            this.btnCompraInsumo.UseVisualStyleBackColor = true;
            this.btnCompraInsumo.Click += new System.EventHandler(this.btnCompraInsumo_Click);
            // 
            // dateTimePicker_fecCadInsumo
            // 
            this.dateTimePicker_fecCadInsumo.Location = new System.Drawing.Point(176, 233);
            this.dateTimePicker_fecCadInsumo.Name = "dateTimePicker_fecCadInsumo";
            this.dateTimePicker_fecCadInsumo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fecCadInsumo.TabIndex = 10;
            // 
            // txtCantInsumo
            // 
            this.txtCantInsumo.Location = new System.Drawing.Point(176, 172);
            this.txtCantInsumo.Name = "txtCantInsumo";
            this.txtCantInsumo.Size = new System.Drawing.Size(182, 20);
            this.txtCantInsumo.TabIndex = 8;
            this.txtCantInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantInsumo_KeyPress);
            // 
            // txtPrecioInsumo
            // 
            this.txtPrecioInsumo.Location = new System.Drawing.Point(176, 115);
            this.txtPrecioInsumo.Name = "txtPrecioInsumo";
            this.txtPrecioInsumo.Size = new System.Drawing.Size(182, 20);
            this.txtPrecioInsumo.TabIndex = 7;
            this.txtPrecioInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioInsumo_KeyPress);
            // 
            // lbl_precioInsumo
            // 
            this.lbl_precioInsumo.AutoSize = true;
            this.lbl_precioInsumo.Location = new System.Drawing.Point(35, 118);
            this.lbl_precioInsumo.Name = "lbl_precioInsumo";
            this.lbl_precioInsumo.Size = new System.Drawing.Size(43, 13);
            this.lbl_precioInsumo.TabIndex = 5;
            this.lbl_precioInsumo.Text = "Precio: ";
            // 
            // lbl_feCaduInsumo
            // 
            this.lbl_feCaduInsumo.AutoSize = true;
            this.lbl_feCaduInsumo.Location = new System.Drawing.Point(35, 239);
            this.lbl_feCaduInsumo.Name = "lbl_feCaduInsumo";
            this.lbl_feCaduInsumo.Size = new System.Drawing.Size(111, 13);
            this.lbl_feCaduInsumo.TabIndex = 4;
            this.lbl_feCaduInsumo.Text = "Fecha de caducidad: ";
            // 
            // lbl_cantInsumo
            // 
            this.lbl_cantInsumo.AutoSize = true;
            this.lbl_cantInsumo.Location = new System.Drawing.Point(35, 179);
            this.lbl_cantInsumo.Name = "lbl_cantInsumo";
            this.lbl_cantInsumo.Size = new System.Drawing.Size(55, 13);
            this.lbl_cantInsumo.TabIndex = 3;
            this.lbl_cantInsumo.Text = "Cantidad: ";
            // 
            // cBoxSelecInsumo
            // 
            this.cBoxSelecInsumo.FormattingEnabled = true;
            this.cBoxSelecInsumo.Location = new System.Drawing.Point(176, 50);
            this.cBoxSelecInsumo.Name = "cBoxSelecInsumo";
            this.cBoxSelecInsumo.Size = new System.Drawing.Size(182, 21);
            this.cBoxSelecInsumo.TabIndex = 1;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Location = new System.Drawing.Point(35, 53);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(103, 13);
            this.lblInsumo.TabIndex = 0;
            this.lblInsumo.Text = "Seleccione Insumo: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvenario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCrearInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Label lbl_feCaduInsumo;
        private System.Windows.Forms.Label lbl_cantInsumo;
        private System.Windows.Forms.ComboBox cBoxSelecInsumo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lbMedida;
        private System.Windows.Forms.Label lbl_precioInsumo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecCadInsumo;
        private System.Windows.Forms.TextBox txtCantInsumo;
        private System.Windows.Forms.TextBox txtPrecioInsumo;
        private System.Windows.Forms.Button btnCompraInsumo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAgregarMedida;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.DataGridView dgvInvenario;
    }
}

