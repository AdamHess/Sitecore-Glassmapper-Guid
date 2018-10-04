using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Foundation.ItemMapper.Interfaces;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;

namespace Company.Feature.AlertToaster.Models
{
    [SitecoreType(TemplateId = AlertToasterTemplates.AlertToasterType.TemplateId, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase)]
    public interface IAlertToasterType : ICommonItemPropertiesMapped
    {
        [SitecoreField(AlertToasterTemplates.AlertToasterType.Fields.CssStyle)]
        string CssStyle { get; set; }
    }
}
