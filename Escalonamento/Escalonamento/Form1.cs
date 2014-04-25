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

        private int contadorTempo = 0;
        private int id = 0;
        private List<Processo> listaProcessos = new List<Processo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            id++;

            listaProcessos.Add(new Processo()
            {
                Id = id,
                NomeProcesso = string.Format("P{0}", id),
                Prioridade = Convert.ToInt32(this.cboPrioridade.Text.ToString()),
                TempoExecucao = Convert.ToInt32(this.cboTempoExecucao.Text.ToString()),
                Inicio = System.DateTime.Now,
                Ativo = true
            });

            DataBind();
        }


        private void DataBind()
        {
            this.dgvProcessos.DataSource = null;
            this.dgvProcessos.DataSource = listaProcessos;       
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            //Pegar o processo de maior prioridade
            int processoIndex = GetIndexProcessoMaior();


            //Pega Total do Tempo de Execucao
            while (VerificaProcessoAtivo())
            {

                //a cada dois laços do contador de tempo diminui 1 da prioridade do processo em execução ou seja o de maior prioridade
               if(contadorTempo % 2 == 0)
               {
                   listaProcessos[processoIndex].Prioridade--;

                   int tmpIndex = GetIndexProcessoMaior();
                   if (tmpIndex != processoIndex)
                   {
                       //Troca o processo
                       processoIndex = tmpIndex;
                   }
               }            

                // Verifica se não tem um processo ativo com mais prioridade que ele, se sim coloca ele em espera somando os tempo de espera dele, ecomeça o fluxo com o maior
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
            int index = 0;
            Processo result = null;
            foreach (var p in listaProcessos)
            {
                if (result == null || (result != null && result.Prioridade < p.Prioridade && p.Ativo))
                    break;

                index++;
            }
            return index;
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
                if(item.Ativo)
                {
                    ativo = true;
                    break;
                }
            }
            return ativo;
        }


        #endregion



        #region ---- Round Robin ou Circular




        #endregion



    }
}
