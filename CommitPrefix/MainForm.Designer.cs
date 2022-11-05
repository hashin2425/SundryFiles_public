
namespace CommitPrefix
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Top_most_chkBox = new System.Windows.Forms.CheckBox();
            this.Comment_box = new System.Windows.Forms.TextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.PrefixGridView = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrefixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.Top_most_chkBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Comment_box, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PrefixGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Clear_Button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Top_most_chkBox
            // 
            this.Top_most_chkBox.AutoSize = true;
            this.Top_most_chkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_most_chkBox.Location = new System.Drawing.Point(4, 5);
            this.Top_most_chkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Top_most_chkBox.Name = "Top_most_chkBox";
            this.Top_most_chkBox.Padding = new System.Windows.Forms.Padding(2);
            this.Top_most_chkBox.Size = new System.Drawing.Size(209, 25);
            this.Top_most_chkBox.TabIndex = 0;
            this.Top_most_chkBox.Text = "最前面に表示する";
            this.Top_most_chkBox.UseVisualStyleBackColor = true;
            this.Top_most_chkBox.CheckedChanged += new System.EventHandler(this.Top_most_chkBox_CheckedChanged);
            // 
            // Comment_box
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Comment_box, 2);
            this.Comment_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment_box.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Comment_box.Location = new System.Drawing.Point(4, 40);
            this.Comment_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comment_box.Multiline = true;
            this.Comment_box.Name = "Comment_box";
            this.Comment_box.Size = new System.Drawing.Size(326, 25);
            this.Comment_box.TabIndex = 1;
            this.Comment_box.Click += new System.EventHandler(this.Comment_box_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear_Button.Location = new System.Drawing.Point(221, 5);
            this.Clear_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(109, 25);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "クリア";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // PrefixGridView
            // 
            this.PrefixGridView.AllowUserToAddRows = false;
            this.PrefixGridView.AllowUserToDeleteRows = false;
            this.PrefixGridView.AllowUserToResizeColumns = false;
            this.PrefixGridView.AllowUserToResizeRows = false;
            this.PrefixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrefixGridView.ColumnHeadersVisible = false;
            this.PrefixGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button,
            this.content});
            this.tableLayoutPanel1.SetColumnSpan(this.PrefixGridView, 2);
            this.PrefixGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrefixGridView.Location = new System.Drawing.Point(4, 75);
            this.PrefixGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrefixGridView.Name = "PrefixGridView";
            this.PrefixGridView.ReadOnly = true;
            this.PrefixGridView.RowHeadersVisible = false;
            this.PrefixGridView.RowTemplate.Height = 21;
            this.PrefixGridView.Size = new System.Drawing.Size(326, 331);
            this.PrefixGridView.TabIndex = 3;
            this.PrefixGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrefixGridView_CellContentClick);
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.button.FillWeight = 40F;
            this.button.HeaderText = "buton";
            this.button.Name = "button";
            this.button.ReadOnly = true;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.content.HeaderText = "content";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Commit Prefix";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrefixGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox Top_most_chkBox;
        private System.Windows.Forms.TextBox Comment_box;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.DataGridView PrefixGridView;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
    }
}

