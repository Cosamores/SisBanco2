using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisBanco
{
    public partial class frmCadastro : Form
    {
        Conta conta;
        Cliente cli;
        List<Cliente> cliente = new List<Cliente>();

        public frmCadastro()
        {

            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

           // Conta c1 = new Conta();

           // Conta c2 = new ContaPoupança();

           // double deposito1 = c1.Depositar(200);
           // double deposito2 = c2.Depositar(300);

           // TotalizaSaldo total = new TotalizaSaldo();

           // total.Soma(c1);
           // total.Soma(c2);

           // MessageBox.Show(Convert.ToString(total.Totaliza));
            //conta = new Conta();
            //conta.Numero = 123;

            //ContaPoupança cp = new ContaPoupança();

            //Cliente cli = new Cliente("Diego");

            //conta.Titular = cli.Nome;

            //txtNumero.Text = Convert.ToString(conta.Numero);
            //txtNomeDoCliente.Text = cli.Nome;



        }

        private void cmdDepositar_Click(object sender, EventArgs e)
        {

            txtSaldo.Text = Convert.ToString(conta.Depositar(Convert.ToDouble(txtValor.Text)));


            MessageBox.Show("Depósito efetuado com sucesso");

        }

        private void grpDadosConta_Enter(object sender, EventArgs e)
        {

        }

        private void lblNumeroDaConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdSaque_Click(object sender, EventArgs e)
        {
            //txtSaldo.Text = Convert.ToString(conta.Sacar(Convert.ToDouble(txtValor.Text)));

           // ContaPoupança cp = new ContaPoupança();


            txtSaldo.Text = Convert.ToString(conta.Sacar(Convert.ToDouble(txtValor.Text)));
            MessageBox.Show("Saque realizado com sucesso");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e) //Btn Criar cliente
        {

          //  Cliente cli = ;

            cliente.Add(new Cliente(txtNomeDoCliente.Text, txtCPF.Text, Convert.ToDateTime(txtDataDeNascimento.Text)));

            List<string> listaerro = new List<string>();

            listaerro = cliente[cliente.Count() -1].EhValida();

            if (listaerro.Count() > 0)
            {
                foreach (var item in listaerro)
                {

                    MessageBox.Show(item);

                }
                
                return;
            }

            cboTitular.Items.Add(cliente[cliente.Count() - 1].Nome + " - " + cliente[cliente.Count() - 1].CPF);
        }
        //public void boxTipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //public void TipoDeContaBox()
        //    //{
        //    //public string TipodeConta { get; set; }

        //    //for (string i = 0; i < 2; int++)
        //    //{
        //    //if 

        //    }

        public void button1_Click_1(object sender, EventArgs e) //Btn Adicionar
        {
            if (cboTipoConta.SelectedIndex == 0)
            {
                conta = new Conta(Convert.ToInt32(txtNumero.Text));
            }
            else
            {
                conta = new ContaPoupança(Convert.ToInt32(txtNumero.Text));
            }

            conta.Numero = Convert.ToInt32(txtNumero.Text);
        }
    }
    }       