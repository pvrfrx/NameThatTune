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
            this.label1.Location = new System.Drawing.Point(20, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продолжительность мелодии";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(23, 468);
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
            this.cbTuneDuration.Location = new System.Drawing.Point(202, 438);
            this.cbTuneDuration.Name = "cbTuneDuration";
            this.cbTuneDuration.Size = new System.Drawing.Size(30, 21);
            this.cbTuneDuration.TabIndex = 10;
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(202, 411);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(30, 21);
            this.cbGameDuration.TabIndex = 11;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cbGameDuration);
            this.Controls.Add(this.cbTuneDuration);
            this.Controls.Add(this.cbRandomStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}