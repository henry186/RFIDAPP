using System;
using System.Windows.Forms;
using ThingMagic;

namespace App
{
    public partial class MainForm : Form
    {
        private Reader reader;

        public void EstablishReader()
        {
            //reader = Reader.Create("eapi:///com3");
            reader = Reader.Create("eapi:///com4");
            reader.Connect();
            reader.ParamSet("/reader/region/id", Reader.Region.NA);
            //reader.ParamSet("/reader/radio/readPower", 1000);
        }

        public void Readsnyc()
        {
            code = 0;
            int timeout = 1300;
            TagReadData[] tags = new TagReadData[1];

            tags = reader.Read(timeout);
            for (int i = 0; i < tags.Length; i++)
            {
                code += int.Parse(tags[i].EpcString.ToString());
            }
        }

        public void ReadsnycTask()
        {
            Readsnyc();
            Separate();
            Position_Set(Top_P, Middle_P, Bottom_P, Tone_P);
            Image_Show(Top_P, Middle_P, Bottom_P, Tone_P);
            Input_Validate(label1_P);
            Play_Sound(code);
        }

        public void Readasnyc()
        {
            code = 0;

            isReading = true;
            reader.StartReading();
            reader.TagRead += Asnyc_Handler;
            OnValueChanged += new ValueChanged(afterValueChanged);
        }

        public void stopReading()
        {
            if (isReading) reader.StopReading();
        }

        private void Asnyc_Handler(object sender, TagReadDataEventArgs e)
        {
            if (code != int.Parse(e.TagReadData.EpcString.ToString()))
            {
                code = int.Parse(e.TagReadData.EpcString.ToString());
                WhenValueChange();
            }
        }

        public delegate void ValueChanged(object sender, EventArgs e);

        public event ValueChanged OnValueChanged;

        public void afterValueChanged(object sender, EventArgs e)
        {
            Separate();
            Position_Set(Top_L, Middle_L, Bottom_L, Tone_L);
            Image_Show(Top_L, Middle_L, Bottom_L, Tone_L);
            Play_Sound(code);
        }

        public void WhenValueChange()
        {
            if (OnValueChanged != null)
            {
                OnValueChanged(this, null);
            }
        }

        private int code = 20002740;
        private bool isReading = false;
    }
}