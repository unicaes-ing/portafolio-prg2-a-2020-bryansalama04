namespace Practica2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLong_Conv = new System.Windows.Forms.TextBox();
            this.txtLongConvertida = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.listConvert = new System.Windows.Forms.ListBox();
            this.listConvert2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca la Longitud que quire convertir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud Convertida:";
            // 
            // txtLong_Conv
            // 
            this.txtLong_Conv.Location = new System.Drawing.Point(276, 29);
            this.txtLong_Conv.Name = "txtLong_Conv";
            this.txtLong_Conv.Size = new System.Drawing.Size(112, 20);
            this.txtLong_Conv.TabIndex = 2;
            // 
            // txtLongConvertida
            // 
            this.txtLongConvertida.Location = new System.Drawing.Point(191, 269);
            this.txtLongConvertida.Name = "txtLongConvertida";
            this.txtLongConvertida.Size = new System.Drawing.Size(144, 20);
            this.txtLongConvertida.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listConvert);
            this.groupBox1.Location = new System.Drawing.Point(51, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listConvert2);
            this.groupBox2.Location = new System.Drawing.Point(242, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(102, 335);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(242, 335);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // listConvert
            // 
            this.listConvert.FormattingEnabled = true;
            this.listConvert.Items.AddRange(new object[] {
            "Pulgadas",
            "Pie",
            "Yardas"});
            this.listConvert.Location = new System.Drawing.Point(17, 28);
            this.listConvert.Name = "listConvert";
            this.listConvert.Size = new System.Drawing.Size(120, 95);
            this.listConvert.TabIndex = 5;
            // 
            // listConvert2
            // 
            this.listConvert2.FormattingEnabled = true;
            this.listConvert2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pie",
            "Yardas"});
            this.listConvert2.Location = new System.Drawing.Point(6, 19);
            this.listConvert2.Name = "listConvert2";
            this.listConvert2.Size = new System.Drawing.Size(120, 95);
            this.listConvert2.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLongConvertida);
            this.Controls.Add(this.txtLong_Conv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLong_Conv;
        private System.Windows.Forms.TextBox txtLongConvertida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listConvert2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}