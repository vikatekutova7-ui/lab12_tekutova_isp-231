namespace TrafficLightHard
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(301, 23);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(200, 100);
            this.panelRed.TabIndex = 0;
            this.panelRed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRed_Paint);
            // 
            // panelYellow
            // 
            this.panelYellow.Location = new System.Drawing.Point(301, 172);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(200, 100);
            this.panelYellow.TabIndex = 0;
            this.panelYellow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelYellow_Paint);
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(301, 323);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(200, 100);
            this.panelGreen.TabIndex = 0;
            this.panelGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGreen_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Red;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStart.Location = new System.Drawing.Point(54, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 67);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
    }
}

