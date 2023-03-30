namespace Lop_hoc
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lv_hienthi = new System.Windows.Forms.ListView();
            this.ch_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng sinh viên:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(65, 36);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(174, 20);
            this.txt_ten.TabIndex = 2;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(116, 65);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(123, 20);
            this.txt_sl.TabIndex = 2;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(265, 39);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 49);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lv_hienthi
            // 
            this.lv_hienthi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ten,
            this.ch_sl});
            this.lv_hienthi.GridLines = true;
            this.lv_hienthi.HideSelection = false;
            this.lv_hienthi.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lv_hienthi.Location = new System.Drawing.Point(12, 109);
            this.lv_hienthi.Name = "lv_hienthi";
            this.lv_hienthi.Size = new System.Drawing.Size(337, 177);
            this.lv_hienthi.TabIndex = 4;
            this.lv_hienthi.UseCompatibleStateImageBehavior = false;
            this.lv_hienthi.View = System.Windows.Forms.View.Details;
            this.lv_hienthi.SelectedIndexChanged += new System.EventHandler(this.lv_hienthi_SelectedIndexChanged);
            // 
            // ch_ten
            // 
            this.ch_ten.Text = "Tên lớp ";
            this.ch_ten.Width = 166;
            // 
            // ch_sl
            // 
            this.ch_sl.Text = "Số lượng sinh viên";
            this.ch_sl.Width = 267;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 304);
            this.Controls.Add(this.lv_hienthi);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ListView lv_hienthi;
        private System.Windows.Forms.ColumnHeader ch_ten;
        private System.Windows.Forms.ColumnHeader ch_sl;
    }
}

