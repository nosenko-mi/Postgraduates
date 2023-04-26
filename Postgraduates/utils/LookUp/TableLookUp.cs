using Postgraduates.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.LookUp
{
    internal class TableLookUp
    {
        /// <summary>
        /// Find text in list globally
        /// </summary>
        public static IEnumerable<Postgrad>? Find(string text, List<Postgrad> list)
        {
            var newList = list.Where(e => e.ToString().Contains(text));
            return newList;
        }

        public static IEnumerable<T>? Find<T>(string text, IEnumerable<T> list)
        {
            var newList = list.Where(e => e.ToString().Contains(text));
            return newList;
        }

    }
}
