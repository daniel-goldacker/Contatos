using Contado.Domain;
using Contatos.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos.UI
{
    public partial class frmConsultaContatos : Form
    {
        public frmConsultaContatos()
        {
            InitializeComponent();
            recarregaGridContatos();
        }
   

        private void recarregaGridContatos()
        {
            ContatosBLL ContatosNegocio = new ContatosBLL();
            dgvContatos.DataSource = ContatosNegocio.BuscaTodosContatos();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            frmCadastroContatos CadastroContatos = new frmCadastroContatos();
            CadastroContatos.ShowDialog();

            recarregaGridContatos();
        }

        private void btnSairSistema_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        private void dgvContatos_DoubleClick(object sender, EventArgs e)
        {
            frmCadastroContatos CadastroContatos = new frmCadastroContatos(Convert.ToInt32(dgvContatos.CurrentRow.Cells[0].Value.ToString()));
            CadastroContatos.ShowDialog();

            recarregaGridContatos();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            ContatosBLL ContatosNegocio = new ContatosBLL();
            if (!String.IsNullOrEmpty(txbPesquisa.Text))
            {
                dgvContatos.DataSource = ContatosNegocio.BuscaContatPorNome(txbPesquisa.Text);
            }
            else
            {
                recarregaGridContatos();
            }
        }

        private void btnGerarCSV_Click(object sender, EventArgs e)
        {

            fbdDiretorio.Description = "Selecione um diretório:";
            fbdDiretorio.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdDiretorio.ShowNewFolderButton = true;
            fbdDiretorio.ShowDialog();
            string diretorio = fbdDiretorio.SelectedPath + "\\arquivo.csv";
       

           if (!diretorio.Equals(String.Empty))
           {
                using (StreamWriter valor = new StreamWriter(diretorio))
                {
                    string teste = String.Empty;
                    for (int i = 0; i < dgvContatos.Rows.Count; i++)
                    {
                        string[] listaContados = { dgvContatos.Rows[i].Cells[0].Value.ToString(), dgvContatos.Rows[i].Cells[1].Value.ToString(), dgvContatos.Rows[i].Cells[2].Value.ToString(), dgvContatos.Rows[i].Cells[3].Value.ToString(), dgvContatos.Rows[i].Cells[4].Value.ToString(), dgvContatos.Rows[i].Cells[5].Value.ToString() };
                        valor.WriteLine(string.Join(";", listaContados));
                    }
                    MessageBox.Show("Arquivo gerado com sucesso!");
                }
           }
        }
    }
}
