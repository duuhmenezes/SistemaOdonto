namespace SistemaOdonto
{
    partial class frmConDentista
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
            tcDentistas = new TabControl();
            SuspendLayout();
            // 
            // tcDentistas
            // 
            tcDentistas.Location = new Point(12, 12);
            tcDentistas.Name = "tcDentistas";
            tcDentistas.SelectedIndex = 0;
            tcDentistas.Size = new Size(776, 426);
            tcDentistas.TabIndex = 0;
            // 
            // frmConDentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tcDentistas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmConDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentistas";
            Load += frmConDentista_Load;
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcDentistas;
    }
}