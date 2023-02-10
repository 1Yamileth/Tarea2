namespace Tarea2_MarilynMejia_20211024014
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrimerNota_textBox = new System.Windows.Forms.TextBox();
            this.TercerNota_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cuarta_NotatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SegundaNota_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Promedio_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LIMPIAR_BUTTON = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.RespuestaP_textBox = new System.Windows.Forms.TextBox();
            this.RespuestaN_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDIDOR DE PROMEDIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRIMER NOTA:";
            // 
            // PrimerNota_textBox
            // 
            this.PrimerNota_textBox.Location = new System.Drawing.Point(214, 168);
            this.PrimerNota_textBox.Name = "PrimerNota_textBox";
            this.PrimerNota_textBox.Size = new System.Drawing.Size(100, 20);
            this.PrimerNota_textBox.TabIndex = 2;
            // 
            // TercerNota_textBox
            // 
            this.TercerNota_textBox.Location = new System.Drawing.Point(214, 296);
            this.TercerNota_textBox.Name = "TercerNota_textBox";
            this.TercerNota_textBox.Size = new System.Drawing.Size(100, 20);
            this.TercerNota_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TERCER NOTA:";
            // 
            // Cuarta_NotatextBox
            // 
            this.Cuarta_NotatextBox.Location = new System.Drawing.Point(214, 361);
            this.Cuarta_NotatextBox.Name = "Cuarta_NotatextBox";
            this.Cuarta_NotatextBox.Size = new System.Drawing.Size(100, 20);
            this.Cuarta_NotatextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CUARTA NOTA:";
            // 
            // SegundaNota_textBox
            // 
            this.SegundaNota_textBox.Location = new System.Drawing.Point(214, 235);
            this.SegundaNota_textBox.Name = "SegundaNota_textBox";
            this.SegundaNota_textBox.Size = new System.Drawing.Size(100, 20);
            this.SegundaNota_textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SEGUNDA NOTA:";
            // 
            // Promedio_button
            // 
            this.Promedio_button.Location = new System.Drawing.Point(586, 74);
            this.Promedio_button.Name = "Promedio_button";
            this.Promedio_button.Size = new System.Drawing.Size(147, 23);
            this.Promedio_button.TabIndex = 9;
            this.Promedio_button.Text = "SACAR PROMEDIO";
            this.Promedio_button.UseVisualStyleBackColor = true;
            this.Promedio_button.Click += new System.EventHandler(this.Promedio_button_Click);
            this.Promedio_button.Enter += new System.EventHandler(this.Promedio_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // LIMPIAR_BUTTON
            // 
            this.LIMPIAR_BUTTON.Location = new System.Drawing.Point(586, 116);
            this.LIMPIAR_BUTTON.Name = "LIMPIAR_BUTTON";
            this.LIMPIAR_BUTTON.Size = new System.Drawing.Size(147, 23);
            this.LIMPIAR_BUTTON.TabIndex = 10;
            this.LIMPIAR_BUTTON.Text = "LIMPIAR";
            this.LIMPIAR_BUTTON.UseVisualStyleBackColor = true;
            this.LIMPIAR_BUTTON.Click += new System.EventHandler(this.LIMPIAR_BUTTON_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "INGRESE NOMBRE DEL ALUMNO: ";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(343, 68);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Name_textBox.TabIndex = 12;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PROMEDIO DEL ALUMNO: ";
            // 
            // RespuestaP_textBox
            // 
            this.RespuestaP_textBox.Location = new System.Drawing.Point(684, 296);
            this.RespuestaP_textBox.Name = "RespuestaP_textBox";
            this.RespuestaP_textBox.Size = new System.Drawing.Size(404, 20);
            this.RespuestaP_textBox.TabIndex = 14;
            // 
            // RespuestaN_textBox
            // 
            this.RespuestaN_textBox.Location = new System.Drawing.Point(684, 270);
            this.RespuestaN_textBox.Name = "RespuestaN_textBox";
            this.RespuestaN_textBox.Size = new System.Drawing.Size(404, 20);
            this.RespuestaN_textBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "NOMBRE DEL ALUMNO(A): ";
            // 
            // Form1
            // 
            this.AcceptButton = this.Promedio_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.RespuestaN_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RespuestaP_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LIMPIAR_BUTTON);
            this.Controls.Add(this.Promedio_button);
            this.Controls.Add(this.SegundaNota_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cuarta_NotatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TercerNota_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrimerNota_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimerNota_textBox;
        private System.Windows.Forms.TextBox TercerNota_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cuarta_NotatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SegundaNota_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Promedio_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button LIMPIAR_BUTTON;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.TextBox RespuestaP_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RespuestaN_textBox;
        private System.Windows.Forms.Label label8;
    }
}

