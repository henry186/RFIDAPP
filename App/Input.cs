using System.Windows.Forms;
using System.Drawing;

namespace App
{
    public partial class MainForm : Form
    {
        public void Separate()
        {
            top = 0;
            middle = 0;
            bottom = 0;
            tone = 0;

            top = code / 1000000;
            middle = (code - top * 1000000) / 10000;
            bottom = (code - top * 1000000 - middle * 10000) / 100;
            tone = (code - top * 1000000 - middle * 10000 - bottom * 100);
        }

        public void Position_Set(PictureBox Top, PictureBox Middle, PictureBox Bottom, PictureBox Tone)
        {
            Top.Image = null;
            Middle.Image = null;
            Bottom.Image = null;
            Tone.Image = null;

            if (top != 0 && middle == 0 && bottom == 0)
                type = 1;

            if (top == 0 && middle != 0 && bottom == 0)
                type = 2;

            if (top == 0 && middle == 0 && bottom != 0)
                type = 3;

            if (top != 0 && middle != 0 && bottom == 0)
                type = 4;

            if (top != 0 && middle == 0 && bottom != 0)
                type = 5;

            if (top == 0 && middle != 0 && bottom != 0)
                type = 6;

            if (top != 0 && middle != 0 && bottom != 0)
                type = 7;

            switch (type)
            {
                case 1:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(397, 118);
                        Top.Location = new Point(359, 211);
                        Middle.Location = new Point(0, 0);
                        Bottom.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(507, 144);
                        Top.Location = new Point(340, 193);
                        Middle.Location = new Point(0, 0);
                        Bottom.Location = new Point(0, 0);
                    }
                    break;

                case 2:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(397, 118);
                        Middle.Location = new Point(359, 211);
                        Top.Location = new Point(0, 0);
                        Bottom.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(507, 144);
                        Middle.Location = new Point(340, 193);
                        Top.Location = new Point(0, 0);
                        Bottom.Location = new Point(0, 0);
                    }
                    break;

                case 3:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(397, 118);
                        Bottom.Location = new Point(359, 211);
                        Top.Location = new Point(0, 0);
                        Middle.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(507, 144);
                        Bottom.Location = new Point(340, 193);
                        Top.Location = new Point(0, 0);
                        Middle.Location = new Point(0, 0);
                    }
                    break;

