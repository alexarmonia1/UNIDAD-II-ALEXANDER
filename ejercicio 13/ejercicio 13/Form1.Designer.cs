namespace ejercicio_13
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            btniniciar = new Button();
            btndetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(265, 146);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(239, 34);
            progressBar1.TabIndex = 0;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(265, 205);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(112, 34);
            btniniciar.TabIndex = 1;
            btniniciar.Text = "iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // btndetener
            // 
            btndetener.Location = new Point(391, 204);
            btndetener.Name = "btndetener";
            btndetener.Size = new Size(112, 34);
            btndetener.TabIndex = 2;
            btndetener.Text = "detener";
            btndetener.UseVisualStyleBackColor = true;
            btndetener.Click += btndetener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndetener);
            Controls.Add(btniniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "barra de progreso";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btniniciar;
        private Button btndetener;
        private System.Windows.Forms.Timer timer1;
    }
}
