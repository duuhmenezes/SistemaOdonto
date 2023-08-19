namespace SistemaOdonto
{
    partial class frmEditarDentista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarDentista));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusMsg = new ToolStripStatusLabel();
            btnDeletar = new Button();
            btnEditar = new Button();
            panel1 = new Panel();
            txtCRO = new MaskedTextBox();
            txtCelular = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = SystemColors.GradientActiveCaption;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusMsg });
            statusStrip1.Location = new Point(11, 262);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(475, 22);
            statusStrip1.TabIndex = 37;
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
            // btnDeletar
            // 
            btnDeletar.BackgroundImage = (Image)resources.GetObject("btnDeletar.BackgroundImage");
            btnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeletar.FlatAppearance.BorderColor = Color.Silver;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Location = new Point(246, 195);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(73, 64);
            btnDeletar.TabIndex = 36;
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.FlatAppearance.BorderColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(167, 195);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(73, 64);
            btnEditar.TabIndex = 35;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.picture_400px;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(286, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 143);
            panel1.TabIndex = 33;
            // 
            // txtCRO
            // 
            txtCRO.Location = new Point(62, 160);
            txtCRO.Mask = "?? 00-000";
            txtCRO.Name = "txtCRO";
            txtCRO.Size = new Size(218, 23);
            txtCRO.TabIndex = 32;
            txtCRO.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(62, 128);
            txtCelular.Mask = "(00) 00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(218, 23);
            txtCelular.TabIndex = 31;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(62, 98);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(218, 23);
            txtTelefone.TabIndex = 30;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 160);
            label5.Name = "label5";
            label5.Padding = new Padding(3, 0, 0, 0);
            label5.Size = new Size(37, 15);
            label5.TabIndex = 29;
            label5.Text = "CRO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 131);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 0, 0, 0);
            label4.Size = new Size(50, 15);
            label4.TabIndex = 28;
            label4.Text = "Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 0, 0, 0);
            label3.Size = new Size(57, 15);
            label3.TabIndex = 27;
            label3.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 73);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 0, 0, 0);
            label2.Size = new Size(42, 15);
            label2.TabIndex = 25;
            label2.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(218, 23);
            txtNome.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 44);
            label1.Name = "label1";
            label1.Padding = new Padding(3, 0, 0, 0);
            label1.Size = new Size(46, 15);
            label1.TabIndex = 23;
            label1.Text = "Nome:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(62, 11);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(55, 23);
            txtCodigo.TabIndex = 22;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(9, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Padding = new Padding(3, 0, 0, 0);
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 21;
            lblCodigo.Text = "Código:";
            // 
            // frmEditarDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(493, 294);
            Controls.Add(statusStrip1);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
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
            MaximizeBox = false;
            Name = "frmEditarDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConDentista";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusMsg;
        private Button btnDeletar;
        private Button btnEditar;
        private Panel panel1;
        private MaskedTextBox txtCRO;
        private MaskedTextBox txtCelular;
        private MaskedTextBox txtTelefone;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}