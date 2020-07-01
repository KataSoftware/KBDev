using System;
using System.Collections.Generic;
using System.Text;
using KS.Time.BusinessObjects;
using SFS.Core.BR;
using SFS.Core.Security.BusinessObjects;

namespace KS.Time.BR
{
    public partial class unProxyBusinessObjectsBR
    {
        partial void OnUpdatingAgile(object sender, BusinessRulesEventArgs<unProxyBusinessObject> e)
        {
            secBusinessObject item = new secBusinessObject();
            item.Name = e.Item.Name;
            item.EntitySetName = e.Item.EntitySetName;
            item.GuidBusinessObject = e.Item.GuidBusinessObject;
            
            SFS.Core.Security.BR.secBusinessObjectsBR.Instance.UpdateAgile(item, "Name", "EntitySetName");
            e.Cancel = true;

        }
        partial void OnGetting(object sender, BusinessRulesEventArgs<unProxyBusinessObject> e)
        {

            e.Filter.AppendFilter($"it.secModule.ModuleKey = \"KSTime\" AND it.HideFromNavigation = false");
            var context = e.ContextRequest.CopySafe();
            context.CustomQuery.Page = e.ContextRequest.CustomQuery.Page;
            context.PreventInterceptors = true;
            context.CustomQuery.PageSize = e.ContextRequest.CustomQuery.PageSize;
            context.CustomQuery.OrderBy  = e.ContextRequest.CustomQuery.OrderBy;
            context.CustomQuery.SortDirection = e.ContextRequest.CustomQuery.SortDirection;
            //context.FreeText = e.ContextRequest.FreeText;
            

            var items = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.GetBy(e.Filter.GetFilterComplete(), context);

            List<unProxyBusinessObject> results = new List<unProxyBusinessObject>();

            foreach (var item in items)
            {
                unProxyBusinessObject result = new unProxyBusinessObject();
                result.BusinessObjectKey = item.BusinessObjectKey;
                result.Name = item.Name;
                result.GuidBusinessObject = item.GuidBusinessObject;
                results.Add(result);
            }

            e.Items = results;
            e.Cancel = true;


        }
        partial void OnCounting(object sender, BusinessRulesEventArgs<unProxyBusinessObject> e)
        {
            e.Filter.AppendFilter($"it.secModule.ModuleKey = \"KSTime\" AND it.HideFromNavigation = false");

            var result = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.GetCount(e.Filter.GetFilterComplete(), e.ContextRequest);

           

            e.CountResult = result;
            e.Cancel = true;
        }


    }
}
