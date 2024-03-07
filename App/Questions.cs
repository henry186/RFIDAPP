using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public partial class MainForm : Form
    {
        private const int randMax = 10;

        private string questionPath;
        private string txtPath;
        private string csvPath;

        private string[] question;
        private int questionIndex;
        private List<int> randomList;
        private int randomIndex;

        private int completed;
        private bool is_finish = true;

        public int correctCounter;
        public int missCounter;

        public void PathSetting()
        {
            questionPath = "../../../questions/";

            switch (questionSet)
            {
                case QuestionSet.SequenceTest:
                    questionPath += "SequenceTest.txt";
                    break;

                case QuestionSet.button10:
                    questionPath += "custom3.txt";
                    break;

                case QuestionSet.RandomTest:
                    questionPath += "RandomTest.txt";
                    break;

                case QuestionSet.b0411:
                    questionPath += "0411.txt";
                    break;

                case QuestionSet.b0708:
                    questionPath += "0708.txt";
                    break;

                case QuestionSet.b0818:
                    questionPath += "0818.txt";
                    break;

                case QuestionSet.b1519:
                    questionPath += "1519.txt";
                    break;

                case QuestionSet.b1620:
                    questionPath += "1620.txt";
                    break;

                case QuestionSet.b1721:
                    questionPath += "1721.txt";
                    break;

                case QuestionSet.b2224:
                    questionPath += "2224.txt";
                    break;

                case QuestionSet.b2632:
                    questionPath += "2632.txt";
                    break;

                case QuestionSet.b2830:
                    questionPath += "2830.txt";
                    break;

                case QuestionSet.b3335:
                    questionPath += "3335.txt";
                    break;

                case QuestionSet.b3436:
                    questionPath += "3436.txt";
                    break;
            }

            txtPath = "../../../log/" + DateTime.Now.ToString("MM-dd-HH-mm") + ".txt";
            csvPath = "../../../log/" + DateTime.Now.ToString("MM-dd-HH-mm") + ".csv";
        }

        public void ReadQuestions()
        {
            question = File.ReadAllLines(questionPath);
        }

        public void SetQuestion()
        {
            completed = 0;
            correctCounter = 0;
            missCounter = 0;
            is_finish = false;

            PathSetting();
            LogEstablish();
            ReadQuestions();
            switch (questionSet)
            {
                case QuestionSet.SequenceTest:
                case QuestionSet.button10:
                    qleft.Text = question.Length.ToString();
                    questionIndex = 0;
                    break;

                case QuestionSet.RandomTest:
                case QuestionSet.b0411:
                case QuestionSet.b0708:
                case QuestionSet.b0818:
                case QuestionSet.b1519:
                case QuestionSet.b1620:
                case QuestionSet.b1721:
                case QuestionSet.b2224:
                case QuestionSet.b2632:
                case QuestionSet.b2830:
                case QuestionSet.b3335:
                case QuestionSet.b3436:
                    qleft.Text = randMax.ToString();
                    RandomMaker();
                    randomIndex = 0;
                    questionIndex = randomList[randomIndex];
                    break;
            }

            MisstimeUpdate();
        }

        public void Submit()
        {
            HidePrevious();
            if (CheckAns(questionIndex))
            {
                correctCounter++;
                CorrectLog();
                NextQuestion();
            }
            else
            {
                missCounter++;
                MissLog();
                MisstimeUpdate();
                if (missCounter == 5)
                {
                    ShowAns();
                    NextQuestion();
                }
            }
        }

        public void HidePreviousR()
        {
            Top_R.Image = null;
            Middle_R.Image = null;
            Bottom_R.Image = null;
            Tone_R.Image = null;
        }

        public void HidePreviousS()
        {
            Top_S.Image = null;
            Middle_S.Image = null;
            Bottom_S.Image = null;
            Tone_S.Image = null;
        }

        public void HidePrevious()
        {
            HidePreviousR();
            HidePreviousS();
        }

        public void MisstimeUpdate()
        {
            switch (missCounter)
            {
                case 0:
                    label10.Text = "○○○○○";
                    break;

                case 1:
                    label10.Text = "●○○○○";
                    break;

                case 2:
                    label10.Text = "●●○○○";
                    break;

                case 3:
                    label10.Text = "●●●○○";
                    break;

                case 4:
                    label10.Text = "●●●●○";
                    break;

                case 5:
                    label10.Text = "●●●●●";
                    break;
            }
        }

        public bool CheckAns(int index)
        {
            Readsnyc();
            Separate();
            PositionS_Set(Top_S, Middle_S, Bottom_S, Tone_S);
            ImageS_Show(Top_S, Middle_S, Bottom_S, Tone_S);

            if (code == int.Parse(question[index]))
            {
                CorrectSound();
                ShowAns();
                pictureBox1.Image = Properties.Resources.Correct;
                pictureBox1.Visible = true;
                HideResult();
                return true;
            }
            else
            {
                ErrorSound();
                pictureBox1.Image = Properties.Resources.Wrong;
                pictureBox1.Visible = true;
                HideResult();
                return false;
            }
        }

        public void SequenceNext()
        {
            questionIndex++;
        }

        public void RandomNext()
        {
            randomIndex++;
            questionIndex = randomList[randomIndex];
        }

        public void NextQuestion()
        {
            completed++;
            missCounter = 0;
            MisstimeUpdate();

            switch (questionSet)
            {
                case QuestionSet.SequenceTest:
                case QuestionSet.button10:
                    if (completed == question.Length)
                    {
                        qleft.Text = (question.Length - completed).ToString();
                        is_finish = true;
                        EndLog();
                    }
                    else
                    {
                        SequenceNext();
                        qleft.Text = (question.Length - completed).ToString();
                    }
                    break;

                case QuestionSet.RandomTest:
                case QuestionSet.b0411:
                case QuestionSet.b0708:
                case QuestionSet.b0818:
                case QuestionSet.b1519:
                case QuestionSet.b1620:
                case QuestionSet.b1721:
                case QuestionSet.b2224:
                case QuestionSet.b2632:
                case QuestionSet.b2830:
                case QuestionSet.b3335:
                case QuestionSet.b3436:
                    if (completed == randMax)
                    {
                        qleft.Text = (randMax - completed).ToString();
                        is_finish = true;
                        EndLog();
                    }
                    else
                    {
                        RandomNext();
                        qleft.Text = (randMax - completed).ToString();
                    }
                    break;
            }
        }

        public void RandomMaker()
        {
            Random random = new Random();
            randomList = Enumerable.Range(0, question.Count() - 1).OrderBy(x => random.Next()).Take(randMax + 1).ToList();
        }

        public void ShowAns()
        {
            code = int.Parse(question[questionIndex]);
            Separate();
            PositionR_Set(Top_R, Middle_R, Bottom_R, Tone_R);
            ImageR_Show(Top_R, Middle_R, Bottom_R, Tone_R);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.Image = null;
            timer1.Stop();
        }

        private void HideResult()
        {
            timer1.Start();
        }

        public void LogEstablish()
        {
            FileStream csvfileStream = new FileStream(csvPath, FileMode.Append);
            StreamWriter csvstreamWriter = new StreamWriter(csvfileStream);

            csvstreamWriter.Write("問題,回答1,回答2,回答3,回答4,回答5,答對題數,總題數");

            csvstreamWriter.Close();
            csvfileStream.Close();
        }

        public void CorrectLog()
        {
            FileStream txtfileStream = new FileStream(txtPath, FileMode.Append);
            StreamWriter txtstreamWriter = new StreamWriter(txtfileStream);
            FileStream csvfileStream = new FileStream(csvPath, FileMode.Append);
            StreamWriter csvstreamWriter = new StreamWriter(csvfileStream);

            if (missCounter != 0)
            {
                txtstreamWriter.WriteLine("正確!");

                csvstreamWriter.Write(",");
                CodeReverse(code, csvstreamWriter);
                for (int comma = missCounter; comma < 6; comma++) { csvstreamWriter.Write(","); }
            }
            else
            {
                txtstreamWriter.Write("\r\n回答題目 : ");
                CodeReverse(int.Parse(question[questionIndex]), txtstreamWriter);
                txtstreamWriter.WriteLine("");
                txtstreamWriter.WriteLine("正確!");

                csvstreamWriter.WriteLine("");
                CodeReverse(int.Parse(question[questionIndex]), csvstreamWriter);
                csvstreamWriter.Write(",");
                CodeReverse(code, csvstreamWriter);
                csvstreamWriter.Write(",,,,,,");
            }

            txtstreamWriter.Close();
            txtfileStream.Close();
            csvstreamWriter.Close();
            csvfileStream.Close();
        }

        public void MissLog()
        {
            FileStream txtfileStream = new FileStream(txtPath, FileMode.Append);
            StreamWriter txtstreamWriter = new StreamWriter(txtfileStream);
            FileStream csvfileStream = new FileStream(csvPath, FileMode.Append);
            StreamWriter csvstreamWriter = new StreamWriter(csvfileStream);

            if (missCounter == 1)
            {
                txtstreamWriter.Write("\r\n曾答錯題目 : ");
                CodeReverse(int.Parse(question[questionIndex]), txtstreamWriter);
                txtstreamWriter.WriteLine("");
                CodeReverse(code, txtstreamWriter);
                txtstreamWriter.WriteLine(",");

                csvstreamWriter.WriteLine("");
                CodeReverse(int.Parse(question[questionIndex]), csvstreamWriter);
                csvstreamWriter.Write(",");
                CodeReverse(code, csvstreamWriter);
            }
            else
            {
                CodeReverse(code, txtstreamWriter);
                txtstreamWriter.WriteLine(",");
                csvstreamWriter.Write(",");
                CodeReverse(code, csvstreamWriter);
            }

            if (missCounter == 5) { csvstreamWriter.Write(",,,,"); }

            txtstreamWriter.Close();
            txtfileStream.Close();
            csvstreamWriter.Close();
            csvfileStream.Close();
        }

        public void SkipLog()
        {
            FileStream txtfileStream = new FileStream(txtPath, FileMode.Append);
            StreamWriter txtstreamWriter = new StreamWriter(txtfileStream);
            FileStream csvfileStream = new FileStream(csvPath, FileMode.Append);
            StreamWriter csvstreamWriter = new StreamWriter(csvfileStream);

            txtstreamWriter.Write("跳過題目 : ");
            CodeReverse(int.Parse(question[questionIndex]), txtstreamWriter);
            txtstreamWriter.WriteLine("");

            if (missCounter != 0)
            {
                for (int comma = missCounter; comma < 7; comma++) { csvstreamWriter.Write(","); }
            }
            else
            {
                csvstreamWriter.WriteLine("");
                CodeReverse(int.Parse(question[questionIndex]), csvstreamWriter);
                csvstreamWriter.Write(",,,,,,,");
            }

            txtstreamWriter.Close();
            txtfileStream.Close();
            csvstreamWriter.Close();
            csvfileStream.Close();
        }

        public void EndLog()
        {
            string questionNumber = null;

            FileStream txtfileStream = new FileStream(txtPath, FileMode.Append);
            StreamWriter txtstreamWriter = new StreamWriter(txtfileStream);
            FileStream csvfileStream = new FileStream(csvPath, FileMode.Append);
            StreamWriter csvstreamWriter = new StreamWriter(csvfileStream);

            switch (questionSet)
            {
                case QuestionSet.SequenceTest:
                case QuestionSet.button10:
                    questionNumber = question.Length.ToString();
                    break;

                case QuestionSet.RandomTest:
                case QuestionSet.b0411:
                case QuestionSet.b0708:
                case QuestionSet.b0818:
                case QuestionSet.b1519:
                case QuestionSet.b1620:
                case QuestionSet.b1721:
                case QuestionSet.b2224:
                case QuestionSet.b2632:
                case QuestionSet.b2830:
                case QuestionSet.b3335:
                case QuestionSet.b3436:
                    questionNumber = randMax.ToString();
                    break;
            }

            txtstreamWriter.WriteLine("\r\n正確率 : " + correctCounter + " / " + questionNumber);
            csvstreamWriter.WriteLine("\r\n,,,,,," + correctCounter + "," + questionNumber);

            txtstreamWriter.Close();
            txtfileStream.Close();
            csvstreamWriter.Close();
            csvfileStream.Close();
        }

        public void CodeReverse(int code, StreamWriter streamWriter)
        {
            int f = 0;
            int s = 0;
            int t = 0;
            int l = 0;

            f = code / 1000000;
            s = (code - f * 1000000) / 10000;
            t = (code - f * 1000000 - s * 10000) / 100;
            l = (code - f * 1000000 - s * 10000 - t * 100);

            switch (f)
            {
                case 1:
                    streamWriter.Write("ㄅ");
                    break;

                case 2:
                    streamWriter.Write("ㄆ");
                    break;

                case 3:
                    streamWriter.Write("ㄇ");
                    break;

                case 4:
                    streamWriter.Write("ㄈ");
                    break;

                case 5:
                    streamWriter.Write("ㄉ");
                    break;

                case 6:
                    streamWriter.Write("ㄊ");
                    break;

                case 7:
                    streamWriter.Write("ㄋ");
                    break;

                case 8:
                    streamWriter.Write("ㄌ");
                    break;

                case 9:
                    streamWriter.Write("ㄍ");
                    break;

                case 10:
                    streamWriter.Write("ㄎ");
                    break;

                case 11:
                    streamWriter.Write("ㄏ");
                    break;

                case 12:
                    streamWriter.Write("ㄐ");
                    break;

                case 13:
                    streamWriter.Write("ㄑ");
                    break;

                case 14:
                    streamWriter.Write("ㄒ");
                    break;

                case 15:
                    streamWriter.Write("ㄓ");
                    break;

                case 16:
                    streamWriter.Write("ㄔ");
                    break;

                case 17:
                    streamWriter.Write("ㄕ");
                    break;

                case 18:
                    streamWriter.Write("ㄖ");
                    break;

                case 19:
                    streamWriter.Write("ㄗ");
                    break;

                case 20:
                    streamWriter.Write("ㄘ");
                    break;

                case 21:
                    streamWriter.Write("ㄙ");
                    break;
            }

            switch (s)
            {
                case 22:
                    streamWriter.Write("ㄧ");
                    break;

                case 23:
                    streamWriter.Write("ㄨ");
                    break;

                case 24:
                    streamWriter.Write("ㄩ");
                    break;
            }

            switch (t)
            {
                case 25:
                    streamWriter.Write("ㄚ");
                    break;

                case 26:
                    streamWriter.Write("ㄛ");
                    break;

                case 27:
                    streamWriter.Write("ㄜ");
                    break;

                case 28:
                    streamWriter.Write("ㄝ");
                    break;

                case 29:
                    streamWriter.Write("ㄞ");
                    break;

                case 30:
                    streamWriter.Write("ㄟ");
                    break;

                case 31:
                    streamWriter.Write("ㄠ");
                    break;

                case 32:
                    streamWriter.Write("ㄡ");
                    break;

                case 33:
                    streamWriter.Write("ㄢ");
                    break;

                case 34:
                    streamWriter.Write("ㄣ");
                    break;

                case 35:
                    streamWriter.Write("ㄤ");
                    break;

                case 36:
                    streamWriter.Write("ㄥ");
                    break;

                case 37:
                    streamWriter.Write("ㄦ");
                    break;
            }

            switch (l)
            {
                case 38:
                    streamWriter.Write("ˊ");
                    break;

                case 39:
                    streamWriter.Write("ˇ");
                    break;

                case 40:
                    streamWriter.Write("ˋ");
                    break;

                case 41:
                    streamWriter.Write("˙");
                    break;
            }
        }

        private enum QuestionSet
        {
            SequenceTest,
            RandomTest,
            b0411,
            b0708,
            b0818,
            b1519,
            b1620,
            b1721,
            b2224,
            b2632,
            b2830,
            b3335,
            b3436,
            button10,
        }

        private QuestionSet questionSet;

        public void Set_SequenceTest()
        {
            questionSet = QuestionSet.SequenceTest;
        }

        public void Set_RandomTest()
        {
            questionSet = QuestionSet.RandomTest;
        }

        public void Set_b0411()
        {
            questionSet = QuestionSet.b0411;
        }

        public void Set_b0708()
        {
            questionSet = QuestionSet.b0708;
        }

        public void Set_b0818()
        {
            questionSet = QuestionSet.b0818;
        }

        public void Set_b1519()
        {
            questionSet = QuestionSet.b1519;
        }

        public void Set_b1620()
        {
            questionSet = QuestionSet.b1620;
        }

        public void Set_b1721()
        {
            questionSet = QuestionSet.b1721;
        }

        public void Set_b2224()
        {
            questionSet = QuestionSet.b2224;
        }

        public void Set_b2632()
        {
            questionSet = QuestionSet.b2632;
        }

        public void Set_b2830()
        {
            questionSet = QuestionSet.b2830;
        }

        public void Set_b3335()
        {
            questionSet = QuestionSet.b3335;
        }

        public void Set_b3436()
        {
            questionSet = QuestionSet.b3436;
        }

        public void Set_button10()
        {
            questionSet = QuestionSet.button10;
        }
    }
}