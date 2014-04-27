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
    public partial class ucPrioridade : UserControl
    {
        public ucPrioridade()
        {
            InitializeComponent();

             listaProcessos.Add(new Processo()
            {
                Id = 1,
                NomeProcesso = "P1",
                Prioridade = 5,
                TempoExecucao = 10,              
                Ativo = true
            });

            listaProcessos.Add(new Processo()
            {
                Id = 2,
                NomeProcesso = "P2",
                Prioridade = 2,
                TempoExecucao = 6,                
                Ativo = true
            });


            listaProcessos.Add(new Processo()
            {
                Id = 3,
                NomeProcesso = "P3",
                Prioridade = 4,
                TempoExecucao = 8,               
                Ativo = true
            });

            DataBind();
        }

        
        #region ---- Algoritimo Prioridades

        private int contadorTempo = 1;
        private int id = 0;
        private List<Processo> listaProcessos = new List<Processo>();


        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            id++;

            listaProcessos.Add(new Processo()
            {
                Id = id,
                NomeProcesso = string.Format("P{0}", id),
                Prioridade = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),            
                Ativo = true
            });

            DataBind();
        }


        private void DataBind()
        {
            this.dgvProcessos.DataSource = null;
            this.dgvProcessos.DataSource = listaProcessos;
            this.dgvProcessos.Refresh();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            //Pegar o processo de maior prioridade
            int processoIndex = GetIndexProcessoMaior();


            //Pega Total do Tempo de Execucao
            while (VerificaProcessoAtivo())
            {
                //Marca Inicio
                if (listaProcessos[processoIndex].Inicio == 0)
                    listaProcessos[processoIndex].Inicio = contadorTempo;

                //Marca FIM              
                listaProcessos[processoIndex].Fim = contadorTempo;

                //a cada dois laços do contador de tempo diminui 1 da prioridade do processo em execução ou seja o de maior prioridade
                if (contadorTempo % 2 == 0)
                {
                    listaProcessos[processoIndex].Prioridade--;                   

                    // Verifica se não tem um processo ativo com mais prioridade que ele, se sim coloca ele em espera somando os tempo de espera dele, ecomeça o fluxo com o maior
                    int tmpIndex = GetIndexProcessoMaior();
                    if (tmpIndex != processoIndex)
                    {
                        //Troca o processo 
                        processoIndex = tmpIndex;
                    }
                }

                
                //Verifica se o tempo de execução dele já acabou e pega o próximo processo com mais prioridade
                if (listaProcessos[processoIndex].TempoExecucao <= (listaProcessos[processoIndex].Fim - listaProcessos[processoIndex].Inicio))
                {
                    //Inativa Processo
                    listaProcessos[processoIndex].Ativo = false;                   
                    processoIndex = GetIndexProcessoMaior();
                }               

                SomaEspera(processoIndex);
                contadorTempo++;
                DataBind();
            }

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


        /// <summary>
        /// Retorna maior processo ativo
        /// </summary>
        /// <returns></returns>
        private int GetIndexProcessoMaior()
        {
            int indexReturn = 0;
            int index = 0;
            Processo result = null;
            foreach (var p in listaProcessos)
            {
                if ((result == null && p.Ativo) || (result != null && result.Prioridade < p.Prioridade && p.Ativo))
                {
                    indexReturn = index;
                    result = p;
                }
                
                index++;
            }
            return indexReturn;
        }


        /// <summary>
        /// Verfica se na lista ainda tem processos ativos
        /// </summary>
        /// <returns></returns>
        private bool VerificaProcessoAtivo()
        {
            bool ativo = false;
            foreach (var item in listaProcessos)
            {
                if (item.Ativo)
                {
                    ativo = true;
                    break;
                }
            }
            return ativo;
        }


        #endregion
    }
}
