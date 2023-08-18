namespace SistemaOdonto
{
    partial class frmCadDentista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDentista));
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtCRO = new MaskedTextBox();
            panel1 = new Panel();
            btnCadastrar = new Button();
            btnBuscar = new Button();
            btnDeletar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusMsg = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(7, 16);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Padding = new Padding(3, 0, 0, 0);
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(60, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(55, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(60, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(218, 23);
            txtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 45);
            label1.Name = "label1";
            label1.Padding = new Padding(3, 0, 0, 0);
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(60, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 0, 0, 0);
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 103);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 0, 0, 0);
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefone:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 132);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 0, 0, 0);
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Celular:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 161);
            label5.Name = "label5";
            label5.Padding = new Padding(3, 0, 0, 0);
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "CRO:";
            label5.Click += label5_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(60, 99);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(218, 23);
            txtTelefone.TabIndex = 12;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(60, 129);
            txtCelular.Mask = "(00) 00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(218, 23);
            txtCelular.TabIndex = 13;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCRO
            // 
            txtCRO.Location = new Point(60, 161);
            txtCRO.Mask = "?? 00-000";
            txtCRO.Name = "txtCRO";
            txtCRO.Size = new Size(218, 23);
            txtCRO.TabIndex = 14;
            txtCRO.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.picture_400px;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(284, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 143);
            panel1.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = Properties.Resources.save_240px;
            btnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrar.FlatAppearance.BorderColor = Color.Silver;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(129, 197);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(73, 64);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(216, 197);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 64);
            btnBuscar.TabIndex = 18;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackgroundImage = (Image)resources.GetObject("btnDeletar.BackgroundImage");
            btnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeletar.FlatAppearance.BorderColor = Color.Silver;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Location = new Point(295, 197);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(73, 64);
            btnDeletar.TabIndex = 19;
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = SystemColors.GradientActiveCaption;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusMsg });
            statusStrip1.Location = new Point(9, 263);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(475, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusMsg
            // 
            toolStripStatusMsg.Name = "toolStripStatusMsg";
            toolStripStatusMsg.Size = new Size(0, 17);
            // 
            // frmCadDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(493, 294);
            Controls.Add(statusStrip1);
            Controls.Add(btnDeletar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCadastrar);
            Controls.Add(panel1);
            Controls.Add(txtCRO);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Dentistas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtCRO;
        private Panel panel1;
        private Button btnCadastrar;
        private Button btnBuscar;
        private Button btnDeletar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusMsg;
    }
}