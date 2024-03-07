using System;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class Setting_Form : Form
    {
        public Setting_Form()
        {
            InitializeComponent();
        }

        private void Setting_Form_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)this.Owner;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exam_Click(object sender, EventArgs e)
        {
            Choose.Width = Exam.Width;
            Choose.Left = Exam.Left;

            Gender_.Visible = false;
            Exam_.Visible = true;
        }

        private void Gender_Click(object sender, EventArgs e)
        {
            Choose.Width = Gender.Width;
            Choose.Left = Gender.Left;

            Gender_.Visible = true;
            Exam_.Visible = false;
        }

        private void BoySound_Paint(object sender, PaintEventArgs e)
        {
            if (mainForm.Is_Boy())
            {
                PictureBox p = (PictureBox)sender;
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(183, 179, 175), 4), 0, 0, p.Width, p.Height);
            }
        }

        private void BoySound_Click(object sender, EventArgs e)
        {
            BoySound.Location = new Point(86, 95);
            GirlSound.Location = new Point(310, 120);

            BoySound.Height = 197;
            GirlSound.Height = 164;

            BoySound.Image = Properties.Resources.BoySound_On;
            GirlSound.Image = Properties.Resources.GirlSound_off;

            mainForm.Set_Boy();
        }

        private void GirlSound_Paint(object sender, PaintEventArgs e)
        {
            if (mainForm.Is_Girl())
            {
                PictureBox p = (PictureBox)sender;
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(183, 179, 175), 4), 0, 0, p.Width, p.Height);
            }
        }

        private void GirlSound_Click(object sender, EventArgs e)
        {
            BoySound.Location = new Point(86, 120);
            GirlSound.Location = new Point(310, 95);

            BoySound.Height = 164;
            GirlSound.Height = 197;

            BoySound.Image = Properties.Resources.BoySound_off;
            GirlSound.Image = Properties.Resources.GirlSound_On;

            mainForm.Set_Girl();
        }

        private MainForm mainForm;

        private void SequenceSet_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = Sequence.Top;
            ChooseQ.Left = Sequence.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_SequenceTest();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(154, 138, 102);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void Random_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = Random.Top;
            ChooseQ.Left = Random.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_RandomTest();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(154, 138, 102);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b0411_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b0411.Top;
            ChooseQ.Left = b0411.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b0411();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(154, 138, 102);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b0708_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b0708.Top;
            ChooseQ.Left = b0708.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b0708();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(154, 138, 102);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b0818_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b0818.Top;
            ChooseQ.Left = b0818.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b0818();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(154, 138, 102);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b1519_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b1519.Top;
            ChooseQ.Left = b1519.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b1519();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(154, 138, 102);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b1620_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b1620.Top;
            ChooseQ.Left = b1620.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b1620();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(154, 138, 102);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b1721_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b1721.Top;
            ChooseQ.Left = b1721.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b1721();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(154, 138, 102);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b2224_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b2224.Top;
            ChooseQ.Left = b2224.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b2224();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(154, 138, 102);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b2632_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b2632.Top;
            ChooseQ.Left = b2632.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b2632();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(154, 138, 102);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b2830_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b2830.Top;
            ChooseQ.Left = b2830.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b2830();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(154, 138, 102);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b3335_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b3335.Top;
            ChooseQ.Left = b3335.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b3335();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(154, 138, 102);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void b3436_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = b3436.Top;
            ChooseQ.Left = b3436.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_b3436();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(154, 138, 102);
            button10.BackColor = Color.FromArgb(169, 151, 112);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChooseQ.Top = button10.Top;
            ChooseQ.Left = button10.Left - 10;
            ChooseQ.BackColor = Color.FromArgb(76, 107, 90);

            mainForm.Set_button10();
            mainForm.SetQuestion();

            Sequence.BackColor = Color.FromArgb(169, 151, 112);
            Random.BackColor = Color.FromArgb(169, 151, 112);
            b0411.BackColor = Color.FromArgb(169, 151, 112);
            b0708.BackColor = Color.FromArgb(169, 151, 112);
            b0818.BackColor = Color.FromArgb(169, 151, 112);
            b1519.BackColor = Color.FromArgb(169, 151, 112);
            b1620.BackColor = Color.FromArgb(169, 151, 112);
            b1721.BackColor = Color.FromArgb(169, 151, 112);
            b2224.BackColor = Color.FromArgb(169, 151, 112);
            b2632.BackColor = Color.FromArgb(169, 151, 112);
            b2830.BackColor = Color.FromArgb(169, 151, 112);
            b3335.BackColor = Color.FromArgb(169, 151, 112);
            b3436.BackColor = Color.FromArgb(169, 151, 112);
            button10.BackColor = Color.FromArgb(154, 138, 102);
        }
    }
}