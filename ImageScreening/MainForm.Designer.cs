
namespace ImageScreening
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Images_btn = new System.Windows.Forms.Button();
            this.Move_to_1_btn = new System.Windows.Forms.Button();
            this.Move_to_2_btn = new System.Windows.Forms.Button();
            this.Images_text = new System.Windows.Forms.TextBox();
            this.Image_to_1_textbox = new System.Windows.Forms.TextBox();
            this.Image_to_2_textbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Pic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(3, 122);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(985, 494);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.Images_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Move_to_1_btn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Move_to_2_btn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Images_text, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Image_to_1_textbox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Image_to_2_textbox, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(985, 113);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Images_btn
            // 
            this.Images_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Images_btn.Location = new System.Drawing.Point(3, 3);
            this.Images_btn.Name = "Images_btn";
            this.Images_btn.Size = new System.Drawing.Size(191, 31);
            this.Images_btn.TabIndex = 0;
            this.Images_btn.Text = "Images";
            this.Images_btn.UseVisualStyleBackColor = true;
            this.Images_btn.Click += new System.EventHandler(this.Images_btn_Click);
            // 
            // Move_to_1_btn
            // 
            this.Move_to_1_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Move_to_1_btn.Location = new System.Drawing.Point(3, 40);
            this.Move_to_1_btn.Name = "Move_to_1_btn";
            this.Move_to_1_btn.Size = new System.Drawing.Size(191, 31);
            this.Move_to_1_btn.TabIndex = 1;
            this.Move_to_1_btn.Text = "Move to 1";
            this.Move_to_1_btn.UseVisualStyleBackColor = true;
            this.Move_to_1_btn.Click += new System.EventHandler(this.Move_to_1_btn_Click);
            // 
            // Move_to_2_btn
            // 
            this.Move_to_2_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Move_to_2_btn.Location = new System.Drawing.Point(3, 77);
            this.Move_to_2_btn.Name = "Move_to_2_btn";
            this.Move_to_2_btn.Size = new System.Drawing.Size(191, 33);
            this.Move_to_2_btn.TabIndex = 2;
            this.Move_to_2_btn.Text = "Move to 2";
            this.Move_to_2_btn.UseVisualStyleBackColor = true;
            this.Move_to_2_btn.Click += new System.EventHandler(this.Move_to_2_btn_Click);
            // 
            // Images_text
            // 
            this.Images_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Images_text.Location = new System.Drawing.Point(200, 3);
            this.Images_text.Name = "Images_text";
            this.Images_text.Size = new System.Drawing.Size(782, 19);
            this.Images_text.TabIndex = 3;
            this.Images_text.DoubleClick += new System.EventHandler(this.Images_text_DoubleClick);
            // 
            // Image_to_1_textbox
            // 
            this.Image_to_1_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image_to_1_textbox.Location = new System.Drawing.Point(200, 40);
            this.Image_to_1_textbox.Name = "Image_to_1_textbox";
            this.Image_to_1_textbox.Size = new System.Drawing.Size(782, 19);
            this.Image_to_1_textbox.TabIndex = 4;
            this.Image_to_1_textbox.DoubleClick += new System.EventHandler(this.Image_to_1_textbox_DoubleClick);
            // 
            // Image_to_2_textbox
            // 
            this.Image_to_2_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image_to_2_textbox.Location = new System.Drawing.Point(200, 77);
            this.Image_to_2_textbox.Name = "Image_to_2_textbox";
            this.Image_to_2_textbox.Size = new System.Drawing.Size(782, 19);
            this.Image_to_2_textbox.TabIndex = 5;
            this.Image_to_2_textbox.DoubleClick += new System.EventHandler(this.Image_to_2_textbox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Image Screening";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Images_btn;
        private System.Windows.Forms.Button Move_to_1_btn;
        private System.Windows.Forms.Button Move_to_2_btn;
        private System.Windows.Forms.TextBox Images_text;
        private System.Windows.Forms.TextBox Image_to_1_textbox;
        private System.Windows.Forms.TextBox Image_to_2_textbox;
    }
}

