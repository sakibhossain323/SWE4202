using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private readonly List <File> _files = new List <File> ();
        private readonly HashSet <string> _cacheName = new HashSet<string> ();
        private File _activeFile = null;

        public Form1()
        {
            InitializeComponent();
            comboBoxFtype.Items.Add("Read-Only");
            comboBoxFtype.Items.Add("Editable");
        }

        private bool AddFile(string name, string type, string content)
        {
            if(_cacheName.Contains(name)) return false;

            if(type == "Read-Only")
            {
                var newfile = new ReadOnlyFile(name, type, content);
                _files.Add (newfile);
                _cacheName.Add (name);
            }
            else if(type == "Editable")
            {
                var newfile = new EditableFile(name, type, content);
                _files.Add(newfile);
                _cacheName.Add(name);
            }

            return true;
        }

        private File FindFile(string name)
        {
            File file = null;
            if (!_cacheName.Contains(name)) return file;

            foreach (File curfile in _files)
            {
                if(name == curfile.Name)
                {
                    file = curfile; break;
                }
            }

            return file;
        }

        private bool RemoveFile(string name)
        {
            File file = FindFile(name);
            if(file == null) return false;
            _files.Remove (file);
            _cacheName.Remove (name);
            return true;
        }

        private void ClearActiveContent()
        {
            textBoxUpContent.Clear();
            textBoxUpNewCont.Clear();
        }

        private void ClearViewedContent()
        {
            textBoxViewCont.Clear();
            listBoxFeatures.Items.Clear();
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            string name = textBoxAddFname.Text;
            string type = comboBoxFtype.Text;
            string content = textBoxAddFcont.Text;

            bool added = AddFile(name, type, content);
            if (!added) MessageBox.Show($"\"{name}\" Already Exists. Provide Unique File Name");
        }

        private void ButtonRemFile_Click(object sender, EventArgs e)
        {
            string name = textBoxRemFname.Text;

            bool removed = RemoveFile(name);
            if (!removed) MessageBox.Show($"\"{name}\" Doesn't Exist!");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxUpFname.Text;

            File file = FindFile(name);
            if(file == null)
            {
                MessageBox.Show($"\"{name}\" Doesn't Exist!");
                ClearActiveContent();
                return;
            }
            else if(file.Type == "Read-Only")
            {
                MessageBox.Show($"\"{name}\" is a Read-Only file!");
                ClearActiveContent();
                return;
            }
            _activeFile = file;
            textBoxUpContent.Text = file.Content;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string newContent = textBoxUpNewCont.Text;
            if(_activeFile == null)
            {
                MessageBox.Show("Select a file please!");
                return;
            }
            EditableFile curfile = (EditableFile)_activeFile;
            curfile.SetContent(newContent);
            _activeFile = null;
            ClearActiveContent();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            string name = textBoxViewFname.Text;

            File file = FindFile(name);
            if (file == null)
            {
                MessageBox.Show($"\"{name}\" Doesn't Exist!");
                ClearViewedContent();
                return;
            }

            textBoxViewCont.Text= file.Content;
            listBoxFeatures.Items.Clear();
            foreach(string feat in file.Features)
            {
                listBoxFeatures.Items.Add(feat);
            }
        }

        private void ButtonShowSumm_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.Add("Name\tType\tSize(KB)");
            double mem = 0;

            foreach(File file in _files)
            {
                double curfilesize = file.GetFileSize();
                listBoxFiles.Items.Add($"{file.Name}\t{file.Type}\t{curfilesize}");
                mem += curfilesize;
            }

            textBoxTotal.Text = _files.Count.ToString();
            textBoxMem.Text= mem.ToString();
        }
    }
}
