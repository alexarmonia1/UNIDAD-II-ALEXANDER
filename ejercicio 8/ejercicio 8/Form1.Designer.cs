namespace ejercicio_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncontar = new Button();
            lblresultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncontar
            // 
            btncontar.Location = new Point(324, 140);
            btncontar.Name = "btncontar";
            btncontar.Size = new Size(112, 34);
            btncontar.TabIndex = 0;
            btncontar.Text = "contar";
            btncontar.UseVisualStyleBackColor = true;
            btncontar.Click += button1_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(295, 194);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(169, 25);
            lblresultado.TabIndex = 1;
            lblresultado.Text = "veces presionado: 0";
            lblresultado.Click += lblresultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 88);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 2;
            label1.Text = "presiona \"contar\" para contar pulsasiones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblresultado);
            Controls.Add(btncontar);
            Name = "Form1";
            Text = "conteo de pulsasiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncontar;
        private Label lblresultado;
        private Label label1;
    }
}
