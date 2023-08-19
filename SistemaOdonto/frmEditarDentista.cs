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
    public partial class frmEditarDentista : Form
    {
        public string status;
        Dentista obj = new Dentista();
        DentistaService service = new DentistaService();

        public frmEditarDentista(Dentista obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Dentista objPar)
        {
            this.obj = objPar;
            txtCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome.ToString();
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtEmail.Text = this.obj.Email.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
            txtCRO.Text = this.obj.CRO.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ValidarCad();
            if (toolStripStatusLabel1.Text == "TUDO OK!")
            {
                if (txtCodigo.Text != this.obj.Id.ToString())
                {
                    status = "apagado";
                    MessageBox.Show("Esse registro foi excluido por outro usuário");
                }
                else
                {
                    status = "editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Email = txtEmail.Text;
                    this.obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    this.obj.CRO = txtCRO.Text;
                    service.Editar(this.obj);
                    this.Close();
                }
            }

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
                return "Preencha o CRO";
            else // caso tudo esteja preenchido ele cai aqui no else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
                return "TUDO OK!";

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Registro excluido com sucesso!");
                status = "apagado";
                this.Close();
            }
        }
        public bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }
    }
}
