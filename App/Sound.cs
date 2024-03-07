using System.Windows.Forms;
using System.Media;
using System;

namespace App
{
    public partial class MainForm : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();

        private string soundPath;

        public void SoundPathSetting(int code)
        {
            soundPath = "../../../sound/";

            switch (gender)
            {
                case Soundgender.Boy:
                    soundPath += "BoySound/";
                    break;

                case Soundgender.Girl:
                    soundPath += "GirlSound/";
                    break;
            }

            soundPath += String.Format("{0:00000000}", code) + ".wav";
        }

        public void Play_Sound(int code)
        {
            SoundPathSetting(code);

            try
            {
                soundPlayer.SoundLocation = soundPath;
                soundPlayer.LoadAsync();
                soundPlayer.Play();
            }
            catch
            {
                soundPlayer.SoundLocation = "../../../sound/error.wav";
                soundPlayer.LoadAsync();
                soundPlayer.Play();
            }
        }

        public void CorrectSound()
        {
            soundPlayer.SoundLocation = "../../../sound/correct.wav";
            soundPlayer.LoadAsync();
            soundPlayer.Play();
        }

        public void ErrorSound()
        {
            soundPlayer.SoundLocation = "../../../sound/error.wav";
            soundPlayer.LoadAsync();
            soundPlayer.Play();
        }

        private enum Soundgender
        {
            Boy,
            Girl,
        }

        private Soundgender gender = Soundgender.Boy;

        public void Set_Boy()
        {
            gender = Soundgender.Boy;
        }

        public void Set_Girl()
        {
            gender = Soundgender.Girl;
        }

        public bool Is_Boy()
        {
            if (gender == Soundgender.Boy) return true;
            else return false;
        }

        public bool Is_Girl()
        {
            if (gender == Soundgender.Girl)
                return true;
            else return false;
        }
    }
}