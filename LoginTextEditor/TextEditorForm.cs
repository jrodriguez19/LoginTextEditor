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

namespace LoginTextEditor
{
    public partial class TextEditorForm : Form
    {
        public string userType;
        public OpenFileDialog openFileDialog;
        public SaveFileDialog saveFileDialog;
        public string username;

        public TextEditorForm()
        {
            InitializeComponent();            
            openFileDialog = new OpenFileDialog();
            // Initialize the OpenFileDialog to look for RTF files.
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "RTF Files|*.rtf";

            saveFileDialog = new SaveFileDialog();
            // Initialize the OpenFileDialog to look for RTF files.
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            

        }

        private void fielToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                {
                    // Load the contents of the file into the RichTextBox.
                    richTB.LoadFile(openFileDialog.FileName);
                }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTB.SaveFile(openFileDialog.FileName);
        }

        private void newTS_Click(object sender, EventArgs e)
        {
            richTB.Clear();
        }

        private void saveAsTS_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                // save the contents into a rtf file
                richTB.SaveFile(saveFileDialog.FileName);
            }
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.Font.FontFamily, richTB.Font.Size, FontStyle.Bold);
            int selstart = richTB.SelectionStart;
            int sellength = richTB.SelectionLength;
            richTB.SelectionFont = new Font(richTB.Font, FontStyle.Bold);
            richTB.SelectionStart = richTB.SelectionStart + richTB.SelectionLength;
            richTB.SelectionLength = 0;
            richTB.SelectionFont = richTB.Font;
            richTB.Select(selstart, sellength);
        }

        private void italicTS_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.Font.FontFamily, richTB.Font.Size, FontStyle.Italic);
            int selstart = richTB.SelectionStart;
            int sellength = richTB.SelectionLength;
            richTB.SelectionFont = new Font(richTB.Font, FontStyle.Italic);
            richTB.SelectionStart = richTB.SelectionStart + richTB.SelectionLength;
            richTB.SelectionLength = 0;
            richTB.SelectionFont = richTB.Font;
            richTB.Select(selstart, sellength);
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTB.LoadFile(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            richTB.SaveFile(openFileDialog.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                // save the contents into a rtf file
                richTB.SaveFile(saveFileDialog.FileName);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.SelectionFont.FontFamily, 10);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.SelectionFont.FontFamily, 12);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.SelectionFont.FontFamily, 14);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTB.SelectionFont = new Font(richTB.SelectionFont.FontFamily, 14);
        }

        private void cutTS_Click(object sender, EventArgs e)
        {
            richTB.Cut();
        }

        private void copyTS_Click(object sender, EventArgs e)
        {
            richTB.Copy();
        }

        private void pasteTS_Click(object sender, EventArgs e)
        {
            richTB.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTB.Paste();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Text Editor Developed by Jorge Rodriguez Nocua");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TextEditorForm_Load(object sender, EventArgs e)
        {
            usernameLabelTS.Text = username;
            if(userType == "View")
            {
                richTB.ReadOnly = true;
            }
            else
            {
                richTB.ReadOnly = false;
            }
        }
    }
}

