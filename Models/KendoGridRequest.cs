using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KendoGridBinder;
using System.Web.Mvc;
using System.Web;

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

    public class KendoGridModelBinderOrchard : KendoGridModelBinder
    {
        private HttpRequestBase _request;

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            KendoGridRequest o = base.BindModel(controllerContext, bindingContext) as KendoGridRequest;
            
            return new KendoGridRequestOrchardModel() 
            { 
                 //FilterObjectWrapper = o.FilterObjectWrapper,
                 Logic = o.Logic,
                 Page = o.Page,
                 PageSize = o.PageSize,
                 Skip = o.Skip,
                 //SortObjects = o.SortObjects,
                 Take = o.Take
            };
        }
    }
}
