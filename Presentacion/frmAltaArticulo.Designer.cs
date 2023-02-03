namespace Presentacion
{
    partial class frmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblsigno = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pbxNuevaImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblNoCodigo = new System.Windows.Forms.Label();
            this.lblNoNombre = new System.Windows.Forms.Label();
            this.lblNoprecio = new System.Windows.Forms.Label();
            this.lblncod = new System.Windows.Forms.Label();
            this.lblnNombre = new System.Windows.Forms.Label();
            this.lblnPrecio = new System.Windows.Forms.Label();
            this.lblMaxCaracter = new System.Windows.Forms.Label();
            this.lblSoloNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCodigo.Location = new System.Drawing.Point(15, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 78);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcíon:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Location = new System.Drawing.Point(15, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(115, 26);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(131, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(115, 78);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(131, 140);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 52);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrecio.Location = new System.Drawing.Point(15, 255);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUrlImagen.Location = new System.Drawing.Point(15, 225);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(82, 16);
            this.lblUrlImagen.TabIndex = 7;
            this.lblUrlImagen.Text = "UrlImagen:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(115, 251);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(131, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(115, 224);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblsigno
            // 
            this.lblsigno.AutoSize = true;
            this.lblsigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsigno.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblsigno.Location = new System.Drawing.Point(68, 255);
            this.lblsigno.Name = "lblsigno";
            this.lblsigno.Size = new System.Drawing.Size(14, 16);
            this.lblsigno.TabIndex = 10;
            this.lblsigno.Text = "$";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.Location = new System.Drawing.Point(106, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 27);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(233, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMarca.Location = new System.Drawing.Point(15, 296);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 16);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCategoria.Location = new System.Drawing.Point(15, 326);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 16);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(115, 295);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(131, 21);
            this.cboMarca.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(115, 323);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(131, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // pbxNuevaImagen
            // 
            this.pbxNuevaImagen.Location = new System.Drawing.Point(279, 53);
            this.pbxNuevaImagen.Name = "pbxNuevaImagen";
            this.pbxNuevaImagen.Size = new System.Drawing.Size(179, 218);
            this.pbxNuevaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNuevaImagen.TabIndex = 17;
            this.pbxNuevaImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(221, 223);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(25, 20);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblNoCodigo
            // 
            this.lblNoCodigo.AutoSize = true;
            this.lblNoCodigo.Location = new System.Drawing.Point(252, 29);
            this.lblNoCodigo.Name = "lblNoCodigo";
            this.lblNoCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblNoCodigo.TabIndex = 19;
            // 
            // lblNoNombre
            // 
            this.lblNoNombre.AutoSize = true;
            this.lblNoNombre.Location = new System.Drawing.Point(253, 52);
            this.lblNoNombre.Name = "lblNoNombre";
            this.lblNoNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNoNombre.TabIndex = 20;
            // 
            // lblNoprecio
            // 
            this.lblNoprecio.AutoSize = true;
            this.lblNoprecio.Location = new System.Drawing.Point(253, 251);
            this.lblNoprecio.Name = "lblNoprecio";
            this.lblNoprecio.Size = new System.Drawing.Size(0, 13);
            this.lblNoprecio.TabIndex = 21;
            // 
            // lblncod
            // 
            this.lblncod.AutoSize = true;
            this.lblncod.BackColor = System.Drawing.SystemColors.Control;
            this.lblncod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblncod.ForeColor = System.Drawing.Color.Red;
            this.lblncod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblncod.Location = new System.Drawing.Point(249, 26);
            this.lblncod.Name = "lblncod";
            this.lblncod.Size = new System.Drawing.Size(20, 25);
            this.lblncod.TabIndex = 22;
            this.lblncod.Text = "*";
            // 
            // lblnNombre
            // 
            this.lblnNombre.AutoSize = true;
            this.lblnNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnNombre.ForeColor = System.Drawing.Color.Red;
            this.lblnNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnNombre.Location = new System.Drawing.Point(248, 52);
            this.lblnNombre.Name = "lblnNombre";
            this.lblnNombre.Size = new System.Drawing.Size(20, 25);
            this.lblnNombre.TabIndex = 23;
            this.lblnNombre.Text = "*";
            // 
            // lblnPrecio
            // 
            this.lblnPrecio.AutoSize = true;
            this.lblnPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.lblnPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblnPrecio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnPrecio.Location = new System.Drawing.Point(253, 252);
            this.lblnPrecio.Name = "lblnPrecio";
            this.lblnPrecio.Size = new System.Drawing.Size(20, 25);
            this.lblnPrecio.TabIndex = 24;
            this.lblnPrecio.Text = "*";
            // 
            // lblMaxCaracter
            // 
            this.lblMaxCaracter.AutoSize = true;
            this.lblMaxCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCaracter.Location = new System.Drawing.Point(16, 94);
            this.lblMaxCaracter.Name = "lblMaxCaracter";
            this.lblMaxCaracter.Size = new System.Drawing.Size(93, 12);
            this.lblMaxCaracter.TabIndex = 25;
            this.lblMaxCaracter.Text = "(Máx 150 caracteres)";
            // 
            // lblSoloNum
            // 
            this.lblSoloNum.AutoSize = true;
            this.lblSoloNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloNum.Location = new System.Drawing.Point(16, 271);
            this.lblSoloNum.Name = "lblSoloNum";
            this.lblSoloNum.Size = new System.Drawing.Size(69, 12);
            this.lblSoloNum.TabIndex = 26;
            this.lblSoloNum.Text = "(Solo Números)";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 419);
            this.Controls.Add(this.lblSoloNum);
            this.Controls.Add(this.lblMaxCaracter);
            this.Controls.Add(this.lblnPrecio);
            this.Controls.Add(this.lblnNombre);
            this.Controls.Add(this.lblncod);
            this.Controls.Add(this.lblNoprecio);
            this.Controls.Add(this.lblNoNombre);
            this.Controls.Add(this.lblNoCodigo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxNuevaImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblsigno);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.MinimumSize = new System.Drawing.Size(462, 454);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblsigno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox pbxNuevaImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblNoCodigo;
        private System.Windows.Forms.Label lblNoNombre;
        private System.Windows.Forms.Label lblNoprecio;
        private System.Windows.Forms.Label lblncod;
        private System.Windows.Forms.Label lblnNombre;
        private System.Windows.Forms.Label lblnPrecio;
        private System.Windows.Forms.Label lblMaxCaracter;
        private System.Windows.Forms.Label lblSoloNum;
    }
}