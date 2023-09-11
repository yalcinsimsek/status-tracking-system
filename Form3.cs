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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HalProjesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=HalDB;Integrated Security = True");
        SqlCommand kmt = new SqlCommand();
        DataSet ds = new DataSet();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama kapatılıyor iyi günler..", "===> Görüşmek Üzere <===");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaptan çıkış yapılıyor...", "===> Görüşmek Üzere <===");
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string deger1;
            deger1 = Form1.kln.ToString();
            
                conn.Open();
                SqlCommand cmd = new SqlCommand(" Update HalFDB set brfiyath='" + textBox3.Text + "',stokh='" + textBox2.Text + "', yerh='" + textBox4.Text + "' where cinsi='" + textBox1.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("Select * From HalFDB", conn);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat],stokh[Stok],yerh[Ürt.Yer] From HalFDB", conn);
                kmt1.Fill(ds, "tbl2");
                dataGridView2.DataSource = ds.Tables["tbl2"];
                MessageBox.Show("Başarıyla Güncellendi !!", "===> BAŞARILI <===", MessageBoxButtons.OK);
                conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string deger1;
            deger1 = Form1.kln.ToString();


            SqlDataAdapter kmt1 = new SqlDataAdapter("Select cinsi[Cinsi],brfiyath[Br.Fiyat],stokh[Stok],yerh[Ürt.Yer] From HalFDB", conn);
            kmt1.Fill(ds, "tbl1");
            dataGridView2.DataSource = ds.Tables["tbl1"];
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string deger;
            deger = textBox1.Text.ToString();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
