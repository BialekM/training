using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeSharpBasics.Training3.Homework.AndrzejIwanski;
using SeeSharpBasics.Training4.minesweeper;

namespace Minesweeper
{
    public partial class AndrzejIwanski : Form
    {
        private Button[,] buttons;
        private AndrzejIwanskiMineSweeper mnsw = new AndrzejIwanskiMineSweeper();

        int[,] field;

        private int _fieldWidth = 10;
        private int _fieldHeight = 10;
        private int _bombCount = 10;

        private int _bombsLeft;

        protected int time = 0;

        // ================== Konstruktor generowania formy ===================
        public AndrzejIwanski()
        {
            InitializeComponent();

            _bombsLeft = _bombCount;
            textBox1.Text = _fieldWidth.ToString();
            textBox2.Text = _fieldHeight.ToString();
            textBox3.Text = _bombCount.ToString();
            label6.Text = time.ToString();
            label7.Text = _bombCount.ToString();
        }

        // ================== Akcja wcisniecia przycisku START/RESET ===================
        private void button1_Click(object sender, EventArgs e)
        {
            _fieldWidth = int.Parse(textBox1.Text);
            _fieldHeight = int.Parse(textBox2.Text);
            _bombCount = int.Parse(textBox3.Text);
            _bombsLeft = _bombCount;
            label7.Text = textBox3.Text;

            if (timer1.Enabled)
            {
                timer1.Stop();
                time = 0;
                button1.Text = "START";
                label6.Text = time.ToString();
            }
            else
            {
                if (buttons != null)
                {
                    FieldReset(_fieldWidth, _fieldHeight);
                }
                timer1.Start();
                button1.Text = "RESET";
                FieldGenerator(_fieldWidth, _fieldHeight, _bombCount);
            }
        }

        // ================== Akcja klikniecia okienka pola ===================
        private void buttons_MouseDown(object sender, MouseEventArgs e)
        {
           
            Button temporaryButton = sender as Button;
            string fieldValue = temporaryButton.Tag.ToString();
            
            if (MouseButtons == MouseButtons.Left)
            {
                switch (fieldValue)
                {
                    case "-1":
                        temporaryButton.Text = "X";
                        temporaryButton.BackColor = Color.Crimson;
                        temporaryButton.ForeColor = Color.Black;
                        lose();
                        break;
                    case "0":
                        temporaryButton.Text = "";
                        temporaryButton.ForeColor = Color.Black;
                        temporaryButton.BackColor = Color.Chartreuse;
                        break;
                    default:
                        temporaryButton.Text = fieldValue;
                        temporaryButton.ForeColor = Color.Black;
                        temporaryButton.BackColor = Color.DarkOrange;
                        break;
                }
            }
            else
            {
                temporaryButton.Text = "D";
                temporaryButton.ForeColor = Color.AliceBlue;
                temporaryButton.BackColor = Color.Black;
                label7.Text = (--_bombsLeft).ToString();
            }
            
            if (_bombsLeft == 0)
            {
                win();
            }
        }

        // ================== Komunikat wygrania ===================
        private void win()
        {
            MessageBox.Show("Gratulacje wygrałeś!","Koniec gry");
            timer1.Enabled = false;
        }

        // ================== Komunikat przegrania ===================
        private void lose()
        {
            MessageBox.Show("Niestety przegrałeś!", "Koniec gry");
            timer1.Stop();
            time = 0;
            button1.Text = "START";
            label6.Text = time.ToString();
        }

        // ================== Obsługa tyknięcia zegara ==============
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label6.Text = time.ToString();
        }

        // ================== Generowanie Pola ===================
        private void FieldGenerator(int dimX, int dimY, int bombsCount)
        {
            buttons = new Button[dimX, dimY];

            field = mnsw.BombsCount(dimX, dimY, bombsCount);

            for (int i = 0; i < dimX; i++)
            {
                for (int j = 0; j < dimY; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].BackColor = Color.Gray;
                    buttons[i, j].Location = new Point(10 + (30*i), 130 + (30*j));
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Visible = true;
                    buttons[i, j].MouseDown += buttons_MouseDown;
                    Controls.Add(buttons[i, j]);
                    buttons[i, j].Tag = field[i, j];
                }
            }
        }

        // ================== Resetowanie Pola ===================
        private void FieldReset(int dimX, int dimY)
        {
            for (int i = 0; i < dimX; i++)
            {
                for (int j = 0; j < dimY; j++)
                {
                    buttons[i,j].Dispose();
                }
            }
        }
    }
}
