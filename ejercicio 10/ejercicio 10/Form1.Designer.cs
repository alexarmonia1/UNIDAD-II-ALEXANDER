namespace ejercicio_10
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
            btnmostrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(318, 173);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(112, 34);
            btnmostrar.TabIndex = 0;
            btnmostrar.Text = "mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 123);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 1;
            label1.Text = "HAZ CLIC AQUI:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnmostrar);
            Name = "Form1";
            Text = "mostrar ventana:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnmostrar;
        private Label label1;
    }
}
