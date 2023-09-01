namespace Ejemplo1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxChocolate = new System.Windows.Forms.CheckBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.rbtGryffindor = new System.Windows.Forms.RadioButton();
            this.rbtHufflepuff = new System.Windows.Forms.RadioButton();
            this.rbtRavenclaw = new System.Windows.Forms.RadioButton();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.rbtSlytherin = new System.Windows.Forms.RadioButton();
            this.cbxColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.grbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(116, 461);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(217, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(217, 351);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(306, 116);
            this.lvElementos.TabIndex = 5;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(147, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(98, 98);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(217, 98);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(306, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbxChocolate
            // 
            this.cbxChocolate.AutoSize = true;
            this.cbxChocolate.Location = new System.Drawing.Point(217, 140);
            this.cbxChocolate.Name = "cbxChocolate";
            this.cbxChocolate.Size = new System.Drawing.Size(135, 17);
            this.cbxChocolate.TabIndex = 2;
            this.cbxChocolate.Text = "Te gusta el chocolate?";
            this.cbxChocolate.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(97, 19);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(126, 24);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil Persona";
            // 
            // rbtGryffindor
            // 
            this.rbtGryffindor.AutoSize = true;
            this.rbtGryffindor.Location = new System.Drawing.Point(12, 28);
            this.rbtGryffindor.Name = "rbtGryffindor";
            this.rbtGryffindor.Size = new System.Drawing.Size(70, 17);
            this.rbtGryffindor.TabIndex = 0;
            this.rbtGryffindor.TabStop = true;
            this.rbtGryffindor.Text = "Gryffindor";
            this.rbtGryffindor.UseVisualStyleBackColor = true;
            // 
            // rbtHufflepuff
            // 
            this.rbtHufflepuff.AutoSize = true;
            this.rbtHufflepuff.Location = new System.Drawing.Point(141, 28);
            this.rbtHufflepuff.Name = "rbtHufflepuff";
            this.rbtHufflepuff.Size = new System.Drawing.Size(71, 17);
            this.rbtHufflepuff.TabIndex = 1;
            this.rbtHufflepuff.TabStop = true;
            this.rbtHufflepuff.Text = "Hufflepuff";
            this.rbtHufflepuff.UseVisualStyleBackColor = true;
            // 
            // rbtRavenclaw
            // 
            this.rbtRavenclaw.AutoSize = true;
            this.rbtRavenclaw.Location = new System.Drawing.Point(275, 28);
            this.rbtRavenclaw.Name = "rbtRavenclaw";
            this.rbtRavenclaw.Size = new System.Drawing.Size(79, 17);
            this.rbtRavenclaw.TabIndex = 2;
            this.rbtRavenclaw.TabStop = true;
            this.rbtRavenclaw.Text = "Ravenclaw";
            this.rbtRavenclaw.UseVisualStyleBackColor = true;
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.rbtSlytherin);
            this.grbTipo.Controls.Add(this.rbtGryffindor);
            this.grbTipo.Controls.Add(this.rbtRavenclaw);
            this.grbTipo.Controls.Add(this.rbtHufflepuff);
            this.grbTipo.Location = new System.Drawing.Point(101, 163);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(514, 67);
            this.grbTipo.TabIndex = 12;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            this.grbTipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtSlytherin
            // 
            this.rbtSlytherin.AutoSize = true;
            this.rbtSlytherin.Location = new System.Drawing.Point(408, 28);
            this.rbtSlytherin.Name = "rbtSlytherin";
            this.rbtSlytherin.Size = new System.Drawing.Size(65, 17);
            this.rbtSlytherin.TabIndex = 3;
            this.rbtSlytherin.TabStop = true;
            this.rbtSlytherin.Text = "Slytherin";
            this.rbtSlytherin.UseVisualStyleBackColor = true;
            // 
            // cbxColorFavorito
            // 
            this.cbxColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxColorFavorito.FormattingEnabled = true;
            this.cbxColorFavorito.Location = new System.Drawing.Point(217, 255);
            this.cbxColorFavorito.Name = "cbxColorFavorito";
            this.cbxColorFavorito.Size = new System.Drawing.Size(306, 21);
            this.cbxColorFavorito.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(119, 263);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color Favorito";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(116, 314);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 4;
            this.btnVerPerfil.Text = "&Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 523);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbxColorFavorito);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cbxChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.MaximumSize = new System.Drawing.Size(786, 562);
            this.MinimumSize = new System.Drawing.Size(691, 543);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbxChocolate;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.RadioButton rbtGryffindor;
        private System.Windows.Forms.RadioButton rbtHufflepuff;
        private System.Windows.Forms.RadioButton rbtRavenclaw;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.RadioButton rbtSlytherin;
        private System.Windows.Forms.ComboBox cbxColorFavorito;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

