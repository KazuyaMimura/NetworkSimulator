namespace NetworkSimulator
{
    partial class FormServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTexBox_Information = new System.Windows.Forms.RichTextBox();
            this.richTexBox_Data = new System.Windows.Forms.RichTextBox();
            this.Server_Listen_Accept = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Server_Listen_Accept);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // richTexBox_Information
            // 
            this.richTexBox_Information.Location = new System.Drawing.Point(10, 222);
            this.richTexBox_Information.Name = "richTexBox_Information";
            this.richTexBox_Information.Size = new System.Drawing.Size(675, 140);
            this.richTexBox_Information.TabIndex = 1;
            this.richTexBox_Information.Text = "";
            // 
            // richTexBox_Data
            // 
            this.richTexBox_Data.Location = new System.Drawing.Point(12, 401);
            this.richTexBox_Data.Name = "richTexBox_Data";
            this.richTexBox_Data.Size = new System.Drawing.Size(675, 140);
            this.richTexBox_Data.TabIndex = 2;
            this.richTexBox_Data.Text = "";
            // 
            // Server_Listen_Accept
            // 
            this.Server_Listen_Accept.Location = new System.Drawing.Point(6, 24);
            this.Server_Listen_Accept.Name = "Server_Listen_Accept";
            this.Server_Listen_Accept.Size = new System.Drawing.Size(165, 65);
            this.Server_Listen_Accept.TabIndex = 0;
            this.Server_Listen_Accept.Text = "Listen && Accept";
            this.Server_Listen_Accept.UseVisualStyleBackColor = true;
            this.Server_Listen_Accept.Click += new System.EventHandler(this.Server_Listen_Accept_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 65);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(332, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 65);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(495, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 65);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 25);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listen Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTexBox_Data);
            this.Controls.Add(this.richTexBox_Information);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormServer";
            this.Text = "ServerSimulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Server_Listen_Accept;
        private System.Windows.Forms.RichTextBox richTexBox_Information;
        private System.Windows.Forms.RichTextBox richTexBox_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}