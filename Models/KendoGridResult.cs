using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kendo.Web.Models
{
    public class KendoGridResult
    {
        public KendoGridResult()
        {
            
        }

        public IEnumerable Data
        {
            get;
            set;
        }

        public string Errors
        {
            get;
            set;
        }

        public int Total
        {
            get;
            set;
        }

        
    }
}
