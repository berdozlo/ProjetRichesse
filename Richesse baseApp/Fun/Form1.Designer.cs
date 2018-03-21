namespace Fun
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName01 = new System.Windows.Forms.Label();
            this.timeHour = new System.Windows.Forms.Timer(this.components);
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnNav = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblName01);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblName01
            // 
            this.lblName01.AutoSize = true;
            this.lblName01.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName01.ForeColor = System.Drawing.Color.White;
            this.lblName01.Location = new System.Drawing.Point(9, 6);
            this.lblName01.Name = "lblName01";
            this.lblName01.Size = new System.Drawing.Size(78, 21);
            this.lblName01.TabIndex = 1;
            this.lblName01.Text = "00:00:00";
            this.lblName01.Click += new System.EventHandler(this.lblName01_Click);
            // 
            // timeHour
            // 
            this.timeHour.Enabled = true;
            this.timeHour.Interval = 1000;
            this.timeHour.Tick += new System.EventHandler(this.timeHour_Tick);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.Black;
            this.btnMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusic.BackgroundImage")));
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.Location = new System.Drawing.Point(32, 62);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(158, 138);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.TabStop = false;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(391, 62);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(158, 106);
            this.btnVideo.TabIndex = 2;
            this.btnVideo.Text = "Vidéos";
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // btnNav
            // 
            this.btnNav.Location = new System.Drawing.Point(783, 62);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(158, 106);
            this.btnNav.TabIndex = 3;
            this.btnNav.Text = "Navigation";
            this.btnNav.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.btnNav);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName01;
        private System.Windows.Forms.Timer timeHour;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnNav;
    }
}

