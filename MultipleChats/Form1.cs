﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChatUI.Form1 frm1 = new ChatUI.Form1();
            frm1.Text = "User A";
            frm1.Chatter = "User A";
            frm1.Show();

            ChatUI.Form1 frm2 = new ChatUI.Form1();
            frm2.Text = "User B";
            frm2.Chatter = "User B";
            frm2.Show();
            this.Hide();
        }
    }
}
