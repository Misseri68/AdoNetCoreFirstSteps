namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            txtSala = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Nueva Sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(12, 50);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(163, 244);
            lstSalas.TabIndex = 2;
            lstSalas.SelectedIndexChanged += lstSalas_SelectedIndexChanged;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(214, 107);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(214, 152);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modificar Salas";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtSala);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstSalas;
        private TextBox txtSala;
        private Button btnUpdate;
    }
}