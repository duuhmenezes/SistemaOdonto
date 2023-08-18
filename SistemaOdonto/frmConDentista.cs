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

        }
        private void frmConDentista_Load(object sender, EventArgs e)
        {

        }
    }
}
