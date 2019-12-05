namespace minesweeper_.Forms
{
    partial class MessageAlertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CANCEL_BTN = new System.Windows.Forms.Button();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CANCEL_BTN
            // 
            this.CANCEL_BTN.BackColor = System.Drawing.Color.White;
            this.CANCEL_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.CANCEL_BTN.FlatAppearance.BorderSize = 2;
            this.CANCEL_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CANCEL_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CANCEL_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CANCEL_BTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_BTN.Location = new System.Drawing.Point(240, 101);
            this.CANCEL_BTN.Name = "CANCEL_BTN";
            this.CANCEL_BTN.Size = new System.Drawing.Size(103, 42);
            this.CANCEL_BTN.TabIndex = 0;
            this.CANCEL_BTN.Text = "CANCEL";
            this.CANCEL_BTN.UseVisualStyleBackColor = false;
            this.CANCEL_BTN.Click += new System.EventHandler(this.CANCEL_BTN_Click);
            // 
            // OK_BTN
            // 
            this.OK_BTN.BackColor = System.Drawing.Color.White;
            this.OK_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.OK_BTN.FlatAppearance.BorderSize = 2;
            this.OK_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OK_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OK_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_BTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(383, 101);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(103, 42);
            this.OK_BTN.TabIndex = 1;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = false;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // ShowText
            // 
            this.ShowText.AutoSize = true;
            this.ShowText.Font = new System.Drawing.Font("굴림", 25F);
            this.ShowText.Location = new System.Drawing.Point(29, 46);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(110, 34);
            this.ShowText.TabIndex = 2;
            this.ShowText.Text = "label1";
            // 
            // MessageAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(510, 161);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.CANCEL_BTN);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageAlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MessageAlertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CANCEL_BTN;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Label ShowText;
    }
}