namespace AdoNetCore
{
    partial class Form13ParametrosSalida
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
            cmbDeps = new ComboBox();
            label1 = new Label();
            btnMostrar = new Button();
            txtSuma = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            txtMedia = new Label();
            txtPersonas = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbDeps
            // 
            cmbDeps.FormattingEnabled = true;
            cmbDeps.Location = new Point(12, 58);
            cmbDeps.Name = "cmbDeps";
            cmbDeps.Size = new Size(121, 23);
            cmbDeps.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Departamentos";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 107);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(121, 26);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(12, 184);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 318);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(211, 58);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(144, 274);
            lstEmpleados.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 148);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 8;
            label2.Text = "Suma salarial";
            // 
            // txtMedia
            // 
            txtMedia.AutoSize = true;
            txtMedia.Location = new Point(14, 226);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(79, 15);
            txtMedia.TabIndex = 9;
            txtMedia.Text = "Media salarial";
            // 
            // txtPersonas
            // 
            txtPersonas.AutoSize = true;
            txtPersonas.Location = new Point(14, 291);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(54, 15);
            txtPersonas.TabIndex = 10;
            txtPersonas.Text = "Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 23);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 11;
            label3.Text = "Empleados";
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 424);
            Controls.Add(label3);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtSuma);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Controls.Add(cmbDeps);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDeps;
        private Label label1;
        private Button btnMostrar;
        private TextBox txtSuma;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox lstEmpleados;
        private Label label2;
        private Label txtMedia;
        private Label txtPersonas;
        private Label label3;
    }
}