using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        // false = p1 turn; true = p2 turn;
        bool turnFlag = false;

        //Game board list 
        List<string> board = new List<string>();

        string winner;

        #endregion


        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            InitGame();
        }

        #endregion

        #region Events
        private void Btn00_Click(object sender, RoutedEventArgs e)
        {
            if (btn00.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn00.Content = "X";
                    board[0] = "X";
                }
                else
                {
                    btn00.Content = "O";
                    board[0] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            if (btn01.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn01.Content = "X";
                    board[1] = "X";
                }
                else
                {
                    btn01.Content = "O";
                    board[1] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn02_Click(object sender, RoutedEventArgs e)
        {
            if (btn02.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn02.Content = "X";
                    board[2] = "X";
                }
                else
                {
                    btn02.Content = "O";
                    board[2] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            if (btn10.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn10.Content = "X";
                    board[3] = "X";
                }
                else
                {
                    btn10.Content = "O";
                    board[3] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            if (btn11.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn11.Content = "X";
                    board[4] = "X";
                }
                else
                {
                    btn11.Content = "O";
                    board[4] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            if (btn12.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn12.Content = "X";
                    board[5] = "X";
                }
                else
                {
                    btn12.Content = "O";
                    board[5] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            if (btn20.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn20.Content = "X";
                    board[6] = "X";
                }
                else
                {
                    btn20.Content = "O";
                    board[6] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn21_Click(object sender, RoutedEventArgs e)
        {
            if (btn21.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn21.Content = "X";
                    board[7] = "X";
                }
                else
                {
                    btn21.Content = "O";
                    board[7] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        private void Btn22_Click(object sender, RoutedEventArgs e)
        {   if (btn22.Content as string == "")
            {
                if (!turnFlag)
                {
                    btn22.Content = "X";
                    board[8] = "X";
                }
                else
                {
                    btn22.Content = "O";
                    board[8] = "O";
                }

                turnFlag = !turnFlag;
                FlipLabel();

                IsGameOver();
            }
        }

        #endregion

        #region Methods

        private void IsGameOver()
        {
            int blankCount = 0;
            
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] == "")
                {
                    blankCount++;
                }
            }

            if (DiagonalWin() || RowWin() || ColumnWin())
            {
                MessageBox.Show(winner + " is the winner");

                ResetGame();
            }
            else if (blankCount == 0)
            {
                MessageBox.Show("Tied Game");

                ResetGame();
            }
        }

        private void InitGame()
        {
            board = new List<string>();

            for (int i = 0; i < 9; i++)
            {
                board.Add("");
            }

            lblPlayerTurn.Content = "X";
            turnFlag = false;
        }

        private void ResetGame()
        {
            btn00.Content = "";
            btn01.Content = "";
            btn02.Content = "";
            btn10.Content = "";
            btn11.Content = "";
            btn12.Content = "";
            btn20.Content = "";
            btn21.Content = "";
            btn22.Content = "";
            InitGame();
        }

        private bool DiagonalWin()
        {
            if (board[0] == board[4] && board[4] == board[8] && board[0] != "")
            {
                winner = board[0];
                return true;
            }

            if (board[2] == board[4] && board[4] == board[6] && board[2] != "")
            {
                winner = board[2];
                return true;
            }

            return false;
        }

        private bool ColumnWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6] && board[i] != "")
                {
                    winner = board[i];
                    return true;
                }
            }

            return false;
        }

        private bool RowWin()
        {
            for (int i = 0; i < board.Count; i += 3)
            {
                if (board[i] == board[i + 1] && board[i + 1] == board[i + 2] && board[i] != "")
                {
                    winner = board[i];
                    return true;
                }
            }

            return false;
        }

        private void FlipLabel()
        {
            if (!turnFlag)
            {
                lblPlayerTurn.Content = "X";
            }
            else
            {
                lblPlayerTurn.Content = "O";
            }
        }

        #endregion
    }
}
