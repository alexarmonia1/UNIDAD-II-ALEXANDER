namespace ejercicio_6
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
            cmbcolors = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbcolors
            // 
            cmbcolors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcolors.FormattingEnabled = true;
            cmbcolors.Items.AddRange(new object[] { "rojo", "verde", "azul" });
            cmbcolors.Location = new Point(293, 164);
            cmbcolors.Name = "cmbcolors";
            cmbcolors.Size = new Size(182, 33);
            cmbcolors.TabIndex = 0;
            cmbcolors.SelectedIndexChanged += cmbcolors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 114);
            label1.Name = "label1";
            label1.Size = new Size(504, 32);
            label1.TabIndex = 1;
            label1.Text = "Seleccione un color para cambiar el fondo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbcolors);
            Name = "Form1";
            Text = "cambiar fondo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbcolors;
        private Label label1;
    }
}
