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
    public partial class ucFifo : UserControl
    {
        public ucFifo()
        {
            InitializeComponent();
        }

        //Contador do tempo
        private int contadorTempo = 1;

        //Controlador para os ids dos processos criados
        private int id = 0;

        //Lista de processos na memória
        private List<Processo> listaProcessos = new List<Processo>();

        public ucFifo()
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
        /// Zera resultados para rodar denvo
        /// </summary>
        private void ZerarResultados()
        {
            for (int i = 0; i < listaProcessos.Count; i++)
            {
                listaProcessos[i].Ativo = true;
                listaProcessos[i].Espera = 0;
                listaProcessos[i].Inicio = 0;
                listaProcessos[i].Fim = 0;
                listaProcessos[i].Prioridade = listaProcessos[i].PrioridadeDefault;
                listaProcessos[i].TempoExecucao = listaProcessos[i].TempoExecucaoDefault;
            }
        }





        private void btnExecutar_Click(object sender, EventArgs e)
        { 
        
        
        
        
        }


        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            id++;

            listaProcessos.Add(new Processo()
            {
                Id = id,
                NomeProcesso = string.Format("P{0}", id),
                TempoExecucaoDefault = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),                
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                Ativo = true
            });

            DataBind();
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
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                Ativo = true
            });

            DataBind();
        }





        /// <summary>
        /// Retorna Index do processo ativo
        /// </summary>
        /// <returns></returns>
        private int GetIndexProcessoAtivo()
        {
            int ativo = -1;
            int i = 0;
            foreach (var item in listaProcessos)
            {
                if (item.Ativo)
                {
                    ativo = i;
                    break;
                }
                i++;
            }
            return ativo;
        }

        /// <summary>
        /// Verifica se o item existe
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int GetIndexProcessoAtivo(int index)
        {
            int ativo = -1;
            if (index < listaProcessos.Count)
            {
                if (!listaProcessos[index].Ativo)
                {
                    index++;
                    ativo = GetIndexProcessoAtivo(index);
                }
                else
                {
                    ativo = index;
                }
            }
            else
            {
                ativo = -1;
            }

            return ativo;
        }


        /// <summary>
        /// Soma tempo de espera nos demais processos
        /// </summary>
        /// <param name="indexProcessoExecutando"></param>
        private void SomaEspera(int indexProcessoExecutando)
        {
            int index = 0;
            foreach (var p in listaProcessos)
            {
                if (index != indexProcessoExecutando && p.Ativo)
                    listaProcessos[index].Espera++;

                index++;
            }
        }

    }
}
