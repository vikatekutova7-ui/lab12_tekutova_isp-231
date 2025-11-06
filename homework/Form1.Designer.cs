namespace ClickerGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(50, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 24);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Время: 10";

            this.lblClicks.AutoSize = true;
            this.lblClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblClicks.Location = new System.Drawing.Point(200, 30);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(119, 24);
            this.lblClicks.TabIndex = 1;
            this.lblClicks.Text = "Нажатий: 0";
 
            this.btnClick.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnClick.Location = new System.Drawing.Point(100, 120);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(200, 80);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "ЖМЯКАЙ))";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);

            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(250, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(50, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(254, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Нажмите [СТАРТ] чтобы начать!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.Location = new System.Drawing.Point(70, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 30);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Кликер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
    }
}