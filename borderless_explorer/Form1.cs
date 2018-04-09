using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Gma.System.MouseKeyHook;

namespace borderless_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 產生Chrome基底的瀏覽器
            set_webkit();
            // Hook鍵盤滑鼠
            subscribe();
        }

        // 初始化滑鼠、鍵盤Hook
        private IKeyboardMouseEvents m_GlobalHook;
        public void subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseMove += GlobalMouseMove;
        }
        private void GlobalMouseMove(object sender, MouseEventArgs e)
        {
            // 若目前在這個程式, 才用到這功能
            if (this.ContainsFocus)
            {
                int X = this.Location.X;
                int Y = this.Location.Y;
                if (e.X >= X && e.Y >= Y)
                {
                    X = e.X - X;
                    Y = e.Y - Y;
                    //Console.WriteLine("{0}, {1}, {2}", X, Y, this.ContainsFocus);
                    Controll_down_btn_visible(X, Y);
                }
            }                    
        }
        public void unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalMouseMove;
            m_GlobalHook.Dispose();
        }

        // 初始化Chrome
        private ChromiumWebBrowser browser;
        private void set_webkit()
        {
            // 初始化Cef
            CefSettings settings = new CefSettings();
            settings.Locale = "zh-tw";
            settings.CachePath = "cache";
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            Cef.Initialize(settings);
            // 設定起始Url
            url_textarea.Text = "https://www.google.com.tw/";
            // 創建Chrome
            browser = new ChromiumWebBrowser(url_textarea.Text);
            browser.Dock = DockStyle.Fill;
            browser.Location = new Point(0, 0);
            browser.MinimumSize = new Size(20, 20);
            browser.Name = "browser";
            browser.Size = new Size(784, 386);
            browser.TabIndex = 1;
            browser.AddressChanged += Browser_AddressChanged;
            toolStripContainer.ContentPanel.Controls.Add(browser);
            // 在每個頁面加載完的事件, 透過JS實現滑鼠事件
            //browser.FrameLoadEnd += (sender, args) =>
            //{
            //    if (args.Frame.IsMain)
            //    {
            //        var js = "document.addEventListener('mousemove', function(event) { bound.mouse_move(event.clientX, event.clientY); })";
            //        browser.GetMainFrame().ExecuteJavaScriptAsync(js);
            //    }
            //};
            //var obj = new BoundObject();
            //browser.RegisterJsObject("bound", obj);
        }

        // 網址變更事件
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                url_textarea.Text = e.Address;
            }));
        }

        // 供BoundObject Class呼叫
        public void Controll_down_btn_visible(int x, int y)
        {
            this.Invoke(new Action(() => {
                if (x < 30 && y < 30 && toolStripContainer.TopToolStripPanelVisible == false)
                {
                    down_btn.Visible = true;
                }
                else
                {
                    down_btn.Visible = false;
                }
                //Console.WriteLine("{0}, {1}", x, y);
            }));
        }

        // 將上方的工具列收起來
        private void up_btn_Click(object sender, EventArgs e)
        {
            toolStripContainer.TopToolStripPanelVisible = false;
            down_btn.Visible = false;
            // 先記錄目前視窗大小
            Size form_size = this.Size;
            // 將目前視窗邊界消除
            this.FormBorderStyle = FormBorderStyle.None;
            // 還原視窗大小
            this.Size = form_size;
        }

        // 將上方的工具列叫出來
        private void down_btn_Click(object sender, EventArgs e)
        {
            toolStripContainer.TopToolStripPanelVisible = true;
            down_btn.Visible = false;
            // 先記錄目前視窗大小
            Size form_size = this.Size;
            // 顯示目前視窗邊界
            this.FormBorderStyle = FormBorderStyle.Sizable;
            // 還原視窗大小
            this.Size = form_size;
        }

        // 處理視窗移動事件
        private Point mouse_offset;
        // 在視窗上按下滑鼠的事件
        private void down_btn_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
            down_btn.Cursor = Cursors.SizeAll;
        }
        // 滑鼠移動事件
        private void down_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                down_btn.Cursor = Cursors.SizeAll;
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }
        // 滑鼠抬起事件
        private void down_btn_MouseUp(object sender, MouseEventArgs e)
        {
            down_btn.Cursor = Cursors.Hand;
        }

        // 上一頁
        private void back_btn_Click(object sender, EventArgs e)
        {
            browser.Back();
        }
        
        // 下一頁
        private void forward_btn_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        // 重新整理
        private void reload_btn_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        // 點擊網址輸入欄位時, 會先全選其內容
        private void url_textarea_Click(object sender, EventArgs e)
        {
            url_textarea.SelectAll();
        }

        // 輸入網址後按Enter, 前往該網站
        private void url_textarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                browser.Load("https://www.google.com.tw/search?q=" + url_textarea.Text);
                e.Handled = true;
            }
        }

        // 關閉視窗時要處理的事情
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 記得要用這個, 不然內存可能會爆
            Cef.Shutdown();
            // 取消滑鼠hook
            unsubscribe();

            Console.WriteLine("清除內存");
        }

        // 清空cookies
        private void clear_cookies_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("清除Cookies將會登出所有網站, 確定要清除嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Cef.GetGlobalCookieManager().DeleteCookies("", "");
                MessageBox.Show("成功清除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
    }
}
