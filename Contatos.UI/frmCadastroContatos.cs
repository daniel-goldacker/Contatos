using Contado.Domain;
using Contatos.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos.UI
{
    public partial class frmCadastroContatos : Form
    {
        public frmCadastroContatos()
        {
            InitializeComponent();
            controlaCampoExluir();
        }

        public frmCadastroContatos(int id)
        {
            InitializeComponent();

            ContatosBLL ContatosNegocio = new ContatosBLL();
            Contato DadosContato = new Contato();

            DadosContato = ContatosNegocio.BuscaContatoPorID(id);
            txbId.Text = DadosContato.Id.ToString();
            txbNome.Text = DadosContato.Nome;
            rtbEndereco.Text = DadosContato.Endereco;
            txbTelefone.Text = DadosContato.Telefone;
            txbCelular.Text = DadosContato.Celular;
            txbEmail.Text = DadosContato.Email;

            controlaCampoExluir();
        }
    


        private void btnGravar_Click(object sender, EventArgs e)
        {

            if ((!String.IsNullOrEmpty(txbNome.Text)) && (!String.IsNullOrEmpty(rtbEndereco.Text)) && 
                (!String.IsNullOrEmpty(txbTelefone.Text)) && (!String.IsNullOrEmpty(txbCelular.Text)) &&
                (!String.IsNullOrEmpty(txbEmail.Text)))
            {
         

                if (String.IsNullOrEmpty(txbId.Text))
                {
                    Contato Contatos = new Contato
                    {
                        Nome = txbNome.Text,
                        Endereco = rtbEndereco.Text,
                        Telefone = txbTelefone.Text,
                        Celular = txbCelular.Text,
                        Email = txbEmail.Text
                    };

                    ContatosBLL ContatosNegocio = new ContatosBLL();
                    ContatosNegocio.CriarContatos(Contatos);
                    this.Close();
                }
                else
                {
                    Contato Contatos = new Contato
                    {
                        Id = Convert.ToInt32(txbId.Text),
                        Nome = txbNome.Text,
                        Endereco = rtbEndereco.Text,
                        Telefone = txbTelefone.Text,
                        Celular = txbCelular.Text,
                        Email = txbEmail.Text
                    };

                    ContatosBLL ContatosNegocio = new ContatosBLL();
                    ContatosNegocio.AlterarContato(Contatos);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("É necessário preencher os campos");
            }

        }



        private void limpaCampos()
        {
            txbNome.Text = String.Empty;
            rtbEndereco.Text = String.Empty;
            txbTelefone.Text = String.Empty;
            txbCelular.Text = String.Empty;
            txbEmail.Text = String.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void controlaCampoExluir()
        {
            if (String.IsNullOrEmpty(txbId.Text)){
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato Contatos = new Contato
            {
                Id = Convert.ToInt32(txbId.Text),
                Nome = txbEmail.Text,
                Endereco = rtbEndereco.Text,
                Telefone = txbTelefone.Text,
                Celular = txbCelular.Text,
                Email = txbEmail.Text
            };

            ContatosBLL ContatosNegocio = new ContatosBLL();
            ContatosNegocio.ExcluirContato(Contatos);
            this.Close();
        }
    }
}
