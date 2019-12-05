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

        public MainForm()
        {
            InitializeComponent();
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            DialogResult tResult = MessageAlertForm.ShowMessage("EXIT?", MessageBoxButtons.OKCancel);

            if(tResult == DialogResult.OK)
                AllDispose();
        }

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

        //private void FormMoveLoc_DoubleClick(object sender, EventArgs e)
        //{
        //    switch(this.WindowState)
        //    {
        //        case FormWindowState.Normal:
        //            this.WindowState = FormWindowState.Maximized;
        //            break;

        //        case FormWindowState.Maximized:
        //            this.WindowState = FormWindowState.Normal;
        //            break;
        //    }
        //}


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


        //private ManualResetEvent mr = new ManualResetEvent(false);
        private Thread mouseThread;

        private void MainForm_Load(object sender, EventArgs e)
        {
            int[] randPos = new int[10];
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
            mouseThread.Abort();

            this.Dispose();
        }
    }
}
