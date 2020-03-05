using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prova_cria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] totalDias;

        private void txtDiasAluguel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número");
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (diasAluguel.Items.Count == 0)
            {
                MessageBox.Show("É preciso clicar no botão 'Total de Dias' antes");
            }
            else
            { 
                int tVetor = totalDias.Length;
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Selecione a pasta onde será criado o arquivo:";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ////declarando a variavel do tipo StreamWriter para 
                    //abrir ou criar um arquivo para escrita 
                    StreamWriter x;

                    //utilizando o metodo para criar um arquivo texto
                    //e associando o caminho e nome ao metodo
                    x = File.CreateText(System.IO.Path.Combine(dialog.SelectedPath, txtNome.Text + ".txt"));

                    //escrevendo o titulo
                    x.WriteLine("            Dados do Cliente" + " " + txtNome.Text);
                    //pulando linha sem escrita
                    x.WriteLine();
                    //escrevendo conteúdo do recibo
                    x.WriteLine("Nome do Cliente: " + txtNome.Text);
                    x.WriteLine("===========================================");
                    if (ckCartao.Checked == true)
                    {
                        x.WriteLine("Cartão Fidelidade: Sim");
                    }
                    else
                    {
                        x.WriteLine("Cartão Fidelidade: Não");
                    }
                    x.WriteLine("===========================================");
                    x.WriteLine("Quantidade de Pessoas: " + qtdPessoas.Text);
                    x.WriteLine("===========================================");
                    x.WriteLine("Total de dias do Aluguel: " + tVetor);
                    x.WriteLine("===========================================");
                    x.WriteLine("Dias do Aluguel  Dia da Semana do Aluguel");
                    for (int i = 0; i < tVetor; i++)
                    {
                        x.WriteLine(totalDias[i]);
                    }

                    //fechando o arquivo texto com o método .Close()
                    x.Close();

                    Application.Exit();
                }            
            }
        }

        private void btnDias_Click(object sender, EventArgs e)
        {
            if (txtDiasAluguel.Text == "")
            {
                MessageBox.Show("Você precisa colocar a quantidade de dias do aluguel");
            }
            else
            {
                int dias = int.Parse(txtDiasAluguel.Text);
                string data, semana, aluguel;
                dias = dias - 1;
                DateTime inicio = dataAluguel.Value;
                totalDias = new string[dias + 1];

                for (int i = 0; i <= dias; i++)
                {
                    semana = inicio.AddDays(i).DayOfWeek.ToString();

                    switch (semana)
                    {
                        case "Monday":
                            semana = "Segunda";
                            break;
                        case "Tuesday":
                            semana = "Terça";
                            break;
                        case "Wednesday":
                            semana = "Quarta";
                            break;
                        case "Thursday":
                            semana = "Quinta";
                            break;
                        case "Friday":
                            semana = "Sexta";
                            break;
                        case "Saturday":
                            semana = "Sábado";
                            break;
                        case "Sunday":
                            semana = "Domingo";
                            break;
                    };

                    data = "Data: " + inicio.AddDays(i).ToString().Substring(0, 10);
                    semana = "Semana: " + semana;
                    aluguel = data + " " + semana;
                    diasAluguel.Items.Add(data + " " + semana);
                    totalDias[i] = aluguel;
                }
            }
        }

        private void txtQtdPessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero");
            }
        }

    }
}
