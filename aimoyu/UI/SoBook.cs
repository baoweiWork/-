﻿using aimoyu.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI
{
    public partial class SoBook : Form
    {
        public SoBook()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
        }

        /// <summary>
        /// 搜索书名
        /// </summary>
        public string bookName = "";

        //实例化一个委托
        public showForm sFrom;

        // 搜索
        private void BtnSearck_Click(object sender, EventArgs e)
        {
            try
            {
                PublicServices.MessageBoxShow(this.PointToScreen(new Point(0, 0)));
                if (this.listTitle.Items.Count > 0)
                    this.listTitle.Items.Clear();
                //创建TestClass类的对象
                ThreadServices threadClass = new ThreadServices()
                {
                    //在testclass对象的mainThread(委托)对象上搭载方法，在线程中调用mainThread对象时相当于调用了这方法。 
                    mainThread2 = new ThreadServices.WebDataDelegate2(SoBookData)
                };
                //启动线程，启动之后线程才开始执行 
                void starter() { threadClass.QueryData(); }
                new Thread(starter).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        // 选中行更改
        private void ListTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.listTitle.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string stitleName = this.listTitle.Items[index].SubItems[1].Text;//书名
                    string sPartName = this.listTitle.Items[index].SubItems[3].Text;//目录地址
                    XmlServices.AddHomeDirectory(stitleName, sPartName);
                    SoTitle objForm = new SoTitle()
                    {
                        titleUrl = sPartName,
                        bookName = this.txtBookName.Text,
                        sFrom = sFrom
                    };
                    this.Close();
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        // 页面加载
        private void SoBook_Shown(object sender, EventArgs e)
        {
            if (bookName != "")
            {
                this.txtBookName.Text = bookName;
                BtnSearck_Click(sender, e);
            }
        }

        // 搜索数据
        private void SoBookData()
        {
            var title = this.txtBookName.Text;
            string url = "https://so.biqusoso.com/s.php?ie=utf-8&siteid=biqukan.com&q=" + title;
            HtmlWeb web = new HtmlWeb();
            //从url中加载
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//ul");
            HtmlNodeCollection aCollection = headNode.SelectNodes("li");
            if (aCollection.Count <= 0)
                return;
            aCollection.RemoveAt(0);
            foreach (var item in aCollection)
            {
                ListViewItem tt = new ListViewItem();
                tt.SubItems[0].Text = item.SelectNodes("span")[0].InnerText;
                tt.SubItems.Add(item.SelectNodes("span")[1].InnerText);
                tt.SubItems.Add(item.SelectNodes("span")[2].InnerText);
                tt.SubItems.Add(item.SelectNodes("span")[1].SelectNodes("a")[0].Attributes["href"].Value);
                this.listTitle.Items.Add(tt);
            }
        }
    }
}
