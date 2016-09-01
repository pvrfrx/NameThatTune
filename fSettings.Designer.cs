namespace NameThatTune
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.lbListMusic = new System.Windows.Forms.ListBox();
            this.btnLoadMusic = new System.Windows.Forms.Button();
            this.btnClearMusic = new System.Windows.Forms.Button();
            this.cbAllFolder = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbTuneDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKeyPlayer1 = new System.Windows.Forms.ComboBox();
            this.cbKeyPlayer2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTimeAnswer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbListMusic
            // 
            this.lbListMusic.FormattingEnabled = true;
            this.lbListMusic.Location = new System.Drawing.Point(13, 13);
            this.lbListMusic.Name = "lbListMusic";
            this.lbListMusic.Size = new System.Drawing.Size(759, 342);
            this.lbListMusic.TabIndex = 0;
            // 
            // btnLoadMusic
            // 
            this.btnLoadMusic.Location = new System.Drawing.Point(13, 362);
            this.btnLoadMusic.Name = "btnLoadMusic";
            this.btnLoadMusic.Size = new System.Drawing.Size(219, 35);
            this.btnLoadMusic.TabIndex = 1;
            this.btnLoadMusic.Text = "Загрузить музыку";
            this.btnLoadMusic.UseVisualStyleBackColor = true;
            this.btnLoadMusic.Click += new System.EventHandler(this.btnLoadMusic_Click);
            // 
            // btnClearMusic
            // 
            this.btnClearMusic.Location = new System.Drawing.Point(553, 362);
            this.btnClearMusic.Name = "btnClearMusic";
            this.btnClearMusic.Size = new System.Drawing.Size(219, 35);
            this.btnClearMusic.TabIndex = 2;
            this.btnClearMusic.Text = "Очистить список";
            this.btnClearMusic.UseVisualStyleBackColor = true;
            this.btnClearMusic.Click += new System.EventHandler(this.btnClearMusic_Click);
            // 
            // cbAllFolder
            // 
            this.cbAllFolder.AutoSize = true;
            this.cbAllFolder.Location = new System.Drawing.Point(239, 362);
            this.cbAllFolder.Name = "cbAllFolder";
            this.cbAllFolder.Size = new System.Drawing.Size(193, 17);
            this.cbAllFolder.TabIndex = 3;
            this.cbAllFolder.Text = "Использовать вложенные папки";
            this.cbAllFolder.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(553, 522);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(666, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продолжительность мелодии";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(9, 107);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(149, 17);
            this.cbRandomStart.TabIndex = 9;
            this.cbRandomStart.Text = "Старт мелодии с начала";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbTuneDuration
            // 
            this.cbTuneDuration.FormattingEnabled = true;
            this.cbTuneDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbTuneDuration.Location = new System.Drawing.Point(188, 49);
            this.cbTuneDuration.Name = "cbTuneDuration";
            this.cbTuneDuration.Size = new System.Drawing.Size(47, 21);
            this.cbTuneDuration.TabIndex = 10;
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(188, 22);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(47, 21);
            this.cbGameDuration.TabIndex = 11;
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(239, 379);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(239, 17);
            this.cbRepeat.TabIndex = 12;
            this.cbRepeat.Text = "Повторять мелодии, если все прозвучали";
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кнопка для игрока 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Кнопка для игрока 2";
            // 
            // cbKeyPlayer1
            // 
            this.cbKeyPlayer1.FormattingEnabled = true;
            this.cbKeyPlayer1.Location = new System.Drawing.Point(161, 25);
            this.cbKeyPlayer1.Name = "cbKeyPlayer1";
            this.cbKeyPlayer1.Size = new System.Drawing.Size(50, 21);
            this.cbKeyPlayer1.TabIndex = 15;
            // 
            // cbKeyPlayer2
            // 
            this.cbKeyPlayer2.FormattingEnabled = true;
            this.cbKeyPlayer2.Location = new System.Drawing.Point(161, 52);
            this.cbKeyPlayer2.Name = "cbKeyPlayer2";
            this.cbKeyPlayer2.Size = new System.Drawing.Size(50, 21);
            this.cbKeyPlayer2.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbKeyPlayer2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbKeyPlayer1);
            this.groupBox1.Location = new System.Drawing.Point(287, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки клавиш для игроков";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTimeAnswer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbRandomStart);
            this.groupBox2.Controls.Add(this.cbGameDuration);
            this.groupBox2.Controls.Add(this.cbTuneDuration);
            this.groupBox2.Location = new System.Drawing.Point(13, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 131);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки игры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Время на ответ";
            // 
            // cbTimeAnswer
            // 
            this.cbTimeAnswer.FormattingEnabled = true;
            this.cbTimeAnswer.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbTimeAnswer.Location = new System.Drawing.Point(188, 76);
            this.cbTimeAnswer.Name = "cbTimeAnswer";
            this.cbTimeAnswer.Size = new System.Drawing.Size(47, 21);
            this.cbTimeAnswer.TabIndex = 13;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbAllFolder);
            this.Controls.Add(this.btnClearMusic);
            this.Controls.Add(this.btnLoadMusic);
            this.Controls.Add(this.lbListMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSettings_FormClosing);
            this.Shown += new System.EventHandler(this.fSettings_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListMusic;
        private System.Windows.Forms.Button btnLoadMusic;
        private System.Windows.Forms.Button btnClearMusic;
        private System.Windows.Forms.CheckBox cbAllFolder;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cbTuneDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKeyPlayer1;
        private System.Windows.Forms.ComboBox cbKeyPlayer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTimeAnswer;
    }
}