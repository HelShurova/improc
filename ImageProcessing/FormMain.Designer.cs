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
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioButtonMorphological = new System.Windows.Forms.RadioButton();
            this.groupBoxMorphAdditional = new System.Windows.Forms.GroupBox();
            this.radioButtonDilation = new System.Windows.Forms.RadioButton();
            this.radioButtonErosion = new System.Windows.Forms.RadioButton();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelImage.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxMorphAdditional.SuspendLayout();
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
            this.hScrollBarFilterIntensity.Minimum = 9;
            this.hScrollBarFilterIntensity.Name = "hScrollBarFilterIntensity";
            this.hScrollBarFilterIntensity.Size = new System.Drawing.Size(180, 20);
            this.hScrollBarFilterIntensity.SmallChange = 10;
            this.hScrollBarFilterIntensity.TabIndex = 3;
            this.hScrollBarFilterIntensity.Value = 9;
            this.hScrollBarFilterIntensity.ValueChanged += new System.EventHandler(this.hScrollBarFilterIntensity_ValueChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.radioButtonMorphological);
            this.groupBoxFilter.Location = new System.Drawing.Point(625, 13);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(182, 119);
            this.groupBoxFilter.TabIndex = 4;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Выбор фильтра";
            // 
            // radioButtonMorphological
            // 
            this.radioButtonMorphological.AutoSize = true;
            this.radioButtonMorphological.Checked = true;
            this.radioButtonMorphological.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMorphological.Name = "radioButtonMorphological";
            this.radioButtonMorphological.Size = new System.Drawing.Size(118, 17);
            this.radioButtonMorphological.TabIndex = 0;
            this.radioButtonMorphological.TabStop = true;
            this.radioButtonMorphological.Text = "Морфологический";
            this.radioButtonMorphological.UseVisualStyleBackColor = true;
            this.radioButtonMorphological.CheckedChanged += new System.EventHandler(this.radioButtonMorphological_CheckedChanged);
            // 
            // groupBoxMorphAdditional
            // 
            this.groupBoxMorphAdditional.Controls.Add(this.radioButtonDilation);
            this.groupBoxMorphAdditional.Controls.Add(this.radioButtonErosion);
            this.groupBoxMorphAdditional.Controls.Add(this.radioButtonClose);
            this.groupBoxMorphAdditional.Controls.Add(this.radioButtonOpen);
            this.groupBoxMorphAdditional.Location = new System.Drawing.Point(625, 153);
            this.groupBoxMorphAdditional.Name = "groupBoxMorphAdditional";
            this.groupBoxMorphAdditional.Size = new System.Drawing.Size(182, 117);
            this.groupBoxMorphAdditional.TabIndex = 5;
            this.groupBoxMorphAdditional.TabStop = false;
            this.groupBoxMorphAdditional.Text = "Дополнительные параметры";
            // 
            // radioButtonDilation
            // 
            this.radioButtonDilation.AutoSize = true;
            this.radioButtonDilation.Location = new System.Drawing.Point(7, 92);
            this.radioButtonDilation.Name = "radioButtonDilation";
            this.radioButtonDilation.Size = new System.Drawing.Size(88, 17);
            this.radioButtonDilation.TabIndex = 3;
            this.radioButtonDilation.Text = "Расширение";
            this.radioButtonDilation.UseVisualStyleBackColor = true;
            // 
            // radioButtonErosion
            // 
            this.radioButtonErosion.AutoSize = true;
            this.radioButtonErosion.Checked = true;
            this.radioButtonErosion.Location = new System.Drawing.Point(7, 68);
            this.radioButtonErosion.Name = "radioButtonErosion";
            this.radioButtonErosion.Size = new System.Drawing.Size(69, 17);
            this.radioButtonErosion.TabIndex = 2;
            this.radioButtonErosion.TabStop = true;
            this.radioButtonErosion.Text = "Сужение";
            this.radioButtonErosion.UseVisualStyleBackColor = true;
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Location = new System.Drawing.Point(7, 44);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(77, 17);
            this.radioButtonClose.TabIndex = 1;
            this.radioButtonClose.Text = "Закрытый";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(7, 20);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.Text = "Открытый";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(819, 402);
            this.Controls.Add(this.groupBoxMorphAdditional);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.hScrollBarFilterIntensity);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.buttonLoadImage);
            this.Name = "FormMain";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxMorphAdditional.ResumeLayout(false);
            this.groupBoxMorphAdditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.HScrollBar hScrollBarFilterIntensity;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioButtonMorphological;
        private System.Windows.Forms.GroupBox groupBoxMorphAdditional;
        private System.Windows.Forms.RadioButton radioButtonDilation;
        private System.Windows.Forms.RadioButton radioButtonErosion;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
    }
}

