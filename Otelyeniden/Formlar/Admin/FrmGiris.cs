﻿using DevExpress.XtraEditors;
using Otelyeniden.Entityy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelyeniden.Formlar.Admin
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities2 db=new DbOtelYeniEntities2();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (kullanici != null)
            {
                Form1 frm=new Form1();
                frm.kullanicirolu = kullanici.Rol;
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adınız veya şifreniz yanlış,tekrar deneyin", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
