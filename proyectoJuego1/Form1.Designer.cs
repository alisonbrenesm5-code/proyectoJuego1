namespace proyectoJuego1
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
            helpProvider1 = new HelpProvider();
            panel1 = new Panel();
            baccapetar = new Button();
            tresultado = new TextBox();
            label3 = new Label();
            res = new Label();
            n2 = new Label();
            op = new Label();
            n1 = new Label();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lerrores = new Label();
            laciertos = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(baccapetar);
            panel1.Controls.Add(tresultado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(res);
            panel1.Controls.Add(n2);
            panel1.Controls.Add(op);
            panel1.Controls.Add(n1);
            panel1.Location = new Point(177, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 370);
            panel1.TabIndex = 0;
            // 
            // baccapetar
            // 
            baccapetar.Location = new Point(20, 251);
            baccapetar.Name = "baccapetar";
            baccapetar.Size = new Size(353, 81);
            baccapetar.TabIndex = 6;
            baccapetar.Text = "Acceptar";
            baccapetar.UseVisualStyleBackColor = true;
            // 
            // tresultado
            // 
            tresultado.Location = new Point(18, 166);
            tresultado.Name = "tresultado";
            tresultado.Size = new Size(150, 31);
            tresultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 14);
            label3.Name = "label3";
            label3.Size = new Size(353, 38);
            label3.TabIndex = 4;
            label3.Text = "Digite el resultado:";
            // 
            // res
            // 
            res.BorderStyle = BorderStyle.FixedSingle;
            res.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            res.Location = new Point(257, 92);
            res.Name = "res";
            res.Size = new Size(53, 38);
            res.TabIndex = 3;
            res.Text = "=?";
            // 
            // n2
            // 
            n2.BorderStyle = BorderStyle.FixedSingle;
            n2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n2.Location = new Point(175, 92);
            n2.Name = "n2";
            n2.Size = new Size(33, 38);
            n2.TabIndex = 2;
            // 
            // op
            // 
            op.BorderStyle = BorderStyle.FixedSingle;
            op.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op.Location = new Point(98, 92);
            op.Name = "op";
            op.Size = new Size(33, 38);
            op.TabIndex = 1;
            // 
            // n1
            // 
            n1.BorderStyle = BorderStyle.FixedSingle;
            n1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n1.Location = new Point(20, 92);
            n1.Name = "n1";
            n1.Size = new Size(33, 38);
            n1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 53);
            label1.Name = "label1";
            label1.Size = new Size(278, 47);
            label1.TabIndex = 1;
            label1.Text = "Juego Aritmetica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(776, 115);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 2;
            label2.Text = "Cantidad Jugadores";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(783, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Uno";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(874, 153);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dos";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(783, 276);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 5;
            label4.Text = "Puntaje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 6;
            label5.Text = "Errores";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 276);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 7;
            label6.Text = "Aciertos";
            // 
            // lerrores
            // 
            lerrores.AutoSize = true;
            lerrores.Location = new Point(29, 150);
            lerrores.Name = "lerrores";
            lerrores.Size = new Size(23, 25);
            lerrores.TabIndex = 8;
            lerrores.Text = "0";
            // 
            // laciertos
            // 
            laciertos.AutoSize = true;
            laciertos.Location = new Point(26, 310);
            laciertos.Name = "laciertos";
            laciertos.Size = new Size(23, 25);
            laciertos.TabIndex = 9;
            laciertos.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(969, 567);
            Controls.Add(laciertos);
            Controls.Add(lerrores);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Juego Aritmetica";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private Panel panel1;
        private Label label1;
        private Label n1;
        private Label n2;
        private Label op;
        private Label res;
        private Label label3;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button baccapetar;
        private TextBox tresultado;
        private Label lerrores;
        private Label laciertos;
    }
}
