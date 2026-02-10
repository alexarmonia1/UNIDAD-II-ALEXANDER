namespace ejercicio_5
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
            groupBox1 = new GroupBox();
            lblresultado = new Label();
            btnaceptar = new Button();
            rbOpcion3 = new RadioButton();
            rbOpcion2 = new RadioButton();
            rbOpcion1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblresultado);
            groupBox1.Controls.Add(btnaceptar);
            groupBox1.Controls.Add(rbOpcion3);
            groupBox1.Controls.Add(rbOpcion2);
            groupBox1.Controls.Add(rbOpcion1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(208, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione la opcion que desee:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(40, 234);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(120, 26);
            lblresultado.TabIndex = 4;
            lblresultado.Text = "Resultado";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(48, 174);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(112, 34);
            btnaceptar.TabIndex = 3;
            btnaceptar.Text = "Aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // rbOpcion3
            // 
            rbOpcion3.AutoSize = true;
            rbOpcion3.Location = new Point(38, 131);
            rbOpcion3.Name = "rbOpcion3";
            rbOpcion3.Size = new Size(132, 30);
            rbOpcion3.TabIndex = 2;
            rbOpcion3.TabStop = true;
            rbOpcion3.Text = "Opcion 3";
            rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            rbOpcion2.AutoSize = true;
            rbOpcion2.Location = new Point(38, 96);
            rbOpcion2.Name = "rbOpcion2";
            rbOpcion2.Size = new Size(132, 30);
            rbOpcion2.TabIndex = 1;
            rbOpcion2.TabStop = true;
            rbOpcion2.Text = "Opcion 2";
            rbOpcion2.UseVisualStyleBackColor = true;
            rbOpcion2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // rbOpcion1
            // 
            rbOpcion1.AutoSize = true;
            rbOpcion1.Location = new Point(38, 61);
            rbOpcion1.Name = "rbOpcion1";
            rbOpcion1.Size = new Size(132, 30);
            rbOpcion1.TabIndex = 0;
            rbOpcion1.TabStop = true;
            rbOpcion1.Text = "Opcion 1";
            rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Seleccion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbOpcion3;
        private RadioButton rbOpcion2;
        private RadioButton rbOpcion1;
        private Label lblresultado;
        private Button btnaceptar;
    }
}
