namespace Form2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonenter = new System.Windows.Forms.Button();
            this.textBoxn2 = new System.Windows.Forms.TextBox();
            this.textBoxn1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.BotonMultiplicar = new System.Windows.Forms.Button();
            this.BotonDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba su nombre";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnombre.Location = new System.Drawing.Point(192, 68);
            this.textBoxnombre.Multiline = true;
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(439, 44);
            this.textBoxnombre.TabIndex = 1;
            this.textBoxnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(284, 156);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(232, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // botonenter
            // 
            this.botonenter.Location = new System.Drawing.Point(665, 71);
            this.botonenter.Name = "botonenter";
            this.botonenter.Size = new System.Drawing.Size(93, 41);
            this.botonenter.TabIndex = 4;
            this.botonenter.Text = "Entrar";
            this.botonenter.UseVisualStyleBackColor = true;
            this.botonenter.Click += new System.EventHandler(this.Saludo_Click);
            // 
            // textBoxn2
            // 
            this.textBoxn2.Location = new System.Drawing.Point(343, 236);
            this.textBoxn2.Name = "textBoxn2";
            this.textBoxn2.Size = new System.Drawing.Size(100, 22);
            this.textBoxn2.TabIndex = 5;
            // 
            // textBoxn1
            // 
            this.textBoxn1.Location = new System.Drawing.Point(343, 208);
            this.textBoxn1.Name = "textBoxn1";
            this.textBoxn1.Size = new System.Drawing.Size(100, 22);
            this.textBoxn1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonResta
            // 
            this.botonResta.Location = new System.Drawing.Point(320, 265);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(75, 23);
            this.botonResta.TabIndex = 10;
            this.botonResta.Text = "Restar";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // BotonMultiplicar
            // 
            this.BotonMultiplicar.Location = new System.Drawing.Point(488, 265);
            this.BotonMultiplicar.Name = "BotonMultiplicar";
            this.BotonMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.BotonMultiplicar.TabIndex = 11;
            this.BotonMultiplicar.Text = "Multiplicar";
            this.BotonMultiplicar.UseVisualStyleBackColor = true;
            this.BotonMultiplicar.Click += new System.EventHandler(this.BotonMultiplicar_Click);
            // 
            // BotonDividir
            // 
            this.BotonDividir.Location = new System.Drawing.Point(407, 265);
            this.BotonDividir.Name = "BotonDividir";
            this.BotonDividir.Size = new System.Drawing.Size(75, 23);
            this.BotonDividir.TabIndex = 12;
            this.BotonDividir.Text = "Dividir";
            this.BotonDividir.UseVisualStyleBackColor = true;
            this.BotonDividir.Click += new System.EventHandler(this.BotonDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 406);
            this.Controls.Add(this.BotonDividir);
            this.Controls.Add(this.BotonMultiplicar);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxn1);
            this.Controls.Add(this.textBoxn2);
            this.Controls.Add(this.botonenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonenter;
        private System.Windows.Forms.TextBox textBoxn2;
        private System.Windows.Forms.TextBox textBoxn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button BotonMultiplicar;
        private System.Windows.Forms.Button BotonDividir;
    }
}

