using System.Diagnostics;
using System.Media;

namespace LiniaProdukcyjna
{
    partial class ProductionControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private int cpuDisplayCounter = 0;
        private int timerCount = 0;
        private bool fanOneActive = false;
        private bool fanTwoActive = false;
        private bool fanThreeActive = false;
        private int fansOnNumber = 0;
        private int nextMalfunctionCounter = 0;
        private int nextMalfunctionTime = 0;
        private int malfunctionTimeCounter = 10;
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
            timerAreUAlive = new System.Windows.Forms.Timer(components);
            titleLabel = new Label();
            temperatureNumericUpDown = new NumericUpDown();
            temperatureLabel = new Label();
            velocityTrackBar = new TrackBar();
            velocityLabel = new Label();
            sizeTrackBar = new TrackBar();
            sizeLabel = new Label();
            infoRichTextBox = new RichTextBox();
            malfunctionWarningRichTextBox = new RichTextBox();
            controlsChangedTimer = new System.Windows.Forms.Timer(components);
            fanOneOnCheckBox = new CheckBox();
            fanTwoOnCheckBox = new CheckBox();
            fanThreeOnCheckBox = new CheckBox();
            timeForFixingLabel = new Label();
            timeToFixTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)temperatureNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)velocityTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // timerAreUAlive
            // 
            timerAreUAlive.Enabled = true;
            timerAreUAlive.Interval = 1000;
            timerAreUAlive.Tick += timerAreUAlive_Tick;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(220, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(436, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Panel kontroli procesu produkcji ciastek";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // temperatureNumericUpDown
            // 
            temperatureNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            temperatureNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            temperatureNumericUpDown.Location = new Point(200, 211);
            temperatureNumericUpDown.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            temperatureNumericUpDown.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            temperatureNumericUpDown.Name = "temperatureNumericUpDown";
            temperatureNumericUpDown.Size = new Size(88, 29);
            temperatureNumericUpDown.TabIndex = 1;
            temperatureNumericUpDown.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            temperatureLabel.Location = new Point(170, 259);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(137, 21);
            temperatureLabel.TabIndex = 2;
            temperatureLabel.Text = "Temperatura Pieca";
            // 
            // velocityTrackBar
            // 
            velocityTrackBar.Location = new Point(381, 211);
            velocityTrackBar.Maximum = 100;
            velocityTrackBar.Minimum = 10;
            velocityTrackBar.Name = "velocityTrackBar";
            velocityTrackBar.Size = new Size(104, 45);
            velocityTrackBar.SmallChange = 10;
            velocityTrackBar.TabIndex = 3;
            velocityTrackBar.Value = 50;
            // 
            // velocityLabel
            // 
            velocityLabel.AutoSize = true;
            velocityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            velocityLabel.Location = new Point(342, 259);
            velocityLabel.Name = "velocityLabel";
            velocityLabel.Size = new Size(191, 21);
            velocityLabel.TabIndex = 4;
            velocityLabel.Text = "Szybkość przesuwu taśmy";
            // 
            // sizeTrackBar
            // 
            sizeTrackBar.Location = new Point(602, 211);
            sizeTrackBar.Maximum = 100;
            sizeTrackBar.Minimum = 10;
            sizeTrackBar.Name = "sizeTrackBar";
            sizeTrackBar.Size = new Size(104, 45);
            sizeTrackBar.SmallChange = 10;
            sizeTrackBar.TabIndex = 5;
            sizeTrackBar.Value = 50;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(564, 259);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(168, 21);
            sizeLabel.TabIndex = 6;
            sizeLabel.Text = "Porcja ciasta na ciastko";
            // 
            // infoRichTextBox
            // 
            infoRichTextBox.BackColor = SystemColors.InfoText;
            infoRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoRichTextBox.ForeColor = SystemColors.Info;
            infoRichTextBox.Location = new Point(245, 304);
            infoRichTextBox.Name = "infoRichTextBox";
            infoRichTextBox.ReadOnly = true;
            infoRichTextBox.Size = new Size(376, 215);
            infoRichTextBox.TabIndex = 10;
            infoRichTextBox.Text = "";
            // 
            // malfunctionWarningRichTextBox
            // 
            malfunctionWarningRichTextBox.BackColor = SystemColors.InfoText;
            malfunctionWarningRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            malfunctionWarningRichTextBox.ForeColor = Color.Red;
            malfunctionWarningRichTextBox.Location = new Point(126, 57);
            malfunctionWarningRichTextBox.Name = "malfunctionWarningRichTextBox";
            malfunctionWarningRichTextBox.ReadOnly = true;
            malfunctionWarningRichTextBox.Size = new Size(638, 114);
            malfunctionWarningRichTextBox.TabIndex = 11;
            malfunctionWarningRichTextBox.Text = "";
            // 
            // controlsChangedTimer
            // 
            controlsChangedTimer.Enabled = true;
            controlsChangedTimer.Tick += controlsChangedTimer_Tick;
            // 
            // fanOneOnCheckBox
            // 
            fanOneOnCheckBox.AutoSize = true;
            fanOneOnCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fanOneOnCheckBox.Location = new Point(126, 306);
            fanOneOnCheckBox.Name = "fanOneOnCheckBox";
            fanOneOnCheckBox.Size = new Size(96, 25);
            fanOneOnCheckBox.TabIndex = 12;
            fanOneOnCheckBox.Text = "Wiatrak 1";
            fanOneOnCheckBox.UseVisualStyleBackColor = true;
            fanOneOnCheckBox.CheckedChanged += fanOneOnCheckBox_CheckedChanged;
            // 
            // fanTwoOnCheckBox
            // 
            fanTwoOnCheckBox.AutoSize = true;
            fanTwoOnCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fanTwoOnCheckBox.Location = new Point(126, 352);
            fanTwoOnCheckBox.Name = "fanTwoOnCheckBox";
            fanTwoOnCheckBox.Size = new Size(96, 25);
            fanTwoOnCheckBox.TabIndex = 13;
            fanTwoOnCheckBox.Text = "Wiatrak 2";
            fanTwoOnCheckBox.UseVisualStyleBackColor = true;
            fanTwoOnCheckBox.CheckedChanged += fanTwoOnCheckBox_CheckedChanged;
            // 
            // fanThreeOnCheckBox
            // 
            fanThreeOnCheckBox.AutoSize = true;
            fanThreeOnCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fanThreeOnCheckBox.Location = new Point(126, 396);
            fanThreeOnCheckBox.Name = "fanThreeOnCheckBox";
            fanThreeOnCheckBox.Size = new Size(96, 25);
            fanThreeOnCheckBox.TabIndex = 14;
            fanThreeOnCheckBox.Text = "Wiatrak 3";
            fanThreeOnCheckBox.UseVisualStyleBackColor = true;
            fanThreeOnCheckBox.CheckedChanged += fanThreeOnCheckBox_CheckedChanged;
            // 
            // timeForFixingLabel
            // 
            timeForFixingLabel.AutoSize = true;
            timeForFixingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timeForFixingLabel.ForeColor = Color.Red;
            timeForFixingLabel.Location = new Point(126, 174);
            timeForFixingLabel.Name = "timeForFixingLabel";
            timeForFixingLabel.Size = new Size(251, 25);
            timeForFixingLabel.TabIndex = 15;
            timeForFixingLabel.Text = "Czas na naprawienie awarii: ";
            timeForFixingLabel.Visible = false;
            // 
            // timeToFixTimer
            // 
            timeToFixTimer.Enabled = true;
            timeToFixTimer.Interval = 1000;
            timeToFixTimer.Tick += timeToFixTimer_Tick;
            // 
            // ProductionControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(880, 531);
            Controls.Add(timeForFixingLabel);
            Controls.Add(fanThreeOnCheckBox);
            Controls.Add(fanTwoOnCheckBox);
            Controls.Add(fanOneOnCheckBox);
            Controls.Add(malfunctionWarningRichTextBox);
            Controls.Add(infoRichTextBox);
            Controls.Add(sizeLabel);
            Controls.Add(sizeTrackBar);
            Controls.Add(velocityLabel);
            Controls.Add(velocityTrackBar);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureNumericUpDown);
            Controls.Add(titleLabel);
            Name = "ProductionControlPanel";
            Text = "Panel kontrolny";
            FormClosed += ProductionControlPanel_FormClosed;
            ((System.ComponentModel.ISupportInitialize)temperatureNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)velocityTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerAreUAlive;
        private Label titleLabel;
        private NumericUpDown temperatureNumericUpDown;
        private Label temperatureLabel;
        private TrackBar velocityTrackBar;
        private Label velocityLabel;
        private TrackBar sizeTrackBar;
        private Label sizeLabel;
        private RichTextBox infoRichTextBox;
        private RichTextBox malfunctionWarningRichTextBox;
        private System.Windows.Forms.Timer controlsChangedTimer;
        private CheckBox fanOneOnCheckBox;
        private CheckBox fanTwoOnCheckBox;
        private CheckBox fanThreeOnCheckBox;
        private Label timeForFixingLabel;
        private System.Windows.Forms.Timer timeToFixTimer;
    }
}