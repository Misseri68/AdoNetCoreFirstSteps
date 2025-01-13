namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            label1 = new Label();
            Empleados = new Label();
            btnBuscar = new Button();
            txtSalario = new TextBox();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca usuario";
            // 
            // Empleados
            // 
            Empleados.AutoSize = true;
            Empleados.Location = new Point(48, 141);
            Empleados.Name = "Empleados";
            Empleados.Size = new Size(65, 15);
            Empleados.TabIndex = 1;
            Empleados.Text = "Empleados";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(138, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(29, 42);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 3;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(12, 180);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(138, 199);
            lstEmpleados.TabIndex = 4;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscar);
            Controls.Add(Empleados);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Empleados;
        private Button btnBuscar;
        private TextBox txtSalario;
        private ListBox lstEmpleados;
    }
}