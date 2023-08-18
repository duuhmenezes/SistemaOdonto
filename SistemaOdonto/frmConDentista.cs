using Entidades;
using GrpcService1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class frmConDentista : Form
    {
        DentistaService service = new DentistaService();
        public frmConDentista()
        {
            InitializeComponent();
            IniciarForm();
        }
        
        public void IniciarForm()
        {
            var lista = service.Listar();
            if(lista == null)
            {
                MessageBox.Show("Não exsitem dentistas cadastrados");
                this.Close();
            }else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach(var dado in lista)
                {
                    char primeiraLetra = dado.Nome.Trim()[0]; // extraindo a primeira letra do campo o trim limpa tudo
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela = numTabela + 1;
                        tcDentistas.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tcDentistas.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }
                    letraAnterior = primeiraLetra; 
                }
            }
        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // se a string for grande a coluna acompanhará
            dg.AllowUserToResizeColumns = false; 
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false; // linha cabeçalho
            dg.BackgroundColor = SystemColors.GradientActiveCaption;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.Chocolate;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;
            
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";

            link.Name = "Nome";
            dg.Columns.Add(link);

            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");
            

        }

        private void GerarLinha(DataGridView data, Dentista dado)
        {
            int linhaAtual = data.Rows.Add(); 
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Nome;
            data.Rows[linhaAtual].Cells[2].Value = dado.Telefone;
            data.Rows[linhaAtual].Cells[3].Value = dado.Celular;
            //data.Rows[linhaAtual].Cells[4].Value = dado.Email;
            //data.Rows[linhaAtual].Cells[5].Value = dado.CRO;




        }

        private void frmConDentista_Load(object sender, EventArgs e)
        {

        }
    }
}
