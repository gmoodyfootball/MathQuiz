namespace MoodyGMathQuiz
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.sumPlus = new System.Windows.Forms.Label();
            this.sumEqual = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minusEqual = new System.Windows.Forms.Label();
            this.differenceMinus = new System.Windows.Forms.Label();
            this.minusLabelRight = new System.Windows.Forms.Label();
            this.minusLabelLeft = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.productEqual = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.timesLabelRight = new System.Windows.Forms.Label();
            this.timesLabelLeft = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.quotientEqual = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.dividedLabelRight = new System.Windows.Forms.Label();
            this.dividedLabelLeft = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.Location = new System.Drawing.Point(165, 10);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(101, 25);
            this.timeLeft.TabIndex = 1;
            this.timeLeft.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(156, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumPlus
            // 
            this.sumPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumPlus.Location = new System.Drawing.Point(105, 75);
            this.sumPlus.Name = "sumPlus";
            this.sumPlus.Size = new System.Drawing.Size(60, 50);
            this.sumPlus.TabIndex = 5;
            this.sumPlus.Text = "+";
            this.sumPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sumPlus.Click += new System.EventHandler(this.label3_Click);
            // 
            // sumEqual
            // 
            this.sumEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumEqual.Location = new System.Drawing.Point(206, 75);
            this.sumEqual.Name = "sumEqual";
            this.sumEqual.Size = new System.Drawing.Size(60, 50);
            this.sumEqual.TabIndex = 6;
            this.sumEqual.Text = "=";
            this.sumEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(272, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(272, 130);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 3;
            // 
            // minusEqual
            // 
            this.minusEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEqual.Location = new System.Drawing.Point(206, 121);
            this.minusEqual.Name = "minusEqual";
            this.minusEqual.Size = new System.Drawing.Size(60, 50);
            this.minusEqual.TabIndex = 11;
            this.minusEqual.Text = "=";
            this.minusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differenceMinus
            // 
            this.differenceMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceMinus.Location = new System.Drawing.Point(105, 121);
            this.differenceMinus.Name = "differenceMinus";
            this.differenceMinus.Size = new System.Drawing.Size(60, 50);
            this.differenceMinus.TabIndex = 10;
            this.differenceMinus.Text = "-";
            this.differenceMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLabelRight
            // 
            this.minusLabelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabelRight.Location = new System.Drawing.Point(156, 121);
            this.minusLabelRight.Name = "minusLabelRight";
            this.minusLabelRight.Size = new System.Drawing.Size(60, 50);
            this.minusLabelRight.TabIndex = 9;
            this.minusLabelRight.Text = "?";
            this.minusLabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLabelLeft
            // 
            this.minusLabelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabelLeft.Location = new System.Drawing.Point(50, 121);
            this.minusLabelLeft.Name = "minusLabelLeft";
            this.minusLabelLeft.Size = new System.Drawing.Size(60, 50);
            this.minusLabelLeft.TabIndex = 8;
            this.minusLabelLeft.Text = "?";
            this.minusLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(272, 176);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            // 
            // productEqual
            // 
            this.productEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productEqual.Location = new System.Drawing.Point(206, 167);
            this.productEqual.Name = "productEqual";
            this.productEqual.Size = new System.Drawing.Size(60, 50);
            this.productEqual.TabIndex = 16;
            this.productEqual.Text = "=";
            this.productEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(105, 167);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 50);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "×";
            this.multiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLabelRight
            // 
            this.timesLabelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabelRight.Location = new System.Drawing.Point(156, 167);
            this.timesLabelRight.Name = "timesLabelRight";
            this.timesLabelRight.Size = new System.Drawing.Size(60, 50);
            this.timesLabelRight.TabIndex = 14;
            this.timesLabelRight.Text = "?";
            this.timesLabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLabelLeft
            // 
            this.timesLabelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabelLeft.Location = new System.Drawing.Point(50, 167);
            this.timesLabelLeft.Name = "timesLabelLeft";
            this.timesLabelLeft.Size = new System.Drawing.Size(60, 50);
            this.timesLabelLeft.TabIndex = 13;
            this.timesLabelLeft.Text = "?";
            this.timesLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(272, 222);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            // 
            // quotientEqual
            // 
            this.quotientEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotientEqual.Location = new System.Drawing.Point(206, 213);
            this.quotientEqual.Name = "quotientEqual";
            this.quotientEqual.Size = new System.Drawing.Size(60, 50);
            this.quotientEqual.TabIndex = 21;
            this.quotientEqual.Text = "=";
            this.quotientEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(105, 213);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 50);
            this.divide.TabIndex = 20;
            this.divide.Text = "÷";
            this.divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLabelRight
            // 
            this.dividedLabelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLabelRight.Location = new System.Drawing.Point(156, 213);
            this.dividedLabelRight.Name = "dividedLabelRight";
            this.dividedLabelRight.Size = new System.Drawing.Size(60, 50);
            this.dividedLabelRight.TabIndex = 19;
            this.dividedLabelRight.Text = "?";
            this.dividedLabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLabelLeft
            // 
            this.dividedLabelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLabelLeft.Location = new System.Drawing.Point(50, 213);
            this.dividedLabelLeft.Name = "dividedLabelLeft";
            this.dividedLabelLeft.Size = new System.Drawing.Size(60, 50);
            this.dividedLabelLeft.TabIndex = 18;
            this.dividedLabelLeft.Text = "?";
            this.dividedLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(161, 298);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 358);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.quotientEqual);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.dividedLabelRight);
            this.Controls.Add(this.dividedLabelLeft);
            this.Controls.Add(this.product);
            this.Controls.Add(this.productEqual);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.timesLabelRight);
            this.Controls.Add(this.timesLabelLeft);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusEqual);
            this.Controls.Add(this.differenceMinus);
            this.Controls.Add(this.minusLabelRight);
            this.Controls.Add(this.minusLabelLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sumEqual);
            this.Controls.Add(this.sumPlus);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label sumPlus;
        private System.Windows.Forms.Label sumEqual;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusEqual;
        private System.Windows.Forms.Label differenceMinus;
        private System.Windows.Forms.Label minusLabelRight;
        private System.Windows.Forms.Label minusLabelLeft;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label productEqual;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label timesLabelRight;
        private System.Windows.Forms.Label timesLabelLeft;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label quotientEqual;
        private System.Windows.Forms.Label divide;
        private System.Windows.Forms.Label dividedLabelRight;
        private System.Windows.Forms.Label dividedLabelLeft;
        private System.Windows.Forms.Button startButton;
    }
}

