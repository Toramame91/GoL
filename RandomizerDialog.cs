﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class RandomizerDialog : Form
    {
        Random seedRnd = new Random();
        public RandomizerDialog()
        {
            InitializeComponent();
        }

        public decimal Seed
        {
            get { return numericUpDownSeed.Value; }
            set { numericUpDownSeed.Value = value; }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            decimal randomizer = (decimal)seedRnd.Next();
            numericUpDownSeed.Value = randomizer;
        }
    }
}
