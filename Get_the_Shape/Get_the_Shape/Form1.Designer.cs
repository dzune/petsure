namespace Get_the_Shape
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.NumericUpDown();
            this.txtRight = new System.Windows.Forms.NumericUpDown();
            this.txtTop = new System.Windows.Forms.NumericUpDown();
            this.txtBottom = new System.Windows.Forms.NumericUpDown();
            this.cmdGo = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square or Rectangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Side:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Right Side:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Top Side:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bottom Side:";
            // 
            // txtLeft
            // 
            this.txtLeft.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtLeft.Location = new System.Drawing.Point(145, 127);
            this.txtLeft.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(85, 20);
            this.txtLeft.TabIndex = 5;
            this.txtLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRight
            // 
            this.txtRight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtRight.Location = new System.Drawing.Point(145, 163);
            this.txtRight.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(85, 20);
            this.txtRight.TabIndex = 6;
            this.txtRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTop
            // 
            this.txtTop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtTop.Location = new System.Drawing.Point(145, 199);
            this.txtTop.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(85, 20);
            this.txtTop.TabIndex = 7;
            this.txtTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBottom
            // 
            this.txtBottom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBottom.Location = new System.Drawing.Point(145, 234);
            this.txtBottom.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(85, 20);
            this.txtBottom.TabIndex = 8;
            this.txtBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(141, 294);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(89, 27);
            this.cmdGo.TabIndex = 9;
            this.cmdGo.Text = "&Go";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(60, 294);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 27);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "&Clear";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "IRENEO LAO\r\ndzunelao@gmail.com";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Get_the_Shape.Properties.Resources.petsure;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 72);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise";
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtLeft;
        private System.Windows.Forms.NumericUpDown txtRight;
        private System.Windows.Forms.NumericUpDown txtTop;
        private System.Windows.Forms.NumericUpDown txtBottom;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

