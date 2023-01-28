namespace Tabla_de_registros
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
            this.dtgvPersona = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cbxLista = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiarCajas = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPersona
            // 
            this.dtgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Telefono,
            this.Cargos});
            this.dtgvPersona.Location = new System.Drawing.Point(29, 174);
            this.dtgvPersona.Name = "dtgvPersona";
            this.dtgvPersona.Size = new System.Drawing.Size(608, 148);
            this.dtgvPersona.TabIndex = 0;
            this.dtgvPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPersona_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Persona";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Persona";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido Persona";
            this.Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad Persona";
            this.Edad.Name = "Edad";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono Persona";
            this.Telefono.Name = "Telefono";
            // 
            // Cargos
            // 
            this.Cargos.HeaderText = "Cargos Persona";
            this.Cargos.Name = "Cargos";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Identificacion";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(26, 47);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = " Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(29, 105);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = " Edad";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(29, 136);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefono";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 20);
            this.txtID.TabIndex = 6;
            this.txtID.Text = " ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(102, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(186, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(102, 105);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(186, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(102, 136);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(186, 20);
            this.txtTel.TabIndex = 10;
            // 
            // cbxLista
            // 
            this.cbxLista.FormattingEnabled = true;
            this.cbxLista.Items.AddRange(new object[] {
            "Doctor",
            "Ingeniero",
            "Abogado",
            "Policia",
            "Diputado"});
            this.cbxLista.Location = new System.Drawing.Point(417, 16);
            this.cbxLista.Name = "cbxLista";
            this.cbxLista.Size = new System.Drawing.Size(138, 21);
            this.cbxLista.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(368, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 26);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(473, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 26);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(369, 126);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiarCajas
            // 
            this.btnLimpiarCajas.Location = new System.Drawing.Point(473, 128);
            this.btnLimpiarCajas.Name = "btnLimpiarCajas";
            this.btnLimpiarCajas.Size = new System.Drawing.Size(81, 20);
            this.btnLimpiarCajas.TabIndex = 16;
            this.btnLimpiarCajas.Text = "Limpiar texto";
            this.btnLimpiarCajas.UseVisualStyleBackColor = true;
            this.btnLimpiarCajas.Click += new System.EventHandler(this.btnLimpiarCajas_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(569, 99);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 24);
            this.btnMod.TabIndex = 17;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 343);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnLimpiarCajas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxLista);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtgvPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cbxLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiarCajas;
        private System.Windows.Forms.Button btnMod;
    }
}

