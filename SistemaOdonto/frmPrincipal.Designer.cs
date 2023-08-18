namespace SistemaOdonto
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuPrincipal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            menuDentista = new ToolStripMenuItem();
            menuPaciente = new ToolStripMenuItem();
            menuConsulta = new ToolStripMenuItem();
            agendasToolStripMenuItem = new ToolStripMenuItem();
            menuAgDentistas = new ToolStripMenuItem();
            menuAgPacientes = new ToolStripMenuItem();
            menuAgConsultas = new ToolStripMenuItem();
            mAjuda = new ToolStripMenuItem();
            menuAjuda = new ToolStripMenuItem();
            mSair = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, agendasToolStripMenuItem, mAjuda, mSair });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(1104, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDentista, menuPaciente, menuConsulta });
            cadastrosToolStripMenuItem.Image = Properties.Resources.add_user_male_240px;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(87, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuDentista
            // 
            menuDentista.Name = "menuDentista";
            menuDentista.Size = new Size(121, 22);
            menuDentista.Text = "Dentista";
            menuDentista.Click += menuDentista_Click;
            // 
            // menuPaciente
            // 
            menuPaciente.Name = "menuPaciente";
            menuPaciente.Size = new Size(121, 22);
            menuPaciente.Text = "Paciente";
            menuPaciente.Click += menuPaciente_Click;
            // 
            // menuConsulta
            // 
            menuConsulta.Name = "menuConsulta";
            menuConsulta.Size = new Size(121, 22);
            menuConsulta.Text = "Consulta";
            // 
            // agendasToolStripMenuItem
            // 
            agendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAgDentistas, menuAgPacientes, menuAgConsultas });
            agendasToolStripMenuItem.Image = Properties.Resources.schedule_480px;
            agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            agendasToolStripMenuItem.Size = new Size(81, 20);
            agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgDentistas
            // 
            menuAgDentistas.Name = "menuAgDentistas";
            menuAgDentistas.Size = new Size(180, 22);
            menuAgDentistas.Text = "Dentistas";
            menuAgDentistas.Click += menuAgDentistas_Click;
            // 
            // menuAgPacientes
            // 
            menuAgPacientes.Name = "menuAgPacientes";
            menuAgPacientes.Size = new Size(180, 22);
            menuAgPacientes.Text = "Pacientes";
            // 
            // menuAgConsultas
            // 
            menuAgConsultas.Name = "menuAgConsultas";
            menuAgConsultas.Size = new Size(180, 22);
            menuAgConsultas.Text = "Consultas";
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new ToolStripItem[] { menuAjuda });
            mAjuda.Image = Properties.Resources.help_240px;
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new Size(66, 20);
            mAjuda.Text = "Ajuda";
            // 
            // menuAjuda
            // 
            menuAjuda.Name = "menuAjuda";
            menuAjuda.Size = new Size(105, 22);
            menuAjuda.Text = "Ajuda";
            // 
            // mSair
            // 
            mSair.DropDownItems.AddRange(new ToolStripItem[] { menuSair });
            mSair.Image = Properties.Resources.Exit_Sign_240px;
            mSair.Name = "mSair";
            mSair.Size = new Size(54, 20);
            mSair.Text = "Sair";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(93, 22);
            menuSair.Text = "Sair";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1104, 486);
            Controls.Add(menuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuPrincipal;
            Name = "frmPrincipal";
            Text = "Sistema Odonto";
            WindowState = FormWindowState.Maximized;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem menuDentista;
        private ToolStripMenuItem menuPaciente;
        private ToolStripMenuItem menuConsulta;
        private ToolStripMenuItem agendasToolStripMenuItem;
        private ToolStripMenuItem menuAgDentistas;
        private ToolStripMenuItem menuAgPacientes;
        private ToolStripMenuItem menuAgConsultas;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mSair;
        private ToolStripMenuItem menuAjuda;
        private ToolStripMenuItem menuSair;
    }
}