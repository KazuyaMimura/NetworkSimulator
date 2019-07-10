namespace NetworkSimulator
{
    partial class FormClient
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTexBox_Data = new System.Windows.Forms.RichTextBox();
            this.richTexBox_Information = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Client_Close = new System.Windows.Forms.Button();
            this.Client_Connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Information";
            // 
            // richTexBox_Data
            // 
            this.richTexBox_Data.Location = new System.Drawing.Point(9, 395);
            this.richTexBox_Data.Name = "richTexBox_Data";
            this.richTexBox_Data.Size = new System.Drawing.Size(675, 140);
            this.richTexBox_Data.TabIndex = 7;
            this.richTexBox_Data.Text = "";
            // 
            // richTexBox_Information
            // 
            this.richTexBox_Information.Location = new System.Drawing.Point(7, 216);
            this.richTexBox_Information.Name = "richTexBox_Information";
            this.richTexBox_Information.Size = new System.Drawing.Size(675, 140);
            this.richTexBox_Information.TabIndex = 6;
            this.richTexBox_Information.Text = "";
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
            // Client_Close
            // 
            this.Client_Close.Location = new System.Drawing.Point(6, 87);
            this.Client_Close.Name = "Client_Close";
            this.Client_Close.Size = new System.Drawing.Size(165, 65);
            this.Client_Close.TabIndex = 1;
            this.Client_Close.Text = "Close";
            this.Client_Close.UseVisualStyleBackColor = true;
            // 
            // Client_Connect
            // 
            this.Client_Connect.Location = new System.Drawing.Point(6, 24);
            this.Client_Connect.Name = "Client_Connect";
            this.Client_Connect.Size = new System.Drawing.Size(165, 65);
            this.Client_Connect.TabIndex = 0;
            this.Client_Connect.Text = "Connect";
            this.Client_Connect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Client_Close);
            this.groupBox1.Controls.Add(this.Client_Connect);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 25);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server IP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(503, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 25);
            this.textBox2.TabIndex = 9;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTexBox_Data);
            this.Controls.Add(this.richTexBox_Information);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClient";
            this.Text = "ClientSimulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTexBox_Data;
        private System.Windows.Forms.RichTextBox richTexBox_Information;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Client_Close;
        private System.Windows.Forms.Button Client_Connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}