using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DropListTest.Models
{
    public class IndexViewModel
    {
        public IEnumerable<SelectListItem> Vendors { get; set; }
        public IEnumerable<SelectListItem> Fruits { get; set; }
        public string selectedVendor { get; set; }
        public string selectedFruit { get; set; }
    }
}
