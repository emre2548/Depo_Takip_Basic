using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Depo_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItemAdd = new ListViewItem();

            listViewItemAdd.Text = cmbItemNameAdd.Text;
            listViewItemAdd.SubItems.Add(tbItemNumAdd.Text);

            listView1.Items.Add(listViewItemAdd);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbItemNameAdd.Items.Add("Kereste");
            cmbItemNameAdd.Items.Add("Tornavida");
            cmbItemNameAdd.Items.Add("Anahtar");
            cmbItemNameAdd.Items.Add("Vida");
            cmbItemNameAdd.Items.Add("Poşet");

            cmbItemNameReduce.Items.Add("Kereste");
            cmbItemNameReduce.Items.Add("Tornavida");
            cmbItemNameReduce.Items.Add("Anahtar");
            cmbItemNameReduce.Items.Add("Vida");
            cmbItemNameReduce.Items.Add("Poşet");
        }
    }
}
