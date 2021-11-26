
namespace Image_Gallery_App_Windows_Form
{
    partial class Form1
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.GoBack);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(632, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.GoNext);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(233, 371);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(359, 55);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureViewer
            // 
            this.pictureViewer.Image = global::Image_Gallery_App_Windows_Form.Properties.Resources._01;
            this.pictureViewer.Location = new System.Drawing.Point(129, 12);
            this.pictureViewer.Name = "pictureViewer";
            this.pictureViewer.Size = new System.Drawing.Size(567, 343);
            this.pictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureViewer.TabIndex = 3;
            this.pictureViewer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureViewer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "Form1";
            this.Text = "Image Gallery in Windows Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureViewer;
    }
}

