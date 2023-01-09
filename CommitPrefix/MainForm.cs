using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CommitPrefix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrefixGridView.Rows.Add("Feature", "新しい機能の追加");
            PrefixGridView.Rows.Add("Fix", "バグ修正");
            PrefixGridView.Rows.Add("Docs", "ドキュメント・コメントの変更");
            PrefixGridView.Rows.Add("Style", "フォーマット(空白・コロン)の変更");
            PrefixGridView.Rows.Add("Refactor", "コードの改善");
            PrefixGridView.Rows.Add("Optimize", "アルゴリズムの改善・効率化");
            PrefixGridView.Rows.Add("Test", "テスト関連");
            PrefixGridView.Rows.Add("Init", "プロジェクトの初期コミット");
            PrefixGridView.Rows.Add("Chore", "ビルド・補助ツール・ライブラリ関連");
            PrefixGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PrefixGridView.Columns["content"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Top_most_chkBox.Checked = false;
            TopMost = Top_most_chkBox.Checked;
            Comment_box.Text = "";
            Issue_box.Text = "";
        }

        private void Top_most_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = Top_most_chkBox.Checked;
        }

        private void Comment_box_Click(object sender, EventArgs e)
        {
            Top_most_chkBox.Checked = true;
            TopMost = Top_most_chkBox.Checked;
        }

        private void PrefixGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string prefix = PrefixGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string comment = Comment_box.Text;
                if (comment.Length != 0)
                {
                    // コメントの最初のアルファベットを大文字にする
                    comment = comment.Substring(0, 1).ToUpper() + comment.Substring(1);
                }

                // イシューの番号を追加する
                bool is_Issue_box_number = int.TryParse(Issue_box.Text, out int issue_num);
                if (is_Issue_box_number)
                {
                    comment += $" [#{issue_num}]";
                }

                Clipboard.SetDataObject($"[{prefix}] {comment}", true); // Send to clipboard like : [Prefix] This is comment.
            }
        }
    }
}
