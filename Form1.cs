using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HalProjesi
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Server=.;Database=HalDB;Integrated Security = True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama kapat�l�yor iyi g�nler..", "===> G�r��mek �zere <===");
            Application.Exit();
        }

        public static string kln = "";
        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == ""))

            {
                MessageBox.Show("Eksik Giri� Yapt�n�z !!", "===> HATA <===", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            try
            {
                conn.Open();
                string sql = "SELECT * FROM ManavGrs WHERE kullan�c�_adi=@kadi1 AND sifre=@sifre1";
                SqlParameter dg1 = new SqlParameter("@kadi1", textBox1.Text);
                SqlParameter dg2 = new SqlParameter("@sifre1", textBox2.Text);
                SqlCommand kmd = new SqlCommand(sql, conn);
                kmd.Parameters.Add(dg1);
                kmd.Parameters.Add(dg2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(kmd);
                da.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    
                    kln = textBox1.Text;
                    MessageBox.Show("Ba�ar�yla giri� yapt�n�z.", "===> Ho�geldiniz <===");
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� bulunamad� !", "===> HATA <===", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == ""))

            {
                MessageBox.Show("Eksik Giri� Yapt�n�z !!", "===> HATA <===", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            


        }
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Y�neticiGrs WHERE ykullanici_adi=@ykadi1 AND ysifre=@ysifre1";
                SqlParameter dg1 = new SqlParameter("@ykadi1", textBox3.Text);
                SqlParameter dg2 = new SqlParameter("@ysifre1", textBox4.Text);
                SqlCommand kmd = new SqlCommand(sql, conn);
                kmd.Parameters.Add(dg1);
                kmd.Parameters.Add(dg2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(kmd);
                da.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                   
                    MessageBox.Show("Ba�ar�yla giri� yapt�n�z.", "===> Ho�geldiniz <===");
                    this.Hide();
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� bulunamad� !", "===> HATA <===", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;

            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.UseSystemPasswordChar = true;

            }
            else
            {
                textBox4.UseSystemPasswordChar = false;
            }
        }
    }
    }
