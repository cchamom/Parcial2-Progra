namespace CapitalFinalDeAhorroPlazoFijo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Monto_Inicial = new System.Windows.Forms.TextBox();
            this.txt_Interes_Anual = new System.Windows.Forms.TextBox();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_IntAcumulado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE CAPITAL FINAL DE AHORROS A PLAZOS FIJOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "MONTO INICIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "TASA DE INTERS ANUAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "PERIODO DE TIEMPO(meses)";
            // 
            // txt_Monto_Inicial
            // 
            this.txt_Monto_Inicial.Location = new System.Drawing.Point(450, 121);
            this.txt_Monto_Inicial.Name = "txt_Monto_Inicial";
            this.txt_Monto_Inicial.Size = new System.Drawing.Size(231, 22);
            this.txt_Monto_Inicial.TabIndex = 4;
            // 
            // txt_Interes_Anual
            // 
            this.txt_Interes_Anual.Location = new System.Drawing.Point(450, 176);
            this.txt_Interes_Anual.Name = "txt_Interes_Anual";
            this.txt_Interes_Anual.Size = new System.Drawing.Size(231, 22);
            this.txt_Interes_Anual.TabIndex = 5;
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(450, 235);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(231, 22);
            this.txt_Tiempo.TabIndex = 6;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Calcular.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(147, 346);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(179, 37);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "CAPITAL FINAL";
            // 
            // btn_IntAcumulado
            // 
            this.btn_IntAcumulado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_IntAcumulado.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IntAcumulado.Location = new System.Drawing.Point(479, 346);
            this.btn_IntAcumulado.Name = "btn_IntAcumulado";
            this.btn_IntAcumulado.Size = new System.Drawing.Size(179, 37);
            this.btn_IntAcumulado.TabIndex = 9;
            this.btn_IntAcumulado.Text = "CALCULAR";
            this.btn_IntAcumulado.UseVisualStyleBackColor = false;
            this.btn_IntAcumulado.Click += new System.EventHandler(this.btn_IntAcumulado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "INTERES FINAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_IntAcumulado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Tiempo);
            this.Controls.Add(this.txt_Interes_Anual);
            this.Controls.Add(this.txt_Monto_Inicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Monto_Inicial;
        private System.Windows.Forms.TextBox txt_Interes_Anual;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_IntAcumulado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

