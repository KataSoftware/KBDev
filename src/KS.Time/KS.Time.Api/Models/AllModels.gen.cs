using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using KS.Time.Web.Mvc.Resources;
using System.Runtime.Serialization;
//using SFS.Core.Web.Mvc.Models;
//using SFS.Core.Web.Mvc.Extensions;
using BO = KS.Time.BusinessObjects;
//using System.Web.Mvc;
using SFS.Core.Api.Models;
//using SFS.Core.Web.Mvc.Resources;
using SFS.Core.Common.Entities.Metadata;
using System.Text;
using Newtonsoft.Json;
using KS.Time.BusinessObjects;
	namespace KS.Time.Api.Models.KstEmailTemplates 
	{
	public partial class KstEmailTemplateModel: ModelBase{

	  public KstEmailTemplateModel(BO.KstEmailTemplate resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstEmailTemplateModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidEmailTemplate.ToString();
            }

			 set
            {
                this.GuidEmailTemplate = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Title != null)
		
            return this.Title.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidEmailTemplate{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("TITLE"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public String   Title { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("TITLEKEY"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public String   TitleKey { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DataType("RichEditorAdvanced")]
	//[LocalizedDisplayName("CONTENT"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public String   Content { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstEmailTemplateResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
		

	
	
		public void Bind(KstEmailTemplateModel model){
            
		this.GuidEmailTemplate = model.GuidEmailTemplate;
		this.Title = model.Title;
		this.TitleKey = model.TitleKey;
		this.Content = model.Content;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstEmailTemplate GetBusinessObject()
        {
            BusinessObjects.KstEmailTemplate result = new BusinessObjects.KstEmailTemplate();


			       
	if (this.GuidEmailTemplate != null )
				result.GuidEmailTemplate = (Guid)this.GuidEmailTemplate;
				
	if (this.Title != null )
				result.Title = (String)this.Title.Trim().Replace("\t", String.Empty);
				
	if (this.TitleKey != null )
				result.TitleKey = (String)this.TitleKey.Trim().Replace("\t", String.Empty);
				
	if (this.Content != null )
				result.Content = (String)this.Content.Trim().Replace("\t", String.Empty);
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				

            return result;
        }
        public void Bind(BusinessObjects.KstEmailTemplate businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidEmailTemplate = businessObject.GuidEmailTemplate;
				
			this.Title = businessObject.Title != null ? businessObject.Title.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.TitleKey != null )
				this.TitleKey = (String)businessObject.TitleKey;
				
	if (businessObject.Content != null )
				this.Content = (String)businessObject.Content;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProxyGeoCities 
	{
	public partial class KstProxyGeoCityModel: ModelBase{

	  public KstProxyGeoCityModel(BO.KstProxyGeoCity resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProxyGeoCityModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidCity.ToString();
            }

			 set
            {
                this.GuidCity = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidCity{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDSTATE"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public Guid  ? GuidState { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDPARENT"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public Guid  ? GuidParent { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyGeoCitiesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidCity", FiltrablePropertyPathName="KstProxyGeoCity2.GuidCity")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYGEOCITY2"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public Guid  ? FkKstProxyGeoCity2 { get; set; }
		//[LocalizedDisplayName("KSTPROXYGEOCITY2"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	//[Exportable()]
	public string  FkKstProxyGeoCity2Text { get; set; }
   // public string FkKstProxyGeoCity2SafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyGeoStatesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidState", FiltrablePropertyPathName="KstProxyGeoState.GuidState")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYGEOSTATE"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	public Guid  ? FkKstProxyGeoState { get; set; }
		//[LocalizedDisplayName("KSTPROXYGEOSTATE"/*, NameResourceType=typeof(KstProxyGeoCityResources)*/)]
	//[Exportable()]
	public string  FkKstProxyGeoStateText { get; set; }
   // public string FkKstProxyGeoStateSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstProxyGeoCityModel model){
            
		this.GuidCity = model.GuidCity;
		this.Name = model.Name;
		this.IsDeleted = model.IsDeleted;
		this.GuidState = model.GuidState;
		this.GuidParent = model.GuidParent;
        }

        public BusinessObjects.KstProxyGeoCity GetBusinessObject()
        {
            BusinessObjects.KstProxyGeoCity result = new BusinessObjects.KstProxyGeoCity();


			       
	if (this.GuidCity != null )
				result.GuidCity = (Guid)this.GuidCity;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.GuidState != null )
				result.GuidState = (Guid)this.GuidState;
				
	if (this.GuidParent != null )
				result.GuidParent = (Guid)this.GuidParent;
				
			
			if(this.FkKstProxyGeoCity2 != null || this.GuidParent != null){
			if (GuidParent != null) this.FkKstProxyGeoCity2 = GuidParent; 
			result.KstProxyGeoCity2 = new BusinessObjects.KstProxyGeoCity() { GuidCity= (Guid)this.FkKstProxyGeoCity2 };

			
			}
				
			
			if(this.FkKstProxyGeoState != null || this.GuidState != null){
			if (GuidState != null) this.FkKstProxyGeoState = GuidState; 
			result.KstProxyGeoState = new BusinessObjects.KstProxyGeoState() { GuidState= (Guid)this.FkKstProxyGeoState };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstProxyGeoCity businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidCity = businessObject.GuidCity;
				
			this.Name = businessObject.Name != null ? businessObject.Name.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.GuidState != null )
				this.GuidState = (Guid)businessObject.GuidState;
				
	if (businessObject.GuidParent != null )
				this.GuidParent = (Guid)businessObject.GuidParent;
	        if (businessObject.KstProxyGeoCity2 != null){
	                	this.FkKstProxyGeoCity2Text = businessObject.KstProxyGeoCity2.Name != null ? businessObject.KstProxyGeoCity2.Name.ToString() : "";; 
										
										
				this.FkKstProxyGeoCity2 = businessObject.KstProxyGeoCity2.GuidCity;
                //this.FkKstProxyGeoCity2SafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyGeoCity2,"GuidCity").Replace("/","-");

			}
	        if (businessObject.KstProxyGeoState != null){
	                	this.FkKstProxyGeoStateText = businessObject.KstProxyGeoState.Name != null ? businessObject.KstProxyGeoState.Name.ToString() : "";; 
										
										
				this.FkKstProxyGeoState = businessObject.KstProxyGeoState.GuidState;
                //this.FkKstProxyGeoStateSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyGeoState,"GuidState").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProxyGeoCountries 
	{
	public partial class KstProxyGeoCountryModel: ModelBase{

	  public KstProxyGeoCountryModel(BO.KstProxyGeoCountry resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProxyGeoCountryModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidCountry.ToString();
            }

			 set
            {
                this.GuidCountry = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidCountry{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(KstProxyGeoCountryResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProxyGeoCountryResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
		

	
	
		public void Bind(KstProxyGeoCountryModel model){
            
		this.GuidCountry = model.GuidCountry;
		this.Name = model.Name;
		this.IsDeleted = model.IsDeleted;
        }

        public BusinessObjects.KstProxyGeoCountry GetBusinessObject()
        {
            BusinessObjects.KstProxyGeoCountry result = new BusinessObjects.KstProxyGeoCountry();


			       
	if (this.GuidCountry != null )
				result.GuidCountry = (Guid)this.GuidCountry;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				

            return result;
        }
        public void Bind(BusinessObjects.KstProxyGeoCountry businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidCountry = businessObject.GuidCountry;
				
			this.Name = businessObject.Name != null ? businessObject.Name.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProxyGeoStates 
	{
	public partial class KstProxyGeoStateModel: ModelBase{

	  public KstProxyGeoStateModel(BO.KstProxyGeoState resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProxyGeoStateModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidState.ToString();
            }

			 set
            {
                this.GuidState = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidState{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(KstProxyGeoStateResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProxyGeoStateResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDCOUNTRY"/*, NameResourceType=typeof(KstProxyGeoStateResources)*/)]
	public Guid  ? GuidCountry { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyGeoCountriesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidCountry", FiltrablePropertyPathName="KstProxyGeoCountry.GuidCountry")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYGEOCOUNTRY"/*, NameResourceType=typeof(KstProxyGeoStateResources)*/)]
	public Guid  ? FkKstProxyGeoCountry { get; set; }
		//[LocalizedDisplayName("KSTPROXYGEOCOUNTRY"/*, NameResourceType=typeof(KstProxyGeoStateResources)*/)]
	//[Exportable()]
	public string  FkKstProxyGeoCountryText { get; set; }
   // public string FkKstProxyGeoCountrySafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstProxyGeoStateModel model){
            
		this.GuidState = model.GuidState;
		this.Name = model.Name;
		this.IsDeleted = model.IsDeleted;
		this.GuidCountry = model.GuidCountry;
        }

        public BusinessObjects.KstProxyGeoState GetBusinessObject()
        {
            BusinessObjects.KstProxyGeoState result = new BusinessObjects.KstProxyGeoState();


			       
	if (this.GuidState != null )
				result.GuidState = (Guid)this.GuidState;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.GuidCountry != null )
				result.GuidCountry = (Guid)this.GuidCountry;
				
			
			if(this.FkKstProxyGeoCountry != null || this.GuidCountry != null){
			if (GuidCountry != null) this.FkKstProxyGeoCountry = GuidCountry; 
			result.KstProxyGeoCountry = new BusinessObjects.KstProxyGeoCountry() { GuidCountry= (Guid)this.FkKstProxyGeoCountry };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstProxyGeoState businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidState = businessObject.GuidState;
				
			this.Name = businessObject.Name != null ? businessObject.Name.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.GuidCountry != null )
				this.GuidCountry = (Guid)businessObject.GuidCountry;
	        if (businessObject.KstProxyGeoCountry != null){
	                	this.FkKstProxyGeoCountryText = businessObject.KstProxyGeoCountry.Name != null ? businessObject.KstProxyGeoCountry.Name.ToString() : "";; 
										
										
				this.FkKstProxyGeoCountry = businessObject.KstProxyGeoCountry.GuidCountry;
                //this.FkKstProxyGeoCountrySafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyGeoCountry,"GuidCountry").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstActivities 
	{
	public partial class KstActivityModel: ModelBase{

	  public KstActivityModel(BO.KstActivity resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstActivityModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidActivity.ToString();
            }

			 set
            {
                this.GuidActivity = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidActivity{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDPROJECT"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Guid  ? GuidProject { get; set; }
		
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ISCUSTOMBYUSER"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Boolean   IsCustomByUser { get; set; }
	public string _IsCustomByUserText = null;
    public string IsCustomByUserText {
        get {
			if (string.IsNullOrEmpty( _IsCustomByUserText ))
				{
			//Aplicar formato si esta especificado
				return IsCustomByUser.ToString();
	
			}else{
				return _IsCustomByUserText ;
			}			
        }
		set{
			_IsCustomByUserText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProjectsController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidProject", FiltrablePropertyPathName="KstProject.GuidProject")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstActivityResources)*/)]
	public Guid  ? FkKstProject { get; set; }
		//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstActivityResources)*/)]
	//[Exportable()]
	public string  FkKstProjectText { get; set; }
   // public string FkKstProjectSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstActivityModel model){
            
		this.GuidActivity = model.GuidActivity;
		this.Name = model.Name;
		this.GuidProject = model.GuidProject;
		this.IsCustomByUser = model.IsCustomByUser;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstActivity GetBusinessObject()
        {
            BusinessObjects.KstActivity result = new BusinessObjects.KstActivity();


			       
	if (this.GuidActivity != null )
				result.GuidActivity = (Guid)this.GuidActivity;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.GuidProject != null )
				result.GuidProject = (Guid)this.GuidProject;
				
	if (this.IsCustomByUser != null )
				result.IsCustomByUser = (Boolean)this.IsCustomByUser;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstProject != null || this.GuidProject != null){
			if (GuidProject != null) this.FkKstProject = GuidProject; 
			result.KstProject = new BusinessObjects.KstProject() { GuidProject= (Guid)this.FkKstProject };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstActivity businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidActivity = businessObject.GuidActivity;
				
				
	if (businessObject.Name != null )
				this.Name = (String)businessObject.Name;
				
	if (businessObject.GuidProject != null )
				this.GuidProject = (Guid)businessObject.GuidProject;
			this.IsCustomByUser = businessObject.IsCustomByUser;
				
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstProject != null){
	                	this.FkKstProjectText = businessObject.KstProject.Name != null ? businessObject.KstProject.Name.ToString() : "";; 
										
										
				this.FkKstProject = businessObject.KstProject.GuidProject;
                //this.FkKstProjectSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProject,"GuidProject").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProjects 
	{
	public partial class KstProjectModel: ModelBase{

	  public KstProjectModel(BO.KstProject resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProjectModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidProject.ToString();
            }

			 set
            {
                this.GuidProject = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidProject{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DisableFilterableInSubfilter=true)]

	//[DataType("Integer")]
	//[LocalizedDisplayName("NUMACTIVITIES"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Int32  ? NumActivities { get; set; }
	public string _NumActivitiesText = null;
    public string NumActivitiesText {
        get {
			if (string.IsNullOrEmpty( _NumActivitiesText ))
				{
	
            if (NumActivities != null)
				return NumActivities.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _NumActivitiesText ;
			}			
        }
		set{
			_NumActivitiesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DisableFilterableInSubfilter=true)]

	//[DataType("Integer")]
	//[LocalizedDisplayName("NUMUSERS"/*, NameResourceType=typeof(KstProjectResources)*/)]
	public Int32  ? NumUsers { get; set; }
	public string _NumUsersText = null;
    public string NumUsersText {
        get {
			if (string.IsNullOrEmpty( _NumUsersText ))
				{
	
            if (NumUsers != null)
				return NumUsers.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _NumUsersText ;
			}			
        }
		set{
			_NumUsersText = value;
		}
        
    }

		
		
		

	
	
		public void Bind(KstProjectModel model){
            
		this.GuidProject = model.GuidProject;
		this.Name = model.Name;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
		this.NumActivities = model.NumActivities;
		this.NumUsers = model.NumUsers;
        }

        public BusinessObjects.KstProject GetBusinessObject()
        {
            BusinessObjects.KstProject result = new BusinessObjects.KstProject();


			       
	if (this.GuidProject != null )
				result.GuidProject = (Guid)this.GuidProject;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
	if (this.NumActivities != null )
				result.NumActivities = (Int32)this.NumActivities;
				
	if (this.NumUsers != null )
				result.NumUsers = (Int32)this.NumUsers;
				

            return result;
        }
        public void Bind(BusinessObjects.KstProject businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidProject = businessObject.GuidProject;
				
			this.Name = businessObject.Name != null ? businessObject.Name.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
				
	if (businessObject.NumActivities != null )
				this.NumActivities = (Int32)businessObject.NumActivities;
				
	if (businessObject.NumUsers != null )
				this.NumUsers = (Int32)businessObject.NumUsers;
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProjectUsers 
	{
	public partial class KstProjectUserModel: ModelBase{

	  public KstProjectUserModel(BO.KstProjectUser resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProjectUserModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidProjectUser.ToString();
            }

			 set
            {
                this.GuidProjectUser = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.BizKeyEngine != null)
		
            return this.BizKeyEngine.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidProjectUser{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDPROJECT"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? GuidProject { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDUSER"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? GuidUser { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("STARTDATE"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public DateTime  ? StartDate { get; set; }
	public string StartDateText {
        get {
            if (StartDate != null)
				return ((DateTime)StartDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.StartDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("ENDDATE"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public DateTime  ? EndDate { get; set; }
	public string EndDateText {
        get {
            if (EndDate != null)
				return ((DateTime)EndDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.EndDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProjectsController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidProject", FiltrablePropertyPathName="KstProject.GuidProject")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? FkKstProject { get; set; }
		//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	//[Exportable()]
	public string  FkKstProjectText { get; set; }
   // public string FkKstProjectSafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyUsersController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "DisplayName", DataPropertyValue = "GuidUser", FiltrablePropertyPathName="KstProxyUser.GuidUser")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYUSER"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	public Guid  ? FkKstProxyUser { get; set; }
		//[LocalizedDisplayName("KSTPROXYUSER"/*, NameResourceType=typeof(KstProjectUserResources)*/)]
	//[Exportable()]
	public string  FkKstProxyUserText { get; set; }
   // public string FkKstProxyUserSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstProjectUserModel model){
            
		this.GuidProjectUser = model.GuidProjectUser;
		this.GuidProject = model.GuidProject;
		this.GuidUser = model.GuidUser;
		this.StartDate = model.StartDate;
		this.EndDate = model.EndDate;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstProjectUser GetBusinessObject()
        {
            BusinessObjects.KstProjectUser result = new BusinessObjects.KstProjectUser();


			       
	if (this.GuidProjectUser != null )
				result.GuidProjectUser = (Guid)this.GuidProjectUser;
				
	if (this.GuidProject != null )
				result.GuidProject = (Guid)this.GuidProject;
				
	if (this.GuidUser != null )
				result.GuidUser = (Guid)this.GuidUser;
				
				if(this.StartDate != null)
					if (this.StartDate != null)
				result.StartDate = (DateTime)this.StartDate;		
				
				if(this.EndDate != null)
					if (this.EndDate != null)
				result.EndDate = (DateTime)this.EndDate;		
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstProject != null || this.GuidProject != null){
			if (GuidProject != null) this.FkKstProject = GuidProject; 
			result.KstProject = new BusinessObjects.KstProject() { GuidProject= (Guid)this.FkKstProject };

			
			}
				
			
			if(this.FkKstProxyUser != null || this.GuidUser != null){
			if (GuidUser != null) this.FkKstProxyUser = GuidUser; 
			result.KstProxyUser = new BusinessObjects.KstProxyUser() { GuidUser= (Guid)this.FkKstProxyUser };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstProjectUser businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidProjectUser = businessObject.GuidProjectUser;
				
				
	if (businessObject.GuidProject != null )
				this.GuidProject = (Guid)businessObject.GuidProject;
				
	if (businessObject.GuidUser != null )
				this.GuidUser = (Guid)businessObject.GuidUser;
				if (businessObject.StartDate != null )
				this.StartDate = (DateTime)businessObject.StartDate;
				if (businessObject.EndDate != null )
				this.EndDate = (DateTime)businessObject.EndDate;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstProject != null){
	                	this.FkKstProjectText = businessObject.KstProject.Name != null ? businessObject.KstProject.Name.ToString() : "";; 
										
										
				this.FkKstProject = businessObject.KstProject.GuidProject;
                //this.FkKstProjectSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProject,"GuidProject").Replace("/","-");

			}
	        if (businessObject.KstProxyUser != null){
	                	this.FkKstProxyUserText = businessObject.KstProxyUser.DisplayName != null ? businessObject.KstProxyUser.DisplayName.ToString() : "";; 
										
				this.FkKstProxyUser = businessObject.KstProxyUser.GuidUser;
                //this.FkKstProxyUserSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyUser,"GuidUser").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstWorkTimes 
	{
	public partial class KstWorkTimeModel: ModelBase{

	  public KstWorkTimeModel(BO.KstWorkTime resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstWorkTimeModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidWorkTime.ToString();
            }

			 set
            {
                this.GuidWorkTime = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Title != null)
		
            return this.Title.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidWorkTime{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("TITLE"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public String   Title { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("COMMENTS"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public String   Comments { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("HOURS"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Decimal  ? Hours { get; set; }
	public string _HoursText = null;
    public string HoursText {
        get {
			if (string.IsNullOrEmpty( _HoursText ))
				{
	
            if (Hours != null)
				return Hours.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _HoursText ;
			}			
        }
		set{
			_HoursText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDPROJECT"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? GuidProject { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDACTIVITY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? GuidActivity { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstActivitiesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidActivity", FiltrablePropertyPathName="KstActivity.GuidActivity")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTACTIVITY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? FkKstActivity { get; set; }
		//[LocalizedDisplayName("KSTACTIVITY"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	//[Exportable()]
	public string  FkKstActivityText { get; set; }
   // public string FkKstActivitySafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProjectsController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidProject", FiltrablePropertyPathName="KstProject.GuidProject")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	public Guid  ? FkKstProject { get; set; }
		//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstWorkTimeResources)*/)]
	//[Exportable()]
	public string  FkKstProjectText { get; set; }
   // public string FkKstProjectSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstWorkTimeModel model){
            
		this.GuidWorkTime = model.GuidWorkTime;
		this.Title = model.Title;
		this.Comments = model.Comments;
		this.Hours = model.Hours;
		this.GuidProject = model.GuidProject;
		this.GuidActivity = model.GuidActivity;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstWorkTime GetBusinessObject()
        {
            BusinessObjects.KstWorkTime result = new BusinessObjects.KstWorkTime();


			       
	if (this.GuidWorkTime != null )
				result.GuidWorkTime = (Guid)this.GuidWorkTime;
				
	if (this.Title != null )
				result.Title = (String)this.Title.Trim().Replace("\t", String.Empty);
				
	if (this.Comments != null )
				result.Comments = (String)this.Comments.Trim().Replace("\t", String.Empty);
				
	if (this.Hours != null )
				result.Hours = (Decimal)this.Hours;
				
	if (this.GuidProject != null )
				result.GuidProject = (Guid)this.GuidProject;
				
	if (this.GuidActivity != null )
				result.GuidActivity = (Guid)this.GuidActivity;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstActivity != null || this.GuidActivity != null){
			if (GuidActivity != null) this.FkKstActivity = GuidActivity; 
			result.KstActivity = new BusinessObjects.KstActivity() { GuidActivity= (Guid)this.FkKstActivity };

			
			}
				
			
			if(this.FkKstProject != null || this.GuidProject != null){
			if (GuidProject != null) this.FkKstProject = GuidProject; 
			result.KstProject = new BusinessObjects.KstProject() { GuidProject= (Guid)this.FkKstProject };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstWorkTime businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidWorkTime = businessObject.GuidWorkTime;
				
				
	if (businessObject.Title != null )
				this.Title = (String)businessObject.Title;
				
	if (businessObject.Comments != null )
				this.Comments = (String)businessObject.Comments;
				
	if (businessObject.Hours != null )
				this.Hours = (Decimal)businessObject.Hours;
				
	if (businessObject.GuidProject != null )
				this.GuidProject = (Guid)businessObject.GuidProject;
				
	if (businessObject.GuidActivity != null )
				this.GuidActivity = (Guid)businessObject.GuidActivity;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstActivity != null){
	                	this.FkKstActivityText = businessObject.KstActivity.Name != null ? businessObject.KstActivity.Name.ToString() : "";; 
										
				this.FkKstActivity = businessObject.KstActivity.GuidActivity;
                //this.FkKstActivitySafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstActivity,"GuidActivity").Replace("/","-");

			}
	        if (businessObject.KstProject != null){
	                	this.FkKstProjectText = businessObject.KstProject.Name != null ? businessObject.KstProject.Name.ToString() : "";; 
										
										
				this.FkKstProject = businessObject.KstProject.GuidProject;
                //this.FkKstProjectSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProject,"GuidProject").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstFiles 
	{
	public partial class KstFileModel: ModelBase{

	  public KstFileModel(BO.KstFile resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstFileModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidFile.ToString();
            }

			 set
            {
                this.GuidFile = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.FileName != null)
		
            return this.FileName.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidFile{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("FILENAME"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   FileName { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("FILETYPE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   FileType { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
 
	//[DataType("File")]
	//[LocalizedDisplayName("FILEDATA"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Byte[]   FileData { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("FILESTORAGE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   FileStorage { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINERSTORAGE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   ContainerStorage { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("FILETHUMBSIZES"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   FileThumbSizes { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DataType("Integer")]
	//[LocalizedDisplayName("FILESIZE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Int64  ? FileSize { get; set; }
	public string _FileSizeText = null;
    public string FileSizeText {
        get {
			if (string.IsNullOrEmpty( _FileSizeText ))
				{
	
            if (FileSize != null)
				return FileSize.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _FileSizeText ;
			}			
        }
		set{
			_FileSizeText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstFileResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstFileResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
		

	
	
		public void Bind(KstFileModel model){
            
		this.GuidFile = model.GuidFile;
		this.FileName = model.FileName;
		this.FileType = model.FileType;
		this.FileData = model.FileData;
		this.FileStorage = model.FileStorage;
		this.ContainerStorage = model.ContainerStorage;
		this.FileThumbSizes = model.FileThumbSizes;
		this.FileSize = model.FileSize;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstFile GetBusinessObject()
        {
            BusinessObjects.KstFile result = new BusinessObjects.KstFile();


			       
	if (this.GuidFile != null )
				result.GuidFile = (Guid)this.GuidFile;
				
	if (this.FileName != null )
				result.FileName = (String)this.FileName.Trim().Replace("\t", String.Empty);
				
	if (this.FileType != null )
				result.FileType = (String)this.FileType.Trim().Replace("\t", String.Empty);
				
				if(this.FileData != null)
					result.FileData = (Byte[])this.FileData;
			
				
	if (this.FileStorage != null )
				result.FileStorage = (String)this.FileStorage.Trim().Replace("\t", String.Empty);
				
	if (this.ContainerStorage != null )
				result.ContainerStorage = (String)this.ContainerStorage.Trim().Replace("\t", String.Empty);
				
	if (this.FileThumbSizes != null )
				result.FileThumbSizes = (String)this.FileThumbSizes.Trim().Replace("\t", String.Empty);
				
	if (this.FileSize != null )
				result.FileSize = (Int64)this.FileSize;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				

            return result;
        }
        public void Bind(BusinessObjects.KstFile businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidFile = businessObject.GuidFile;
				
			this.FileName = businessObject.FileName != null ? businessObject.FileName.Trim().Replace("\t", String.Empty) : "";
				
				
	if (businessObject.FileType != null )
				this.FileType = (String)businessObject.FileType;
			if (businessObject.FileData != null )
				this.FileData = businessObject.FileData;			
				
	if (businessObject.FileStorage != null )
				this.FileStorage = (String)businessObject.FileStorage;
				
	if (businessObject.ContainerStorage != null )
				this.ContainerStorage = (String)businessObject.ContainerStorage;
				
	if (businessObject.FileThumbSizes != null )
				this.FileThumbSizes = (String)businessObject.FileThumbSizes;
				
	if (businessObject.FileSize != null )
				this.FileSize = (Int64)businessObject.FileSize;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProjectFiles 
	{
	public partial class KstProjectFileModel: ModelBase{

	  public KstProjectFileModel(BO.KstProjectFile resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProjectFileModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidProjectFile.ToString();
            }

			 set
            {
                this.GuidProjectFile = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.BizKeyEngine != null)
		
            return this.BizKeyEngine.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidProjectFile{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDPROJECT"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? GuidProject { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDFILE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? GuidFile { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstFilesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "FileName", DataPropertyValue = "GuidFile", FiltrablePropertyPathName="KstFile.GuidFile")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? FkKstFile { get; set; }
		//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	//[Exportable()]
	public string  FkKstFileText { get; set; }
   // public string FkKstFileSafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProjectsController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Name", DataPropertyValue = "GuidProject", FiltrablePropertyPathName="KstProject.GuidProject")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	public Guid  ? FkKstProject { get; set; }
		//[LocalizedDisplayName("KSTPROJECT"/*, NameResourceType=typeof(KstProjectFileResources)*/)]
	//[Exportable()]
	public string  FkKstProjectText { get; set; }
   // public string FkKstProjectSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstProjectFileModel model){
            
		this.GuidProjectFile = model.GuidProjectFile;
		this.GuidProject = model.GuidProject;
		this.GuidFile = model.GuidFile;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstProjectFile GetBusinessObject()
        {
            BusinessObjects.KstProjectFile result = new BusinessObjects.KstProjectFile();


			       
	if (this.GuidProjectFile != null )
				result.GuidProjectFile = (Guid)this.GuidProjectFile;
				
	if (this.GuidProject != null )
				result.GuidProject = (Guid)this.GuidProject;
				
	if (this.GuidFile != null )
				result.GuidFile = (Guid)this.GuidFile;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstFile != null || this.GuidFile != null){
			if (GuidFile != null) this.FkKstFile = GuidFile; 
			result.KstFile = new BusinessObjects.KstFile() { GuidFile= (Guid)this.FkKstFile };

			
			}
				
			
			if(this.FkKstProject != null || this.GuidProject != null){
			if (GuidProject != null) this.FkKstProject = GuidProject; 
			result.KstProject = new BusinessObjects.KstProject() { GuidProject= (Guid)this.FkKstProject };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstProjectFile businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidProjectFile = businessObject.GuidProjectFile;
				
				
	if (businessObject.GuidProject != null )
				this.GuidProject = (Guid)businessObject.GuidProject;
				
	if (businessObject.GuidFile != null )
				this.GuidFile = (Guid)businessObject.GuidFile;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstFile != null){
	                	this.FkKstFileText = businessObject.KstFile.FileName != null ? businessObject.KstFile.FileName.ToString() : "";; 
										
										
				this.FkKstFile = businessObject.KstFile.GuidFile;
                //this.FkKstFileSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstFile,"GuidFile").Replace("/","-");

			}
	        if (businessObject.KstProject != null){
	                	this.FkKstProjectText = businessObject.KstProject.Name != null ? businessObject.KstProject.Name.ToString() : "";; 
										
										
				this.FkKstProject = businessObject.KstProject.GuidProject;
                //this.FkKstProjectSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProject,"GuidProject").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstUserFiles 
	{
	public partial class KstUserFileModel: ModelBase{

	  public KstUserFileModel(BO.KstUserFile resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstUserFileModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidUserFile.ToString();
            }

			 set
            {
                this.GuidUserFile = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.BizKeyEngine != null)
		
            return this.BizKeyEngine.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidUserFile{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDUSER"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? GuidUser { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDFILE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? GuidFile { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ISPROFILEDEFAULT"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Boolean  ? IsProfileDefault { get; set; }
	public string _IsProfileDefaultText = null;
    public string IsProfileDefaultText {
        get {
			if (string.IsNullOrEmpty( _IsProfileDefaultText ))
				{
	
            if (IsProfileDefault != null)

				return IsProfileDefault.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsProfileDefaultText ;
			}			
        }
		set{
			_IsProfileDefaultText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstFilesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "FileName", DataPropertyValue = "GuidFile", FiltrablePropertyPathName="KstFile.GuidFile")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? FkKstFile { get; set; }
		//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	//[Exportable()]
	public string  FkKstFileText { get; set; }
   // public string FkKstFileSafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyUsersController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "DisplayName", DataPropertyValue = "GuidUser", FiltrablePropertyPathName="KstProxyUser.GuidUser")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYUSER"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	public Guid  ? FkKstProxyUser { get; set; }
		//[LocalizedDisplayName("KSTPROXYUSER"/*, NameResourceType=typeof(KstUserFileResources)*/)]
	//[Exportable()]
	public string  FkKstProxyUserText { get; set; }
   // public string FkKstProxyUserSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstUserFileModel model){
            
		this.GuidUserFile = model.GuidUserFile;
		this.GuidUser = model.GuidUser;
		this.GuidFile = model.GuidFile;
		this.IsProfileDefault = model.IsProfileDefault;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstUserFile GetBusinessObject()
        {
            BusinessObjects.KstUserFile result = new BusinessObjects.KstUserFile();


			       
	if (this.GuidUserFile != null )
				result.GuidUserFile = (Guid)this.GuidUserFile;
				
	if (this.GuidUser != null )
				result.GuidUser = (Guid)this.GuidUser;
				
	if (this.GuidFile != null )
				result.GuidFile = (Guid)this.GuidFile;
				
	if (this.IsProfileDefault != null )
				result.IsProfileDefault = (Boolean)this.IsProfileDefault;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstFile != null || this.GuidFile != null){
			if (GuidFile != null) this.FkKstFile = GuidFile; 
			result.KstFile = new BusinessObjects.KstFile() { GuidFile= (Guid)this.FkKstFile };

			
			}
				
			
			if(this.FkKstProxyUser != null || this.GuidUser != null){
			if (GuidUser != null) this.FkKstProxyUser = GuidUser; 
			result.KstProxyUser = new BusinessObjects.KstProxyUser() { GuidUser= (Guid)this.FkKstProxyUser };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstUserFile businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidUserFile = businessObject.GuidUserFile;
				
				
	if (businessObject.GuidUser != null )
				this.GuidUser = (Guid)businessObject.GuidUser;
				
	if (businessObject.GuidFile != null )
				this.GuidFile = (Guid)businessObject.GuidFile;
				
	if (businessObject.IsProfileDefault != null )
				this.IsProfileDefault = (Boolean)businessObject.IsProfileDefault;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstFile != null){
	                	this.FkKstFileText = businessObject.KstFile.FileName != null ? businessObject.KstFile.FileName.ToString() : "";; 
										
										
				this.FkKstFile = businessObject.KstFile.GuidFile;
                //this.FkKstFileSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstFile,"GuidFile").Replace("/","-");

			}
	        if (businessObject.KstProxyUser != null){
	                	this.FkKstProxyUserText = businessObject.KstProxyUser.DisplayName != null ? businessObject.KstProxyUser.DisplayName.ToString() : "";; 
										
				this.FkKstProxyUser = businessObject.KstProxyUser.GuidUser;
                //this.FkKstProxyUserSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyUser,"GuidUser").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstWorkTimeFiles 
	{
	public partial class KstWorkTimeFileModel: ModelBase{

	  public KstWorkTimeFileModel(BO.KstWorkTimeFile resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstWorkTimeFileModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidWorkTimeFile.ToString();
            }

			 set
            {
                this.GuidWorkTimeFile = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.BizKeyEngine != null)
		
            return this.BizKeyEngine.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidWorkTimeFile{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDWORKTIME"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? GuidWorkTime { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDFILE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? GuidFile { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
///[Exportable()]
		
//[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
//[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	//[SystemProperty()]
	//[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BIZKEYENGINE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public String   BizKeyEngine { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DataType("Integer")]
	//[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstFilesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "FileName", DataPropertyValue = "GuidFile", FiltrablePropertyPathName="KstFile.GuidFile")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? FkKstFile { get; set; }
		//[LocalizedDisplayName("KSTFILE"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	//[Exportable()]
	public string  FkKstFileText { get; set; }
   // public string FkKstFileSafeKey { get; set; }

	
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstWorkTimesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "Title", DataPropertyValue = "GuidWorkTime", FiltrablePropertyPathName="KstWorkTime.GuidWorkTime")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTWORKTIME"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	public Guid  ? FkKstWorkTime { get; set; }
		//[LocalizedDisplayName("KSTWORKTIME"/*, NameResourceType=typeof(KstWorkTimeFileResources)*/)]
	//[Exportable()]
	public string  FkKstWorkTimeText { get; set; }
   // public string FkKstWorkTimeSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstWorkTimeFileModel model){
            
		this.GuidWorkTimeFile = model.GuidWorkTimeFile;
		this.GuidWorkTime = model.GuidWorkTime;
		this.GuidFile = model.GuidFile;
		this.GuidCompany = model.GuidCompany;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.IsDeleted = model.IsDeleted;
		this.BizKeyEngine = model.BizKeyEngine;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.Bytes = model.Bytes;
        }

        public BusinessObjects.KstWorkTimeFile GetBusinessObject()
        {
            BusinessObjects.KstWorkTimeFile result = new BusinessObjects.KstWorkTimeFile();


			       
	if (this.GuidWorkTimeFile != null )
				result.GuidWorkTimeFile = (Guid)this.GuidWorkTimeFile;
				
	if (this.GuidWorkTime != null )
				result.GuidWorkTime = (Guid)this.GuidWorkTime;
				
	if (this.GuidFile != null )
				result.GuidFile = (Guid)this.GuidFile;
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
	if (this.BizKeyEngine != null )
				result.BizKeyEngine = (String)this.BizKeyEngine.Trim().Replace("\t", String.Empty);
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
			
			if(this.FkKstFile != null || this.GuidFile != null){
			if (GuidFile != null) this.FkKstFile = GuidFile; 
			result.KstFile = new BusinessObjects.KstFile() { GuidFile= (Guid)this.FkKstFile };

			
			}
				
			
			if(this.FkKstWorkTime != null || this.GuidWorkTime != null){
			if (GuidWorkTime != null) this.FkKstWorkTime = GuidWorkTime; 
			result.KstWorkTime = new BusinessObjects.KstWorkTime() { GuidWorkTime= (Guid)this.FkKstWorkTime };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstWorkTimeFile businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidWorkTimeFile = businessObject.GuidWorkTimeFile;
				
				
	if (businessObject.GuidWorkTime != null )
				this.GuidWorkTime = (Guid)businessObject.GuidWorkTime;
				
	if (businessObject.GuidFile != null )
				this.GuidFile = (Guid)businessObject.GuidFile;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				
	if (businessObject.BizKeyEngine != null )
				this.BizKeyEngine = (String)businessObject.BizKeyEngine;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
	        if (businessObject.KstFile != null){
	                	this.FkKstFileText = businessObject.KstFile.FileName != null ? businessObject.KstFile.FileName.ToString() : "";; 
										
										
				this.FkKstFile = businessObject.KstFile.GuidFile;
                //this.FkKstFileSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstFile,"GuidFile").Replace("/","-");

			}
	        if (businessObject.KstWorkTime != null){
	                	this.FkKstWorkTimeText = businessObject.KstWorkTime.Title != null ? businessObject.KstWorkTime.Title.ToString() : "";; 
										
				this.FkKstWorkTime = businessObject.KstWorkTime.GuidWorkTime;
                //this.FkKstWorkTimeSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstWorkTime,"GuidWorkTime").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProxyRoles 
	{
	public partial class KstProxyRoleModel: ModelBase{

	  public KstProxyRoleModel(BO.KstProxyRole resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProxyRoleModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidRole.ToString();
            }

			 set
            {
                this.GuidRole = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.RoleName != null)
		
            return this.RoleName.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidRole{ get; set; }
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ROLENAME"/*, NameResourceType=typeof(KstProxyRoleResources)*/)]
	public String   RoleName { get; set; }
		
		
	
///[Exportable()]
	
	    [Required()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAMEKEY"/*, NameResourceType=typeof(KstProxyRoleResources)*/)]
	public String   NameKey { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstProxyRoleResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProxyRoleResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstProxyRoleResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
		

	
	
		public void Bind(KstProxyRoleModel model){
            
		this.GuidRole = model.GuidRole;
		this.RoleName = model.RoleName;
		this.NameKey = model.NameKey;
		this.UpdatedDate = model.UpdatedDate;
		this.IsDeleted = model.IsDeleted;
		this.CreatedDate = model.CreatedDate;
        }

        public BusinessObjects.KstProxyRole GetBusinessObject()
        {
            BusinessObjects.KstProxyRole result = new BusinessObjects.KstProxyRole();


			       
	if (this.GuidRole != null )
				result.GuidRole = (Guid)this.GuidRole;
				
	if (this.RoleName != null )
				result.RoleName = (String)this.RoleName.Trim().Replace("\t", String.Empty);
				
	if (this.NameKey != null )
				result.NameKey = (String)this.NameKey.Trim().Replace("\t", String.Empty);
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				

            return result;
        }
        public void Bind(BusinessObjects.KstProxyRole businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidRole = businessObject.GuidRole;
				
			this.RoleName = businessObject.RoleName != null ? businessObject.RoleName.Trim().Replace("\t", String.Empty) : "";
				
			this.NameKey = businessObject.NameKey != null ? businessObject.NameKey.Trim().Replace("\t", String.Empty) : "";
				
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
           
        }
	}
}
	namespace KS.Time.Api.Models.KstProxyUsers 
	{
	public partial class KstProxyUserModel: ModelBase{

	  public KstProxyUserModel(BO.KstProxyUser resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public KstProxyUserModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidUser.ToString();
            }

			 set
            {
                this.GuidUser = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.DisplayName != null)
		
            return this.DisplayName.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidUser{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("DISPLAYNAME"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   DisplayName { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("USERNAME"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   Username { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("PASSWORD"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   Password { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("FIRSTNAME"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   FirstName { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("LASTNAME"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   LastName { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("EMAIL"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public String   Email { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("GUIDROLE"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public Guid  ? GuidRole { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("DISABLED"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public Boolean  ? Disabled { get; set; }
	public string _DisabledText = null;
    public string DisabledText {
        get {
			if (string.IsNullOrEmpty( _DisabledText ))
				{
	
            if (Disabled != null)

				return Disabled.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _DisabledText ;
			}			
        }
		set{
			_DisabledText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable(DataClassProvider = typeof(Controllers.KstProxyRolesController), GetByKeyMethod="GetByKey", GetAllMethod = "GetAll", DataPropertyText = "RoleName", DataPropertyValue = "GuidRole", FiltrablePropertyPathName="KstProxyRole.GuidRole")]	

	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("KSTPROXYROLE"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	public Guid  ? FkKstProxyRole { get; set; }
		//[LocalizedDisplayName("KSTPROXYROLE"/*, NameResourceType=typeof(KstProxyUserResources)*/)]
	//[Exportable()]
	public string  FkKstProxyRoleText { get; set; }
   // public string FkKstProxyRoleSafeKey { get; set; }

	
		
		

	
	
		public void Bind(KstProxyUserModel model){
            
		this.GuidUser = model.GuidUser;
		this.DisplayName = model.DisplayName;
		this.Username = model.Username;
		this.Password = model.Password;
		this.FirstName = model.FirstName;
		this.LastName = model.LastName;
		this.Email = model.Email;
		this.GuidRole = model.GuidRole;
		this.UpdatedDate = model.UpdatedDate;
		this.IsDeleted = model.IsDeleted;
		this.CreatedDate = model.CreatedDate;
		this.Disabled = model.Disabled;
        }

        public BusinessObjects.KstProxyUser GetBusinessObject()
        {
            BusinessObjects.KstProxyUser result = new BusinessObjects.KstProxyUser();


			       
	if (this.GuidUser != null )
				result.GuidUser = (Guid)this.GuidUser;
				
	if (this.DisplayName != null )
				result.DisplayName = (String)this.DisplayName.Trim().Replace("\t", String.Empty);
				
	if (this.Username != null )
				result.Username = (String)this.Username.Trim().Replace("\t", String.Empty);
				
	if (this.Password != null )
				result.Password = (String)this.Password.Trim().Replace("\t", String.Empty);
				
	if (this.FirstName != null )
				result.FirstName = (String)this.FirstName.Trim().Replace("\t", String.Empty);
				
	if (this.LastName != null )
				result.LastName = (String)this.LastName.Trim().Replace("\t", String.Empty);
				
	if (this.Email != null )
				result.Email = (String)this.Email.Trim().Replace("\t", String.Empty);
				
	if (this.GuidRole != null )
				result.GuidRole = (Guid)this.GuidRole;
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
	if (this.Disabled != null )
				result.Disabled = (Boolean)this.Disabled;
				
			
			if(this.FkKstProxyRole != null || this.GuidRole != null){
			if (GuidRole != null) this.FkKstProxyRole = GuidRole; 
			result.KstProxyRole = new BusinessObjects.KstProxyRole() { GuidRole= (Guid)this.FkKstProxyRole };

			
			}
				

            return result;
        }
        public void Bind(BusinessObjects.KstProxyUser businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidUser = businessObject.GuidUser;
				
				
	if (businessObject.DisplayName != null )
				this.DisplayName = (String)businessObject.DisplayName;
				
	if (businessObject.Username != null )
				this.Username = (String)businessObject.Username;
				
	if (businessObject.Password != null )
				this.Password = (String)businessObject.Password;
				
	if (businessObject.FirstName != null )
				this.FirstName = (String)businessObject.FirstName;
				
	if (businessObject.LastName != null )
				this.LastName = (String)businessObject.LastName;
				
	if (businessObject.Email != null )
				this.Email = (String)businessObject.Email;
				
	if (businessObject.GuidRole != null )
				this.GuidRole = (Guid)businessObject.GuidRole;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				
	if (businessObject.Disabled != null )
				this.Disabled = (Boolean)businessObject.Disabled;
	        if (businessObject.KstProxyRole != null){
	                	this.FkKstProxyRoleText = businessObject.KstProxyRole.RoleName != null ? businessObject.KstProxyRole.RoleName.ToString() : "";; 
										
										
				this.FkKstProxyRole = businessObject.KstProxyRole.GuidRole;
                //this.FkKstProxyRoleSafeKey  = SFS.Core.Entities.Utils.GetKey(businessObject.KstProxyRole,"GuidRole").Replace("/","-");

			}
           
        }
	}
}
	namespace KS.Time.Api.Models.unProxyBusinessObjects 
	{
	public partial class unProxyBusinessObjectModel: ModelBase{

	  public unProxyBusinessObjectModel(BO.unProxyBusinessObject resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public unProxyBusinessObjectModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidBusinessObject.ToString();
            }

			 set
            {
                this.GuidBusinessObject = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidBusinessObject{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(unProxyBusinessObjectResources)*/)]
	public String   Name { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("BUSINESSOBJECTKEY"/*, NameResourceType=typeof(unProxyBusinessObjectResources)*/)]
	public String   BusinessObjectKey { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENTITYSETNAME"/*, NameResourceType=typeof(unProxyBusinessObjectResources)*/)]
	public String   EntitySetName { get; set; }
		
		
		

	
	
		public void Bind(unProxyBusinessObjectModel model){
            
		this.GuidBusinessObject = model.GuidBusinessObject;
		this.Name = model.Name;
		this.BusinessObjectKey = model.BusinessObjectKey;
		this.EntitySetName = model.EntitySetName;
        }

        public BusinessObjects.unProxyBusinessObject GetBusinessObject()
        {
            BusinessObjects.unProxyBusinessObject result = new BusinessObjects.unProxyBusinessObject();


			       
	if (this.GuidBusinessObject != null )
				result.GuidBusinessObject = (Guid)this.GuidBusinessObject;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.BusinessObjectKey != null )
				result.BusinessObjectKey = (String)this.BusinessObjectKey.Trim().Replace("\t", String.Empty);
				
	if (this.EntitySetName != null )
				result.EntitySetName = (String)this.EntitySetName.Trim().Replace("\t", String.Empty);
				

            return result;
        }
        public void Bind(BusinessObjects.unProxyBusinessObject businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidBusinessObject = businessObject.GuidBusinessObject;
				
				
	if (businessObject.Name != null )
				this.Name = (String)businessObject.Name;
				
	if (businessObject.BusinessObjectKey != null )
				this.BusinessObjectKey = (String)businessObject.BusinessObjectKey;
				
	if (businessObject.EntitySetName != null )
				this.EntitySetName = (String)businessObject.EntitySetName;
           
        }
	}
}
	namespace KS.Time.Api.Models.unProxyEvents 
	{
	public partial class unProxyEventModel: ModelBase{

	  public unProxyEventModel(BO.unProxyEvent resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public unProxyEventModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidUnProxyEvent.ToString();
            }

			 set
            {
                this.GuidUnProxyEvent = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.Title != null)
		
            return this.Title.ToString();
			else
				return "";
		
        }    
			


       
	
		[SystemProperty()]		
		public Guid? GuidUnProxyEvent{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("TITLE"/*, NameResourceType=typeof(unProxyEventResources)*/)]
	public String   Title { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MESSAGE"/*, NameResourceType=typeof(unProxyEventResources)*/)]
	public String   Message { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DataType("RichEditorAdvanced")]
	//[LocalizedDisplayName("TYPEEVENT"/*, NameResourceType=typeof(unProxyEventResources)*/)]
	public String   TypeEvent { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ISEXCEPTION"/*, NameResourceType=typeof(unProxyEventResources)*/)]
	public Boolean  ? IsException { get; set; }
	public string _IsExceptionText = null;
    public string IsExceptionText {
        get {
			if (string.IsNullOrEmpty( _IsExceptionText ))
				{
	
            if (IsException != null)

				return IsException.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsExceptionText ;
			}			
        }
		set{
			_IsExceptionText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[SystemProperty()]
	//[DateTime(true, false, null)]	
	//[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(unProxyEventResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
		

	
	
		public void Bind(unProxyEventModel model){
            
		this.GuidUnProxyEvent = model.GuidUnProxyEvent;
		this.Title = model.Title;
		this.Message = model.Message;
		this.TypeEvent = model.TypeEvent;
		this.IsException = model.IsException;
		this.UpdatedDate = model.UpdatedDate;
        }

        public BusinessObjects.unProxyEvent GetBusinessObject()
        {
            BusinessObjects.unProxyEvent result = new BusinessObjects.unProxyEvent();


			       
	if (this.GuidUnProxyEvent != null )
				result.GuidUnProxyEvent = (Guid)this.GuidUnProxyEvent;
				
	if (this.Title != null )
				result.Title = (String)this.Title.Trim().Replace("\t", String.Empty);
				
	if (this.Message != null )
				result.Message = (String)this.Message.Trim().Replace("\t", String.Empty);
				
	if (this.TypeEvent != null )
				result.TypeEvent = (String)this.TypeEvent.Trim().Replace("\t", String.Empty);
				
	if (this.IsException != null )
				result.IsException = (Boolean)this.IsException;
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				

            return result;
        }
        public void Bind(BusinessObjects.unProxyEvent businessObject)
        {
				this.BusinessObjectObject = businessObject;


			this.GuidUnProxyEvent = businessObject.GuidUnProxyEvent;
				
				
	if (businessObject.Title != null )
				this.Title = (String)businessObject.Title;
				
	if (businessObject.Message != null )
				this.Message = (String)businessObject.Message;
				
	if (businessObject.TypeEvent != null )
				this.TypeEvent = (String)businessObject.TypeEvent;
				
	if (businessObject.IsException != null )
				this.IsException = (Boolean)businessObject.IsException;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
           
        }
	}
}
	namespace KS.Time.Api.Models.unProxySettings 
	{
	public partial class unProxySettingModel: ModelBase{

	  public unProxySettingModel(BO.unProxySetting resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public unProxySettingModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidUnProxySetting.ToString();
            }

			 set
            {
                this.GuidUnProxySetting = Guid.Parse(value);
            }
        }
			
			
        public override string ToString()
        {
			if (this.SMTPServer != null)
		
            return this.SMTPServer.ToString();
			else
				return "";
		
        }    
			


	public Guid  ? SMTPServerId { get; set; }
	public Guid  ? SMTPSSLEnabledId { get; set; }
	public Guid  ? SMTPUserId { get; set; }
	public Guid  ? SMTPPasswordId { get; set; }
	public Guid  ? SMTPFromNameId { get; set; }
	public Guid  ? SMTPPortId { get; set; }
	public Guid  ? SMTPFromEmailId { get; set; }
	public Guid  ? AzureBlobStorageConnectionId { get; set; }
	public Guid  ? SaveBlobInAzureStorageId { get; set; }
	public Guid  ? SaveBlobInDataBaseId { get; set; }
	public Guid  ? UserNameGeoNamesId { get; set; }
	public Guid  ? EngineURLId { get; set; }
	public Guid  ? ENGINE_API_KEYId { get; set; }
	public Guid  ? MAMBU_URLId { get; set; }
	public Guid  ? MAMBU_USERId { get; set; }
	public Guid  ? MAMBU_PWDId { get; set; }
	public Guid  ? KM_MAXIMOId { get; set; }
	public Guid  ? MAP_KEYId { get; set; }
	public Guid  ? ENGINE_OAUTH_CLIENT_IDId { get; set; }
	public Guid  ? ENGINE_OAUTH_LOGIN_URLId { get; set; }
	public Guid  ? ENGINE_OAUTH_USERNAMEId { get; set; }
	public Guid  ? ENGINE_OAUTH_PASSWORDId { get; set; }
	public Guid  ? ENGINE_OAUTH_CLIENT_SECRETId { get; set; }
	public Guid  ? ENGINE_DEFINITION_IDId { get; set; }
	public Guid  ? CONTAINER_DATOS_CLIENTE_IDId { get; set; }
	public Guid  ? CONTAINER_DOCUMENTOS_IDId { get; set; }
	public Guid  ? CONTAINER_DIRECCION_IDId { get; set; }
	public Guid  ? CONTAINER_DATOS_FINANCIEROS_IDId { get; set; }
	public Guid  ? CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId { get; set; }
	public Guid  ? CONTAINER_BENEFICIARIOS_IDId { get; set; }
	public Guid  ? CONTAINER_CONTRATOS_IDId { get; set; }
	public Guid  ? CONTAINER_APROBACION_IDId { get; set; }
	public Guid  ? MAMBU_CONTRATO_TEMPLATEIDId { get; set; }
	public Guid  ? MAMBU_CARATULA_TEMPLATEIDId { get; set; }
	public Guid  ? MAMBU_PAGARE_TEMPLATEIDId { get; set; }
	public Guid  ? MAMBU_REFERENCIASPAGO_TEMPLATEIDId { get; set; }
	public Guid  ? MATI_AUTH_HEADERId { get; set; }
	public Guid  ? WEBBHOOK_MATI_KEYId { get; set; }
       
	
		[SystemProperty()]		
		public Guid? GuidUnProxySetting{ get; set; }
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPSERVER"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPServer { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPSSLENABLED"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public Boolean  ? SMTPSSLEnabled { get; set; }
	public string _SMTPSSLEnabledText = null;
    public string SMTPSSLEnabledText {
        get {
			if (string.IsNullOrEmpty( _SMTPSSLEnabledText ))
				{
	
            if (SMTPSSLEnabled != null)

				return SMTPSSLEnabled.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _SMTPSSLEnabledText ;
			}			
        }
		set{
			_SMTPSSLEnabledText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPUSER"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPUser { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPPASSWORD"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPPassword { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPFROMNAME"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPFromName { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPPORT"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPPort { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SMTPFROMEMAIL"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   SMTPFromEmail { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("AZUREBLOBSTORAGECONNECTION"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   AzureBlobStorageConnection { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SAVEBLOBINAZURESTORAGE"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public Boolean  ? SaveBlobInAzureStorage { get; set; }
	public string _SaveBlobInAzureStorageText = null;
    public string SaveBlobInAzureStorageText {
        get {
			if (string.IsNullOrEmpty( _SaveBlobInAzureStorageText ))
				{
	
            if (SaveBlobInAzureStorage != null)

				return SaveBlobInAzureStorage.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _SaveBlobInAzureStorageText ;
			}			
        }
		set{
			_SaveBlobInAzureStorageText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("SAVEBLOBINDATABASE"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public Boolean  ? SaveBlobInDataBase { get; set; }
	public string _SaveBlobInDataBaseText = null;
    public string SaveBlobInDataBaseText {
        get {
			if (string.IsNullOrEmpty( _SaveBlobInDataBaseText ))
				{
	
            if (SaveBlobInDataBase != null)

				return SaveBlobInDataBase.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _SaveBlobInDataBaseText ;
			}			
        }
		set{
			_SaveBlobInDataBaseText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("USERNAMEGEONAMES"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   UserNameGeoNames { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINEURL"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   EngineURL { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_API_KEY"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_API_KEY { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_URL"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_URL { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_USER"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_USER { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_PWD"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_PWD { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[DataType("Integer")]
	//[LocalizedDisplayName("KM_MAXIMO"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public Int32  ? KM_MAXIMO { get; set; }
	public string _KM_MAXIMOText = null;
    public string KM_MAXIMOText {
        get {
			if (string.IsNullOrEmpty( _KM_MAXIMOText ))
				{
	
            if (KM_MAXIMO != null)
				return KM_MAXIMO.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _KM_MAXIMOText ;
			}			
        }
		set{
			_KM_MAXIMOText = value;
		}
        
    }

		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAP_KEY"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAP_KEY { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_OAUTH_CLIENT_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_OAUTH_CLIENT_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_OAUTH_LOGIN_URL"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_OAUTH_LOGIN_URL { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_OAUTH_USERNAME"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_OAUTH_USERNAME { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_OAUTH_PASSWORD"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_OAUTH_PASSWORD { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_OAUTH_CLIENT_SECRET"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_OAUTH_CLIENT_SECRET { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("ENGINE_DEFINITION_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   ENGINE_DEFINITION_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_DATOS_CLIENTE_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_DATOS_CLIENTE_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_DOCUMENTOS_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_DOCUMENTOS_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_DIRECCION_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_DIRECCION_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_DATOS_FINANCIEROS_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_DATOS_FINANCIEROS_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_BENEFICIARIOS_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_BENEFICIARIOS_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_CONTRATOS_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_CONTRATOS_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("CONTAINER_APROBACION_ID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   CONTAINER_APROBACION_ID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_CONTRATO_TEMPLATEID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_CONTRATO_TEMPLATEID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_CARATULA_TEMPLATEID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_CARATULA_TEMPLATEID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_PAGARE_TEMPLATEID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_PAGARE_TEMPLATEID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MAMBU_REFERENCIASPAGO_TEMPLATEID"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MAMBU_REFERENCIASPAGO_TEMPLATEID { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("MATI_AUTH_HEADER"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   MATI_AUTH_HEADER { get; set; }
		
		
	
///[Exportable()]
		
	//[RelationFilterable()] 
	//[LocalizedDisplayName("WEBBHOOK_MATI_KEY"/*, NameResourceType=typeof(unProxySettingResources)*/)]
	public String   WEBBHOOK_MATI_KEY { get; set; }
		
		
		

	
	
		public void Bind(unProxySettingModel model){
            
		this.GuidUnProxySetting = model.GuidUnProxySetting;
		this.SMTPServer = model.SMTPServer;
		this.SMTPSSLEnabled = model.SMTPSSLEnabled;
		this.SMTPUser = model.SMTPUser;
		this.SMTPPassword = model.SMTPPassword;
		this.SMTPFromName = model.SMTPFromName;
		this.SMTPPort = model.SMTPPort;
		this.SMTPFromEmail = model.SMTPFromEmail;
		this.AzureBlobStorageConnection = model.AzureBlobStorageConnection;
		this.SaveBlobInAzureStorage = model.SaveBlobInAzureStorage;
		this.SaveBlobInDataBase = model.SaveBlobInDataBase;
		this.UserNameGeoNames = model.UserNameGeoNames;
		this.EngineURL = model.EngineURL;
		this.ENGINE_API_KEY = model.ENGINE_API_KEY;
		this.MAMBU_URL = model.MAMBU_URL;
		this.MAMBU_USER = model.MAMBU_USER;
		this.MAMBU_PWD = model.MAMBU_PWD;
		this.KM_MAXIMO = model.KM_MAXIMO;
		this.MAP_KEY = model.MAP_KEY;
		this.ENGINE_OAUTH_CLIENT_ID = model.ENGINE_OAUTH_CLIENT_ID;
		this.ENGINE_OAUTH_LOGIN_URL = model.ENGINE_OAUTH_LOGIN_URL;
		this.ENGINE_OAUTH_USERNAME = model.ENGINE_OAUTH_USERNAME;
		this.ENGINE_OAUTH_PASSWORD = model.ENGINE_OAUTH_PASSWORD;
		this.ENGINE_OAUTH_CLIENT_SECRET = model.ENGINE_OAUTH_CLIENT_SECRET;
		this.ENGINE_DEFINITION_ID = model.ENGINE_DEFINITION_ID;
		this.CONTAINER_DATOS_CLIENTE_ID = model.CONTAINER_DATOS_CLIENTE_ID;
		this.CONTAINER_DOCUMENTOS_ID = model.CONTAINER_DOCUMENTOS_ID;
		this.CONTAINER_DIRECCION_ID = model.CONTAINER_DIRECCION_ID;
		this.CONTAINER_DATOS_FINANCIEROS_ID = model.CONTAINER_DATOS_FINANCIEROS_ID;
		this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID = model.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID;
		this.CONTAINER_BENEFICIARIOS_ID = model.CONTAINER_BENEFICIARIOS_ID;
		this.CONTAINER_CONTRATOS_ID = model.CONTAINER_CONTRATOS_ID;
		this.CONTAINER_APROBACION_ID = model.CONTAINER_APROBACION_ID;
		this.MAMBU_CONTRATO_TEMPLATEID = model.MAMBU_CONTRATO_TEMPLATEID;
		this.MAMBU_CARATULA_TEMPLATEID = model.MAMBU_CARATULA_TEMPLATEID;
		this.MAMBU_PAGARE_TEMPLATEID = model.MAMBU_PAGARE_TEMPLATEID;
		this.MAMBU_REFERENCIASPAGO_TEMPLATEID = model.MAMBU_REFERENCIASPAGO_TEMPLATEID;
		this.MATI_AUTH_HEADER = model.MATI_AUTH_HEADER;
		this.WEBBHOOK_MATI_KEY = model.WEBBHOOK_MATI_KEY;
        }

        public BusinessObjects.unProxySetting GetBusinessObject()
        {
            BusinessObjects.unProxySetting result = new BusinessObjects.unProxySetting();


			       
	if (this.GuidUnProxySetting != null )
				result.GuidUnProxySetting = (Guid)this.GuidUnProxySetting;
				
	if (this.SMTPServer != null )
				result.SMTPServer = (String)this.SMTPServer.Trim().Replace("\t", String.Empty);
				
	if (this.SMTPSSLEnabled != null )
				result.SMTPSSLEnabled = (Boolean)this.SMTPSSLEnabled;
				
	if (this.SMTPUser != null )
				result.SMTPUser = (String)this.SMTPUser.Trim().Replace("\t", String.Empty);
				
	if (this.SMTPPassword != null )
				result.SMTPPassword = (String)this.SMTPPassword.Trim().Replace("\t", String.Empty);
				
	if (this.SMTPFromName != null )
				result.SMTPFromName = (String)this.SMTPFromName.Trim().Replace("\t", String.Empty);
				
	if (this.SMTPPort != null )
				result.SMTPPort = (String)this.SMTPPort.Trim().Replace("\t", String.Empty);
				
	if (this.SMTPFromEmail != null )
				result.SMTPFromEmail = (String)this.SMTPFromEmail.Trim().Replace("\t", String.Empty);
				
	if (this.AzureBlobStorageConnection != null )
				result.AzureBlobStorageConnection = (String)this.AzureBlobStorageConnection.Trim().Replace("\t", String.Empty);
				
	if (this.SaveBlobInAzureStorage != null )
				result.SaveBlobInAzureStorage = (Boolean)this.SaveBlobInAzureStorage;
				
	if (this.SaveBlobInDataBase != null )
				result.SaveBlobInDataBase = (Boolean)this.SaveBlobInDataBase;
				
	if (this.UserNameGeoNames != null )
				result.UserNameGeoNames = (String)this.UserNameGeoNames.Trim().Replace("\t", String.Empty);
				
	if (this.EngineURL != null )
				result.EngineURL = (String)this.EngineURL.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_API_KEY != null )
				result.ENGINE_API_KEY = (String)this.ENGINE_API_KEY.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_URL != null )
				result.MAMBU_URL = (String)this.MAMBU_URL.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_USER != null )
				result.MAMBU_USER = (String)this.MAMBU_USER.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_PWD != null )
				result.MAMBU_PWD = (String)this.MAMBU_PWD.Trim().Replace("\t", String.Empty);
				
	if (this.KM_MAXIMO != null )
				result.KM_MAXIMO = (Int32)this.KM_MAXIMO;
				
	if (this.MAP_KEY != null )
				result.MAP_KEY = (String)this.MAP_KEY.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_OAUTH_CLIENT_ID != null )
				result.ENGINE_OAUTH_CLIENT_ID = (String)this.ENGINE_OAUTH_CLIENT_ID.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_OAUTH_LOGIN_URL != null )
				result.ENGINE_OAUTH_LOGIN_URL = (String)this.ENGINE_OAUTH_LOGIN_URL.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_OAUTH_USERNAME != null )
				result.ENGINE_OAUTH_USERNAME = (String)this.ENGINE_OAUTH_USERNAME.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_OAUTH_PASSWORD != null )
				result.ENGINE_OAUTH_PASSWORD = (String)this.ENGINE_OAUTH_PASSWORD.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_OAUTH_CLIENT_SECRET != null )
				result.ENGINE_OAUTH_CLIENT_SECRET = (String)this.ENGINE_OAUTH_CLIENT_SECRET.Trim().Replace("\t", String.Empty);
				
	if (this.ENGINE_DEFINITION_ID != null )
				result.ENGINE_DEFINITION_ID = (String)this.ENGINE_DEFINITION_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_DATOS_CLIENTE_ID != null )
				result.CONTAINER_DATOS_CLIENTE_ID = (String)this.CONTAINER_DATOS_CLIENTE_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_DOCUMENTOS_ID != null )
				result.CONTAINER_DOCUMENTOS_ID = (String)this.CONTAINER_DOCUMENTOS_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_DIRECCION_ID != null )
				result.CONTAINER_DIRECCION_ID = (String)this.CONTAINER_DIRECCION_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_DATOS_FINANCIEROS_ID != null )
				result.CONTAINER_DATOS_FINANCIEROS_ID = (String)this.CONTAINER_DATOS_FINANCIEROS_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID != null )
				result.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID = (String)this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_BENEFICIARIOS_ID != null )
				result.CONTAINER_BENEFICIARIOS_ID = (String)this.CONTAINER_BENEFICIARIOS_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_CONTRATOS_ID != null )
				result.CONTAINER_CONTRATOS_ID = (String)this.CONTAINER_CONTRATOS_ID.Trim().Replace("\t", String.Empty);
				
	if (this.CONTAINER_APROBACION_ID != null )
				result.CONTAINER_APROBACION_ID = (String)this.CONTAINER_APROBACION_ID.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_CONTRATO_TEMPLATEID != null )
				result.MAMBU_CONTRATO_TEMPLATEID = (String)this.MAMBU_CONTRATO_TEMPLATEID.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_CARATULA_TEMPLATEID != null )
				result.MAMBU_CARATULA_TEMPLATEID = (String)this.MAMBU_CARATULA_TEMPLATEID.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_PAGARE_TEMPLATEID != null )
				result.MAMBU_PAGARE_TEMPLATEID = (String)this.MAMBU_PAGARE_TEMPLATEID.Trim().Replace("\t", String.Empty);
				
	if (this.MAMBU_REFERENCIASPAGO_TEMPLATEID != null )
				result.MAMBU_REFERENCIASPAGO_TEMPLATEID = (String)this.MAMBU_REFERENCIASPAGO_TEMPLATEID.Trim().Replace("\t", String.Empty);
				
	if (this.MATI_AUTH_HEADER != null )
				result.MATI_AUTH_HEADER = (String)this.MATI_AUTH_HEADER.Trim().Replace("\t", String.Empty);
				
	if (this.WEBBHOOK_MATI_KEY != null )
				result.WEBBHOOK_MATI_KEY = (String)this.WEBBHOOK_MATI_KEY.Trim().Replace("\t", String.Empty);
				
			if (this.SMTPServerId != null )
				result.SMTPServerId = (Guid)this.SMTPServerId;
			if (this.SMTPSSLEnabledId != null )
				result.SMTPSSLEnabledId = (Guid)this.SMTPSSLEnabledId;
			if (this.SMTPUserId != null )
				result.SMTPUserId = (Guid)this.SMTPUserId;
			if (this.SMTPPasswordId != null )
				result.SMTPPasswordId = (Guid)this.SMTPPasswordId;
			if (this.SMTPFromNameId != null )
				result.SMTPFromNameId = (Guid)this.SMTPFromNameId;
			if (this.SMTPPortId != null )
				result.SMTPPortId = (Guid)this.SMTPPortId;
			if (this.SMTPFromEmailId != null )
				result.SMTPFromEmailId = (Guid)this.SMTPFromEmailId;
			if (this.AzureBlobStorageConnectionId != null )
				result.AzureBlobStorageConnectionId = (Guid)this.AzureBlobStorageConnectionId;
			if (this.SaveBlobInAzureStorageId != null )
				result.SaveBlobInAzureStorageId = (Guid)this.SaveBlobInAzureStorageId;
			if (this.SaveBlobInDataBaseId != null )
				result.SaveBlobInDataBaseId = (Guid)this.SaveBlobInDataBaseId;
			if (this.UserNameGeoNamesId != null )
				result.UserNameGeoNamesId = (Guid)this.UserNameGeoNamesId;
			if (this.EngineURLId != null )
				result.EngineURLId = (Guid)this.EngineURLId;
			if (this.ENGINE_API_KEYId != null )
				result.ENGINE_API_KEYId = (Guid)this.ENGINE_API_KEYId;
			if (this.MAMBU_URLId != null )
				result.MAMBU_URLId = (Guid)this.MAMBU_URLId;
			if (this.MAMBU_USERId != null )
				result.MAMBU_USERId = (Guid)this.MAMBU_USERId;
			if (this.MAMBU_PWDId != null )
				result.MAMBU_PWDId = (Guid)this.MAMBU_PWDId;
			if (this.KM_MAXIMOId != null )
				result.KM_MAXIMOId = (Guid)this.KM_MAXIMOId;
			if (this.MAP_KEYId != null )
				result.MAP_KEYId = (Guid)this.MAP_KEYId;
			if (this.ENGINE_OAUTH_CLIENT_IDId != null )
				result.ENGINE_OAUTH_CLIENT_IDId = (Guid)this.ENGINE_OAUTH_CLIENT_IDId;
			if (this.ENGINE_OAUTH_LOGIN_URLId != null )
				result.ENGINE_OAUTH_LOGIN_URLId = (Guid)this.ENGINE_OAUTH_LOGIN_URLId;
			if (this.ENGINE_OAUTH_USERNAMEId != null )
				result.ENGINE_OAUTH_USERNAMEId = (Guid)this.ENGINE_OAUTH_USERNAMEId;
			if (this.ENGINE_OAUTH_PASSWORDId != null )
				result.ENGINE_OAUTH_PASSWORDId = (Guid)this.ENGINE_OAUTH_PASSWORDId;
			if (this.ENGINE_OAUTH_CLIENT_SECRETId != null )
				result.ENGINE_OAUTH_CLIENT_SECRETId = (Guid)this.ENGINE_OAUTH_CLIENT_SECRETId;
			if (this.ENGINE_DEFINITION_IDId != null )
				result.ENGINE_DEFINITION_IDId = (Guid)this.ENGINE_DEFINITION_IDId;
			if (this.CONTAINER_DATOS_CLIENTE_IDId != null )
				result.CONTAINER_DATOS_CLIENTE_IDId = (Guid)this.CONTAINER_DATOS_CLIENTE_IDId;
			if (this.CONTAINER_DOCUMENTOS_IDId != null )
				result.CONTAINER_DOCUMENTOS_IDId = (Guid)this.CONTAINER_DOCUMENTOS_IDId;
			if (this.CONTAINER_DIRECCION_IDId != null )
				result.CONTAINER_DIRECCION_IDId = (Guid)this.CONTAINER_DIRECCION_IDId;
			if (this.CONTAINER_DATOS_FINANCIEROS_IDId != null )
				result.CONTAINER_DATOS_FINANCIEROS_IDId = (Guid)this.CONTAINER_DATOS_FINANCIEROS_IDId;
			if (this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId != null )
				result.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId = (Guid)this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId;
			if (this.CONTAINER_BENEFICIARIOS_IDId != null )
				result.CONTAINER_BENEFICIARIOS_IDId = (Guid)this.CONTAINER_BENEFICIARIOS_IDId;
			if (this.CONTAINER_CONTRATOS_IDId != null )
				result.CONTAINER_CONTRATOS_IDId = (Guid)this.CONTAINER_CONTRATOS_IDId;
			if (this.CONTAINER_APROBACION_IDId != null )
				result.CONTAINER_APROBACION_IDId = (Guid)this.CONTAINER_APROBACION_IDId;
			if (this.MAMBU_CONTRATO_TEMPLATEIDId != null )
				result.MAMBU_CONTRATO_TEMPLATEIDId = (Guid)this.MAMBU_CONTRATO_TEMPLATEIDId;
			if (this.MAMBU_CARATULA_TEMPLATEIDId != null )
				result.MAMBU_CARATULA_TEMPLATEIDId = (Guid)this.MAMBU_CARATULA_TEMPLATEIDId;
			if (this.MAMBU_PAGARE_TEMPLATEIDId != null )
				result.MAMBU_PAGARE_TEMPLATEIDId = (Guid)this.MAMBU_PAGARE_TEMPLATEIDId;
			if (this.MAMBU_REFERENCIASPAGO_TEMPLATEIDId != null )
				result.MAMBU_REFERENCIASPAGO_TEMPLATEIDId = (Guid)this.MAMBU_REFERENCIASPAGO_TEMPLATEIDId;
			if (this.MATI_AUTH_HEADERId != null )
				result.MATI_AUTH_HEADERId = (Guid)this.MATI_AUTH_HEADERId;
			if (this.WEBBHOOK_MATI_KEYId != null )
				result.WEBBHOOK_MATI_KEYId = (Guid)this.WEBBHOOK_MATI_KEYId;

            return result;
        }
        public void Bind(BusinessObjects.unProxySetting businessObject)
        {
				this.BusinessObjectObject = businessObject;


			if (businessObject.SMTPServerId != null )
				this.SMTPServerId = (Guid)businessObject.SMTPServerId;
			if (businessObject.SMTPSSLEnabledId != null )
				this.SMTPSSLEnabledId = (Guid)businessObject.SMTPSSLEnabledId;
			if (businessObject.SMTPUserId != null )
				this.SMTPUserId = (Guid)businessObject.SMTPUserId;
			if (businessObject.SMTPPasswordId != null )
				this.SMTPPasswordId = (Guid)businessObject.SMTPPasswordId;
			if (businessObject.SMTPFromNameId != null )
				this.SMTPFromNameId = (Guid)businessObject.SMTPFromNameId;
			if (businessObject.SMTPPortId != null )
				this.SMTPPortId = (Guid)businessObject.SMTPPortId;
			if (businessObject.SMTPFromEmailId != null )
				this.SMTPFromEmailId = (Guid)businessObject.SMTPFromEmailId;
			if (businessObject.AzureBlobStorageConnectionId != null )
				this.AzureBlobStorageConnectionId = (Guid)businessObject.AzureBlobStorageConnectionId;
			if (businessObject.SaveBlobInAzureStorageId != null )
				this.SaveBlobInAzureStorageId = (Guid)businessObject.SaveBlobInAzureStorageId;
			if (businessObject.SaveBlobInDataBaseId != null )
				this.SaveBlobInDataBaseId = (Guid)businessObject.SaveBlobInDataBaseId;
			if (businessObject.UserNameGeoNamesId != null )
				this.UserNameGeoNamesId = (Guid)businessObject.UserNameGeoNamesId;
			if (businessObject.EngineURLId != null )
				this.EngineURLId = (Guid)businessObject.EngineURLId;
			if (businessObject.ENGINE_API_KEYId != null )
				this.ENGINE_API_KEYId = (Guid)businessObject.ENGINE_API_KEYId;
			if (businessObject.MAMBU_URLId != null )
				this.MAMBU_URLId = (Guid)businessObject.MAMBU_URLId;
			if (businessObject.MAMBU_USERId != null )
				this.MAMBU_USERId = (Guid)businessObject.MAMBU_USERId;
			if (businessObject.MAMBU_PWDId != null )
				this.MAMBU_PWDId = (Guid)businessObject.MAMBU_PWDId;
			if (businessObject.KM_MAXIMOId != null )
				this.KM_MAXIMOId = (Guid)businessObject.KM_MAXIMOId;
			if (businessObject.MAP_KEYId != null )
				this.MAP_KEYId = (Guid)businessObject.MAP_KEYId;
			if (businessObject.ENGINE_OAUTH_CLIENT_IDId != null )
				this.ENGINE_OAUTH_CLIENT_IDId = (Guid)businessObject.ENGINE_OAUTH_CLIENT_IDId;
			if (businessObject.ENGINE_OAUTH_LOGIN_URLId != null )
				this.ENGINE_OAUTH_LOGIN_URLId = (Guid)businessObject.ENGINE_OAUTH_LOGIN_URLId;
			if (businessObject.ENGINE_OAUTH_USERNAMEId != null )
				this.ENGINE_OAUTH_USERNAMEId = (Guid)businessObject.ENGINE_OAUTH_USERNAMEId;
			if (businessObject.ENGINE_OAUTH_PASSWORDId != null )
				this.ENGINE_OAUTH_PASSWORDId = (Guid)businessObject.ENGINE_OAUTH_PASSWORDId;
			if (businessObject.ENGINE_OAUTH_CLIENT_SECRETId != null )
				this.ENGINE_OAUTH_CLIENT_SECRETId = (Guid)businessObject.ENGINE_OAUTH_CLIENT_SECRETId;
			if (businessObject.ENGINE_DEFINITION_IDId != null )
				this.ENGINE_DEFINITION_IDId = (Guid)businessObject.ENGINE_DEFINITION_IDId;
			if (businessObject.CONTAINER_DATOS_CLIENTE_IDId != null )
				this.CONTAINER_DATOS_CLIENTE_IDId = (Guid)businessObject.CONTAINER_DATOS_CLIENTE_IDId;
			if (businessObject.CONTAINER_DOCUMENTOS_IDId != null )
				this.CONTAINER_DOCUMENTOS_IDId = (Guid)businessObject.CONTAINER_DOCUMENTOS_IDId;
			if (businessObject.CONTAINER_DIRECCION_IDId != null )
				this.CONTAINER_DIRECCION_IDId = (Guid)businessObject.CONTAINER_DIRECCION_IDId;
			if (businessObject.CONTAINER_DATOS_FINANCIEROS_IDId != null )
				this.CONTAINER_DATOS_FINANCIEROS_IDId = (Guid)businessObject.CONTAINER_DATOS_FINANCIEROS_IDId;
			if (businessObject.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId != null )
				this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId = (Guid)businessObject.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId;
			if (businessObject.CONTAINER_BENEFICIARIOS_IDId != null )
				this.CONTAINER_BENEFICIARIOS_IDId = (Guid)businessObject.CONTAINER_BENEFICIARIOS_IDId;
			if (businessObject.CONTAINER_CONTRATOS_IDId != null )
				this.CONTAINER_CONTRATOS_IDId = (Guid)businessObject.CONTAINER_CONTRATOS_IDId;
			if (businessObject.CONTAINER_APROBACION_IDId != null )
				this.CONTAINER_APROBACION_IDId = (Guid)businessObject.CONTAINER_APROBACION_IDId;
			if (businessObject.MAMBU_CONTRATO_TEMPLATEIDId != null )
				this.MAMBU_CONTRATO_TEMPLATEIDId = (Guid)businessObject.MAMBU_CONTRATO_TEMPLATEIDId;
			if (businessObject.MAMBU_CARATULA_TEMPLATEIDId != null )
				this.MAMBU_CARATULA_TEMPLATEIDId = (Guid)businessObject.MAMBU_CARATULA_TEMPLATEIDId;
			if (businessObject.MAMBU_PAGARE_TEMPLATEIDId != null )
				this.MAMBU_PAGARE_TEMPLATEIDId = (Guid)businessObject.MAMBU_PAGARE_TEMPLATEIDId;
			if (businessObject.MAMBU_REFERENCIASPAGO_TEMPLATEIDId != null )
				this.MAMBU_REFERENCIASPAGO_TEMPLATEIDId = (Guid)businessObject.MAMBU_REFERENCIASPAGO_TEMPLATEIDId;
			if (businessObject.MATI_AUTH_HEADERId != null )
				this.MATI_AUTH_HEADERId = (Guid)businessObject.MATI_AUTH_HEADERId;
			if (businessObject.WEBBHOOK_MATI_KEYId != null )
				this.WEBBHOOK_MATI_KEYId = (Guid)businessObject.WEBBHOOK_MATI_KEYId;
			this.GuidUnProxySetting = businessObject.GuidUnProxySetting;
				
				
	if (businessObject.SMTPServer != null )
				this.SMTPServer = (String)businessObject.SMTPServer;
				
	if (businessObject.SMTPSSLEnabled != null )
				this.SMTPSSLEnabled = (Boolean)businessObject.SMTPSSLEnabled;
				
	if (businessObject.SMTPUser != null )
				this.SMTPUser = (String)businessObject.SMTPUser;
				
	if (businessObject.SMTPPassword != null )
				this.SMTPPassword = (String)businessObject.SMTPPassword;
				
	if (businessObject.SMTPFromName != null )
				this.SMTPFromName = (String)businessObject.SMTPFromName;
				
	if (businessObject.SMTPPort != null )
				this.SMTPPort = (String)businessObject.SMTPPort;
				
	if (businessObject.SMTPFromEmail != null )
				this.SMTPFromEmail = (String)businessObject.SMTPFromEmail;
				
	if (businessObject.AzureBlobStorageConnection != null )
				this.AzureBlobStorageConnection = (String)businessObject.AzureBlobStorageConnection;
				
	if (businessObject.SaveBlobInAzureStorage != null )
				this.SaveBlobInAzureStorage = (Boolean)businessObject.SaveBlobInAzureStorage;
				
	if (businessObject.SaveBlobInDataBase != null )
				this.SaveBlobInDataBase = (Boolean)businessObject.SaveBlobInDataBase;
				
	if (businessObject.UserNameGeoNames != null )
				this.UserNameGeoNames = (String)businessObject.UserNameGeoNames;
				
	if (businessObject.EngineURL != null )
				this.EngineURL = (String)businessObject.EngineURL;
				
	if (businessObject.ENGINE_API_KEY != null )
				this.ENGINE_API_KEY = (String)businessObject.ENGINE_API_KEY;
				
	if (businessObject.MAMBU_URL != null )
				this.MAMBU_URL = (String)businessObject.MAMBU_URL;
				
	if (businessObject.MAMBU_USER != null )
				this.MAMBU_USER = (String)businessObject.MAMBU_USER;
				
	if (businessObject.MAMBU_PWD != null )
				this.MAMBU_PWD = (String)businessObject.MAMBU_PWD;
				
	if (businessObject.KM_MAXIMO != null )
				this.KM_MAXIMO = (Int32)businessObject.KM_MAXIMO;
				
	if (businessObject.MAP_KEY != null )
				this.MAP_KEY = (String)businessObject.MAP_KEY;
				
	if (businessObject.ENGINE_OAUTH_CLIENT_ID != null )
				this.ENGINE_OAUTH_CLIENT_ID = (String)businessObject.ENGINE_OAUTH_CLIENT_ID;
				
	if (businessObject.ENGINE_OAUTH_LOGIN_URL != null )
				this.ENGINE_OAUTH_LOGIN_URL = (String)businessObject.ENGINE_OAUTH_LOGIN_URL;
				
	if (businessObject.ENGINE_OAUTH_USERNAME != null )
				this.ENGINE_OAUTH_USERNAME = (String)businessObject.ENGINE_OAUTH_USERNAME;
				
	if (businessObject.ENGINE_OAUTH_PASSWORD != null )
				this.ENGINE_OAUTH_PASSWORD = (String)businessObject.ENGINE_OAUTH_PASSWORD;
				
	if (businessObject.ENGINE_OAUTH_CLIENT_SECRET != null )
				this.ENGINE_OAUTH_CLIENT_SECRET = (String)businessObject.ENGINE_OAUTH_CLIENT_SECRET;
				
	if (businessObject.ENGINE_DEFINITION_ID != null )
				this.ENGINE_DEFINITION_ID = (String)businessObject.ENGINE_DEFINITION_ID;
				
	if (businessObject.CONTAINER_DATOS_CLIENTE_ID != null )
				this.CONTAINER_DATOS_CLIENTE_ID = (String)businessObject.CONTAINER_DATOS_CLIENTE_ID;
				
	if (businessObject.CONTAINER_DOCUMENTOS_ID != null )
				this.CONTAINER_DOCUMENTOS_ID = (String)businessObject.CONTAINER_DOCUMENTOS_ID;
				
	if (businessObject.CONTAINER_DIRECCION_ID != null )
				this.CONTAINER_DIRECCION_ID = (String)businessObject.CONTAINER_DIRECCION_ID;
				
	if (businessObject.CONTAINER_DATOS_FINANCIEROS_ID != null )
				this.CONTAINER_DATOS_FINANCIEROS_ID = (String)businessObject.CONTAINER_DATOS_FINANCIEROS_ID;
				
	if (businessObject.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID != null )
				this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID = (String)businessObject.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID;
				
	if (businessObject.CONTAINER_BENEFICIARIOS_ID != null )
				this.CONTAINER_BENEFICIARIOS_ID = (String)businessObject.CONTAINER_BENEFICIARIOS_ID;
				
	if (businessObject.CONTAINER_CONTRATOS_ID != null )
				this.CONTAINER_CONTRATOS_ID = (String)businessObject.CONTAINER_CONTRATOS_ID;
				
	if (businessObject.CONTAINER_APROBACION_ID != null )
				this.CONTAINER_APROBACION_ID = (String)businessObject.CONTAINER_APROBACION_ID;
				
	if (businessObject.MAMBU_CONTRATO_TEMPLATEID != null )
				this.MAMBU_CONTRATO_TEMPLATEID = (String)businessObject.MAMBU_CONTRATO_TEMPLATEID;
				
	if (businessObject.MAMBU_CARATULA_TEMPLATEID != null )
				this.MAMBU_CARATULA_TEMPLATEID = (String)businessObject.MAMBU_CARATULA_TEMPLATEID;
				
	if (businessObject.MAMBU_PAGARE_TEMPLATEID != null )
				this.MAMBU_PAGARE_TEMPLATEID = (String)businessObject.MAMBU_PAGARE_TEMPLATEID;
				
	if (businessObject.MAMBU_REFERENCIASPAGO_TEMPLATEID != null )
				this.MAMBU_REFERENCIASPAGO_TEMPLATEID = (String)businessObject.MAMBU_REFERENCIASPAGO_TEMPLATEID;
				
	if (businessObject.MATI_AUTH_HEADER != null )
				this.MATI_AUTH_HEADER = (String)businessObject.MATI_AUTH_HEADER;
				
	if (businessObject.WEBBHOOK_MATI_KEY != null )
				this.WEBBHOOK_MATI_KEY = (String)businessObject.WEBBHOOK_MATI_KEY;
           
        }
	}
}
