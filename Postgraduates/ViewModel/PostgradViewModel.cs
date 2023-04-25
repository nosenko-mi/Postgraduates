using Postgraduates.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.ViewModel
{
    internal class PostgradViewModel
    {
        private List<Postgrad> _postgrads;
        // private PostgradRepository repository;

        public void GetPostgrads()
        {
            // _postgrads = repository.GetAll()
        }

        public void SetPostgrads(List<Postgrad> postgrads)
        {
            _postgrads = postgrads;
        }
    }
}
