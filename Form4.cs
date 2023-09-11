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

namespace HalProjesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=HalDB;Integrated Security = True");
        SqlCommand kmt = new SqlCommand();
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
            
        {
            ds.Clear();
            string deger1;
            deger1 = Form1.kln.ToString();
            if (deger1 == "Akdeniz")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From Akdeniz", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
            }
            else if (deger1 == "Vişnelik")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From Vişnelik", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
            }
            else if (deger1 == "BülentSaka")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From BülentSaka ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label6.Text = Form1.kln;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seca = dataGridView2.SelectedCells[0].RowIndex;
            string bryfiyat = dataGridView2.Rows[seca].Cells[1].Value.ToString();
            string yerm = dataGridView2.Rows[seca].Cells[3].Value.ToString();
            string stok = dataGridView2.Rows[seca].Cells[2].Value.ToString();
            string cinsi = dataGridView2.Rows[seca].Cells[0].Value.ToString();

            textBox1.Text = cinsi;
            textBox2.Text = stok;
            textBox3.Text = bryfiyat;
            textBox4.Text = yerm;





        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string deger1;
            deger1 = Form1.kln.ToString();
            if (deger1 == "Akdeniz")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(" Update Akdeniz set brfiyatm='" + textBox3.Text + "',stokm='" + textBox2.Text + "', yerm='" + textBox4.Text + "' where cinsi='" + textBox1.Text + "' ",conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Akdeniz",conn);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From Akdeniz", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            }
            else if (deger1 == "Vişnelik")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(" Update Vişnelik set brfiyatm='" + textBox3.Text + "',stokm='" + textBox2.Text + "', yerm='" + textBox4.Text + "' where cinsi='" + textBox1.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Vişnelik", conn);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From Vişnelik", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            }
            else if (deger1 == "BülentSaka")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(" Update BülentSaka set brfiyatm='" + textBox3.Text + "',stokm='" + textBox2.Text + "', yerm='" + textBox4.Text + "' where cinsi='" + textBox1.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * From BülentSaka", conn);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat],stokm[Stok],yerm[Ürt.Yer] From BülentSaka", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            }

        }
    }
}
