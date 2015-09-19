namespace ImageProcessing
{
    partial class FormMain
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelImage = new System.Windows.Forms.Panel();
            this.hScrollBarFilterIntensity = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(606, 375);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(627, 347);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(180, 43);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Загрузить изображение";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg; *.jpeg; *.png";
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.pictureBoxMain);
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(609, 378);
            this.panelImage.TabIndex = 2;
            // 
            // hScrollBarFilterIntensity
            // 
            this.hScrollBarFilterIntensity.Location = new System.Drawing.Point(627, 310);
            this.hScrollBarFilterIntensity.Name = "hScrollBarFilterIntensity";
            this.hScrollBarFilterIntensity.Size = new System.Drawing.Size(180, 20);
            this.hScrollBarFilterIntensity.TabIndex = 3;
            this.hScrollBarFilterIntensity.Value = 46;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(819, 402);
            this.Controls.Add(this.hScrollBarFilterIntensity);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.buttonLoadImage);
            this.Name = "FormMain";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.HScrollBar hScrollBarFilterIntensity;
    }
}

