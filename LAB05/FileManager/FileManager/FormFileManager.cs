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
    public partial class FormFileManager : Form
    {
        readonly FileSystem filesys = new FileSystem();

        public FormFileManager()
        {
            InitializeComponent();
            comboBoxFtype.Items.Add("Read-Only");
            comboBoxFtype.Items.Add("Editable");
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {           
            try 
            {
                string name = textBoxAddFname.Text;
                string type = comboBoxFtype.Text;
                string content = textBoxAddFcont.Text;

                filesys.AddFile(name, type, content);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonRemFile_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxRemFname.Text;
                filesys.RemoveFile(name);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                string name = textBoxUpFname.Text;
                filesys.UpdateFile(name);
                textBoxUpContent.Text = filesys.SelectedFile.Content;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string newContent = textBoxUpNewCont.Text;
                filesys.SaveContent(newContent);
                textBoxUpContent.Clear();
                textBoxUpNewCont.Clear();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxViewFname.Text;
                File file = filesys.FindFile(name);

                textBoxViewCont.Text = file.Content;
                listBoxFeatures.Items.Clear();
                foreach (string feat in file.Features) listBoxFeatures.Items.Add(feat);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonShowSumm_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.Add("Name\tType\tSize(KB)");
            
            double mem = 0;
            List<File> files = filesys.Files;

            foreach(File file in files)
            {
                double size = file.FileSize;
                mem += size;

                listBoxFiles.Items.Add($"{file.Name}\t{file.Type}\t{size}");
            }

            textBoxTotal.Text = files.Count.ToString();
            textBoxMem.Text= mem.ToString();
        }
    }
}
