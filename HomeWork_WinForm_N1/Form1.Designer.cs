namespace HomeWork_WinForm_N1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataLabel = new Label();
            labelNumber = new Label();
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonOK = new Button();
            labelQuestion = new Label();
            buttonNewGame = new Button();
            SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new Point(133, 22);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(515, 80);
            dataLabel.TabIndex = 0;
            dataLabel.Text = resources.GetString("dataLabel.Text");
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(352, 149);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(41, 20);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "1000";
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(225, 235);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(94, 29);
            buttonLeft.TabIndex = 2;
            buttonLeft.Text = "Меньше";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(416, 239);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(94, 29);
            buttonRight.TabIndex = 3;
            buttonRight.Text = "Больше";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(317, 287);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "Отгадано!";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(205, 188);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(373, 20);
            labelQuestion.TabIndex = 5;
            labelQuestion.Text = "Загаданное число больше или меньше указанного?";
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(287, 334);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(157, 29);
            buttonNewGame.TabIndex = 6;
            buttonNewGame.Text = "Играем снова!";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNewGame);
            Controls.Add(labelQuestion);
            Controls.Add(buttonOK);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(labelNumber);
            Controls.Add(dataLabel);
            Name = "Form1";
            Text = "Угадаю число!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataLabel;
        private Label labelNumber;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonOK;
        private Label labelQuestion;
        private Button buttonNewGame;
    }
}