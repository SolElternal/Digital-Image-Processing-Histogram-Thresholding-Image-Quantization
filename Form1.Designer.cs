namespace Assignment1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btnInput = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Label();
            this.btnDif = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.listView5 = new System.Windows.Forms.ListView();
            this.btnhis1 = new System.Windows.Forms.Label();
            this.btnHis2 = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.OpenFileImage = new System.Windows.Forms.OpenFileDialog();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.btndiffer = new System.Windows.Forms.Button();
            this.btnhis = new System.Windows.Forms.Button();
            this.btnquan = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(406, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 296);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(788, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(358, 296);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 314);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(391, 35);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(382, 314);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(779, 35);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(382, 314);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btnInput
            // 
            this.btnInput.AutoSize = true;
            this.btnInput.Location = new System.Drawing.Point(156, 363);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(76, 16);
            this.btnInput.TabIndex = 6;
            this.btnInput.Text = "Input Image";
            this.btnInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.AutoSize = true;
            this.btnOutput.Location = new System.Drawing.Point(556, 363);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(86, 16);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Output Image";
            this.btnOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDif
            // 
            this.btnDif.AutoSize = true;
            this.btnDif.Location = new System.Drawing.Point(918, 363);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(109, 16);
            this.btnDif.TabIndex = 8;
            this.btnDif.Text = "Difference Image";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(57, 431);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(367, 296);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(51, 422);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(382, 314);
            this.listView4.TabIndex = 10;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(477, 431);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(367, 296);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // listView5
            // 
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(471, 422);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(382, 314);
            this.listView5.TabIndex = 12;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // btnhis1
            // 
            this.btnhis1.AutoSize = true;
            this.btnhis1.Location = new System.Drawing.Point(199, 750);
            this.btnhis1.Name = "btnhis1";
            this.btnhis1.Size = new System.Drawing.Size(79, 16);
            this.btnhis1.TabIndex = 13;
            this.btnhis1.Text = "Histogram 1";
            this.btnhis1.Click += new System.EventHandler(this.btnhis1_Click);
            // 
            // btnHis2
            // 
            this.btnHis2.AutoSize = true;
            this.btnHis2.Location = new System.Drawing.Point(623, 750);
            this.btnHis2.Name = "btnHis2";
            this.btnHis2.Size = new System.Drawing.Size(79, 16);
            this.btnHis2.TabIndex = 14;
            this.btnHis2.Text = "Histogram 2";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(57, 829);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(216, 65);
            this.btnopen.TabIndex = 15;
            this.btnopen.Text = "OPEN";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileImage
            // 
            this.OpenFileImage.FileName = "OpenFileImage";
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(302, 829);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(216, 65);
            this.btnThreshold.TabIndex = 16;
            this.btnThreshold.Text = "Threshold";
            this.btnThreshold.UseVisualStyleBackColor = true;
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // btndiffer
            // 
            this.btndiffer.Location = new System.Drawing.Point(909, 478);
            this.btndiffer.Name = "btndiffer";
            this.btndiffer.Size = new System.Drawing.Size(216, 65);
            this.btndiffer.TabIndex = 17;
            this.btndiffer.Text = "Image Difference";
            this.btndiffer.UseVisualStyleBackColor = true;
            this.btndiffer.Click += new System.EventHandler(this.btndiffer_Click);
            // 
            // btnhis
            // 
            this.btnhis.Location = new System.Drawing.Point(921, 829);
            this.btnhis.Name = "btnhis";
            this.btnhis.Size = new System.Drawing.Size(216, 65);
            this.btnhis.TabIndex = 18;
            this.btnhis.Text = "Histogram Equalization";
            this.btnhis.UseVisualStyleBackColor = true;
            this.btnhis.Click += new System.EventHandler(this.btnhis_Click);
            // 
            // btnquan
            // 
            this.btnquan.Location = new System.Drawing.Point(681, 829);
            this.btnquan.Name = "btnquan";
            this.btnquan.Size = new System.Drawing.Size(216, 65);
            this.btnquan.TabIndex = 19;
            this.btnquan.Text = "Image Quantization 8";
            this.btnquan.UseVisualStyleBackColor = true;
            this.btnquan.Click += new System.EventHandler(this.btnquan_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(909, 570);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(216, 65);
            this.btnHorizontal.TabIndex = 20;
            this.btnHorizontal.Text = "Flip Horizontal";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(909, 662);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(216, 65);
            this.btnVertical.TabIndex = 21;
            this.btnVertical.Text = "Flip Vertical";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 911);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 65);
            this.button1.TabIndex = 22;
            this.button1.Text = "Image Quantization 16";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 1023);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVertical);
            this.Controls.Add(this.btnHorizontal);
            this.Controls.Add(this.btnquan);
            this.Controls.Add(this.btnhis);
            this.Controls.Add(this.btndiffer);
            this.Controls.Add(this.btnThreshold);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnHis2);
            this.Controls.Add(this.btnhis1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.btnDif);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label btnInput;
        private System.Windows.Forms.Label btnOutput;
        private System.Windows.Forms.Label btnDif;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Label btnhis1;
        private System.Windows.Forms.Label btnHis2;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog OpenFileImage;
        private System.Windows.Forms.Button btnThreshold;
        private System.Windows.Forms.Button btndiffer;
        private System.Windows.Forms.Button btnhis;
        private System.Windows.Forms.Button btnquan;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button button1;
    }
}

