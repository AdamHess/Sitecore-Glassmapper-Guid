using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Company.Foundation.ItemMapper.Interfaces;
using Glass.Mapper.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;

namespace Company.Feature.AlertToaster.Models
{
    [SitecoreType(TemplateId = AlertToasterTemplates.AlertToaster.TemplateId, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase)]
    public interface IAlertToaster : ICommonItemPropertiesMapped
    {     
        [SitecoreField(AlertToasterTemplates.AlertToaster.Fields.IsEnabledId)]
        bool IsEnabled { get; set; }               
        [SitecoreField(AlertToasterTemplates.AlertToaster.Fields.TitleId)]
        string Title { get; set; }
        [SitecoreField(AlertToasterTemplates.AlertToaster.Fields.ContentId)]
        string Content { get; set; }        
        
        [SitecoreField(AlertToasterTemplates.AlertToaster.Fields.TypeId)]
        IAlertToasterType Type { get; set; }
    }
}
