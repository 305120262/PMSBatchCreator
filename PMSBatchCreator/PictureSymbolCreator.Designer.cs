namespace PMSBatchCreator
{
    partial class PictureSymbolCreator
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
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDepth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(128, 94);
            this.tbxSet.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(345, 25);
            this.tbxSet.TabIndex = 24;
            this.tbxSet.Text = "Default";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "类别";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(128, 34);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(348, 25);
            this.tbxInput.TabIndex = 22;
            this.tbxInput.Text = "D:\\test.style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "符号库";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(125, 153);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(348, 25);
            this.tbxOutput.TabIndex = 29;
            this.tbxOutput.Text = "D:\\test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "图片输出目录";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "……";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "……";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxTarget
            // 
            this.tbxTarget.Location = new System.Drawing.Point(128, 210);
            this.tbxTarget.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTarget.Name = "tbxTarget";
            this.tbxTarget.Size = new System.Drawing.Size(348, 25);
            this.tbxTarget.TabIndex = 33;
            this.tbxTarget.Text = "C:\\PMS.style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "输出符号库";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "图片位数";
            // 
            // cbxDepth
            // 
            this.cbxDepth.FormattingEnabled = true;
            this.cbxDepth.Items.AddRange(new object[] {
            "8bit",
            "32bit"});
            this.cbxDepth.Location = new System.Drawing.Point(128, 270);
            this.cbxDepth.Name = "cbxDepth";
            this.cbxDepth.Size = new System.Drawing.Size(121, 23);
            this.cbxDepth.TabIndex = 35;
            this.cbxDepth.Text = "8bit";
            // 
            // PictureSymbolCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 396);
            this.Controls.Add(this.cbxDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label3);
            this.Name = "PictureSymbolCreator";
            this.Text = " 批量导成ArcGIS点符号到图标";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDepth;
    }
}