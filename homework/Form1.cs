using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private int clicks = 0;
        private int timeLeft = 10;
        private bool gameRunning = false;

        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            lblTime.Text = $"Время: {timeLeft}";
            lblClicks.Text = $"Нажатий: {clicks}";

            if (!gameRunning && timeLeft == 0)
            {
                if (clicks >= 30)
                {
                    lblStatus.Text = $"Результат: {clicks} кликов, красавчик)";
                }
                else
                {
                    lblStatus.Text = $"Результат: {clicks} кликов, как то вяло((";
                }
            }
            else if (!gameRunning)
            {
                lblStatus.Text = "Нажмите [СТАРТ] чтобы начать!";
            }
            else
            {
                lblStatus.Text = "";
            }
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (gameRunning && timeLeft > 0)
            {
                clicks++;
                UpdateDisplay();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!gameRunning)
            {
                StartGame();
            }
        }
        private void StartGame()
        {
            clicks = 0;
            timeLeft = 10;
            gameRunning = true;
            btnStart.Enabled = false;
            btnReset.Enabled = false;

            UpdateDisplay();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateDisplay();
            }
            else
            {
                EndGame();
            }
        }
        private void EndGame()
        {
            gameRunning = false;
            timer1.Stop();
            btnStart.Enabled = true;
            btnReset.Enabled = true;
            UpdateDisplay();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clicks = 0;
            timeLeft = 10;
            gameRunning = false;
            timer1.Stop();
            btnStart.Enabled = true;
            UpdateDisplay();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}