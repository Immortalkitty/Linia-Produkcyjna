
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Media;
namespace LiniaProdukcyjna
{
    partial class AreUAliveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int timeLeftToConfirmCounter = 15;
        private ProductionControlPanel parentWindow;
        private bool isAlarmOn = false;
        SoundPlayer alarm = new SoundPlayer(LiniaProdukcyjna.Properties.Resources.alarm);

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            iAmAliveButton = new Button();
            timeToConfirmLabel = new Label();
            timeToConfirmTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 50);
            label1.TabIndex = 0;
            label1.Text = "Czy jesteś obecny? Gdy nie potwierdzisz obecności przed upływem czasu zostaniesz wylogowany.";
            // 
            // iAmAliveButton
            // 
            iAmAliveButton.BackColor = Color.YellowGreen;
            iAmAliveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iAmAliveButton.Location = new Point(81, 149);
            iAmAliveButton.Name = "iAmAliveButton";
            iAmAliveButton.Size = new Size(163, 68);
            iAmAliveButton.TabIndex = 1;
            iAmAliveButton.Text = "Aktywny";
            iAmAliveButton.UseVisualStyleBackColor = false;
            iAmAliveButton.Click += iAmAliveButton_Click;
            // 
            // timeToConfirmLabel
            // 
            timeToConfirmLabel.AutoSize = true;
            timeToConfirmLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeToConfirmLabel.ForeColor = Color.Red;
            timeToConfirmLabel.Location = new Point(148, 86);
            timeToConfirmLabel.Name = "timeToConfirmLabel";
            timeToConfirmLabel.Size = new Size(49, 40);
            timeToConfirmLabel.TabIndex = 2;
            timeToConfirmLabel.Text = "15";
            // 
            // timeToConfirmTimer
            // 
            timeToConfirmTimer.Enabled = true;
            timeToConfirmTimer.Interval = 1000;
            timeToConfirmTimer.Tick += timeToConfirmTimer_Tick;
            // 
            // AreUAliveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 250);
            Controls.Add(timeToConfirmLabel);
            Controls.Add(iAmAliveButton);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AreUAliveForm";
            Text = "Sprawdzenie obecności";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button iAmAliveButton;
        private Label timeToConfirmLabel;
        private System.Windows.Forms.Timer timeToConfirmTimer;
    }
}