namespace Exercicio_Calcular_Imposto_Carro_Importado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCilindrada = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCo2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbCombustivel = new System.Windows.Forms.GroupBox();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbGasolina = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalImpostos = new System.Windows.Forms.Label();
            this.grbCombustivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cilindrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nivel Co2";
            // 
            // mtxtCilindrada
            // 
            this.mtxtCilindrada.Location = new System.Drawing.Point(102, 58);
            this.mtxtCilindrada.Mask = "00009";
            this.mtxtCilindrada.Name = "mtxtCilindrada";
            this.mtxtCilindrada.Size = new System.Drawing.Size(100, 20);
            this.mtxtCilindrada.TabIndex = 4;
            this.mtxtCilindrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtCo2
            // 
            this.mtxtCo2.Location = new System.Drawing.Point(102, 82);
            this.mtxtCo2.Mask = "099";
            this.mtxtCo2.Name = "mtxtCo2";
            this.mtxtCo2.Size = new System.Drawing.Size(100, 20);
            this.mtxtCo2.TabIndex = 5;
            this.mtxtCo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "cm3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "g/km";
            // 
            // grbCombustivel
            // 
            this.grbCombustivel.Controls.Add(this.rbOutros);
            this.grbCombustivel.Controls.Add(this.rbGasolina);
            this.grbCombustivel.Location = new System.Drawing.Point(15, 119);
            this.grbCombustivel.Name = "grbCombustivel";
            this.grbCombustivel.Size = new System.Drawing.Size(287, 74);
            this.grbCombustivel.TabIndex = 8;
            this.grbCombustivel.TabStop = false;
            this.grbCombustivel.Text = "Combustível";
            this.grbCombustivel.Enter += new System.EventHandler(this.grbCombustivel_Enter);
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Location = new System.Drawing.Point(155, 33);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(54, 17);
            this.rbOutros.TabIndex = 1;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            this.rbOutros.CheckedChanged += new System.EventHandler(this.rbOutros_CheckedChanged);
            // 
            // rbGasolina
            // 
            this.rbGasolina.AutoSize = true;
            this.rbGasolina.Location = new System.Drawing.Point(43, 33);
            this.rbGasolina.Name = "rbGasolina";
            this.rbGasolina.Size = new System.Drawing.Size(66, 17);
            this.rbGasolina.TabIndex = 0;
            this.rbGasolina.TabStop = true;
            this.rbGasolina.Text = "Gasolina";
            this.rbGasolina.UseVisualStyleBackColor = true;
            this.rbGasolina.CheckedChanged += new System.EventHandler(this.rbGasolina_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(58, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(215, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Impostos";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total de Impostos";
            // 
            // lblTotalImpostos
            // 
            this.lblTotalImpostos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalImpostos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalImpostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImpostos.ForeColor = System.Drawing.Color.Red;
            this.lblTotalImpostos.Location = new System.Drawing.Point(158, 268);
            this.lblTotalImpostos.Name = "lblTotalImpostos";
            this.lblTotalImpostos.Size = new System.Drawing.Size(85, 22);
            this.lblTotalImpostos.TabIndex = 10;
            this.lblTotalImpostos.Text = "label7";
            this.lblTotalImpostos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 300);
            this.Controls.Add(this.lblTotalImpostos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbCombustivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtCo2);
            this.Controls.Add(this.mtxtCilindrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Veículos Importados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCombustivel.ResumeLayout(false);
            this.grbCombustivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCilindrada;
        private System.Windows.Forms.MaskedTextBox mtxtCo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbCombustivel;
        private System.Windows.Forms.RadioButton rbOutros;
        private System.Windows.Forms.RadioButton rbGasolina;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalImpostos;
    }
}

