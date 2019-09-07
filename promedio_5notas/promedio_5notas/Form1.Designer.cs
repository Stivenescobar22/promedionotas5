namespace promedio_5notas
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.lblnota5 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota5 = new System.Windows.Forms.TextBox();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblpasoono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(492, 185);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(91, 55);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(174, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(328, 24);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Promedio y Resultado Estudiante";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(106, 83);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(175, 19);
            this.lblnota1.TabIndex = 2;
            this.lblnota1.Text = "ingrese primero nota :";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(101, 141);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(180, 19);
            this.lblnota2.TabIndex = 3;
            this.lblnota2.Text = "ingrese segunda nota :";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(106, 191);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(168, 19);
            this.lblnota3.TabIndex = 4;
            this.lblnota3.Text = "ingrese tercera nota :";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota4.Location = new System.Drawing.Point(110, 240);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(163, 19);
            this.lblnota4.TabIndex = 5;
            this.lblnota4.Text = "ingrese cuarta nota :";
            // 
            // lblnota5
            // 
            this.lblnota5.AutoSize = true;
            this.lblnota5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota5.Location = new System.Drawing.Point(110, 296);
            this.lblnota5.Name = "lblnota5";
            this.lblnota5.Size = new System.Drawing.Size(164, 19);
            this.lblnota5.TabIndex = 6;
            this.lblnota5.Text = "ingrese quinta nota :";
            // 
            // txtnota1
            // 
            this.txtnota1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1.Location = new System.Drawing.Point(317, 84);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 28);
            this.txtnota1.TabIndex = 7;
            // 
            // txtnota2
            // 
            this.txtnota2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2.Location = new System.Drawing.Point(317, 137);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 28);
            this.txtnota2.TabIndex = 8;
            // 
            // txtnota3
            // 
            this.txtnota3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota3.Location = new System.Drawing.Point(317, 182);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 28);
            this.txtnota3.TabIndex = 9;
            // 
            // txtnota4
            // 
            this.txtnota4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota4.Location = new System.Drawing.Point(317, 241);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 28);
            this.txtnota4.TabIndex = 10;
            // 
            // txtnota5
            // 
            this.txtnota5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota5.Location = new System.Drawing.Point(317, 297);
            this.txtnota5.Name = "txtnota5";
            this.txtnota5.Size = new System.Drawing.Size(100, 28);
            this.txtnota5.TabIndex = 11;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(183, 354);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(91, 19);
            this.lblpromedio.TabIndex = 12;
            this.lblpromedio.Text = "Promedio :";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(313, 354);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(84, 19);
            this.lblresultado.TabIndex = 13;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // lblpasoono
            // 
            this.lblpasoono.AutoSize = true;
            this.lblpasoono.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasoono.Location = new System.Drawing.Point(419, 354);
            this.lblpasoono.Name = "lblpasoono";
            this.lblpasoono.Size = new System.Drawing.Size(83, 19);
            this.lblpasoono.TabIndex = 14;
            this.lblpasoono.Text = "paso o no";
            this.lblpasoono.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpasoono);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.txtnota5);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lblnota5);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.Label lblnota5;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota5;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblpasoono;
    }
}

