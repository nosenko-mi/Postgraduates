using Postgraduates.model;
using Postgraduates.utils;
using Postgraduates.utils.Converter;
using Postgraduates.utils.file.Exporter;
using Postgraduates.utils.file.FileFactory;
using Postgraduates.utils.file.FileReader;
using Postgraduates.ViewModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace Postgraduates
{
    public partial class MainForm : Form
    {
        private string _filePath;
        private bool textChanged;
        private static readonly FileFactory _defaultFactory = new TextFileFactory();
        private FileFactory _factory = _defaultFactory;
        private PostgraduatesViewModel _viewModel = new PostgraduatesViewModel();

        public MainForm()
        {
            InitializeComponent();

            _filePath = "";
            textChanged = false;

        }

        private void RenderQueryLayout(PostgraduatesType type)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Label lbl = new Label();
                lbl.Name = column.HeaderText + "QueryLabel";
                lbl.Text = column.HeaderText;
                flowLayoutPanel.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Name = column.HeaderText + "QueryTextBox";
                txt.Text = "";
                flowLayoutPanel.Controls.Add(txt);
            }
        }

        private void WriteText(string filePath)
        {
            this._filePath = filePath;
            // get content
            // Get file from factory
            // Save file
            //_factory.SaveFile(filePath, content);

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
            this.textChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveChanges();
                _filePath = openFileDialog.FileName;

                FileInfo fileInfo = new FileInfo(_filePath);
                string ext = fileInfo.Extension;
                if (ext != ".xml")
                {
                    _filePath = "";
                    MessageBox.Show(
                        "File extention is not supported. Try opening .xml file",
                        "Extention error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var table = _viewModel.GetFromFile(_filePath);
                dataGridView.DataSource = table;
                RenderQueryLayout(PostgraduatesType.Postgrad);
                textChanged = false;
                _factory = _defaultFactory;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable table = _viewModel.FindInTable(searchTextBox.Text);
            dataGridView.DataSource = table;
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            DataTable table = _viewModel.GetTable();
            dataGridView.DataSource = table;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource == null)
            {
                MessageBox.Show(
                    "Table is empty",
                    "Export error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            saveFileDialog.Filter = SaveFilters.HTML;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var exporter = new HtmlExporter();
                exporter.EportTable(
                    (DataTable)(dataGridView.DataSource),
                    saveFileDialog.FileName);
            }

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            DataTable table = _viewModel.FindInTable(searchTextBox.Text);
            dataGridView.DataSource = table;
        }

        private void runQuerryButton_Click(object sender, EventArgs e)
        {
            var queryParams = CollectQueryData();
            var table = _viewModel.RunQuery(queryParams);
            dataGridView.DataSource = table;
        }

        private string[] CollectQueryData()
        {
            string[] result = new string[2];
            bool isSelected = false;
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if (c is TextBox && c.Text.Length > 0)
                {
                    if (isSelected)
                    {
                        MessageBox.Show(
                            "Query can be performed only by 1 field.\nThe last filled will be used in query",
                            "Querry warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    result[0] = c.Text;
                    string name = c.Name.ToString();
                    name = name.Substring(0, name.Length - 12);
                    result[1] = name;
                    isSelected = true;
                }
            }
            return result;
        }

        private void clearQueryButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if (c is TextBox && c.Text.Length > 0)
                {
                    c.Text = "";
                }
            }
            DataTable table = _viewModel.GetTable();
            dataGridView.DataSource = table;
        }
    }
}