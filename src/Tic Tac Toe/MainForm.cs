using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        #region Graphics Code
        public MainForm()
        {
            InitializeComponent();
        }

        public Button[,] BtnTTT;

        private void picBtnClose_MouseEnter(object sender, EventArgs e)
        {
            this.picBtnClose.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Over;
        }

        private void picBtnClose_MouseLeave(object sender, EventArgs e)
        {
            this.picBtnClose.Image = global::Tic_Tac_Toe.Properties.Resources.Normal;
        }

        private void picBtnClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.picBtnClose.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Down;
        }

        private void picBtnMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            this.picBtnMinimize.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Down1;
        }

        private void picBtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            this.picBtnMinimize.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Over1;
        }

        private void picBtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.picBtnMinimize.Image = global::Tic_Tac_Toe.Properties.Resources.Normal1;
        }

        public Boolean PlayGame = false;
        private void picBtnPlayGame_MouseLeave(object sender, EventArgs e)
        {
            if (!PlayGame)
                this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Normal2;
        }

        private void picBtnPlayGame_MouseEnter(object sender, EventArgs e)
        {
            if (!PlayGame)
                this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Over2;
        }

        private void picBtnPlayGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (!PlayGame)
                this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Down2;
        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int Xbefore, Ybefore;
        private void picBtnMove_MouseDown(object sender, MouseEventArgs e)
        {
            keepDown = true;
            Xbefore = e.X;
            Ybefore = e.Y;
        }
        public bool keepDown = false;
        private void picBtnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (keepDown)
            {
                this.Location = new Point((this.Location.X + (e.X - Xbefore)), (this.Location.Y + (e.Y - Ybefore)));
            }
        }

        private void picBtnMove_MouseUp(object sender, MouseEventArgs e)
        {
            keepDown = false;
        }

        private void picBtnAbout_MouseEnter(object sender, EventArgs e)
        {
            this.picBtnAbout.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Over3;
        }

        private void picBtnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.picBtnAbout.Image = global::Tic_Tac_Toe.Properties.Resources.Normal3;
        }

        private void picBtnAbout_MouseDown(object sender, MouseEventArgs e)
        {
            this.picBtnAbout.Image = global::Tic_Tac_Toe.Properties.Resources.Mouse_Down3;
        }

        private void picBtnAbout_Click(object sender, EventArgs e)
        {
            picAbout.Visible = true;
            picEmail.Visible = true;
            picEmail.BringToFront();
            label1.Visible = true;
            label1.BringToFront();
            label2.Visible = true;
            label2.BringToFront();
            linkLabel1.Visible = true;
            linkLabel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            // picBtnTicTacToe
            // 
            creatNewForm();
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            picAbout.Visible = false;
            picEmail.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            linkLabel1.Visible = false;
        }

        #endregion

        public void FindLoc()
        {
            Loc.X = 0;
            Loc.Y = 0;
            int x = (this.ActiveControl.Location.X - 67);
            int y = (this.ActiveControl.Location.Y - 66);
            while (x != 0)
            {
                x -= 72;
                Loc.Y++;
            }
            while (y != 0)
            {
                y -= 80;
                Loc.X++;
            }
        }
        public static Point Loc;
        private static int beadCounter = 9;
        public bool[,] TTTX = new bool[3, 3];
        public bool[,] TTTO = new bool[3, 3]; 
        private void BtnTTT_Click(object sender, EventArgs e)
        {
            FindLoc();
            this.BtnTTT[Loc.X, Loc.Y].BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.X;
            TTTX[Loc.X, Loc.Y] = true;
            BtnTTT[Loc.X, Loc.Y].Enabled = false;
            beadCounter--;
            if (winUserTrust_check())
            {
                MessageBox.Show("You Win !");
                Restart();
            }
            else if (beadCounter == 0)
            {
                MessageBox.Show("You & Computer are Tie!");
                Restart();
            }
            else
                StartPC();
        }

        private void Restart()
        {
            beadCounter = 9;
            PcFirstRun = true;
            picBtnPlayGame.Enabled = true;
            chkFirstPc.Enabled = true;
            this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Normal2;

            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    TTTO[x, y] = false;
                    TTTX[x, y] = false;
                    this.Controls.Remove(BtnTTT[x, y]);
                }
            creatNewForm();
        }

        private void creatNewForm()
        {
            BtnTTT = new Button[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    this.BtnTTT[i, j] = new Button();
                    this.BtnTTT[i, j].Enabled = false;
                    this.BtnTTT[i, j].Cursor = System.Windows.Forms.Cursors.Hand;
                    this.BtnTTT[i, j].BackColor = System.Drawing.Color.Transparent;
                    this.BtnTTT[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    this.BtnTTT[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    this.BtnTTT[i, j].ForeColor = System.Drawing.Color.Transparent;
                    this.BtnTTT[i, j].Location = new System.Drawing.Point(67 + (j * 72), 66 + (i * 80));
                    this.BtnTTT[i, j].Size = new System.Drawing.Size(53, 50);
                    this.BtnTTT[i, j].TabIndex = (i * 3) + j + 1;
                    this.BtnTTT[i, j].UseVisualStyleBackColor = false;
                    this.BtnTTT[i, j].Click += new System.EventHandler(this.BtnTTT_Click);
                    this.Controls.Add(this.BtnTTT[i, j]);
                }   
        }

        private bool winUserTrust_check()
        {
            Point p1, p2, p3;
            char ch1, ch2, ch3;
            for (int i = 1; i < 9; i++)
            {
                mood_check(i, out ch1, out p1, out ch2, out p2, out ch3, out p3);
                if (ch1 == 'X' && ch2 == 'X' && ch3 == 'X')
                    return true;
            }
            return false;
        }

        private void picBtnPlayGame_Click(object sender, EventArgs e)
        {
            this.picBtnPlayGame.Image = global::Tic_Tac_Toe.Properties.Resources.Disable2;
            this.picBtnPlayGame.Enabled = false;
            chkFirstPc.Enabled = false;
            PlayGame = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    BtnTTT[i, j].Enabled = true;
            if (chkFirstPc.Checked)
            {
                // first Tic is Left of Up: (0, 0)
                //                                  *|_|_  
                //                                  _|_|_
                //                                   | |
                //
                BtnTTT[0, 0].BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.shapes_circle_frame;
                BtnTTT[0, 0].Enabled = false;
                TTTO[0, 0] = true;
                PcFirstRun = false;
                beadCounter--;
            }
        }

        bool PcFirstRun = true;
        public bool[] deletedMood = new bool[9]; // for clear some mood
        private void StartPC()
        {
            //
            // Process for Answer --------------------------------------------------------
            if (!TTTX[1, 1] && !TTTO[1, 1] && PcFirstRun) // first center
            {
                Loc = new Point(1, 1);
                PcFirstRun = false;
            }
            else if (!winPC_check(out Loc))
            {
                if (!winUSER_check(out Loc))
                {
                    // clear deletedMood by True -----
                    // for (int i = 0; i < 9; i++)
                    //      deletedMood[i] = false;
                    //--------------------------------
                    // ELLIPSIS the mood who has 'X' & 'O' for example: 
                    // Mood 3 is Ellipsis Mood ===>  deletedMood[3] = false;
                    //            _|_|_
                    //            _|_|_
                    //             |O|X
                    //
                    twoBeadMood_check();
                    //
                    // find share point between O mood & X mood
                    // Example: (S is share Point)
                    //
                    //  X|_|S     X|_|S       _|_|_      _|X|O
                    //  _|_|O     _|_|_       _|X|_      _|S|_
                    //   | |      S| |O       S|O|S       | |
                    //
                    Loc = findSharePoint();
                }
            }
            // ---------------------------------------------------------------------------
            //
            if (Loc.X == 3) // not found trust point or Game is tie between PC & User
                Loc = EOP();
            BtnTTT[Loc.X, Loc.Y].BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.shapes_circle_frame;
            BtnTTT[Loc.X, Loc.Y].Enabled = false;
            TTTO[Loc.X, Loc.Y] = true;
            beadCounter--;
            if (!PlayGame)
            {
                GameOver();
                Restart();
            }
            else if (beadCounter == 0)
            {
                MessageBox.Show("You & Computer are Tie!");
                Restart();
            }
        }

        // return end point location
        private Point EOP()
        {
            for (Loc.X = 0; Loc.X < 3; Loc.X++)
                for (Loc.Y = 0; Loc.Y < 3; Loc.Y++)
                    if (!TTTO[Loc.X, Loc.Y] && !TTTX[Loc.X, Loc.Y])
                        return Loc;
            return Loc;
        }

        private Point findSharePoint()
        {
            // find share point between O mood & X mood
            // Example: (S is share Point)
            //
            //  X|_|S     X|_|S       _|_|_      _|X|O
            //  _|_|O     _|_|_       _|X|_      _|S|_
            //   | |      S| |O       S|O|S       | |
            //
            ArrayList o_Point_arrayList = new ArrayList(); // for save space point of O mood
            char ch1, ch2, ch3;
            Point p1, p2, p3;
            // ------ Save All Correct Point ---------------------------------------------
            for (int i = 1; i < 9; i++)
                if (!deletedMood[i]) // if ('i' mood none deleted and is currect)
                {
                    mood_check(i, out ch1, out p1, out ch2, out p2, out ch3, out p3);
                    // 
                    // read any O mood space place
                    try
                    {
                        if (ch1 == 'O')
                        {
                            o_Point_arrayList.Add(p2);
                            o_Point_arrayList.Add(p3);
                        }
                        else if (ch2 == 'O')
                        {
                            o_Point_arrayList.Add(p1);
                            o_Point_arrayList.Add(p3);
                        }
                        else if (ch3 == 'O')
                        {
                            o_Point_arrayList.Add(p2);
                            o_Point_arrayList.Add(p1);
                        }
                        else continue;
                    }
                    catch { continue; }
                }
            // ---------------------------------------------------------------------------
            //
            // +++++++++++ Match X mood Space point by Saved Point +++++++++++++++++++++++
            for (int i = 1; i < 9; i++)
                if (!deletedMood[i]) // if ('i' mood none deleted and is currect)
                {
                    mood_check(i, out ch1, out p1, out ch2, out p2, out ch3, out p3);
                    // 
                    // read X mood space place by match
                    if (ch1 == 'X')
                    {
                        if (o_Point_arrayList.Contains(p2))
                            return p2;
                        if (o_Point_arrayList.Contains(p3))
                            return p3;
                    }
                    else if (ch2 == 'X')
                    {
                        if (o_Point_arrayList.Contains(p1))
                            return p1;
                        if (o_Point_arrayList.Contains(p3))
                            return p3;
                    }
                    else if (ch3 == 'X')
                    {
                        if (o_Point_arrayList.Contains(p2))
                            return p2;
                        if (o_Point_arrayList.Contains(p1))
                            return p1;
                    }
                    else continue;
                }
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            return new Point(3, 3);
        }

        // check for mood of have two bead mood O & X
        private void twoBeadMood_check()
        {
            // Example: Mood 3 is noMood 
            //            _|_|_
            //            _|_|_
            //             |O|X
            //
            // All Phase is:
            // 1.              O|X|_
            // 2.              X|O|_
            // 3.              O|_|X
            // 4.              X|_|O
            // 5.              _|O|X
            // 6.              _|X|O
            //
            char one, two, three;
            Point onePoint, twoPoint, threePoint;

            for (int i = 1; i < 9; i++)
            {
                mood_check(i, out one, out onePoint, out two, out twoPoint, out three, out threePoint);
                //
                // check phase of mood
                //
                // Example: 
                // ------------------------------------------------
                //         Phase1:    O|X|_
                //
                if (one == 'O' && two == 'X')
                {
                    deletedMood[i] = true;
                    continue;
                }
                // ------------------------------------------------
                //         Phase2:    X|O|_
                //
                if (one == 'X' && two == 'O') 
                {
                    deletedMood[i] = true;
                    continue;
                }
                // ------------------------------------------------
                //         Phase3:    O|_|X
                //
                if (one == 'O' && three == 'X') 
                {
                    deletedMood[i] = true;
                    continue;
                }
                // ------------------------------------------------
                //         Phase4:    X|_|O
                //
                if (one == 'X' && three == 'O') 
                {
                    deletedMood[i] = true;
                    continue;
                }
                // ------------------------------------------------
                //         Phase5:    _|O|X
                //
                if (two == 'O' && three == 'X') 
                {
                    deletedMood[i] = true;
                    continue;
                }
                // ------------------------------------------------
                //         Phase6:    _|X|O
                //
                if (two == 'X' && three == 'O') 
                {
                    deletedMood[i] = true;
                    continue;
                }
            }
            //
        }

        // check for mood of user win
        private bool winUSER_check(out Point Checked)
        {
            // Example: 'M' is a Final or User Win Mood
            //
            //            X|O|_  
            //            O|X|_
            //             | |M
            //
            char one, two, three;
            Point onePoint, twoPoint, threePoint;

            for (int i = 1; i < 9; i++)
            {
                mood_check(i, out one, out onePoint, out two, out twoPoint, out three, out threePoint);
                //
                // check phase of mood
                //
                // Example: 
                //         Phase1:
                //                  _|_|_
                //                  _|_|_
                //                  X|X|
                //
                if (one == 'X' && two == 'X' && three == ' ')
                {
                    Checked = threePoint;
                    return true;
                }
                // ------------------------------------------------
                //         Phase2:
                //                  _|_|_
                //                  _|_|_
                //                  X| |X
                //
                if (one == 'X' && two == ' ' && three == 'X')
                {
                    Checked = twoPoint;
                    return true;
                }
                // ------------------------------------------------
                //         Phase3:
                //                  _|_|_
                //                  _|_|_
                //                   |X|X
                //
                if (one == ' ' && two == 'X' && three == 'X')
                {
                    Checked = onePoint;
                    return true;
                }
            }
            Checked = new Point(3, 3);
            return false;
        }

        // if pc is win
        private void GameOver()
        {
            MessageBox.Show("Game Over !" + "\nComputer is Win");
        }

        // check for mood of pc win
        private bool winPC_check(out Point Checked)
        {
            // Example: 'M' is a Final or Pc Win Mood
            //
            //            O|X|_  
            //            _|O|_
            //             |X|M
            //
            char one, two, three;
            Point onePoint, twoPoint, threePoint;

            for (int i = 1; i < 9; i++)
            {
                mood_check(i, out one, out onePoint, out two, out twoPoint, out three, out threePoint);
                //
                // check phase of mood
                //
                // Example: 
                //         Phase1:
                //                  _|_|_
                //                  _|_|_
                //                  O|O|
                //
                if (one == 'O' && two == 'O' && three == ' ')
                {
                    Checked = threePoint;
                    PlayGame = false;
                    return true;
                }
                // ------------------------------------------------
                //         Phase2:
                //                  _|_|_
                //                  _|_|_
                //                  O| |O
                //
                if (one == 'O' && two == ' ' && three == 'O')
                {
                    Checked = twoPoint;
                    PlayGame = false;
                    return true;
                }
                // ------------------------------------------------
                //         Phase3:
                //                  _|_|_
                //                  _|_|_
                //                   |O|O
                //
                if (one == ' ' && two == 'O' && three == 'O')
                {
                    Checked = onePoint;
                    PlayGame = false;
                    return true;
                }
            }
            Checked = new Point(3, 3);
            return false;
        }

        // every Mood is 3 bead of 'X' or 'O'
        private void mood_check(int numMood, out char one_Bead, out Point P1,
                                             out char two_Bead, out Point P2, 
                                             out char three_Bead, out Point P3)
        {
            one_Bead = two_Bead = three_Bead = ' ';
            P1 = P2 = P3 = new Point(0, 0);

            switch (numMood)
            {
                case 1:
                    {
                        // Mood 1:
                        //         O|O|O
                        //         _|_|_
                        //          | |
                        //
                        if (TTTO[0, 0]) one_Bead = 'O';
                        else if (TTTX[0, 0]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 0);

                        if (TTTO[0, 1]) two_Bead = 'O';
                        else if (TTTX[0, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(0, 1);

                        if (TTTO[0, 2]) three_Bead = 'O';
                        else if (TTTX[0, 2]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(0, 2);
                    }
                    break;
                case 2:
                    {
                        // Mood 2:
                        //         _|_|_
                        //         O|O|O
                        //          | |
                        //
                        if (TTTO[1, 0]) one_Bead = 'O';
                        else if (TTTX[1, 0]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(1, 0);

                        if (TTTO[1, 1]) two_Bead = 'O';
                        else if (TTTX[1, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 1);

                        if (TTTO[1, 2]) three_Bead = 'O';
                        else if (TTTX[1, 2]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(1, 2);
                    }
                    break;
                case 3:
                    {
                        // Mood 3:
                        //         _|_|_
                        //         _|_|_
                        //         O|O|O
                        //
                        if (TTTO[2, 0]) one_Bead = 'O';
                        else if (TTTX[2, 0]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(2, 0);

                        if (TTTO[2, 1]) two_Bead = 'O';
                        else if (TTTX[2, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(2, 1);

                        if (TTTO[2, 2]) three_Bead = 'O';
                        else if (TTTX[2, 2]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 2);
                    }
                    break;
                case 4:
                    {
                        // Mood 4:
                        //         O|_|_
                        //         O|_|_
                        //         O| |
                        //
                        if (TTTO[0, 0]) one_Bead = 'O';
                        else if (TTTX[0, 0]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 0);

                        if (TTTO[1, 0]) two_Bead = 'O';
                        else if (TTTX[1, 0]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 0);

                        if (TTTO[2, 0]) three_Bead = 'O';
                        else if (TTTX[2, 0]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 0);
                    }
                    break;
                case 5:
                    {
                        // Mood 5:
                        //         _|O|_
                        //         _|O|_
                        //          |O|
                        //
                        if (TTTO[0, 1]) one_Bead = 'O';
                        else if (TTTX[0, 1]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 1);

                        if (TTTO[1, 1]) two_Bead = 'O';
                        else if (TTTX[1, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 1);

                        if (TTTO[2, 1]) three_Bead = 'O';
                        else if (TTTX[2, 1]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 1);
                    }
                    break;
                case 6:
                    {
                        // Mood 6:
                        //         _|_|O
                        //         _|_|O
                        //          | |O
                        //
                        if (TTTO[0, 2]) one_Bead = 'O';
                        else if (TTTX[0, 2]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 2);

                        if (TTTO[1, 2]) two_Bead = 'O';
                        else if (TTTX[1, 2]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 2);

                        if (TTTO[2, 2]) three_Bead = 'O';
                        else if (TTTX[2, 2]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 2);
                    }
                    break;
                case 7:
                    {
                        // Mood 7:
                        //         O|_|_
                        //         _|O|_
                        //          | |O
                        //
                        if (TTTO[0, 0]) one_Bead = 'O';
                        else if (TTTX[0, 0]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 0);

                        if (TTTO[1, 1]) two_Bead = 'O';
                        else if (TTTX[1, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 1);

                        if (TTTO[2, 2]) three_Bead = 'O';
                        else if (TTTX[2, 2]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 2);
                    }
                    break;
                case 8:
                    {
                        // Mood 8:
                        //         _|_|O
                        //         _|O|_
                        //         O| |
                        //
                        if (TTTO[0, 2]) one_Bead = 'O';
                        else if (TTTX[0, 2]) one_Bead = 'X';
                        else one_Bead = ' ';
                        P1 = new Point(0, 2);

                        if (TTTO[1, 1]) two_Bead = 'O';
                        else if (TTTX[1, 1]) two_Bead = 'X';
                        else two_Bead = ' ';
                        P2 = new Point(1, 1);

                        if (TTTO[2, 0]) three_Bead = 'O';
                        else if (TTTX[2, 0]) three_Bead = 'X';
                        else three_Bead = ' ';
                        P3 = new Point(2, 0);
                    }
                    break;
                default:
                    {
                        one_Bead = ' ';
                        two_Bead = ' ';
                        three_Bead = ' ';
                    }
                    break;
            }
        }

        private void picEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto: Behzad.kh.2006@Gamil.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.Azerbaycan.ir");
            System.Diagnostics.Process.Start("www.Unixe.co.cc"); 
        }

    }
}
