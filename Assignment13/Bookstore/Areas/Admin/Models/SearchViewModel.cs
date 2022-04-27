﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    // SearchViewModel class takes that data and passes it to a view, along with books that 
    // meet search criteria. Uses data annotation to make sure user enters a search term.

    public class SearchViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        [Required(ErrorMessage = "Please enter a search term.")]
        public string SearchTerm { get; set; }
        public string Type { get; set; }
        public string Header { get; set; }
    }
}
