using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutiSGO
{
    public partial class Form1 : Form
    {
        public int slot = 2;
        public string UITweakScript = File.ReadAllText(@".\script.js");
        public string autoScript = File.ReadAllText(@".\sgoAuto.js");
        public static int limitHp = 120;
        public static int limitPower = 120;
        public static int floor = 0;
        public string autoFight = "setInterval(function(){autoFight(" + limitHp + "," + limitPower + "," + 4 + ")},11000)";
        public string autoForward = "setInterval(function(){autoForward()},11000);";

        public Form1()
        {
            InitializeComponent();
            init();
        }
        async void init()
        {
            webView21.CreationProperties =
            new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
            webView21.CreationProperties.UserDataFolder = System.IO.Path.Combine(
                Application.StartupPath, $"webView1");
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://swordgale.online/");
            webView22.CreationProperties =
            new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
            webView22.CreationProperties.UserDataFolder = System.IO.Path.Combine(
                Application.StartupPath, $"webView2");
            await webView22.EnsureCoreWebView2Async();
            webView22.CoreWebView2.Navigate("https://swordgale.online/");


        }
        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
                
            }
            WebViewResize();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            WebViewResize();
        }
        public void WebViewResize()
        {
            var viewHeight = this.Height - this.webView21.Top - menuStrip1.Height;
            this.webView21.Height = viewHeight;
            this.webView22.Height = viewHeight;
            var viewWidth = (this.Width / this.slot);
            webView21.Left = 0;
            this.webView21.Width = viewWidth;
            this.webView22.Width = viewWidth;
            webView22.Left = webView21.Width;
            btnAutoFight2.Left = this.webView22.Left;
            btnAutoForward2.Left = btnAutoFight2.Right + 5;
            btnStopAuto2.Left = btnAutoForward2.Right + 5;
            btnLogout2.Left = btnStopAuto2.Right + 5;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (btnAutoFight1.Enabled)
            {
                //await webView21.CoreWebView2.ExecuteScriptAsync(@"javascript:" + autoFight);
                await webView21.CoreWebView2.ExecuteScriptAsync(@"javascript:"+ autoFight);

            }
            btnAutoFight1.Enabled = false;
            btnAutoForward1.Enabled = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (btnAutoFight2.Enabled)
            {
                await webView22.CoreWebView2.ExecuteScriptAsync(@"javascript:" + autoFight);
            }
            btnAutoFight2.Enabled = false;
            btnAutoForward2.Enabled = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await webView21.CoreWebView2.ExecuteScriptAsync(@"javascript:localStorage.clear()");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await webView22.CoreWebView2.ExecuteScriptAsync(@"javascript:localStorage.clear()");
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            webView21.CoreWebView2.ExecuteScriptAsync(autoScript);
            if (UITweakToolStripMenuItem.Checked)
            {
                webView21.CoreWebView2.ExecuteScriptAsync(UITweakScript);
            }
            if (GrayscaleModeToolStripMenuItem.Checked)
            {
                webView21.CoreWebView2.ExecuteScriptAsync(@"document.getElementsByTagName('html')[0].style.filter = 'invert(1) grayscale(1)';");
            }
            btnAutoFight1.Enabled = true;
            btnAutoForward1.Enabled = true;


        }

        private void webView22_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            webView22.CoreWebView2.ExecuteScriptAsync(autoScript);
            if (UITweakToolStripMenuItem.Checked)
            {
                webView22.CoreWebView2.ExecuteScriptAsync(UITweakScript);
            }
            if (GrayscaleModeToolStripMenuItem.Checked)
            {
                webView22.CoreWebView2.ExecuteScriptAsync(@"document.getElementsByTagName('html')[0].style.filter = 'invert(1) grayscale(1)';");
            }
            btnAutoFight2.Enabled = true;
            btnAutoForward2.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " v" + Application.ProductVersion;
            WebViewResize();
        }

        private void UITweakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UITweakToolStripMenuItem.Checked = !UITweakToolStripMenuItem.Checked;
            webView21.Reload();
            webView22.Reload();
        }

        private void GrayscaleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleModeToolStripMenuItem.Checked = !GrayscaleModeToolStripMenuItem.Checked;
            webView21.Reload();
            webView22.Reload();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await webView21.CoreWebView2.ExecuteScriptAsync(@"javascript:" + autoForward);
            btnAutoFight1.Enabled = false;
            btnAutoForward1.Enabled = false;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await webView22.CoreWebView2.ExecuteScriptAsync(@"javascript:" + autoForward);
            btnAutoFight2.Enabled = false;
            btnAutoForward2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webView22.Reload();
        }
        public void EnabledAutoButton()
        {
            btnAutoFight1.Enabled = true;
            btnAutoFight2.Enabled = true;
            btnAutoForward1.Enabled = true;
            btnAutoForward2.Enabled = true;
        }
    }
}
