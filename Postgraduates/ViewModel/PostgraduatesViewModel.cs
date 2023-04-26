using Postgraduates.model;
using Postgraduates.repository;
using Postgraduates.utils.Converter;
using Postgraduates.utils.file.FileFactory;
using Postgraduates.utils.LookUp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;

namespace Postgraduates.ViewModel
{
    internal class PostgraduatesViewModel
    {
        private string _filePath = "";
        private List<Postgrad> _postgrads;
        private PostgradRepository _repository = new PostgradRepository();
        private List<Exam> _exams;


        public DataTable FindInTable(string text)
        {
            var list = TableLookUp.Find<Postgrad>(text, _postgrads);
            var converter = new PostgradConverter();
            var table = converter.ToDataTable(list);
            return table;
        }

        public DataTable RunQuery(string[] queryParams)
        {
            XDocument xml = XDocument.Load(_filePath); // Load the XML document

            var list = _repository.RunQuery(queryParams);
            var converter = new PostgradConverter();
            var table = converter.ToDataTable(list);

            return table;

        }

        public DataTable GetFromFile(string filePath)
        {
            // No need in abstract factory because xml structure is required
            XmlFile file = new XmlFile();
            _filePath = filePath;
            _repository.FilePath = _filePath;
            // TODO: Check what you parse first and create corresponding converter!!!
            _postgrads = file.TryParsePostgrads(filePath);
            var table = GetTable();
            //var table = _postgrads.ToDataTable();
            return table;
        }

        public DataTable GetTable()
        {
            if (_postgrads == null)
            {
                return new DataTable();
            }
            var converter = new PostgradConverter();
            var table = converter.ToDataTable(_postgrads);
            return table;
        }

        public List<Postgrad> GetPostgrads()
        {
            // _postgrads = repository.GetAll()
            return _postgrads;
        }

        public void SetPostgrads(List<Postgrad> postgrads)
        {
            _postgrads = postgrads;
        }
    }
}
