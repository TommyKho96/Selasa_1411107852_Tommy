﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selasa_1411107852_Tommy
{
    public partial class Latihan_1_1 : Form
    {
        public Latihan_1_1()
        {
            InitializeComponent();
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 20;
            vScrollBar2.Minimum = 0;
            vScrollBar2.Maximum = 20;

            vScrollBar1.Value = 0;
            vScrollBar2.Value = 20;

        }

        private void Latihan_1_1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Help;
            label1.Text = "" + vScrollBar1.Value.ToString();
            label2.Text = "" + vScrollBar2.Value.ToString();

            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 3000;
            tooltip.InitialDelay = 500;
            tooltip.ReshowDelay = 100;
            tooltip.SetToolTip(this.halaman1next, "Next");
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int tempbertambah;
            tempbertambah = vScrollBar1.Value - 1;
            int temp;
            temp = vScrollBar1.Value;
            int tempberkurang;
            tempberkurang = vScrollBar1.Value + 1;
            label1.Text = "" + vScrollBar1.Value.ToString();

            if (vScrollBar1.Value > vScrollBar1.Minimum)
            {
                if (vScrollBar2.Value > 0)
                {
                    vScrollBar2.Value -= 1;
                    label2.Text = "" + vScrollBar2.Value.ToString();
                }
                else
                {
                    vScrollBar2.Value += 0;
                    label2.Text = "" + vScrollBar2.Value.ToString();
                }

            }


            else if (vScrollBar1.Value == vScrollBar1.Maximum)
            {
                vScrollBar2.Value += 1;
                label2.Text = "" + vScrollBar2.Value.ToString();
            }

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "" + vScrollBar2.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Latihan_2_1 latihan2 = new Latihan_2_1();
            Latihan_1_1 latihan1 = new Latihan_1_1();
            this.Hide();
            latihan1.Close();
            latihan2.Show();

        }

    }
}
