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

        private void Form1_Resize(object sender, EventArgs e)
        {
            WebViewResize();
        }
        public void WebViewResize()
        {
            var viewHeight = this.Height - 95;
            this.webView21.Height = viewHeight;
            this.webView22.Height = viewHeight;
            var viewWidth = (this.Width - 11 * this.slot - 5 * (this.slot - 1)) / 2;
            this.webView21.Width = viewWidth;
            webView22.Left = this.webView21.Right + 5;
            this.webView22.Width = viewWidth;
            button3.Left = this.webView22.Left;
            button4.Left = button3.Right + 5;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                await webView21.CoreWebView2.ExecuteScriptAsync(@"javascript:setInterval(function(){document.getElementsByClassName('css-1myfyhp')[0].children[1].click();},11000);");

            }
            button1.Enabled = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                await webView22.CoreWebView2.ExecuteScriptAsync(@"javascript:setInterval(function(){document.getElementsByClassName('css-1myfyhp')[0].children[1].click();},11000);");
            }
            button3.Enabled = false;
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
            if (UITweakToolStripMenuItem.Checked)
            {
                webView21.CoreWebView2.ExecuteScriptAsync(UITweakScript);

            }
            if (!button1.Enabled)
            {
                button1.Enabled = true;
            }

        }

        private void webView22_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (UITweakToolStripMenuItem.Checked)
            {
            webView22.CoreWebView2.ExecuteScriptAsync(UITweakScript);

            }
            if (!button3.Enabled)
            {
                button3.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebViewResize();
        }

        private void UITweakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UITweakToolStripMenuItem.Checked = !UITweakToolStripMenuItem.Checked;
            webView21.Reload();
            webView22.Reload();
        }
    }
}
