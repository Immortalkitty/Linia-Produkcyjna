using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiniaProdukcyjna
{
    public partial class AreUAliveForm : Form
    {
        public AreUAliveForm()
        {
            InitializeComponent();
        }

        public AreUAliveForm(ProductionControlPanel parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;

        }


        private void timeToConfirmTimer_Tick(object sender, EventArgs e)
        {
            timeLeftToConfirmCounter--;
            timeToConfirmLabel.Text = timeLeftToConfirmCounter.ToString();
            if (timeLeftToConfirmCounter == 0)
            {
                if (!isAlarmOn)
                {
                    alarm.PlayLooping();
                    isAlarmOn = true;

                }

            }
            if (isAlarmOn && timeLeftToConfirmCounter == -3)
            {

                Application.Exit();

            }

        }

        private void iAmAliveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
