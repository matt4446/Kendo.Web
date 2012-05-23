using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KendoGridBinder;
using Orchard.Mvc.ModelBinders;
using Kendo.Web.Models;

namespace Kendo.Web.ModelBinders
{
    public class KendoGridRequestModelBinder : IModelBinderProvider
    {
        public IEnumerable<ModelBinderDescriptor> GetModelBinders()
        {
            yield return new ModelBinderDescriptor() {
                Type = typeof(KendoGridRequestOrchardModel),
                ModelBinder = new KendoGridModelBinderOrchard()
            };
        }

    }

}
