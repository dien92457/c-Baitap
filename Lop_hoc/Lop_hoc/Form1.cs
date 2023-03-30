using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lop_hoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lv_hienthi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txt_ten.Text)) || (string.IsNullOrEmpty(txt_sl.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txt_ten.Text;
                lv_hienthi.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txt_sl.Text));
                item.SubItems.Add(subitem);

                txt_ten.Clear();
                txt_sl.Clear();
                txt_ten.Focus();
            }
        }  }
}
