using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class CategoryForm : BaseForm
    {
        private readonly CategoryService _categoryService;
        private readonly CategoryRepository _categoryRepository;
        public CategoryForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _categoryRepository = new CategoryRepository(dbContext);
            _categoryService = new CategoryService(_categoryRepository);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CheckControl();
            GetAllCategories();
        }

        protected override void btnList_Click(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenKategori != null)
                {
                    secilenKategori.CategoryName = txtKategoriAdi.Text;
                    secilenKategori.Description = txtAciklama.Text;
                    secilenKategori.IsActive = chkAktif.Checked;

                    _categoryService.Update(secilenKategori);
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    GetAllCategories();
                }
                else
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenKategori!=null)
                {
                    _categoryService.Delete(secilenKategori.Id);
                    GetAllCategories();
                    MessageBox.Show("İşlem Başarılı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //formdan verileri al.
                string cName = txtKategoriAdi.Text;
                string cDesc = txtAciklama.Text;

                //Category nesnesi oluştur.
                Category newCat = new Category()
                {
                    CategoryName = cName,
                    Description = cDesc,
                    IsActive = chkAktif.Checked
                };

                //kayıt işlemini gerçekleştir.

                _categoryService.Create(newCat);
                MessageBox.Show("Kayıt Başarılı.");
                GetAllCategories();
                FormuTemizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormuTemizle()
        {
            txtAciklama.Text = "";
            txtKategoriAdi.Text = "";
            txtKategoriAdi.Focus();
        }

        private void GetAllCategories()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "CategoryName";
            lstListe.DataSource = _categoryService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenKategori = null;
            FormuTemizle();
        }

        private void chkAktif_CheckedChanged(object sender, EventArgs e)
        {
            CheckControl();
        }

        private void CheckControl()
        {
            chkAktif.Text = chkAktif.Checked ? "AKTİF" : "PASİF";
        }

        Category? secilenKategori;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Secili kategoriyi yakalayarak textboxları dolduralım.
            if (lstListe.SelectedIndex != -1)
            {
                secilenKategori = (Category?)lstListe.SelectedItem;

                if (secilenKategori != null)
                {
                    txtKategoriAdi.Text = secilenKategori.CategoryName;
                    txtAciklama.Text = secilenKategori.Description;
                    chkAktif.Checked = secilenKategori.IsActive;
                }
            }
        }
    }
}
