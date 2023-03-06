using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinJogoVelha
{
    public partial class Form1 : Form
    {
        /*
        TicTacToePropriedades oPropriedades = new TicTacToePropriedades();
        oPropriedades.Jogador = "X";
        oPropriedades.Posicao = "11";
        */

        /* Uso simples de LIST
        List<string> listaNome = new List<string>();
        listaNome.Add(Jogador);
        */

        string JogadorAtual = "X";

        string[] board = new string[9];

        IList<string> Jogador = new List<string>();
        IList<int> Posicao = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comportamentoInicio();            
        }

        private string Teste() 
        {
            IList<string> frutas = new List<string>();
            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Pera");
            frutas.Add("Abacaxi");
            
            for (int i = 0; i < frutas.Count; i++)
            {
                Console.WriteLine("- " + frutas[i]);
            }

            return "bla";
        }

        private void comportamentoInicio() 
        {
            lblMensagem.Text = "";

            lblL1C1.Text = "_";
            lblL1C2.Text = "_";
            lblL1C3.Text = "_";
            lblL2C1.Text = "_";
            lblL2C2.Text = "_";
            lblL2C3.Text = "_";
            lblL3C1.Text = "_";
            lblL3C2.Text = "_";
            lblL3C3.Text = "_";

            Jogador.Clear();
            Posicao.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            comportamentoInicio();
        }

        private void mudaJogador(string jogador, int posicao)
        {
            Jogador.Add(jogador);
            Posicao.Add(posicao);

            board[posicao] = jogador;

            //Troca o caracter do jogador
            if (jogador == "X")
            {
                JogadorAtual = "O";
            }
            else if (jogador == "O")
            {
                JogadorAtual = "X";
            }

            //Todos campos preenchidos
            if (
                lblL1C1.Text != "_" & lblL1C2.Text != "_" & lblL1C3.Text != "_" & 
                lblL2C1.Text != "_" & lblL2C2.Text != "_" & lblL2C3.Text != "_" & 
                lblL3C1.Text != "_" & lblL3C3.Text != "_" & lblL3C3.Text != "_"
                )
            {
                lblMensagem.Text = "FIM DE JOGO";

                for (int i = 0; i < Jogador.Count; i++)
                {
                    lblResultado.Text += Jogador[i] + "|" + Posicao[i] + " - ";
                }
            }

            //Verifica se houve um vencedor
            
            if (IsWin(JogadorAtual))
            { 
                lblMensagem.Text = JogadorAtual + " venceu!"; 
            }            
        }

        private bool IsWin(string symbol)
        {
            // Verifica todas as linhas do tabuleiro
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == symbol && board[i * 3 + 1] == symbol && board[i * 3 + 2] == symbol)
                {
                    return true;
                }
            }

            // Verifica todas as colunas do tabuleiro
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == symbol && board[i + 3] == symbol && board[i + 6] == symbol)
                {
                    return true;
                }
            }

            // Verifica as diagonais do tabuleiro
            if (board[0] == symbol && board[4] == symbol && board[8] == symbol)
            {
                return true;
            }
            if (board[2] == symbol && board[4] == symbol && board[6] == symbol)
            {
                return true;
            }

            // Se nenhuma das condições acima for verdadeira, então o jogador não venceu
            return false;
        }


        private void lblL1C1_Click(object sender, EventArgs e)
        {
            lblL1C1.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 0);
        }

        private void lblL1C2_Click(object sender, EventArgs e)
        {
            lblL1C2.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 1);
        }

        private void lblL1C3_Click(object sender, EventArgs e)
        {
            lblL1C3.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 2);
        }

        private void lblL2C1_Click(object sender, EventArgs e)
        {
            lblL2C1.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 3);
        }

        private void lblL2C2_Click(object sender, EventArgs e)
        {
            lblL2C2.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 4);
        }

        private void lblL2C3_Click(object sender, EventArgs e)
        {
            lblL2C3.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 5);
        }

        private void lblL3C1_Click(object sender, EventArgs e)
        {
            lblL3C1.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 6);
        }

        private void lblL3C2_Click(object sender, EventArgs e)
        {
            lblL3C2.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 7);
        }

        private void lblL3C3_Click(object sender, EventArgs e)
        {
            lblL3C3.Text = JogadorAtual;
            mudaJogador(JogadorAtual, 8);
        }
    }
}
