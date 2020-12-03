namespace WfTask3._4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rotateLine = new System.Windows.Forms.Button();
            this.xZeroTextBox = new System.Windows.Forms.TextBox();
            this.yZeroTextBox = new System.Windows.Forms.TextBox();
            this.yOneTextBox = new System.Windows.Forms.TextBox();
            this.xOneTextBox = new System.Windows.Forms.TextBox();
            this.rotateAngle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawFunc
            // 
            this.drawFunc.AutoEllipsis = true;
            this.drawFunc.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawFunc.Location = new System.Drawing.Point(14, 614);
            this.drawFunc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drawFunc.Name = "drawFunc";
            this.drawFunc.Size = new System.Drawing.Size(119, 30);
            this.drawFunc.TabIndex = 0;
            this.drawFunc.Text = "Draw  line";
            this.drawFunc.UseVisualStyleBackColor = true;
            this.drawFunc.Click += new System.EventHandler(this.drawFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "X1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rotateLine
            // 
            this.rotateLine.Location = new System.Drawing.Point(13, 654);
            this.rotateLine.Name = "rotateLine";
            this.rotateLine.Size = new System.Drawing.Size(120, 42);
            this.rotateLine.TabIndex = 5;
            this.rotateLine.Text = "rotate line";
            this.rotateLine.UseVisualStyleBackColor = true;
            this.rotateLine.Click += new System.EventHandler(this.rotateLine_Click);
            // 
            // xZeroTextBox
            // 
            this.xZeroTextBox.Location = new System.Drawing.Point(53, 391);
            this.xZeroTextBox.Name = "xZeroTextBox";
            this.xZeroTextBox.Size = new System.Drawing.Size(80, 30);
            this.xZeroTextBox.TabIndex = 6;
            this.xZeroTextBox.Text = "0";
            // 
            // yZeroTextBox
            // 
            this.yZeroTextBox.Location = new System.Drawing.Point(53, 427);
            this.yZeroTextBox.Name = "yZeroTextBox";
            this.yZeroTextBox.Size = new System.Drawing.Size(80, 30);
            this.yZeroTextBox.TabIndex = 7;
            this.yZeroTextBox.Text = "0";
            // 
            // yOneTextBox
            // 
            this.yOneTextBox.Location = new System.Drawing.Point(53, 499);
            this.yOneTextBox.Name = "yOneTextBox";
            this.yOneTextBox.Size = new System.Drawing.Size(80, 30);
            this.yOneTextBox.TabIndex = 9;
            this.yOneTextBox.Text = "100";
            // 
            // xOneTextBox
            // 
            this.xOneTextBox.Location = new System.Drawing.Point(53, 463);
            this.xOneTextBox.Name = "xOneTextBox";
            this.xOneTextBox.Size = new System.Drawing.Size(80, 30);
            this.xOneTextBox.TabIndex = 8;
            this.xOneTextBox.Text = "100";
            // 
            // rotateAngle
            // 
            this.rotateAngle.Location = new System.Drawing.Point(18, 575);
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(80, 30);
            this.rotateAngle.TabIndex = 11;
            this.rotateAngle.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 548);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "rotate number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 735);
            this.Controls.Add(this.rotateAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yOneTextBox);
            this.Controls.Add(this.xOneTextBox);
            this.Controls.Add(this.yZeroTextBox);
            this.Controls.Add(this.xZeroTextBox);
            this.Controls.Add(this.rotateLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawFunc);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rotateLine;
        private System.Windows.Forms.TextBox xZeroTextBox;
        private System.Windows.Forms.TextBox yZeroTextBox;
        private System.Windows.Forms.TextBox yOneTextBox;
        private System.Windows.Forms.TextBox xOneTextBox;
        private System.Windows.Forms.TextBox rotateAngle;
        private System.Windows.Forms.Label label5;
    }
}

