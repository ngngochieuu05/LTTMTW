using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace BTVN_NgNgocHieu
{
    public partial class SoanThaoVanBan_NgNgocHieu : Form
    {
        private string currentFilePath = null;

        public SoanThaoVanBan_NgNgocHieu()
        {
            InitializeComponent();
        }

        private void SoanThaoVanBan_NgNgocHieu_Load(object sender, System.EventArgs e)
        {
            // Load fonts
            cmbFonts.Items.Clear();
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }

            // Load sizes
            cmbSize.Items.Clear();
            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                cmbSize.Items.Add(s.ToString());
            }

            // Default font
            SetDefaultFormatting();
        }

        private void SetDefaultFormatting()
        {
            cmbFonts.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
            richText.Font = new Font("Tahoma", 14f);
            richText.ForeColor = Color.Black;
            btnBold.Checked = false;
            btnItalic.Checked = false;
            btnUnderline.Checked = false;
            currentFilePath = null;
            UpdateWordCount();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            richText.Clear();
            SetDefaultFormatting();
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Rich Text (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                            richText.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                        else
                            richText.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                        currentFilePath = ofd.FileName;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Lỗi mở tập tin: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Rich Text (*.rtf)|*.rtf";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            richText.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                            currentFilePath = sfd.FileName;
                            MessageBox.Show("Lưu thành công.");
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu tập tin: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    // Save back using appropriate type
                    RichTextBoxStreamType type = Path.GetExtension(currentFilePath).ToLower() == ".rtf"
                        ? RichTextBoxStreamType.RichText
                        : RichTextBoxStreamType.PlainText;
                    richText.SaveFile(currentFilePath, type);
                    MessageBox.Show("Lưu văn bản thành công.");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi lưu tập tin: " + ex.Message);
                }
            }
        }

        private void btnBold_Click(object sender, System.EventArgs e)
        {
            ToggleSelectionStyle(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, System.EventArgs e)
        {
            ToggleSelectionStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, System.EventArgs e)
        {
            ToggleSelectionStyle(FontStyle.Underline);
        }

        private void ToggleSelectionStyle(FontStyle style)
        {
            Font current = richText.SelectionFont ?? richText.Font;
            FontStyle newStyle = current.Style;
            if ((current.Style & style) == style)
                newStyle &= ~style;
            else
                newStyle |= style;
            richText.SelectionFont = new Font(current, newStyle);
        }

        private void cmbFonts_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string fontName = cmbFonts.SelectedItem as string;
            if (!string.IsNullOrEmpty(fontName))
            {
                float size = richText.SelectionFont != null ? richText.SelectionFont.Size : richText.Font.Size;
                richText.SelectionFont = new Font(fontName, size, richText.SelectionFont != null ? richText.SelectionFont.Style : richText.Font.Style);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            float size;
            if (float.TryParse(cmbSize.SelectedItem as string, out size))
            {
                string fontName = richText.SelectionFont != null ? richText.SelectionFont.Name : richText.Font.Name;
                richText.SelectionFont = new Font(fontName, size, richText.SelectionFont != null ? richText.SelectionFont.Style : richText.Font.Style);
            }
        }

        private void richText_TextChanged(object sender, System.EventArgs e)
        {
            UpdateWordCount();
        }

        private void UpdateWordCount()
        {
            string text = richText.Text;
            int count = string.IsNullOrWhiteSpace(text)
                ? 0
                : text.Split(new char[] { ' ', '\n', '\r', '\t' }, System.StringSplitOptions.RemoveEmptyEntries).Length;
            lblWordCount.Text = "Tổng số từ: " + count;
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
