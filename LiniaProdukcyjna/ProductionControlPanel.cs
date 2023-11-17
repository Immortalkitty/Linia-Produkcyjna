using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LiniaProdukcyjna
{
    public partial class ProductionControlPanel : Form
    {

        public ProductionControlPanel()
        {
            InitializeComponent();

        }
        private void ProductionControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerAreUAlive_Tick(object sender, EventArgs e)
        {
            timerCount++;
            if (timerCount >= 60)
            {
                Point windowLocation=this.Location;
                AreUAliveForm areualivewindow= new AreUAliveForm(this);
                areualivewindow.Show();

                areualivewindow.Location = windowLocation;
                
                timerCount = 0;
            }

        }

        private void controlsChangedTimer_Tick(object sender, EventArgs e)
        {
            int powerUsage = (int)cpuCounter.NextValue();
            double energy = (velocityTrackBar.Value * 0.4 + (double)temperatureNumericUpDown.Value * 0.5 + fansOnNumber * 30) / 2.8;

            string info = "";
            info += "Temperatura pieca: " + temperatureNumericUpDown.Value + " C\n";
            info += "Liczba włączonych wentylatorów: " + fansOnNumber + "\n";
            info += "Szybkość przesuwu taśmy: " + velocityTrackBar.Value + " %\n";
            info += "Porcja ciasta na jedno ciastko: " + sizeTrackBar.Value + " g\n";
            info += "Poziom użwanej mocy procesora jednostki sterującej: " + powerUsage + " %\n";
            info += "Zużycie energii: " + (int)energy + " %";
            infoRichTextBox.Text = info;

            nextMalfunctionCounter++;
            if (nextMalfunctionCounter > 100)
            {
                nextMalfunctionCounter = 0;
                Random rnd = new Random();
                nextMalfunctionTime = rnd.Next(1, 100);
            }

            if (nextMalfunctionCounter == nextMalfunctionTime)
            {
                malfunctionPerform();
            }

            if (isMalfunctionCritical() == "")
            {
                malfunctionWarningRichTextBox.ForeColor = Color.Green;
                malfunctionWarningRichTextBox.Text = "Brak awarii. ";
                alarm.Stop();
                isAlarmOn = false;
            }
            else
            {
                malfunctionWarningRichTextBox.ForeColor = Color.Red;
                malfunctionWarningRichTextBox.Text = isMalfunctionCritical();
                if (!isAlarmOn)
                {
                    alarm.PlayLooping();
                    isAlarmOn = true;

                }

            }




        }

        private void malfunctionPerform()
        {
            int fanMalfunctioningNumber = 0;
            Random rnd1 = new Random();
            fanMalfunctioningNumber = rnd1.Next(1, 3);

            switch (fanMalfunctioningNumber)
            {
                case 1:
                    fanOneOnCheckBox.Checked = !fanOneOnCheckBox.Checked;
                    break;
                case 2:
                    fanTwoOnCheckBox.Checked = !fanTwoOnCheckBox.Checked;
                    break;
                case 3:
                    fanThreeOnCheckBox.Checked = !fanThreeOnCheckBox.Checked;
                    break;
            }

            int changedTemperature = (int)(temperatureNumericUpDown.Value + rnd1.Next(-40, 40));
            if (150 <= changedTemperature && changedTemperature <= 300) temperatureNumericUpDown.Value = changedTemperature;

            int changedVelocity = (int)(velocityTrackBar.Value + rnd1.Next(-20, 20));
            if (changedVelocity <= 100 && changedVelocity >= 10) velocityTrackBar.Value = changedVelocity;

            int changedSize = (int)(sizeTrackBar.Value + rnd1.Next(-20, 20));
            if (changedSize <= 100 && changedSize >= 10) sizeTrackBar.Value = changedSize;

        }

        private string isMalfunctionCritical()
        {
            string malfunctionInfo = "";
            double energy = (velocityTrackBar.Value * 0.4 + (double)temperatureNumericUpDown.Value * 0.5 + fansOnNumber * 30) / 2.8;
            if (energy > 90)
            {
                malfunctionInfo += "AWARIA!!!\nZa duże zużycie energii, zmniejsz prędkośc taśmy, temperaturę pieca lub liczbę włączonych wiatraków!\n";
            }

            if (temperatureNumericUpDown.Value <= 220 && velocityTrackBar.Value >= 60)
            {
                malfunctionInfo += "AWARIA!!!\nCiastka niedopieczone. Zmniejsz prędkość taśmy lub zwiększ temperaturę pieca!\n";
            }
            if (temperatureNumericUpDown.Value >= 270 && velocityTrackBar.Value <= 80)
            {
                malfunctionInfo += "AWARIA!!!\nCiastka spalone. Zwiększ prędkość taśmy lub zmniejsz temperaturę pieca!\n";
            }

            if (temperatureNumericUpDown.Value < 175)
            {
                malfunctionInfo += "AWARIA!!!\nZa niska temperatura pieca!\n";
            }
            if (sizeTrackBar.Value < 30)
            {
                malfunctionInfo += "AWARIA!!!\nZa małe ciastka!\n";
            }
            if (sizeTrackBar.Value > 75)
            {
                malfunctionInfo += "AWARIA!!!\nZa duże ciastka!\n";
            }

            return malfunctionInfo;

        }



        private void fanTwoOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fanTwoActive = !fanTwoActive;

            if (fanTwoActive)
            {
                fansOnNumber++;
            }
            else
            {
                fansOnNumber--;
            }
        }

        private void fanOneOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fanOneActive = !fanOneActive;

            if (fanOneActive)
            {
                fansOnNumber++;
            }
            else
            {
                fansOnNumber--;
            }
        }

        private void fanThreeOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fanThreeActive = !fanThreeActive;

            if (fanThreeActive)
            {
                fansOnNumber++;
            }
            else
            {
                fansOnNumber--;
            }
        }

        private void timeToFixTimer_Tick(object sender, EventArgs e)
        {

            if (!isMalfunctionCritical().Equals(""))
            {
                if (malfunctionTimeCounter <= 10 && malfunctionTimeCounter >= 0)
                {
                    timeForFixingLabel.Visible = true;
                    timeForFixingLabel.Text = "Czas na naprawienie awarii: " + malfunctionTimeCounter;
                }
                if(malfunctionTimeCounter==-2)
                {
                    MessageBox.Show("Linia produkcyjna uległa zniszczeniu. Program zakończy swoje działanie po wciśnięciu 'OK'.");
                    this.Close();
                }
               
                malfunctionTimeCounter--;

            }
            else
            {
                malfunctionTimeCounter = 10;
                timeForFixingLabel.Visible = false;
            }

        }
    }
}
