namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            txtIncremento = new TextBox();
            txtOficio = new TextBox();
            btnIncrementar = new Button();
            btnNombreOficio = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            SuspendLayout();
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(22, 32);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(123, 214);
            lstOficios.TabIndex = 0;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(193, 32);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(123, 214);
            lstEmpleados.TabIndex = 1;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(358, 48);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 2;
            txtIncremento.Text = "Incremento";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(358, 162);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 3;
            txtOficio.Text = "NOficio";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(358, 98);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(100, 29);
            btnIncrementar.TabIndex = 4;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // btnNombreOficio
            // 
            btnNombreOficio.Location = new Point(358, 214);
            btnNombreOficio.Name = "btnNombreOficio";
            btnNombreOficio.Size = new Size(100, 32);
            btnNombreOficio.TabIndex = 5;
            btnNombreOficio.Text = "Nombre ofi";
            btnNombreOficio.UseVisualStyleBackColor = true;
            btnNombreOficio.Click += btnNombreOficio_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(22, 268);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(75, 15);
            lblSumaSalarial.TabIndex = 6;
            lblSumaSalarial.Text = "suma salarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(22, 304);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(79, 15);
            lblMediaSalarial.TabIndex = 7;
            lblMediaSalarial.Text = "Media salarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(22, 335);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(68, 15);
            lblMaximoSalario.TabIndex = 8;
            lblMaximoSalario.Text = "Max Salario";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 371);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnNombreOficio);
            Controls.Add(btnIncrementar);
            Controls.Add(txtOficio);
            Controls.Add(txtIncremento);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private TextBox txtIncremento;
        private TextBox txtOficio;
        private Button btnIncrementar;
        private Button btnNombreOficio;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
    }
}