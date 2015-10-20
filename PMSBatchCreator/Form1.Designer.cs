namespace PMSBatchCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tbxFolder = new System.Windows.Forms.TextBox();
            this.cbIsScale = new System.Windows.Forms.CheckBox();
            this.cbIsFileName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.cbxPType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成符号库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxFolder
            // 
            this.tbxFolder.Location = new System.Drawing.Point(97, 46);
            this.tbxFolder.Name = "tbxFolder";
            this.tbxFolder.Size = new System.Drawing.Size(262, 21);
            this.tbxFolder.TabIndex = 1;
            this.tbxFolder.Text = "C:\\图标";
            // 
            // cbIsScale
            // 
            this.cbIsScale.AutoSize = true;
            this.cbIsScale.Location = new System.Drawing.Point(260, 251);
            this.cbIsScale.Name = "cbIsScale";
            this.cbIsScale.Size = new System.Drawing.Size(72, 16);
            this.cbIsScale.TabIndex = 3;
            this.cbIsScale.Text = "缩放图片";
            this.cbIsScale.UseVisualStyleBackColor = true;
            this.cbIsScale.Visible = false;
            // 
            // cbIsFileName
            // 
            this.cbIsFileName.AutoSize = true;
            this.cbIsFileName.Checked = true;
            this.cbIsFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsFileName.Location = new System.Drawing.Point(95, 251);
            this.cbIsFileName.Name = "cbIsFileName";
            this.cbIsFileName.Size = new System.Drawing.Size(120, 16);
            this.cbIsFileName.TabIndex = 4;
            this.cbIsFileName.Text = "按文件名命名符号";
            this.cbIsFileName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "图标文件夹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "图片格式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "输出符号库";
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(95, 199);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(262, 21);
            this.tbxOutput.TabIndex = 8;
            this.tbxOutput.Text = "C:\\PMS.style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "符号大小";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(97, 123);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(262, 21);
            this.tbxSize.TabIndex = 9;
            this.tbxSize.Text = "8";
            // 
            // cbxPType
            // 
            this.cbxPType.FormattingEnabled = true;
            this.cbxPType.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "JPEG",
            "EMF"});
            this.cbxPType.Location = new System.Drawing.Point(95, 85);
            this.cbxPType.Name = "cbxPType";
            this.cbxPType.Size = new System.Drawing.Size(121, 20);
            this.cbxPType.TabIndex = 11;
            this.cbxPType.Text = "PNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "类别";
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(97, 161);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(260, 21);
            this.tbxSet.TabIndex = 13;
            this.tbxSet.Text = "Default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 358);
            this.Controls.Add(this.tbxSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxPType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIsFileName);
            this.Controls.Add(this.cbIsScale);
            this.Controls.Add(this.tbxFolder);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "批量导入图标生成样式库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxFolder;
        private System.Windows.Forms.CheckBox cbIsScale;
        private System.Windows.Forms.CheckBox cbIsFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.ComboBox cbxPType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSet;
    }
}

