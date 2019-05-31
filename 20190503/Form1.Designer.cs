namespace _20190503
{
    partial class Form1
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
            this.tbCals = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCals
            // 
            this.tbCals.Font = new System.Drawing.Font("굴림", 10F);
            this.tbCals.Location = new System.Drawing.Point(19, 21);
            this.tbCals.Multiline = true;
            this.tbCals.Name = "tbCals";
            this.tbCals.ReadOnly = true;
            this.tbCals.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCals.Size = new System.Drawing.Size(269, 19);
            this.tbCals.TabIndex = 0;
            this.tbCals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(19, 83);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 30);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Number_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(74, 83);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 30);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Number_click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(129, 83);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 30);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Number_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(19, 119);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 30);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Number_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(74, 119);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 30);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Number_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(129, 119);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 30);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Number_click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(19, 155);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 30);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Number_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(74, 155);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 30);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Number_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(129, 155);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 30);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Number_click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(19, 191);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(104, 30);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Number_click);
            // 
            // btnEq
            // 
            this.btnEq.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEq.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEq.Location = new System.Drawing.Point(239, 120);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(49, 101);
            this.btnEq.TabIndex = 11;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = false;
            this.btnEq.Click += new System.EventHandler(this.BtnEq_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMul.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMul.Location = new System.Drawing.Point(184, 119);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(49, 30);
            this.btnMul.TabIndex = 12;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(184, 84);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(49, 30);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(184, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSub.Location = new System.Drawing.Point(184, 155);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(49, 30);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.Location = new System.Drawing.Point(239, 84);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(49, 30);
            this.btnCE.TabIndex = 16;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("굴림", 15F);
            this.tbNumber.Location = new System.Drawing.Point(19, 46);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNumber.Size = new System.Drawing.Size(269, 31);
            this.tbNumber.TabIndex = 17;
            this.tbNumber.Text = "0";
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDot.Location = new System.Drawing.Point(129, 191);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(49, 30);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 241);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.tbCals);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCals;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnDot;
    }
}