                case 4:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(378, 43);
                        Top.Location = new Point(340, 131);
                        Middle.Location = new Point(340, 295);
                        Bottom.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(495, 226);
                        Top.Location = new Point(328, 111);
                        Middle.Location = new Point(328, 275);
                        Bottom.Location = new Point(0, 0);
                    }
                    break;

                case 5:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(378, 43);
                        Top.Location = new Point(340, 131);
                        Bottom.Location = new Point(340, 295);
                        Middle.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(495, 226);
                        Top.Location = new Point(328, 111);
                        Bottom.Location = new Point(328, 275);
                        Middle.Location = new Point(0, 0);
                    }
                    break;

                case 6:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(378, 43);
                        Middle.Location = new Point(340, 131);
                        Bottom.Location = new Point(340, 295);
                        Top.Location = new Point(0, 0);
                    }
                    else
                    {
                        Tone.Location = new Point(495, 226);
                        Middle.Location = new Point(328, 111);
                        Bottom.Location = new Point(328, 275);
                        Top.Location = new Point(0, 0);
                    }
                    break;

                case 7:
                    if (tone == 41)
                    {
                        Tone.Location = new Point(360, -22);
                        Top.Location = new Point(328, 65);
                        Middle.Location = new Point(328, 225);
                        Bottom.Location = new Point(328, 387);
                    }
                    else
                    {
                        Tone.Location = new Point(495, 275);
                        Top.Location = new Point(328, 33);
                        Middle.Location = new Point(328, 193);
                        Bottom.Location = new Point(328, 355);
                    }
                    break;
            }
        }

        public void Image_Show(PictureBox Top, PictureBox Middle, PictureBox Bottom, PictureBox Tone)
        {
            switch (top)
            {
                case 1: //ㄅ
                    Top.Image = Properties.Resources._1;
                    break;

                case 2: //ㄆ
                    Top.Image = Properties.Resources._2;
                    break;

                case 3: //ㄇ
                    Top.Image = Properties.Resources._3;
                    break;

                case 4: //ㄈ
                    Top.Image = Properties.Resources._4;
                    break;

                case 5: //ㄉ
                    Top.Image = Properties.Resources._5;
                    break;

                case 6: //ㄊ
                    Top.Image = Properties.Resources._6;
                    break;

                case 7: //ㄋ
                    Top.Image = Properties.Resources._7;
                    break;

                case 8: //ㄌ
                    Top.Image = Properties.Resources._8;
                    break;

                case 9: //ㄍ
                    Top.Image = Properties.Resources._9;
                    break;

                case 10: //ㄎ
                    Top.Image = Properties.Resources._10;
                    break;

                case 11: //ㄏ
                    Top.Image = Properties.Resources._11;
                    break;

                case 12: //ㄐ
                    Top.Image = Properties.Resources._12;
                    break;

                case 13: //ㄑ
                    Top.Image = Properties.Resources._13;
                    break;

                case 14: //ㄒ
                    Top.Image = Properties.Resources._14;
                    break;

                case 15: //ㄓ
                    Top.Image = Properties.Resources._15;
                    break;

                case 16: //ㄔ
                    Top.Image = Properties.Resources._16;
                    break;

                case 17: //ㄕ
                    Top.Image = Properties.Resources._17;
                    break;

                case 18: //ㄖ
                    Top.Image = Properties.Resources._18;
                    break;

                case 19: //ㄗ
                    Top.Image = Properties.Resources._19;
                    break;

                case 20: //ㄘ
                    Top.Image = Properties.Resources._20;
                    break;

                case 21: //ㄙ
                    Top.Image = Properties.Resources._21;
                    break;

                default:
                    Top.Image = null;
                    break;
            }

            switch (middle)
            {
                case 22: //ㄧ
                    Middle.Image = Properties.Resources._35;
                    break;

                case 23: //ㄨ
                    Middle.Image = Properties.Resources._36;
                    break;

                case 24: //ㄩ
                    Middle.Image = Properties.Resources._37;
                    break;

                default:
                    Middle.Image = null;
                    break;
            }

            switch (bottom)
            {
                case 25: //ㄚ
                    Bottom.Image = Properties.Resources._22;
                    break;

                case 26: //ㄛ
                    Bottom.Image = Properties.Resources._23;
                    break;

                case 27: //ㄜ
                    Bottom.Image = Properties.Resources._24;
                    break;

                case 28: //ㄝ
                    Bottom.Image = Properties.Resources._25;
                    break;

                case 29: //ㄞ
                    Bottom.Image = Properties.Resources._26;
                    break;

                case 30: //ㄟ
                    Bottom.Image = Properties.Resources._27;
                    break;

                case 31: //ㄠ
                    Bottom.Image = Properties.Resources._28;
                    break;

                case 32: //ㄡ
                    Bottom.Image = Properties.Resources._29;
                    break;

                case 33: //ㄢ
                    Bottom.Image = Properties.Resources._30;
                    break;

                case 34: //ㄣ
                    Bottom.Image = Properties.Resources._31;
                    break;

                case 35: //ㄤ
                    Bottom.Image = Properties.Resources._32;
                    break;

                case 36: //ㄥ
                    Bottom.Image = Properties.Resources._33;
                    break;

                case 37: //ㄦ
                    Bottom.Image = Properties.Resources._34;
                    break;

                default:
                    Bottom.Image = null;
                    break;
            }

            switch (tone)
            {
                case 38: //ˊ
                    Tone.Image = Properties.Resources._38;
                    break;

                case 39: //ˇ
                    Tone.Image = Properties.Resources._39;
                    break;

                case 40: //ˋ
                    Tone.Image = Properties.Resources._40;
                    break;

                case 41: //˙
                    Tone.Image = Properties.Resources._41;
                    break;

                default:
                    Tone.Image = null;
                    break;
            }
        }

        public void Input_Validate(Label label1)
        {
            switch (code)
            {
                case 01002500:
                case 01002538:
                case 01002539:
                case 01002540:
                case 01002541:
                case 01002600:
                case 01002638:
                case 01002639:
                case 01002640:
                case 01002641:
                case 01002900:
                case 01002938:
                case 01002939:
                case 01002940:
                case 01003000:
                case 01003039:
                case 01003040:
                case 01003100:
                case 01003138:
                case 01003139:
                case 01003140:
                case 01003141:
                case 01003300:
                case 01003339:
                case 01003340:
                case 01003400:
                case 01003439:
                case 01003440:
                case 01003500:
                case 01003539:
                case 01003540:
                case 01003600:
                case 01003640:
                case 01220000:
                case 01220038:
                case 01220039:
                case 01220040:
                case 01222800:
                case 01222838:
                case 01222839:
                case 01222840:
                case 01223100:
                case 01223139:
                case 01223140:
                case 01223300:
                case 01223339:
                case 01223340:
                case 01223400:
                case 01223440:
                case 01223600:
                case 01223639:
                case 01223640:
                case 01230000:
                case 01230038:
                case 01230039:
                case 01230040:
                case 02002500:
                case 02002538:
                case 02002540:
                case 02002600:
                case 02002638:
                case 02002639:
                case 02002640:
                case 02002641:
                case 02002900:
                case 02002938:
                case 02002940:
                case 02003000:
                case 02003038:
                case 02003040:
                case 02003100:
                case 02003138:
                case 02003139:
                case 02003140:
                case 02003300:
                case 02003338:
                case 02003340:
                case 02003400:
                case 02003438:
                case 02003500:
                case 02003538:
                case 02003540:
                case 02003600:
                case 02003638:
                case 02003639:
                case 02003640:
                case 02220000:
                case 02220038:
                case 02220039:
                case 02220040:
                case 02222800:
                case 02222839:
                case 02223100:
                case 02223138:
                case 02223139:
                case 02223140:
                case 02223300:
                case 02223338:
                case 02223340:
                case 02223400:
                case 02223438:
                case 02223439:
                case 02223440:
                case 02223600:
                case 02223638:
                case 02223640:
                case 02230000:
                case 02230038:
                case 02230039:
                case 02230040:
                case 03002500:
                case 03002538:
                case 03002539:
                case 03002540:
                case 03002541:
                case 03002600:
                case 03002638:
                case 03002639:
                case 03002640:
                case 03002641:
                case 03002938:
                case 03002939:
                case 03002940:
                case 03003038:
                case 03003039:
                case 03003040:
                case 03003041:
                case 03003100:
                case 03003138:
                case 03003139:
                case 03003140:
                case 03003238:
                case 03003239:
                case 03003338:
                case 03003339:
                case 03003340:
                case 03003400:
                case 03003438:
                case 03003440:
                case 03003441:
                case 03003538:
                case 03003539:
                case 03003600:
                case 03003638:
                case 03003639:
                case 03003640:
                case 03220000:
                case 03220038:
                case 03220039:
                case 03220040:
                case 03222800:
                case 03222840:
                case 03223100:
                case 03223138:
                case 03223139:
                case 03223140:
                case 03223240:
                case 03223338:
                case 03223339:
                case 03223340:
                case 03223438:
                case 03223439:
                case 03223638:
                case 03223640:
                case 03230039:
                case 03230040:
                case 04002500:
                case 04002538:
                case 04002539:
                case 04002540:
                case 04002638:
                case 04003000:
                case 04003038:
                case 04003039:
                case 04003040:
                case 04003239:
                case 04003300:
                case 04003338:
                case 04003339:
                case 04003340:
                case 04003400:
                case 04003438:
                case 04003439:
                case 04003440:
                case 04003500:
                case 04003538:
                case 04003539:
                case 04003540:
                case 04003600:
                case 04003638:
                case 04003640:
                case 04230000:
                case 04230038:
                case 04230039:
                case 04230040:
                case 05002500:
                case 05002538:
                case 05002539:
                case 05002540:
                case 05002738:
                case 05002741:
                case 05002900:
                case 05002939:
                case 05002940:
                case 05003039:
                case 05003100:
                case 05003139:
                case 05003140:
                case 05003200:
                case 05003239:
                case 05003240:
                case 05003300:
                case 05003339:
                case 05003340:
                case 05003500:
                case 05003539:
                case 05003540:
                case 05003600:
                case 05003639:
                case 05003640:
                case 05220000:
                case 05220038:
                case 05220039:
                case 05220040:
                case 05220041:
                case 05222800:
                case 05222838:
                case 05222841:
                case 05223100:
                case 05223139:
                case 05223140:
                case 05223200:
                case 05223300:
                case 05223339:
                case 05223340:
                case 05223600:
                case 05223639:
                case 05223640:
                case 05230000:
                case 05230038:
                case 05230039:
                case 05230040:
                case 05232600:
                case 05232638:
                case 05232639:
                case 05232640:
                case 05232641:
                case 05233000:
                case 05233040:
                case 05233300:
                case 05233339:
                case 05233340:
                case 05233400:
                case 05233439:
                case 05233440:
                case 05233600:
                case 05233639:
                case 05233640:
                case 06002500:
                case 06002539:
                case 06002540:
                case 06002740:
                case 06002900:
                case 06002938:
                case 06002940:
                case 06003100:
                case 06003138:
                case 06003139:
                case 06003140:
                case 06003200:
                case 06003238:
                case 06003240:
                case 06003241:
                case 06003300:
                case 06003338:
                case 06003339:
                case 06003340:
                case 06003500:
                case 06003538:
                case 06003539:
                case 06003540:
                case 06003638:
                case 06220000:
                case 06220038:
                case 06220039:
                case 06220040:
                case 06222800:
                case 06222839:
                case 06222840:
                case 06223100:
                case 06223138:
                case 06223139:
                case 06223140:
                case 06223300:
                case 06223338:
                case 06223339:
                case 06223600:
                case 06223638:
                case 06223639:
                case 06230000:
                case 06230038:
                case 06230039:
                case 06230040:
                case 06232600:
                case 06232638:
                case 06232639:
                case 06232640:
                case 06233000:
                case 06233038:
                case 06233039:
                case 06233040:
                case 06233300:
                case 06233338:
                case 06233400:
                case 06233438:
                case 06233440:
                case 06233600:
                case 06233638:
                case 06233639:
                case 06233640:
                case 07002538:
                case 07002539:
                case 07002540:
                case 07002700:
                case 07002740:
                case 07002741:
                case 07003039:
                case 07003040:
                case 07003100:
                case 07003138:
                case 07003139:
                case 07003140:
                case 07003300:
                case 07003338:
                case 07003339:
                case 07003340:
                case 07003440:
                case 07003500:
                case 07003538:
                case 07003638:
                case 07220038:
                case 07220039:
                case 07220040:
                case 07222800:
                case 07222840:
                case 07223200:
                case 07223238:
                case 07223239:
                case 07223240:
                case 07223338:
                case 07223339:
                case 07223340:
                case 07223538:
                case 07223540:
                case 07223541:
                case 07230038:
                case 07230039:
                case 07230040:
                case 07240039:
                case 08002500:
                case 08002538:
                case 08002539:
                case 08002540:
                case 08002541:
                case 08002700:
                case 08002740:
                case 08002741:
                case 08002938:
                case 08002940:
                case 08003000:
                case 08003038:
                case 08003039:
                case 08003040:
                case 08003100:
                case 08003138:
                case 08003139:
                case 08003140:
                case 08003238:
                case 08003239:
                case 08003240:
                case 08003338:
                case 08003339:
                case 08003340:
                case 08003500:
                case 08003538:
                case 08003539:
                case 08003540:
                case 08003638:
                case 08003639:
                case 08003640:
                case 08220000:
                case 08220038:
                case 08220039:
                case 08220040:
                case 08222800:
                case 08222839:
                case 08222840:
                case 08223100:
                case 08223138:
                case 08223139:
                case 08223140:
                case 08223200:
                case 08223238:
                case 08223239:
                case 08223240:
                case 08223338:
                case 08223339:
                case 08223340:
                case 08223438:
                case 08223439:
                case 08223440:
                case 08223538:
                case 08223539:
                case 08223540:
                case 08223600:
                case 08223638:
                case 08223639:
                case 08223640:
                case 08230000:
                case 08230038:
                case 08230039:
                case 08230040:
                case 08232600:
                case 08232638:
                case 08232639:
                case 08232640:
                case 08232641:
                case 08233338:
                case 08233339:
                case 08233340:
                case 08233638:
                case 08233639:
                case 08233640:
                case 09002500:
                case 09002538:
                case 09002540:
                case 09002700:
                case 09002738:
                case 09002739:
                case 09002740:
                case 09002741:
                case 09002900:
                case 09002939:
                case 09002940:
                case 09003039:
                case 09003100:
                case 09003139:
                case 09003140:
                case 09003200:
                case 09003239:
                case 09003240:
                case 09003300:
                case 09003339:
                case 09003340:
                case 09003400:
                case 09003438:
                case 09003439:
                case 09003440:
                case 09003500:
                case 09003539:
                case 09003540:
                case 09003600:
                case 09003639:
                case 09003640:
                case 09230000:
                case 09230038:
                case 09230039:
                case 09230040:
                case 09230041:
                case 09232500:
                case 09232539:
                case 09232540:
                case 09232600:
                case 09232638:
                case 09232639:
                case 09232640:
                case 09232900:
                case 09232939:
                case 09232940:
                case 09233000:
                case 09233039:
                case 09233040:
                case 09233300:
                case 09233339:
                case 09233340:
                case 09233439:
                case 09233440:
                case 09233500:
                case 09233539:
                case 09233540:
                case 09233600:
                case 09233639:
                case 09233640:
                case 10002500:
                case 10002539:
                case 10002540:
                case 10002700:
                case 10002738:
                case 10002739:
                case 10002740:
                case 10002900:
                case 10002939:
                case 10002940:
                case 10003100:
                case 10003139:
                case 10003140:
                case 10003200:
                case 10003239:
                case 10003240:
                case 10003300:
                case 10003339:
                case 10003340:
                case 10003439:
                case 10003440:
                case 10003500:
                case 10003538:
                case 10003539:
                case 10003540:
                case 10003600:
                case 10230000:
                case 10230039:
                case 10230040:
                case 10232500:
                case 10232539:
                case 10232540:
                case 10232638:
                case 10232640:
                case 10232940:
                case 10233000:
                case 10233038:
                case 10233039:
                case 10233040:
                case 10233300:
                case 10233339:
                case 10233400:
                case 10233439:
                case 10233440:
                case 10233500:
                case 10233538:
                case 10233540:
                case 10233600:
                case 10233639:
                case 10233640:
                case 11002500:
                case 11002538:
                case 11002700:
                case 11002738:
                case 11002740:
                case 11002900:
                case 11002938:
                case 11002939:
                case 11002940:
                case 11003000:
                case 11003040:
                case 11003100:
                case 11003138:
                case 11003139:
                case 11003140:
                case 11003200:
                case 11003238:
                case 11003239:
                case 11003240:
                case 11003300:
                case 11003338:
                case 11003339:
                case 11003340:
                case 11003438:
                case 11003439:
                case 11003440:
                case 11003500:
                case 11003538:
                case 11003540:
                case 11003600:
                case 11003638:
                case 11003640:
                case 11230000:
                case 11230038:
                case 11230039:
                case 11230040:
                case 11232500:
                case 11232538:
                case 11232540:
                case 11232638:
                case 11232639:
                case 11232640:
                case 11232938:
                case 11232940:
                case 11233000:
                case 11233038:
                case 11233039:
                case 11233040:
                case 11233300:
                case 11233338:
                case 11233339:
                case 11233340:
                case 11233400:
                case 11233438:
                case 11233439:
                case 11233440:
                case 11233500:
                case 11233538:
                case 11233539:
                case 11233540:
                case 11233600:
                case 11233638:
                case 11233639:
                case 11233640:
                case 12220000:
                case 12220038:
                case 12220039:
                case 12220040:
                case 12222500:
                case 12222538:
                case 12222539:
                case 12222540:
                case 12222800:
                case 12222838:
                case 12222839:
                case 12222840:
                case 12223100:
                case 12223138:
                case 12223139:
                case 12223140:
                case 12223200:
                case 12223239:
                case 12223240:
                case 12223300:
                case 12223339:
                case 12223340:
                case 12223400:
                case 12223439:
                case 12223440:
                case 12223500:
                case 12223539:
                case 12223540:
                case 12223600:
                case 12223639:
                case 12223640:
                case 12240000:
                case 12240038:
                case 12240039:
                case 12240040:
                case 12242800:
                case 12242838:
                case 12242840:
                case 12243300:
                case 12243339:
                case 12243340:
                case 12243400:
                case 12243440:
                case 12243639:
                case 13220000:
                case 13220038:
                case 13220039:
                case 13220040:
                case 13222500:
                case 13222539:
                case 13222540:
                case 13222800:
                case 13222838:
                case 13222839:
                case 13222840:
                case 13223100:
                case 13223138:
                case 13223139:
                case 13223140:
                case 13223200:
                case 13223238:
                case 13223239:
                case 13223300:
                case 13223338:
                case 13223339:
                case 13223340:
                case 13223400:
                case 13223438:
                case 13223439:
                case 13223440:
                case 13223500:
                case 13223538:
                case 13223539:
                case 13223540:
                case 13223600:
                case 13223638:
                case 13223639:
                case 13223640:
                case 13240000:
                case 13240038:
                case 13240039:
                case 13240040:
                case 13242800:
                case 13242838:
                case 13242840:
                case 13243300:
                case 13243338:
                case 13243339:
                case 13243340:
                case 13243438:
                case 13243440:
                case 13243600:
                case 13243638:
                case 14220000:
                case 14220038:
                case 14220039:
                case 14220040:
                case 14222500:
                case 14222538:
                case 14222540:
                case 14222800:
                case 14222838:
                case 14222839:
                case 14222840:
                case 14222841:
                case 14223100:
                case 14223138:
                case 14223139:
                case 14223140:
                case 14223200:
                case 14223239:
                case 14223240:
                case 14223300:
                case 14223338:
                case 14223339:
                case 14223340:
                case 14223400:
                case 14223440:
                case 14223500:
                case 14223538:
                case 14223539:
                case 14223540:
                case 14223600:
                case 14223638:
                case 14223639:
                case 14223640:
                case 14240000:
                case 14240038:
                case 14240039:
                case 14240040:
                case 14242800:
                case 14242838:
                case 14242839:
                case 14242840:
                case 14243300:
                case 14243338:
                case 14243339:
                case 14243340:
                case 14243400:
                case 14243438:
                case 14243440:
                case 14243600:
                case 14243638:
                case 15000000:
                case 15000038:
                case 15000039:
                case 15000040:
                case 15002500:
                case 15002538:
                case 15002539:
                case 15002540:
                case 15002700:
                case 15002738:
                case 15002739:
                case 15002740:
                case 15002741:
                case 15002900:
                case 15002938:
                case 15002939:
                case 15002940:
                case 15003100:
                case 15003138:
                case 15003139:
                case 15003140:
                case 15003200:
                case 15003238:
                case 15003239:
                case 15003240:
                case 15003300:
                case 15003339:
                case 15003340:
                case 15003400:
                case 15003439:
                case 15003440:
                case 15003500:
                case 15003539:
                case 15003540:
                case 15003600:
                case 15003639:
                case 15003640:
                case 15230000:
                case 15230038:
                case 15230039:
                case 15230040:
                case 15232500:
                case 15232539:
                case 15232600:
                case 15232638:
                case 15232939:
                case 15232940:
                case 15233000:
                case 15233040:
                case 15233300:
                case 15233339:
                case 15233340:
                case 15233400:
                case 15233439:
                case 15233500:
                case 15233540:
                case 15233600:
                case 15233639:
                case 15233640:
                case 16000000:
                case 16000038:
                case 16000039:
                case 16000040:
                case 16002500:
                case 16002538:
                case 16002540:
                case 16002700:
                case 16002739:
                case 16002740:
                case 16002900:
                case 16002938:
                case 16003100:
                case 16003138:
                case 16003139:
                case 16003140:
                case 16003200:
                case 16003238:
                case 16003239:
                case 16003240:
                case 16003300:
                case 16003338:
                case 16003339:
                case 16003340:
                case 16003400:
                case 16003438:
                case 16003439:
                case 16003440:
                case 16003500:
                case 16003538:
                case 16003539:
                case 16003540:
                case 16003600:
                case 16003638:
                case 16003639:
                case 16003640:
                case 16230000:
                case 16230038:
                case 16230039:
                case 16230040:
                case 16232600:
                case 16232640:
                case 16232939:
                case 16232940:
                case 16233000:
                case 16233038:
                case 16233300:
                case 16233338:
                case 16233339:
                case 16233340:
                case 16233400:
                case 16233438:
                case 16233439:
                case 16233500:
                case 16233538:
                case 16233539:
                case 16233540:
                case 16233600:
                case 16233638:
                case 16233639:
                case 16233640:
                case 17000000:
                case 17000038:
                case 17000039:
                case 17000040:
                case 17000041:
                case 17002500:
                case 17002538:
                case 17002539:
                case 17002540:
                case 17002700:
                case 17002738:
                case 17002739:
                case 17002740:
                case 17002900:
                case 17002939:
                case 17002940:
                case 17003038:
                case 17003100:
                case 17003138:
                case 17003139:
                case 17003140:
                case 17003200:
                case 17003238:
                case 17003239:
                case 17003240:
                case 17003300:
                case 17003339:
                case 17003340:
                case 17003400:
                case 17003438:
                case 17003439:
                case 17003440:
                case 17003441:
                case 17003500:
                case 17003539:
                case 17003540:
                case 17003541:
                case 17003600:
                case 17003638:
                case 17003639:
                case 17003640:
                case 17230000:
                case 17230038:
                case 17230039:
                case 17230040:
                case 17230041:
                case 17232500:
                case 17232539:
                case 17232600:
                case 17232640:
                case 17232900:
                case 17232939:
                case 17232940:
                case 17233039:
                case 17233040:
                case 17233300:
                case 17233340:
                case 17233439:
                case 17233440:
                case 17233500:
                case 17233539:
                case 18000040:
                case 18002739:
                case 18002740:
                case 18003138:
                case 18003139:
                case 18003140:
                case 18003238:
                case 18003240:
                case 18003338:
                case 18003339:
                case 18003400:
                case 18003438:
                case 18003439:
                case 18003440:
                case 18003539:
                case 18003540:
                case 18003600:
                case 18003638:
                case 18230038:
                case 18230039:
                case 18230040:
                case 18232640:
                case 18233039:
                case 18233040:
                case 18233339:
                case 18233440:
                case 18233638:
                case 18233639:
                case 19000000:
                case 19000039:
                case 19000040:
                case 19000041:
                case 19002500:
                case 19002538:
                case 19002738:
                case 19002740:
                case 19002900:
                case 19002939:
                case 19002940:
                case 19003038:
                case 19003100:
                case 19003138:
                case 19003139:
                case 19003140:
                case 19003200:
                case 19003239:
                case 19003240:
                case 19003300:
                case 19003338:
                case 19003339:
                case 19003340:
                case 19003439:
                case 19003500:
                case 19003540:
                case 19003600:
                case 19003640:
                case 19230000:
                case 19230038:
                case 19230039:
                case 19232600:
                case 19232638:
                case 19232639:
                case 19232640:
                case 19233000:
                case 19233039:
                case 19233040:
                case 19233300:
                case 19233339:
                case 19233340:
                case 19233400:
                case 19233440:
                case 19233600:
                case 19233639:
                case 19233640:
                case 20000000:
                case 20000038:
                case 20000039:
                case 20000040:
                case 20002500:
                case 20002740:
                case 20002900:
                case 20002938:
                case 20002939:
                case 20002940:
                case 20003100:
                case 20003138:
                case 20003139:
                case 20003140:
                case 20003240:
                case 20003300:
                case 20003338:
                case 20003339:
                case 20003340:
                case 20003400:
                case 20003438:
                case 20003500:
                case 20003538:
                case 20003600:
                case 20003638:
                case 20003640:
                case 20230000:
                case 20230038:
                case 20230040:
                case 20232600:
                case 20232638:
                case 20232640:
                case 20233000:
                case 20233039:
                case 20233040:
                case 20233300:
                case 20233340:
                case 20233400:
                case 20233438:
                case 20233439:
                case 20233440:
                case 20233600:
                case 20233638:
                case 21000000:
                case 21000039:
                case 21000040:
                case 21002500:
                case 21002539:
                case 21002540:
                case 21002740:
                case 21002900:
                case 21002940:
                case 21003100:
                case 21003139:
                case 21003140:
                case 21003200:
                case 21003239:
                case 21003240:
                case 21003300:
                case 21003339:
                case 21003340:
                case 21003400:
                case 21003500:
                case 21003539:
                case 21003540:
                case 21003600:
                case 21230000:
                case 21230038:
                case 21230040:
                case 21232600:
                case 21232639:
                case 21233000:
                case 21233038:
                case 21233039:
                case 21233040:
                case 21233300:
                case 21233340:
                case 21233400:
                case 21233439:
                case 21233600:
                case 21233639:
                case 21233640:
                case 00220000:
                case 00220038:
                case 00220039:
                case 00220040:
                case 00222500:
                case 00222538:
                case 00222539:
                case 00222540:
                case 00222600:
                case 00222800:
                case 00222838:
                case 00222839:
                case 00222840:
                case 00222841:
                case 00222938:
                case 00223100:
                case 00223138:
                case 00223139:
                case 00223140:
                case 00223200:
                case 00223238:
                case 00223239:
                case 00223240:
                case 00223300:
                case 00223338:
                case 00223339:
                case 00223340:
                case 00223400:
                case 00223438:
                case 00223439:
                case 00223440:
                case 00223500:
                case 00223538:
                case 00223539:
                case 00223540:
                case 00223600:
                case 00223638:
                case 00223639:
                case 00223640:
                case 00230000:
                case 00230038:
                case 00230039:
                case 00230040:
                case 00232500:
                case 00232538:
                case 00232539:
                case 00232540:
                case 00232541:
                case 00232600:
                case 00232639:
                case 00232640:
                case 00232900:
                case 00232940:
                case 00233000:
                case 00233038:
                case 00233039:
                case 00233040:
                case 00233300:
                case 00233338:
                case 00233339:
                case 00233340:
                case 00233400:
                case 00233438:
                case 00233439:
                case 00233440:
                case 00233500:
                case 00233538:
                case 00233539:
                case 00233540:
                case 00233600:
                case 00233639:
                case 00233640:
                case 00240000:
                case 00240038:
                case 00240039:
                case 00240040:
                case 00242800:
                case 00242840:
                case 00243300:
                case 00243338:
                case 00243339:
                case 00243340:
                case 00243400:
                case 00243438:
                case 00243439:
                case 00243440:
                case 00243600:
                case 00243639:
                case 00243640:
                case 00002500:
                case 00002538:
                case 00002540:
                case 00002541:
                case 00002638:
                case 00002700:
                case 00002738:
                case 00002739:
                case 00002740:
                case 00002741:
                case 00002840:
                case 00002900:
                case 00002938:
                case 00002939:
                case 00002940:
                case 00002941:
                case 00003100:
                case 00003138:
                case 00003139:
                case 00003140:
                case 00003141:
                case 00003200:
                case 00003239:
                case 00003240:
                case 00003241:
                case 00003300:
                case 00003339:
                case 00003340:
                case 00003400:
                case 00003440:
                case 00003500:
                case 00003538:
                case 00003540:
                case 00003700:
                case 00003738:
                case 00003739:
                case 00003740:
                    label1.Text = "有音有字";
                    break;

                case 01000000:
                case 01003038:
                case 01003338:
                case 01003438:
                case 01003538:
                case 01003638:
                case 01003639:
                case 01223138:
                case 01223338:
                case 01223438:
                case 01223439:
                case 01223638:
                case 02000000:
                case 02002539:
                case 02002939:
                case 02003039:
                case 02003339:
                case 02003439:
                case 02003440:
                case 02003539:
                case 02222838:
                case 02222840:
                case 02223339:
                case 02223639:
                case 03000000:
                case 03002900:
                case 03003000:
                case 03003200:
                case 03003240:
                case 03003300:
                case 03003439:
                case 03003500:
                case 03003540:
                case 03222838:
                case 03222839:
                case 03223200:
                case 03223238:
                case 03223239:
                case 03223300:
                case 03223400:
                case 03223440:
                case 03223600:
                case 03223639:
                case 03230000:
                case 03230038:
                case 04000000:
                case 04002600:
                case 04002639:
                case 04002640:
                case 04003200:
                case 04003238:
                case 04003240:
                case 04003639:
                case 05000000:
                case 05002700:
                case 05002739:
                case 05002740:
                case 05002938:
                case 05003000:
                case 05003038:
                case 05003040:
                case 05003138:
                case 05003238:
                case 05003338:
                case 05003538:
                case 05003638:
                case 05222839:
                case 05222840:
                case 05223138:
                case 05223238:
                case 05223239:
                case 05223240:
                case 05223338:
                case 05223638:
                case 05233038:
                case 05233039:
                case 05233338:
                case 05233438:
                case 05233638:
                case 06000000:
                case 06002538:
                case 06002700:
                case 06002738:
                case 06002739:
                case 06002939:
                case 06003239:
                case 06003600:
                case 06003639:
                case 06003640:
                case 06222838:
                case 06223340:
                case 06223640:
                case 06233339:
                case 06233340:
                case 06233439:
                case 07000000:
                case 07002500:
                case 07002738:
                case 07002739:
                case 07003000:
                case 07003038:
                case 07003400:
                case 07003438:
                case 07003439:
                case 07003539:
                case 07003540:
                case 07003600:
                case 07003639:
                case 07003640:
                case 07220000:
                case 07222838:
                case 07222839:
                case 07223300:
                case 07223500:
                case 07223539:
                case 07230000:
                case 07240000:
                case 07240038:
                case 07240040:
                case 08000000:
                case 08002738:
                case 08002739:
                case 08002900:
                case 08002939:
                case 08003200:
                case 08003300:
                case 08003600:
                case 08222838:
                case 08223300:
                case 08223400:
                case 08223500:
                case 08233300:
                case 08233600:
                case 09000000:
                case 09002539:
                case 09002938:
                case 09003000:
                case 09003038:
                case 09003138:
                case 09003238:
                case 09003338:
                case 09003538:
                case 09003638:
                case 09232538:
                case 09232938:
                case 09233038:
                case 09233338:
                case 09233400:
                case 09233438:
                case 09233538:
                case 09233638:
                case 10000000:
                case 10002538:
                case 10002938:
                case 10003138:
                case 10003238:
                case 10003338:
                case 10003400:
                case 10003438:
                case 10003638:
                case 10003639:
                case 10003640:
                case 10230038:
                case 10232538:
                case 10232600:
                case 10232639:
                case 10232900:
                case 10232938:
                case 10232939:
                case 10233338:
                case 10233340:
                case 10233438:
                case 10233539:
                case 10233638:
                case 11000000:
                case 11002539:
                case 11002540:
                case 11002739:
                case 11003038:
                case 11003039:
                case 11003400:
                case 11003539:
                case 11003639:
                case 11232539:
                case 11232600:
                case 11232900:
                case 11232939:
                case 12000000:
                case 12223238:
                case 12223338:
                case 12223438:
                case 12223538:
                case 12223638:
                case 12242839:
                case 12243338:
                case 12243438:
                case 12243439:
                case 12243600:
                case 12243638:
                case 12243640:
                case 13000000:
                case 13222538:
                case 13223240:
                case 13242839:
                case 13243400:
                case 13243439:
                case 13243639:
                case 13243640:
                case 14000000:
                case 14222539:
                case 14223238:
                case 14223438:
                case 14223439:
                case 14243439:
                case 14243639:
                case 14243640:
                case 15003338:
                case 15003438:
                case 15003538:
                case 15003638:
                case 15232538:
                case 15232540:
                case 15232639:
                case 15232640:
                case 15232900:
                case 15232938:
                case 15233038:
                case 15233039:
                case 15233338:
                case 15233438:
                case 15233440:
                case 15233538:
                case 15233539:
                case 15233638:
                case 16002539:
                case 16002738:
                case 16002939:
                case 16002940:
                case 16232638:
                case 16232639:
                case 16232900:
                case 16232938:
                case 16233039:
                case 16233040:
                case 16233440:
                case 17002938:
                case 17003000:
                case 17003039:
                case 17003040:
                case 17003338:
                case 17003538:
                case 17232538:
                case 17232540:
                case 17232638:
                case 17232639:
                case 17232938:
                case 17233000:
                case 17233038:
                case 17233338:
                case 17233339:
                case 17233400:
                case 17233438:
                case 17233538:
                case 17233540:
                case 18000000:
                case 18000038:
                case 18000039:
                case 18002700:
                case 18002738:
                case 18003100:
                case 18003200:
                case 18003239:
                case 18003300:
                case 18003340:
                case 18003500:
                case 18003538:
                case 18003639:
                case 18003640:
                case 18230000:
                case 18232600:
                case 18232638:
                case 18232639:
                case 18233000:
                case 18233038:
                case 18233300:
                case 18233338:
                case 18233340:
                case 18233400:
                case 18233438:
                case 18233439:
                case 18233600:
                case 18233640:
                case 19000038:
                case 19002539:
                case 19002540:
                case 19002700:
                case 19002739:
                case 19002938:
                case 19003000:
                case 19003039:
                case 19003040:
                case 19003238:
                case 19003400:
                case 19003438:
                case 19003440:
                case 19003538:
                case 19003539:
                case 19003638:
                case 19003639:
                case 19230040:
                case 19233038:
                case 19233338:
                case 19233438:
                case 19233439:
                case 19233638:
                case 20002538:
                case 20002539:
                case 20002540:
                case 20002700:
                case 20002738:
                case 20002739:
                case 20003200:
                case 20003238:
                case 20003239:
                case 20003439:
                case 20003440:
                case 20003539:
                case 20003540:
                case 20003639:
                case 20230039:
                case 20232639:
                case 20233038:
                case 20233338:
                case 20233339:
                case 20233639:
                case 20233640:
                case 21000038:
                case 21002538:
                case 21002700:
                case 21002738:
                case 21002739:
                case 21002938:
                case 21002939:
                case 21003138:
                case 21003238:
                case 21003338:
                case 21003438:
                case 21003439:
                case 21003440:
                case 21003538:
                case 21003638:
                case 21003639:
                case 21003640:
                case 21230039:
                case 21232638:
                case 21232640:
                case 21233338:
                case 21233339:
                case 21233438:
                case 21233440:
                case 21233638:
                case 00222638:
                case 00222639:
                case 00222640:
                case 00222900:
                case 00222939:
                case 00222940:
                case 00232638:
                case 00232938:
                case 00232939:
                case 00233638:
                case 00242838:
                case 00242839:
                case 00243638:
                case 00002539:
                case 00002600:
                case 00002639:
                case 00002640:
                case 00002800:
                case 00002838:
                case 00002839:
                case 00003000:
                case 00003038:
                case 00003039:
                case 00003238:
                case 00003338:
                case 00003438:
                case 00003439:
                case 00003539:
                case 00003600:
                    label1.Text = "有音無字";
                    break;

                default:
                    label1.Text = "無音無字";
                    break;
            }
        }

        private int top;
        private int middle;
        private int bottom;
        private int tone;
        private int type;
    }
}