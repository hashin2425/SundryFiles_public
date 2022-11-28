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
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImageScreening
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string[] ScreeningImages;
        private new int Cursor = 0;

        private void Images_btn_Click(object sender, EventArgs e) { Get_Images(); }

        private void MainForm_Load(object sender, EventArgs e) { Get_Images(); }

        private void Move_to_1_btn_Click(object sender, EventArgs e) { Do_Move(Image_to_1_textbox.Text); }

        private void Move_to_2_btn_Click(object sender, EventArgs e) { Do_Move(Image_to_2_textbox.Text); }

        private void Pic_Click(object sender, EventArgs e) { Show_img(); }

        private void Images_text_DoubleClick(object sender, EventArgs e) { Images_text.Text = Open_FileDialog(); }

        private void Image_to_1_textbox_DoubleClick(object sender, EventArgs e) { Image_to_1_textbox.Text = Open_FileDialog(); }

        private void Image_to_2_textbox_DoubleClick(object sender, EventArgs e) { Image_to_2_textbox.Text = Open_FileDialog(); }

        private void Get_Images()
        {
            Cursor = 0;
            var matcher = new Matcher();
            matcher.AddInclude("*.png");
            ScreeningImages = (string[])matcher.GetResultsInFullPath(Images_text.Text);
        }

        private void Do_Move(string path)
        {
            string filename = Path.GetFileName(ScreeningImages[Cursor]);
            File.Move(ScreeningImages[Cursor], path + filename);

            Cursor++;
            Show_img();

            Images_btn.Text = $"Images({Cursor}/{ScreeningImages.Length})";
        }

        private void Show_img()
        {
            if (ScreeningImages.Length > 0)
            {
                Pic.ImageLocation = ScreeningImages[Cursor];
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    Do_Move(Image_to_1_textbox.Text);
                    break;
                case '2':
                    Do_Move(Image_to_2_textbox.Text);
                    break;
            }
        }

        private string Open_FileDialog()
        {
            CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog();

            if (folderBrowserDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return folderBrowserDialog.FileName;
            }
            else { return ""; }
        }
    }
}
