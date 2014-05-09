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
    public partial class ucRoundRobin : UserControl
    {
        //Contador do tempo
        private int contadorTempo = 1;

        //Controlador para os ids dos processos criados
        private int id = 0;

        //Lista de processos na memória
        private List<Processo> listaProcessos = new List<Processo>();


        public ucRoundRobin()
        {
            InitializeComponent();


           // listaProcessos.Add(new Processo()
           //{
           //    Id = 1,
           //    NomeProcesso = "P1",
           //    PrioridadeDefault = 5,
           //    Prioridade = 5,
           //    TempoExecucaoDefault = 10,
           //    TempoExecucao = 10,
           //    Ativo = true
           //});

           // listaProcessos.Add(new Processo()
           // {
           //     Id = 2,
           //     NomeProcesso = "P2",
           //     PrioridadeDefault = 2,
           //     Prioridade = 2,
           //     TempoExecucaoDefault = 6,
           //     TempoExecucao = 6,
           //     Ativo = true
           // });


           // listaProcessos.Add(new Processo()
           // {
           //     Id = 3,
           //     NomeProcesso = "P3",
           //     PrioridadeDefault = 4,
           //     Prioridade = 4,
           //     TempoExecucaoDefault = 8,
           //     TempoExecucao = 8,
           //     Ativo = true
           // });


           // DataBind();

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
            contadorTempo = 1;

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


        /// <summary>
        /// Soma tempo de espera nos demais processos
        /// </summary>
        /// <param name="indexProcessoExecutando"></param>
        private void SomaEspera(int indexProcessoExecutando)
        {
            try
            {
                int index = 0;
                foreach (var p in listaProcessos)
                {
                    if (index != indexProcessoExecutando && p.Ativo)
                        listaProcessos[index].Espera++;

                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {

            ZerarResultados();

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
                    listaProcessos[i].Ativo = false;

                if (contadorTempo % 2 == 0)
                {
                    //Pega proximo da fila
                    int tmp = i + 1;
                    i = GetIndexProcessoAtivo(tmp);

                    //Valida novamente todo array para verificar se não tem nenhum antes ativo.
                    if(i == -1 )
                    {
                        i = GetIndexProcessoAtivo();
                    }

                }

                //Chama método para atualizar o tempo de espera dos demais processos.
                SomaEspera(i);


                contadorTempo++;
                DataBind();

            }
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


       


    }
}
