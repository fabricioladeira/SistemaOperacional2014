﻿using System;
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

            // listaProcessos.Add(new Processo()
            //{
            //    Id = 1,
            //    NomeProcesso = "P1",
            //    PrioridadeDefault = 5,
            //    Prioridade = 5,
            //    TempoExecucao = 10,              
            //    Ativo = true
            //});

            //listaProcessos.Add(new Processo()
            //{
            //    Id = 2,
            //    NomeProcesso = "P2",
            //    PrioridadeDefault = 2,
            //    Prioridade = 2,
            //    TempoExecucao = 6,                
            //    Ativo = true
            //});


            //listaProcessos.Add(new Processo()
            //{
            //    Id = 3,
            //    NomeProcesso = "P3",
            //    PrioridadeDefault = 4,
            //    Prioridade = 4,
            //    TempoExecucao = 8,               
            //    Ativo = true
            //});

            DataBind();
        }

        
        #region ---- Algoritimo Prioridades


        //Contador do tempo
        private int contadorTempo = 1;

        //Controlador para os ids dos processos criados
        private int id = 0;

        //Lista de processos na memória
        private List<Processo> listaProcessos = new List<Processo>();

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
                PrioridadeDefault = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                Prioridade = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),            
                Ativo = true
            });

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
            }
        }


        /// <summary>
        /// Executa algoritimo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecutar_Click(object sender, EventArgs e)
        {

            //Zera os resultados para caso o usuário clicar novamento no botão executar ele ezecutar novaente o algoritimo
            ZerarResultados();

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
                    if (listaProcessos[processoIndex].Prioridade > 0)
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

                //Chama método para atualizar o tempo de espera dos demais processos.
                SomaEspera(processoIndex);

                //Soma tempo decorrido
                contadorTempo++;

                //Recarrega Grid
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