namespace AdoNetCore
{
    partial class Form12MensajeServidor
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
            txtNum = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            Numero = new Label();
            Nombre = new Label();
            Localidad = new Label();
            Departamentos = new Label();
            lblMensaje = new Label();
            btnInsertar = new Button();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(25, 62);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(25, 218);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 2;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(41, 25);
            Numero.Name = "Numero";
            Numero.Size = new Size(51, 15);
            Numero.TabIndex = 3;
            Numero.Text = "Numero";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(41, 100);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre";
            // 
            // Localidad
            // 
            Localidad.AutoSize = true;
            Localidad.Location = new Point(41, 186);
            Localidad.Name = "Localidad";
            Localidad.Size = new Size(58, 15);
            Localidad.TabIndex = 5;
            Localidad.Text = "Localidad";
            // 
            // Departamentos
            // 
            Departamentos.AutoSize = true;
            Departamentos.Location = new Point(220, 25);
            Departamentos.Name = "Departamentos";
            Departamentos.Size = new Size(88, 15);
            Departamentos.TabIndex = 6;
            Departamentos.Text = "Departamentos";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(41, 381);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 15);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "lblMensaje";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(25, 279);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 34);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(220, 62);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(178, 304);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajeServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 447);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnInsertar);
            Controls.Add(lblMensaje);
            Controls.Add(Departamentos);
            Controls.Add(Localidad);
            Controls.Add(Nombre);
            Controls.Add(Numero);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtNum);
            Name = "Form12MensajeServidor";
            Text = "Form12MensajeServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Label Numero;
        private Label Nombre;
        private Label Localidad;
        private Label Departamentos;
        private Label lblMensaje;
        private Button btnInsertar;
        private ListBox lstDepartamentos;
    }
}