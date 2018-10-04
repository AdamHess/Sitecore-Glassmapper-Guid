using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.Feature.AlertToaster
{
    public struct AlertToasterTemplates
    {
        public struct AlertToaster
        {
           
            public const string TemplateId ="{65F5F04D-8F32-42D0-A794-A6F8825D0F1F}";
            public struct Fields
            {
                public const string IsEnabledId = "427AB14C-00D9-48FE-B52C-BA6BF0B1DC3B}";
                public const string TypeId = "{C87BF8E3-D685-4054-9FE8-C297007F35A4}";                
                public const string TitleId = "{63F230D8-9436-4EC2-8E3C-8F0ED883AF93}";
                public const string ContentId = "{B206EBCB-27BB-4B73-8319-05C8D448A760}";               
            }
        }
        public struct AlertToasterType
        {
           
            public const string TemplateId = "{70293A25-9C8A-4824-B916-3C9D83294626}";
            public struct Fields
            {
                public const string CssStyle = "{1389EA61-A6B7-42B5-B141-DB9F2194C998}";
         
            }
        }

    }
}