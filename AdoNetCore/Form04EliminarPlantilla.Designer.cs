namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            lstEmpleados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(12, 73);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(168, 289);
            lstEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleados Plantilla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 33);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "ID empleado";
            // 
            // txtID
            // 
            txtID.Location = new Point(249, 73);
            txtID.Name = "txtID";
            txtID.Size = new Size(113, 23);
            txtID.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(249, 102);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Borrar Empleado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 404);
            Controls.Add(btnEliminar);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Button btnEliminar;
    }
}