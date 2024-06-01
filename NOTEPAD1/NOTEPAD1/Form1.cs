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
namespace NOTEPAD1
{
    public partial class NotePad : Form
    {
        private bool isFileSaved;
        private bool isDirty;
        private string CurrentOpenFileName;

        public FontDialog FontDialog { get; private set; }

        public NotePad()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileSaved)
            {
                if (Path.GetExtension(CurrentOpenFileName) == ".txt")
                    Note.LoadFile(CurrentOpenFileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(CurrentOpenFileName) == ".rtf")
                    Note.LoadFile(CurrentOpenFileName, RichTextBoxStreamType.RichText);
                isDirty = false;
            }
            else
            {
                if (isDirty)
                {
                    SaveAs();
                }
                else
                {
                    Note.Clear();
                    this.Text = "Untitled -Notepad";
                    isDirty = false;
                }
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();

        }

        private void SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (* .txt)|*.txt |Rich Text Format (* .rtf)|*.rtf";
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFile.FileName) == ".txt")
                    Note.LoadFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(saveFile.FileName) == ".rtf")
                    Note.LoadFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }
            this.Text = Path.GetFileName(saveFile.FileName) + "NotePad";
            isFileSaved = true;
            isDirty = false;
            CurrentOpenFileName = saveFile.FileName;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights are reserved by Author ", "About NotePad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isDirty = true;
        }
        //To Make New File
        private void newFile()
        {
            if (!string.IsNullOrEmpty(this.Note.Text))
            {
                MessageBox.Show("Save the File First!");
            }
            else
            {
                this.Note.Text = string.Empty;
                this.Text = "Untitled -NotePad";
            }
        }
        //To Save File
        /*private void SaveFile()
        {
            saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                File.W(saveFile.FileName, this.Note.Text)
            }
        }*/

        private void New_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (* .txt)|*.txt |Rich Text Format (* .rtf)|*.rtf";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFile.FileName) == ".txt")
                    Note.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                if (Path.GetExtension(openFile.FileName) == ".rtf")
                    Note.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
            }
            this.Text = Path.GetFileName(openFile.FileName) + "NotePad";
            isFileSaved = true;
            isDirty = false;
            CurrentOpenFileName = openFile.FileName;
        }

        private void NotePad_Load(object sender, EventArgs e)
        {
            isFileSaved = false;
            isDirty = false;
            CurrentOpenFileName = "";
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if(Note.CanUndo == true)
            {
                Note.Undo();
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if(Note.CanRedo == true)
            {
                Note.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Note.SelectedText != "")
            {
                Note.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Note.SelectionLength > 0)
            {
                Note.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                Note.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.SelectedText = "";
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.Clear();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            Note.Text = time.ToString();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
            {
                this.Note.Font = font.Font;
            }

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.WordWrap = false;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.Note.ForeColor = color.Color;
            }
        }
    }
}
