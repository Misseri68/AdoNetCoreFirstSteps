namespace AdoNetCore
{
    partial class EutanasiarEnfermos
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
            label2 = new Label();
            btnEliminar = new Button();
            txtInscripcion = new TextBox();
            lstTerminales = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Terminales";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(22, 122);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Finish him!";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(22, 70);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(100, 23);
            txtInscripcion.TabIndex = 3;
            // 
            // lstTerminales
            // 
            lstTerminales.FormattingEnabled = true;
            lstTerminales.Location = new Point(161, 70);
            lstTerminales.Name = "lstTerminales";
            lstTerminales.Size = new Size(197, 229);
            lstTerminales.TabIndex = 4;
            // 
            // EutanasiarEnfermos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTerminales);
            Controls.Add(txtInscripcion);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EutanasiarEnfermos";
            Text = "EutanasiarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtInscripcion;
        private ListBox lstTerminales;
    }
}