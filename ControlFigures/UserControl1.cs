using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFigures
{
    public partial class pnlFigura : UserControl
    {
        public pnlFigura()
        {
            InitializeComponent();
        }

        public string figura
        {
            get { return lblTipo.Text; }
            set { lblTipo.Text = value; }
        }

        public string Calculo
        {
            get { return lblResult.Text; }
            set { lblResult.Text = value; }
        }

        public string Result
        {
            get { return pb1.ImageLocation; }
            set { pb1.ImageLocation = value; }
        }
    }
}
