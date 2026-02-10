namespace Ejercicio_4
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnsumar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblresultado = new Label();
            btnclean = new Button();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(299, 129);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 0;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(299, 184);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += textBox2_TextChanged;
            // 
            // btnsumar
            // 
            btnsumar.Location = new Point(299, 236);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(137, 38);
            btnsumar.TabIndex = 2;
            btnsumar.Text = "sumar";
            btnsumar.UseVisualStyleBackColor = true;
            btnsumar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 80);
            label1.Name = "label1";
            label1.Size = new Size(303, 32);
            label1.TabIndex = 3;
            label1.Text = "Introduzca sus numeros:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 129);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 4;
            label2.Text = "Primer Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 184);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 5;
            label3.Text = "Segundo Numero:";
            label3.Click += label3_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(470, 185);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(121, 30);
            lblresultado.TabIndex = 6;
            lblresultado.Text = "Resultado";
            // 
            // btnclean
            // 
            btnclean.Location = new Point(299, 289);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(137, 34);
            btnclean.TabIndex = 7;
            btnclean.Text = "limpiar";
            btnclean.UseVisualStyleBackColor = true;
            btnclean.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclean);
            Controls.Add(lblresultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "SUMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnsumar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblresultado;
        private Button btnclean;
    }
}
