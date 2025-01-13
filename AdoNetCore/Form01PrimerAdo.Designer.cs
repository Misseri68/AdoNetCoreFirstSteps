namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeer = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTiposDato = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(8, 27);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(8, 71);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(75, 23);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(8, 114);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 2;
            btnLeer.Text = "btnLeer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(129, 71);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 199);
            lstApellidos.TabIndex = 4;
            lstApellidos.SelectedIndexChanged += lstApellidos_SelectedIndexChanged;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(309, 71);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 199);
            lstColumnas.TabIndex = 5;
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(472, 71);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(120, 199);
            lstTiposDato.TabIndex = 6;
            lstTiposDato.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 31);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 31);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipos Dato";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(12, 286);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 315);
            Controls.Add(lblMensaje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstTiposDato);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnLeer);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeer;
        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTiposDato;
        private Label label2;
        private Label label3;
        private Label lblMensaje;
    }
}