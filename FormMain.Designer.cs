namespace NetworkSimulator
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainServer = new System.Windows.Forms.Button();
            this.MainClient = new System.Windows.Forms.Button();
            this.MainSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainServer
            // 
            this.MainServer.Location = new System.Drawing.Point(12, 22);
            this.MainServer.Name = "MainServer";
            this.MainServer.Size = new System.Drawing.Size(150, 170);
            this.MainServer.TabIndex = 0;
            this.MainServer.Text = "Server";
            this.MainServer.UseVisualStyleBackColor = true;
            this.MainServer.Click += new System.EventHandler(this.MainServer_Click);
            // 
            // MainClient
            // 
            this.MainClient.Location = new System.Drawing.Point(160, 22);
            this.MainClient.Name = "MainClient";
            this.MainClient.Size = new System.Drawing.Size(150, 170);
            this.MainClient.TabIndex = 1;
            this.MainClient.Text = "Client";
            this.MainClient.UseVisualStyleBackColor = true;
            this.MainClient.Click += new System.EventHandler(this.MainClient_Click);
            // 
            // MainSetting
            // 
            this.MainSetting.Location = new System.Drawing.Point(308, 22);
            this.MainSetting.Name = "MainSetting";
            this.MainSetting.Size = new System.Drawing.Size(150, 170);
            this.MainSetting.TabIndex = 2;
            this.MainSetting.Text = "Setting";
            this.MainSetting.UseVisualStyleBackColor = true;
            this.MainSetting.Click += new System.EventHandler(this.MainSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright © Kazuya Mimura";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 250);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainSetting);
            this.Controls.Add(this.MainClient);
            this.Controls.Add(this.MainServer);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NetworkSimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainServer;
        private System.Windows.Forms.Button MainClient;
        private System.Windows.Forms.Button MainSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}

