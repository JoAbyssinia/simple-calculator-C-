namespace Simple_Calculator
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
            this.calc_screen = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.remender = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mins = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.thr = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.ziro = new System.Windows.Forms.Button();
            this.ngtv = new System.Windows.Forms.Button();
            this.num_disp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc_screen
            // 
            this.calc_screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calc_screen.AutoSize = true;
            this.calc_screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calc_screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_screen.ForeColor = System.Drawing.Color.Black;
            this.calc_screen.Location = new System.Drawing.Point(12, 58);
            this.calc_screen.MaximumSize = new System.Drawing.Size(250, 50);
            this.calc_screen.MinimumSize = new System.Drawing.Size(250, 30);
            this.calc_screen.Name = "calc_screen";
            this.calc_screen.Size = new System.Drawing.Size(250, 30);
            this.calc_screen.TabIndex = 0;
            this.calc_screen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.calc_screen.UseCompatibleTextRendering = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Red;
            this.clear.Location = new System.Drawing.Point(12, 100);
            this.clear.MinimumSize = new System.Drawing.Size(0, 40);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(128, 40);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // remender
            // 
            this.remender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remender.Location = new System.Drawing.Point(146, 100);
            this.remender.MinimumSize = new System.Drawing.Size(0, 40);
            this.remender.Name = "remender";
            this.remender.Size = new System.Drawing.Size(56, 40);
            this.remender.TabIndex = 2;
            this.remender.Text = "%";
            this.remender.UseVisualStyleBackColor = true;
            this.remender.Click += new System.EventHandler(this.remender_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(209, 100);
            this.add.MinimumSize = new System.Drawing.Size(0, 40);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(51, 40);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 148);
            this.seven.MinimumSize = new System.Drawing.Size(0, 40);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(62, 40);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(80, 148);
            this.eight.MinimumSize = new System.Drawing.Size(0, 40);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 40);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(146, 148);
            this.nine.MinimumSize = new System.Drawing.Size(0, 40);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(56, 40);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // mins
            // 
            this.mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins.Location = new System.Drawing.Point(209, 148);
            this.mins.MinimumSize = new System.Drawing.Size(0, 40);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(51, 40);
            this.mins.TabIndex = 7;
            this.mins.Text = "-";
            this.mins.UseVisualStyleBackColor = true;
            this.mins.Click += new System.EventHandler(this.mins_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(209, 200);
            this.mult.MinimumSize = new System.Drawing.Size(0, 40);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(51, 40);
            this.mult.TabIndex = 11;
            this.mult.Text = "×";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(146, 200);
            this.six.MinimumSize = new System.Drawing.Size(0, 40);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(56, 40);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(80, 200);
            this.five.MinimumSize = new System.Drawing.Size(0, 40);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 40);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 200);
            this.four.MinimumSize = new System.Drawing.Size(0, 40);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(62, 40);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(209, 251);
            this.div.MinimumSize = new System.Drawing.Size(0, 40);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(51, 40);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // thr
            // 
            this.thr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thr.Location = new System.Drawing.Point(146, 251);
            this.thr.MinimumSize = new System.Drawing.Size(0, 40);
            this.thr.Name = "thr";
            this.thr.Size = new System.Drawing.Size(56, 40);
            this.thr.TabIndex = 14;
            this.thr.Text = "3";
            this.thr.UseVisualStyleBackColor = true;
            this.thr.Click += new System.EventHandler(this.thr_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(80, 251);
            this.two.MinimumSize = new System.Drawing.Size(0, 40);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 40);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 251);
            this.one.MinimumSize = new System.Drawing.Size(0, 40);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(62, 40);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.equal.Location = new System.Drawing.Point(209, 302);
            this.equal.MinimumSize = new System.Drawing.Size(0, 40);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(51, 40);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(146, 302);
            this.dot.MinimumSize = new System.Drawing.Size(0, 40);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(56, 40);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // ziro
            // 
            this.ziro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ziro.Location = new System.Drawing.Point(80, 302);
            this.ziro.MinimumSize = new System.Drawing.Size(0, 40);
            this.ziro.Name = "ziro";
            this.ziro.Size = new System.Drawing.Size(60, 40);
            this.ziro.TabIndex = 17;
            this.ziro.Text = "0";
            this.ziro.UseVisualStyleBackColor = true;
            this.ziro.Click += new System.EventHandler(this.ziro_Click);
            // 
            // ngtv
            // 
            this.ngtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngtv.Location = new System.Drawing.Point(12, 302);
            this.ngtv.MinimumSize = new System.Drawing.Size(0, 40);
            this.ngtv.Name = "ngtv";
            this.ngtv.Size = new System.Drawing.Size(62, 40);
            this.ngtv.TabIndex = 16;
            this.ngtv.Text = "+,-";
            this.ngtv.UseVisualStyleBackColor = true;
            this.ngtv.Click += new System.EventHandler(this.ngtv_Click);
            // 
            // num_disp
            // 
            this.num_disp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_disp.AutoSize = true;
            this.num_disp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num_disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_disp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num_disp.Location = new System.Drawing.Point(12, 38);
            this.num_disp.MaximumSize = new System.Drawing.Size(250, 20);
            this.num_disp.MinimumSize = new System.Drawing.Size(250, 20);
            this.num_disp.Name = "num_disp";
            this.num_disp.Size = new System.Drawing.Size(250, 20);
            this.num_disp.TabIndex = 20;
            this.num_disp.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.num_disp);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.ziro);
            this.Controls.Add(this.ngtv);
            this.Controls.Add(this.div);
            this.Controls.Add(this.thr);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.mins);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remender);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calc_screen);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button remender;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mins;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button thr;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button ziro;
        private System.Windows.Forms.Button ngtv;
        public System.Windows.Forms.Label calc_screen;
        public System.Windows.Forms.Label num_disp;
    }
}

