namespace PraktikaCS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxA = new System.Windows.Forms.TextBox();
            this.boxB = new System.Windows.Forms.TextBox();
            this.boxC = new System.Windows.Forms.TextBox();
            this.boxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "y =        x²  +        x  +        ";
            // 
            // boxA
            // 
            this.boxA.Location = new System.Drawing.Point(55, 22);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(20, 20);
            this.boxA.TabIndex = 7;
            this.boxA.Text = "1";
            // 
            // boxB
            // 
            this.boxB.Location = new System.Drawing.Point(116, 22);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(20, 20);
            this.boxB.TabIndex = 8;
            this.boxB.Text = "-1";
            // 
            // boxC
            // 
            this.boxC.Location = new System.Drawing.Point(174, 22);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(20, 20);
            this.boxC.TabIndex = 9;
            this.boxC.Text = "-2";
            // 
            // boxX
            // 
            this.boxX.Location = new System.Drawing.Point(142, 77);
            this.boxX.Name = "boxX";
            this.boxX.Size = new System.Drawing.Size(42, 20);
            this.boxX.TabIndex = 15;
            this.boxX.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Максимальное X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxX);
            this.Controls.Add(this.boxC);
            this.Controls.Add(this.boxB);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Квадратное уравнение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxA;
        private System.Windows.Forms.TextBox boxB;
        private System.Windows.Forms.TextBox boxC;
        private System.Windows.Forms.TextBox boxX;
        private System.Windows.Forms.Label label2;
    }
}
