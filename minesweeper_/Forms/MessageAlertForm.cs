using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_.Forms
{
    public partial class MessageAlertForm : Form
    {
        private static string mMsg;
        private static MessageBoxButtons mMBB;

        public MessageAlertForm()
        {
            InitializeComponent();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void CANCEL_BTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void MessageAlertForm_Load(object sender, EventArgs e)
        {
            ShowText.Text = mMsg;

            if (mMBB == MessageBoxButtons.OK) CANCEL_BTN.Enabled = false;

            switch(mMBB)
            {
                case MessageBoxButtons.OK:
                    CANCEL_BTN.Visible = false;
                    break;

                case MessageBoxButtons.OKCancel:
                    CANCEL_BTN.Visible = true;
                    break;
            }
        }

        public void SetValue(String pMsg, MessageBoxButtons pMessageBoxButtons)
        {
            mMsg = pMsg;
            mMBB = pMessageBoxButtons;
        }

        public static DialogResult ShowMessage(String pMsg, MessageBoxButtons pMessageBoxButtons = MessageBoxButtons.OK)
        {
            using (MessageAlertForm tFrm = new MessageAlertForm())
            {
                tFrm.SetValue(pMsg, pMessageBoxButtons);
                DialogResult tResult = tFrm.ShowDialog();

                return tResult;
            }
        }
    }
}
