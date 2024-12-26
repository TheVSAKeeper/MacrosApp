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
            textBox = new System.Windows.Forms.TextBox();
            labelMousePosition = new System.Windows.Forms.Label();
            buttonStop = new System.Windows.Forms.Button();
            buttonStart = new System.Windows.Forms.Button();
            uiStep1CountTextBox = new System.Windows.Forms.TextBox();
            uiStep2CountTextBox = new System.Windows.Forms.TextBox();
            uiStep1ShiftCountTextBox = new System.Windows.Forms.TextBox();
            uiStep2ShiftCountTextBox = new System.Windows.Forms.TextBox();
            twoStepWithShiftRadioButton = new System.Windows.Forms.RadioButton();
            uiKuricaKormRadioButton = new System.Windows.Forms.RadioButton();
            uiKuricaKormStep2CountTextBox = new System.Windows.Forms.TextBox();
            uiKuricaKormStep1CountTextBox = new System.Windows.Forms.TextBox();
            uiDelayTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            uiClassicStepCount = new System.Windows.Forms.TextBox();
            uiShiftEveryTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            uiClassicRadioButton = new System.Windows.Forms.RadioButton();
            mouseMoveClickDelayTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            uiMacrosHistoryControl = new MacrosApp.Gui.MacrosHistoryControl();
            uiDerevoRadioButton = new System.Windows.Forms.RadioButton();
            uiKuricaCustomRadioButton = new System.Windows.Forms.RadioButton();
            uiKuricaKormShiftTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            buttonKeys = new System.Windows.Forms.Button();
            SuspendLayout();

            // 
            // textBox
            // 
            textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                   | System.Windows.Forms.AnchorStyles.Left)
                                                                  | System.Windows.Forms.AnchorStyles.Right));

            textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            textBox.Location = new System.Drawing.Point(5, 378);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox.Size = new System.Drawing.Size(763, 198);
            textBox.TabIndex = 3;

            // 
            // labelMousePosition
            // 
            labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right));

            labelMousePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelMousePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelMousePosition.Location = new System.Drawing.Point(5, 335);
            labelMousePosition.Name = "labelMousePosition";
            labelMousePosition.Size = new System.Drawing.Size(751, 28);
            labelMousePosition.TabIndex = 2;
            labelMousePosition.Text = "labelMousePosition";
            labelMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStop
            // 
            buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStop.Location = new System.Drawing.Point(102, 4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(90, 28);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.Click += ButtonStopClick;
            // 
            // buttonStart
            // 
            buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStart.Location = new System.Drawing.Point(5, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(90, 28);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.Click += ButtonStartClick;
            // 
            // uiStep1CountTextBox
            // 
            uiStep1CountTextBox.Location = new System.Drawing.Point(197, 60);
            uiStep1CountTextBox.Name = "uiStep1CountTextBox";
            uiStep1CountTextBox.Size = new System.Drawing.Size(120, 23);
            uiStep1CountTextBox.TabIndex = 4;
            uiStep1CountTextBox.Text = "10";
            // 
            // uiStep2CountTextBox
            // 
            uiStep2CountTextBox.Location = new System.Drawing.Point(324, 60);
            uiStep2CountTextBox.Name = "uiStep2CountTextBox";
            uiStep2CountTextBox.Size = new System.Drawing.Size(120, 23);
            uiStep2CountTextBox.TabIndex = 5;
            uiStep2CountTextBox.Text = "1";
            // 
            // uiStep1ShiftCountTextBox
            // 
            uiStep1ShiftCountTextBox.Location = new System.Drawing.Point(451, 60);
            uiStep1ShiftCountTextBox.Name = "uiStep1ShiftCountTextBox";
            uiStep1ShiftCountTextBox.Size = new System.Drawing.Size(120, 23);
            uiStep1ShiftCountTextBox.TabIndex = 6;
            uiStep1ShiftCountTextBox.Text = "16";
            // 
            // uiStep2ShiftCountTextBox
            // 
            uiStep2ShiftCountTextBox.Location = new System.Drawing.Point(578, 60);
            uiStep2ShiftCountTextBox.Name = "uiStep2ShiftCountTextBox";
            uiStep2ShiftCountTextBox.Size = new System.Drawing.Size(120, 23);
            uiStep2ShiftCountTextBox.TabIndex = 7;
            uiStep2ShiftCountTextBox.Text = "8";
            // 
            // twoStepWithShiftRadioButton
            // 
            twoStepWithShiftRadioButton.AutoSize = true;
            twoStepWithShiftRadioButton.Location = new System.Drawing.Point(5, 62);
            twoStepWithShiftRadioButton.Name = "twoStepWithShiftRadioButton";
            twoStepWithShiftRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            twoStepWithShiftRadioButton.Size = new System.Drawing.Size(166, 19);
            twoStepWithShiftRadioButton.TabIndex = 8;
            twoStepWithShiftRadioButton.Text = "2 прохода со смещением";
            twoStepWithShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormRadioButton
            // 
            uiKuricaKormRadioButton.AutoSize = true;
            uiKuricaKormRadioButton.Checked = true;
            uiKuricaKormRadioButton.Location = new System.Drawing.Point(72, 134);
            uiKuricaKormRadioButton.Name = "uiKuricaKormRadioButton";
            uiKuricaKormRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            uiKuricaKormRadioButton.Size = new System.Drawing.Size(104, 19);
            uiKuricaKormRadioButton.TabIndex = 9;
            uiKuricaKormRadioButton.TabStop = true;
            uiKuricaKormRadioButton.Text = "корм лебедям";
            uiKuricaKormRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormStep2CountTextBox
            // 
            uiKuricaKormStep2CountTextBox.Location = new System.Drawing.Point(198, 133);
            uiKuricaKormStep2CountTextBox.Name = "uiKuricaKormStep2CountTextBox";
            uiKuricaKormStep2CountTextBox.Size = new System.Drawing.Size(62, 23);
            uiKuricaKormStep2CountTextBox.TabIndex = 10;
            uiKuricaKormStep2CountTextBox.Text = "10";
            // 
            // uiKuricaKormStep1CountTextBox
            // 
            uiKuricaKormStep1CountTextBox.Location = new System.Drawing.Point(295, 133);
            uiKuricaKormStep1CountTextBox.Name = "uiKuricaKormStep1CountTextBox";
            uiKuricaKormStep1CountTextBox.Size = new System.Drawing.Size(63, 23);
            uiKuricaKormStep1CountTextBox.TabIndex = 11;
            uiKuricaKormStep1CountTextBox.Text = "10";
            // 
            // uiDelayTextBox
            // 
            uiDelayTextBox.Location = new System.Drawing.Point(822, 257);
            uiDelayTextBox.Name = "uiDelayTextBox";
            uiDelayTextBox.Size = new System.Drawing.Size(120, 23);
            uiDelayTextBox.TabIndex = 12;
            uiDelayTextBox.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(198, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 15);
            label1.TabIndex = 13;
            label1.Text = "Количество 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(323, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 14;
            label2.Text = "Количество 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(448, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 15);
            label3.TabIndex = 15;
            label3.Text = "смещение 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(578, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 15);
            label4.TabIndex = 16;
            label4.Text = "смещение 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(504, 261);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(279, 15);
            label5.TabIndex = 17;
            label5.Text = "задержка (увеличить интервал между кликами) в";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(194, 111);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 15);
            label6.TabIndex = 18;
            label6.Text = "Количество 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(292, 111);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 15);
            label7.TabIndex = 19;
            label7.Text = "Количество 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(198, 186);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 15);
            label8.TabIndex = 22;
            label8.Text = "Количество 1";
            // 
            // uiClassicStepCount
            // 
            uiClassicStepCount.Location = new System.Drawing.Point(202, 208);
            uiClassicStepCount.Name = "uiClassicStepCount";
            uiClassicStepCount.Size = new System.Drawing.Size(62, 23);
            uiClassicStepCount.TabIndex = 21;
            uiClassicStepCount.Text = "10";
            // 
            // uiShiftEveryTextBox
            // 
            uiShiftEveryTextBox.Location = new System.Drawing.Point(706, 58);
            uiShiftEveryTextBox.Name = "uiShiftEveryTextBox";
            uiShiftEveryTextBox.Size = new System.Drawing.Size(120, 23);
            uiShiftEveryTextBox.TabIndex = 23;
            uiShiftEveryTextBox.Text = "3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(702, 37);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(110, 15);
            label9.TabIndex = 24;
            label9.Text = "смещение каждые";
            // 
            // uiClassicRadioButton
            // 
            uiClassicRadioButton.AutoSize = true;
            uiClassicRadioButton.Location = new System.Drawing.Point(5, 209);
            uiClassicRadioButton.Name = "uiClassicRadioButton";
            uiClassicRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            uiClassicRadioButton.Size = new System.Drawing.Size(163, 19);
            uiClassicRadioButton.TabIndex = 25;
            uiClassicRadioButton.Text = "повторять без смещения";
            uiClassicRadioButton.UseVisualStyleBackColor = true;
            // 
            // mouseMoveClickDelayTextBox
            // 
            mouseMoveClickDelayTextBox.Location = new System.Drawing.Point(822, 289);
            mouseMoveClickDelayTextBox.Name = "mouseMoveClickDelayTextBox";
            mouseMoveClickDelayTextBox.Size = new System.Drawing.Size(120, 23);
            mouseMoveClickDelayTextBox.TabIndex = 26;
            mouseMoveClickDelayTextBox.Text = "500";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(510, 297);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(276, 15);
            label10.TabIndex = 27;
            label10.Text = "Задержка перед перемещение мышки и кликом";
            // 
            // uiMacrosHistoryControl
            // 
            uiMacrosHistoryControl.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            uiMacrosHistoryControl.AutoScroll = true;
            uiMacrosHistoryControl.Location = new System.Drawing.Point(763, 17);
            uiMacrosHistoryControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            uiMacrosHistoryControl.Name = "uiMacrosHistoryControl";
            uiMacrosHistoryControl.Size = new System.Drawing.Size(453, 682);
            uiMacrosHistoryControl.TabIndex = 28;
            // 
            // uiDerevoRadioButton
            // 
            uiDerevoRadioButton.AutoSize = true;
            uiDerevoRadioButton.Location = new System.Drawing.Point(109, 111);
            uiDerevoRadioButton.Name = "uiDerevoRadioButton";
            uiDerevoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            uiDerevoRadioButton.Size = new System.Drawing.Size(68, 19);
            uiDerevoRadioButton.TabIndex = 29;
            uiDerevoRadioButton.Text = "деревья";
            uiDerevoRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaCustomRadioButton
            // 
            uiKuricaCustomRadioButton.AutoSize = true;
            uiKuricaCustomRadioButton.Location = new System.Drawing.Point(365, 134);
            uiKuricaCustomRadioButton.Name = "uiKuricaCustomRadioButton";
            uiKuricaCustomRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            uiKuricaCustomRadioButton.Size = new System.Drawing.Size(98, 19);
            uiKuricaCustomRadioButton.TabIndex = 30;
            uiKuricaCustomRadioButton.Text = "произвольно";
            uiKuricaCustomRadioButton.UseVisualStyleBackColor = true;
            // 
            // uiKuricaKormShiftTextBox
            // 
            uiKuricaKormShiftTextBox.Location = new System.Drawing.Point(481, 133);
            uiKuricaKormShiftTextBox.Name = "uiKuricaKormShiftTextBox";
            uiKuricaKormShiftTextBox.Size = new System.Drawing.Size(63, 23);
            uiKuricaKormShiftTextBox.TabIndex = 31;
            uiKuricaKormShiftTextBox.Text = "48";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(478, 111);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(203, 15);
            label11.TabIndex = 33;
            label11.Text = "смещение (деревья 64, курицам 32)";
            // 
            // buttonKeys
            // 
            buttonKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonKeys.Location = new System.Drawing.Point(343, 4);
            buttonKeys.Name = "buttonKeys";
            buttonKeys.Size = new System.Drawing.Size(70, 28);
            buttonKeys.TabIndex = 34;
            buttonKeys.Text = "Клавиши";
            buttonKeys.Click += OnKeyBindingsButtonClicked;
            // 
            // MainForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            ClientSize = new System.Drawing.Size(1230, 580);
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
