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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=HalDB;Integrated Security = True");
        SqlCommand kmt = new SqlCommand();
        DataSet ds = new DataSet();

        public static string deger = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ds.Clear();
            textBox1.Text = "";
            dataGridView1.DataSource = null;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            
            
            string deger1;
            label2.Text = "";
            deger = comboBox1.SelectedItem.ToString();
            label2.Text = deger+" "+"Fiyatı";
            SqlDataAdapter kmt = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat] From HalFDB where cinsi= '"+deger+"'", conn);
              kmt.Fill(ds, "tbl1");
              dataGridView1.DataSource = ds.Tables["tbl1"];
            deger1 = Form1.kln.ToString ();
            if (deger1 == "Akdeniz")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From Akdeniz where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                int seca = dataGridView2.SelectedCells[0].RowIndex;
                string bryfiyat = dataGridView2.Rows[seca].Cells[1].Value.ToString();
                textBox1.Text = bryfiyat;
                
            }
            else if (deger1 == "Vişnelik")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From Vişnelik where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                int seca = dataGridView2.SelectedCells[0].RowIndex;
                string bryfiyat = dataGridView2.Rows[seca].Cells[1].Value.ToString();
                textBox1.Text = bryfiyat;
            }
            else if (deger1 == "BülentSaka")
            {
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From BülentSaka where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                int seca = dataGridView2.SelectedCells[0].RowIndex;
                string bryfiyat = dataGridView2.Rows[seca].Cells[1].Value.ToString();
                textBox1.Text = bryfiyat;
            }

            if (deger == "Limon")
            {
                pictureBox1.Visible = true; 
            }
            else if (deger == "Elma")
            {
                pictureBox2.Visible = true;
            }
            else if (deger == "Muz")
            { 
                pictureBox3.Visible = true;
            }
            else if (deger == "Soğan")
            {
                pictureBox4.Visible = true;
            }
            else if (deger == "Armut")
            {
                pictureBox5.Visible = true;
            }
            else if (deger == "Portakal")
            {
                pictureBox6.Visible = true;
            }
            else if (deger == "Avokado")
            {
                pictureBox7.Visible = true;
            }
            else if (deger == "Kivi")
            {
                pictureBox8.Visible = true;
            }
            else if (deger == "Üzüm")
            {
                pictureBox9.Visible = true;
            }
            else if (deger == "Erik")
            {
                pictureBox10.Visible = true;
            }
            else if (deger == "Domates")
            {
                pictureBox11.Visible = true;
            }
            else if (deger == "Salatalık")
            {
                pictureBox12.Visible = true;
            }
            else if (deger == "Tatlı Biber")
            {
                pictureBox13.Visible = true;
            }
            else if (deger == "Sarımsak")
            {
                pictureBox14.Visible = true;
            }
            else if (deger == "Mantar")
            {
                pictureBox15.Visible = true;
            }
            else if (deger == "Havuç")
            {
                pictureBox16.Visible = true;
            }
            else if (deger == "Patates")
            {
                pictureBox17.Visible = true;
            }
            else if (deger == "Maydanoz")
            {
                pictureBox18.Visible = true;
            }
            else if (deger == "Marul")
            {
                pictureBox19.Visible = true;
            }
            else if (deger == "Zencefil")
            {
                pictureBox20.Visible = true;
            }
            else if (deger == "Taze Fasulye")
            {
                pictureBox21.Visible = true;
            }
            else if (deger == "Bezelye")
            {
                pictureBox22.Visible = true;
            }
            else if (deger == "Greyfurt")
            {
                pictureBox23.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Hesaptan çıkış yapılıyor...", "===> Görüşmek Üzere <===");
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ds.Clear();
            string deger1;
            deger1 = Form1.kln.ToString();
            if (deger1 == "Akdeniz")
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                kmt = new SqlCommand("Update Akdeniz set brfiyatm =@fiyat where  cinsi ='"+deger+"'",conn);
                kmt.Parameters.AddWithValue("@fiyat",textBox1.Text);
                kmt.ExecuteNonQuery();
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From Akdeniz where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                SqlDataAdapter kmt3 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat] From HalFDB where cinsi= '" + deger + "'", conn);
                kmt3.Fill(ds, "tbl1");
                dataGridView1.DataSource = ds.Tables["tbl1"];
                textBox1.Text = "";
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();

            }
            else if (deger1 == "Vişnelik")
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                kmt = new SqlCommand("Update Vişnelik set brfiyatm =@fiyat where  cinsi ='" + deger + "'", conn);
                kmt.Parameters.AddWithValue("@fiyat", textBox1.Text);
                kmt.ExecuteNonQuery();
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From Vişnelik where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                SqlDataAdapter kmt3 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat] From HalFDB where cinsi= '" + deger + "'", conn);
                kmt3.Fill(ds, "tbl1");
                dataGridView1.DataSource = ds.Tables["tbl1"];
                textBox1.Text = "";
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            }
            else if (deger1 == "BülentSaka")
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                kmt = new SqlCommand("Update BülentSaka set brfiyatm =@fiyat where  cinsi ='" + deger + "'", conn);
                kmt.Parameters.AddWithValue("@fiyat", textBox1.Text);
                kmt.ExecuteNonQuery();
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyatm[Br.Fiyat] From BülentSaka where cinsi ='" + deger + "' ", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                SqlDataAdapter kmt3 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat] From HalFDB where cinsi= '" + deger + "'", conn);
                kmt3.Fill(ds, "tbl1");
                dataGridView1.DataSource = ds.Tables["tbl1"];
                textBox1.Text = "";
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.kln +" "+"Manav A.Ş";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama kapatılıyor iyi günler..", "===> Görüşmek Üzere <===");
            Application.Exit();
        }
    }
}
