
namespace SGOMaster
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnAutoFight1 = new System.Windows.Forms.Button();
            this.btnLogout1 = new System.Windows.Forms.Button();
            this.btnAutoFight2 = new System.Windows.Forms.Button();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UITweakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoForward1 = new System.Windows.Forms.Button();
            this.btnAutoForward2 = new System.Windows.Forms.Button();
            this.btnStopAuto1 = new System.Windows.Forms.Button();
            this.btnStopAuto2 = new System.Windows.Forms.Button();
            this.floorBox1 = new System.Windows.Forms.ComboBox();
            this.floorBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(6, 91);
            this.webView21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(675, 1076);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // btnAutoFight1
            // 
            this.btnAutoFight1.Location = new System.Drawing.Point(6, 49);
            this.btnAutoFight1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoFight1.Name = "btnAutoFight1";
            this.btnAutoFight1.Size = new System.Drawing.Size(165, 40);
            this.btnAutoFight1.TabIndex = 2;
            this.btnAutoFight1.Text = "自動戰鬥";
            this.btnAutoFight1.UseVisualStyleBackColor = true;
            this.btnAutoFight1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout1
            // 
            this.btnLogout1.Location = new System.Drawing.Point(534, 49);
            this.btnLogout1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogout1.Name = "btnLogout1";
            this.btnLogout1.Size = new System.Drawing.Size(138, 40);
            this.btnLogout1.TabIndex = 3;
            this.btnLogout1.Text = "登出";
            this.btnLogout1.UseVisualStyleBackColor = true;
            this.btnLogout1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAutoFight2
            // 
            this.btnAutoFight2.Location = new System.Drawing.Point(791, 49);
            this.btnAutoFight2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoFight2.Name = "btnAutoFight2";
            this.btnAutoFight2.Size = new System.Drawing.Size(165, 40);
            this.btnAutoFight2.TabIndex = 4;
            this.btnAutoFight2.Text = "自動戰鬥";
            this.btnAutoFight2.UseVisualStyleBackColor = true;
            this.btnAutoFight2.Click += new System.EventHandler(this.button3_Click);
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Location = new System.Drawing.Point(791, 91);
            this.webView22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(675, 1076);
            this.webView22.TabIndex = 5;
            this.webView22.ZoomFactor = 1D;
            this.webView22.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView22_NavigationCompleted);
            // 
            // btnLogout2
            // 
            this.btnLogout2.Location = new System.Drawing.Point(1319, 49);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(138, 40);
            this.btnLogout2.TabIndex = 6;
            this.btnLogout2.Text = "登出";
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1723, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UITweakToolStripMenuItem,
            this.GrayscaleModeToolStripMenuItem});
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(72, 30);
            this.SettingToolStripMenuItem.Text = "設定";
            // 
            // UITweakToolStripMenuItem
            // 
            this.UITweakToolStripMenuItem.Checked = true;
            this.UITweakToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UITweakToolStripMenuItem.Name = "UITweakToolStripMenuItem";
            this.UITweakToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.UITweakToolStripMenuItem.Text = "啟用介面優化插件";
            this.UITweakToolStripMenuItem.Click += new System.EventHandler(this.UITweakToolStripMenuItem_Click);
            // 
            // GrayscaleModeToolStripMenuItem
            // 
            this.GrayscaleModeToolStripMenuItem.Name = "GrayscaleModeToolStripMenuItem";
            this.GrayscaleModeToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.GrayscaleModeToolStripMenuItem.Text = "上班模式";
            this.GrayscaleModeToolStripMenuItem.Click += new System.EventHandler(this.GrayscaleModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "設定";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnAutoForward1
            // 
            this.btnAutoForward1.Location = new System.Drawing.Point(182, 49);
            this.btnAutoForward1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoForward1.Name = "btnAutoForward1";
            this.btnAutoForward1.Size = new System.Drawing.Size(165, 40);
            this.btnAutoForward1.TabIndex = 8;
            this.btnAutoForward1.Text = "自動趕路";
            this.btnAutoForward1.UseVisualStyleBackColor = true;
            this.btnAutoForward1.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAutoForward2
            // 
            this.btnAutoForward2.Location = new System.Drawing.Point(967, 49);
            this.btnAutoForward2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoForward2.Name = "btnAutoForward2";
            this.btnAutoForward2.Size = new System.Drawing.Size(165, 40);
            this.btnAutoForward2.TabIndex = 9;
            this.btnAutoForward2.Text = "自動趕路";
            this.btnAutoForward2.UseVisualStyleBackColor = true;
            this.btnAutoForward2.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnStopAuto1
            // 
            this.btnStopAuto1.Location = new System.Drawing.Point(358, 49);
            this.btnStopAuto1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStopAuto1.Name = "btnStopAuto1";
            this.btnStopAuto1.Size = new System.Drawing.Size(165, 40);
            this.btnStopAuto1.TabIndex = 10;
            this.btnStopAuto1.Text = "停止自動";
            this.btnStopAuto1.UseVisualStyleBackColor = true;
            this.btnStopAuto1.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnStopAuto2
            // 
            this.btnStopAuto2.Location = new System.Drawing.Point(1143, 49);
            this.btnStopAuto2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStopAuto2.Name = "btnStopAuto2";
            this.btnStopAuto2.Size = new System.Drawing.Size(165, 40);
            this.btnStopAuto2.TabIndex = 11;
            this.btnStopAuto2.Text = "停止自動";
            this.btnStopAuto2.UseVisualStyleBackColor = true;
            this.btnStopAuto2.Click += new System.EventHandler(this.button8_Click);
            // 
            // floorBox1
            // 
            this.floorBox1.FormattingEnabled = true;
            this.floorBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.floorBox1.Location = new System.Drawing.Point(681, 54);
            this.floorBox1.Name = "floorBox1";
            this.floorBox1.Size = new System.Drawing.Size(88, 29);
            this.floorBox1.TabIndex = 12;
            this.floorBox1.Text = "3";
            // 
            // floorBox2
            // 
            this.floorBox2.FormattingEnabled = true;
            this.floorBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.floorBox2.Location = new System.Drawing.Point(1466, 56);
            this.floorBox2.Name = "floorBox2";
            this.floorBox2.Size = new System.Drawing.Size(88, 29);
            this.floorBox2.TabIndex = 13;
            this.floorBox2.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 1402);
            this.Controls.Add(this.floorBox2);
            this.Controls.Add(this.floorBox1);
            this.Controls.Add(this.btnStopAuto2);
            this.Controls.Add(this.btnStopAuto1);
            this.Controls.Add(this.btnAutoForward2);
            this.Controls.Add(this.btnAutoForward1);
            this.Controls.Add(this.btnLogout2);
            this.Controls.Add(this.webView22);
            this.Controls.Add(this.btnAutoFight2);
            this.Controls.Add(this.btnLogout1);
            this.Controls.Add(this.btnAutoFight1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "SGOMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnAutoFight1;
        private System.Windows.Forms.Button btnLogout1;
        private System.Windows.Forms.Button btnAutoFight2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UITweakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GrayscaleModeToolStripMenuItem;
        private System.Windows.Forms.Button btnAutoForward1;
        private System.Windows.Forms.Button btnAutoForward2;
        private System.Windows.Forms.Button btnStopAuto1;
        private System.Windows.Forms.Button btnStopAuto2;
        private System.Windows.Forms.ComboBox floorBox1;
        private System.Windows.Forms.ComboBox floorBox2;
    }
}

