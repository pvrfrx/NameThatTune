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
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cbAllFolder);
            this.Controls.Add(this.btnClearMusic);
            this.Controls.Add(this.btnLoadMusic);
            this.Controls.Add(this.lbListMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListMusic;
        private System.Windows.Forms.Button btnLoadMusic;
        private System.Windows.Forms.Button btnClearMusic;
        private System.Windows.Forms.CheckBox cbAllFolder;
    }
}