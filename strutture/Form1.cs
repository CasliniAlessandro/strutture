using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strutture
{
    public partial class Form1 : Form
    {   public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto [] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p=new prodotto[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);
            
        }
        public string prodString(prodotto p)
        {
            return "Nome:"+p.nome+" prezzo:"+p.prezzo.ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }


        public bool Cancella(prodotto[] p, string nom)
        {
            bool ritorno=false;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == nom)
                {
                    int var = i;
                    while (var < dim - 1)
                    {
                        p[var] = p[var + 1];
                        var++;
                    }
                    dim--;
                    ritorno = true;
                }
            }
            return ritorno;


        }

        private void cancella_Click(object sender, EventArgs e)
        {
            if (Cancella(p, textBox1.Text))

            {
                visualizza(p);
                MessageBox.Show("Elemento cancellato");
            }
            else
            {
                MessageBox.Show("Elemento non trovato");
            }




        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifica_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


