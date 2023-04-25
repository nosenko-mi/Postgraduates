using Postgraduates.utils.file.FileFactory;
using Postgraduates.utils.file.FileReader;
using Postgraduates.ViewModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Postgraduates
{
    public partial class MainForm : Form
    {
        private string _filePath;
        private bool textChanged;
        private string _previousText = string.Empty;
        private static readonly FileFactory _defaultFactory = new TextFileFactory();
        private FileFactory _factory = _defaultFactory;
        private PostgradViewModel _postgradViewModel = new PostgradViewModel();

        public MainForm()
        {
            InitializeComponent();

            this._filePath = "";
            this.textChanged = false;

        }

        private void WriteText(string filePath)
        {
            this._filePath = filePath;
            // get content
            string content = textEditor.Text;
            // Get file from factory
            // Save file
            _factory.SaveFile(filePath, content);

            //System.IO.File.WriteAllText(this.filePath, this.textEditor.Text);
            this.textChanged = false;
        }

        private void SaveAs()
        {
            saveFileDialog.Filter = SaveFilters.All();
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get new filter
                string[] split = saveFileDialog.Filter.Split('|');
                int index = saveFileDialog.FilterIndex;
                string currentFilter = split[(index - 1) * 2] + "|" + split[(index - 1) * 2 + 1];
                // get factory for given filter
                _factory = SaveFilters.GetFactory(currentFilter);
                // write file
                this.WriteText(this.saveFileDialog.FileName);
            }
        }

        private void Save()
        {
            if (this._filePath == null || this._filePath == "")
            {
                this.SaveAs();
            }
            else
            {
                this.WriteText(this._filePath);
            }
        }

        private void SaveChanges()
        {
            if (this.textChanged)
            {
                if (MessageBox.Show("Save changes?", "Text is changed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Save();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
            this.textEditor.Clear();
            this.textChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveChanges();
                _filePath = openFileDialog.FileName;

                // Get file extension
                FileInfo fileInfo = new FileInfo(_filePath);
                string ext = fileInfo.Extension;

                if (ext != ".xml")
                {
                    MessageBox.Show(
                        "File extenction is not supported. Try opening .xml file", 
                        "Extention error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }
                // Get factory
                //FileReader reader = new FileReader(new XmlFileReader());
                // Read file
                //string text = reader.ReadFile(_filePath);

                // No need in abstract factory because xml structure is required
                XmlFile file = new XmlFile();
                string text = file.Read(_filePath);
                file.TryParsePostgrads(_filePath);

                textEditor.Text = text;
                textChanged = false;
                _previousText = text;
                _factory = _defaultFactory;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;

            int lineIndex = textEditor.GetLineFromCharIndex(textEditor.SelectionStart);
            int columnIndex = textEditor.SelectionStart - textEditor.GetFirstCharIndexOfCurrentLine();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveChanges();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }
    }
}