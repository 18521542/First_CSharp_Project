﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Tier.Forms__ForManageData
{
    public partial class AddBook : Form
    {
        private static AddBook instance = null;

        public bool isShown = false;

        public static AddBook getInstance() 
        {
            if (instance == null)
                instance = new AddBook();
            return instance;
        }
        public AddBook()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            isShown = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
