namespace capture_Trim_From_Any_Camera
{
    partial class captureImageFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capturedPic = new System.Windows.Forms.PictureBox();
            this.livePic = new System.Windows.Forms.PictureBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.captureBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cropPic = new System.Windows.Forms.PictureBox();
            this.useImageBtn = new System.Windows.Forms.Button();
            this.cameraCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step 1: Take Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Step 2: Drag mouse over to crop image";
            // 
            // capturedPic
            // 
            this.capturedPic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.capturedPic.Location = new System.Drawing.Point(24, 349);
            this.capturedPic.Name = "capturedPic";
            this.capturedPic.Size = new System.Drawing.Size(347, 175);
            this.capturedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedPic.TabIndex = 1;
            this.capturedPic.TabStop = false;
            this.capturedPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.capturedPic_MouseDown);
            this.capturedPic.MouseEnter += new System.EventHandler(this.capturedPic_MouseEnter);
            this.capturedPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.capturedPic_MouseMove);
            this.capturedPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.capturedPic_MouseUp);
            // 
            // livePic
            // 
            this.livePic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.livePic.Location = new System.Drawing.Point(24, 35);
            this.livePic.Name = "livePic";
            this.livePic.Size = new System.Drawing.Size(560, 205);
            this.livePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.livePic.TabIndex = 0;
            this.livePic.TabStop = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Location = new System.Drawing.Point(158, 247);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(58, 36);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // captureBtn
            // 
            this.captureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.captureBtn.Location = new System.Drawing.Point(487, 247);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(97, 36);
            this.captureBtn.TabIndex = 7;
            this.captureBtn.Text = "Capture image";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(24, 247);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 36);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start camera";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Step 3: Use image";
            // 
            // cropPic
            // 
            this.cropPic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cropPic.Location = new System.Drawing.Point(408, 349);
            this.cropPic.Name = "cropPic";
            this.cropPic.Size = new System.Drawing.Size(176, 175);
            this.cropPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cropPic.TabIndex = 9;
            this.cropPic.TabStop = false;
            // 
            // useImageBtn
            // 
            this.useImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useImageBtn.Location = new System.Drawing.Point(487, 530);
            this.useImageBtn.Name = "useImageBtn";
            this.useImageBtn.Size = new System.Drawing.Size(97, 36);
            this.useImageBtn.TabIndex = 11;
            this.useImageBtn.Text = "Use image";
            this.useImageBtn.UseVisualStyleBackColor = true;
            this.useImageBtn.Click += new System.EventHandler(this.useImageBtn_Click);
            // 
            // cameraCmb
            // 
            this.cameraCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraCmb.FormattingEnabled = true;
            this.cameraCmb.Location = new System.Drawing.Point(374, 11);
            this.cameraCmb.Name = "cameraCmb";
            this.cameraCmb.Size = new System.Drawing.Size(210, 21);
            this.cameraCmb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose camera:";
            // 
            // captureImageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(601, 581);
            this.Controls.Add(this.cameraCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.useImageBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cropPic);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capturedPic);
            this.Controls.Add(this.livePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "captureImageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capture Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.captureImageFrm_FormClosing);
            this.Load += new System.EventHandler(this.captureImageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capturedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox livePic;
        private System.Windows.Forms.PictureBox capturedPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cropPic;
        private System.Windows.Forms.Button useImageBtn;
        private System.Windows.Forms.ComboBox cameraCmb;
        private System.Windows.Forms.Label label4;
    }
}