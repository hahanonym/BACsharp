﻿namespace TemplateApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.whoIsButton = new System.Windows.Forms.Button();
            this.readPropertyButton = new System.Windows.Forms.Button();
            this.writePropertyButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonLightOn = new System.Windows.Forms.Button();
            this.buttonLightOff = new System.Windows.Forms.Button();
            this.buttonLightStart = new System.Windows.Forms.Button();
            this.buttonLightStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // whoIsButton
            // 
            this.whoIsButton.Location = new System.Drawing.Point(11, 329);
            this.whoIsButton.Name = "whoIsButton";
            this.whoIsButton.Size = new System.Drawing.Size(75, 23);
            this.whoIsButton.TabIndex = 1;
            this.whoIsButton.Text = "Who Is";
            this.whoIsButton.UseVisualStyleBackColor = true;
            this.whoIsButton.Click += new System.EventHandler(this.whoIsButton_Click);
            // 
            // readPropertyButton
            // 
            this.readPropertyButton.Location = new System.Drawing.Point(92, 329);
            this.readPropertyButton.Name = "readPropertyButton";
            this.readPropertyButton.Size = new System.Drawing.Size(98, 23);
            this.readPropertyButton.TabIndex = 2;
            this.readPropertyButton.Text = "RPM";
            this.readPropertyButton.UseVisualStyleBackColor = true;
            this.readPropertyButton.Click += new System.EventHandler(this.readPropertyButton_Click);
            // 
            // writePropertyButton
            // 
            this.writePropertyButton.Location = new System.Drawing.Point(196, 329);
            this.writePropertyButton.Name = "writePropertyButton";
            this.writePropertyButton.Size = new System.Drawing.Size(88, 23);
            this.writePropertyButton.TabIndex = 3;
            this.writePropertyButton.Text = "Write property";
            this.writePropertyButton.UseVisualStyleBackColor = true;
            this.writePropertyButton.Click += new System.EventHandler(this.writePropertyButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(217, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(302, 277);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(525, 98);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(268, 225);
            this.listBox3.TabIndex = 8;
            // 
            // buttonLightOn
            // 
            this.buttonLightOn.Location = new System.Drawing.Point(816, 13);
            this.buttonLightOn.Name = "buttonLightOn";
            this.buttonLightOn.Size = new System.Drawing.Size(88, 23);
            this.buttonLightOn.TabIndex = 9;
            this.buttonLightOn.Text = "On";
            this.buttonLightOn.UseVisualStyleBackColor = true;
            this.buttonLightOn.Click += new System.EventHandler(this.buttonLightOn_Click);
            // 
            // buttonLightOff
            // 
            this.buttonLightOff.Location = new System.Drawing.Point(816, 42);
            this.buttonLightOff.Name = "buttonLightOff";
            this.buttonLightOff.Size = new System.Drawing.Size(88, 23);
            this.buttonLightOff.TabIndex = 10;
            this.buttonLightOff.Text = "Off";
            this.buttonLightOff.UseVisualStyleBackColor = true;
            this.buttonLightOff.Click += new System.EventHandler(this.buttonLightOff_Click);
            // 
            // buttonLightStart
            // 
            this.buttonLightStart.Location = new System.Drawing.Point(816, 69);
            this.buttonLightStart.Name = "buttonLightStart";
            this.buttonLightStart.Size = new System.Drawing.Size(88, 23);
            this.buttonLightStart.TabIndex = 11;
            this.buttonLightStart.Text = "Start";
            this.buttonLightStart.UseVisualStyleBackColor = true;
            this.buttonLightStart.Click += new System.EventHandler(this.buttonLightStart_Click);
            // 
            // buttonLightStop
            // 
            this.buttonLightStop.Location = new System.Drawing.Point(816, 98);
            this.buttonLightStop.Name = "buttonLightStop";
            this.buttonLightStop.Size = new System.Drawing.Size(88, 23);
            this.buttonLightStop.TabIndex = 12;
            this.buttonLightStop.Text = "Stop";
            this.buttonLightStop.UseVisualStyleBackColor = true;
            this.buttonLightStop.Click += new System.EventHandler(this.buttonLightStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 368);
            this.Controls.Add(this.buttonLightStop);
            this.Controls.Add(this.buttonLightStart);
            this.Controls.Add(this.buttonLightOff);
            this.Controls.Add(this.buttonLightOn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.writePropertyButton);
            this.Controls.Add(this.readPropertyButton);
            this.Controls.Add(this.whoIsButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button whoIsButton;
        private System.Windows.Forms.Button readPropertyButton;
        private System.Windows.Forms.Button writePropertyButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonLightOn;
        private System.Windows.Forms.Button buttonLightOff;
        private System.Windows.Forms.Button buttonLightStart;
        private System.Windows.Forms.Button buttonLightStop;
    }
}

