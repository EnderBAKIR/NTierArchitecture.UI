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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        //protected > sadece kendinden türetilen sınıflardan erişime izin verilir.
        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnList_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox gbox= (GroupBox)item;

                    foreach (var t in gbox.Controls)
                    {
                        if (t is TextBox)
                        {
                            TextBox a = t as TextBox;
                            a.Text = string.Empty;
                        }

                        if (t is CheckBox)
                        {
                            CheckBox chk = t as CheckBox;
                            chk.Checked = false;
                        }
                    }
                }

                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }
            }
        }
    }
}
