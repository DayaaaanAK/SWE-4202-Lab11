using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player_1 = true;
        int score_1 = 0;
        int score_2 = 0;
        bool WinState()
        {
            if (Cell_1x1.Text != "" && Cell_1x1.Text == Cell_1x2.Text && Cell_1x2.Text == Cell_1x3.Text)
                return true;
            else if (Cell_2x1.Text != "" && Cell_2x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_2x3.Text)
                return true;
            else if (Cell_3x1.Text != "" && Cell_3x1.Text == Cell_3x2.Text && Cell_3x2.Text == Cell_3x3.Text)
                return true;
            else if (Cell_1x1.Text != "" && Cell_1x1.Text == Cell_2x1.Text && Cell_2x1.Text == Cell_3x1.Text)
                return true;
            else if (Cell_1x2.Text != "" && Cell_1x2.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_3x2.Text)
                return true;
            else if (Cell_1x3.Text != "" && Cell_1x3.Text == Cell_2x3.Text && Cell_2x3.Text == Cell_3x3.Text)
                return true;
            else if (Cell_1x1.Text != "" && Cell_1x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_3x3.Text)
                return true;
            else if (Cell_3x1.Text != "" && Cell_3x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_1x3.Text)
                return true;
            else return false;
        }
        bool DrawState()
        {
            if (Cell_1x1.Text != "" && Cell_1x2.Text != "" && Cell_1x3.Text != "" && Cell_2x1.Text != "" && Cell_2x2.Text != "" && Cell_2x3.Text != "" && Cell_3x1.Text != "" && Cell_3x2.Text != "" && Cell_3x3.Text != "" && WinState() == false)
                return true;
            else return false;
        }
        void clear()
        {
            Cell_1x1.Text = "";
            Cell_2x1.Text = "";
            Cell_3x1.Text = "";
            Cell_1x2.Text = "";
            Cell_2x2.Text = "";
            Cell_3x2.Text = "";
            Cell_1x3.Text = "";
            Cell_2x3.Text = "";
            Cell_3x3.Text = "";
        }

        private void OnClick_1x1(object sender, EventArgs e)
        {
            if(Cell_1x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x1.Text = "X";
                }
                else
                {
                    Cell_1x1.Text = "O";
                }
                player_1 = !player_1;
            }
            if(WinState() == true)
            {
                if(player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if(DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void OnClick_1x2(object sender, EventArgs e)
        {
            if (Cell_1x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x2.Text = "X";
                }
                else
                {
                    Cell_1x2.Text = "O";
                }
                
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_1x3(object sender, EventArgs e)
        {
            if (Cell_1x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x3.Text = "X";
                }
                else
                {
                    Cell_1x3.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_2x3(object sender, EventArgs e)
        {
            if (Cell_2x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x3.Text = "X";
                }
                else
                {
                    Cell_2x3.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_3x3(object sender, EventArgs e)
        {
            if (Cell_3x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x3.Text = "X";
                }
                else
                {
                    Cell_3x3.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_3x2(object sender, EventArgs e)
        {
            if (Cell_3x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x2.Text = "X";
                }
                else
                {
                    Cell_3x2.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_3x1(object sender, EventArgs e)
        {
            if (Cell_3x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x1.Text = "X";
                }
                else
                {
                    Cell_3x1.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_2x1(object sender, EventArgs e)
        {
            if (Cell_2x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x1.Text = "X";
                }
                else
                {
                    Cell_2x1.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }

        private void OnClick_2x2(object sender, EventArgs e)
        {
            if (Cell_2x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x2.Text = "X";
                }
                else
                {
                    Cell_2x2.Text = "O";
                }
            }
            if (WinState() == true)
            {
                if (player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Player 2 wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
            player_1 = !player_1;
        }
    }
}
