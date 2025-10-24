using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacrosApp.Gui
{
    internal partial class MainForm
    {
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBox = new TextBox();
            labelMousePosition = new Label();
            buttonStop = new Button();
            buttonStart = new Button();
            uiStep1CountTextBox = new TextBox();
            uiStep2CountTextBox = new TextBox();
            uiStep1ShiftCountTextBox = new TextBox();
            uiStep2ShiftCountTextBox = new TextBox();
            twoStepWithShiftRadioButton = new RadioButton();
            uiKuricaKormRadioButton = new RadioButton();
            uiKuricaKormStep2CountTextBox = new TextBox();
            uiKuricaKormStep1CountTextBox = new TextBox();
            uiDelayTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            uiClassicStepCount = new TextBox();
            uiShiftEveryTextBox = new TextBox();
            label9 = new Label();
            uiClassicRadioButton = new RadioButton();
            mouseMoveClickDelayTextBox = new TextBox();
            label10 = new Label();
            uiMacrosHistoryControl = new MacrosHistoryControl();
            uiDerevoRadioButton = new RadioButton();
            uiKuricaCustomRadioButton = new RadioButton();
            uiKuricaKormShiftTextBox = new TextBox();
            label11 = new Label();
            buttonKeys = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Courier New", 11F, FontStyle.Regular, GraphicsUnit.World);
            textBox.Location = new Point(5, 378);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(736, 240);
            textBox.TabIndex = 3;
            // 
            // labelMousePosition
            // 
            labelMousePosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMousePosition.BorderStyle = BorderStyle.FixedSingle;
            labelMousePosition.FlatStyle = FlatStyle.Flat;
            labelMousePosition.Location = new Point(5, 335);
            labelMousePosition.Name = "labelMousePosition";
            labelMousePosition.Size = new Size(724, 28);
            labelMousePosition.TabIndex = 2;
            labelMousePosition.Text = "labelMousePosition";
            labelMousePosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonStop
            // 
            buttonStop.FlatStyle = FlatStyle.Flat;
            buttonStop.Location = new Point(102, 4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(90, 28);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.Click += ButtonStopClick;
            // 
            // buttonStart
            // 
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Location = new Point(5, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(90, 28);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.Click += ButtonStartClick;
            // 
            // uiStep1CountTextBox
            // 
            uiStep1CountTextBox.Location = new Point(197, 60);
            uiStep1CountTextBox.Name = "uiStep1CountTextBox";
            uiStep1CountTextBox.Size = new Size(78, 23);
            uiStep1CountTextBox.TabIndex = 4;
            uiStep1CountTextBox.Text = "10";
            // 
            // uiStep2CountTextBox
            // 
            uiStep2CountTextBox.Location = new Point(281, 61);
            uiStep2CountTextBox.Name = "uiStep2CountTextBox";
            uiStep2CountTextBox.Size = new Size(80, 23);
            uiStep2CountTextBox.TabIndex = 5;
            uiStep2CountTextBox.Text = "1";
            // 
            // uiStep1ShiftCountTextBox
            // 
            uiStep1ShiftCountTextBox.Location = new Point(392, 60);
            uiStep1ShiftCountTextBox.Name = "uiStep1ShiftCountTextBox";
            uiStep1ShiftCountTextBox.Size = new Size(71, 23);
            uiStep1ShiftCountTextBox.TabIndex = 6;
            uiStep1ShiftCountTextBox.Text = "16";
            // 
            // uiStep2ShiftCountTextBox
            // 
            uiStep2ShiftCountTextBox.Location = new Point(496, 60);
            uiStep2ShiftCountTextBox.Name = "uiStep2ShiftCountTextBox";
            uiStep2ShiftCountTextBox.Size = new Size(74, 23);
            uiStep2ShiftCountTextBox.TabIndex = 7;
            uiStep2ShiftCountTextBox.Text = "8";
            // 
            // twoStepWithShiftRadioButton
            // 
            twoStepWithShiftRadioButton.AutoSize = true;
            twoStepWithShiftRadioButton.Location = new Point(5, 62);
            twoStepWithShiftRadioButton.Name = "twoStepWithShiftRadioButton";
            twoStepWithShiftRadioButton.RightToLeft = RightToLeft.Yes;
            twoStepWithShiftRadioButton.Size = new Size(166, 19);
            twoStepWithShiftRadioButton.TabIndex = 8;
            twoStepWithShiftRadioButton.Text = "2 прохода со смещением";
            twoStepWithShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormRadioButton
            // 
            uiKuricaKormRadioButton.AutoSize = true;
            uiKuricaKormRadioButton.Checked = true;
            uiKuricaKormRadioButton.Location = new Point(72, 134);
            uiKuricaKormRadioButton.Name = "uiKuricaKormRadioButton";
            uiKuricaKormRadioButton.RightToLeft = RightToLeft.Yes;
            uiKuricaKormRadioButton.Size = new Size(104, 19);
            uiKuricaKormRadioButton.TabIndex = 9;
            uiKuricaKormRadioButton.TabStop = true;
            uiKuricaKormRadioButton.Text = "корм лебедям";
            uiKuricaKormRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormStep2CountTextBox
            // 
            uiKuricaKormStep2CountTextBox.Location = new Point(198, 133);
            uiKuricaKormStep2CountTextBox.Name = "uiKuricaKormStep2CountTextBox";
            uiKuricaKormStep2CountTextBox.Size = new Size(62, 23);
            uiKuricaKormStep2CountTextBox.TabIndex = 10;
            uiKuricaKormStep2CountTextBox.Text = "10";
            // 
            // uiKuricaKormStep1CountTextBox
            // 
            uiKuricaKormStep1CountTextBox.Location = new Point(295, 133);
            uiKuricaKormStep1CountTextBox.Name = "uiKuricaKormStep1CountTextBox";
            uiKuricaKormStep1CountTextBox.Size = new Size(63, 23);
            uiKuricaKormStep1CountTextBox.TabIndex = 11;
            uiKuricaKormStep1CountTextBox.Text = "10";
            // 
            // uiDelayTextBox
            // 
            uiDelayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiDelayTextBox.Location = new Point(609, 257);
            uiDelayTextBox.Name = "uiDelayTextBox";
            uiDelayTextBox.Size = new Size(120, 23);
            uiDelayTextBox.TabIndex = 12;
            uiDelayTextBox.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 13;
            label1.Text = "Количество 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 42);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 14;
            label2.Text = "Количество 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 41);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 15;
            label3.Text = "смещение 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 41);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 16;
            label4.Text = "смещение 2";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(291, 261);
            label5.Name = "label5";
            label5.Size = new Size(279, 15);
            label5.TabIndex = 17;
            label5.Text = "задержка (увеличить интервал между кликами) в";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 111);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 18;
            label6.Text = "Количество 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 111);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 19;
            label7.Text = "Количество 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 186);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 22;
            label8.Text = "Количество 1";
            // 
            // uiClassicStepCount
            // 
            uiClassicStepCount.Location = new Point(202, 208);
            uiClassicStepCount.Name = "uiClassicStepCount";
            uiClassicStepCount.Size = new Size(62, 23);
            uiClassicStepCount.TabIndex = 21;
            uiClassicStepCount.Text = "10";
            // 
            // uiShiftEveryTextBox
            // 
            uiShiftEveryTextBox.Location = new Point(576, 60);
            uiShiftEveryTextBox.Name = "uiShiftEveryTextBox";
            uiShiftEveryTextBox.Size = new Size(80, 23);
            uiShiftEveryTextBox.TabIndex = 23;
            uiShiftEveryTextBox.Text = "3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(576, 41);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 24;
            label9.Text = "смещение каждые";
            // 
            // uiClassicRadioButton
            // 
            uiClassicRadioButton.AutoSize = true;
            uiClassicRadioButton.Location = new Point(5, 209);
            uiClassicRadioButton.Name = "uiClassicRadioButton";
            uiClassicRadioButton.RightToLeft = RightToLeft.Yes;
            uiClassicRadioButton.Size = new Size(163, 19);
            uiClassicRadioButton.TabIndex = 25;
            uiClassicRadioButton.Text = "повторять без смещения";
            uiClassicRadioButton.UseVisualStyleBackColor = true;
            // 
            // mouseMoveClickDelayTextBox
            // 
            mouseMoveClickDelayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mouseMoveClickDelayTextBox.Location = new Point(609, 289);
            mouseMoveClickDelayTextBox.Name = "mouseMoveClickDelayTextBox";
            mouseMoveClickDelayTextBox.Size = new Size(120, 23);
            mouseMoveClickDelayTextBox.TabIndex = 26;
            mouseMoveClickDelayTextBox.Text = "20";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(297, 297);
            label10.Name = "label10";
            label10.Size = new Size(276, 15);
            label10.TabIndex = 27;
            label10.Text = "Задержка перед перемещение мышки и кликом";
            // 
            // uiMacrosHistoryControl
            // 
            uiMacrosHistoryControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            uiMacrosHistoryControl.AutoScroll = true;
            uiMacrosHistoryControl.Location = new Point(736, 17);
            uiMacrosHistoryControl.Margin = new Padding(4, 3, 4, 3);
            uiMacrosHistoryControl.Name = "uiMacrosHistoryControl";
            uiMacrosHistoryControl.Size = new Size(453, 593);
            uiMacrosHistoryControl.TabIndex = 28;
            // 
            // uiDerevoRadioButton
            // 
            uiDerevoRadioButton.AutoSize = true;
            uiDerevoRadioButton.Location = new Point(109, 111);
            uiDerevoRadioButton.Name = "uiDerevoRadioButton";
            uiDerevoRadioButton.RightToLeft = RightToLeft.Yes;
            uiDerevoRadioButton.Size = new Size(68, 19);
            uiDerevoRadioButton.TabIndex = 29;
            uiDerevoRadioButton.Text = "деревья";
            uiDerevoRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaCustomRadioButton
            // 
            uiKuricaCustomRadioButton.AutoSize = true;
            uiKuricaCustomRadioButton.Location = new Point(365, 134);
            uiKuricaCustomRadioButton.Name = "uiKuricaCustomRadioButton";
            uiKuricaCustomRadioButton.RightToLeft = RightToLeft.Yes;
            uiKuricaCustomRadioButton.Size = new Size(98, 19);
            uiKuricaCustomRadioButton.TabIndex = 30;
            uiKuricaCustomRadioButton.Text = "произвольно";
            uiKuricaCustomRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormShiftTextBox
            // 
            uiKuricaKormShiftTextBox.Location = new Point(481, 133);
            uiKuricaKormShiftTextBox.Name = "uiKuricaKormShiftTextBox";
            uiKuricaKormShiftTextBox.Size = new Size(63, 23);
            uiKuricaKormShiftTextBox.TabIndex = 31;
            uiKuricaKormShiftTextBox.Text = "48";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(478, 111);
            label11.Name = "label11";
            label11.Size = new Size(203, 15);
            label11.TabIndex = 33;
            label11.Text = "смещение (деревья 64, курицам 32)";
            // 
            // buttonKeys
            // 
            buttonKeys.FlatStyle = FlatStyle.Flat;
            buttonKeys.Location = new Point(343, 4);
            buttonKeys.Name = "buttonKeys";
            buttonKeys.Size = new Size(70, 28);
            buttonKeys.TabIndex = 34;
            buttonKeys.Text = "Клавиши";
            buttonKeys.Click += OnKeyBindingsButtonClicked;
            // 
            // MainForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1203, 622);
            Controls.Add(buttonKeys);
            Controls.Add(label11);
            Controls.Add(uiKuricaKormShiftTextBox);
            Controls.Add(uiKuricaCustomRadioButton);
            Controls.Add(uiDerevoRadioButton);
            Controls.Add(uiMacrosHistoryControl);
            Controls.Add(label10);
            Controls.Add(mouseMoveClickDelayTextBox);
            Controls.Add(uiClassicRadioButton);
            Controls.Add(label9);
            Controls.Add(uiShiftEveryTextBox);
            Controls.Add(label8);
            Controls.Add(uiClassicStepCount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uiDelayTextBox);
            Controls.Add(uiKuricaKormStep1CountTextBox);
            Controls.Add(uiKuricaKormStep2CountTextBox);
            Controls.Add(uiKuricaKormRadioButton);
            Controls.Add(twoStepWithShiftRadioButton);
            Controls.Add(uiStep2ShiftCountTextBox);
            Controls.Add(uiStep1ShiftCountTextBox);
            Controls.Add(uiStep2CountTextBox);
            Controls.Add(uiStep1CountTextBox);
            Controls.Add(textBox);
            Controls.Add(labelMousePosition);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MacrosApp";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonKeys;

        private Button buttonStart;
        private Button buttonStop;
        private System.Windows.Forms.Label labelMousePosition;
        private TextBox uiStep1CountTextBox;
        private TextBox uiStep2CountTextBox;
        private TextBox uiStep1ShiftCountTextBox;
        private TextBox uiStep2ShiftCountTextBox;
        private System.Windows.Forms.RadioButton twoStepWithShiftRadioButton;
        private System.Windows.Forms.RadioButton uiKuricaKormRadioButton;
        private TextBox uiKuricaKormStep2CountTextBox;
        private TextBox uiKuricaKormStep1CountTextBox;
        private TextBox uiDelayTextBox;
        private System.Windows.Forms.TextBox textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox uiClassicStepCount;
        private TextBox uiShiftEveryTextBox;
        private Label label9;
        private System.Windows.Forms.RadioButton uiClassicRadioButton;
        private TextBox mouseMoveClickDelayTextBox;
        private Label label10;
        private MacrosApp.Gui.MacrosHistoryControl uiMacrosHistoryControl;
        private System.Windows.Forms.RadioButton uiDerevoRadioButton;
        private System.Windows.Forms.RadioButton uiKuricaCustomRadioButton;
        private TextBox uiKuricaKormShiftTextBox;
        private Label label11;
    }
}
