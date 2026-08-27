namespace MarkEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            新規作成ToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            名前をつけて保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            印刷ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            オプションToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            編集ToolStripMenuItem = new ToolStripMenuItem();
            元に戻すToolStripMenuItem = new ToolStripMenuItem();
            やり直しToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            切り取りToolStripMenuItem = new ToolStripMenuItem();
            コピーToolStripMenuItem = new ToolStripMenuItem();
            貼り付けToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            すべて選択ToolStripMenuItem = new ToolStripMenuItem();
            挿入ToolStripMenuItem = new ToolStripMenuItem();
            書式ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 編集ToolStripMenuItem, 挿入ToolStripMenuItem, 書式ToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新規作成ToolStripMenuItem, 開くToolStripMenuItem, toolStripSeparator1, 保存ToolStripMenuItem, 名前をつけて保存ToolStripMenuItem, toolStripSeparator5, 印刷ToolStripMenuItem, toolStripSeparator2, オプションToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            新規作成ToolStripMenuItem.Image = Properties.Resources.AddDocument;
            新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            新規作成ToolStripMenuItem.Size = new Size(158, 22);
            新規作成ToolStripMenuItem.Text = "新規作成";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Image = Properties.Resources.OpenFile;
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(158, 22);
            開くToolStripMenuItem.Text = "開く";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Image = Properties.Resources.Save;
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(158, 22);
            保存ToolStripMenuItem.Text = "保存";
            // 
            // 名前をつけて保存ToolStripMenuItem
            // 
            名前をつけて保存ToolStripMenuItem.Image = Properties.Resources.SaveAs;
            名前をつけて保存ToolStripMenuItem.Name = "名前をつけて保存ToolStripMenuItem";
            名前をつけて保存ToolStripMenuItem.Size = new Size(158, 22);
            名前をつけて保存ToolStripMenuItem.Text = "名前をつけて保存";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(155, 6);
            // 
            // 印刷ToolStripMenuItem
            // 
            印刷ToolStripMenuItem.Image = Properties.Resources.Print;
            印刷ToolStripMenuItem.Name = "印刷ToolStripMenuItem";
            印刷ToolStripMenuItem.Size = new Size(158, 22);
            印刷ToolStripMenuItem.Text = "印刷";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(155, 6);
            // 
            // オプションToolStripMenuItem
            // 
            オプションToolStripMenuItem.Image = Properties.Resources.Settings;
            オプションToolStripMenuItem.Name = "オプションToolStripMenuItem";
            オプションToolStripMenuItem.Size = new Size(158, 22);
            オプションToolStripMenuItem.Text = "オプション";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(158, 22);
            終了ToolStripMenuItem.Text = "終了";
            // 
            // 編集ToolStripMenuItem
            // 
            編集ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 元に戻すToolStripMenuItem, やり直しToolStripMenuItem, toolStripSeparator3, 切り取りToolStripMenuItem, コピーToolStripMenuItem, 貼り付けToolStripMenuItem, toolStripSeparator4, すべて選択ToolStripMenuItem });
            編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            編集ToolStripMenuItem.Size = new Size(43, 20);
            編集ToolStripMenuItem.Text = "編集";
            // 
            // 元に戻すToolStripMenuItem
            // 
            元に戻すToolStripMenuItem.Image = Properties.Resources.Undo;
            元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            元に戻すToolStripMenuItem.Size = new Size(127, 22);
            元に戻すToolStripMenuItem.Text = "元に戻す";
            // 
            // やり直しToolStripMenuItem
            // 
            やり直しToolStripMenuItem.Image = Properties.Resources.Redo;
            やり直しToolStripMenuItem.Name = "やり直しToolStripMenuItem";
            やり直しToolStripMenuItem.Size = new Size(127, 22);
            やり直しToolStripMenuItem.Text = "やり直し";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(124, 6);
            // 
            // 切り取りToolStripMenuItem
            // 
            切り取りToolStripMenuItem.Image = Properties.Resources.Cut;
            切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            切り取りToolStripMenuItem.Size = new Size(127, 22);
            切り取りToolStripMenuItem.Text = "切り取り";
            // 
            // コピーToolStripMenuItem
            // 
            コピーToolStripMenuItem.Image = Properties.Resources.Copy;
            コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            コピーToolStripMenuItem.Size = new Size(127, 22);
            コピーToolStripMenuItem.Text = "コピー";
            // 
            // 貼り付けToolStripMenuItem
            // 
            貼り付けToolStripMenuItem.Image = Properties.Resources.Paste;
            貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem";
            貼り付けToolStripMenuItem.Size = new Size(127, 22);
            貼り付けToolStripMenuItem.Text = "貼り付け";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(124, 6);
            // 
            // すべて選択ToolStripMenuItem
            // 
            すべて選択ToolStripMenuItem.Image = Properties.Resources.SelectAll;
            すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem";
            すべて選択ToolStripMenuItem.Size = new Size(127, 22);
            すべて選択ToolStripMenuItem.Text = "すべて選択";
            // 
            // 挿入ToolStripMenuItem
            // 
            挿入ToolStripMenuItem.Name = "挿入ToolStripMenuItem";
            挿入ToolStripMenuItem.Size = new Size(43, 20);
            挿入ToolStripMenuItem.Text = "挿入";
            // 
            // 書式ToolStripMenuItem
            // 
            書式ToolStripMenuItem.Name = "書式ToolStripMenuItem";
            書式ToolStripMenuItem.Size = new Size(43, 20);
            書式ToolStripMenuItem.Text = "書式";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "MarkEditor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 新規作成ToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 名前をつけて保存ToolStripMenuItem;
        private ToolStripMenuItem オプションToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem 編集ToolStripMenuItem;
        private ToolStripMenuItem 元に戻すToolStripMenuItem;
        private ToolStripMenuItem やり直しToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 切り取りToolStripMenuItem;
        private ToolStripMenuItem コピーToolStripMenuItem;
        private ToolStripMenuItem 貼り付けToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem すべて選択ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem 印刷ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 挿入ToolStripMenuItem;
        private ToolStripMenuItem 書式ToolStripMenuItem;
    }
}
