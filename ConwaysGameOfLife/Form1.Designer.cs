namespace ConwaysGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.resetButton = new System.Windows.Forms.Button();
            this.nextFrameButton = new System.Windows.Forms.Button();
            this.gridSizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.gridScaleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randomChanceBox = new System.Windows.Forms.TextBox();
            this.randomiseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // nextFrameButton
            // 
            this.nextFrameButton.Location = new System.Drawing.Point(12, 72);
            this.nextFrameButton.Name = "nextFrameButton";
            this.nextFrameButton.Size = new System.Drawing.Size(75, 23);
            this.nextFrameButton.TabIndex = 2;
            this.nextFrameButton.Text = "Next Frame";
            this.nextFrameButton.UseVisualStyleBackColor = true;
            this.nextFrameButton.Click += new System.EventHandler(this.nextFrameButton_Click);
            // 
            // gridSizeBox
            // 
            this.gridSizeBox.Location = new System.Drawing.Point(11, 146);
            this.gridSizeBox.Name = "gridSizeBox";
            this.gridSizeBox.Size = new System.Drawing.Size(100, 20);
            this.gridSizeBox.TabIndex = 3;
            this.gridSizeBox.Text = "10";
            this.gridSizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridSizeBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delay (ms)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(10, 237);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(100, 20);
            this.delayBox.TabIndex = 6;
            this.delayBox.Text = "1";
            this.delayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grid Size";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(13, 101);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 8;
            this.startStopButton.Text = "Start/Stop";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // gridScaleBox
            // 
            this.gridScaleBox.Location = new System.Drawing.Point(10, 195);
            this.gridScaleBox.Name = "gridScaleBox";
            this.gridScaleBox.Size = new System.Drawing.Size(100, 20);
            this.gridScaleBox.TabIndex = 9;
            this.gridScaleBox.Text = "10";
            this.gridScaleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridScaleBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grid Scale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Random chance (1-1000)";
            // 
            // randomChanceBox
            // 
            this.randomChanceBox.Location = new System.Drawing.Point(13, 276);
            this.randomChanceBox.Name = "randomChanceBox";
            this.randomChanceBox.Size = new System.Drawing.Size(100, 20);
            this.randomChanceBox.TabIndex = 12;
            this.randomChanceBox.Text = "500";
            this.randomChanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.randomChanceBox_KeyPress);
            // 
            // randomiseButton
            // 
            this.randomiseButton.Location = new System.Drawing.Point(13, 41);
            this.randomiseButton.Name = "randomiseButton";
            this.randomiseButton.Size = new System.Drawing.Size(75, 23);
            this.randomiseButton.TabIndex = 13;
            this.randomiseButton.Text = "Randomise";
            this.randomiseButton.UseVisualStyleBackColor = true;
            this.randomiseButton.Click += new System.EventHandler(this.randomiseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 813);
            this.Controls.Add(this.randomiseButton);
            this.Controls.Add(this.randomChanceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridScaleBox);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSizeBox);
            this.Controls.Add(this.nextFrameButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button nextFrameButton;
        private System.Windows.Forms.TextBox gridSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.TextBox gridScaleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox randomChanceBox;
        private System.Windows.Forms.Button randomiseButton;
    }
}

