﻿namespace aimoyu
{
    partial class SoTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoTitle));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripList = new System.Windows.Forms.ToolStrip();
            this.toolBtnReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(655, 423);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "章节名";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "链接地址";
            this.columnHeader3.Width = 404;
            // 
            // toolStripList
            // 
            this.toolStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnReturn});
            this.toolStripList.Location = new System.Drawing.Point(0, 0);
            this.toolStripList.Name = "toolStripList";
            this.toolStripList.Size = new System.Drawing.Size(658, 25);
            this.toolStripList.TabIndex = 1;
            this.toolStripList.Text = "toolStrip1";
            // 
            // toolBtnReturn
            // 
            this.toolBtnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnReturn.Image")));
            this.toolBtnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReturn.Name = "toolBtnReturn";
            this.toolBtnReturn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReturn.Text = "toolStripButton1";
            this.toolBtnReturn.Click += new System.EventHandler(this.ToolBtnReturn_Click);
            // 
            // SoTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.toolStripList);
            this.Controls.Add(this.listView1);
            this.Name = "SoTitle";
            this.Text = "章节列表";
            this.toolStripList.ResumeLayout(false);
            this.toolStripList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip toolStripList;
        private System.Windows.Forms.ToolStripButton toolBtnReturn;
    }
}