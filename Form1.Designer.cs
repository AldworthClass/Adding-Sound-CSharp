namespace Adding_Sound_CSharp
{
    partial class FormSound
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.imgTerminator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTerminator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(7, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(118, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(7, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(243, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(131, 6);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(119, 23);
            this.btnLoop.TabIndex = 2;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // imgTerminator
            // 
            this.imgTerminator.Image = global::Adding_Sound_CSharp.Properties.Resources.TerminatorImage;
            this.imgTerminator.Location = new System.Drawing.Point(7, 64);
            this.imgTerminator.Name = "imgTerminator";
            this.imgTerminator.Size = new System.Drawing.Size(243, 205);
            this.imgTerminator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTerminator.TabIndex = 3;
            this.imgTerminator.TabStop = false;
            // 
            // FormSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 281);
            this.Controls.Add(this.imgTerminator);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Name = "FormSound";
            this.Text = "Adding Sound";
            this.Load += new System.EventHandler(this.FormSound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTerminator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.PictureBox imgTerminator;
    }
}

