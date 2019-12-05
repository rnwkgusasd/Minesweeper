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
            base.Dispose(disposing);
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
            this.Board_Panel = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.Board_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EXIT_BTN
            // 
            this.EXIT_BTN.BackColor = System.Drawing.Color.Red;
            this.EXIT_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.FormMoveLoc.Size = new System.Drawing.Size(811, 35);
            this.FormMoveLoc.TabIndex = 1;
            this.FormMoveLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMoveLoc_MouseDown);
            this.FormMoveLoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMoveLoc_MouseUp);
            // 
            // Board_Panel
            // 
            this.Board_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Board_Panel.Controls.Add(this.button31);
            this.Board_Panel.Controls.Add(this.button25);
            this.Board_Panel.Controls.Add(this.button32);
            this.Board_Panel.Controls.Add(this.button26);
            this.Board_Panel.Controls.Add(this.button27);
            this.Board_Panel.Controls.Add(this.button33);
            this.Board_Panel.Controls.Add(this.button28);
            this.Board_Panel.Controls.Add(this.button29);
            this.Board_Panel.Controls.Add(this.button34);
            this.Board_Panel.Controls.Add(this.button30);
            this.Board_Panel.Controls.Add(this.button36);
            this.Board_Panel.Controls.Add(this.button13);
            this.Board_Panel.Controls.Add(this.button35);
            this.Board_Panel.Controls.Add(this.button14);
            this.Board_Panel.Controls.Add(this.button15);
            this.Board_Panel.Controls.Add(this.button16);
            this.Board_Panel.Controls.Add(this.button17);
            this.Board_Panel.Controls.Add(this.button18);
            this.Board_Panel.Controls.Add(this.button19);
            this.Board_Panel.Controls.Add(this.button20);
            this.Board_Panel.Controls.Add(this.button21);
            this.Board_Panel.Controls.Add(this.button22);
            this.Board_Panel.Controls.Add(this.button23);
            this.Board_Panel.Controls.Add(this.button24);
            this.Board_Panel.Controls.Add(this.button12);
            this.Board_Panel.Controls.Add(this.button11);
            this.Board_Panel.Controls.Add(this.button10);
            this.Board_Panel.Controls.Add(this.button9);
            this.Board_Panel.Controls.Add(this.button8);
            this.Board_Panel.Controls.Add(this.button7);
            this.Board_Panel.Controls.Add(this.button6);
            this.Board_Panel.Controls.Add(this.button5);
            this.Board_Panel.Controls.Add(this.button4);
            this.Board_Panel.Controls.Add(this.button3);
            this.Board_Panel.Controls.Add(this.button2);
            this.Board_Panel.Controls.Add(this.button1);
            this.Board_Panel.Location = new System.Drawing.Point(122, 62);
            this.Board_Panel.Name = "Board_Panel";
            this.Board_Panel.Size = new System.Drawing.Size(600, 475);
            this.Board_Panel.TabIndex = 2;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(456, 316);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(74, 70);
            this.button25.TabIndex = 29;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(376, 316);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(74, 70);
            this.button26.TabIndex = 28;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(296, 316);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(74, 70);
            this.button27.TabIndex = 27;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(216, 316);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(74, 70);
            this.button28.TabIndex = 26;
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(136, 316);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(74, 70);
            this.button29.TabIndex = 25;
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(56, 316);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(74, 70);
            this.button30.TabIndex = 24;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(456, 240);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(74, 70);
            this.button13.TabIndex = 23;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(456, 164);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(74, 70);
            this.button14.TabIndex = 22;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(376, 240);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(74, 70);
            this.button15.TabIndex = 21;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(296, 240);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(74, 70);
            this.button16.TabIndex = 20;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(216, 240);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(74, 70);
            this.button17.TabIndex = 19;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(136, 240);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(74, 70);
            this.button18.TabIndex = 18;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(56, 240);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(74, 70);
            this.button19.TabIndex = 17;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(376, 164);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(74, 70);
            this.button20.TabIndex = 16;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(296, 164);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(74, 70);
            this.button21.TabIndex = 15;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(216, 164);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(74, 70);
            this.button22.TabIndex = 14;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(136, 164);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(74, 70);
            this.button23.TabIndex = 13;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(56, 164);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(74, 70);
            this.button24.TabIndex = 12;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(456, 88);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 70);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(456, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 70);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(376, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 70);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(296, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 70);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(216, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 70);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(136, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 70);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(56, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 70);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(376, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 70);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(296, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 70);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(216, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 70);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(136, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 70);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(56, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 70);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(456, 392);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(74, 70);
            this.button31.TabIndex = 35;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.White;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(376, 392);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(74, 70);
            this.button32.TabIndex = 34;
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.White;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(296, 392);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(74, 70);
            this.button33.TabIndex = 33;
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.White;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(216, 392);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(74, 70);
            this.button34.TabIndex = 32;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.White;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(136, 392);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(74, 70);
            this.button35.TabIndex = 31;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.White;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(56, 392);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(74, 70);
            this.button36.TabIndex = 30;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 549);
            this.Controls.Add(this.Board_Panel);
            this.Controls.Add(this.FormMoveLoc);
            this.Controls.Add(this.EXIT_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Board_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXIT_BTN;
        private System.Windows.Forms.Panel FormMoveLoc;
        private System.Windows.Forms.Panel Board_Panel;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
    }
}

