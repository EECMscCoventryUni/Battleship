using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class battleship : Form
    {

        Board player1 ;
        Board player2;
        public battleship()
        {
            InitializeComponent();

            setUpGame();
        }


        public void  setUpGame() {

            player1 = new Board(12, 12);
            player2 = new Board(12, 12);

            setGrid(player1, Board1);

            setGrid(player2, Board2);

            player1shiplist.DataSource = new string[] { Board.patrol_boat1, Board.patrol_boat2, Board.battleship1, Board.battleship2, Board.submarine, Board.destroyer, Board.carrier };
            player1shipalign.DataSource = new string[] { Board.horizontalalign, Board.verticalalign };

            player2shiplist.DataSource = new string[] { Board.patrol_boat1, Board.patrol_boat2, Board.battleship1, Board.battleship2, Board.submarine, Board.destroyer, Board.carrier };
            player2shipalign.DataSource = new string[] { Board.horizontalalign, Board.verticalalign };
        }    
        public void setGrid(Board boardobj, DataGridView board) {

            var data = boardobj.board;
            var rowCount = data.GetLength(0);
            var rowLength = data.GetLength(1);


            board.ColumnCount = rowCount;
            board.Rows.Clear();
           

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = data[rowIndex, columnIndex]
                    });
                }

                board.Rows.Add(row);
            }
        }

        // Player 1 place ships

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = Board1.SelectedCells[0].RowIndex;
            int columnindex = Board1.SelectedCells[0].ColumnIndex;

            bool success = player1.placeship(rowindex, columnindex, player1shiplist.SelectedItem.ToString(), player1shipalign.SelectedItem.ToString());

            if (success) {
                setGrid(player1, Board1);
            } else
            {

                player1message.Text = "Ship cannot be placed in that position";
            }
             
     
        }
        //private void button11_Click(object sender, EventArgs e)
        //{
        //    player1.placeship(0, 1, Board.patrol_boat1, Board.horizontalalign);
        //    player1.placeship(1, 1, Board.patrol_boat2, Board.verticalalign);

        //    setGrid(player1, Board1);
        //    button1.Enabled = false;
        //    // once players have set thier ships enable play for first player
        //    if (!button2.Enabled)
        //      button3.Enabled = true;
        //}
        // Player 2 place ships

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = Board2.SelectedCells[0].RowIndex;
            int columnindex = Board2.SelectedCells[0].ColumnIndex;

            bool success = player2.placeship(rowindex, columnindex, player2shiplist.SelectedItem.ToString(), player2shipalign.SelectedItem.ToString());

            if (success)
            {
                setGrid(player2, Board2);
            }
            else
            {

                player2message.Text = "Ship cannot be placed in that position";
            }

           
        }
        //private void button22_Click(object sender, EventArgs e)
        //{
        //    player2.placeship(1, 0, Board.patrol_boat1, Board.horizontalalign);
        //    player2.placeship(1, 2, Board.patrol_boat2, Board.verticalalign);
        //    setGrid(player2, Board2);
        //    button2.Enabled = false;
        //    // once players have set thier ships enable play for first player
        //    if (!button1.Enabled)
        //        button3.Enabled = true;
        //}

        // player 1 take shot
        private void button3_Click(object sender, EventArgs e)
        {

            // click on your own board to take shot at opponent
            int rowindex = Board1.SelectedCells[0].RowIndex;
            int columnindex = Board1.SelectedCells[0].ColumnIndex;

            var is_shot_hit = player2.takeshot(rowindex, columnindex);
            if (!is_shot_hit)
            {
                //give chance to the other player as it is a miss
                button4.Enabled = true;
                button3.Enabled = false;
            }
            else
            { // if hit check if all ships sunked 
                if (player2.checksunkShips())
                {
                    button3.Enabled = false;
                    gameResult.Text = "All ships of Player 2 sanked and Player 1 has won";
                }
            }



            setGrid(player2, Board2);
        }

        // player 2 take shot
        private void button4_Click(object sender, EventArgs e)
        {
            // click on your own board to take shot at opponent
            int rowindex = Board2.SelectedCells[0].RowIndex;
            int columnindex = Board2.SelectedCells[0].ColumnIndex;

            var is_shot_hit = player1.takeshot(rowindex, columnindex);
            if (!is_shot_hit)
            { // give  chance to the other player as it is a miss
                button3.Enabled = true;
                button4.Enabled = false;
            }
            else { // if hit check if all ships sunked 
                if (player1.checksunkShips())
                {
                    button4.Enabled = false;
                    gameResult.Text = "All ships of Player 1 sanked and Player 2 has won";
                }
            }
                    


            setGrid(player1, Board1);

        }

        private void player1doneplacing_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            player1doneplacing.Enabled = false;
            if (!player2doneplacing.Enabled) {
               
                button3.Enabled = true;
            }
        }

        private void player2doneplacing_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            player2doneplacing.Enabled = false;
            if (!player1doneplacing.Enabled)
            {
                button3.Enabled = true;           
            }
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            setUpGame();
            player1doneplacing.Enabled = true;
            player2doneplacing.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            button3.Enabled = false;
            button4.Enabled = false;
            player1message.Text = "";
            player2message.Text = "";
        }
    }
}
