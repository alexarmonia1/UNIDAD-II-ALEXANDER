namespace ejercicio_11
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
            dtpfecha = new DateTimePicker();
            btnmostrar = new Button();
            lblfecha = new Label();
            SuspendLayout();
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(229, 107);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(300, 31);
            dtpfecha.TabIndex = 0;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(312, 154);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(112, 34);
            btnmostrar.TabIndex = 1;
            btnmostrar.Text = "mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new Point(334, 215);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(54, 25);
            lblfecha.TabIndex = 2;
            lblfecha.Text = "fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblfecha);
            Controls.Add(btnmostrar);
            Controls.Add(dtpfecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpfecha;
        private Button btnmostrar;
        private Label lblfecha;
    }
}
