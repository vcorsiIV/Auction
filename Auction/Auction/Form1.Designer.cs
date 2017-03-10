namespace Auction
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.intRadButton1 = new System.Windows.Forms.RadioButton();
            this.dblRadButton = new System.Windows.Forms.RadioButton();
            this.strRadButton = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.currentBidLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(12, 72);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(222, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // intRadButton1
            // 
            this.intRadButton1.AutoSize = true;
            this.intRadButton1.Checked = true;
            this.intRadButton1.Location = new System.Drawing.Point(12, 109);
            this.intRadButton1.Name = "intRadButton1";
            this.intRadButton1.Size = new System.Drawing.Size(107, 17);
            this.intRadButton1.TabIndex = 3;
            this.intRadButton1.TabStop = true;
            this.intRadButton1.Text = "int (Pay by Credit)";
            this.intRadButton1.UseVisualStyleBackColor = true;
            this.intRadButton1.CheckedChanged += new System.EventHandler(this.radButton1_CheckedChanged);
            // 
            // dblRadButton
            // 
            this.dblRadButton.AutoSize = true;
            this.dblRadButton.Location = new System.Drawing.Point(12, 158);
            this.dblRadButton.Name = "dblRadButton";
            this.dblRadButton.Size = new System.Drawing.Size(125, 17);
            this.dblRadButton.TabIndex = 4;
            this.dblRadButton.Text = "double (Pay by Cash)";
            this.dblRadButton.UseVisualStyleBackColor = true;
            this.dblRadButton.CheckedChanged += new System.EventHandler(this.radButton2_CheckedChanged);
            // 
            // strRadButton
            // 
            this.strRadButton.AutoSize = true;
            this.strRadButton.Location = new System.Drawing.Point(12, 213);
            this.strRadButton.Name = "strRadButton";
            this.strRadButton.Size = new System.Drawing.Size(125, 17);
            this.strRadButton.TabIndex = 5;
            this.strRadButton.Text = "string (Pay by Check)";
            this.strRadButton.UseVisualStyleBackColor = true;
            this.strRadButton.CheckedChanged += new System.EventHandler(this.radButton3_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(234, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Your bid here.";
            // 
            // currentBidLbl
            // 
            this.currentBidLbl.AutoSize = true;
            this.currentBidLbl.Location = new System.Drawing.Point(461, 293);
            this.currentBidLbl.Name = "currentBidLbl";
            this.currentBidLbl.Size = new System.Drawing.Size(97, 13);
            this.currentBidLbl.TabIndex = 7;
            this.currentBidLbl.Text = "Current bid:   $0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Select the method of which you wish to bid.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "We only accept bids over the value of $10.00 dollars.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "If you wish to write a check enter in either $XX.XX or XX.XX dollars for a valid " +
    "acception.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 315);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBidLbl);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.strRadButton);
            this.Controls.Add(this.dblRadButton);
            this.Controls.Add(this.intRadButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton intRadButton1;
        private System.Windows.Forms.RadioButton dblRadButton;
        private System.Windows.Forms.RadioButton strRadButton;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label currentBidLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

