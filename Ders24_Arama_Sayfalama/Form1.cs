using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders24_Arama_Sayfalama
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader sdr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // listviewDoldur();
            listviewDoldur_sayfali();
            btn_geri.Visible = false;
            urunsayisibul();
        }

        void urunsayisibul()
        {
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "select Count (*)  from Products";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                lbl_urunsayisi.Text = sdr[0].ToString();
            }
            sqlcon.Close();
        }

        void listviewDoldur()
        {
            lst_urunler.Items.Clear();
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "select productID,ProductName,Unitprice,UnitsInStock,CategoryName,CompanyName from Products as p inner join Categories as c on p.CategoryID = c.CategoryID inner join Suppliers as s on p.SupplierID = s.SupplierID";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr[0].ToString();
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lst_urunler.Items.Add(lv);
            }
            sqlcon.Close();
        }

        private void txt_productName_TextChanged(object sender, EventArgs e)
        {
            lst_urunler.Items.Clear();
            string urunadi = txt_productName.Text;

            lst_urunler.Items.Clear();
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "select ProductID,ProductName,UnitPrice,UnitsInStock,CategoryName,CompanyName from Products p inner join Categories c on p.CategoryID = c.CategoryID inner join Suppliers s on p.SupplierID = s.SupplierID where p.productname like '%" +urunadi+ "%' order by ProductName ";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr[0].ToString();
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lv.SubItems.Add(sdr[4].ToString());
                lv.SubItems.Add(sdr[5].ToString());
                lst_urunler.Items.Add(lv);
            }
            sqlcon.Close();
            btn_ileri.Visible = false;
        }

        void listviewDoldur_sayfali()
        {
            int degisken1 = 0;
            int degisken2 = 10;
            lst_urunler.Items.Clear();
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT ProductID,ProductName,UnitPrice,UnitsInStock,CategoryName,CompanyName FROM Products AS p INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID INNER JOIN Suppliers AS s ON p.SupplierID = s.SupplierID ORDER BY ProductID OFFSET " + degisken1 + " ROWS FETCH NEXT " + degisken2 + " ROWS ONLY";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr[0].ToString();
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lst_urunler.Items.Add(lv);
            }
            sqlcon.Close();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            btn_ileri.Visible = true;

            int sayfano = Convert.ToInt32(txt_sayfano.Text) - 2;

            lst_urunler.Items.Clear();
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "select ProductID,ProductName,UnitPrice,UnitsInStock from Products  order by ProductID offset " + sayfano * 10 + " rows fetch next 10 rows only";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr[0].ToString();
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lst_urunler.Items.Add(lv);
            }
            sqlcon.Close();

            txt_sayfano.Text = (Convert.ToInt32(txt_sayfano.Text) - 1).ToString();

            if (sayfano == 0)
            {
                btn_geri.Visible = false;
            }

        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            int sayfano = Convert.ToInt32(txt_sayfano.Text);

            btn_geri.Visible = true;
            lst_urunler.Items.Clear();
            sqlcon = cls_connection.baglanti;
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "select ProductID,ProductName,UnitPrice,UnitsInStock from Products  order by ProductID offset "+ sayfano * 10 + " rows fetch next 10 rows only";
            sqlcmd.Connection = sqlcon;
            sdr = sqlcmd.ExecuteReader();
            foreach (var item in sdr)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr[0].ToString();
                lv.SubItems.Add(sdr[1].ToString());
                lv.SubItems.Add(sdr[2].ToString());
                lv.SubItems.Add(sdr[3].ToString());
                lst_urunler.Items.Add(lv);
            }
            sqlcon.Close();

            txt_sayfano.Text =(Convert.ToInt32(txt_sayfano.Text) + 1).ToString();

            if (Convert.ToInt32(lbl_urunsayisi.Text) / 10 < sayfano + 1)
            {
                btn_ileri.Visible = false;
            }

        }
    }
}
