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
                Prioridade = this.prioridade.Value,
                TempoExecucao = this.tempExecucao.Value,
                Inicio = System.DateTime.Now
            });

            DataBind();
        }


        private void DataBind()
        {
            this.dgvProcessos.DataSource = null;
            this.dgvProcessos.DataSource = lista;       
        }

    }
}
