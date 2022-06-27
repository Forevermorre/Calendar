namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbMonday = new System.Windows.Forms.Label();
            this.lbTuesday = new System.Windows.Forms.Label();
            this.lbWednesday = new System.Windows.Forms.Label();
            this.lbThursday = new System.Windows.Forms.Label();
            this.lbFriday = new System.Windows.Forms.Label();
            this.lbSaturday = new System.Windows.Forms.Label();
            this.lbSunday = new System.Windows.Forms.Label();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnExit = new Calendar.CustomButton();
            this.btnNext = new Calendar.CustomButton();
            this.btnPrev = new Calendar.CustomButton();
            this.formMoveController1 = new Calendar.FormMoveController(this.components);
            this.formMoveController2 = new Calendar.FormMoveController(this.components);
            this.formMoveController3 = new Calendar.FormMoveController(this.components);
            this.SuspendLayout();
            // 
            // lbMonday
            // 
            this.lbMonday.AutoSize = true;
            this.lbMonday.BackColor = System.Drawing.Color.Transparent;
            this.lbMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMonday.Location = new System.Drawing.Point(139, 65);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.Size = new System.Drawing.Size(102, 18);
            this.lbMonday.TabIndex = 0;
            this.lbMonday.Text = "Понедельник";
            // 
            // lbTuesday
            // 
            this.lbTuesday.AutoSize = true;
            this.lbTuesday.BackColor = System.Drawing.Color.Transparent;
            this.lbTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTuesday.Location = new System.Drawing.Point(301, 65);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.Size = new System.Drawing.Size(66, 18);
            this.lbTuesday.TabIndex = 3;
            this.lbTuesday.Text = "Вторник";
            // 
            // lbWednesday
            // 
            this.lbWednesday.AutoSize = true;
            this.lbWednesday.BackColor = System.Drawing.Color.Transparent;
            this.lbWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWednesday.Location = new System.Drawing.Point(455, 65);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.Size = new System.Drawing.Size(52, 18);
            this.lbWednesday.TabIndex = 4;
            this.lbWednesday.Text = "Среда";
            // 
            // lbThursday
            // 
            this.lbThursday.AutoSize = true;
            this.lbThursday.BackColor = System.Drawing.Color.Transparent;
            this.lbThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbThursday.Location = new System.Drawing.Point(596, 65);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.Size = new System.Drawing.Size(63, 18);
            this.lbThursday.TabIndex = 5;
            this.lbThursday.Text = "Четверг";
            // 
            // lbFriday
            // 
            this.lbFriday.AutoSize = true;
            this.lbFriday.BackColor = System.Drawing.Color.Transparent;
            this.lbFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFriday.Location = new System.Drawing.Point(738, 65);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.Size = new System.Drawing.Size(66, 18);
            this.lbFriday.TabIndex = 6;
            this.lbFriday.Text = "Пятница";
            // 
            // lbSaturday
            // 
            this.lbSaturday.AutoSize = true;
            this.lbSaturday.BackColor = System.Drawing.Color.Transparent;
            this.lbSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSaturday.Location = new System.Drawing.Point(884, 65);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.Size = new System.Drawing.Size(68, 18);
            this.lbSaturday.TabIndex = 7;
            this.lbSaturday.Text = "Суббота";
            // 
            // lbSunday
            // 
            this.lbSunday.AutoSize = true;
            this.lbSunday.BackColor = System.Drawing.Color.Transparent;
            this.lbSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSunday.Location = new System.Drawing.Point(1017, 65);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.Size = new System.Drawing.Size(99, 18);
            this.lbSunday.TabIndex = 8;
            this.lbSunday.Text = "Воскресенье";
            // 
            // dayContainer
            // 
            this.dayContainer.BackColor = System.Drawing.Color.Transparent;
            this.dayContainer.Location = new System.Drawing.Point(114, 88);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1024, 484);
            this.dayContainer.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(12, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(1261, 49);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "МЕСЯЦ ГОД";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.BorderColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnExit.BorderRadius = 13;
            this.btnExit.BorderSize = 0;
            this.btnExit.FillColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.FillColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnExit.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnExit.Location = new System.Drawing.Point(1211, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnClickFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.OnClickFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.OnClickSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnExit.OnClickSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.OnOverFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.OnOverFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.OnOverSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnExit.OnOverSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnExit.Size = new System.Drawing.Size(32, 31);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = Calendar.TextPosition.Center;
            this.btnExit.UseGradient = false;
            this.btnExit.UseGradientBorder = true;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.BorderColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnNext.BorderRadius = 34;
            this.btnNext.BorderSize = 2;
            this.btnNext.FillColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.FillColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNext.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNext.Location = new System.Drawing.Point(1144, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnClickFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.OnClickFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.OnClickSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnNext.OnClickSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.OnOverFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.OnOverFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.OnOverSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(103)))));
            this.btnNext.OnOverSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnNext.Size = new System.Drawing.Size(73, 72);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.TextAlign = Calendar.TextPosition.Center;
            this.btnNext.UseGradient = true;
            this.btnNext.UseGradientBorder = true;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.BorderColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.btnPrev.BorderRadius = 34;
            this.btnPrev.BorderSize = 2;
            this.btnPrev.FillColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.FillColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnPrev.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnPrev.Location = new System.Drawing.Point(35, 310);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.OnClickFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.OnClickFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.OnClickSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.btnPrev.OnClickSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.OnOverFirstBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.OnOverFirstFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.OnOverSecondBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.btnPrev.OnOverSecondFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrev.Size = new System.Drawing.Size(73, 72);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "<";
            this.btnPrev.TextAlign = Calendar.TextPosition.Center;
            this.btnPrev.UseGradient = true;
            this.btnPrev.UseGradientBorder = true;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // formMoveController1
            // 
            this.formMoveController1.SourceControl = this;
            // 
            // formMoveController2
            // 
            this.formMoveController2.SourceControl = this.dayContainer;
            // 
            // formMoveController3
            // 
            this.formMoveController3.SourceControl = this.lbDate;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 646);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSunday);
            this.Controls.Add(this.lbSaturday);
            this.Controls.Add(this.lbFriday);
            this.Controls.Add(this.lbThursday);
            this.Controls.Add(this.lbWednesday);
            this.Controls.Add(this.lbTuesday);
            this.Controls.Add(this.lbMonday);
            this.Controls.Add(this.dayContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Календарь";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMonday;
        private System.Windows.Forms.Label lbTuesday;
        private System.Windows.Forms.Label lbWednesday;
        private System.Windows.Forms.Label lbThursday;
        private System.Windows.Forms.Label lbFriday;
        private System.Windows.Forms.Label lbSaturday;
        private System.Windows.Forms.Label lbSunday;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private System.Windows.Forms.Label lbDate;
        private CustomButton btnPrev;
        private CustomButton btnNext;
        private CustomButton btnExit;
        private FormMoveController formMoveController1;
        private FormMoveController formMoveController2;
        private FormMoveController formMoveController3;
    }
}

