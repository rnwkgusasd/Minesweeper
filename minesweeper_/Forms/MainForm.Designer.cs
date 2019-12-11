namespace minesweeper_.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            Invoke(new System.Action(() =>
            {
                base.Dispose(disposing);
            }));
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.EXIT_BTN = new System.Windows.Forms.Button();
            this.FormMoveLoc = new System.Windows.Forms.Panel();
            this.MINIMIZE_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EXIT_BTN
            // 
            this.EXIT_BTN.BackColor = System.Drawing.Color.Red;
            this.EXIT_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EXIT_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EXIT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BTN.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BTN.ForeColor = System.Drawing.Color.White;
            this.EXIT_BTN.Location = new System.Drawing.Point(816, 1);
            this.EXIT_BTN.Name = "EXIT_BTN";
            this.EXIT_BTN.Size = new System.Drawing.Size(51, 35);
            this.EXIT_BTN.TabIndex = 0;
            this.EXIT_BTN.Text = "X";
            this.EXIT_BTN.UseVisualStyleBackColor = false;
            this.EXIT_BTN.Click += new System.EventHandler(this.EXIT_BTN_Click);
            // 
            // FormMoveLoc
            // 
            this.FormMoveLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormMoveLoc.Location = new System.Drawing.Point(-1, 1);
            this.FormMoveLoc.Name = "FormMoveLoc";
            this.FormMoveLoc.Size = new System.Drawing.Size(732, 35);
            this.FormMoveLoc.TabIndex = 1;
            this.FormMoveLoc.DoubleClick += new System.EventHandler(this.FormMoveLoc_DoubleClick);
            this.FormMoveLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMoveLoc_MouseDown);
            this.FormMoveLoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMoveLoc_MouseUp);
            // 
            // MINIMIZE_BTN
            // 
            this.MINIMIZE_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MINIMIZE_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MINIMIZE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMIZE_BTN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MINIMIZE_BTN.ForeColor = System.Drawing.Color.Black;
            this.MINIMIZE_BTN.Location = new System.Drawing.Point(782, 1);
            this.MINIMIZE_BTN.Name = "MINIMIZE_BTN";
            this.MINIMIZE_BTN.Size = new System.Drawing.Size(28, 35);
            this.MINIMIZE_BTN.TabIndex = 3;
            this.MINIMIZE_BTN.Text = "_";
            this.MINIMIZE_BTN.UseVisualStyleBackColor = false;
            this.MINIMIZE_BTN.Click += new System.EventHandler(this.MINIMIZE_BTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 549);
            this.Controls.Add(this.MINIMIZE_BTN);
            this.Controls.Add(this.FormMoveLoc);
            this.Controls.Add(this.EXIT_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXIT_BTN;
        private System.Windows.Forms.Panel FormMoveLoc;
        private System.Windows.Forms.Button MINIMIZE_BTN;
    }
}

