using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escalonamento
{
    public partial class ucShortestJobFirst : UserControl
    {
        //Contador do tempo
        private int contadorTempo = 1;

        //Controlador para os ids dos processos criados
        private int id = 0;

        //Lista de processos na memória
        private List<Processo> listaProcessos = new List<Processo>();


        public ucShortestJobFirst()
        {
            InitializeComponent();

            DataBind();
        }

        /// <summary>
        /// Coloca dados da lista de processos no Grid
        /// </summary>
        private void DataBind()
        {
            this.dgvProcessos.DataSource = null;
            this.dgvProcessos.DataSource = listaProcessos;
            this.dgvProcessos.Refresh();
        }


        /// <summary>
        /// Adiciona processo na lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            id++;

            listaProcessos.Add(new Processo()
            {
                Id = id,
                NomeProcesso = string.Format("P{0}", id),
                TempoExecucaoDefault = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                //Prioridade=Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                //PrioridadeDefault = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                Ativo = true
            });

            DataBind();


        }


        /// <summary>
        /// executa processos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int i = GetIndexProcessoAtivo();

            //Executa enquanto hover processo ativo
            while (i != -1)
            {
                //Decrementa o tempo de execução
                listaProcessos[i].TempoExecucao--;

                //Marca Inicio
                if (listaProcessos[i].Inicio == 0)
                    listaProcessos[i].Inicio = contadorTempo;

                //Marca FIM              
                listaProcessos[i].Fim = contadorTempo;


                //Verifica se o tempo de execucao chegou a zero e inativa o processo
                if (listaProcessos[i].TempoExecucao == 0)
                {
                    listaProcessos[i].Ativo = false;

                    //if (contadorTempo % 2 == 0)
                    //{
                    //Pega proximo da fila
                    int tmp = i + 1;
                    i = GetIndexProcessoAtivo();

                    //Valida novamente todo array para verificar se não tem nenhum antes ativo.
                    if (i == -1)
                    {
                        i = GetIndexProcessoAtivo();
                    }

                    //}                

                }


                contadorTempo++;
                DataBind();

            }
        }


        /// <summary>
        /// Retorna Index do processo que tem o menor tempo de execução.
        /// </summary>
        /// <returns></returns>
        private int GetIndexProcessoAtivo()
        {


            int ativo = -1;
            int menorProcesso = 0;
            int i = 0;
            bool processo1 = true;
            foreach (var item in listaProcessos)
            {
                if (item.Ativo)
                {

                    if (processo1)
                    {
                        processo1 = false;
                        ativo = i;
                        menorProcesso = item.TempoExecucaoDefault;
                    }
                    else if (item.TempoExecucaoDefault <= menorProcesso)
                    {

                        ativo = i;
                        menorProcesso = item.TempoExecucaoDefault;
                    }

                }
                i++;
            }
            return ativo;
        }

    }
}
