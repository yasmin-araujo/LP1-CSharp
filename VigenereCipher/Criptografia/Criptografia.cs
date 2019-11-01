using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Criptografia : Form
    {
        private Char[] alfa = new Char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private Char[,] mat = new Char[27,26];
        private String cifra;
        private int col = 0, lin = 1;
        public Criptografia()
        {
            InitializeComponent();

            carregaMatriz();
        }
        
        public void carregaMatriz()
        {
            for (int x = 0; x <= 26; x++) //linha
            {
                for (int y = 0; y < 26; y++)//coluna
                {
                    mat[x,y] = alfa[y+x]; //carrega matriz alternando primeira letra
                }
            }
            
        }

        public void mostraMatriz()
        {
            String mostra = "";

            for (int x = 0; x <= 26; x++) //linha
            {
                for (int y = 0; y < 26; y++)//coluna
                {
                    mostra += mat[x, y] + " ";
                }
                mostra += "\n || " + x.ToString() + " \n";
            }

            txbCifrado.Text = mostra;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            txbCifrado.Clear();

            string chave = PegarChave();
            string texto = PegarTexto();
            int tamchave = chave.Length;
            int tamtexto = texto.Length;
            string bigchave = "";
            int rep = 1;
            cifra = "";

            while (tamtexto > (rep * tamchave)) //para ter chave para todas as letras do texto
            {
                rep++;
            }

            for (int x = 0; x < rep; x++) 
            {
                bigchave += chave;
            }

            for (int x = 0; x < tamtexto; x++) //cada letra do texto
            {
               cifra += DecifraLetra(bigchave[x], texto[x]);
            }
            
            txbCifrado.Text = cifra;
        }

        public string PegarChave() //pega valor da chave e retira os espaços
        {
            string ch = txbChave.Text;
            ch = ch.Replace(" ", "");
            return ch;
        }

        public string PegarTexto() //pega valor do texto e retira os espaços
        {
            string tx = txbTexto.Text;
            tx = tx.Replace(" ", "");
            return tx;
        }

        private void radCodificar_Click(object sender, EventArgs e)
        {
            lblDigita.Text = "Digite texto a ser codificado:";
            lblMostra.Text = "Texto cifrado:";
        }

        private void radDescodificar_Click(object sender, EventArgs e)
        {
            lblDigita.Text = "Digite texto a ser descodificado:";
            lblMostra.Text = "Texto original:";
        }

        public char DecifraLetra(char ch, char tx) //codifica letra
        {
            char lt;
            lin = 1;
            col = 0;

            while (ch != mat[lin, 0])
            {
                lin++;
            }

            if (radCodificar.Checked == true)
            {
                while (tx != mat[0, col])
                {
                    col++;
                }

                lt = mat[lin, col];
            }
            else if (radDescodificar.Checked == true)
            {
                while (tx != mat[lin, col])
                {
                    col++;
                }

                lt = mat[0, col];
            }
            else
                lt = '0';

            return lt;
        }
    }
}
