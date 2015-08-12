namespace WindowsAutoPrint
{
    partial class FrmConfig
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
            this.chk_AutoUpdate = new System.Windows.Forms.CheckBox();
            this.lbl_StoreID = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.txt_SvPath = new System.Windows.Forms.TextBox();
            this.lbl_SvPath = new System.Windows.Forms.Label();
            this.txt_Api = new System.Windows.Forms.TextBox();
            this.lbl_Api = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_PrinterNm = new System.Windows.Forms.TextBox();
            this.lbl_Printer = new System.Windows.Forms.Label();
            this.txt_ApiPict = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_AutoPrint = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chk_AutoUpdate
            // 
            this.chk_AutoUpdate.AutoSize = true;
            this.chk_AutoUpdate.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_AutoUpdate.Location = new System.Drawing.Point(54, 25);
            this.chk_AutoUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_AutoUpdate.Name = "chk_AutoUpdate";
            this.chk_AutoUpdate.Size = new System.Drawing.Size(146, 31);
            this.chk_AutoUpdate.TabIndex = 0;
            this.chk_AutoUpdate.Text = "自動更新する";
            this.chk_AutoUpdate.UseVisualStyleBackColor = true;
            // 
            // lbl_StoreID
            // 
            this.lbl_StoreID.AutoSize = true;
            this.lbl_StoreID.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_StoreID.Location = new System.Drawing.Point(333, 100);
            this.lbl_StoreID.Name = "lbl_StoreID";
            this.lbl_StoreID.Size = new System.Drawing.Size(59, 27);
            this.lbl_StoreID.TabIndex = 1;
            this.lbl_StoreID.Text = "Value";
            // 
            // txt_Value
            // 
            this.txt_Value.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Value.Location = new System.Drawing.Point(452, 96);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(110, 34);
            this.txt_Value.TabIndex = 2;
            // 
            // txt_SvPath
            // 
            this.txt_SvPath.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_SvPath.Location = new System.Drawing.Point(168, 157);
            this.txt_SvPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SvPath.Name = "txt_SvPath";
            this.txt_SvPath.Size = new System.Drawing.Size(418, 34);
            this.txt_SvPath.TabIndex = 4;
            // 
            // lbl_SvPath
            // 
            this.lbl_SvPath.AutoSize = true;
            this.lbl_SvPath.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SvPath.Location = new System.Drawing.Point(49, 161);
            this.lbl_SvPath.Name = "lbl_SvPath";
            this.lbl_SvPath.Size = new System.Drawing.Size(84, 27);
            this.lbl_SvPath.TabIndex = 3;
            this.lbl_SvPath.Text = "サーバー";
            // 
            // txt_Api
            // 
            this.txt_Api.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Api.Location = new System.Drawing.Point(168, 213);
            this.txt_Api.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Api.Name = "txt_Api";
            this.txt_Api.Size = new System.Drawing.Size(418, 34);
            this.txt_Api.TabIndex = 6;
            // 
            // lbl_Api
            // 
            this.lbl_Api.AutoSize = true;
            this.lbl_Api.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Api.Location = new System.Drawing.Point(49, 218);
            this.lbl_Api.Name = "lbl_Api";
            this.lbl_Api.Size = new System.Drawing.Size(42, 27);
            this.lbl_Api.TabIndex = 5;
            this.lbl_Api.Text = "API";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(165, 422);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(83, 84);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(375, 421);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 86);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_PrinterNm
            // 
            this.txt_PrinterNm.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PrinterNm.Location = new System.Drawing.Point(168, 333);
            this.txt_PrinterNm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PrinterNm.Name = "txt_PrinterNm";
            this.txt_PrinterNm.Size = new System.Drawing.Size(418, 34);
            this.txt_PrinterNm.TabIndex = 10;
            // 
            // lbl_Printer
            // 
            this.lbl_Printer.AutoSize = true;
            this.lbl_Printer.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Printer.Location = new System.Drawing.Point(49, 338);
            this.lbl_Printer.Name = "lbl_Printer";
            this.lbl_Printer.Size = new System.Drawing.Size(102, 27);
            this.lbl_Printer.TabIndex = 9;
            this.lbl_Printer.Text = "プリンタ名";
            // 
            // txt_ApiPict
            // 
            this.txt_ApiPict.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ApiPict.Location = new System.Drawing.Point(168, 268);
            this.txt_ApiPict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ApiPict.Name = "txt_ApiPict";
            this.txt_ApiPict.Size = new System.Drawing.Size(418, 34);
            this.txt_ApiPict.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(49, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "API(画像)";
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Key.Location = new System.Drawing.Point(168, 96);
            this.txt_Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(110, 34);
            this.txt_Key.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Key";
            // 
            // chk_AutoPrint
            // 
            this.chk_AutoPrint.AutoSize = true;
            this.chk_AutoPrint.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_AutoPrint.Location = new System.Drawing.Point(329, 25);
            this.chk_AutoPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_AutoPrint.Name = "chk_AutoPrint";
            this.chk_AutoPrint.Size = new System.Drawing.Size(146, 31);
            this.chk_AutoPrint.TabIndex = 15;
            this.chk_AutoPrint.Text = "自動印刷する";
            this.chk_AutoPrint.UseVisualStyleBackColor = true;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 527);
            this.Controls.Add(this.chk_AutoPrint);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ApiPict);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PrinterNm);
            this.Controls.Add(this.lbl_Printer);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Api);
            this.Controls.Add(this.lbl_Api);
            this.Controls.Add(this.txt_SvPath);
            this.Controls.Add(this.lbl_SvPath);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.lbl_StoreID);
            this.Controls.Add(this.chk_AutoUpdate);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConfig";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_AutoUpdate;
        private System.Windows.Forms.Label lbl_StoreID;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.TextBox txt_SvPath;
        private System.Windows.Forms.Label lbl_SvPath;
        private System.Windows.Forms.TextBox txt_Api;
        private System.Windows.Forms.Label lbl_Api;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_PrinterNm;
        private System.Windows.Forms.Label lbl_Printer;
        private System.Windows.Forms.TextBox txt_ApiPict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_AutoPrint;
    }
}