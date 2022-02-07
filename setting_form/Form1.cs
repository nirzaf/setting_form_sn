using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace setting_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //////this.title_textBox1.Text = setting_form.Properties.Settings.Default.co_title;
            //////this.manager_textBox2.Text = setting_form.Properties.Settings.Default.co_manager;
            //////this.adv_textBox3.Text = setting_form.Properties.Settings.Default.co_adv;
            //////this.tel_textBox4.Text = setting_form.Properties.Settings.Default.co_tel;
            //////this.cell_textBox5.Text = setting_form.Properties.Settings.Default.co_cell;
            //////this.fax_textBox6 .Text = setting_form.Properties.Settings.Default.co_fax ;
            //////this.act_textBox7.Text = setting_form.Properties.Settings.Default.co_activity ;
            //////this.email_textBox8 .Text = setting_form.Properties.Settings.Default.co_email ;
            //////this.site_textBox9.Text = setting_form.Properties.Settings.Default.co_site ;
            //////this.add_textBox10.Text = setting_form.Properties.Settings.Default.co_add ;
            //////this.lang_comboBox1 .Text = setting_form.Properties.Settings.Default.co_language;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // button4_Click(sender, e);
            this.title_textBox1.Text = setting_form.Properties.Settings.Default.co_title;
            this.manager_textBox2.Text = setting_form.Properties.Settings.Default.co_manager;
            this.adv_textBox3.Text = setting_form.Properties.Settings.Default.co_adv;
            this.tel_textBox4.Text = setting_form.Properties.Settings.Default.co_tel;
            this.cell_textBox5.Text = setting_form.Properties.Settings.Default.co_cell;
            this.fax_textBox6.Text = setting_form.Properties.Settings.Default.co_fax;
            this.act_textBox7.Text = setting_form.Properties.Settings.Default.co_activity;
            this.email_textBox8.Text = setting_form.Properties.Settings.Default.co_email;
            this.site_textBox9.Text = setting_form.Properties.Settings.Default.co_site;
            this.add_textBox10.Text = setting_form.Properties.Settings.Default.co_add;
            this.lang_comboBox1.Text = setting_form.Properties.Settings.Default.co_language;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setting_form.Properties.Settings.Default.co_title = this.title_textBox1.Text;
            setting_form.Properties.Settings.Default.co_manager = this.manager_textBox2.Text;
            setting_form.Properties.Settings.Default.co_adv = this.adv_textBox3.Text;
            setting_form.Properties.Settings.Default.co_tel = this.tel_textBox4.Text;
            setting_form.Properties.Settings.Default.co_cell = this.cell_textBox5.Text;
            setting_form.Properties.Settings.Default.co_fax = this.fax_textBox6.Text;
            setting_form.Properties.Settings.Default.co_activity = this.act_textBox7.Text;
            setting_form.Properties.Settings.Default.co_email = this.email_textBox8.Text;
            setting_form.Properties.Settings.Default.co_site = this.site_textBox9.Text;
            setting_form.Properties.Settings.Default.co_add = this.add_textBox10.Text;
            setting_form.Properties.Settings.Default.co_language = this.lang_comboBox1.Text;
            setting_form.Properties.Settings.Default.Save();
            MessageBox.Show("Settings Saved!");
        }
    }
}
