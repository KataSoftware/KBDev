// <Template>
//   <SolutionTemplate></SolutionTemplate>
//   <Version>20150126.0020</Version>
//   <Update>uiModel.ModuleNamespace</Update>
// </Template>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

using KS.Time.BR;
using Newtonsoft.Json; //System.Web.Script.Serialization;
using KS.Time.Api.Models;
//using KS.Time.Web.Mvc.Resources;
using BO = KS.Time.BusinessObjects;
//using SFS.Core.Web.Mvc.Security;
using SFS.Core.Web.Mvc;
//using SFS.Core.Web.Mvc.Models;
//using SFS.Core.Web.Mvc.Resources;
//using SFS.Core.Web.Mvc.Controllers;
//using MvcSiteMapProvider;
//using System.Web.Routing;
using System.Collections;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
//using SFS.Core.My;
using SFS.Core.Entities;
using SFS.Core.Api;
using SFS.Core.Api.Models;
using KS.Time.BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using SFS.Core.My;

namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstEmailTemplates;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstEmailTemplatesController : KS.Time.Api.ControllerBase<Models.KstEmailTemplates.KstEmailTemplateModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstEmailTemplates.KstEmailTemplateModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstEmailTemplates.KstEmailTemplateModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstEmailTemplateModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstEmailTemplateModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstEmailTemplateModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstEmailTemplateModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstEmailTemplateModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstEmailTemplateModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstEmailTemplatesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstEmailTemplateModel model = new KstEmailTemplateModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstEmailTemplateModel> data, ContextRequest contextRequest)
        {
            List<KstEmailTemplate> items = new  List<KstEmailTemplate>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstEmailTemplatesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstEmailTemplate", "KSTime", typeof(KstEmailTemplatesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstEmailTemplatesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstEmailTemplateModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstEmailTemplateModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstEmailTemplateModel> models, ContextRequest contextRequest)
        {
            List<KstEmailTemplate> objs = new List<KstEmailTemplate>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstEmailTemplatesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstEmailTemplateModel> models, ContextRequest contextRequest)
        {
            List<KstEmailTemplate> objs = new List<KstEmailTemplate>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstEmailTemplatesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstEmailTemplatesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstEmailTemplateModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstEmailTemplateModel> GetAll() {
            			var bos = BR.KstEmailTemplatesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Title",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstEmailTemplateModel> results = new List<KstEmailTemplateModel>();
            KstEmailTemplateModel model = null;
            foreach (var bo in bos)
            {
                model = new KstEmailTemplateModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstEmailTemplate = GetRouteDataOrQueryParam("id");
			if (idKstEmailTemplate != null)
			{
				if (!decripted)
                {
					idKstEmailTemplate = SFS.Core.Entities.Utils.GetPropertyKey(idKstEmailTemplate.Replace("-","/"), "GuidEmailTemplate");
				}else{
					if (id != null )
						idKstEmailTemplate = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidEmailTemplate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidEmailTemplate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidEmailTemplate",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidEmailTemplate",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.GUIDEMAILTEMPLATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Title"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Title")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Title",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "Title",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.TITLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("TitleKey"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "TitleKey")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "TitleKey",

					 MaxLength = 20,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "TitleKey",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.TITLEKEY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Content"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Content")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "Content",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Content",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.CONTENT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 120,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstEmailTemplateResources.BYTES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstEmailTemplateModel> uiModel) {
          	
			MyEventArgs<UIModel<KstEmailTemplateModel>> me = new MyEventArgs<UIModel<KstEmailTemplateModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstEmailTemplateModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstEmailTemplatesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstEmailTemplatesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstEmailTemplateModel model = null;
            List<KstEmailTemplateModel> results = new List<KstEmailTemplateModel>();
            foreach (var item in bos)
            {
                model = new KstEmailTemplateModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstEmailTemplateModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstEmailTemplateModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstEmailTemplateModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstEmailTemplateModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstEmailTemplateModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstEmailTemplateModel model = null;
            ControllerEventArgs<KstEmailTemplateModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstEmailTemplateModel>() { Id = objectKey  });
             bool cancel = false;
             KstEmailTemplateModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidEmailTemplate = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidEmailTemplate"));
			if (dec)
                 {
                     guidEmailTemplate = new Guid(id);
                 }
                 else
                 {
                     guidEmailTemplate = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstEmailTemplateModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstEmailTemplatesBR.Instance.GetByKey(guidEmailTemplate, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstEmailTemplateModel> GetContextModel(UIModelContextTypes formMode, KstEmailTemplateModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstEmailTemplateModel> GetContextModel(UIModelContextTypes formMode, KstEmailTemplateModel model, bool decript, Guid ? id) {
            UIModel<KstEmailTemplateModel> me = new UIModel<KstEmailTemplateModel>(true, "KstEmailTemplates");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstEmailTemplate";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstEmailTemplate";
            me.EntitySetName = "KstEmailTemplates";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstEmailTemplates";
            me.PropertyKeyName = "GuidEmailTemplate";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstEmailTemplateResources.KSTEMAILTEMPLATES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Title") != null){
						me.Properties.Find(p => p.PropertyName == "Title").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidEmailTemplate") != null){
						me.Properties.Find(p => p.PropertyName == "GuidEmailTemplate").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProxyGeoCities;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProxyGeoCitiesController : KS.Time.Api.ControllerBase<Models.KstProxyGeoCities.KstProxyGeoCityModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCities.KstProxyGeoCityModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCities.KstProxyGeoCityModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProxyGeoCityModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProxyGeoCityModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProxyGeoCityModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProxyGeoCityModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProxyGeoCityModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProxyGeoCityModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProxyGeoCitiesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProxyGeoCityModel model = new KstProxyGeoCityModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProxyGeoCityModel> data, ContextRequest contextRequest)
        {
            List<KstProxyGeoCity> items = new  List<KstProxyGeoCity>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProxyGeoCitiesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProxyGeoCity", "KSTime", typeof(KstProxyGeoCitiesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProxyGeoCitiesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProxyGeoCityModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProxyGeoCityModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProxyGeoCityModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoCity> objs = new List<KstProxyGeoCity>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProxyGeoCitiesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProxyGeoCityModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoCity> objs = new List<KstProxyGeoCity>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProxyGeoCitiesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProxyGeoCitiesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProxyGeoCityModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProxyGeoCityModel> GetAll() {
            			var bos = BR.KstProxyGeoCitiesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProxyGeoCityModel> results = new List<KstProxyGeoCityModel>();
            KstProxyGeoCityModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProxyGeoCityModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProxyGeoCity = GetRouteDataOrQueryParam("id");
			if (idKstProxyGeoCity != null)
			{
				if (!decripted)
                {
					idKstProxyGeoCity = SFS.Core.Entities.Utils.GetPropertyKey(idKstProxyGeoCity.Replace("-","/"), "GuidCity");
				}else{
					if (id != null )
						idKstProxyGeoCity = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidCity"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidCity")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidCity",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidCity",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.GUIDCITY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidState"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidState")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidState",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidState",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.GUIDSTATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidParent"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidParent")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidParent",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidParent",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.GUIDPARENT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoCity1"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoCity2" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoCity1.GuidCity")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoCity1.GuidCity" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoCities" });
			

	
	//fk_KstProxyGeoCity_KstProxyGeoCity
		//if (this.Request.QueryString["fk"] != "KstProxyGeoCity1")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProxyGeoCities/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProxyGeoCity1&fk=KstProxyGeoCity2&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyGeoCity2.GuidCity = Guid(\"" + idKstProxyGeoCity +"\")")+ "&fkValue=" + idKstProxyGeoCity,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProxyGeoCity",
					BusinessObjectSet = "KstProxyGeoCities",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoCity1",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoCity1.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoCity",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProxyGeoCities"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.KSTPROXYGEOCITY1*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoCity2"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoCity1" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoCity2.GuidCity")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoCity2.GuidCity" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoCities" });
			

	
	//fk_KstProxyGeoCity_KstProxyGeoCity
		//if (this.Request.QueryString["fk"] != "KstProxyGeoCity2")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyGeoCity",
					BusinessObjectSet = "KstProxyGeoCities",
					PropertyNavigationKey = "GuidCity",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidCity",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoCity2",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoCity2.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoCity",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyGeoCities"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.KSTPROXYGEOCITY2*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoState"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoCities" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoState.GuidState")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoState.GuidState" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoStates" });
			

	
	//fk_KstProxyGeoCity_KstProxyGeoState
		//if (this.Request.QueryString["fk"] != "KstProxyGeoState")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyGeoState",
					BusinessObjectSet = "KstProxyGeoStates",
					PropertyNavigationKey = "GuidState",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidState",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoState",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoState.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoState",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyGeoStates"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCityResources.KSTPROXYGEOSTATE*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProxyGeoCityModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProxyGeoCityModel>> me = new MyEventArgs<UIModel<KstProxyGeoCityModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProxyGeoCityModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProxyGeoCitiesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProxyGeoCitiesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProxyGeoCityModel model = null;
            List<KstProxyGeoCityModel> results = new List<KstProxyGeoCityModel>();
            foreach (var item in bos)
            {
                model = new KstProxyGeoCityModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProxyGeoCityModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProxyGeoCityModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProxyGeoCityModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoCityModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoCityModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProxyGeoCityModel model = null;
            ControllerEventArgs<KstProxyGeoCityModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProxyGeoCityModel>() { Id = objectKey  });
             bool cancel = false;
             KstProxyGeoCityModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidCity = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidCity"));
			if (dec)
                 {
                     guidCity = new Guid(id);
                 }
                 else
                 {
                     guidCity = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProxyGeoCityModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProxyGeoCitiesBR.Instance.GetByKey(guidCity, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProxyGeoCityModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoCityModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProxyGeoCityModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoCityModel model, bool decript, Guid ? id) {
            UIModel<KstProxyGeoCityModel> me = new UIModel<KstProxyGeoCityModel>(true, "KstProxyGeoCities");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProxyGeoCity";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProxyGeoCity";
            me.EntitySetName = "KstProxyGeoCities";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProxyGeoCities";
            me.PropertyKeyName = "GuidCity";

            me.Properties = GetProperties(me, decript, id);
 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProxyGeoCityResources.KSTPROXYGEOCITIES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidCity") != null){
						me.Properties.Find(p => p.PropertyName == "GuidCity").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProxyGeoCountries;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProxyGeoCountriesController : KS.Time.Api.ControllerBase<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProxyGeoCountries.KstProxyGeoCountryModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoCountries.KstProxyGeoCountryModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProxyGeoCountryModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProxyGeoCountryModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProxyGeoCountryModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProxyGeoCountryModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProxyGeoCountryModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProxyGeoCountryModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProxyGeoCountriesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProxyGeoCountryModel model = new KstProxyGeoCountryModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProxyGeoCountryModel> data, ContextRequest contextRequest)
        {
            List<KstProxyGeoCountry> items = new  List<KstProxyGeoCountry>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProxyGeoCountriesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProxyGeoCountry", "KSTime", typeof(KstProxyGeoCountriesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProxyGeoCountriesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProxyGeoCountryModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProxyGeoCountryModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProxyGeoCountryModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoCountry> objs = new List<KstProxyGeoCountry>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProxyGeoCountriesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProxyGeoCountryModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoCountry> objs = new List<KstProxyGeoCountry>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProxyGeoCountriesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProxyGeoCountriesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProxyGeoCountryModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProxyGeoCountryModel> GetAll() {
            			var bos = BR.KstProxyGeoCountriesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProxyGeoCountryModel> results = new List<KstProxyGeoCountryModel>();
            KstProxyGeoCountryModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProxyGeoCountryModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProxyGeoCountry = GetRouteDataOrQueryParam("id");
			if (idKstProxyGeoCountry != null)
			{
				if (!decripted)
                {
					idKstProxyGeoCountry = SFS.Core.Entities.Utils.GetPropertyKey(idKstProxyGeoCountry.Replace("-","/"), "GuidCountry");
				}else{
					if (id != null )
						idKstProxyGeoCountry = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidCountry"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidCountry")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidCountry",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidCountry",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCountryResources.GUIDCOUNTRY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCountryResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoStates"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoCountry" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoStates.GuidState")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoStates.GuidState" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoStates" });
			

	
	//fk_KstProxyGeoState_KstProxyGeoCountry
		//if (this.Request.QueryString["fk"] != "KstProxyGeoStates")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProxyGeoStates/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProxyGeoStates&fk=KstProxyGeoCountry&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyGeoCountry.GuidCountry = Guid(\"" + idKstProxyGeoCountry +"\")")+ "&fkValue=" + idKstProxyGeoCountry,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProxyGeoState",
					BusinessObjectSet = "KstProxyGeoStates",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoStates",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoStates.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoState",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProxyGeoStates"
                    /*,PropertyDisplayName = Resources.KstProxyGeoCountryResources.KSTPROXYGEOSTATES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProxyGeoCountryModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProxyGeoCountryModel>> me = new MyEventArgs<UIModel<KstProxyGeoCountryModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProxyGeoCountryModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProxyGeoCountriesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProxyGeoCountriesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProxyGeoCountryModel model = null;
            List<KstProxyGeoCountryModel> results = new List<KstProxyGeoCountryModel>();
            foreach (var item in bos)
            {
                model = new KstProxyGeoCountryModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProxyGeoCountryModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProxyGeoCountryModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProxyGeoCountryModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoCountryModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoCountryModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProxyGeoCountryModel model = null;
            ControllerEventArgs<KstProxyGeoCountryModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProxyGeoCountryModel>() { Id = objectKey  });
             bool cancel = false;
             KstProxyGeoCountryModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidCountry = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidCountry"));
			if (dec)
                 {
                     guidCountry = new Guid(id);
                 }
                 else
                 {
                     guidCountry = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProxyGeoCountryModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProxyGeoCountriesBR.Instance.GetByKey(guidCountry, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProxyGeoCountryModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoCountryModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProxyGeoCountryModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoCountryModel model, bool decript, Guid ? id) {
            UIModel<KstProxyGeoCountryModel> me = new UIModel<KstProxyGeoCountryModel>(true, "KstProxyGeoCountries");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProxyGeoCountry";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProxyGeoCountry";
            me.EntitySetName = "KstProxyGeoCountries";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProxyGeoCountries";
            me.PropertyKeyName = "GuidCountry";

            me.Properties = GetProperties(me, decript, id);
 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProxyGeoCountryResources.KSTPROXYGEOCOUNTRIES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidCountry") != null){
						me.Properties.Find(p => p.PropertyName == "GuidCountry").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProxyGeoStates;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProxyGeoStatesController : KS.Time.Api.ControllerBase<Models.KstProxyGeoStates.KstProxyGeoStateModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProxyGeoStates.KstProxyGeoStateModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyGeoStates.KstProxyGeoStateModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProxyGeoStateModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProxyGeoStateModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProxyGeoStateModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProxyGeoStateModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProxyGeoStateModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProxyGeoStateModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProxyGeoStatesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProxyGeoStateModel model = new KstProxyGeoStateModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProxyGeoStateModel> data, ContextRequest contextRequest)
        {
            List<KstProxyGeoState> items = new  List<KstProxyGeoState>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProxyGeoStatesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProxyGeoState", "KSTime", typeof(KstProxyGeoStatesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProxyGeoStatesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProxyGeoStateModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProxyGeoStateModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProxyGeoStateModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoState> objs = new List<KstProxyGeoState>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProxyGeoStatesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProxyGeoStateModel> models, ContextRequest contextRequest)
        {
            List<KstProxyGeoState> objs = new List<KstProxyGeoState>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProxyGeoStatesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProxyGeoStatesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProxyGeoStateModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProxyGeoStateModel> GetAll() {
            			var bos = BR.KstProxyGeoStatesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProxyGeoStateModel> results = new List<KstProxyGeoStateModel>();
            KstProxyGeoStateModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProxyGeoStateModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProxyGeoState = GetRouteDataOrQueryParam("id");
			if (idKstProxyGeoState != null)
			{
				if (!decripted)
                {
					idKstProxyGeoState = SFS.Core.Entities.Utils.GetPropertyKey(idKstProxyGeoState.Replace("-","/"), "GuidState");
				}else{
					if (id != null )
						idKstProxyGeoState = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidState"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidState")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidState",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidState",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoStateResources.GUIDSTATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoStateResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidCountry"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidCountry")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidCountry",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidCountry",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyGeoStateResources.GUIDCOUNTRY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoCities"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoState" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoCities.GuidCity")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoCities.GuidCity" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoCities" });
			

	
	//fk_KstProxyGeoCity_KstProxyGeoState
		//if (this.Request.QueryString["fk"] != "KstProxyGeoCities")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProxyGeoCities/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProxyGeoCities&fk=KstProxyGeoState&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyGeoState.GuidState = Guid(\"" + idKstProxyGeoState +"\")")+ "&fkValue=" + idKstProxyGeoState,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProxyGeoCity",
					BusinessObjectSet = "KstProxyGeoCities",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoCities",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoCities.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoCity",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProxyGeoCities"
                    /*,PropertyDisplayName = Resources.KstProxyGeoStateResources.KSTPROXYGEOCITIES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyGeoCountry"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyGeoStates" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyGeoCountry.GuidCountry")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyGeoCountry.GuidCountry" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyGeoCountries" });
			

	
	//fk_KstProxyGeoState_KstProxyGeoCountry
		//if (this.Request.QueryString["fk"] != "KstProxyGeoCountry")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyGeoCountry",
					BusinessObjectSet = "KstProxyGeoCountries",
					PropertyNavigationKey = "GuidCountry",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidCountry",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyGeoCountry",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyGeoCountry.Name",
					
	
                    TypeName = "KSTimeModel.KstProxyGeoCountry",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyGeoCountries"
                    /*,PropertyDisplayName = Resources.KstProxyGeoStateResources.KSTPROXYGEOCOUNTRY*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProxyGeoStateModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProxyGeoStateModel>> me = new MyEventArgs<UIModel<KstProxyGeoStateModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProxyGeoStateModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProxyGeoStatesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProxyGeoStatesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProxyGeoStateModel model = null;
            List<KstProxyGeoStateModel> results = new List<KstProxyGeoStateModel>();
            foreach (var item in bos)
            {
                model = new KstProxyGeoStateModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProxyGeoStateModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProxyGeoStateModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProxyGeoStateModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoStateModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyGeoStateModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProxyGeoStateModel model = null;
            ControllerEventArgs<KstProxyGeoStateModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProxyGeoStateModel>() { Id = objectKey  });
             bool cancel = false;
             KstProxyGeoStateModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidState = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidState"));
			if (dec)
                 {
                     guidState = new Guid(id);
                 }
                 else
                 {
                     guidState = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProxyGeoStateModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProxyGeoStatesBR.Instance.GetByKey(guidState, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProxyGeoStateModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoStateModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProxyGeoStateModel> GetContextModel(UIModelContextTypes formMode, KstProxyGeoStateModel model, bool decript, Guid ? id) {
            UIModel<KstProxyGeoStateModel> me = new UIModel<KstProxyGeoStateModel>(true, "KstProxyGeoStates");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProxyGeoState";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProxyGeoState";
            me.EntitySetName = "KstProxyGeoStates";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProxyGeoStates";
            me.PropertyKeyName = "GuidState";

            me.Properties = GetProperties(me, decript, id);
 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProxyGeoStateResources.KSTPROXYGEOSTATES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidState") != null){
						me.Properties.Find(p => p.PropertyName == "GuidState").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstActivities;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstActivitiesController : KS.Time.Api.ControllerBase<Models.KstActivities.KstActivityModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstActivities.KstActivityModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstActivities.KstActivityModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstActivities.KstActivityModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstActivities.KstActivityModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstActivities.KstActivityModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstActivities.KstActivityModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstActivityModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstActivityModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstActivityModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstActivityModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstActivityModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstActivityModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstActivitiesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstActivityModel model = new KstActivityModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstActivityModel> data, ContextRequest contextRequest)
        {
            List<KstActivity> items = new  List<KstActivity>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstActivitiesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstActivity", "KSTime", typeof(KstActivitiesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstActivitiesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstActivityModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstActivityModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstActivityModel> models, ContextRequest contextRequest)
        {
            List<KstActivity> objs = new List<KstActivity>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstActivitiesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstActivityModel> models, ContextRequest contextRequest)
        {
            List<KstActivity> objs = new List<KstActivity>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstActivitiesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstActivitiesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstActivityModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstActivityModel> GetAll() {
            			var bos = BR.KstActivitiesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstActivityModel> results = new List<KstActivityModel>();
            KstActivityModel model = null;
            foreach (var bo in bos)
            {
                model = new KstActivityModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstActivity = GetRouteDataOrQueryParam("id");
			if (idKstActivity != null)
			{
				if (!decripted)
                {
					idKstActivity = SFS.Core.Entities.Utils.GetPropertyKey(idKstActivity.Replace("-","/"), "GuidActivity");
				}else{
					if (id != null )
						idKstActivity = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidActivity"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidActivity")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidActivity",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidActivity",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.GUIDACTIVITY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidProject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.GUIDPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("IsCustomByUser"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "IsCustomByUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "IsCustomByUser",

					 MaxLength = 0,
					IsRequired = true ,
					IsDefaultProperty = false,
                    SortBy = "IsCustomByUser",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.ISCUSTOMBYUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 122,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstActivityResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProject"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstActivities" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProject.GuidProject")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProject.GuidProject" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjects" });
			

	
	//fk_KstActivity_KstProject
		//if (this.Request.QueryString["fk"] != "KstProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProject",
					BusinessObjectSet = "KstProjects",
					PropertyNavigationKey = "GuidProject",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidProject",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProject.Name",
					
	
                    TypeName = "KSTimeModel.KstProject",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProjects"
                    /*,PropertyDisplayName = Resources.KstActivityResources.KSTPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstWorkTimes"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstActivity" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstWorkTimes.GuidWorkTime")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstWorkTimes.GuidWorkTime" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstWorkTimes" });
			

	
	//fk_KstWorkTime_KstActivity
		//if (this.Request.QueryString["fk"] != "KstWorkTimes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstWorkTimes/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstWorkTimes&fk=KstActivity&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstActivity.GuidActivity = Guid(\"" + idKstActivity +"\")")+ "&fkValue=" + idKstActivity,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstWorkTime",
					BusinessObjectSet = "KstWorkTimes",
					
					CustomProperties = customProperties,

                    PropertyName = "KstWorkTimes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstWorkTimes.Title",
					
	
                    TypeName = "KSTimeModel.KstWorkTime",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstWorkTimes"
                    /*,PropertyDisplayName = Resources.KstActivityResources.KSTWORKTIMES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstActivityModel> uiModel) {
          	
			MyEventArgs<UIModel<KstActivityModel>> me = new MyEventArgs<UIModel<KstActivityModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstActivityModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstActivitiesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstActivitiesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstActivityModel model = null;
            List<KstActivityModel> results = new List<KstActivityModel>();
            foreach (var item in bos)
            {
                model = new KstActivityModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstActivityModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstActivityModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstActivityModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstActivityModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstActivityModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstActivityModel model = null;
            ControllerEventArgs<KstActivityModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstActivityModel>() { Id = objectKey  });
             bool cancel = false;
             KstActivityModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidActivity = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidActivity"));
			if (dec)
                 {
                     guidActivity = new Guid(id);
                 }
                 else
                 {
                     guidActivity = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstActivityModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstActivitiesBR.Instance.GetByKey(guidActivity, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstActivityModel> GetContextModel(UIModelContextTypes formMode, KstActivityModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstActivityModel> GetContextModel(UIModelContextTypes formMode, KstActivityModel model, bool decript, Guid ? id) {
            UIModel<KstActivityModel> me = new UIModel<KstActivityModel>(true, "KstActivities");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstActivity";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstActivity";
            me.EntitySetName = "KstActivities";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstActivities";
            me.PropertyKeyName = "GuidActivity";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstActivityResources.KSTACTIVITIES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidActivity") != null){
						me.Properties.Find(p => p.PropertyName == "GuidActivity").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProjects;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProjectsController : KS.Time.Api.ControllerBase<Models.KstProjects.KstProjectModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProjects.KstProjectModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProjects.KstProjectModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProjects.KstProjectModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProjects.KstProjectModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProjects.KstProjectModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjects.KstProjectModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProjectModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProjectModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProjectModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProjectModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProjectModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProjectModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProjectsBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProjectModel model = new KstProjectModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProjectModel> data, ContextRequest contextRequest)
        {
            List<KstProject> items = new  List<KstProject>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProjectsBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProject", "KSTime", typeof(KstProjectsController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProjectsBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProjectModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProjectModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProjectModel> models, ContextRequest contextRequest)
        {
            List<KstProject> objs = new List<KstProject>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProjectsBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProjectModel> models, ContextRequest contextRequest)
        {
            List<KstProject> objs = new List<KstProject>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProjectsBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProjectsBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProjectModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProjectModel> GetAll() {
            			var bos = BR.KstProjectsBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProjectModel> results = new List<KstProjectModel>();
            KstProjectModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProjectModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProject = GetRouteDataOrQueryParam("id");
			if (idKstProject != null)
			{
				if (!decripted)
                {
					idKstProject = SFS.Core.Entities.Utils.GetPropertyKey(idKstProject.Replace("-","/"), "GuidProject");
				}else{
					if (id != null )
						idKstProject = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidProject",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidProject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.GUIDPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 122,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstActivities"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProject" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstActivities.GuidActivity")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstActivities.GuidActivity" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstActivities" });
			

	
	//fk_KstActivity_KstProject
		//if (this.Request.QueryString["fk"] != "KstActivities")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstActivities/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstActivities&fk=KstProject&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProject.GuidProject = Guid(\"" + idKstProject +"\")")+ "&fkValue=" + idKstProject,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstActivity",
					BusinessObjectSet = "KstActivities",
					
					CustomProperties = customProperties,

                    PropertyName = "KstActivities",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstActivities.Name",
					
	
                    TypeName = "KSTimeModel.KstActivity",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstActivities"
                    /*,PropertyDisplayName = Resources.KstProjectResources.KSTACTIVITIES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProjectUsers"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProject" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProjectUsers.GuidProjectUser")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProjectUsers.GuidProjectUser" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjectUsers" });
			

	
	//fk_KstProjectUser_KstProject
		//if (this.Request.QueryString["fk"] != "KstProjectUsers")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProjectUsers/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProjectUsers&fk=KstProject&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProject.GuidProject = Guid(\"" + idKstProject +"\")")+ "&fkValue=" + idKstProject,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProjectUser",
					BusinessObjectSet = "KstProjectUsers",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProjectUsers",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProjectUsers.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstProjectUser",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProjectUsers"
                    /*,PropertyDisplayName = Resources.KstProjectResources.KSTPROJECTUSERS*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstWorkTimes"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProject" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstWorkTimes.GuidWorkTime")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstWorkTimes.GuidWorkTime" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstWorkTimes" });
			

	
	//fk_KstWorkTime_KstProject
		//if (this.Request.QueryString["fk"] != "KstWorkTimes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstWorkTimes/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstWorkTimes&fk=KstProject&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProject.GuidProject = Guid(\"" + idKstProject +"\")")+ "&fkValue=" + idKstProject,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstWorkTime",
					BusinessObjectSet = "KstWorkTimes",
					
					CustomProperties = customProperties,

                    PropertyName = "KstWorkTimes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstWorkTimes.Title",
					
	
                    TypeName = "KSTimeModel.KstWorkTime",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstWorkTimes"
                    /*,PropertyDisplayName = Resources.KstProjectResources.KSTWORKTIMES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProjectFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProject" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProjectFiles.GuidProjectFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProjectFiles.GuidProjectFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjectFiles" });
			

	
	//fk_KstProjectFile_KstProject
		//if (this.Request.QueryString["fk"] != "KstProjectFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProjectFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProjectFiles&fk=KstProject&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProject.GuidProject = Guid(\"" + idKstProject +"\")")+ "&fkValue=" + idKstProject,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProjectFile",
					BusinessObjectSet = "KstProjectFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProjectFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProjectFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstProjectFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProjectFiles"
                    /*,PropertyDisplayName = Resources.KstProjectResources.KSTPROJECTFILES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("NumActivities"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="ComputedLinq", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "NumActivities")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 112,
																	
					CustomProperties = customProperties,

                    PropertyName = "NumActivities",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "NumActivities",
					
	
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.NUMACTIVITIES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("NumUsers"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="ComputedLinq", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "NumUsers")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 113,
																	
					CustomProperties = customProperties,

                    PropertyName = "NumUsers",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "NumUsers",
					
	
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectResources.NUMUSERS*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProjectModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProjectModel>> me = new MyEventArgs<UIModel<KstProjectModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProjectModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProjectsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProjectsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProjectModel model = null;
            List<KstProjectModel> results = new List<KstProjectModel>();
            foreach (var item in bos)
            {
                model = new KstProjectModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProjectModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProjectModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProjectModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProjectModel model = null;
            ControllerEventArgs<KstProjectModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProjectModel>() { Id = objectKey  });
             bool cancel = false;
             KstProjectModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidProject = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidProject"));
			if (dec)
                 {
                     guidProject = new Guid(id);
                 }
                 else
                 {
                     guidProject = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProjectModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProjectsBR.Instance.GetByKey(guidProject, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProjectModel> GetContextModel(UIModelContextTypes formMode, KstProjectModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProjectModel> GetContextModel(UIModelContextTypes formMode, KstProjectModel model, bool decript, Guid ? id) {
            UIModel<KstProjectModel> me = new UIModel<KstProjectModel>(true, "KstProjects");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProject";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProject";
            me.EntitySetName = "KstProjects";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProjects";
            me.PropertyKeyName = "GuidProject";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProjectResources.KSTPROJECTS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

						 me.Properties.Find(p => p.PropertyName == "NumActivities").IsHidden = true;

						 me.Properties.Find(p => p.PropertyName == "NumUsers").IsHidden = true;

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidProject") != null){
						me.Properties.Find(p => p.PropertyName == "GuidProject").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProjectUsers;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProjectUsersController : KS.Time.Api.ControllerBase<Models.KstProjectUsers.KstProjectUserModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProjectUsers.KstProjectUserModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProjectUsers.KstProjectUserModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProjectUsers.KstProjectUserModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProjectUsers.KstProjectUserModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjectUsers.KstProjectUserModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProjectUserModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProjectUserModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProjectUserModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProjectUserModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProjectUserModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProjectUserModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProjectUsersBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProjectUserModel model = new KstProjectUserModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProjectUserModel> data, ContextRequest contextRequest)
        {
            List<KstProjectUser> items = new  List<KstProjectUser>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProjectUsersBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProjectUser", "KSTime", typeof(KstProjectUsersController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProjectUsersBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProjectUserModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProjectUserModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProjectUserModel> models, ContextRequest contextRequest)
        {
            List<KstProjectUser> objs = new List<KstProjectUser>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProjectUsersBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProjectUserModel> models, ContextRequest contextRequest)
        {
            List<KstProjectUser> objs = new List<KstProjectUser>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProjectUsersBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProjectUsersBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProjectUserModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProjectUserModel> GetAll() {
            			var bos = BR.KstProjectUsersBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "BizKeyEngine",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProjectUserModel> results = new List<KstProjectUserModel>();
            KstProjectUserModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProjectUserModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProjectUser = GetRouteDataOrQueryParam("id");
			if (idKstProjectUser != null)
			{
				if (!decripted)
                {
					idKstProjectUser = SFS.Core.Entities.Utils.GetPropertyKey(idKstProjectUser.Replace("-","/"), "GuidProjectUser");
				}else{
					if (id != null )
						idKstProjectUser = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProjectUser"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProjectUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidProjectUser",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidProjectUser",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.GUIDPROJECTUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidProject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.GUIDPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUser"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidUser",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidUser",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.GUIDUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("StartDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "StartDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "StartDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "StartDate",
					
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.STARTDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("EndDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "EndDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "EndDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "EndDate",
					
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.ENDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 124,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProject"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProjectUsers" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProject.GuidProject")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProject.GuidProject" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjects" });
			

	
	//fk_KstProjectUser_KstProject
		//if (this.Request.QueryString["fk"] != "KstProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProject",
					BusinessObjectSet = "KstProjects",
					PropertyNavigationKey = "GuidProject",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidProject",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProject.Name",
					
	
                    TypeName = "KSTimeModel.KstProject",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProjects"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.KSTPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyUser"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProjectUsers" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyUser.GuidUser")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyUser.GuidUser" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyUsers" });
			

	
	//fk_KstProjectUser_KstProxyUser
		//if (this.Request.QueryString["fk"] != "KstProxyUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 112,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyUser",
					BusinessObjectSet = "KstProxyUsers",
					PropertyNavigationKey = "GuidUser",
					PropertyNavigationText = "DisplayName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="DisplayName",
					GetMethodDisplayValue = "GuidUser",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyUser",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyUser.DisplayName",
					
	
                    TypeName = "KSTimeModel.KstProxyUser",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyUsers"
                    /*,PropertyDisplayName = Resources.KstProjectUserResources.KSTPROXYUSER*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProjectUserModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProjectUserModel>> me = new MyEventArgs<UIModel<KstProjectUserModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProjectUserModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProjectUsersBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProjectUsersBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProjectUserModel model = null;
            List<KstProjectUserModel> results = new List<KstProjectUserModel>();
            foreach (var item in bos)
            {
                model = new KstProjectUserModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProjectUserModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProjectUserModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProjectUserModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectUserModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectUserModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProjectUserModel model = null;
            ControllerEventArgs<KstProjectUserModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProjectUserModel>() { Id = objectKey  });
             bool cancel = false;
             KstProjectUserModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidProjectUser = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidProjectUser"));
			if (dec)
                 {
                     guidProjectUser = new Guid(id);
                 }
                 else
                 {
                     guidProjectUser = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProjectUserModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProjectUsersBR.Instance.GetByKey(guidProjectUser, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProjectUserModel> GetContextModel(UIModelContextTypes formMode, KstProjectUserModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProjectUserModel> GetContextModel(UIModelContextTypes formMode, KstProjectUserModel model, bool decript, Guid ? id) {
            UIModel<KstProjectUserModel> me = new UIModel<KstProjectUserModel>(true, "KstProjectUsers");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProjectUser";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProjectUser";
            me.EntitySetName = "KstProjectUsers";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProjectUsers";
            me.PropertyKeyName = "GuidProjectUser";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProjectUserResources.KSTPROJECTUSERS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "BizKeyEngine") != null){
						me.Properties.Find(p => p.PropertyName == "BizKeyEngine").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidProjectUser") != null){
						me.Properties.Find(p => p.PropertyName == "GuidProjectUser").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstWorkTimes;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstWorkTimesController : KS.Time.Api.ControllerBase<Models.KstWorkTimes.KstWorkTimeModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstWorkTimes.KstWorkTimeModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimes.KstWorkTimeModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstWorkTimes.KstWorkTimeModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstWorkTimeModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstWorkTimeModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstWorkTimeModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstWorkTimeModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstWorkTimeModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstWorkTimeModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstWorkTimesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstWorkTimeModel model = new KstWorkTimeModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstWorkTimeModel> data, ContextRequest contextRequest)
        {
            List<KstWorkTime> items = new  List<KstWorkTime>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstWorkTimesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstWorkTime", "KSTime", typeof(KstWorkTimesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstWorkTimesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstWorkTimeModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstWorkTimeModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstWorkTimeModel> models, ContextRequest contextRequest)
        {
            List<KstWorkTime> objs = new List<KstWorkTime>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstWorkTimesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstWorkTimeModel> models, ContextRequest contextRequest)
        {
            List<KstWorkTime> objs = new List<KstWorkTime>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstWorkTimesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstWorkTimesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstWorkTimeModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstWorkTimeModel> GetAll() {
            			var bos = BR.KstWorkTimesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Title",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstWorkTimeModel> results = new List<KstWorkTimeModel>();
            KstWorkTimeModel model = null;
            foreach (var bo in bos)
            {
                model = new KstWorkTimeModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstWorkTime = GetRouteDataOrQueryParam("id");
			if (idKstWorkTime != null)
			{
				if (!decripted)
                {
					idKstWorkTime = SFS.Core.Entities.Utils.GetPropertyKey(idKstWorkTime.Replace("-","/"), "GuidWorkTime");
				}else{
					if (id != null )
						idKstWorkTime = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidWorkTime"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidWorkTime")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidWorkTime",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidWorkTime",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.GUIDWORKTIME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Title"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Title")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Title",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "Title",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.TITLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Comments"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Comments")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "Comments",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Comments",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.COMMENTS*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Hours"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Hours")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "Hours",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Hours",
					
	
                    TypeName = "Decimal",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.HOURS*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidProject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.GUIDPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidActivity"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidActivity")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidActivity",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidActivity",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.GUIDACTIVITY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 128,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("DueDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "DueDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 112,
																	
					CustomProperties = customProperties,

                    PropertyName = "DueDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "DueDate",
					
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.DUEDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstActivity"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstWorkTimes" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstActivity.GuidActivity")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstActivity.GuidActivity" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstActivities" });
			

	
	//fk_KstWorkTime_KstActivity
		//if (this.Request.QueryString["fk"] != "KstActivity")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 113,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstActivity",
					BusinessObjectSet = "KstActivities",
					PropertyNavigationKey = "GuidActivity",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidActivity",
					
					CustomProperties = customProperties,

                    PropertyName = "KstActivity",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstActivity.Name",
					
	
                    TypeName = "KSTimeModel.KstActivity",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstActivities"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.KSTACTIVITY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProject"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstWorkTimes" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProject.GuidProject")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProject.GuidProject" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjects" });
			

	
	//fk_KstWorkTime_KstProject
		//if (this.Request.QueryString["fk"] != "KstProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 114,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProject",
					BusinessObjectSet = "KstProjects",
					PropertyNavigationKey = "GuidProject",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidProject",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProject.Name",
					
	
                    TypeName = "KSTimeModel.KstProject",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProjects"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.KSTPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstWorkTimeFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstWorkTime" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstWorkTimeFiles.GuidWorkTimeFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstWorkTimeFiles.GuidWorkTimeFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstWorkTimeFiles" });
			

	
	//fk_KstWorkTimeFile_KstWorkTime
		//if (this.Request.QueryString["fk"] != "KstWorkTimeFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 115,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstWorkTimeFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstWorkTimeFiles&fk=KstWorkTime&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstWorkTime.GuidWorkTime = Guid(\"" + idKstWorkTime +"\")")+ "&fkValue=" + idKstWorkTime,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstWorkTimeFile",
					BusinessObjectSet = "KstWorkTimeFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstWorkTimeFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstWorkTimeFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstWorkTimeFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstWorkTimeFiles"
                    /*,PropertyDisplayName = Resources.KstWorkTimeResources.KSTWORKTIMEFILES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstWorkTimeModel> uiModel) {
          	
			MyEventArgs<UIModel<KstWorkTimeModel>> me = new MyEventArgs<UIModel<KstWorkTimeModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstWorkTimeModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstWorkTimesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstWorkTimesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstWorkTimeModel model = null;
            List<KstWorkTimeModel> results = new List<KstWorkTimeModel>();
            foreach (var item in bos)
            {
                model = new KstWorkTimeModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstWorkTimeModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstWorkTimeModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstWorkTimeModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstWorkTimeModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstWorkTimeModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstWorkTimeModel model = null;
            ControllerEventArgs<KstWorkTimeModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstWorkTimeModel>() { Id = objectKey  });
             bool cancel = false;
             KstWorkTimeModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidWorkTime = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidWorkTime"));
			if (dec)
                 {
                     guidWorkTime = new Guid(id);
                 }
                 else
                 {
                     guidWorkTime = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstWorkTimeModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstWorkTimesBR.Instance.GetByKey(guidWorkTime, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstWorkTimeModel> GetContextModel(UIModelContextTypes formMode, KstWorkTimeModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstWorkTimeModel> GetContextModel(UIModelContextTypes formMode, KstWorkTimeModel model, bool decript, Guid ? id) {
            UIModel<KstWorkTimeModel> me = new UIModel<KstWorkTimeModel>(true, "KstWorkTimes");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstWorkTime";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstWorkTime";
            me.EntitySetName = "KstWorkTimes";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstWorkTimes";
            me.PropertyKeyName = "GuidWorkTime";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstWorkTimeResources.KSTWORKTIMES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Title") != null){
						me.Properties.Find(p => p.PropertyName == "Title").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidWorkTime") != null){
						me.Properties.Find(p => p.PropertyName == "GuidWorkTime").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstFiles;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstFilesController : KS.Time.Api.ControllerBase<Models.KstFiles.KstFileModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstFiles.KstFileModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstFiles.KstFileModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstFiles.KstFileModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstFiles.KstFileModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstFiles.KstFileModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstFiles.KstFileModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstFileModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstFileModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstFileModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstFileModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstFileModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstFileModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstFilesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstFileModel model = new KstFileModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstFileModel> data, ContextRequest contextRequest)
        {
            List<KstFile> items = new  List<KstFile>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstFilesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstFile", "KSTime", typeof(KstFilesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstFilesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstFileModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstFileModel> models, ContextRequest contextRequest)
        {
            List<KstFile> objs = new List<KstFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstFilesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstFileModel> models, ContextRequest contextRequest)
        {
            List<KstFile> objs = new List<KstFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstFilesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstFilesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstFileModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstFileModel> GetAll() {
            			var bos = BR.KstFilesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "FileName",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstFileModel> results = new List<KstFileModel>();
            KstFileModel model = null;
            foreach (var bo in bos)
            {
                model = new KstFileModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstFile = GetRouteDataOrQueryParam("id");
			if (idKstFile != null)
			{
				if (!decripted)
                {
					idKstFile = SFS.Core.Entities.Utils.GetPropertyKey(idKstFile.Replace("-","/"), "GuidFile");
				}else{
					if (id != null )
						idKstFile = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidFile",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.GUIDFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileName",

					 MaxLength = 255,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "FileName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILENAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileType"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileType")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileType",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FileType",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILETYPE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileData"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileData")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileData",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FileData",
					
	
                    TypeName = "Binary",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILEDATA*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileStorage"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileStorage")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileStorage",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FileStorage",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILESTORAGE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ContainerStorage"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "ContainerStorage")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "ContainerStorage",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ContainerStorage",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.CONTAINERSTORAGE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileThumbSizes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileThumbSizes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileThumbSizes",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FileThumbSizes",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILETHUMBSIZES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FileSize"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FileSize")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "FileSize",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FileSize",
					
	
                    TypeName = "Int64",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.FILESIZE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 131,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 113,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstFileResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProjectFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstFile" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProjectFiles.GuidProjectFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProjectFiles.GuidProjectFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjectFiles" });
			

	
	//fk_KstProjectFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstProjectFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 114,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProjectFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProjectFiles&fk=KstFile&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstFile.GuidFile = Guid(\"" + idKstFile +"\")")+ "&fkValue=" + idKstFile,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProjectFile",
					BusinessObjectSet = "KstProjectFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProjectFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProjectFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstProjectFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProjectFiles"
                    /*,PropertyDisplayName = Resources.KstFileResources.KSTPROJECTFILES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstUserFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstFile" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstUserFiles.GuidUserFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstUserFiles.GuidUserFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstUserFiles" });
			

	
	//fk_KstUserFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstUserFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 115,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstUserFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstUserFiles&fk=KstFile&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstFile.GuidFile = Guid(\"" + idKstFile +"\")")+ "&fkValue=" + idKstFile,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstUserFile",
					BusinessObjectSet = "KstUserFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstUserFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstUserFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstUserFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstUserFiles"
                    /*,PropertyDisplayName = Resources.KstFileResources.KSTUSERFILES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstWorkTimeFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstFile" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstWorkTimeFiles.GuidWorkTimeFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstWorkTimeFiles.GuidWorkTimeFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstWorkTimeFiles" });
			

	
	//fk_KstWorkTimeFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstWorkTimeFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 116,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstWorkTimeFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstWorkTimeFiles&fk=KstFile&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstFile.GuidFile = Guid(\"" + idKstFile +"\")")+ "&fkValue=" + idKstFile,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstWorkTimeFile",
					BusinessObjectSet = "KstWorkTimeFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstWorkTimeFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstWorkTimeFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstWorkTimeFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstWorkTimeFiles"
                    /*,PropertyDisplayName = Resources.KstFileResources.KSTWORKTIMEFILES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstFileModel> uiModel) {
          	
			MyEventArgs<UIModel<KstFileModel>> me = new MyEventArgs<UIModel<KstFileModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstFileModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstFileModel model = null;
            List<KstFileModel> results = new List<KstFileModel>();
            foreach (var item in bos)
            {
                model = new KstFileModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstFileModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstFileModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstFileModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstFileModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstFileModel model = null;
            ControllerEventArgs<KstFileModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstFileModel>() { Id = objectKey  });
             bool cancel = false;
             KstFileModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidFile = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidFile"));
			if (dec)
                 {
                     guidFile = new Guid(id);
                 }
                 else
                 {
                     guidFile = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstFileModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstFilesBR.Instance.GetByKey(guidFile, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstFileModel> GetContextModel(UIModelContextTypes formMode, KstFileModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstFileModel> GetContextModel(UIModelContextTypes formMode, KstFileModel model, bool decript, Guid ? id) {
            UIModel<KstFileModel> me = new UIModel<KstFileModel>(true, "KstFiles");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstFile";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstFile";
            me.EntitySetName = "KstFiles";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstFiles";
            me.PropertyKeyName = "GuidFile";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstFileResources.KSTFILES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "FileName") != null){
						me.Properties.Find(p => p.PropertyName == "FileName").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidFile") != null){
						me.Properties.Find(p => p.PropertyName == "GuidFile").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProjectFiles;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProjectFilesController : KS.Time.Api.ControllerBase<Models.KstProjectFiles.KstProjectFileModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProjectFiles.KstProjectFileModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProjectFiles.KstProjectFileModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProjectFiles.KstProjectFileModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProjectFiles.KstProjectFileModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProjectFiles.KstProjectFileModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProjectFileModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProjectFileModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProjectFileModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProjectFileModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProjectFileModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProjectFileModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProjectFilesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProjectFileModel model = new KstProjectFileModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProjectFileModel> data, ContextRequest contextRequest)
        {
            List<KstProjectFile> items = new  List<KstProjectFile>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProjectFilesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProjectFile", "KSTime", typeof(KstProjectFilesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProjectFilesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProjectFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProjectFileModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProjectFileModel> models, ContextRequest contextRequest)
        {
            List<KstProjectFile> objs = new List<KstProjectFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProjectFilesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProjectFileModel> models, ContextRequest contextRequest)
        {
            List<KstProjectFile> objs = new List<KstProjectFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProjectFilesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProjectFilesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProjectFileModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProjectFileModel> GetAll() {
            			var bos = BR.KstProjectFilesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "BizKeyEngine",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProjectFileModel> results = new List<KstProjectFileModel>();
            KstProjectFileModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProjectFileModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProjectFile = GetRouteDataOrQueryParam("id");
			if (idKstProjectFile != null)
			{
				if (!decripted)
                {
					idKstProjectFile = SFS.Core.Entities.Utils.GetPropertyKey(idKstProjectFile.Replace("-","/"), "GuidProjectFile");
				}else{
					if (id != null )
						idKstProjectFile = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProjectFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProjectFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidProjectFile",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidProjectFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.GUIDPROJECTFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidProject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidProject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.GUIDPROJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.GUIDFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 120,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstFile"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProjectFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstFile.GuidFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstFile.GuidFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstFiles" });
			

	
	//fk_KstProjectFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstFile",
					BusinessObjectSet = "KstFiles",
					PropertyNavigationKey = "GuidFile",
					PropertyNavigationText = "FileName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="FileName",
					GetMethodDisplayValue = "GuidFile",
					
					CustomProperties = customProperties,

                    PropertyName = "KstFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstFile.FileName",
					
	
                    TypeName = "KSTimeModel.KstFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstFiles"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.KSTFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProject"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProjectFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProject.GuidProject")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProject.GuidProject" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjects" });
			

	
	//fk_KstProjectFile_KstProject
		//if (this.Request.QueryString["fk"] != "KstProject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProject",
					BusinessObjectSet = "KstProjects",
					PropertyNavigationKey = "GuidProject",
					PropertyNavigationText = "Name",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Name",
					GetMethodDisplayValue = "GuidProject",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProject",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProject.Name",
					
	
                    TypeName = "KSTimeModel.KstProject",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProjects"
                    /*,PropertyDisplayName = Resources.KstProjectFileResources.KSTPROJECT*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProjectFileModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProjectFileModel>> me = new MyEventArgs<UIModel<KstProjectFileModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProjectFileModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProjectFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProjectFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProjectFileModel model = null;
            List<KstProjectFileModel> results = new List<KstProjectFileModel>();
            foreach (var item in bos)
            {
                model = new KstProjectFileModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProjectFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProjectFileModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProjectFileModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectFileModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProjectFileModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProjectFileModel model = null;
            ControllerEventArgs<KstProjectFileModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProjectFileModel>() { Id = objectKey  });
             bool cancel = false;
             KstProjectFileModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidProjectFile = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidProjectFile"));
			if (dec)
                 {
                     guidProjectFile = new Guid(id);
                 }
                 else
                 {
                     guidProjectFile = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProjectFileModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProjectFilesBR.Instance.GetByKey(guidProjectFile, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProjectFileModel> GetContextModel(UIModelContextTypes formMode, KstProjectFileModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProjectFileModel> GetContextModel(UIModelContextTypes formMode, KstProjectFileModel model, bool decript, Guid ? id) {
            UIModel<KstProjectFileModel> me = new UIModel<KstProjectFileModel>(true, "KstProjectFiles");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProjectFile";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProjectFile";
            me.EntitySetName = "KstProjectFiles";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProjectFiles";
            me.PropertyKeyName = "GuidProjectFile";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProjectFileResources.KSTPROJECTFILES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "BizKeyEngine") != null){
						me.Properties.Find(p => p.PropertyName == "BizKeyEngine").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidProjectFile") != null){
						me.Properties.Find(p => p.PropertyName == "GuidProjectFile").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstUserFiles;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstUserFilesController : KS.Time.Api.ControllerBase<Models.KstUserFiles.KstUserFileModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstUserFiles.KstUserFileModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstUserFiles.KstUserFileModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstUserFiles.KstUserFileModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstUserFiles.KstUserFileModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstUserFiles.KstUserFileModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstUserFileModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstUserFileModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstUserFileModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstUserFileModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstUserFileModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstUserFileModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstUserFilesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstUserFileModel model = new KstUserFileModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstUserFileModel> data, ContextRequest contextRequest)
        {
            List<KstUserFile> items = new  List<KstUserFile>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstUserFilesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstUserFile", "KSTime", typeof(KstUserFilesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstUserFilesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstUserFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstUserFileModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstUserFileModel> models, ContextRequest contextRequest)
        {
            List<KstUserFile> objs = new List<KstUserFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstUserFilesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstUserFileModel> models, ContextRequest contextRequest)
        {
            List<KstUserFile> objs = new List<KstUserFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstUserFilesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstUserFilesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstUserFileModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstUserFileModel> GetAll() {
            			var bos = BR.KstUserFilesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "BizKeyEngine",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstUserFileModel> results = new List<KstUserFileModel>();
            KstUserFileModel model = null;
            foreach (var bo in bos)
            {
                model = new KstUserFileModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstUserFile = GetRouteDataOrQueryParam("id");
			if (idKstUserFile != null)
			{
				if (!decripted)
                {
					idKstUserFile = SFS.Core.Entities.Utils.GetPropertyKey(idKstUserFile.Replace("-","/"), "GuidUserFile");
				}else{
					if (id != null )
						idKstUserFile = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUserFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUserFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidUserFile",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidUserFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.GUIDUSERFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUser"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidUser",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidUser",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.GUIDUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.GUIDFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("IsProfileDefault"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "IsProfileDefault")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "IsProfileDefault",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "IsProfileDefault",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.ISPROFILEDEFAULT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 122,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstFile"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstUserFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstFile.GuidFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstFile.GuidFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstFiles" });
			

	
	//fk_KstUserFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstFile",
					BusinessObjectSet = "KstFiles",
					PropertyNavigationKey = "GuidFile",
					PropertyNavigationText = "FileName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="FileName",
					GetMethodDisplayValue = "GuidFile",
					
					CustomProperties = customProperties,

                    PropertyName = "KstFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstFile.FileName",
					
	
                    TypeName = "KSTimeModel.KstFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstFiles"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.KSTFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyUser"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstUserFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyUser.GuidUser")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyUser.GuidUser" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyUsers" });
			

	
	//fk_KstUserFile_KstProxyUser
		//if (this.Request.QueryString["fk"] != "KstProxyUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyUser",
					BusinessObjectSet = "KstProxyUsers",
					PropertyNavigationKey = "GuidUser",
					PropertyNavigationText = "DisplayName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="DisplayName",
					GetMethodDisplayValue = "GuidUser",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyUser",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyUser.DisplayName",
					
	
                    TypeName = "KSTimeModel.KstProxyUser",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyUsers"
                    /*,PropertyDisplayName = Resources.KstUserFileResources.KSTPROXYUSER*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstUserFileModel> uiModel) {
          	
			MyEventArgs<UIModel<KstUserFileModel>> me = new MyEventArgs<UIModel<KstUserFileModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstUserFileModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstUserFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstUserFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstUserFileModel model = null;
            List<KstUserFileModel> results = new List<KstUserFileModel>();
            foreach (var item in bos)
            {
                model = new KstUserFileModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstUserFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstUserFileModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstUserFileModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstUserFileModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstUserFileModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstUserFileModel model = null;
            ControllerEventArgs<KstUserFileModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstUserFileModel>() { Id = objectKey  });
             bool cancel = false;
             KstUserFileModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidUserFile = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidUserFile"));
			if (dec)
                 {
                     guidUserFile = new Guid(id);
                 }
                 else
                 {
                     guidUserFile = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstUserFileModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstUserFilesBR.Instance.GetByKey(guidUserFile, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstUserFileModel> GetContextModel(UIModelContextTypes formMode, KstUserFileModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstUserFileModel> GetContextModel(UIModelContextTypes formMode, KstUserFileModel model, bool decript, Guid ? id) {
            UIModel<KstUserFileModel> me = new UIModel<KstUserFileModel>(true, "KstUserFiles");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstUserFile";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstUserFile";
            me.EntitySetName = "KstUserFiles";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstUserFiles";
            me.PropertyKeyName = "GuidUserFile";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstUserFileResources.KSTUSERFILES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "BizKeyEngine") != null){
						me.Properties.Find(p => p.PropertyName == "BizKeyEngine").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidUserFile") != null){
						me.Properties.Find(p => p.PropertyName == "GuidUserFile").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstWorkTimeFiles;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstWorkTimeFilesController : KS.Time.Api.ControllerBase<Models.KstWorkTimeFiles.KstWorkTimeFileModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstWorkTimeFiles.KstWorkTimeFileModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstWorkTimeFiles.KstWorkTimeFileModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstWorkTimeFileModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstWorkTimeFileModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstWorkTimeFileModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstWorkTimeFileModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstWorkTimeFileModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstWorkTimeFileModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstWorkTimeFilesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstWorkTimeFileModel model = new KstWorkTimeFileModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstWorkTimeFileModel> data, ContextRequest contextRequest)
        {
            List<KstWorkTimeFile> items = new  List<KstWorkTimeFile>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstWorkTimeFilesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstWorkTimeFile", "KSTime", typeof(KstWorkTimeFilesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstWorkTimeFilesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstWorkTimeFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstWorkTimeFileModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstWorkTimeFileModel> models, ContextRequest contextRequest)
        {
            List<KstWorkTimeFile> objs = new List<KstWorkTimeFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstWorkTimeFilesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstWorkTimeFileModel> models, ContextRequest contextRequest)
        {
            List<KstWorkTimeFile> objs = new List<KstWorkTimeFile>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstWorkTimeFilesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstWorkTimeFilesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstWorkTimeFileModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstWorkTimeFileModel> GetAll() {
            			var bos = BR.KstWorkTimeFilesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "BizKeyEngine",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstWorkTimeFileModel> results = new List<KstWorkTimeFileModel>();
            KstWorkTimeFileModel model = null;
            foreach (var bo in bos)
            {
                model = new KstWorkTimeFileModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstWorkTimeFile = GetRouteDataOrQueryParam("id");
			if (idKstWorkTimeFile != null)
			{
				if (!decripted)
                {
					idKstWorkTimeFile = SFS.Core.Entities.Utils.GetPropertyKey(idKstWorkTimeFile.Replace("-","/"), "GuidWorkTimeFile");
				}else{
					if (id != null )
						idKstWorkTimeFile = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidWorkTimeFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidWorkTimeFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidWorkTimeFile",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidWorkTimeFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.GUIDWORKTIMEFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidWorkTime"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidWorkTime")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidWorkTime",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidWorkTime",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.GUIDWORKTIME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidFile"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidFile",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.GUIDFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BizKeyEngine"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BizKeyEngine")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "BizKeyEngine",

					 MaxLength = 32,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "BizKeyEngine",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.BIZKEYENGINE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 120,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.BYTES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstFile"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstWorkTimeFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstFile.GuidFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstFile.GuidFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstFiles" });
			

	
	//fk_KstWorkTimeFile_KstFile
		//if (this.Request.QueryString["fk"] != "KstFile")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstFile",
					BusinessObjectSet = "KstFiles",
					PropertyNavigationKey = "GuidFile",
					PropertyNavigationText = "FileName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="FileName",
					GetMethodDisplayValue = "GuidFile",
					
					CustomProperties = customProperties,

                    PropertyName = "KstFile",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstFile.FileName",
					
	
                    TypeName = "KSTimeModel.KstFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstFiles"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.KSTFILE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstWorkTime"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstWorkTimeFiles" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstWorkTime.GuidWorkTime")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstWorkTime.GuidWorkTime" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstWorkTimes" });
			

	
	//fk_KstWorkTimeFile_KstWorkTime
		//if (this.Request.QueryString["fk"] != "KstWorkTime")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstWorkTime",
					BusinessObjectSet = "KstWorkTimes",
					PropertyNavigationKey = "GuidWorkTime",
					PropertyNavigationText = "Title",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="Title",
					GetMethodDisplayValue = "GuidWorkTime",
					
					CustomProperties = customProperties,

                    PropertyName = "KstWorkTime",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstWorkTime.Title",
					
	
                    TypeName = "KSTimeModel.KstWorkTime",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstWorkTimes"
                    /*,PropertyDisplayName = Resources.KstWorkTimeFileResources.KSTWORKTIME*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstWorkTimeFileModel> uiModel) {
          	
			MyEventArgs<UIModel<KstWorkTimeFileModel>> me = new MyEventArgs<UIModel<KstWorkTimeFileModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstWorkTimeFileModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstWorkTimeFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstWorkTimeFilesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstWorkTimeFileModel model = null;
            List<KstWorkTimeFileModel> results = new List<KstWorkTimeFileModel>();
            foreach (var item in bos)
            {
                model = new KstWorkTimeFileModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstWorkTimeFileModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstWorkTimeFileModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstWorkTimeFileModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstWorkTimeFileModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstWorkTimeFileModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstWorkTimeFileModel model = null;
            ControllerEventArgs<KstWorkTimeFileModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstWorkTimeFileModel>() { Id = objectKey  });
             bool cancel = false;
             KstWorkTimeFileModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidWorkTimeFile = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidWorkTimeFile"));
			if (dec)
                 {
                     guidWorkTimeFile = new Guid(id);
                 }
                 else
                 {
                     guidWorkTimeFile = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstWorkTimeFileModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstWorkTimeFilesBR.Instance.GetByKey(guidWorkTimeFile, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstWorkTimeFileModel> GetContextModel(UIModelContextTypes formMode, KstWorkTimeFileModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstWorkTimeFileModel> GetContextModel(UIModelContextTypes formMode, KstWorkTimeFileModel model, bool decript, Guid ? id) {
            UIModel<KstWorkTimeFileModel> me = new UIModel<KstWorkTimeFileModel>(true, "KstWorkTimeFiles");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstWorkTimeFile";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstWorkTimeFile";
            me.EntitySetName = "KstWorkTimeFiles";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstWorkTimeFiles";
            me.PropertyKeyName = "GuidWorkTimeFile";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstWorkTimeFileResources.KSTWORKTIMEFILES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "BizKeyEngine") != null){
						me.Properties.Find(p => p.PropertyName == "BizKeyEngine").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidWorkTimeFile") != null){
						me.Properties.Find(p => p.PropertyName == "GuidWorkTimeFile").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProxyRoles;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProxyRolesController : KS.Time.Api.ControllerBase<Models.KstProxyRoles.KstProxyRoleModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProxyRoles.KstProxyRoleModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProxyRoles.KstProxyRoleModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyRoles.KstProxyRoleModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProxyRoleModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProxyRoleModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProxyRoleModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProxyRoleModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProxyRoleModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProxyRoleModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProxyRolesBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProxyRoleModel model = new KstProxyRoleModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProxyRoleModel> data, ContextRequest contextRequest)
        {
            List<KstProxyRole> items = new  List<KstProxyRole>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProxyRolesBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProxyRole", "KSTime", typeof(KstProxyRolesController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProxyRolesBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProxyRoleModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProxyRoleModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProxyRoleModel> models, ContextRequest contextRequest)
        {
            List<KstProxyRole> objs = new List<KstProxyRole>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProxyRolesBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProxyRoleModel> models, ContextRequest contextRequest)
        {
            List<KstProxyRole> objs = new List<KstProxyRole>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProxyRolesBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProxyRolesBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProxyRoleModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProxyRoleModel> GetAll() {
            			var bos = BR.KstProxyRolesBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "RoleName",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProxyRoleModel> results = new List<KstProxyRoleModel>();
            KstProxyRoleModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProxyRoleModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProxyRole = GetRouteDataOrQueryParam("id");
			if (idKstProxyRole != null)
			{
				if (!decripted)
                {
					idKstProxyRole = SFS.Core.Entities.Utils.GetPropertyKey(idKstProxyRole.Replace("-","/"), "GuidRole");
				}else{
					if (id != null )
						idKstProxyRole = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidRole"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidRole")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidRole",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidRole",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyRoleResources.GUIDROLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("RoleName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "RoleName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "RoleName",

					 MaxLength = 150,
					IsRequired = true ,
					IsDefaultProperty = true,
                    SortBy = "RoleName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyRoleResources.ROLENAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("NameKey"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "NameKey")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "NameKey",

					 MaxLength = 100,
					IsRequired = true ,
					IsDefaultProperty = false,
                    SortBy = "NameKey",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyRoleResources.NAMEKEY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyRoleResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyUsers"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyRole" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyUsers.GuidUser")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyUsers.GuidUser" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyUsers" });
			

	
	//fk_KstProxyUser_KstProxyRole
		//if (this.Request.QueryString["fk"] != "KstProxyUsers")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProxyUsers/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProxyUsers&fk=KstProxyRole&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyRole.GuidRole = Guid(\"" + idKstProxyRole +"\")")+ "&fkValue=" + idKstProxyRole,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProxyUser",
					BusinessObjectSet = "KstProxyUsers",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyUsers",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyUsers.DisplayName",
					
	
                    TypeName = "KSTimeModel.KstProxyUser",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProxyUsers"
                    /*,PropertyDisplayName = Resources.KstProxyRoleResources.KSTPROXYUSERS*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProxyRoleModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProxyRoleModel>> me = new MyEventArgs<UIModel<KstProxyRoleModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProxyRoleModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProxyRolesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProxyRolesBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProxyRoleModel model = null;
            List<KstProxyRoleModel> results = new List<KstProxyRoleModel>();
            foreach (var item in bos)
            {
                model = new KstProxyRoleModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProxyRoleModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProxyRoleModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProxyRoleModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyRoleModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyRoleModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProxyRoleModel model = null;
            ControllerEventArgs<KstProxyRoleModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProxyRoleModel>() { Id = objectKey  });
             bool cancel = false;
             KstProxyRoleModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidRole = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidRole"));
			if (dec)
                 {
                     guidRole = new Guid(id);
                 }
                 else
                 {
                     guidRole = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProxyRoleModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProxyRolesBR.Instance.GetByKey(guidRole, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProxyRoleModel> GetContextModel(UIModelContextTypes formMode, KstProxyRoleModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProxyRoleModel> GetContextModel(UIModelContextTypes formMode, KstProxyRoleModel model, bool decript, Guid ? id) {
            UIModel<KstProxyRoleModel> me = new UIModel<KstProxyRoleModel>(true, "KstProxyRoles");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProxyRole";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProxyRole";
            me.EntitySetName = "KstProxyRoles";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProxyRoles";
            me.PropertyKeyName = "GuidRole";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProxyRoleResources.KSTPROXYROLES_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "RoleName") != null){
						me.Properties.Find(p => p.PropertyName == "RoleName").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidRole") != null){
						me.Properties.Find(p => p.PropertyName == "GuidRole").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.KstProxyUsers;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class KstProxyUsersController : KS.Time.Api.ControllerBase<Models.KstProxyUsers.KstProxyUserModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.KstProxyUsers.KstProxyUserModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.KstProxyUsers.KstProxyUserModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.KstProxyUsers.KstProxyUserModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.KstProxyUsers.KstProxyUserModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.KstProxyUsers.KstProxyUserModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<KstProxyUserModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<KstProxyUserModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<KstProxyUserModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<KstProxyUserModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<KstProxyUserModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<KstProxyUserModel> data, ContextRequest contextRequest)
        {
            var result = BR.KstProxyUsersBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                KstProxyUserModel model = new KstProxyUserModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<KstProxyUserModel> data, ContextRequest contextRequest)
        {
            List<KstProxyUser> items = new  List<KstProxyUser>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.KstProxyUsersBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "KstProxyUser", "KSTime", typeof(KstProxyUsersController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.KstProxyUsersBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<KstProxyUserModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<KstProxyUserModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<KstProxyUserModel> models, ContextRequest contextRequest)
        {
            List<KstProxyUser> objs = new List<KstProxyUser>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.KstProxyUsersBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<KstProxyUserModel> models, ContextRequest contextRequest)
        {
            List<KstProxyUser> objs = new List<KstProxyUser>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.KstProxyUsersBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.KstProxyUsersBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(KstProxyUserModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<KstProxyUserModel> GetAll() {
            			var bos = BR.KstProxyUsersBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "DisplayName",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<KstProxyUserModel> results = new List<KstProxyUserModel>();
            KstProxyUserModel model = null;
            foreach (var bo in bos)
            {
                model = new KstProxyUserModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idKstProxyUser = GetRouteDataOrQueryParam("id");
			if (idKstProxyUser != null)
			{
				if (!decripted)
                {
					idKstProxyUser = SFS.Core.Entities.Utils.GetPropertyKey(idKstProxyUser.Replace("-","/"), "GuidUser");
				}else{
					if (id != null )
						idKstProxyUser = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUser"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidUser",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidUser",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.GUIDUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("DisplayName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "DisplayName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "DisplayName",

					 MaxLength = 150,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "DisplayName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.DISPLAYNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Username"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Username")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "Username",

					 MaxLength = 100,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Username",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.USERNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Password"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Password")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "Password",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Password",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.PASSWORD*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("FirstName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "FirstName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "FirstName",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "FirstName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.FIRSTNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("LastName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "LastName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "LastName",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "LastName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.LASTNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Email"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Email")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "Email",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Email",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.EMAIL*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidRole"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidRole")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	IsForeignKey = true,

									
					CustomProperties = customProperties,

                    PropertyName = "GuidRole",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "GuidRole",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.GUIDROLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 123,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Disabled"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Disabled")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "Disabled",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Disabled",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.DISABLED*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProjectUsers"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyUser" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProjectUsers.GuidProjectUser")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProjectUsers.GuidProjectUser" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProjectUsers" });
			

	
	//fk_KstProjectUser_KstProxyUser
		//if (this.Request.QueryString["fk"] != "KstProjectUsers")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstProjectUsers/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstProjectUsers&fk=KstProxyUser&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyUser.GuidUser = Guid(\"" + idKstProxyUser +"\")")+ "&fkValue=" + idKstProxyUser,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstProjectUser",
					BusinessObjectSet = "KstProjectUsers",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProjectUsers",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProjectUsers.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstProjectUser",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstProjectUsers"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.KSTPROJECTUSERS*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstProxyRole"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyUsers" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstProxyRole.GuidRole")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstProxyRole.GuidRole" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstProxyRoles" });
			

	
	//fk_KstProxyUser_KstProxyRole
		//if (this.Request.QueryString["fk"] != "KstProxyRole")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 112,
																
					
					ModuleKey = "KSTime",
				BusinessObjectKey = "KstProxyRole",
					BusinessObjectSet = "KstProxyRoles",
					PropertyNavigationKey = "GuidRole",
					PropertyNavigationText = "RoleName",
					NavigationPropertyType = NavigationPropertyTypes.SimpleDropDown,
					GetMethodName = "GetAll",
					GetMethodParameters = "",
					GetMethodDisplayText ="RoleName",
					GetMethodDisplayValue = "GuidRole",
					
					CustomProperties = customProperties,

                    PropertyName = "KstProxyRole",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstProxyRole.RoleName",
					
	
                    TypeName = "KSTimeModel.KstProxyRole",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/KstProxyRoles"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.KSTPROXYROLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KstUserFiles"))
{				
    customProperties = new List<CustomProperty>();

        			customProperties.Add(new CustomProperty() { Name="Fk", Value=@"KstProxyUser" });
			//[RelationFilterable(DisableFilterableInSubfilter=true, FiltrablePropertyPathName="KstUserFiles.GuidUserFile")]		
			customProperties.Add(new CustomProperty() { Name="FiltrablePropertyPathName", Value=@"KstUserFiles.GuidUserFile" });
			customProperties.Add(new CustomProperty() { Name = "BusinessObjectSetName", Value = @"KstUserFiles" });
			

	
	//fk_KstUserFile_KstProxyUser
		//if (this.Request.QueryString["fk"] != "KstUserFiles")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 113,
																
					//Link = VirtualPathUtility.ToAbsolute("~/") + "KSTime/KstUserFiles/ListViewGen?overrideModule=" + GetOverrideApp()  + "&pal=False&es=False&pag=10&filterlinks=1&idTab=KstUserFiles&fk=KstProxyUser&startFilter="+ (new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext)).Encode("it.KstProxyUser.GuidUser = Guid(\"" + idKstProxyUser +"\")")+ "&fkValue=" + idKstProxyUser,
					ModuleKey = "KSTime",
					BusinessObjectKey = "KstUserFile",
					BusinessObjectSet = "KstUserFiles",
					
					CustomProperties = customProperties,

                    PropertyName = "KstUserFiles",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KstUserFiles.BizKeyEngine",
					
	
                    TypeName = "KSTimeModel.KstUserFile",
                    IsNavigationProperty = true,
					IsNavigationPropertyMany = true,
                    PathName = "KSTime/KstUserFiles"
                    /*,PropertyDisplayName = Resources.KstProxyUserResources.KSTUSERFILES*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<KstProxyUserModel> uiModel) {
          	
			MyEventArgs<UIModel<KstProxyUserModel>> me = new MyEventArgs<UIModel<KstProxyUserModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<KstProxyUserModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.KstProxyUsersBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.KstProxyUsersBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            KstProxyUserModel model = null;
            List<KstProxyUserModel> results = new List<KstProxyUserModel>();
            foreach (var item in bos)
            {
                model = new KstProxyUserModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<KstProxyUserModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<KstProxyUserModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  KstProxyUserModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyUserModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected KstProxyUserModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             KstProxyUserModel model = null;
            ControllerEventArgs<KstProxyUserModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<KstProxyUserModel>() { Id = objectKey  });
             bool cancel = false;
             KstProxyUserModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidUser = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidUser"));
			if (dec)
                 {
                     guidUser = new Guid(id);
                 }
                 else
                 {
                     guidUser = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new KstProxyUserModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.KstProxyUsersBR.Instance.GetByKey(guidUser, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<KstProxyUserModel> GetContextModel(UIModelContextTypes formMode, KstProxyUserModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<KstProxyUserModel> GetContextModel(UIModelContextTypes formMode, KstProxyUserModel model, bool decript, Guid ? id) {
            UIModel<KstProxyUserModel> me = new UIModel<KstProxyUserModel>(true, "KstProxyUsers");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "KstProxyUser";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "KstProxyUser";
            me.EntitySetName = "KstProxyUsers";

			me.AreaAction = "KSTime";
            me.ControllerAction = "KstProxyUsers";
            me.PropertyKeyName = "GuidUser";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = KstProxyUserResources.KSTPROXYUSERS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "DisplayName") != null){
						me.Properties.Find(p => p.PropertyName == "DisplayName").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidUser") != null){
						me.Properties.Find(p => p.PropertyName == "GuidUser").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.unProxyBusinessObjects;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class unProxyBusinessObjectsController : KS.Time.Api.ControllerBase<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.unProxyBusinessObjects.unProxyBusinessObjectModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxyBusinessObjects.unProxyBusinessObjectModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<unProxyBusinessObjectModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<unProxyBusinessObjectModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<unProxyBusinessObjectModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<unProxyBusinessObjectModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<unProxyBusinessObjectModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<unProxyBusinessObjectModel> data, ContextRequest contextRequest)
        {
            var result = BR.unProxyBusinessObjectsBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                unProxyBusinessObjectModel model = new unProxyBusinessObjectModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<unProxyBusinessObjectModel> data, ContextRequest contextRequest)
        {
            List<unProxyBusinessObject> items = new  List<unProxyBusinessObject>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.unProxyBusinessObjectsBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "unProxyBusinessObject", "KSTime", typeof(unProxyBusinessObjectsController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.unProxyBusinessObjectsBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<unProxyBusinessObjectModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<unProxyBusinessObjectModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<unProxyBusinessObjectModel> models, ContextRequest contextRequest)
        {
            List<unProxyBusinessObject> objs = new List<unProxyBusinessObject>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.unProxyBusinessObjectsBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<unProxyBusinessObjectModel> models, ContextRequest contextRequest)
        {
            List<unProxyBusinessObject> objs = new List<unProxyBusinessObject>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.unProxyBusinessObjectsBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.unProxyBusinessObjectsBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(unProxyBusinessObjectModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<unProxyBusinessObjectModel> GetAll() {
            			var bos = BR.unProxyBusinessObjectsBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<unProxyBusinessObjectModel> results = new List<unProxyBusinessObjectModel>();
            unProxyBusinessObjectModel model = null;
            foreach (var bo in bos)
            {
                model = new unProxyBusinessObjectModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idunProxyBusinessObject = GetRouteDataOrQueryParam("id");
			if (idunProxyBusinessObject != null)
			{
				if (!decripted)
                {
					idunProxyBusinessObject = SFS.Core.Entities.Utils.GetPropertyKey(idunProxyBusinessObject.Replace("-","/"), "GuidBusinessObject");
				}else{
					if (id != null )
						idunProxyBusinessObject = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidBusinessObject"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidBusinessObject")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidBusinessObject",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidBusinessObject",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyBusinessObjectResources.GUIDBUSINESSOBJECT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyBusinessObjectResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("BusinessObjectKey"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "BusinessObjectKey")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "BusinessObjectKey",

					 MaxLength = 100,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "BusinessObjectKey",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyBusinessObjectResources.BUSINESSOBJECTKEY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("EntitySetName"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "EntitySetName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "EntitySetName",

					 MaxLength = 100,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "EntitySetName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyBusinessObjectResources.ENTITYSETNAME*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<unProxyBusinessObjectModel> uiModel) {
          	
			MyEventArgs<UIModel<unProxyBusinessObjectModel>> me = new MyEventArgs<UIModel<unProxyBusinessObjectModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<unProxyBusinessObjectModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.unProxyBusinessObjectsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.unProxyBusinessObjectsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            unProxyBusinessObjectModel model = null;
            List<unProxyBusinessObjectModel> results = new List<unProxyBusinessObjectModel>();
            foreach (var item in bos)
            {
                model = new unProxyBusinessObjectModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<unProxyBusinessObjectModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<unProxyBusinessObjectModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  unProxyBusinessObjectModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxyBusinessObjectModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxyBusinessObjectModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             unProxyBusinessObjectModel model = null;
            ControllerEventArgs<unProxyBusinessObjectModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<unProxyBusinessObjectModel>() { Id = objectKey  });
             bool cancel = false;
             unProxyBusinessObjectModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidBusinessObject = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidBusinessObject"));
			if (dec)
                 {
                     guidBusinessObject = new Guid(id);
                 }
                 else
                 {
                     guidBusinessObject = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new unProxyBusinessObjectModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.unProxyBusinessObjectsBR.Instance.GetByKey(guidBusinessObject, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<unProxyBusinessObjectModel> GetContextModel(UIModelContextTypes formMode, unProxyBusinessObjectModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<unProxyBusinessObjectModel> GetContextModel(UIModelContextTypes formMode, unProxyBusinessObjectModel model, bool decript, Guid ? id) {
            UIModel<unProxyBusinessObjectModel> me = new UIModel<unProxyBusinessObjectModel>(true, "unProxyBusinessObjects");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "unProxyBusinessObject";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "unProxyBusinessObject";
            me.EntitySetName = "unProxyBusinessObjects";

			me.AreaAction = "KSTime";
            me.ControllerAction = "unProxyBusinessObjects";
            me.PropertyKeyName = "GuidBusinessObject";

            me.Properties = GetProperties(me, decript, id);
 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = unProxyBusinessObjectResources.UNPROXYBUSINESSOBJECTS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidBusinessObject") != null){
						me.Properties.Find(p => p.PropertyName == "GuidBusinessObject").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.unProxyEvents;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class unProxyEventsController : KS.Time.Api.ControllerBase<Models.unProxyEvents.unProxyEventModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.unProxyEvents.unProxyEventModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.unProxyEvents.unProxyEventModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.unProxyEvents.unProxyEventModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.unProxyEvents.unProxyEventModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxyEvents.unProxyEventModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<unProxyEventModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<unProxyEventModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<unProxyEventModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<unProxyEventModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<unProxyEventModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<unProxyEventModel> data, ContextRequest contextRequest)
        {
            var result = BR.unProxyEventsBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                unProxyEventModel model = new unProxyEventModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<unProxyEventModel> data, ContextRequest contextRequest)
        {
            List<unProxyEvent> items = new  List<unProxyEvent>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.unProxyEventsBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "unProxyEvent", "KSTime", typeof(unProxyEventsController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.unProxyEventsBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<unProxyEventModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<unProxyEventModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<unProxyEventModel> models, ContextRequest contextRequest)
        {
            List<unProxyEvent> objs = new List<unProxyEvent>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.unProxyEventsBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<unProxyEventModel> models, ContextRequest contextRequest)
        {
            List<unProxyEvent> objs = new List<unProxyEvent>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.unProxyEventsBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.unProxyEventsBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(unProxyEventModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<unProxyEventModel> GetAll() {
            			var bos = BR.unProxyEventsBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "Title",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<unProxyEventModel> results = new List<unProxyEventModel>();
            unProxyEventModel model = null;
            foreach (var bo in bos)
            {
                model = new unProxyEventModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idunProxyEvent = GetRouteDataOrQueryParam("id");
			if (idunProxyEvent != null)
			{
				if (!decripted)
                {
					idunProxyEvent = SFS.Core.Entities.Utils.GetPropertyKey(idunProxyEvent.Replace("-","/"), "GuidUnProxyEvent");
				}else{
					if (id != null )
						idunProxyEvent = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUnProxyEvent"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUnProxyEvent")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidUnProxyEvent",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidUnProxyEvent",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyEventResources.GUIDUNPROXYEVENT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Title"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Title")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Title",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "Title",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyEventResources.TITLE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Message"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Message")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "Message",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Message",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyEventResources.MESSAGE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("TypeEvent"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "TypeEvent")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "TypeEvent",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "TypeEvent",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyEventResources.TYPEEVENT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("IsException"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "IsException")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "IsException",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "IsException",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxyEventResources.ISEXCEPTION*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    //,PropertyDisplayName = SFS.Core.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<unProxyEventModel> uiModel) {
          	
			MyEventArgs<UIModel<unProxyEventModel>> me = new MyEventArgs<UIModel<unProxyEventModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<unProxyEventModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.unProxyEventsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.unProxyEventsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            unProxyEventModel model = null;
            List<unProxyEventModel> results = new List<unProxyEventModel>();
            foreach (var item in bos)
            {
                model = new unProxyEventModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<unProxyEventModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<unProxyEventModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  unProxyEventModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxyEventModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxyEventModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             unProxyEventModel model = null;
            ControllerEventArgs<unProxyEventModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<unProxyEventModel>() { Id = objectKey  });
             bool cancel = false;
             unProxyEventModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidUnProxyEvent = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidUnProxyEvent"));
			if (dec)
                 {
                     guidUnProxyEvent = new Guid(id);
                 }
                 else
                 {
                     guidUnProxyEvent = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new unProxyEventModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.unProxyEventsBR.Instance.GetByKey(guidUnProxyEvent, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<unProxyEventModel> GetContextModel(UIModelContextTypes formMode, unProxyEventModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<unProxyEventModel> GetContextModel(UIModelContextTypes formMode, unProxyEventModel model, bool decript, Guid ? id) {
            UIModel<unProxyEventModel> me = new UIModel<unProxyEventModel>(true, "unProxyEvents");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "unProxyEvent";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "unProxyEvent";
            me.EntitySetName = "unProxyEvents";

			me.AreaAction = "KSTime";
            me.ControllerAction = "unProxyEvents";
            me.PropertyKeyName = "GuidUnProxyEvent";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = unProxyEventResources.UNPROXYEVENTS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Title") != null){
						me.Properties.Find(p => p.PropertyName == "Title").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidUnProxyEvent") != null){
						me.Properties.Find(p => p.PropertyName == "GuidUnProxyEvent").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
namespace KS.Time.Api.Controllers
{
	using KS.Time.Api.Models.unProxySettings;

	[Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public partial class unProxySettingsController : KS.Time.Api.ControllerBase<Models.unProxySettings.unProxySettingModel>
    {
	/* [HttpGet()]
	 [Route("[action]")]
        public IActionResult Puff(string abc)
        {
            return Ok("Hola desde areaaaaa! " + abc );
        }*/

       


	#region partial methods
        ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel>> e);
    	partial void OnUISettings(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.unProxySettings.unProxySettingModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.unProxySettings.unProxySettingModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.unProxySettings.unProxySettingModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.unProxySettings.unProxySettingModel>> e);
      	partial void OnAuthorization(object sender, object context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.unProxySettings.unProxySettingModel>> e);

		 [ApiExplorerSettings(IgnoreApi = true)]
		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<unProxySettingModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected  override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<unProxySettingModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<unProxySettingModel>> e)
        {
            OnDownloading(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualShowing(object sender, MyEventArgs<UIModel<unProxySettingModel>> e)
        {
            OnShowing(sender, e);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
		 protected override void OnVirtualUISettings(object sender, MyEventArgs<UIModel<unProxySettingModel>> e)
        {
            OnUISettings(sender, e);
        }

	#endregion
	#region API
	 partial void OnAuthorization(AuthorizationEventArgs e);
	  [ApiExplorerSettings(IgnoreApi = true)]
	  protected override bool? OnAuthorizationBase(AuthorizationEventArgs e)
        {
			 
			 this.OnAuthorization(e);
			 return e.ValidResult;
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
	 protected override ActionResult ApiCreateGen(ApiWrapperCreate<unProxySettingModel> data, ContextRequest contextRequest)
        {
            var result = BR.unProxySettingsBR.Instance.Create(data.Item.GetBusinessObject(), contextRequest);
 
           if ( data.ReturnType != null)
            {
                unProxySettingModel model = new unProxySettingModel(result);
                if (data.ReturnType == "key")
                {

                    return ResolveApiResponse("success", null, null, model.Id);
                }else
                {
                    return ResolveApiResponse("success", null, null, model);
                }

            }
            else
            {
                return ResolveApiResponse("success", null, null, null );
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiCreateBulkGen(ApiWrapperCreate<unProxySettingModel> data, ContextRequest contextRequest)
        {
            List<unProxySetting> items = new  List<unProxySetting>();

            foreach (var item in data.Items)
            {
                items.Add(item.GetBusinessObject());
            }
            BR.unProxySettingsBR.Instance.CreateBulk(items, contextRequest);
            return ResolveApiResponse("success", null, null, null);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
              protected override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
	   // [MyAuthorize("r", "unProxySetting", "KSTime", typeof(unProxySettingsController))]
		protected ActionResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }

			 
			 if (this.IsRESTRequest == false)
            {
                return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
            }else
            {
                try
                {
                    return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);

                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", reason = "exception", message = ex.ToString() });

                }
            }
        }
       [ApiExplorerSettings(IgnoreApi = true)]
		 protected override ActionResult ApiGetByCount(string filter, ContextRequest contextRequest)
        {
              var result  =  BR.unProxySettingsBR.Instance.GetCount(filter,  contextRequest);

            return ResolveApiResponse("success", null, null, result);
        }

		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            var result = GetByKey(id, contextRequest, true);
			  UIModel<unProxySettingModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = new List<unProxySettingModel>();
            uiModel.Items.Add(result);


            Showing(ref uiModel);

            return ResolveApiResponse("success", null, null, uiModel.Items[0]);
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
         protected override ActionResult ApiDeleteGen(List<unProxySettingModel> models, ContextRequest contextRequest)
        {
            List<unProxySetting> objs = new List<unProxySetting>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.unProxySettingsBR.Instance.Delete(objs, contextRequest);
                if (this.IsRESTRequest == true)
                {
                    
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
            }
            catch (Exception ex)
            {
               if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }
		 [ApiExplorerSettings(IgnoreApi = true)]
        protected override ActionResult ApiUpdateGen(List<unProxySettingModel> models, ContextRequest contextRequest)
        {
            List<unProxySetting> objs = new List<unProxySetting>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
			if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {
                    foreach (var obj in objs)
                    {

                        BR.unProxySettingsBR.Instance.UpdateAgile(obj, contextRequest);

                    }
                }
                else
                {
					foreach (var obj in objs)
					{
						BR.unProxySettingsBR.Instance.Update(obj, contextRequest);

					}
				}
				if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("success", null, null, null);

                }
                else
                {
                    return Content("ok");

                }
              
            }
            catch (Exception ex)
            {
                if (this.IsRESTRequest == true)
                {
                    //return Json(new { status = "error", reason = "error", message= ex.ToString() }, JsonRequestBehavior.AllowGet);
					return ResolveApiResponse("error", "exception", ex.ToString(), null );

                }
                else
                {
                    return Json(ex.ToString());

                }
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(unProxySettingModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		[ApiExplorerSettings(IgnoreApi = true)]
 		public object Authorization(object context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		public List<unProxySettingModel> GetAll() {
            			var bos = BR.unProxySettingsBR.Instance.GetBy("",
					new SFS.Core.My.ContextRequest()
					{
						CustomQuery = new SFS.Core.My.CustomQuery()
						{
							OrderBy = "SMTPServer",
							SortDirection = SFS.Core.Data.SortDirection.Ascending
						}
					});
            			List<unProxySettingModel> results = new List<unProxySettingModel>();
            unProxySettingModel model = null;
            foreach (var bo in bos)
            {
                model = new unProxySettingModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
      

		List<PropertyDefinition> _properties = null;
		[ApiExplorerSettings(IgnoreApi = true)]
		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idunProxySetting = GetRouteDataOrQueryParam("id");
			if (idunProxySetting != null)
			{
				if (!decripted)
                {
					idunProxySetting = SFS.Core.Entities.Utils.GetPropertyKey(idunProxySetting.Replace("-","/"), "GuidUnProxySetting");
				}else{
					if (id != null )
						idunProxySetting = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidUnProxySetting"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidUnProxySetting")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidUnProxySetting",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidUnProxySetting",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.GUIDUNPROXYSETTING*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPServer"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPServer")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPServer",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "SMTPServer",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPSERVER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPSSLEnabled"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPSSLEnabled")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPSSLEnabled",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPSSLEnabled",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPSSLENABLED*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPUser"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPUser")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPUser",

					 MaxLength = 100,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPUser",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPUSER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPPassword"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPPassword")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPPassword",

					 MaxLength = 100,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPPassword",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPPASSWORD*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPFromName"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPFromName")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPFromName",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPFromName",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPFROMNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPPort"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPPort")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPPort",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPPort",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPPORT*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SMTPFromEmail"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ContextParam", Value=@"Company" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SMTPFromEmail")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 107,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPFromEmail",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SMTPFromEmail",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SMTPFROMEMAIL*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("AzureBlobStorageConnection"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ParamId", Value=@"AzureStorageConnectionString" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "AzureBlobStorageConnection")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "AzureBlobStorageConnection",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "AzureBlobStorageConnection",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.AZUREBLOBSTORAGECONNECTION*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SaveBlobInAzureStorage"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ParamId", Value=@"save-files-blob" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SaveBlobInAzureStorage")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "SaveBlobInAzureStorage",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SaveBlobInAzureStorage",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SAVEBLOBINAZURESTORAGE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("SaveBlobInDataBase"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ParamId", Value=@"save-files-db" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "SaveBlobInDataBase")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "SaveBlobInDataBase",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "SaveBlobInDataBase",
					
	
                    TypeName = "Boolean",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.SAVEBLOBINDATABASE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UserNameGeoNames"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ParamId", Value=@"username-geonames" });
		 
    customProperties.Add(new CustomProperty() { Name="AppNameKey", Value=@"SFSCoreSecurity" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "UserNameGeoNames")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 111,
																	
					CustomProperties = customProperties,

                    PropertyName = "UserNameGeoNames",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UserNameGeoNames",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.USERNAMEGEONAMES*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("EngineURL"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "EngineURL")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 112,
																	
					CustomProperties = customProperties,

                    PropertyName = "EngineURL",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "EngineURL",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINEURL*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_API_KEY"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_API_KEY")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 113,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_API_KEY",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_API_KEY",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_API_KEY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_URL"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_URL")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 114,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_URL",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_URL",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_URL*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_USER"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_USER")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 115,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_USER",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_USER",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_USER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_PWD"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_PWD")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 116,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_PWD",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_PWD",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_PWD*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("KM_MAXIMO"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    customProperties.Add(new CustomProperty() { Name="ParamId", Value=@"km-maximo" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "KM_MAXIMO")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 117,
																	
					CustomProperties = customProperties,

                    PropertyName = "KM_MAXIMO",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "KM_MAXIMO",
					
	
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.KM_MAXIMO*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAP_KEY"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAP_KEY")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 118,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAP_KEY",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAP_KEY",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAP_KEY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_OAUTH_CLIENT_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_OAUTH_CLIENT_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 119,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_CLIENT_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_CLIENT_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_OAUTH_CLIENT_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_OAUTH_LOGIN_URL"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_OAUTH_LOGIN_URL")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 120,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_LOGIN_URL",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_LOGIN_URL",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_OAUTH_LOGIN_URL*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_OAUTH_USERNAME"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_OAUTH_USERNAME")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 121,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_USERNAME",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_USERNAME",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_OAUTH_USERNAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_OAUTH_PASSWORD"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_OAUTH_PASSWORD")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 122,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_PASSWORD",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_PASSWORD",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_OAUTH_PASSWORD*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_OAUTH_CLIENT_SECRET"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_OAUTH_CLIENT_SECRET")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 123,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_CLIENT_SECRET",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_CLIENT_SECRET",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_OAUTH_CLIENT_SECRET*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("ENGINE_DEFINITION_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "ENGINE_DEFINITION_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 124,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_DEFINITION_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "ENGINE_DEFINITION_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.ENGINE_DEFINITION_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_DATOS_CLIENTE_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_DATOS_CLIENTE_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 125,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DATOS_CLIENTE_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DATOS_CLIENTE_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_DATOS_CLIENTE_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_DOCUMENTOS_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_DOCUMENTOS_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 126,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DOCUMENTOS_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DOCUMENTOS_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_DOCUMENTOS_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_DIRECCION_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_DIRECCION_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 127,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DIRECCION_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DIRECCION_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_DIRECCION_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_DATOS_FINANCIEROS_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_DATOS_FINANCIEROS_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 128,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DATOS_FINANCIEROS_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DATOS_FINANCIEROS_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_DATOS_FINANCIEROS_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 129,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_BENEFICIARIOS_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_BENEFICIARIOS_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 130,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_BENEFICIARIOS_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_BENEFICIARIOS_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_BENEFICIARIOS_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_CONTRATOS_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_CONTRATOS_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 131,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_CONTRATOS_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_CONTRATOS_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_CONTRATOS_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CONTAINER_APROBACION_ID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "CONTAINER_APROBACION_ID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 132,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_APROBACION_ID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_APROBACION_ID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.CONTAINER_APROBACION_ID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_CONTRATO_TEMPLATEID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_CONTRATO_TEMPLATEID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 133,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_CONTRATO_TEMPLATEID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_CONTRATO_TEMPLATEID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_CONTRATO_TEMPLATEID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_CARATULA_TEMPLATEID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_CARATULA_TEMPLATEID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 134,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_CARATULA_TEMPLATEID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_CARATULA_TEMPLATEID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_CARATULA_TEMPLATEID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_PAGARE_TEMPLATEID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_PAGARE_TEMPLATEID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 135,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_PAGARE_TEMPLATEID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_PAGARE_TEMPLATEID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_PAGARE_TEMPLATEID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MAMBU_REFERENCIASPAGO_TEMPLATEID"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MAMBU_REFERENCIASPAGO_TEMPLATEID")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 136,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_REFERENCIASPAGO_TEMPLATEID",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MAMBU_REFERENCIASPAGO_TEMPLATEID",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MAMBU_REFERENCIASPAGO_TEMPLATEID*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("MATI_AUTH_HEADER"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "MATI_AUTH_HEADER")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 137,
																	
					CustomProperties = customProperties,

                    PropertyName = "MATI_AUTH_HEADER",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "MATI_AUTH_HEADER",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.MATI_AUTH_HEADER*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("WEBBHOOK_MATI_KEY"))
{				
    customProperties = new List<CustomProperty>();

        customProperties.Add(new CustomProperty() { Name="IsParam", Value=@"true" });
		 
    
	
	//Null
		//if (this.Request.QueryString["fk"] != "WEBBHOOK_MATI_KEY")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 138,
																	
					CustomProperties = customProperties,

                    PropertyName = "WEBBHOOK_MATI_KEY",

					 MaxLength = 500,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "WEBBHOOK_MATI_KEY",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "KSTime/"
                    /*,PropertyDisplayName = Resources.unProxySettingResources.WEBBHOOK_MATI_KEY*/
                });
		//	}
	
	}
	
				

if (visibleProperty || specificProperties.Contains("GuidActividadEconomica"))
{				
    customProperties = new List<CustomProperty>();

        

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPServer",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPServer",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPSSLEnabled",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPSSLEnabled",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPUser",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPUser",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPPassword",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPPassword",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPFromName",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPFromName",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPPort",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPPort",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SMTPFromEmail",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SMTPFromEmail",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "AzureBlobStorageConnection",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "AzureBlobStorageConnection",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SaveBlobInAzureStorage",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SaveBlobInAzureStorage",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "SaveBlobInDataBase",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "SaveBlobInDataBase",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "UserNameGeoNames",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "UserNameGeoNames",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "EngineURL",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "EngineURL",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_API_KEY",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_API_KEY",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_URL",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_URL",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_USER",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_USER",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_PWD",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_PWD",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "KM_MAXIMO",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "KM_MAXIMO",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAP_KEY",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAP_KEY",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_CLIENT_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_CLIENT_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_LOGIN_URL",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_LOGIN_URL",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_USERNAME",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_USERNAME",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_PASSWORD",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_PASSWORD",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_OAUTH_CLIENT_SECRET",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_OAUTH_CLIENT_SECRET",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "ENGINE_DEFINITION_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "ENGINE_DEFINITION_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DATOS_CLIENTE_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DATOS_CLIENTE_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DOCUMENTOS_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DOCUMENTOS_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DIRECCION_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DIRECCION_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_DATOS_FINANCIEROS_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_DATOS_FINANCIEROS_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_BENEFICIARIOS_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_BENEFICIARIOS_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_CONTRATOS_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_CONTRATOS_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "CONTAINER_APROBACION_ID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "CONTAINER_APROBACION_ID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_CONTRATO_TEMPLATEID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_CONTRATO_TEMPLATEID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_CARATULA_TEMPLATEID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_CARATULA_TEMPLATEID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_PAGARE_TEMPLATEID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_PAGARE_TEMPLATEID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MAMBU_REFERENCIASPAGO_TEMPLATEID",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MAMBU_REFERENCIASPAGO_TEMPLATEID",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "MATI_AUTH_HEADER",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "MATI_AUTH_HEADER",
					
	
                    TypeName = "Guid",
                   
                });
	
	

				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "WEBBHOOK_MATI_KEY",

					 MaxLength = 0,
					IsRequired = false ,
					IsHidden = false,
                    
					IsDefaultProperty = false,
                    SortBy = "WEBBHOOK_MATI_KEY",
					
	
                    TypeName = "Guid",
                   
                });
	
	
	}
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }
			[ApiExplorerSettings(IgnoreApi = true)]
		private void Showing(ref UIModel<unProxySettingModel> uiModel) {
          	
			MyEventArgs<UIModel<unProxySettingModel>> me = new MyEventArgs<UIModel<unProxySettingModel>>() { UIModel = uiModel };
			 OnVirtualLayoutSettings(this, me);

            OnShowing(this, me);

			
			if (this.ContextRequest != null && this.ContextRequest.ApiWrapper != null && this.ContextRequest.ApiWrapper.AllFields == true )
			{
				me.UIModel.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.UIModel;
            }

        }
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override  UIModel<unProxySettingModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.Query["q"].ToString()))
					filter = filter + HttpUtility.UrlDecode(Request.Query["q"].ToString());
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFS.Core.My.Context.CurrentContext;
            }
            var bos = BR.unProxySettingsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.unProxySettingsBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            unProxySettingModel model = null;
            List<unProxySettingModel> results = new List<unProxySettingModel>();
            foreach (var item in bos)
            {
                model = new unProxySettingModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<unProxySettingModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			/*if (Request != null){
				if (SFS.Core.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}*/
            Showing(ref uiModel);
            return uiModel;
		}			
	
		
		[ApiExplorerSettings(IgnoreApi = true)]
		protected override List<unProxySettingModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		
      



		[ApiExplorerSettings(IgnoreApi = true)]
		protected  unProxySettingModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxySettingModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }
		[ApiExplorerSettings(IgnoreApi = true)]
        protected unProxySettingModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             unProxySettingModel model = null;
            ControllerEventArgs<unProxySettingModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<unProxySettingModel>() { Id = objectKey  });
             bool cancel = false;
             unProxySettingModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidUnProxySetting = Guid.Empty; //new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, "GuidUnProxySetting"));
			if (dec)
                 {
                     guidUnProxySetting = new Guid(id);
                 }
                 else
                 {
                     guidUnProxySetting = new Guid(SFS.Core.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new unProxySettingModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.unProxySettingsBR.Instance.GetByKey(guidUnProxySetting, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
  

        

			[ApiExplorerSettings(IgnoreApi = true)]
		protected override UIModel<unProxySettingModel> GetContextModel(UIModelContextTypes formMode, unProxySettingModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			[ApiExplorerSettings(IgnoreApi = true)]
		 private UIModel<unProxySettingModel> GetContextModel(UIModelContextTypes formMode, unProxySettingModel model, bool decript, Guid ? id) {
            UIModel<unProxySettingModel> me = new UIModel<unProxySettingModel>(true, "unProxySettings");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "unProxySetting";
			
            me.ModuleKey = "KSTime";

			me.ModuleNamespace = "KS.Time";
            me.EntityKey = "unProxySetting";
            me.EntitySetName = "unProxySettings";

			me.AreaAction = "KSTime";
            me.ControllerAction = "unProxySettings";
            me.PropertyKeyName = "GuidUnProxySetting";

            me.Properties = GetProperties(me, decript, id);
 			
			 
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = unProxySettingResources.UNPROXYSETTINGS_DETAILS;
                   // me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
		//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "SMTPServer") != null){
						me.Properties.Find(p => p.PropertyName == "SMTPServer").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidUnProxySetting") != null){
						me.Properties.Find(p => p.PropertyName == "GuidUnProxySetting").IsHidden = false;
					 }
					 
                    
					

				

                    break;
                case UIModelContextTypes.ListForm:
	

                    break;
                default:
                    break;
            }
            	this.SetDefaultProperties(me);
			
			
			return me;
        }
		

		

		


	
    }
}
