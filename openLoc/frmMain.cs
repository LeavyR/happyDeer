using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace openLoc
{
    public partial class frmMain : Form
    {
        private string loc = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", loc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Hashtable ht = clsLoad.cl.Deal();
            //遍历方法二：遍历哈希表中的值
            foreach (string value in ht.Values)
            {
                Console.WriteLine(value);
                //获取listbox1的对象
                ListBox list1 = this.lb;
                //判断人员是否已经添加过
                if (!list1.Items.Contains(value))
                {
                    list1.Items.Add(value);
                }
                else
                {
                    MessageBox.Show("该目录已经添加过，无法重复添加！");
                }
            }
        }

        private void getValue(object sender, EventArgs e)
        {
            loc = lb.SelectedItem.ToString();
        }
    }
}
