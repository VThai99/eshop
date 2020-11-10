using eshopSolution.data.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshopSolution.data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOder { get; set; }
        public Boolean IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    } 
}
