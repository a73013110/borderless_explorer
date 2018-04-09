namespace borderless_explorer
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
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.url_textarea = new System.Windows.Forms.ToolStripTextBox();
            this.down_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.ToolStripButton();
            this.back_btn = new System.Windows.Forms.ToolStripButton();
            this.forward_btn = new System.Windows.Forms.ToolStripButton();
            this.reload_btn = new System.Windows.Forms.ToolStripButton();
            this.more_btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.clear_cookies_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.down_btn);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1350, 704);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1350, 729);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.BackColor = System.Drawing.Color.White;
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.up_btn,
            this.toolStripSeparator1,
            this.back_btn,
            this.forward_btn,
            this.reload_btn,
            this.url_textarea,
            this.more_btn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // url_textarea
            // 
            this.url_textarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url_textarea.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.url_textarea.Name = "url_textarea";
            this.url_textarea.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.url_textarea.Size = new System.Drawing.Size(686, 25);
            this.url_textarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.url_textarea_KeyPress);
            this.url_textarea.Click += new System.EventHandler(this.url_textarea_Click);
            // 
            // down_btn
            // 
            this.down_btn.BackgroundImage = global::borderless_explorer.Properties.Resources.down;
            this.down_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.down_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.down_btn.Location = new System.Drawing.Point(3, 3);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(23, 22);
            this.down_btn.TabIndex = 2;
            this.down_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Visible = false;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            this.down_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_btn_MouseDown);
            this.down_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.down_btn_MouseMove);
            this.down_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_btn_MouseUp);
            // 
            // up_btn
            // 
            this.up_btn.BackColor = System.Drawing.Color.White;
            this.up_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.up_btn.Image = global::borderless_explorer.Properties.Resources.up;
            this.up_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(23, 22);
            this.up_btn.Text = "無邊框模式";
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.White;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(23, 22);
            this.back_btn.Text = "上一頁";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.BackColor = System.Drawing.Color.White;
            this.forward_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward_btn.Image = ((System.Drawing.Image)(resources.GetObject("forward_btn.Image")));
            this.forward_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(23, 22);
            this.forward_btn.Text = "下一頁";
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // reload_btn
            // 
            this.reload_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reload_btn.Image = ((System.Drawing.Image)(resources.GetObject("reload_btn.Image")));
            this.reload_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(23, 22);
            this.reload_btn.Text = "重新整理";
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // more_btn
            // 
            this.more_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.more_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear_cookies_btn});
            this.more_btn.Image = global::borderless_explorer.Properties.Resources.more;
            this.more_btn.Name = "more_btn";
            this.more_btn.ShowDropDownArrow = false;
            this.more_btn.Size = new System.Drawing.Size(20, 22);
            // 
            // clear_cookies_btn
            // 
            this.clear_cookies_btn.Image = global::borderless_explorer.Properties.Resources.clear_cashe;
            this.clear_cookies_btn.Name = "clear_cookies_btn";
            this.clear_cookies_btn.RightToLeftAutoMirrorImage = true;
            this.clear_cookies_btn.Size = new System.Drawing.Size(180, 22);
            this.clear_cookies_btn.Text = "清空緩存";
            this.clear_cookies_btn.Click += new System.EventHandler(this.clear_cookies_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "無邊框瀏覽器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton up_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.ToolStripButton back_btn;
        private System.Windows.Forms.ToolStripButton forward_btn;
        private System.Windows.Forms.ToolStripTextBox url_textarea;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton reload_btn;
        private System.Windows.Forms.ToolStripDropDownButton more_btn;
        private System.Windows.Forms.ToolStripMenuItem clear_cookies_btn;
    }
}

