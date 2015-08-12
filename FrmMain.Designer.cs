namespace WindowsAutoPrint
{
    partial class frm_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lbl_Key = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.chk_AutoUpdate = new System.Windows.Forms.CheckBox();
            this.txt_Result = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noty_Task = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_Task = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timmer_Update = new System.Windows.Forms.Timer(this.components);
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.chk_AutoPrint = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.menu_Task.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Key.Location = new System.Drawing.Point(20, 63);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(42, 27);
            this.lbl_Key.TabIndex = 1;
            this.lbl_Key.Text = "key";
            // 
            // txt_Value
            // 
            this.txt_Value.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Value.Location = new System.Drawing.Point(133, 99);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.ReadOnly = true;
            this.txt_Value.Size = new System.Drawing.Size(277, 34);
            this.txt_Value.TabIndex = 2;
            this.txt_Value.Text = "1";
            // 
            // chk_AutoUpdate
            // 
            this.chk_AutoUpdate.AutoSize = true;
            this.chk_AutoUpdate.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_AutoUpdate.Location = new System.Drawing.Point(25, 23);
            this.chk_AutoUpdate.Name = "chk_AutoUpdate";
            this.chk_AutoUpdate.Size = new System.Drawing.Size(182, 31);
            this.chk_AutoUpdate.TabIndex = 0;
            this.chk_AutoUpdate.Text = "自動チェックする";
            this.chk_AutoUpdate.UseVisualStyleBackColor = true;
            this.chk_AutoUpdate.CheckStateChanged += new System.EventHandler(this.chk_AutoUpdate_CheckStateChanged);
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Result.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Result.Location = new System.Drawing.Point(12, 3);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(452, 89);
            this.txt_Result.TabIndex = 4;
            this.txt_Result.TabStop = false;
            this.txt_Result.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_AutoPrint);
            this.groupBox1.Controls.Add(this.txt_Key);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Value);
            this.groupBox1.Controls.Add(this.lbl_Key);
            this.groupBox1.Controls.Add(this.chk_AutoUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Key.Location = new System.Drawing.Point(133, 60);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.ReadOnly = true;
            this.txt_Key.Size = new System.Drawing.Size(277, 34);
            this.txt_Key.TabIndex = 1;
            this.txt_Key.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "value";
            // 
            // noty_Task
            // 
            this.noty_Task.ContextMenuStrip = this.menu_Task;
            this.noty_Task.Icon = ((System.Drawing.Icon)(resources.GetObject("noty_Task.Icon")));
            this.noty_Task.Text = "マルノ薬局";
            this.noty_Task.Visible = true;
            this.noty_Task.DoubleClick += new System.EventHandler(this.noty_Task_DoubleClick);
            // 
            // menu_Task
            // 
            this.menu_Task.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_Task.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.menu_Task.Name = "menu_Task";
            this.menu_Task.Size = new System.Drawing.Size(134, 94);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // timmer_Update
            // 
            this.timmer_Update.Interval = 20000;
            this.timmer_Update.Tick += new System.EventHandler(this.timmer_Update_Tick);
            // 
            // btn_Print
            // 
            this.btn_Print.BackgroundImage = global::WindowsAutoPrint.Properties.Resources.print;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Print.Location = new System.Drawing.Point(479, 87);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Print.Size = new System.Drawing.Size(111, 75);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.TabStop = false;
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackgroundImage = global::WindowsAutoPrint.Properties.Resources.config;
            this.btn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Config.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Config.Location = new System.Drawing.Point(479, 9);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Config.Size = new System.Drawing.Size(111, 72);
            this.btn_Config.TabIndex = 7;
            this.btn_Config.TabStop = false;
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackgroundImage = global::WindowsAutoPrint.Properties.Resources.update;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Update.Location = new System.Drawing.Point(479, 167);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(111, 80);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // chk_AutoPrint
            // 
            this.chk_AutoPrint.AutoSize = true;
            this.chk_AutoPrint.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_AutoPrint.Location = new System.Drawing.Point(264, 22);
            this.chk_AutoPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_AutoPrint.Name = "chk_AutoPrint";
            this.chk_AutoPrint.Size = new System.Drawing.Size(146, 31);
            this.chk_AutoPrint.TabIndex = 16;
            this.chk_AutoPrint.Text = "自動印刷する";
            this.chk_AutoPrint.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 253);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Update);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "APP更新モニター";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menu_Task.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.CheckBox chk_AutoUpdate;
        private System.Windows.Forms.RichTextBox txt_Result;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon noty_Task;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ContextMenuStrip menu_Task;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.Timer timmer_Update;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_AutoPrint;
    }
}

