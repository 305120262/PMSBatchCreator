namespace PMSBatchCreator
{
    partial class SymbolBookCreator
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPoint = new System.Windows.Forms.CheckBox();
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.cbArea = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLabelSize = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(121, 38);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(348, 25);
            this.tbxInput.TabIndex = 10;
            this.tbxInput.Text = "C:\\MyStyle.style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "符号库";
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(121, 98);
            this.tbxSet.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(345, 25);
            this.tbxSet.TabIndex = 15;
            this.tbxSet.Text = "Default";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "类别";
            // 
            // cbPoint
            // 
            this.cbPoint.AutoSize = true;
            this.cbPoint.Checked = true;
            this.cbPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPoint.Location = new System.Drawing.Point(117, 295);
            this.cbPoint.Margin = new System.Windows.Forms.Padding(4);
            this.cbPoint.Name = "cbPoint";
            this.cbPoint.Size = new System.Drawing.Size(74, 19);
            this.cbPoint.TabIndex = 16;
            this.cbPoint.Text = "点符号";
            this.cbPoint.UseVisualStyleBackColor = true;
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.Checked = true;
            this.cbLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLine.Location = new System.Drawing.Point(246, 295);
            this.cbLine.Margin = new System.Windows.Forms.Padding(4);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(74, 19);
            this.cbLine.TabIndex = 17;
            this.cbLine.Text = "线符号";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // cbArea
            // 
            this.cbArea.AutoSize = true;
            this.cbArea.Checked = true;
            this.cbArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbArea.Location = new System.Drawing.Point(377, 294);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(74, 19);
            this.cbArea.TabIndex = 18;
            this.cbArea.Text = "面符号";
            this.cbArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "点图标大小";
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(121, 168);
            this.tbxSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(132, 25);
            this.tbxSize.TabIndex = 20;
            this.tbxSize.Text = "30";
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.Checked = true;
            this.cbGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrid.Location = new System.Drawing.Point(377, 234);
            this.cbGrid.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(89, 19);
            this.cbGrid.TabIndex = 21;
            this.cbGrid.Text = "绘制网格";
            this.cbGrid.UseVisualStyleBackColor = true;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(118, 354);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(348, 25);
            this.tbxOutput.TabIndex = 23;
            this.tbxOutput.Text = "D:\\MySymbolBook.pdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "输出PDF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "名称文本大小";
            // 
            // tbxLabelSize
            // 
            this.tbxLabelSize.Location = new System.Drawing.Point(118, 228);
            this.tbxLabelSize.Name = "tbxLabelSize";
            this.tbxLabelSize.Size = new System.Drawing.Size(135, 25);
            this.tbxLabelSize.TabIndex = 25;
            this.tbxLabelSize.Text = "8";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(337, 168);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(132, 25);
            this.tbxWidth.TabIndex = 26;
            this.tbxWidth.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "线宽";
            // 
            // SymbolBookCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxLabelSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrid);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbLine);
            this.Controls.Add(this.cbPoint);
            this.Controls.Add(this.tbxSet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SymbolBookCreator";
            this.Text = "生成ArcGIS符号图集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPoint;
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLabelSize;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label label6;
    }
}