using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Web.Models
{
    public class GridFilter
    {
        public virtual string Operator { get; set; }
        public virtual string Field { get; set; }
        public virtual string Value { get; set; }
    }

    public class GridFilters
    {
        public List<GridFilter> Filters { get; set; }
        public string Logic { get; set; }
    }
}