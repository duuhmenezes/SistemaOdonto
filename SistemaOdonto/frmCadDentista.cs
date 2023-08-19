using Entidades;
using GrpcService1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class frmCadDentista : Form
    {
        DentistaService service = new DentistaService();
        public frmCadDentista()
        {
            InitializeComponent();
            txtNome.Text = txtCelular.Text;

        }

        private string ValidarCad()
        {
            toolStripStatusLabel1.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o Nome!";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o Celular";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o Email";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o Telefone";
            }
            else if (txtCRO.Text == string.Empty)
            {
                return "Preencha o CRO";
            }
            else // caso tudo esteja preenchido ele cai aqui no else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
                return "TUDO OK!";

            }
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = ValidarCad();
                if (toolStripStatusLabel1.Text == "TUDO OK!")
                {
                    service.Cadastrar(ObjGerado());
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar os Dados" + ex);
            }
        }

        public Dentista ObjGerado()
        {
            Dentista obj = new Dentista();
            obj.Nome = txtNome.Text;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.CRO = txtCRO.Text; ;
            obj.Email = txtEmail.Text;

            return obj;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }

        private void frmCadDentista_Load(object sender, EventArgs e)
        {

        }
    }
}
