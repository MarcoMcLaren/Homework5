using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5.Models
{
    public class BooksVM
    {
        public IEnumerable<books> Books { get; set; }
        public IEnumerable<authors> Authors { get; set; }
        public IEnumerable<types> Types { get; set; }

    }
}