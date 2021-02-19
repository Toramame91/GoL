using System;
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
    public partial class UniverseSettingsDialog : Form
    {
        public UniverseSettingsDialog()
        {
            InitializeComponent();
        }
        //property for time interval
        public decimal TimeInterval
        {
            get { return numericUpDownTimeInterval.Value; }
            set { numericUpDownTimeInterval.Value = value; }
        }
        //property for universe width
        public decimal UniverseHeight
        {
            get { return numericUpDownHeight.Value; }
            set { numericUpDownHeight.Value = value; }
        }
        //property for universe length
        public decimal UniverseLength
        {
            get { return numericUpDownLength.Value; }
            set { numericUpDownLength.Value = value; }
        }
    }
}
