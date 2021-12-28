
namespace PhotoPlayer
{
    partial class PhotoPlayerForm
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
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRemovePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(181, 23);
            this.buttonLoadPicture.TabIndex = 0;
            this.buttonLoadPicture.Text = "Wczytaj zdjęcie";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRemovePhoto
            // 
            this.buttonRemovePhoto.Location = new System.Drawing.Point(12, 12);
            this.buttonRemovePhoto.Name = "buttonRemovePhoto";
            this.buttonRemovePhoto.Size = new System.Drawing.Size(181, 23);
            this.buttonRemovePhoto.TabIndex = 2;
            this.buttonRemovePhoto.Text = "Usuń zdjęcie";
            this.buttonRemovePhoto.UseVisualStyleBackColor = true;
            this.buttonRemovePhoto.Visible = false;
            this.buttonRemovePhoto.Click += new System.EventHandler(this.buttonRemovePhoto_Click);
            // 
            // PhotoPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 122);
            this.Controls.Add(this.buttonRemovePhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLoadPicture);
            this.Name = "PhotoPlayerForm";
            this.Text = "Photo Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhotoPlayerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRemovePhoto;
    }
}

