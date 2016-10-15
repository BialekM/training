using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edwin_chessboard_drawn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
            int j = 0;

            SolidBrush BlackField = new SolidBrush(Color.Black);
            SolidBrush WhiteField = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(i, j, 80, 80);
            Graphics g = e.Graphics;

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {

                    if ((i + j) % 2 == 1)
                    {
                        g.FillRectangle(BlackField, i * 80, j * 80, 80, 80);
                    }
                    else
                    {
                        g.FillRectangle(WhiteField, i * 80, j * 80, 80, 80);
                    }
                }
            }
        }
    }
}
