namespace capture_Trim_From_Any_Camera
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.passportPic = new System.Windows.Forms.PictureBox();
            this.useCameraBtn = new System.Windows.Forms.Button();
            this.imageFromFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.passportPic)).BeginInit();
            this.SuspendLayout();
            // 
            // passportPic
            // 
            this.passportPic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passportPic.Location = new System.Drawing.Point(40, 89);
            this.passportPic.Name = "passportPic";
            this.passportPic.Size = new System.Drawing.Size(146, 161);
            this.passportPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passportPic.TabIndex = 0;
            this.passportPic.TabStop = false;
            // 
            // useCameraBtn
            // 
            this.useCameraBtn.Location = new System.Drawing.Point(208, 147);
            this.useCameraBtn.Name = "useCameraBtn";
            this.useCameraBtn.Size = new System.Drawing.Size(146, 36);
            this.useCameraBtn.TabIndex = 2;
            this.useCameraBtn.Text = "Capture from camera";
            this.useCameraBtn.UseVisualStyleBackColor = true;
            this.useCameraBtn.Click += new System.EventHandler(this.useCameraBtn_Click);
            // 
            // imageFromFileBtn
            // 
            this.imageFromFileBtn.Location = new System.Drawing.Point(208, 213);
            this.imageFromFileBtn.Name = "imageFromFileBtn";
            this.imageFromFileBtn.Size = new System.Drawing.Size(146, 36);
            this.imageFromFileBtn.TabIndex = 3;
            this.imageFromFileBtn.Text = "Select Image file";
            this.imageFromFileBtn.UseVisualStyleBackColor = true;
            this.imageFromFileBtn.Click += new System.EventHandler(this.imageFromFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please make sure a camera is connected to your machine";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(37, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "For educational purpose only";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(440, 106);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 540);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageFromFileBtn);
            this.Controls.Add(this.useCameraBtn);
            this.Controls.Add(this.passportPic);
            this.Name = "Home";
            this.Text = "Home Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.passportPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox passportPic;
        private System.Windows.Forms.Button useCameraBtn;
        private System.Windows.Forms.Button imageFromFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

