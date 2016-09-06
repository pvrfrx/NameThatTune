namespace NameThatTune
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.timerTune = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lblGameDuration = new System.Windows.Forms.Label();
            this.btnGameOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(525, 491);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(444, 400);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 26);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Следующая";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(652, 400);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(98, 26);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Продолжить";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(548, 400);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(98, 26);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(460, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(614, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Игрок 2";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoint1.Location = new System.Drawing.Point(498, 213);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(31, 33);
            this.lblPoint1.TabIndex = 6;
            this.lblPoint1.Text = "0";
            this.lblPoint1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPoint1_MouseClick);
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoint2.Location = new System.Drawing.Point(658, 213);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(31, 33);
            this.lblPoint2.TabIndex = 7;
            this.lblPoint2.Text = "0";
            this.lblPoint2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblPoint1_MouseClick);
            // 
            // timerTune
            // 
            this.timerTune.Interval = 1000;
            this.timerTune.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(443, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 39);
            this.progressBar1.TabIndex = 8;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // lblGameDuration
            // 
            this.lblGameDuration.AutoSize = true;
            this.lblGameDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameDuration.Location = new System.Drawing.Point(578, 220);
            this.lblGameDuration.Name = "lblGameDuration";
            this.lblGameDuration.Size = new System.Drawing.Size(0, 25);
            this.lblGameDuration.TabIndex = 9;
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(651, 441);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(99, 26);
            this.btnGameOver.TabIndex = 10;
            this.btnGameOver.Text = "Закончить игру";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NameThatTune.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.lblGameDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPoint2);
            this.Controls.Add(this.lblPoint1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Shown += new System.EventHandler(this.fGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Timer timerTune;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lblGameDuration;
        private System.Windows.Forms.Button btnGameOver;
    }
}