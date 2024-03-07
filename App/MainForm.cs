using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using ThingMagic;
using System.Media;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EstablishReader();
            Form.CheckForIllegalCrossThreadCalls = false;
            //跨執行緒操作, 不安全的行為
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            reader.Destroy();
            this.Close();
        }

        private Setting_Form setting_Form = null;

        private void Setting_Click(object sender, EventArgs e)
        {
            if (setting_Form == null)
            {
                setting_Form = new Setting_Form();
                setting_Form.TopMost = true;
                setting_Form.Show(this);
            }
            else if (setting_Form?.IsDisposed == true)
            {
                setting_Form = new Setting_Form();
                setting_Form.TopMost = true;
                setting_Form.Show(this);
            }
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            stopReading();

            Choose.Height = HomePage.Height;
            Choose.Top = HomePage.Top;
            HomePage.BackColor = Color.FromArgb(255, 154, 138, 102);
            Learning.BackColor = Color.FromArgb(255, 169, 151, 112);
            Practice.BackColor = Color.FromArgb(255, 169, 151, 112);
            Quiz.BackColor = Color.FromArgb(255, 169, 151, 112);
            HomePage_.Visible = true;
            Learning_.Visible = false;
            Practice_.Visible = false;
            Quiz_.Visible = false;
        }

        private void Learning_Click(object sender, EventArgs e)
        {
            stopReading();

            Choose.Height = Learning.Height;
            Choose.Top = Learning.Top;
            HomePage.BackColor = Color.FromArgb(255, 169, 151, 112);
            Learning.BackColor = Color.FromArgb(255, 154, 138, 102);
            Practice.BackColor = Color.FromArgb(255, 169, 151, 112);
            Quiz.BackColor = Color.FromArgb(255, 169, 151, 112);
            HomePage_.Visible = false;
            Learning_.Visible = true;
            Practice_.Visible = false;
            Quiz_.Visible = false;
        }

        private void Start_L_Click(object sender, EventArgs e)
        {
            Readasnyc();
        }

        private void Stop_L_Click(object sender, EventArgs e)
        {
            stopReading();
        }

        private void Replay_L_Click(object sender, EventArgs e)
        {
            Play_Sound(code);
        }

        private void Practice_Click(object sender, EventArgs e)
        {
            stopReading();

            Choose.Height = Practice.Height;
            Choose.Top = Practice.Top;
            HomePage.BackColor = Color.FromArgb(255, 169, 151, 112);
            Learning.BackColor = Color.FromArgb(255, 169, 151, 112);
            Practice.BackColor = Color.FromArgb(255, 154, 138, 102);
            Quiz.BackColor = Color.FromArgb(255, 169, 151, 112);
            HomePage_.Visible = false;
            Learning_.Visible = false;
            Practice_.Visible = true;
            Quiz_.Visible = false;
        }

        private void Start_P_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ReadsnycTask);
            thread.Start();
        }

        private void Replay_P_Click(object sender, EventArgs e)
        {
            Play_Sound(code);
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            stopReading();

            Choose.Height = Quiz.Height;
            Choose.Top = Quiz.Top;
            HomePage.BackColor = Color.FromArgb(255, 169, 151, 112);
            Learning.BackColor = Color.FromArgb(255, 169, 151, 112);
            Practice.BackColor = Color.FromArgb(255, 169, 151, 112);
            Quiz.BackColor = Color.FromArgb(255, 154, 138, 102);
            HomePage_.Visible = false;
            Learning_.Visible = false;
            Practice_.Visible = false;
            Quiz_.Visible = true;
        }

        private void PlayQSound_Click(object sender, EventArgs e)
        {
            if (!is_finish)
            {
                Play_Sound(int.Parse(question[questionIndex]));
            }
            else { MessageBox.Show("未選擇題組或已答題完畢, 請從右上角進入設定", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }
        }

        private void CheckAnswer_Click(object sender, EventArgs e)
        {
            if (!is_finish)
            {
                Submit();
            }
            else { MessageBox.Show("未選擇題組或已答題完畢, 請從右上角進入設定", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }
        }

        private void ChangeQ_Click(object sender, EventArgs e)
        {
            if (!is_finish)
            {
                SkipLog();
                ShowAns();
                HidePreviousS();
                NextQuestion();
            }
            else { MessageBox.Show("未選擇題組或已答題完畢, 請從右上角進入設定", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }
        }
    }
}