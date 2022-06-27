namespace Calendar
{
    partial class UserControlWeekend
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbweekend = new System.Windows.Forms.Label();
            this.formMoveController1 = new Calendar.FormMoveController(this.components);
            this.SuspendLayout();
            // 
            // lbweekend
            // 
            this.lbweekend.AutoSize = true;
            this.lbweekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbweekend.Location = new System.Drawing.Point(7, 7);
            this.lbweekend.Name = "lbweekend";
            this.lbweekend.Size = new System.Drawing.Size(49, 33);
            this.lbweekend.TabIndex = 0;
            this.lbweekend.Text = "00";
            // 
            // formMoveController1
            // 
            this.formMoveController1.SourceControl = this;
            // 
            // UserControlWeekend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbweekend);
            this.Name = "UserControlWeekend";
            this.Size = new System.Drawing.Size(140, 70);
            this.Load += new System.EventHandler(this.UserControlWeekend_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlWeekend_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbweekend;
        private FormMoveController formMoveController1;
    }
}
