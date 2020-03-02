namespace Practica3
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHTrabajadas = new System.Windows.Forms.TextBox();
            this.txtVhora = new System.Windows.Forms.TextBox();
            this.dvgPlanilla = new System.Windows.Forms.DataGridView();
            this.Column_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_HrTrabj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Vhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de la hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Planilla:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtHTrabajadas
            // 
            this.txtHTrabajadas.Location = new System.Drawing.Point(141, 77);
            this.txtHTrabajadas.Name = "txtHTrabajadas";
            this.txtHTrabajadas.Size = new System.Drawing.Size(183, 20);
            this.txtHTrabajadas.TabIndex = 5;
            // 
            // txtVhora
            // 
            this.txtVhora.Location = new System.Drawing.Point(141, 124);
            this.txtVhora.Name = "txtVhora";
            this.txtVhora.Size = new System.Drawing.Size(183, 20);
            this.txtVhora.TabIndex = 6;
            // 
            // dvgPlanilla
            // 
            this.dvgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nombre,
            this.Column_HrTrabj,
            this.Column_Vhora,
            this.Column_Subt,
            this.Column_Imp,
            this.Column_Total});
            this.dvgPlanilla.Location = new System.Drawing.Point(35, 226);
            this.dvgPlanilla.Name = "dvgPlanilla";
            this.dvgPlanilla.Size = new System.Drawing.Size(646, 150);
            this.dvgPlanilla.TabIndex = 7;
            // 
            // Column_Nombre
            // 
            this.Column_Nombre.HeaderText = "Nombre";
            this.Column_Nombre.Name = "Column_Nombre";
            // 
            // Column_HrTrabj
            // 
            this.Column_HrTrabj.HeaderText = "Horas Trabajadas";
            this.Column_HrTrabj.Name = "Column_HrTrabj";
            // 
            // Column_Vhora
            // 
            this.Column_Vhora.HeaderText = "Valor Hora";
            this.Column_Vhora.Name = "Column_Vhora";
            // 
            // Column_Subt
            // 
            this.Column_Subt.HeaderText = "Subtotal";
            this.Column_Subt.Name = "Column_Subt";
            // 
            // Column_Imp
            // 
            this.Column_Imp.HeaderText = "Impuesto";
            this.Column_Imp.Name = "Column_Imp";
            // 
            // Column_Total
            // 
            this.Column_Total.HeaderText = "Total";
            this.Column_Total.Name = "Column_Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(43, 405);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(553, 410);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 446);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dvgPlanilla);
            this.Controls.Add(this.txtVhora);
            this.Controls.Add(this.txtHTrabajadas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHTrabajadas;
        private System.Windows.Forms.TextBox txtVhora;
        private System.Windows.Forms.DataGridView dvgPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_HrTrabj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Vhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Subt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Total;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTotal;
    }
}