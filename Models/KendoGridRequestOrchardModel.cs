using System;
using System.Linq;

namespace Kendo.Web.Models
{
    public class KendoGridRequestOrchardModel 
    {
        //public KendoGridRequest Model { get; set; }
        //public KendoGridBinder.Containers.FilterObjectWrapper FilterObjectWrapper { get; set; }
        public int Page { get; set; }

        public int PageSize { get; set; }

        public int Skip { get; set; }

        //public IEnumerable<KendoGridBinder.Containers.SortObject> SortObjects { get; set; }

        public int Take { get; set; }

        public string Logic { get; set; }
    }
}