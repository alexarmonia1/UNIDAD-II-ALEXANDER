namespace Ejercicio_2
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
            lblmostrar = new Label();
            btncambiar = new Button();
            SuspendLayout();
            // 
            // lblmostrar
            // 
            lblmostrar.AutoSize = true;
            lblmostrar.Location = new Point(286, 117);
            lblmostrar.Name = "lblmostrar";
            lblmostrar.Size = new Size(172, 25);
            lblmostrar.TabIndex = 0;
            lblmostrar.Text = "esperando cambio...";
            // 
            // btncambiar
            // 
            btncambiar.Location = new Point(299, 166);
            btncambiar.Name = "btncambiar";
            btncambiar.Size = new Size(132, 37);
            btncambiar.TabIndex = 1;
            btncambiar.Text = "cambiar ";
            btncambiar.UseVisualStyleBackColor = true;
            btncambiar.Click += btncambiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncambiar);
            Controls.Add(lblmostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmostrar;
        private Button btncambiar;
    }
}
