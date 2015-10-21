using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_for_debate_competition
{
    public partial class Window : Form
    {
        int stage;
        const int lastStage = 7;
        int clickNum;
        TimeSpan totalStartTime;
        TimeSpan prosQuesStartTime;
        TimeSpan consAnswStartTime;
        TimeSpan totalTime;
        TimeSpan prosQuesTime;
        TimeSpan consAnswTime;
        TimeSpan totalTimeRemaining;
        TimeSpan prosQuesTimeRemaining;
        TimeSpan consAnswTimeRemaining;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            stage = 0;
            initializeControls();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (stage > 0)
                stage--;
            initializeControls();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (stage < lastStage)
                stage++;
            topic.ReadOnly = true;
            topicOfProposition.ReadOnly = true;
            topicOfOpposition.ReadOnly = true;
            initializeControls();
            if (stage == lastStage)
                exitButton.Visible = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            topic.ReadOnly = true;
            topicOfProposition.ReadOnly = true;
            topicOfOpposition.ReadOnly = true;
            switch (stage)
            {
                case 0:
                    stage++;
                    initializeControls();
                    break;
                default:
                    break;
            }
        }

        private void prosQuesButton_Click(object sender, EventArgs e)
        {
            prosQuesStartTime = new TimeSpan(DateTime.Now.Ticks);
            consAnswTimeIndicator.ForeColor = Color.White;
            prosQuesTimer.Start();
            consAnswTimer.Stop();
            switch (stage)
            {
                case 1:
                case 3:
                case 5:
                case 6:
                    prosQuesTime = prosQuesTimeRemaining;
                    break;
                default:
                    consAnswTimeIndicator.ForeColor = Color.White;
                    consAnswTimeIndicator.Text = consAnswTime.ToString();
                    break;
            }
            if (clickNum == 0)
            {
                totalTime = totalTimeRemaining;
                totalStartTime = new TimeSpan(DateTime.Now.Ticks);
                totalTimer.Start();
            }
            clickNum++;
            refreshPersonIndicator("blue");
        }

        private void consAnswButton_Click(object sender, EventArgs e)
        {
            consAnswStartTime = new TimeSpan(DateTime.Now.Ticks);
            prosQuesTimer.Stop();
            consAnswTimer.Start();
            switch (stage)
            {
                case 1:
                case 3:
                case 5:
                case 6:
                    consAnswTime = consAnswTimeRemaining;
                    break;
                default:
                    prosQuesTimeIndicator.ForeColor = Color.White;
                    prosQuesTimeIndicator.Text = prosQuesTime.ToString();
                    break;
            }
            if (clickNum == 0)
            {
                totalTime = totalTimeRemaining;
                totalStartTime = new TimeSpan(DateTime.Now.Ticks);
                totalTimer.Start();
            }
            clickNum++;
            refreshPersonIndicator("red");
        }
        
        private void prosQuesTimer_Tick(object sender, EventArgs e)
        {
            timeChanger(prosQuesTimer, prosQuesTimeIndicator, prosQuesTime, prosQuesStartTime, ref prosQuesTimeRemaining);
        }

        private void consAnswTimer_Tick(object sender, EventArgs e)
        {
            timeChanger(consAnswTimer, consAnswTimeIndicator, consAnswTime, consAnswStartTime, ref consAnswTimeRemaining);
        }
        
        private void totalTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan nullTimeSpan = new TimeSpan();
            timeChanger(totalTimer, totalTimeIndicator, totalTime, totalStartTime, ref nullTimeSpan);
        }

        private void timeChanger(Timer timer, Label indicator, TimeSpan totalTime, TimeSpan startTime, ref TimeSpan timeRemaining)
        {
            TimeSpan timeNow = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan timePassed = timeNow - startTime;
            timeRemaining = totalTime - timePassed;
            if (timeRemaining - new TimeSpan(0, 0, 1) > TimeSpan.Zero)
            {
                if (timeRemaining - new TimeSpan(0, 0, 11) > TimeSpan.Zero)
                {
                    indicator.ForeColor = Color.White;
                }
                else
                {
                    indicator.ForeColor = Color.Orange;
                }
            }
            else
            {
                
                totalTimer.Stop();
                timer.Stop();
                TimeSpan totalTimePassed = timeNow - totalStartTime;
                totalTimeRemaining = this.totalTime - totalTimePassed;
                clickNum = 0;
                indicator.ForeColor = Color.Red;
            }
            string hours = timeRemaining.Hours.ToString();
            string minutes = timeRemaining.Minutes.ToString();
            string seconds = timeRemaining.Seconds.ToString();
            if (hours.Length < 2) hours = "0" + hours;
            if (minutes.Length < 2) minutes = "0" + minutes;
            if (seconds.Length < 2) seconds = "0" + seconds;
            indicator.Text = hours + ':' + minutes + ':' + seconds;
        }

        private void refreshPersonIndicator(string color)
        {
            switch (stage)
            {
                case 0:
                case lastStage:
                    for (int i = 1; i <= 8; i++)
                    {
                        personIndicator(i).Image = whiteImageOfperson(i);
                    }
                    break;
                default:
                    for (int i = 1; i <= 8; i++)
                    {
                        personIndicator(i).Image = darkColorImageOfperson(i);
                    }
                    break;
            }
            switch (stage)
            {
                case 1:
                    switch (color)
                    {
                        case "blue":
                                personIndicator(1).Image = lightColorImageOfperson(1);
                            break;
                        case "red":
                                personIndicator(5).Image = lightColorImageOfperson(5);
                            break;
                        default:
                            break;
                    }
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                    switch (color)
                    {
                        case "blue":
                            for (int i = 1; i <= 4; i++)
                            {
                                personIndicator(i).Image = lightColorImageOfperson(i);
                            }
                            break;
                        case "red":
                            for (int i = 5; i <= 8; i++)
                            {
                                personIndicator(i).Image = lightColorImageOfperson(i);
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private string stageName()
        {
            switch (stage)
            {
                case 0:
                    return "准备";
                case 1:
                    return "立论阶段";
                case 2:
                    return "盘问阶段";
                case 3:
                    return "驳论阶段";
                case 4:
                    return "双方攻辩";
                case 5:
                    return "自由辩论";
                case 6:
                    return "总结陈词";
                case 7:
                    return "结束";
                default:
                    return "?";
            }
        }

        private void initializeControls()
        {
            totalTimer.Stop();
            prosQuesTimer.Stop();
            consAnswTimer.Stop();

            prosQuesTimeIndicator.ForeColor = Color.White;
            consAnswTimeIndicator.ForeColor = Color.White;
            totalTimeIndicator.ForeColor = Color.White;

            if (stage == 0 || stage == lastStage)
                stageLabel.Visible = false;
            else
                stageLabel.Visible = true;
            stageLabel.Text = "STAGE " + stage;

            stageIndicator.Text = stageName();
            clickNum = 0;

            refreshPersonIndicator(null);

            switch (stage)
            {
                case 0:
                    setStatus(false, false, true, "", "", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0));
                    break;
                case 1:
                    setStatus(false, true, false, "PROPOSITION", "OPPOSITION", new TimeSpan(0, 0, 0), new TimeSpan(0, 3, 0), new TimeSpan(0, 3, 0));
                    break;
                case 2:
                    setStatus(true, true, false, "QUESTION", "ANSWER", new TimeSpan(0, 3, 0), new TimeSpan(0, 0, 20), new TimeSpan(0, 0, 30));
                    break;
                case 3:
                    setStatus(false, true, false, "PROPOSITION", "OPPOSITION", new TimeSpan(0, 0, 0), new TimeSpan(0, 1, 30), new TimeSpan(0, 1, 30));
                    break;
                case 4:
                    setStatus(true, true, false, "PROPOSITION", "OPPOSITION", new TimeSpan(0, 3, 0), new TimeSpan(0, 0, 20), new TimeSpan(0, 0, 20));
                    break;
                case 5:
                    setStatus(false, true, false, "PROPOSITION", "OPPOSITION", new TimeSpan(0, 0, 0), new TimeSpan(0, 4, 0), new TimeSpan(0, 4, 0));
                    break;
                case 6:
                    setStatus(false, true, false, "PROPOSITION", "OPPOSITION", new TimeSpan(0, 0, 0), new TimeSpan(0, 4, 0), new TimeSpan(0, 4, 0));
                    break;
                case 7:
                    setStatus(false, false, true, "", "", new TimeSpan(0, 0, 0), new TimeSpan(0, 4, 0), new TimeSpan(0, 4, 0));
                    break;
                default:
                    setStatus(false, false, false, "", "", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0));
                    break;
            }

            totalTimeRemaining = totalTime;
            prosQuesTimeRemaining = prosQuesTime;
            consAnswTimeRemaining = consAnswTime;
        }

        private void setStatus(bool     totalTimerVisible,
                               bool     pOQAVisible,
                               bool     startExitButtonVisible,
                               string   text1,
                               string   text2,
                               TimeSpan totalTime,
                               TimeSpan prosQuesTime,
                               TimeSpan consAnswTime)
        {
            totalTimeIndicator.Visible = totalTimerVisible;
            totalTimerLable.Visible = totalTimerVisible;

            prosQuesButton.Visible = pOQAVisible;
            prosQuesLable.Visible = pOQAVisible;
            prosQuesTimeIndicator.Visible = pOQAVisible;
            consAnswButton.Visible = pOQAVisible;
            consAnswLabel.Visible = pOQAVisible;
            consAnswTimeIndicator.Visible = pOQAVisible;

            startButton.Visible = startExitButtonVisible;
            exitButton.Visible = startExitButtonVisible;

            prosQuesLable.Text = text1;
            prosQuesButton.Text = text1;
            consAnswLabel.Text = text2;
            consAnswButton.Text = text2;

            totalTimeIndicator.Text = totalTime.ToString();
            prosQuesTimeIndicator.Text = prosQuesTime.ToString();
            consAnswTimeIndicator.Text = consAnswTime.ToString();

            this.totalTime = totalTime;
            this.prosQuesTime = prosQuesTime;
            this.consAnswTime = consAnswTime;
        }

        private Image whiteImageOfperson(int personNum)
        {
            switch (personNum)
            {
                case 1:
                    return Properties.Resources.CircleWhite__8_;
                case 2:
                    return Properties.Resources.CircleWhite__7_;
                case 3:
                    return Properties.Resources.CircleWhite__6_;
                case 4:
                    return Properties.Resources.CircleWhite__5_;
                case 5:
                    return Properties.Resources.CircleWhite__1_;
                case 6:
                    return Properties.Resources.CircleWhite__2_;
                case 7:
                    return Properties.Resources.CircleWhite__3_;
                case 8:
                    return Properties.Resources.CircleWhite__4_;
                default:
                    return null;
            }
        }

        private Image lightColorImageOfperson(int personNum)
        {
            switch (personNum)
            {
                case 1:
                    return Properties.Resources.CircleLBlue__4_;
                case 2:
                    return Properties.Resources.CircleLBlue__3_;
                case 3:
                    return Properties.Resources.CircleLBlue__2_;
                case 4:
                    return Properties.Resources.CircleLBlue__1_;
                case 5:
                    return Properties.Resources.CircleLRed__1_;
                case 6:
                    return Properties.Resources.CircleLRed__2_;
                case 7:
                    return Properties.Resources.CircleLRed__3_;
                case 8:
                    return Properties.Resources.CircleLRed__4_;
                default:
                    return null;
            }
        }

        private Image darkColorImageOfperson(int personNum)
        {
            switch (personNum)
            {
                case 1:
                    return Properties.Resources.CircleDBlue__4_;
                case 2:
                    return Properties.Resources.CircleDBlue__3_;
                case 3:
                    return Properties.Resources.CircleDBlue__2_;
                case 4:
                    return Properties.Resources.CircleDBlue__1_;
                case 5:
                    return Properties.Resources.CircleDRed__1_;
                case 6:
                    return Properties.Resources.CircleDRed__2_;
                case 7:
                    return Properties.Resources.CircleDRed__3_;
                case 8:
                    return Properties.Resources.CircleDRed__4_;
                default:
                    return null;
            }
        }

        private PictureBox personIndicator(int num)
        {
            if (num > 0 && num <= 8)
                return (PictureBox)Controls.Find("personIndicator" + num, false)[0];
            else
                return null;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            initializeControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeControls();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer for debate competition\n\n- BISTU Student Union - Department of Information Technology\n- March 17th, 2013");
        }

        private void startButton_VisibleChanged(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                startButton.Visible = false;
            }
        }
    }
}