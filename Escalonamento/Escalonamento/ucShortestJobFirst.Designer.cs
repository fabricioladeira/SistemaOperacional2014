﻿namespace Escalonamento
{
    partial class ucShortestJobFirst
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTempoExecucao = new System.Windows.Forms.ComboBox();
            this.btnAdicionarProcesso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProcessos = new System.Windows.Forms.DataGridView();
            this.Processo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadeDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempoExecucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTempoExecucao);
            this.groupBox1.Controls.Add(this.btnAdicionarProcesso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Processos";
            // 
            // cboTempoExecucao
            // 
            this.cboTempoExecucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTempoExecucao.FormattingEnabled = true;
            this.cboTempoExecucao.Items.AddRange(new object[] {
            "10",
            "8",
            "7",
            "6",
            "5",
            "4"});
            this.cboTempoExecucao.Location = new System.Drawing.Point(117, 25);
            this.cboTempoExecucao.Name = "cboTempoExecucao";
            this.cboTempoExecucao.Size = new System.Drawing.Size(121, 21);
            this.cboTempoExecucao.TabIndex = 15;
            // 
            // btnAdicionarProcesso
            // 
            this.btnAdicionarProcesso.Location = new System.Drawing.Point(688, 49);
            this.btnAdicionarProcesso.Name = "btnAdicionarProcesso";
            this.btnAdicionarProcesso.Size = new System.Drawing.Size(151, 23);
            this.btnAdicionarProcesso.TabIndex = 13;
            this.btnAdicionarProcesso.Text = "Adicionar Processo";
            this.btnAdicionarProcesso.UseVisualStyleBackColor = true;
            this.btnAdicionarProcesso.Click += new System.EventHandler(this.btnAdicionarProcesso_Click);
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
            // dgvProcessos
            // 
            this.dgvProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Processo,
            this.colId,
            this.PrioridadeDefault,
            this.colPrioridade,
            this.Inicio,
            this.Fim,
            this.colTempoExecucao,
            this.colTempoEspera,
            this.colAtivo});
            this.dgvProcessos.Location = new System.Drawing.Point(3, 81);
            this.dgvProcessos.Name = "dgvProcessos";
            this.dgvProcessos.ReadOnly = true;
            this.dgvProcessos.Size = new System.Drawing.Size(845, 277);
            this.dgvProcessos.TabIndex = 21;
            // 
            // Processo
            // 
            this.Processo.DataPropertyName = "NomeProcesso";
            this.Processo.HeaderText = "Processo";
            this.Processo.Name = "Processo";
            this.Processo.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // PrioridadeDefault
            // 
            this.PrioridadeDefault.DataPropertyName = "PrioridadeDefault";
            this.PrioridadeDefault.HeaderText = "Prioridade Default";
            this.PrioridadeDefault.Name = "PrioridadeDefault";
            this.PrioridadeDefault.ReadOnly = true;
            // 
            // colPrioridade
            // 
            this.colPrioridade.DataPropertyName = "Prioridade";
            this.colPrioridade.HeaderText = "Prioridade";
            this.colPrioridade.Name = "colPrioridade";
            this.colPrioridade.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "Inicio";
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Fim
            // 
            this.Fim.DataPropertyName = "Fim";
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            this.Fim.ReadOnly = true;
            // 
            // colTempoExecucao
            // 
            this.colTempoExecucao.DataPropertyName = "TempoExecucao";
            this.colTempoExecucao.HeaderText = "Tempo Execução";
            this.colTempoExecucao.Name = "colTempoExecucao";
            this.colTempoExecucao.ReadOnly = true;
            // 
            // colTempoEspera
            // 
            this.colTempoEspera.DataPropertyName = "Espera";
            this.colTempoEspera.HeaderText = "Espera";
            this.colTempoEspera.Name = "colTempoEspera";
            this.colTempoEspera.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(688, 374);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(157, 23);
            this.btnExecutar.TabIndex = 22;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ucShortestJobFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.dgvProcessos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucShortestJobFirst";
            this.Size = new System.Drawing.Size(857, 413);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTempoExecucao;
        private System.Windows.Forms.Button btnAdicionarProcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioridadeDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempoExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.Button btnExecutar;

    }
}
