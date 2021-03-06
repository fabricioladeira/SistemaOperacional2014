﻿namespace Escalonamento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            //this.btnExecutar_Click = new System.Windows.Forms.Button();
            this.ucFifo1 = new Escalonamento.ucFifo();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucShortestJobFirst1 = new Escalonamento.ucShortestJobFirst();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucPrioridade1 = new Escalonamento.ucPrioridade();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucRoundRobin1 = new Escalonamento.ucRoundRobin();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            //this.tabPage1.Controls.Add(this.btnExecutar_Click);
            this.tabPage1.Controls.Add(this.ucFifo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FIFO (First In First Out)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExecutar_Click
            // 
          /*  this.btnExecutar_Click.Location = new System.Drawing.Point(705, 376);
            this.btnExecutar_Click.Name = "btnExecutar_Click";
            this.btnExecutar_Click.Size = new System.Drawing.Size(124, 23);
            this.btnExecutar_Click.TabIndex = 4;
            this.btnExecutar_Click.Text = "Executar";
            this.btnExecutar_Click.UseVisualStyleBackColor = true;
          */  // 
            // ucFifo1
            // 
            this.ucFifo1.Location = new System.Drawing.Point(4, 2);
            this.ucFifo1.Name = "ucFifo1";
            this.ucFifo1.Size = new System.Drawing.Size(857, 413);
            this.ucFifo1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucShortestJobFirst1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "(Shortest Job First)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucShortestJobFirst1
            // 
            this.ucShortestJobFirst1.Location = new System.Drawing.Point(4, 3);
            this.ucShortestJobFirst1.Name = "ucShortestJobFirst1";
            this.ucShortestJobFirst1.Size = new System.Drawing.Size(857, 413);
            this.ucShortestJobFirst1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucPrioridade1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(867, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Prioridade";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ucPrioridade1
            // 
            this.ucPrioridade1.Location = new System.Drawing.Point(0, 6);
            this.ucPrioridade1.Name = "ucPrioridade1";
            this.ucPrioridade1.Size = new System.Drawing.Size(857, 413);
            this.ucPrioridade1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucRoundRobin1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(867, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Round Robin ou Circular";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ucRoundRobin1
            // 
            this.ucRoundRobin1.Location = new System.Drawing.Point(3, 2);
            this.ucRoundRobin1.Name = "ucRoundRobin1";
            this.ucRoundRobin1.Size = new System.Drawing.Size(857, 413);
            this.ucRoundRobin1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Escalonamento";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3; 
        private System.Windows.Forms.TabPage tabPage4;
        private ucPrioridade ucPrioridade1;
        private ucFifo ucFifo1;
        private ucShortestJobFirst ucShortestJobFirst1;
        private ucRoundRobin ucRoundRobin1;
       // private System.Windows.Forms.Button btnExecutar_Click;
    }
}

