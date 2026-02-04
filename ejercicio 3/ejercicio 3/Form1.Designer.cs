namespace ejercicio_3
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
            btnagregar = new Button();
            label1 = new Label();
            lblresultado = new Label();
            tbxdetalles = new TextBox();
            SuspendLayout();
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(321, 185);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 34);
            btnagregar.TabIndex = 0;
            btnagregar.Text = "agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 92);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su Texto aqui:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = SystemColors.MenuBar;
            lblresultado.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(321, 239);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(120, 25);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "RESULTADO";
            // 
            // tbxdetalles
            // 
            tbxdetalles.Location = new Point(304, 136);
            tbxdetalles.Name = "tbxdetalles";
            tbxdetalles.Size = new Size(150, 31);
            tbxdetalles.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxdetalles);
            Controls.Add(lblresultado);
            Controls.Add(label1);
            Controls.Add(btnagregar);
            Name = "Form1";
            Text = "DE TEXTBOX A LABEL";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnagregar;
        private Label label1;
        private Label lblresultado;
        private TextBox tbxdetalles;
    }
}
