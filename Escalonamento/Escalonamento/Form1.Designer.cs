namespace Escalonamento
{
    partial class Form1
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tempExecucao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.prioridade = new System.Windows.Forms.NumericUpDown();
            this.qtdProcessos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fatiaTempoDisponivel = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Processo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempoExecucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdProcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatiaTempoDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(618, 283);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar Processo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo Execução";
            // 
            // tempExecucao
            // 
            this.tempExecucao.Location = new System.Drawing.Point(117, 26);
            this.tempExecucao.Name = "tempExecucao";
            this.tempExecucao.Size = new System.Drawing.Size(57, 20);
            this.tempExecucao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prioridade";
            // 
            // prioridade
            // 
            this.prioridade.Location = new System.Drawing.Point(117, 52);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(57, 20);
            this.prioridade.TabIndex = 7;
            // 
            // qtdProcessos
            // 
            this.qtdProcessos.Location = new System.Drawing.Point(128, 16);
            this.qtdProcessos.Name = "qtdProcessos";
            this.qtdProcessos.Size = new System.Drawing.Size(57, 20);
            this.qtdProcessos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtd Processos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fatia de Tempo Disponivel";
            // 
            // fatiaTempoDisponivel
            // 
            this.fatiaTempoDisponivel.Location = new System.Drawing.Point(349, 16);
            this.fatiaTempoDisponivel.Name = "fatiaTempoDisponivel";
            this.fatiaTempoDisponivel.Size = new System.Drawing.Size(57, 20);
            this.fatiaTempoDisponivel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Processo,
            this.Inicio,
            this.Fim,
            this.colPrioridade,
            this.colTempoExecucao,
            this.colTempoEspera});
            this.dataGridView1.Location = new System.Drawing.Point(22, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Processo
            // 
            this.Processo.HeaderText = "Processo";
            this.Processo.Name = "Processo";
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            // 
            // Fim
            // 
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            // 
            // colPrioridade
            // 
            this.colPrioridade.HeaderText = "Prioridade";
            this.colPrioridade.Name = "colPrioridade";
            // 
            // colTempoExecucao
            // 
            this.colTempoExecucao.HeaderText = "Tempo Execução";
            this.colTempoExecucao.Name = "colTempoExecucao";
            // 
            // colTempoEspera
            // 
            this.colTempoEspera.HeaderText = "Espera";
            this.colTempoEspera.Name = "colTempoEspera";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tempExecucao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prioridade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Processos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fatiaTempoDisponivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtdProcessos);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Escalonamento";
            ((System.ComponentModel.ISupportInitialize)(this.tempExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdProcessos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatiaTempoDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tempExecucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown prioridade;
        private System.Windows.Forms.NumericUpDown qtdProcessos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown fatiaTempoDisponivel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempoExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempoEspera;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

