using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Company.Foundation.ItemMapper.Interfaces
{
    /// <summary>
    /// Optional Interface for simplifying the mapping of common sitecore specific fields
    /// That all items have. 
    /// </summary>
    public interface ICommonItemPropertiesMapped
    {
        [SitecoreId]
        ID ID { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }
        
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        ID TemplateId { get; set; }

        [SitecoreItem]
        Item Item { get; set; }

    }
}
