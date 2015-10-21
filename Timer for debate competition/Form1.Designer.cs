namespace Timer_for_debate_competition
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.stageLabel = new System.Windows.Forms.Label();
            this.stageIndicator = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.totalTimeIndicator = new System.Windows.Forms.Label();
            this.totalTimerLable = new System.Windows.Forms.Label();
            this.consAnswLabel = new System.Windows.Forms.Label();
            this.consAnswTimeIndicator = new System.Windows.Forms.Label();
            this.prosQuesLable = new System.Windows.Forms.Label();
            this.prosQuesTimeIndicator = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.prosQuesButton = new System.Windows.Forms.Button();
            this.consAnswButton = new System.Windows.Forms.Button();
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.prosQuesTimer = new System.Windows.Forms.Timer(this.components);
            this.consAnswTimer = new System.Windows.Forms.Timer(this.components);
            this.personIndicator1 = new System.Windows.Forms.PictureBox();
            this.personIndicator2 = new System.Windows.Forms.PictureBox();
            this.personIndicator3 = new System.Windows.Forms.PictureBox();
            this.personIndicator4 = new System.Windows.Forms.PictureBox();
            this.personIndicator8 = new System.Windows.Forms.PictureBox();
            this.personIndicator7 = new System.Windows.Forms.PictureBox();
            this.personIndicator6 = new System.Windows.Forms.PictureBox();
            this.personIndicator5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.topic = new System.Windows.Forms.TextBox();
            this.topicOfProposition = new System.Windows.Forms.TextBox();
            this.topicOfOpposition = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator5)).BeginInit();
            this.SuspendLayout();
            // 
            // stageLabel
            // 
            this.stageLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageLabel.ForeColor = System.Drawing.Color.White;
            this.stageLabel.Location = new System.Drawing.Point(258, 184);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(306, 24);
            this.stageLabel.TabIndex = 1;
            this.stageLabel.Text = "STAGE";
            this.stageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // stageIndicator
            // 
            this.stageIndicator.Font = new System.Drawing.Font("STXihei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stageIndicator.ForeColor = System.Drawing.Color.White;
            this.stageIndicator.Location = new System.Drawing.Point(262, 208);
            this.stageIndicator.Name = "stageIndicator";
            this.stageIndicator.Size = new System.Drawing.Size(302, 69);
            this.stageIndicator.TabIndex = 1;
            this.stageIndicator.Text = "?";
            this.stageIndicator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("STXihei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(540, 208);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(24, 69);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "▶";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.FlatAppearance.BorderSize = 0;
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Font = new System.Drawing.Font("STXihei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastButton.ForeColor = System.Drawing.Color.White;
            this.lastButton.Location = new System.Drawing.Point(262, 208);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(24, 69);
            this.lastButton.TabIndex = 2;
            this.lastButton.Text = "◀";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // totalTimeIndicator
            // 
            this.totalTimeIndicator.Font = new System.Drawing.Font("STXihei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalTimeIndicator.ForeColor = System.Drawing.Color.White;
            this.totalTimeIndicator.Location = new System.Drawing.Point(262, 307);
            this.totalTimeIndicator.Name = "totalTimeIndicator";
            this.totalTimeIndicator.Size = new System.Drawing.Size(302, 69);
            this.totalTimeIndicator.TabIndex = 1;
            this.totalTimeIndicator.Text = "00:00:00";
            this.totalTimeIndicator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // totalTimerLable
            // 
            this.totalTimerLable.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimerLable.ForeColor = System.Drawing.Color.White;
            this.totalTimerLable.Location = new System.Drawing.Point(258, 283);
            this.totalTimerLable.Name = "totalTimerLable";
            this.totalTimerLable.Size = new System.Drawing.Size(306, 24);
            this.totalTimerLable.TabIndex = 1;
            this.totalTimerLable.Text = "TOTAL REMAINING TIME";
            this.totalTimerLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // consAnswLabel
            // 
            this.consAnswLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consAnswLabel.ForeColor = System.Drawing.Color.White;
            this.consAnswLabel.Location = new System.Drawing.Point(448, 381);
            this.consAnswLabel.Name = "consAnswLabel";
            this.consAnswLabel.Size = new System.Drawing.Size(222, 24);
            this.consAnswLabel.TabIndex = 1;
            this.consAnswLabel.Text = "OPPOSITION/ANSWER";
            this.consAnswLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // consAnswTimeIndicator
            // 
            this.consAnswTimeIndicator.Font = new System.Drawing.Font("STXihei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.consAnswTimeIndicator.ForeColor = System.Drawing.Color.White;
            this.consAnswTimeIndicator.Location = new System.Drawing.Point(450, 409);
            this.consAnswTimeIndicator.Name = "consAnswTimeIndicator";
            this.consAnswTimeIndicator.Size = new System.Drawing.Size(222, 48);
            this.consAnswTimeIndicator.TabIndex = 1;
            this.consAnswTimeIndicator.Text = "00:00:00";
            this.consAnswTimeIndicator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // prosQuesLable
            // 
            this.prosQuesLable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prosQuesLable.ForeColor = System.Drawing.Color.White;
            this.prosQuesLable.Location = new System.Drawing.Point(153, 381);
            this.prosQuesLable.Name = "prosQuesLable";
            this.prosQuesLable.Size = new System.Drawing.Size(222, 24);
            this.prosQuesLable.TabIndex = 1;
            this.prosQuesLable.Text = "PROPOSITION/QUESTION";
            this.prosQuesLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // prosQuesTimeIndicator
            // 
            this.prosQuesTimeIndicator.Font = new System.Drawing.Font("STXihei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prosQuesTimeIndicator.ForeColor = System.Drawing.Color.White;
            this.prosQuesTimeIndicator.Location = new System.Drawing.Point(155, 409);
            this.prosQuesTimeIndicator.Name = "prosQuesTimeIndicator";
            this.prosQuesTimeIndicator.Size = new System.Drawing.Size(222, 48);
            this.prosQuesTimeIndicator.TabIndex = 1;
            this.prosQuesTimeIndicator.Text = "00:00:00";
            this.prosQuesTimeIndicator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(334, 487);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(151, 57);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.VisibleChanged += new System.EventHandler(this.startButton_VisibleChanged);
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(334, 549);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 57);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // prosQuesButton
            // 
            this.prosQuesButton.FlatAppearance.BorderSize = 0;
            this.prosQuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prosQuesButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prosQuesButton.ForeColor = System.Drawing.Color.White;
            this.prosQuesButton.Location = new System.Drawing.Point(231, 500);
            this.prosQuesButton.Name = "prosQuesButton";
            this.prosQuesButton.Size = new System.Drawing.Size(151, 57);
            this.prosQuesButton.TabIndex = 2;
            this.prosQuesButton.Text = "PROPOSITION/QUESTION";
            this.prosQuesButton.UseVisualStyleBackColor = true;
            this.prosQuesButton.Click += new System.EventHandler(this.prosQuesButton_Click);
            // 
            // consAnswButton
            // 
            this.consAnswButton.FlatAppearance.BorderSize = 0;
            this.consAnswButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consAnswButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consAnswButton.ForeColor = System.Drawing.Color.White;
            this.consAnswButton.Location = new System.Drawing.Point(434, 500);
            this.consAnswButton.Name = "consAnswButton";
            this.consAnswButton.Size = new System.Drawing.Size(151, 57);
            this.consAnswButton.TabIndex = 2;
            this.consAnswButton.Text = "OPPOSITION/ANSWER";
            this.consAnswButton.UseVisualStyleBackColor = true;
            this.consAnswButton.Click += new System.EventHandler(this.consAnswButton_Click);
            // 
            // totalTimer
            // 
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
            // 
            // prosQuesTimer
            // 
            this.prosQuesTimer.Tick += new System.EventHandler(this.prosQuesTimer_Tick);
            // 
            // consAnswTimer
            // 
            this.consAnswTimer.Tick += new System.EventHandler(this.consAnswTimer_Tick);
            // 
            // personIndicator1
            // 
            this.personIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator1.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__8_;
            this.personIndicator1.Location = new System.Drawing.Point(140, 113);
            this.personIndicator1.Name = "personIndicator1";
            this.personIndicator1.Size = new System.Drawing.Size(183, 100);
            this.personIndicator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator1.TabIndex = 0;
            this.personIndicator1.TabStop = false;
            // 
            // personIndicator2
            // 
            this.personIndicator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator2.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__7_;
            this.personIndicator2.Location = new System.Drawing.Point(52, 201);
            this.personIndicator2.Name = "personIndicator2";
            this.personIndicator2.Size = new System.Drawing.Size(100, 182);
            this.personIndicator2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator2.TabIndex = 0;
            this.personIndicator2.TabStop = false;
            // 
            // personIndicator3
            // 
            this.personIndicator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator3.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__6_;
            this.personIndicator3.Location = new System.Drawing.Point(52, 400);
            this.personIndicator3.Name = "personIndicator3";
            this.personIndicator3.Size = new System.Drawing.Size(100, 183);
            this.personIndicator3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator3.TabIndex = 0;
            this.personIndicator3.TabStop = false;
            // 
            // personIndicator4
            // 
            this.personIndicator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator4.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__5_;
            this.personIndicator4.Location = new System.Drawing.Point(140, 571);
            this.personIndicator4.Name = "personIndicator4";
            this.personIndicator4.Size = new System.Drawing.Size(182, 100);
            this.personIndicator4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator4.TabIndex = 0;
            this.personIndicator4.TabStop = false;
            // 
            // personIndicator8
            // 
            this.personIndicator8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator8.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__4_;
            this.personIndicator8.Location = new System.Drawing.Point(496, 571);
            this.personIndicator8.Name = "personIndicator8";
            this.personIndicator8.Size = new System.Drawing.Size(183, 100);
            this.personIndicator8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator8.TabIndex = 0;
            this.personIndicator8.TabStop = false;
            // 
            // personIndicator7
            // 
            this.personIndicator7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator7.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__3_;
            this.personIndicator7.Location = new System.Drawing.Point(666, 401);
            this.personIndicator7.Name = "personIndicator7";
            this.personIndicator7.Size = new System.Drawing.Size(100, 182);
            this.personIndicator7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator7.TabIndex = 0;
            this.personIndicator7.TabStop = false;
            // 
            // personIndicator6
            // 
            this.personIndicator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator6.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__2_;
            this.personIndicator6.Location = new System.Drawing.Point(666, 200);
            this.personIndicator6.Name = "personIndicator6";
            this.personIndicator6.Size = new System.Drawing.Size(100, 183);
            this.personIndicator6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator6.TabIndex = 0;
            this.personIndicator6.TabStop = false;
            // 
            // personIndicator5
            // 
            this.personIndicator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personIndicator5.Image = global::Timer_for_debate_competition.Properties.Resources.CircleWhite__1_;
            this.personIndicator5.Location = new System.Drawing.Point(497, 113);
            this.personIndicator5.Name = "personIndicator5";
            this.personIndicator5.Size = new System.Drawing.Size(182, 100);
            this.personIndicator5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.personIndicator5.TabIndex = 0;
            this.personIndicator5.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(334, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topic
            // 
            this.topic.BackColor = System.Drawing.Color.SteelBlue;
            this.topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.topic.Font = new System.Drawing.Font("STXihei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topic.ForeColor = System.Drawing.Color.White;
            this.topic.Location = new System.Drawing.Point(0, 17);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(823, 67);
            this.topic.TabIndex = 4;
            this.topic.Text = "辩题";
            this.topic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topicOfProposition
            // 
            this.topicOfProposition.BackColor = System.Drawing.Color.SteelBlue;
            this.topicOfProposition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicOfProposition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.topicOfProposition.Font = new System.Drawing.Font("STXihei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topicOfProposition.ForeColor = System.Drawing.Color.White;
            this.topicOfProposition.Location = new System.Drawing.Point(0, 73);
            this.topicOfProposition.Name = "topicOfProposition";
            this.topicOfProposition.Size = new System.Drawing.Size(411, 38);
            this.topicOfProposition.TabIndex = 5;
            this.topicOfProposition.Text = "正方观点";
            this.topicOfProposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topicOfOpposition
            // 
            this.topicOfOpposition.BackColor = System.Drawing.Color.SteelBlue;
            this.topicOfOpposition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicOfOpposition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.topicOfOpposition.Font = new System.Drawing.Font("STXihei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topicOfOpposition.ForeColor = System.Drawing.Color.White;
            this.topicOfOpposition.Location = new System.Drawing.Point(412, 73);
            this.topicOfOpposition.Name = "topicOfOpposition";
            this.topicOfOpposition.Size = new System.Drawing.Size(411, 38);
            this.topicOfOpposition.TabIndex = 6;
            this.topicOfOpposition.Text = "反方观点";
            this.topicOfOpposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("STXihei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(329, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "BISTU 学生会";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(823, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.consAnswButton);
            this.Controls.Add(this.prosQuesButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prosQuesTimeIndicator);
            this.Controls.Add(this.consAnswTimeIndicator);
            this.Controls.Add(this.totalTimeIndicator);
            this.Controls.Add(this.stageIndicator);
            this.Controls.Add(this.prosQuesLable);
            this.Controls.Add(this.consAnswLabel);
            this.Controls.Add(this.totalTimerLable);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.personIndicator1);
            this.Controls.Add(this.personIndicator2);
            this.Controls.Add(this.personIndicator3);
            this.Controls.Add(this.personIndicator4);
            this.Controls.Add(this.personIndicator8);
            this.Controls.Add(this.personIndicator7);
            this.Controls.Add(this.personIndicator6);
            this.Controls.Add(this.personIndicator5);
            this.Controls.Add(this.topicOfOpposition);
            this.Controls.Add(this.topicOfProposition);
            this.Controls.Add(this.topic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer for debate conpetition";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personIndicator5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox personIndicator5;
        private System.Windows.Forms.PictureBox personIndicator6;
        private System.Windows.Forms.PictureBox personIndicator7;
        private System.Windows.Forms.PictureBox personIndicator8;
        private System.Windows.Forms.PictureBox personIndicator4;
        private System.Windows.Forms.PictureBox personIndicator3;
        private System.Windows.Forms.PictureBox personIndicator2;
        private System.Windows.Forms.PictureBox personIndicator1;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label stageIndicator;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Label totalTimeIndicator;
        private System.Windows.Forms.Label totalTimerLable;
        private System.Windows.Forms.Label consAnswLabel;
        private System.Windows.Forms.Label consAnswTimeIndicator;
        private System.Windows.Forms.Label prosQuesLable;
        private System.Windows.Forms.Label prosQuesTimeIndicator;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button prosQuesButton;
        private System.Windows.Forms.Button consAnswButton;
        private System.Windows.Forms.Timer totalTimer;
        private System.Windows.Forms.Timer prosQuesTimer;
        private System.Windows.Forms.Timer consAnswTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.TextBox topicOfProposition;
        private System.Windows.Forms.TextBox topicOfOpposition;
        private System.Windows.Forms.Button button2;


    }
}

