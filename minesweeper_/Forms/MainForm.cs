using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_.Forms
{
    public partial class MainForm : Form, IDisposable
    {
        private bool isMouseOver = false;
        private Point CurMousePos;

        public static int BOX_ROWS_COUNT = 6;
        public static int BOX_COLUMNS_COUNT = 6;
        public static int BOX_COUNT = BOX_ROWS_COUNT * BOX_COLUMNS_COUNT;
        public static int MINE_COUNT = 8;
        
        public Button[] Buttons = new Button[BOX_COUNT];
        public int[] ButtonsMineCount = new int[BOX_COUNT];
        private int[] randPos = new int[MINE_COUNT];

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            DialogResult tResult = MessageAlertForm.ShowMessage("EXIT?", MessageBoxButtons.OKCancel);

            if(tResult == DialogResult.OK)
                AllDispose();
        }


        /// <summary>
        /// Minimize Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MINIMIZE_BTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Form Location Change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMoveLoc_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseOver = true;
            
            mouseThread = new Thread(ThreadFunc);
            mouseThread.Start();

            Point MouseLocation = this.PointToScreen(e.Location);
            Point MinusLoc = new Point(this.Location.X - MouseLocation.X, this.Location.Y - MouseLocation.Y);

            while (isMouseOver)
            {
                if (MouseLocation != CurMousePos)
                {
                    MouseLocation = CurMousePos;
                    Point FrmLocation = new Point(MouseLocation.X + MinusLoc.X, MouseLocation.Y + MinusLoc.Y - 2);

                    this.Location = FrmLocation;
                }

                Application.DoEvents();
            }
        }

        private void FormMoveLoc_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseOver = false;
            mouseThread.Abort();
        }

        /// <summary>
        /// Form Maximize event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMoveLoc_DoubleClick(object sender, EventArgs e)
        {
            //switch (this.WindowState)
            //{
            //    case FormWindowState.Normal:
            //        this.WindowState = FormWindowState.Maximized;
            //        break;

            //    case FormWindowState.Maximized:
            //        this.WindowState = FormWindowState.Normal;
            //        break;
            //}
        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out Point lpPoint);

        /// <summary>
        /// Gets the current cursor position in screen coordinates relative to an entire multi-desktop position
        /// </summary>
        /// <returns></returns>
        public Point GetCursorPosition()
        {
            Point lMousePosition;

            // Get mouse position
            GetCursorPos(out lMousePosition);

            // Apply DPI scaling
            return new Point(lMousePosition.X, lMousePosition.Y);
        }


        private ManualResetEvent mr = new ManualResetEvent(false);
        private Thread mouseThread;

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetRandomPoint();

            MakeButtons();

            MineCheck();

            Task.Factory.StartNew(VictoryCheck);
        }

        /// <summary>
        /// Victory Check Function (TASK)
        /// </summary>
        private void VictoryCheck()
        {
            while (true)
            {
                if(!mr.WaitOne(100))
                {
                    if(Buttons.Length > 0 && Buttons != null)
                    {
                        Thread.Sleep(300);

                        List<int> ButtonCheck = new List<int>();
                        List<int> ButtonRightClickCheck = new List<int>();

                        for (int i = 0; i < Buttons.Length; i++)
                        {
                            if (Buttons[i].Text != "!")
                                ButtonRightClickCheck.Add(i);

                            if (Buttons[i].BackColor != Color.MediumAquamarine)
                                ButtonCheck.Add(i);
                        }

                        if (ButtonRightClickCheck.Count == MINE_COUNT)
                        {

                        }

                        if (ButtonCheck.Count != MINE_COUNT)
                            continue;

                        DialogResult dr = MessageAlertForm.ShowMessage("Victory   Retry?", MessageBoxButtons.OKCancel);

                        if (dr == DialogResult.OK) Restart();
                        else if (dr == DialogResult.Cancel) AllDispose();

                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Mine Check
        /// </summary>
        private void MineCheck()
        {
            ButtonsMineCount = new int[BOX_COUNT];

            // Make not mines button
            for (int i = 0; i < randPos.Length; i++)
            {
                // Top Row
                int temp = randPos[i] - 6 - 1;
                if (temp >= 0 && temp < BOX_COUNT && randPos[i] % 6 != 0)
                    ButtonsMineCount[temp]++;

                temp = randPos[i] - 6;
                if (temp >= 0 && temp < BOX_COUNT)
                    ButtonsMineCount[temp]++;

                temp = randPos[i] - 6 + 1;
                if (temp >= 0 && temp < BOX_COUNT && (randPos[i] + 1) % 6 != 0)
                    ButtonsMineCount[temp]++;

                // Middle Row
                temp = randPos[i] - 1;
                if (temp >= 0 && temp < BOX_COUNT && randPos[i] % 6 != 0)
                    ButtonsMineCount[temp]++;

                temp = randPos[i] + 1;
                if (temp >= 0 && temp < BOX_COUNT && (randPos[i] + 1) % 6 != 0)
                    ButtonsMineCount[temp]++;

                // Bottom Row
                temp = randPos[i] + 6 - 1;
                if (temp >= 0 && temp < BOX_COUNT && randPos[i] % 6 != 0)
                    ButtonsMineCount[temp]++;

                temp = randPos[i] + 6;
                if (temp >= 0 && temp < BOX_COUNT)
                    ButtonsMineCount[temp]++;

                temp = randPos[i] + 6 + 1;
                if (temp >= 0 && temp < BOX_COUNT && (randPos[i] + 1) % 6 != 0)
                    ButtonsMineCount[temp]++;
            }
        }

        /// <summary>
        /// Set Random Button Position
        /// </summary>
        private void SetRandomPoint()
        {
            // Make mines random position
            Random rand = new Random();
            randPos = new int[MINE_COUNT];

            while (true)
            {
                for (int i = 0; i < randPos.Length; i++)
                {
                    randPos[i] = rand.Next(0, 36);

                    //MessageBox.Show(randPos[i].ToString());
                }

                if (randPos.Distinct().ToArray().Length == MINE_COUNT)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Make Buttons in Form
        /// </summary>
        private void MakeButtons()
        {
            Buttons = new Button[BOX_COUNT];

            // Make buttons
            int x = 250;
            int y = 150;

            for (int i = 0; i < BOX_COUNT; i++)
            {
                if (i != 0)
                {
                    if (i % 6 == 0)
                    {
                        x = 250;
                        y += 50;
                    }
                }


                Buttons[i] = new Button();
                Buttons[i].Size = new Size(50, 50);
                Buttons[i].Location = new Point(x, y);
                Buttons[i].FlatStyle = FlatStyle.Flat;
                Buttons[i].MouseDown += BtnClick_Event;

                Invoke(new Action(() =>
                {
                    Controls.Add(Buttons[i]);
                }));
                
                x += 50;
            }
        }

        private void BtnClick_Event(object sender, MouseEventArgs e)
        {
            Button tBtn = (Button)sender;

            if(e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < randPos.Length; i++)
                {
                    if (tBtn == Buttons[randPos[i]])
                    {
                        if(Buttons[randPos[i]].Text != "!")
                        {
                            Buttons[randPos[i]].Text = "※";

                            Thread.Sleep(500);

                            DialogResult tDR = MessageAlertForm.ShowMessage("GAME OVER   Retry?", MessageBoxButtons.OKCancel);

                            if(tDR == DialogResult.OK)
                            {
                                Restart();
                            }
                        }

                        return;
                    }
                }

                for (int i = 0; i < Buttons.Length; i++)
                {
                    if (tBtn == Buttons[i])
                    {
                        if(Buttons[i].Text != "!")
                        {
                            if(ButtonsMineCount[i] != 0)
                                Buttons[i].Text = ButtonsMineCount[i].ToString();
                            else
                            {
                                SpaceCheck(MakeSpaceArr(i), i);
                            }

                            Buttons[i].BackColor = Color.MediumAquamarine;
                        }
                        
                        return;
                    }
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < Buttons.Length; i++)
                {
                    if (tBtn == Buttons[i])
                    {
                        if (Buttons[i].Text == "" && Buttons[i].BackColor != Color.MediumAquamarine)
                            Buttons[i].Text = "!";
                        else if (Buttons[i].Text == "!") Buttons[i].Text = "";
                        return;
                    }
                }
            }
        }

        private void Restart()
        {
            RemoveButtons();

            SetRandomPoint();

            MakeButtons();

            MineCheck();

            Task.Factory.StartNew(VictoryCheck);
        }

        private void RemoveButtons()
        {
            for(int i = 0; i < BOX_COUNT; i++)
            {
                Buttons[i].Invoke(new Action(() =>
                {
                    Buttons[i].Dispose();
                }));
            }
        }

        private void SpaceCheck(int[] tArr, int pThisNum)
        {
            for(int i = 0; i < tArr.Length; i++)
            {
                if (Buttons[tArr[i]].BackColor == Color.MediumAquamarine) continue;
                if (ButtonsMineCount[pThisNum] != 0 && Buttons[pThisNum].BackColor == Color.MediumAquamarine) continue;
                if (ButtonsMineCount[tArr[i]] != 0 && Buttons[tArr[i]].BackColor == Color.MediumAquamarine) continue;

                if (!randPos.Contains(tArr[i]))
                {
                    Buttons[tArr[i]].BackColor = Color.MediumAquamarine;

                    if (ButtonsMineCount[tArr[i]] != 0)
                        Buttons[tArr[i]].Text = ButtonsMineCount[tArr[i]].ToString();

                    SpaceCheck(MakeSpaceArr(tArr[i]), tArr[i]);
                }
            }
        }

        private int[] MakeSpaceArr(int num)
        {
            List<int> tmpList = new List<int>();

            // Top Row
            int temp = num - BOX_ROWS_COUNT - 1;
            if (temp >= 0 && temp < BOX_COUNT && num % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            temp = num - BOX_ROWS_COUNT;
            if (temp >= 0 && temp < BOX_COUNT)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            temp = num - BOX_ROWS_COUNT + 1;
            if (temp >= 0 && temp < BOX_COUNT && (num + 1) % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            // Middle Row
            temp = num - 1;
            if (temp >= 0 && temp < BOX_COUNT && num % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            temp = num + 1;
            if (temp >= 0 && temp < BOX_COUNT && (num + 1) % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            // Bottom Row
            temp = num + BOX_ROWS_COUNT - 1;
            if (temp >= 0 && temp < BOX_COUNT && num % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            temp = num + BOX_ROWS_COUNT;
            if (temp >= 0 && temp < BOX_COUNT)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            temp = num + BOX_ROWS_COUNT + 1;
            if (temp >= 0 && temp < BOX_COUNT && (num + 1) % 6 != 0)
                if (ButtonsMineCount[temp] >= 0) tmpList.Add(temp);

            return tmpList.ToArray();
        }

        private void ThreadFunc()
        {
            while(true)
            {
                if(/* !mr.WaitOne(10) */ true)
                {
                    Point p = GetCursorPosition();

                    CurMousePos = p;

                    Application.DoEvents();
                }
            }
        }

        private void AllDispose() 
        {
            if(mouseThread != null && mouseThread.IsAlive)
                mouseThread.Abort();

            this.Dispose();
        }
    }
}
