namespace NTierArchitecture.UI.Forms
{
    partial class CategoryForm
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
            txtKategoriAdi = new TextBox();
            label1 = new Label();
            lstListe = new ListBox();
            chkAktif = new CheckBox();
            txtAciklama = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(304, 202);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(367, 43);
            txtKategoriAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 202);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 2;
            label1.Text = "Kategori Adı";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(677, 202);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(264, 300);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(479, 415);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(192, 41);
            chkAktif.TabIndex = 5;
            chkAktif.Text = "AKTİF / PASİF";
            chkAktif.UseVisualStyleBackColor = true;
            chkAktif.CheckedChanged += chkAktif_CheckedChanged;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(304, 251);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(367, 158);
            txtAciklama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 251);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 2;
            label2.Text = "Açıklama";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 535);
            Controls.Add(chkAktif);
            Controls.Add(lstListe);
            Controls.Add(label2);
            Controls.Add(txtAciklama);
            Controls.Add(label1);
            Controls.Add(txtKategoriAdi);
            Margin = new Padding(13, 17, 13, 17);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            Controls.SetChildIndex(txtKategoriAdi, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtAciklama, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(chkAktif, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKategoriAdi;
        private Label label1;
        private ListBox lstListe;
        private CheckBox chkAktif;
        private TextBox txtAciklama;
        private Label label2;
    }
}