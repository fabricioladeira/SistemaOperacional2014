using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escalonamento
{
    public partial class Form1 : Form
    {

        #region ---- FIFO (First In First Out)




        #endregion


        #region ---- (Shortest Job First)




        #endregion


        #region ---- Algoritimo Prioridades

        private int id = 0;
        private List<Processo> lista = new List<Processo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            id++;

            lista.Add(new Processo()
            {
                Id = id,
                NomeProcesso = string.Format("P{0}", id),
                Prioridade = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                Inicio = System.DateTime.Now
            });

            DataBind();
        }


        private void DataBind()
        {
            this.dgvProcessos.DataSource = null;
            this.dgvProcessos.DataSource = lista;       
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

        }


        #endregion



        #region ---- Round Robin ou Circular


        #endregion



    }
}
