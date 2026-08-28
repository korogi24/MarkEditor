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
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            新規作成ToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            名前をつけて保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            印刷ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            オプションToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            編集ToolStripMenuItem = new ToolStripMenuItem();
            元に戻すToolStripMenuItem = new ToolStripMenuItem();
            やり直しToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            切り取りToolStripMenuItem = new ToolStripMenuItem();
            コピーToolStripMenuItem = new ToolStripMenuItem();
            貼り付けToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            すべて選択ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 編集ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新規作成ToolStripMenuItem, 開くToolStripMenuItem, toolStripSeparator1, 保存ToolStripMenuItem, 名前をつけて保存ToolStripMenuItem, toolStripSeparator2, 印刷ToolStripMenuItem, toolStripSeparator3, オプションToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            新規作成ToolStripMenuItem.Image = Properties.IconResources.NewDocument;
            新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            新規作成ToolStripMenuItem.Size = new Size(180, 22);
            新規作成ToolStripMenuItem.Text = "新規作成";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Image = Properties.IconResources.OpenFile;
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Image = Properties.IconResources.Save;
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存";
            // 
            // 名前をつけて保存ToolStripMenuItem
            // 
            名前をつけて保存ToolStripMenuItem.Image = Properties.IconResources.SaveAs;
            名前をつけて保存ToolStripMenuItem.Name = "名前をつけて保存ToolStripMenuItem";
            名前をつけて保存ToolStripMenuItem.Size = new Size(180, 22);
            名前をつけて保存ToolStripMenuItem.Text = "名前をつけて保存";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // 印刷ToolStripMenuItem
            // 
            印刷ToolStripMenuItem.Image = Properties.IconResources.Print;
            印刷ToolStripMenuItem.Name = "印刷ToolStripMenuItem";
            印刷ToolStripMenuItem.Size = new Size(180, 22);
            印刷ToolStripMenuItem.Text = "印刷";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // オプションToolStripMenuItem
            // 
            オプションToolStripMenuItem.Image = Properties.IconResources.Settings;
            オプションToolStripMenuItem.Name = "オプションToolStripMenuItem";
            オプションToolStripMenuItem.Size = new Size(180, 22);
            オプションToolStripMenuItem.Text = "オプション";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(180, 22);
            終了ToolStripMenuItem.Text = "終了";
            // 
            // 編集ToolStripMenuItem
            // 
            編集ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 元に戻すToolStripMenuItem, やり直しToolStripMenuItem, toolStripSeparator4, 切り取りToolStripMenuItem, コピーToolStripMenuItem, 貼り付けToolStripMenuItem, toolStripSeparator5, すべて選択ToolStripMenuItem });
            編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            編集ToolStripMenuItem.Size = new Size(43, 20);
            編集ToolStripMenuItem.Text = "編集";
            // 
            // 元に戻すToolStripMenuItem
            // 
            元に戻すToolStripMenuItem.Image = Properties.IconResources.Undo;
            元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            元に戻すToolStripMenuItem.Size = new Size(180, 22);
            元に戻すToolStripMenuItem.Text = "元に戻す";
            // 
            // やり直しToolStripMenuItem
            // 
            やり直しToolStripMenuItem.Image = Properties.IconResources.Redo;
            やり直しToolStripMenuItem.Name = "やり直しToolStripMenuItem";
            やり直しToolStripMenuItem.Size = new Size(180, 22);
            やり直しToolStripMenuItem.Text = "やり直し";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // 切り取りToolStripMenuItem
            // 
            切り取りToolStripMenuItem.Image = Properties.IconResources.Cut;
            切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            切り取りToolStripMenuItem.Size = new Size(180, 22);
            切り取りToolStripMenuItem.Text = "切り取り";
            // 
            // コピーToolStripMenuItem
            // 
            コピーToolStripMenuItem.Image = Properties.IconResources.Copy;
            コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            コピーToolStripMenuItem.Size = new Size(180, 22);
            コピーToolStripMenuItem.Text = "コピー";
            // 
            // 貼り付けToolStripMenuItem
            // 
            貼り付けToolStripMenuItem.Image = Properties.IconResources.Paste;
            貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem";
            貼り付けToolStripMenuItem.Size = new Size(180, 22);
            貼り付けToolStripMenuItem.Text = "貼り付け";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // すべて選択ToolStripMenuItem
            // 
            すべて選択ToolStripMenuItem.Image = Properties.IconResources.SelectAll;
            すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem";
            すべて選択ToolStripMenuItem.Size = new Size(180, 22);
            すべて選択ToolStripMenuItem.Text = "すべて選択";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "MarkEidtor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 新規作成ToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 名前をつけて保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 印刷ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem オプションToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripMenuItem 編集ToolStripMenuItem;
        private ToolStripMenuItem 元に戻すToolStripMenuItem;
        private ToolStripMenuItem やり直しToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem 切り取りToolStripMenuItem;
        private ToolStripMenuItem コピーToolStripMenuItem;
        private ToolStripMenuItem 貼り付けToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem すべて選択ToolStripMenuItem;
    }
}
