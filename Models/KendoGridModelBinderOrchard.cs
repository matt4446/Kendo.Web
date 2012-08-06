using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGridBinder;

namespace Kendo.Web.Models
{
    public class KendoGridModelBinderOrchard : KendoGridModelBinder
    {
        private HttpRequestBase _request;

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            KendoGridRequest o = base.BindModel(controllerContext, bindingContext) as KendoGridRequest;
              
            return new KendoGridRequestOrchardModel()
            { 
                // FilterObjectWrapper = o.FilterObjectWrapper,
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