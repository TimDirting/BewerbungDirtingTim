
namespace BewerbungDirtingTim
{
    partial class BewerbungsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PaintingTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonAnschreiben = new System.Windows.Forms.Button();
            this.buttonLebenslauf = new System.Windows.Forms.Button();
            this.buttonAnlagen = new System.Windows.Forms.Button();
            this.buttonBeispielCode = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonchessstart = new System.Windows.Forms.Button();
            this.KnightBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxDesign2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKnight = new System.Windows.Forms.PictureBox();
            this.pictureBoxDesign = new System.Windows.Forms.PictureBox();
            this.buttonPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KnightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintingTimer
            // 
            this.PaintingTimer.Enabled = true;
            this.PaintingTimer.Interval = 10;
            this.PaintingTimer.Tick += new System.EventHandler(this.paintingTimer_Tick);
            // 
            // buttonAnschreiben
            // 
            this.buttonAnschreiben.BackColor = System.Drawing.Color.White;
            this.buttonAnschreiben.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnschreiben.Font = new System.Drawing.Font("Arial", 38.25F);
            this.buttonAnschreiben.Location = new System.Drawing.Point(12, 313);
            this.buttonAnschreiben.Name = "buttonAnschreiben";
            this.buttonAnschreiben.Size = new System.Drawing.Size(326, 123);
            this.buttonAnschreiben.TabIndex = 3;
            this.buttonAnschreiben.Text = "Anschreiben";
            this.buttonAnschreiben.UseVisualStyleBackColor = false;
            this.buttonAnschreiben.Click += new System.EventHandler(this.buttonAnschreiben_Click);
            // 
            // buttonLebenslauf
            // 
            this.buttonLebenslauf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLebenslauf.BackColor = System.Drawing.Color.White;
            this.buttonLebenslauf.Font = new System.Drawing.Font("Arial", 38.25F);
            this.buttonLebenslauf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLebenslauf.Location = new System.Drawing.Point(423, 313);
            this.buttonLebenslauf.Name = "buttonLebenslauf";
            this.buttonLebenslauf.Size = new System.Drawing.Size(320, 123);
            this.buttonLebenslauf.TabIndex = 1;
            this.buttonLebenslauf.Text = "Lebenslauf";
            this.buttonLebenslauf.UseVisualStyleBackColor = false;
            this.buttonLebenslauf.Click += new System.EventHandler(this.buttonLebenslauf_Click);
            // 
            // buttonAnlagen
            // 
            this.buttonAnlagen.BackColor = System.Drawing.Color.White;
            this.buttonAnlagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnlagen.Font = new System.Drawing.Font("Arial", 38.25F);
            this.buttonAnlagen.Location = new System.Drawing.Point(12, 442);
            this.buttonAnlagen.Name = "buttonAnlagen";
            this.buttonAnlagen.Size = new System.Drawing.Size(326, 123);
            this.buttonAnlagen.TabIndex = 7;
            this.buttonAnlagen.Text = "Anlagen";
            this.buttonAnlagen.UseVisualStyleBackColor = false;
            this.buttonAnlagen.Click += new System.EventHandler(this.buttonAnlagen_Click);
            // 
            // buttonBeispielCode
            // 
            this.buttonBeispielCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBeispielCode.BackColor = System.Drawing.Color.White;
            this.buttonBeispielCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBeispielCode.Font = new System.Drawing.Font("Arial", 38.25F);
            this.buttonBeispielCode.Location = new System.Drawing.Point(423, 442);
            this.buttonBeispielCode.Name = "buttonBeispielCode";
            this.buttonBeispielCode.Size = new System.Drawing.Size(320, 123);
            this.buttonBeispielCode.TabIndex = 8;
            this.buttonBeispielCode.Text = "Beispielcode";
            this.buttonBeispielCode.UseVisualStyleBackColor = false;
            this.buttonBeispielCode.Click += new System.EventHandler(this.buttonBeispielCode_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(302, 12);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(511, 263);
            this.richTextBoxInfo.TabIndex = 9;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonchessstart
            // 
            this.buttonchessstart.Location = new System.Drawing.Point(12, 799);
            this.buttonchessstart.Name = "buttonchessstart";
            this.buttonchessstart.Size = new System.Drawing.Size(200, 23);
            this.buttonchessstart.TabIndex = 12;
            this.buttonchessstart.Text = "drück mich";
            this.buttonchessstart.UseVisualStyleBackColor = true;
            this.buttonchessstart.Click += new System.EventHandler(this.buttonchessstart_Click);
            // 
            // KnightBox
            // 
            this.KnightBox.BackgroundImage = global::BewerbungDirtingTim.Properties.Resources.white_cartoon_chess_horse_tile_knight_pieces_piece_f;
            this.KnightBox.Location = new System.Drawing.Point(12, 595);
            this.KnightBox.Name = "KnightBox";
            this.KnightBox.Size = new System.Drawing.Size(200, 198);
            this.KnightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KnightBox.TabIndex = 11;
            this.KnightBox.TabStop = false;
            this.KnightBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxDesign2
            // 
            this.pictureBoxDesign2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDesign2.Location = new System.Drawing.Point(-95, 571);
            this.pictureBoxDesign2.Name = "pictureBoxDesign2";
            this.pictureBoxDesign2.Size = new System.Drawing.Size(2808, 18);
            this.pictureBoxDesign2.TabIndex = 10;
            this.pictureBoxDesign2.TabStop = false;
            // 
            // pictureBoxKnight
            // 
            this.pictureBoxKnight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxKnight.Location = new System.Drawing.Point(293, 595);
            this.pictureBoxKnight.Name = "pictureBoxKnight";
            this.pictureBoxKnight.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxKnight.TabIndex = 6;
            this.pictureBoxKnight.TabStop = false;
            this.pictureBoxKnight.Click += new System.EventHandler(this.pictureBoxKnight_Click);
            // 
            // pictureBoxDesign
            // 
            this.pictureBoxDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDesign.Location = new System.Drawing.Point(0, 289);
            this.pictureBoxDesign.Name = "pictureBoxDesign";
            this.pictureBoxDesign.Size = new System.Drawing.Size(2808, 18);
            this.pictureBoxDesign.TabIndex = 5;
            this.pictureBoxDesign.TabStop = false;
            // 
            // buttonPicture
            // 
            this.buttonPicture.BackColor = System.Drawing.Color.White;
            this.buttonPicture.BackgroundImage = global::BewerbungDirtingTim.Properties.Resources.IMG_61;
            this.buttonPicture.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPicture.FlatAppearance.BorderSize = 5;
            this.buttonPicture.Location = new System.Drawing.Point(12, 12);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(234, 263);
            this.buttonPicture.TabIndex = 0;
            this.buttonPicture.UseVisualStyleBackColor = false;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // BewerbungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 897);
            this.Controls.Add(this.buttonchessstart);
            this.Controls.Add(this.KnightBox);
            this.Controls.Add(this.pictureBoxDesign2);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonBeispielCode);
            this.Controls.Add(this.buttonAnlagen);
            this.Controls.Add(this.pictureBoxKnight);
            this.Controls.Add(this.pictureBoxDesign);
            this.Controls.Add(this.buttonAnschreiben);
            this.Controls.Add(this.buttonLebenslauf);
            this.Controls.Add(this.buttonPicture);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "BewerbungsForm";
            this.Text = "Bewerbung Tim Dirting";
            this.Resize += new System.EventHandler(this.BewerbungsForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.KnightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPicture;
        private System.Windows.Forms.Button buttonLebenslauf;
        private System.Windows.Forms.Button buttonAnschreiben;
        private System.Windows.Forms.PictureBox pictureBoxDesign;
        private System.Windows.Forms.Timer PaintingTimer;
        private System.Windows.Forms.PictureBox pictureBoxKnight;
        private System.Windows.Forms.Button buttonAnlagen;
        private System.Windows.Forms.Button buttonBeispielCode;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxDesign2;
        private System.Windows.Forms.PictureBox KnightBox;
        private System.Windows.Forms.Button buttonchessstart;
    }
}

