﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)

        {
         
            Form jogo = new Form_jogo(box1.Text, box2.Text);
            jogo.Show();
            this.Visible = false;
        }

        private void box2_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
