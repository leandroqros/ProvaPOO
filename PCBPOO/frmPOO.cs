using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;
using Triangle;

namespace PCBPOO
{
    public partial class frmPOO : Form
    {
        Calculs fig = new CalculsT();
        CalculsT Tri = new CalculsT();

        public frmPOO()
        {
            InitializeComponent();
        }
        
        private void btnArea_Click(object sender, EventArgs e)
        {
            double calculo;
         
            calculo = fig.Area(int.Parse(txtDimensio1.Text), int.Parse(txtDimensio2.Text));
            pnlFigura1.figura = "R";
            pnlFigura1.Calculo = "Area: " + calculo;
            pnlFigura1.Result = "plain-square.png";
        }

        private void btnVolum_Click(object sender, EventArgs e)
        {
            //punto 8
            double calculo;

            calculo = fig.Volum(int.Parse(txtDimensio1.Text),int.Parse(txtDimensio2.Text),int.Parse(txtDimensio3.Text));
            pnlFigura1.figura = "R";
            pnlFigura1.Calculo = "Volum: " + calculo;
            pnlFigura1.Result = "plain-square.png";
        }

        private void btnAreaCercle_Click(object sender, EventArgs e)
        {
            //punto 9
            double calculo;

            calculo = fig.Area(int.Parse(txtDimensio1.Text));
            pnlFigura1.figura = "C";
            pnlFigura1.Calculo = "Volum: " + calculo;
            pnlFigura1.Result = "plain-circle.png";
        }

        private void btnAreaTriangle_Click(object sender, EventArgs e)
        {
            //punto 10
            double calculo;

            calculo = Tri.Area(int.Parse(txtDimensio1.Text),int.Parse(txtDimensio2.Text));
            pnlFigura1.figura = "T";
            pnlFigura1.Calculo = "Volum: " + calculo;
            pnlFigura1.Result = "plain-triangle.png";
        }

        private void btnVolumTriangle_Click(object sender, EventArgs e)
        {
            //punto 11
            double calculo;

            calculo = Tri.Volum(int.Parse(txtDimensio1.Text),int.Parse(txtDimensio2.Text));
            pnlFigura1.figura = "T";
            pnlFigura1.Calculo = "Volum: " + calculo;
            pnlFigura1.Result = "plain-triangle.png";
        }
    }
}
