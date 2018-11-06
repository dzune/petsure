using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_the_Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            // numericdropdowns validates the input 
            string myShape = "";
            myShape = Shape(Convert.ToInt32(txtLeft.Value), Convert.ToInt32(txtTop.Value), Convert.ToInt32(txtRight.Value), Convert.ToInt32(txtBottom.Value));
            if (myShape != "")
            {
                MessageBox.Show("The Shape is " + myShape);
            }
            else
            {
                MessageBox.Show("Please Enter a Value for Each Side");
            }
        }

        /// <summary>
        /// This function returns the shape
        /// </summary>
        /// <param name="intSide1">Left Side</param>
        /// <param name="intSide2">Top Side</param>
        /// <param name="intSide3">Right Side</param>
        /// <param name="intSide4">Bottom Side</param>
        /// <returns></returns>
        private string Shape(int intSide1, int intSide2, int intSide3, int intSide4 )
        {
            
            if(intSide1 == 0 || intSide3 == 0 || intSide2 == 0 || intSide4 == 0)
            {
                return "";
            }
            string strShape = "";
            if (intSide1 != intSide3 || intSide2 != intSide4)
            {
                strShape = "Neither a Square or a Rectangle";
            }
            else if((intSide1 == intSide3 && intSide2 == intSide4) && (intSide1 != intSide2))
            {
                strShape = "Rectangle";
            }
            else 
            {
                strShape = "Square";
            }
            return strShape;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            txtLeft.Value = 0;
            txtRight.Value = 0;
            txtTop.Value = 0;
            txtBottom.Value = 0;
            txtTop.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
