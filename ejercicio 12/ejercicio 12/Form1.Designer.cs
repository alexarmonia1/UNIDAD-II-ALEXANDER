namespace ejercicio_12
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
            txtcelsius = new TextBox();
            btnconvertir = new Button();
            lblresultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtcelsius
            // 
            txtcelsius.Location = new Point(248, 136);
            txtcelsius.Name = "txtcelsius";
            txtcelsius.Size = new Size(150, 31);
            txtcelsius.TabIndex = 0;
            // 
            // btnconvertir
            // 
            btnconvertir.Location = new Point(286, 187);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.Size = new Size(112, 34);
            btnconvertir.TabIndex = 1;
            btnconvertir.Text = "convertir";
            btnconvertir.UseVisualStyleBackColor = true;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(413, 139);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(86, 25);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 94);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 3;
            label1.Text = "INGRESE SU GRADO CELSIUS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblresultado);
            Controls.Add(btnconvertir);
            Controls.Add(txtcelsius);
            Name = "Form1";
            Text = "CONVERTIDOR DE CELSIUS A F";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcelsius;
        private Button btnconvertir;
        private Label lblresultado;
        private Label label1;
    }
}
