﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void addNamebtn_Click(object sender, EventArgs e)
        {
            string lastName = lastNametxb.Text;
            string firstName = firstNametxb.Text;
            string phone = phonetxb.Text;

            if (lastName == "" || firstName == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                return;
            }

            ListViewItem item = new ListViewItem(lastName);

            item.SubItems.Add(firstName);
            item.SubItems.Add(phone);
            item.ImageIndex = 0;

            listView.Items.Add(item);
        }

        
        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.GridLines = true;
        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.GridLines = true;
        }
    }
}
