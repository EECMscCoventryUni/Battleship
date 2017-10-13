using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Board
    {

        public String[,] board;// = new String[3, 3];
        public const string patrol_boat1 = "patrol boat1";
        public const string patrol_boat2 = "patrol boat2";
        public const string battleship1 = "battleship1";
        public const string battleship2 = "battleship2";
        public const string submarine = "submarine";
        public const string destroyer = "destroyer";
        public const string carrier = "carrier";
        public const string horizontalalign = "horizontal";
        public const string verticalalign = "vertical";
        public Board(int row, int column)
        {
            board = new String[row, column];
        }

        public bool placeship(int startrow, int startcolumn, string shiptype, string align)
        {

            var rtnsucces = true;
            var shiplength = getShipLength(shiptype);
            if (align == "horizontal")
            {
                bool noships = true;
                int bound = board.GetUpperBound(1);
                // first check if no ships occupied
                for (int i = 0; i < shiplength; i++)
                {

                    if ((startcolumn + i) >= 0 && (startcolumn + i) <= bound) // check if it is not outside bounds
                    {
                        string shipvalue = board[startrow, startcolumn + i];
                        if (!(String.IsNullOrEmpty(shipvalue) || shipvalue == shiptype))
                        {
                            noships = false;
                            break;
                        }
                    }
                    else
                    {
                        noships = false;
                        break;

                    }
                        
                }

                if (noships)
                {
                    // if we have this ship previously placed remove it so that it can be places in a new position
                    removeExistingShipfromBoard(shiptype);
                    // now place the ships
                    for (int i = 0; i < shiplength; i++)
                    {
                        board[startrow, startcolumn + i] = shiptype;

                    }
                }
                else
                {
                    rtnsucces = false;
                }

            }
            else
            {

                bool noships = true;
                int bound = board.GetUpperBound(0);
                // first check if no ships occupied
                for (int i = 0; i < shiplength; i++)
                {
                    if ((startrow + i) >= 0 && (startrow + i) <= bound) // check if it is not outside bounds
                    {
                        string shipvalue = board[startrow + i, startcolumn];
                        if (!(String.IsNullOrEmpty(shipvalue) || shipvalue == shiptype))
                        {
                            noships = false;
                            break;
                        }
                    }
                    else {
                        noships = false;
                        break;

                    }
                }
                if (noships)
                {
                    // if we have this ship previously placed remove it so that it can be places in a new position
                    removeExistingShipfromBoard(shiptype);
                    // place in a column the ship 
                    for (int i = 0; i < shiplength; i++)
                    {
                        board[startrow + i, startcolumn] = shiptype;
                    }
                }
                else
                {
                    rtnsucces = false;
                }
            }

            return rtnsucces;
        }



        public bool takeshot(int row, int column)
        {
            var IsshotHit = false;
            string shipvalue = board[row, column];
            if (!String.IsNullOrEmpty(shipvalue) && shipvalue != "Hit" && shipvalue != "Miss")
            {              
                board[row, column] = "Hit";
                IsshotHit = true;
            }
            else
            {
                board[row, column] = "Miss";
            }

            return IsshotHit;
        }

        public bool checksunkShips()
        {

            bool AllShipsSunked = true;
            int bound0 = board.GetUpperBound(0);
            int bound1 = board.GetUpperBound(1);

            for (int variable1 = 0; variable1 <= bound0; variable1++)
            {
                for (int variable2 = 0; variable2 <= bound1; variable2++)
                {
                    string shipvalue = board[variable1, variable2];
                    if (!(String.IsNullOrEmpty(shipvalue) || shipvalue == "Hit" || shipvalue == "Miss"))
                    {
                        AllShipsSunked = false;
                        break;
                    }
                }
            }

            return AllShipsSunked;
        }

        // used to remove existing ship value from board so that it can be replaced again
        public void removeExistingShipfromBoard(string existingshipvalue)
        {
            int bound0 = board.GetUpperBound(0);
            int bound1 = board.GetUpperBound(1);

            for (int variable1 = 0; variable1 <= bound0; variable1++)
            {
                for (int variable2 = 0; variable2 <= bound1; variable2++)
                {
                    string shipvalue = board[variable1, variable2];
                    if (shipvalue == existingshipvalue)
                    {
                        board[variable1, variable2] = null;
                    }
                }
            }

        }

        public int getShipLength(string shiptype)
        {

            int rtnShiplength = 0;

            switch (shiptype)
            {
                case patrol_boat1:
                case patrol_boat2:
                    rtnShiplength = 2;
                    break;
                case battleship1:
                case battleship2:
                case submarine:
                    rtnShiplength = 3;
                    break;
                case destroyer:
                    rtnShiplength = 4;
                    break;
                case carrier:
                    rtnShiplength = 5;
                    break;


            }
            return rtnShiplength;
        }
    }
}
