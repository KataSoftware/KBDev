 
 

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using SFS.Core.Common.Entities.Metadata;
using SFS.Core.Common.Entities;
using System.Linq.Dynamic.Core;
using System.Linq.Dynamic.Core.CustomTypeProviders;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

#endregion
namespace KS.Time.BusinessObjects
{

	  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidEmailTemplate",PropertyDefaultText="Title",RequiredProperties="Title", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstEmailTemplate", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstEmailTemplate:  ITrackable, IMyEntity{
	   public  KstEmailTemplate(Guid? guidEmailTemplate, String title)
        {
			if (guidEmailTemplate != null ){
            this.GuidEmailTemplate = guidEmailTemplate.Value;
            this.Title = title;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidEmailTemplate.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidEmailTemplate = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Title != null )		
            		return this.Title.ToString();
				else
					return String.Empty;
			}

		//public KstEmailTemplate()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstEmailTemplate(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1

	#endregion

	#region
	private Guid __GuidEmailTemplate;
	[DataMember]
	
	public Guid GuidEmailTemplate  { 
		get{
			return __GuidEmailTemplate;
		}
		set{

			__GuidEmailTemplate = value;
			
		}
	 }
	private String __Title;
	[DataMember]
	
	public String Title  { 
		get{
			return __Title;
		}
		set{

			__Title = value;
			
		}
	 }
	private String __TitleKey;
	[DataMember]
	
	public String TitleKey  { 
		get{
			return __TitleKey;
		}
		set{

			__TitleKey = value;
			
		}
	 }
	private String __Content;
	[DataMember]
	
	public String Content  { 
		get{
			return __Content;
		}
		set{

			__Content = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstEmailTemplate";
		public static readonly string EntitySetName = "KstEmailTemplates";
        public struct PropertyNames {
            public static readonly string GuidEmailTemplate = "GuidEmailTemplate";
            public static readonly string Title = "Title";
            public static readonly string TitleKey = "TitleKey";
            public static readonly string Content = "Content";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidCity",PropertyDefaultText="Name",RequiredProperties="Name",DeletedPropertyName="IsDeleted")]
	  [Table("KstProxyGeoCity", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProxyGeoCity:  ITrackable, IMyEntity{
	   public  KstProxyGeoCity(Guid? guidCity, String name)
        {
			if (guidCity != null ){
            this.GuidCity = guidCity.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidCity.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidCity = Guid.Parse(value);
}
		}

		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstProxyGeoCity()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProxyGeoCity(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProxyGeoCity1 = new HashSet<KstProxyGeoCity>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProxyGeoCity> KstProxyGeoCity1 { get; set; }
	


//x1
	private KstProxyGeoCity __KstProxyGeoCity2;
	[DataMember]
	public virtual KstProxyGeoCity KstProxyGeoCity2 {
		get{
			return __KstProxyGeoCity2;
		}
		set{
			__KstProxyGeoCity2 = value;
				if (value != null)
                {
                   this.__GuidParent = value.GuidCity;
                }else
                {
					                    this.__GuidParent = null;
					                }
		}
	}
	

	private KstProxyGeoState __KstProxyGeoState;
	[DataMember]
	public virtual KstProxyGeoState KstProxyGeoState {
		get{
			return __KstProxyGeoState;
		}
		set{
			__KstProxyGeoState = value;
				if (value != null)
                {
                   this.__GuidState = value.GuidState;
                }else
                {
					                    this.__GuidState = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidCity;
	[DataMember]
	
	public Guid GuidCity  { 
		get{
			return __GuidCity;
		}
		set{

			__GuidCity = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private Guid? __GuidState;
	[DataMember]
	
	public Guid? GuidState  { 
		get{
			return __GuidState;
		}
		set{

			__GuidState = value;
				if (value == null)
                {
                    this.__KstProxyGeoState = null;
                }else
                {
											if (this.__KstProxyGeoState != null && this.__KstProxyGeoState.GuidState != value.Value)
						{
							this.__KstProxyGeoState = new KstProxyGeoState() { GuidState = value.Value };

						}
                    //this.__KstProxyGeoState = new KstProxyGeoState() { GuidState = value.Value };
					  // if (this.__KstProxyGeoState == null )
                      //      this.__KstProxyGeoState = new KstProxyGeoState() {  GuidState = value.Value };
                      //  else {
                       //     if (this.__KstProxyGeoState.GuidState != value)
                       //     {
                       //     this.__KstProxyGeoState = new KstProxyGeoState() {  GuidState = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidParent;
	[DataMember]
	
	public Guid? GuidParent  { 
		get{
			return __GuidParent;
		}
		set{

			__GuidParent = value;
				if (value == null)
                {
                    this.__KstProxyGeoCity2 = null;
                }else
                {
											if (this.__KstProxyGeoCity2 != null && this.__KstProxyGeoCity2.GuidCity != value.Value)
						{
							this.__KstProxyGeoCity2 = new KstProxyGeoCity() { GuidCity = value.Value };

						}
                    //this.__KstProxyGeoCity2 = new KstProxyGeoCity() { GuidCity = value.Value };
					  // if (this.__KstProxyGeoCity2 == null )
                      //      this.__KstProxyGeoCity2 = new KstProxyGeoCity() {  GuidCity = value.Value };
                      //  else {
                       //     if (this.__KstProxyGeoCity2.GuidCity != value)
                       //     {
                       //     this.__KstProxyGeoCity2 = new KstProxyGeoCity() {  GuidCity = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProxyGeoCity";
		public static readonly string EntitySetName = "KstProxyGeoCities";
        public struct PropertyNames {
            public static readonly string GuidCity = "GuidCity";
            public static readonly string Name = "Name";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string GuidState = "GuidState";
            public static readonly string GuidParent = "GuidParent";
            public static readonly string KstProxyGeoCity1 = "KstProxyGeoCity1";
            public static readonly string KstProxyGeoCity2 = "KstProxyGeoCity2";
            public static readonly string KstProxyGeoState = "KstProxyGeoState";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidCountry",PropertyDefaultText="Name",RequiredProperties="Name",DeletedPropertyName="IsDeleted")]
	  [Table("KstProxyGeoCountry", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProxyGeoCountry:  ITrackable, IMyEntity{
	   public  KstProxyGeoCountry(Guid? guidCountry, String name)
        {
			if (guidCountry != null ){
            this.GuidCountry = guidCountry.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidCountry.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidCountry = Guid.Parse(value);
}
		}

		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstProxyGeoCountry()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProxyGeoCountry(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProxyGeoStates = new HashSet<KstProxyGeoState>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProxyGeoState> KstProxyGeoStates { get; set; }
	


//x1

	#endregion

	#region
	private Guid __GuidCountry;
	[DataMember]
	
	public Guid GuidCountry  { 
		get{
			return __GuidCountry;
		}
		set{

			__GuidCountry = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProxyGeoCountry";
		public static readonly string EntitySetName = "KstProxyGeoCountries";
        public struct PropertyNames {
            public static readonly string GuidCountry = "GuidCountry";
            public static readonly string Name = "Name";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string KstProxyGeoStates = "KstProxyGeoStates";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidState",PropertyDefaultText="Name",RequiredProperties="Name",DeletedPropertyName="IsDeleted")]
	  [Table("KstProxyGeoState", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProxyGeoState:  ITrackable, IMyEntity{
	   public  KstProxyGeoState(Guid? guidState, String name)
        {
			if (guidState != null ){
            this.GuidState = guidState.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidState.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidState = Guid.Parse(value);
}
		}

		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstProxyGeoState()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProxyGeoState(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProxyGeoCities = new HashSet<KstProxyGeoCity>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProxyGeoCity> KstProxyGeoCities { get; set; }
	


//x1
	private KstProxyGeoCountry __KstProxyGeoCountry;
	[DataMember]
	public virtual KstProxyGeoCountry KstProxyGeoCountry {
		get{
			return __KstProxyGeoCountry;
		}
		set{
			__KstProxyGeoCountry = value;
				if (value != null)
                {
                   this.__GuidCountry = value.GuidCountry;
                }else
                {
					                    this.__GuidCountry = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidState;
	[DataMember]
	
	public Guid GuidState  { 
		get{
			return __GuidState;
		}
		set{

			__GuidState = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private Guid? __GuidCountry;
	[DataMember]
	
	public Guid? GuidCountry  { 
		get{
			return __GuidCountry;
		}
		set{

			__GuidCountry = value;
				if (value == null)
                {
                    this.__KstProxyGeoCountry = null;
                }else
                {
											if (this.__KstProxyGeoCountry != null && this.__KstProxyGeoCountry.GuidCountry != value.Value)
						{
							this.__KstProxyGeoCountry = new KstProxyGeoCountry() { GuidCountry = value.Value };

						}
                    //this.__KstProxyGeoCountry = new KstProxyGeoCountry() { GuidCountry = value.Value };
					  // if (this.__KstProxyGeoCountry == null )
                      //      this.__KstProxyGeoCountry = new KstProxyGeoCountry() {  GuidCountry = value.Value };
                      //  else {
                       //     if (this.__KstProxyGeoCountry.GuidCountry != value)
                       //     {
                       //     this.__KstProxyGeoCountry = new KstProxyGeoCountry() {  GuidCountry = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProxyGeoState";
		public static readonly string EntitySetName = "KstProxyGeoStates";
        public struct PropertyNames {
            public static readonly string GuidState = "GuidState";
            public static readonly string Name = "Name";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string GuidCountry = "GuidCountry";
            public static readonly string KstProxyGeoCities = "KstProxyGeoCities";
            public static readonly string KstProxyGeoCountry = "KstProxyGeoCountry";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidActivity",PropertyDefaultText="Name",RequiredProperties="IsCustomByUser", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstActivity", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstActivity:  ITrackable, IMyEntity{
	   public  KstActivity(Guid? guidActivity, String name)
        {
			if (guidActivity != null ){
            this.GuidActivity = guidActivity.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidActivity.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidActivity = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstActivity()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstActivity(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstWorkTimes = new HashSet<KstWorkTime>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstWorkTime> KstWorkTimes { get; set; }
	


//x1
	private KstProject __KstProject;
	[DataMember]
	public virtual KstProject KstProject {
		get{
			return __KstProject;
		}
		set{
			__KstProject = value;
				if (value != null)
                {
                   this.__GuidProject = value.GuidProject;
                }else
                {
					                    this.__GuidProject = null;
					                }
		}
	}
	

	private KstActivityType __KstActivityType;
	[DataMember]
	public virtual KstActivityType KstActivityType {
		get{
			return __KstActivityType;
		}
		set{
			__KstActivityType = value;
				if (value != null)
                {
                   this.__GuidActivityType = value.GuidActivityType;
                }else
                {
					                    this.__GuidActivityType = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidActivity;
	[DataMember]
	
	public Guid GuidActivity  { 
		get{
			return __GuidActivity;
		}
		set{

			__GuidActivity = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Guid? __GuidProject;
	[DataMember]
	
	public Guid? GuidProject  { 
		get{
			return __GuidProject;
		}
		set{

			__GuidProject = value;
				if (value == null)
                {
                    this.__KstProject = null;
                }else
                {
											if (this.__KstProject != null && this.__KstProject.GuidProject != value.Value)
						{
							this.__KstProject = new KstProject() { GuidProject = value.Value };

						}
                    //this.__KstProject = new KstProject() { GuidProject = value.Value };
					  // if (this.__KstProject == null )
                      //      this.__KstProject = new KstProject() {  GuidProject = value.Value };
                      //  else {
                       //     if (this.__KstProject.GuidProject != value)
                       //     {
                       //     this.__KstProject = new KstProject() {  GuidProject = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Boolean __IsCustomByUser;
	[DataMember]
	
	public Boolean IsCustomByUser  { 
		get{
			return __IsCustomByUser;
		}
		set{

			__IsCustomByUser = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
	private Guid? __GuidActivityType;
	[DataMember]
	
	public Guid? GuidActivityType  { 
		get{
			return __GuidActivityType;
		}
		set{

			__GuidActivityType = value;
				if (value == null)
                {
                    this.__KstActivityType = null;
                }else
                {
											if (this.__KstActivityType != null && this.__KstActivityType.GuidActivityType != value.Value)
						{
							this.__KstActivityType = new KstActivityType() { GuidActivityType = value.Value };

						}
                    //this.__KstActivityType = new KstActivityType() { GuidActivityType = value.Value };
					  // if (this.__KstActivityType == null )
                      //      this.__KstActivityType = new KstActivityType() {  GuidActivityType = value.Value };
                      //  else {
                       //     if (this.__KstActivityType.GuidActivityType != value)
                       //     {
                       //     this.__KstActivityType = new KstActivityType() {  GuidActivityType = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstActivity";
		public static readonly string EntitySetName = "KstActivities";
        public struct PropertyNames {
            public static readonly string GuidActivity = "GuidActivity";
            public static readonly string Name = "Name";
            public static readonly string GuidProject = "GuidProject";
            public static readonly string IsCustomByUser = "IsCustomByUser";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string GuidActivityType = "GuidActivityType";
            public static readonly string KstProject = "KstProject";
            public static readonly string KstWorkTimes = "KstWorkTimes";
            public static readonly string KstActivityType = "KstActivityType";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidProject",PropertyDefaultText="Name",RequiredProperties="Name", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstProject", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProject:  ITrackable, IMyEntity{
	   public  KstProject(Guid? guidProject, String name)
        {
			if (guidProject != null ){
            this.GuidProject = guidProject.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidProject.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidProject = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstProject()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProject(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstActivities = new HashSet<KstActivity>();


	this.KstProjectUsers = new HashSet<KstProjectUser>();


	this.KstWorkTimes = new HashSet<KstWorkTime>();


	this.KstProjectFiles = new HashSet<KstProjectFile>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstActivity> KstActivities { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstProjectUser> KstProjectUsers { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstWorkTime> KstWorkTimes { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstProjectFile> KstProjectFiles { get; set; }
	


//x1

	#endregion

	#region
	private Guid __GuidProject;
	[DataMember]
	
	public Guid GuidProject  { 
		get{
			return __GuidProject;
		}
		set{

			__GuidProject = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
[NotMapped]
			[DataMember]
          	 public Int32? NumActivities { get; set; } //test

[NotMapped]
			[DataMember]
          	 public Int32? NumUsers { get; set; } //test

	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProject";
		public static readonly string EntitySetName = "KstProjects";
        public struct PropertyNames {
            public static readonly string GuidProject = "GuidProject";
            public static readonly string Name = "Name";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstActivities = "KstActivities";
            public static readonly string KstProjectUsers = "KstProjectUsers";
            public static readonly string KstWorkTimes = "KstWorkTimes";
            public static readonly string KstProjectFiles = "KstProjectFiles";
            public static readonly string NumActivities = "NumActivities";
            public static readonly string NumUsers = "NumUsers";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidProjectUser",PropertyDefaultText="BizKeyEngine", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstProjectUser", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProjectUser:  ITrackable, IMyEntity{
	   public  KstProjectUser(Guid? guidProjectUser, String bizKeyEngine)
        {
			if (guidProjectUser != null ){
            this.GuidProjectUser = guidProjectUser.Value;
            this.BizKeyEngine = bizKeyEngine;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidProjectUser.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidProjectUser = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.BizKeyEngine != null )		
            		return this.BizKeyEngine.ToString();
				else
					return String.Empty;
			}

		//public KstProjectUser()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProjectUser(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1
	private KstProject __KstProject;
	[DataMember]
	public virtual KstProject KstProject {
		get{
			return __KstProject;
		}
		set{
			__KstProject = value;
				if (value != null)
                {
                   this.__GuidProject = value.GuidProject;
                }else
                {
					                    this.__GuidProject = null;
					                }
		}
	}
	

	private KstProxyUser __KstProxyUser;
	[DataMember]
	public virtual KstProxyUser KstProxyUser {
		get{
			return __KstProxyUser;
		}
		set{
			__KstProxyUser = value;
				if (value != null)
                {
                   this.__GuidUser = value.GuidUser;
                }else
                {
					                    this.__GuidUser = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidProjectUser;
	[DataMember]
	
	public Guid GuidProjectUser  { 
		get{
			return __GuidProjectUser;
		}
		set{

			__GuidProjectUser = value;
			
		}
	 }
	private Guid? __GuidProject;
	[DataMember]
	
	public Guid? GuidProject  { 
		get{
			return __GuidProject;
		}
		set{

			__GuidProject = value;
				if (value == null)
                {
                    this.__KstProject = null;
                }else
                {
											if (this.__KstProject != null && this.__KstProject.GuidProject != value.Value)
						{
							this.__KstProject = new KstProject() { GuidProject = value.Value };

						}
                    //this.__KstProject = new KstProject() { GuidProject = value.Value };
					  // if (this.__KstProject == null )
                      //      this.__KstProject = new KstProject() {  GuidProject = value.Value };
                      //  else {
                       //     if (this.__KstProject.GuidProject != value)
                       //     {
                       //     this.__KstProject = new KstProject() {  GuidProject = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidUser;
	[DataMember]
	
	public Guid? GuidUser  { 
		get{
			return __GuidUser;
		}
		set{

			__GuidUser = value;
				if (value == null)
                {
                    this.__KstProxyUser = null;
                }else
                {
											if (this.__KstProxyUser != null && this.__KstProxyUser.GuidUser != value.Value)
						{
							this.__KstProxyUser = new KstProxyUser() { GuidUser = value.Value };

						}
                    //this.__KstProxyUser = new KstProxyUser() { GuidUser = value.Value };
					  // if (this.__KstProxyUser == null )
                      //      this.__KstProxyUser = new KstProxyUser() {  GuidUser = value.Value };
                      //  else {
                       //     if (this.__KstProxyUser.GuidUser != value)
                       //     {
                       //     this.__KstProxyUser = new KstProxyUser() {  GuidUser = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private DateTime? __StartDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? StartDate  { 
		get{
			return __StartDate;
		}
		set{

			__StartDate = value;
			
		}
	 }
	private DateTime? __EndDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? EndDate  { 
		get{
			return __EndDate;
		}
		set{

			__EndDate = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProjectUser";
		public static readonly string EntitySetName = "KstProjectUsers";
        public struct PropertyNames {
            public static readonly string GuidProjectUser = "GuidProjectUser";
            public static readonly string GuidProject = "GuidProject";
            public static readonly string GuidUser = "GuidUser";
            public static readonly string StartDate = "StartDate";
            public static readonly string EndDate = "EndDate";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstProject = "KstProject";
            public static readonly string KstProxyUser = "KstProxyUser";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidWorkTime",PropertyDefaultText="Title", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstWorkTime", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstWorkTime:  ITrackable, IMyEntity{
	   public  KstWorkTime(Guid? guidWorkTime, String title)
        {
			if (guidWorkTime != null ){
            this.GuidWorkTime = guidWorkTime.Value;
            this.Title = title;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidWorkTime.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidWorkTime = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Title != null )		
            		return this.Title.ToString();
				else
					return String.Empty;
			}

		//public KstWorkTime()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstWorkTime(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstWorkTimeFiles = new HashSet<KstWorkTimeFile>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstWorkTimeFile> KstWorkTimeFiles { get; set; }
	


//x1
	private KstActivity __KstActivity;
	[DataMember]
	public virtual KstActivity KstActivity {
		get{
			return __KstActivity;
		}
		set{
			__KstActivity = value;
				if (value != null)
                {
                   this.__GuidActivity = value.GuidActivity;
                }else
                {
					                    this.__GuidActivity = null;
					                }
		}
	}
	

	private KstProject __KstProject;
	[DataMember]
	public virtual KstProject KstProject {
		get{
			return __KstProject;
		}
		set{
			__KstProject = value;
				if (value != null)
                {
                   this.__GuidProject = value.GuidProject;
                }else
                {
					                    this.__GuidProject = null;
					                }
		}
	}
	

	private KstActivityType __KstActivityType;
	[DataMember]
	public virtual KstActivityType KstActivityType {
		get{
			return __KstActivityType;
		}
		set{
			__KstActivityType = value;
				if (value != null)
                {
                   this.__GuidActivityType = value.GuidActivityType;
                }else
                {
					                    this.__GuidActivityType = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidWorkTime;
	[DataMember]
	
	public Guid GuidWorkTime  { 
		get{
			return __GuidWorkTime;
		}
		set{

			__GuidWorkTime = value;
			
		}
	 }
	private String __Title;
	[DataMember]
	
	public String Title  { 
		get{
			return __Title;
		}
		set{

			__Title = value;
			
		}
	 }
	private String __Comments;
	[DataMember]
	
	public String Comments  { 
		get{
			return __Comments;
		}
		set{

			__Comments = value;
			
		}
	 }
	private Decimal? __Hours;
	[DataMember]
	
	public Decimal? Hours  { 
		get{
			return __Hours;
		}
		set{

			__Hours = value;
			
		}
	 }
	private Guid? __GuidProject;
	[DataMember]
	
	public Guid? GuidProject  { 
		get{
			return __GuidProject;
		}
		set{

			__GuidProject = value;
				if (value == null)
                {
                    this.__KstProject = null;
                }else
                {
											if (this.__KstProject != null && this.__KstProject.GuidProject != value.Value)
						{
							this.__KstProject = new KstProject() { GuidProject = value.Value };

						}
                    //this.__KstProject = new KstProject() { GuidProject = value.Value };
					  // if (this.__KstProject == null )
                      //      this.__KstProject = new KstProject() {  GuidProject = value.Value };
                      //  else {
                       //     if (this.__KstProject.GuidProject != value)
                       //     {
                       //     this.__KstProject = new KstProject() {  GuidProject = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidActivity;
	[DataMember]
	
	public Guid? GuidActivity  { 
		get{
			return __GuidActivity;
		}
		set{

			__GuidActivity = value;
				if (value == null)
                {
                    this.__KstActivity = null;
                }else
                {
											if (this.__KstActivity != null && this.__KstActivity.GuidActivity != value.Value)
						{
							this.__KstActivity = new KstActivity() { GuidActivity = value.Value };

						}
                    //this.__KstActivity = new KstActivity() { GuidActivity = value.Value };
					  // if (this.__KstActivity == null )
                      //      this.__KstActivity = new KstActivity() {  GuidActivity = value.Value };
                      //  else {
                       //     if (this.__KstActivity.GuidActivity != value)
                       //     {
                       //     this.__KstActivity = new KstActivity() {  GuidActivity = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
	private DateTime? __DueDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? DueDate  { 
		get{
			return __DueDate;
		}
		set{

			__DueDate = value;
			
		}
	 }
	private Guid? __GuidActivityType;
	[DataMember]
	
	public Guid? GuidActivityType  { 
		get{
			return __GuidActivityType;
		}
		set{

			__GuidActivityType = value;
				if (value == null)
                {
                    this.__KstActivityType = null;
                }else
                {
											if (this.__KstActivityType != null && this.__KstActivityType.GuidActivityType != value.Value)
						{
							this.__KstActivityType = new KstActivityType() { GuidActivityType = value.Value };

						}
                    //this.__KstActivityType = new KstActivityType() { GuidActivityType = value.Value };
					  // if (this.__KstActivityType == null )
                      //      this.__KstActivityType = new KstActivityType() {  GuidActivityType = value.Value };
                      //  else {
                       //     if (this.__KstActivityType.GuidActivityType != value)
                       //     {
                       //     this.__KstActivityType = new KstActivityType() {  GuidActivityType = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstWorkTime";
		public static readonly string EntitySetName = "KstWorkTimes";
        public struct PropertyNames {
            public static readonly string GuidWorkTime = "GuidWorkTime";
            public static readonly string Title = "Title";
            public static readonly string Comments = "Comments";
            public static readonly string Hours = "Hours";
            public static readonly string GuidProject = "GuidProject";
            public static readonly string GuidActivity = "GuidActivity";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string DueDate = "DueDate";
            public static readonly string GuidActivityType = "GuidActivityType";
            public static readonly string KstActivity = "KstActivity";
            public static readonly string KstProject = "KstProject";
            public static readonly string KstWorkTimeFiles = "KstWorkTimeFiles";
            public static readonly string KstActivityType = "KstActivityType";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidFile",PropertyDefaultText="FileName",RequiredProperties="FileName", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstFile", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstFile:  ITrackable, IMyEntity{
	   public  KstFile(Guid? guidFile, String fileName)
        {
			if (guidFile != null ){
            this.GuidFile = guidFile.Value;
            this.FileName = fileName;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidFile.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidFile = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.FileName != null )		
            		return this.FileName.ToString();
				else
					return String.Empty;
			}

		//public KstFile()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstFile(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProjectFiles = new HashSet<KstProjectFile>();


	this.KstUserFiles = new HashSet<KstUserFile>();


	this.KstWorkTimeFiles = new HashSet<KstWorkTimeFile>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProjectFile> KstProjectFiles { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstUserFile> KstUserFiles { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstWorkTimeFile> KstWorkTimeFiles { get; set; }
	


//x1

	#endregion

	#region
	private Guid __GuidFile;
	[DataMember]
	
	public Guid GuidFile  { 
		get{
			return __GuidFile;
		}
		set{

			__GuidFile = value;
			
		}
	 }
	private String __FileName;
	[DataMember]
	
	public String FileName  { 
		get{
			return __FileName;
		}
		set{

			__FileName = value;
			
		}
	 }
	private String __FileType;
	[DataMember]
	
	public String FileType  { 
		get{
			return __FileType;
		}
		set{

			__FileType = value;
			
		}
	 }
	private Byte[] __FileData;
	[DataMember]
	
	public Byte[] FileData  { 
		get{
			return __FileData;
		}
		set{

			__FileData = value;
			
		}
	 }
	private String __FileStorage;
	[DataMember]
	
	public String FileStorage  { 
		get{
			return __FileStorage;
		}
		set{

			__FileStorage = value;
			
		}
	 }
	private String __ContainerStorage;
	[DataMember]
	
	public String ContainerStorage  { 
		get{
			return __ContainerStorage;
		}
		set{

			__ContainerStorage = value;
			
		}
	 }
	private String __FileThumbSizes;
	[DataMember]
	
	public String FileThumbSizes  { 
		get{
			return __FileThumbSizes;
		}
		set{

			__FileThumbSizes = value;
			
		}
	 }
	private Int64? __FileSize;
	[DataMember]
	
	public Int64? FileSize  { 
		get{
			return __FileSize;
		}
		set{

			__FileSize = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstFile";
		public static readonly string EntitySetName = "KstFiles";
        public struct PropertyNames {
            public static readonly string GuidFile = "GuidFile";
            public static readonly string FileName = "FileName";
            public static readonly string FileType = "FileType";
            public static readonly string FileData = "FileData";
            public static readonly string FileStorage = "FileStorage";
            public static readonly string ContainerStorage = "ContainerStorage";
            public static readonly string FileThumbSizes = "FileThumbSizes";
            public static readonly string FileSize = "FileSize";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstProjectFiles = "KstProjectFiles";
            public static readonly string KstUserFiles = "KstUserFiles";
            public static readonly string KstWorkTimeFiles = "KstWorkTimeFiles";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidProjectFile",PropertyDefaultText="BizKeyEngine", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstProjectFile", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProjectFile:  ITrackable, IMyEntity{
	   public  KstProjectFile(Guid? guidProjectFile, String bizKeyEngine)
        {
			if (guidProjectFile != null ){
            this.GuidProjectFile = guidProjectFile.Value;
            this.BizKeyEngine = bizKeyEngine;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidProjectFile.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidProjectFile = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.BizKeyEngine != null )		
            		return this.BizKeyEngine.ToString();
				else
					return String.Empty;
			}

		//public KstProjectFile()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProjectFile(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1
	private KstFile __KstFile;
	[DataMember]
	public virtual KstFile KstFile {
		get{
			return __KstFile;
		}
		set{
			__KstFile = value;
				if (value != null)
                {
                   this.__GuidFile = value.GuidFile;
                }else
                {
					                    this.__GuidFile = null;
					                }
		}
	}
	

	private KstProject __KstProject;
	[DataMember]
	public virtual KstProject KstProject {
		get{
			return __KstProject;
		}
		set{
			__KstProject = value;
				if (value != null)
                {
                   this.__GuidProject = value.GuidProject;
                }else
                {
					                    this.__GuidProject = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidProjectFile;
	[DataMember]
	
	public Guid GuidProjectFile  { 
		get{
			return __GuidProjectFile;
		}
		set{

			__GuidProjectFile = value;
			
		}
	 }
	private Guid? __GuidProject;
	[DataMember]
	
	public Guid? GuidProject  { 
		get{
			return __GuidProject;
		}
		set{

			__GuidProject = value;
				if (value == null)
                {
                    this.__KstProject = null;
                }else
                {
											if (this.__KstProject != null && this.__KstProject.GuidProject != value.Value)
						{
							this.__KstProject = new KstProject() { GuidProject = value.Value };

						}
                    //this.__KstProject = new KstProject() { GuidProject = value.Value };
					  // if (this.__KstProject == null )
                      //      this.__KstProject = new KstProject() {  GuidProject = value.Value };
                      //  else {
                       //     if (this.__KstProject.GuidProject != value)
                       //     {
                       //     this.__KstProject = new KstProject() {  GuidProject = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidFile;
	[DataMember]
	
	public Guid? GuidFile  { 
		get{
			return __GuidFile;
		}
		set{

			__GuidFile = value;
				if (value == null)
                {
                    this.__KstFile = null;
                }else
                {
											if (this.__KstFile != null && this.__KstFile.GuidFile != value.Value)
						{
							this.__KstFile = new KstFile() { GuidFile = value.Value };

						}
                    //this.__KstFile = new KstFile() { GuidFile = value.Value };
					  // if (this.__KstFile == null )
                      //      this.__KstFile = new KstFile() {  GuidFile = value.Value };
                      //  else {
                       //     if (this.__KstFile.GuidFile != value)
                       //     {
                       //     this.__KstFile = new KstFile() {  GuidFile = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProjectFile";
		public static readonly string EntitySetName = "KstProjectFiles";
        public struct PropertyNames {
            public static readonly string GuidProjectFile = "GuidProjectFile";
            public static readonly string GuidProject = "GuidProject";
            public static readonly string GuidFile = "GuidFile";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstFile = "KstFile";
            public static readonly string KstProject = "KstProject";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidUserFile",PropertyDefaultText="BizKeyEngine", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstUserFile", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstUserFile:  ITrackable, IMyEntity{
	   public  KstUserFile(Guid? guidUserFile, String bizKeyEngine)
        {
			if (guidUserFile != null ){
            this.GuidUserFile = guidUserFile.Value;
            this.BizKeyEngine = bizKeyEngine;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidUserFile.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidUserFile = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.BizKeyEngine != null )		
            		return this.BizKeyEngine.ToString();
				else
					return String.Empty;
			}

		//public KstUserFile()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstUserFile(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1
	private KstFile __KstFile;
	[DataMember]
	public virtual KstFile KstFile {
		get{
			return __KstFile;
		}
		set{
			__KstFile = value;
				if (value != null)
                {
                   this.__GuidFile = value.GuidFile;
                }else
                {
					                    this.__GuidFile = null;
					                }
		}
	}
	

	private KstProxyUser __KstProxyUser;
	[DataMember]
	public virtual KstProxyUser KstProxyUser {
		get{
			return __KstProxyUser;
		}
		set{
			__KstProxyUser = value;
				if (value != null)
                {
                   this.__GuidUser = value.GuidUser;
                }else
                {
					                    this.__GuidUser = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidUserFile;
	[DataMember]
	
	public Guid GuidUserFile  { 
		get{
			return __GuidUserFile;
		}
		set{

			__GuidUserFile = value;
			
		}
	 }
	private Guid? __GuidUser;
	[DataMember]
	
	public Guid? GuidUser  { 
		get{
			return __GuidUser;
		}
		set{

			__GuidUser = value;
				if (value == null)
                {
                    this.__KstProxyUser = null;
                }else
                {
											if (this.__KstProxyUser != null && this.__KstProxyUser.GuidUser != value.Value)
						{
							this.__KstProxyUser = new KstProxyUser() { GuidUser = value.Value };

						}
                    //this.__KstProxyUser = new KstProxyUser() { GuidUser = value.Value };
					  // if (this.__KstProxyUser == null )
                      //      this.__KstProxyUser = new KstProxyUser() {  GuidUser = value.Value };
                      //  else {
                       //     if (this.__KstProxyUser.GuidUser != value)
                       //     {
                       //     this.__KstProxyUser = new KstProxyUser() {  GuidUser = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidFile;
	[DataMember]
	
	public Guid? GuidFile  { 
		get{
			return __GuidFile;
		}
		set{

			__GuidFile = value;
				if (value == null)
                {
                    this.__KstFile = null;
                }else
                {
											if (this.__KstFile != null && this.__KstFile.GuidFile != value.Value)
						{
							this.__KstFile = new KstFile() { GuidFile = value.Value };

						}
                    //this.__KstFile = new KstFile() { GuidFile = value.Value };
					  // if (this.__KstFile == null )
                      //      this.__KstFile = new KstFile() {  GuidFile = value.Value };
                      //  else {
                       //     if (this.__KstFile.GuidFile != value)
                       //     {
                       //     this.__KstFile = new KstFile() {  GuidFile = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Boolean? __IsProfileDefault;
	[DataMember]
	
	public Boolean? IsProfileDefault  { 
		get{
			return __IsProfileDefault;
		}
		set{

			__IsProfileDefault = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstUserFile";
		public static readonly string EntitySetName = "KstUserFiles";
        public struct PropertyNames {
            public static readonly string GuidUserFile = "GuidUserFile";
            public static readonly string GuidUser = "GuidUser";
            public static readonly string GuidFile = "GuidFile";
            public static readonly string IsProfileDefault = "IsProfileDefault";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstFile = "KstFile";
            public static readonly string KstProxyUser = "KstProxyUser";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidWorkTimeFile",PropertyDefaultText="BizKeyEngine", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstWorkTimeFile", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstWorkTimeFile:  ITrackable, IMyEntity{
	   public  KstWorkTimeFile(Guid? guidWorkTimeFile, String bizKeyEngine)
        {
			if (guidWorkTimeFile != null ){
            this.GuidWorkTimeFile = guidWorkTimeFile.Value;
            this.BizKeyEngine = bizKeyEngine;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidWorkTimeFile.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidWorkTimeFile = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.BizKeyEngine != null )		
            		return this.BizKeyEngine.ToString();
				else
					return String.Empty;
			}

		//public KstWorkTimeFile()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstWorkTimeFile(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1
	private KstFile __KstFile;
	[DataMember]
	public virtual KstFile KstFile {
		get{
			return __KstFile;
		}
		set{
			__KstFile = value;
				if (value != null)
                {
                   this.__GuidFile = value.GuidFile;
                }else
                {
					                    this.__GuidFile = null;
					                }
		}
	}
	

	private KstWorkTime __KstWorkTime;
	[DataMember]
	public virtual KstWorkTime KstWorkTime {
		get{
			return __KstWorkTime;
		}
		set{
			__KstWorkTime = value;
				if (value != null)
                {
                   this.__GuidWorkTime = value.GuidWorkTime;
                }else
                {
					                    this.__GuidWorkTime = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidWorkTimeFile;
	[DataMember]
	
	public Guid GuidWorkTimeFile  { 
		get{
			return __GuidWorkTimeFile;
		}
		set{

			__GuidWorkTimeFile = value;
			
		}
	 }
	private Guid? __GuidWorkTime;
	[DataMember]
	
	public Guid? GuidWorkTime  { 
		get{
			return __GuidWorkTime;
		}
		set{

			__GuidWorkTime = value;
				if (value == null)
                {
                    this.__KstWorkTime = null;
                }else
                {
											if (this.__KstWorkTime != null && this.__KstWorkTime.GuidWorkTime != value.Value)
						{
							this.__KstWorkTime = new KstWorkTime() { GuidWorkTime = value.Value };

						}
                    //this.__KstWorkTime = new KstWorkTime() { GuidWorkTime = value.Value };
					  // if (this.__KstWorkTime == null )
                      //      this.__KstWorkTime = new KstWorkTime() {  GuidWorkTime = value.Value };
                      //  else {
                       //     if (this.__KstWorkTime.GuidWorkTime != value)
                       //     {
                       //     this.__KstWorkTime = new KstWorkTime() {  GuidWorkTime = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidFile;
	[DataMember]
	
	public Guid? GuidFile  { 
		get{
			return __GuidFile;
		}
		set{

			__GuidFile = value;
				if (value == null)
                {
                    this.__KstFile = null;
                }else
                {
											if (this.__KstFile != null && this.__KstFile.GuidFile != value.Value)
						{
							this.__KstFile = new KstFile() { GuidFile = value.Value };

						}
                    //this.__KstFile = new KstFile() { GuidFile = value.Value };
					  // if (this.__KstFile == null )
                      //      this.__KstFile = new KstFile() {  GuidFile = value.Value };
                      //  else {
                       //     if (this.__KstFile.GuidFile != value)
                       //     {
                       //     this.__KstFile = new KstFile() {  GuidFile = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstWorkTimeFile";
		public static readonly string EntitySetName = "KstWorkTimeFiles";
        public struct PropertyNames {
            public static readonly string GuidWorkTimeFile = "GuidWorkTimeFile";
            public static readonly string GuidWorkTime = "GuidWorkTime";
            public static readonly string GuidFile = "GuidFile";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstFile = "KstFile";
            public static readonly string KstWorkTime = "KstWorkTime";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidRole",PropertyDefaultText="RoleName",RequiredProperties="RoleName,NameKey",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstProxyRole", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProxyRole:  ITrackable, IMyEntity{
	   public  KstProxyRole(Guid? guidRole, String roleName)
        {
			if (guidRole != null ){
            this.GuidRole = guidRole.Value;
            this.RoleName = roleName;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidRole.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidRole = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.RoleName != null )		
            		return this.RoleName.ToString();
				else
					return String.Empty;
			}

		//public KstProxyRole()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProxyRole(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProxyUsers = new HashSet<KstProxyUser>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProxyUser> KstProxyUsers { get; set; }
	


//x1

	#endregion

	#region
	private Guid __GuidRole;
	[DataMember]
	
	public Guid GuidRole  { 
		get{
			return __GuidRole;
		}
		set{

			__GuidRole = value;
			
		}
	 }
	private String __RoleName;
	[DataMember]
	
	public String RoleName  { 
		get{
			return __RoleName;
		}
		set{

			__RoleName = value;
			
		}
	 }
	private String __NameKey;
	[DataMember]
	
	public String NameKey  { 
		get{
			return __NameKey;
		}
		set{

			__NameKey = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProxyRole";
		public static readonly string EntitySetName = "KstProxyRoles";
        public struct PropertyNames {
            public static readonly string GuidRole = "GuidRole";
            public static readonly string RoleName = "RoleName";
            public static readonly string NameKey = "NameKey";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string KstProxyUsers = "KstProxyUsers";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidUser",PropertyDefaultText="DisplayName",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstProxyUser", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstProxyUser:  ITrackable, IMyEntity{
	   public  KstProxyUser(Guid? guidUser, String displayName)
        {
			if (guidUser != null ){
            this.GuidUser = guidUser.Value;
            this.DisplayName = displayName;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidUser.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidUser = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.DisplayName != null )		
            		return this.DisplayName.ToString();
				else
					return String.Empty;
			}

		//public KstProxyUser()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstProxyUser(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstProjectUsers = new HashSet<KstProjectUser>();


	this.KstUserFiles = new HashSet<KstUserFile>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstProjectUser> KstProjectUsers { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstUserFile> KstUserFiles { get; set; }
	


//x1
	private KstProxyRole __KstProxyRole;
	[DataMember]
	public virtual KstProxyRole KstProxyRole {
		get{
			return __KstProxyRole;
		}
		set{
			__KstProxyRole = value;
				if (value != null)
                {
                   this.__GuidRole = value.GuidRole;
                }else
                {
					                    this.__GuidRole = null;
					                }
		}
	}
	


	#endregion

	#region
	private Guid __GuidUser;
	[DataMember]
	
	public Guid GuidUser  { 
		get{
			return __GuidUser;
		}
		set{

			__GuidUser = value;
			
		}
	 }
	private String __DisplayName;
	[DataMember]
	
	public String DisplayName  { 
		get{
			return __DisplayName;
		}
		set{

			__DisplayName = value;
			
		}
	 }
	private String __Username;
	[DataMember]
	
	public String Username  { 
		get{
			return __Username;
		}
		set{

			__Username = value;
			
		}
	 }
	private String __Password;
	[DataMember]
	
	public String Password  { 
		get{
			return __Password;
		}
		set{

			__Password = value;
			
		}
	 }
	private String __FirstName;
	[DataMember]
	
	public String FirstName  { 
		get{
			return __FirstName;
		}
		set{

			__FirstName = value;
			
		}
	 }
	private String __LastName;
	[DataMember]
	
	public String LastName  { 
		get{
			return __LastName;
		}
		set{

			__LastName = value;
			
		}
	 }
	private String __Email;
	[DataMember]
	
	public String Email  { 
		get{
			return __Email;
		}
		set{

			__Email = value;
			
		}
	 }
	private Guid? __GuidRole;
	[DataMember]
	
	public Guid? GuidRole  { 
		get{
			return __GuidRole;
		}
		set{

			__GuidRole = value;
				if (value == null)
                {
                    this.__KstProxyRole = null;
                }else
                {
											if (this.__KstProxyRole != null && this.__KstProxyRole.GuidRole != value.Value)
						{
							this.__KstProxyRole = new KstProxyRole() { GuidRole = value.Value };

						}
                    //this.__KstProxyRole = new KstProxyRole() { GuidRole = value.Value };
					  // if (this.__KstProxyRole == null )
                      //      this.__KstProxyRole = new KstProxyRole() {  GuidRole = value.Value };
                      //  else {
                       //     if (this.__KstProxyRole.GuidRole != value)
                       //     {
                       //     this.__KstProxyRole = new KstProxyRole() {  GuidRole = value.Value };
					//		}
                     //   }
					                }
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private Boolean? __Disabled;
	[DataMember]
	
	public Boolean? Disabled  { 
		get{
			return __Disabled;
		}
		set{

			__Disabled = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstProxyUser";
		public static readonly string EntitySetName = "KstProxyUsers";
        public struct PropertyNames {
            public static readonly string GuidUser = "GuidUser";
            public static readonly string DisplayName = "DisplayName";
            public static readonly string Username = "Username";
            public static readonly string Password = "Password";
            public static readonly string FirstName = "FirstName";
            public static readonly string LastName = "LastName";
            public static readonly string Email = "Email";
            public static readonly string GuidRole = "GuidRole";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string Disabled = "Disabled";
            public static readonly string KstProjectUsers = "KstProjectUsers";
            public static readonly string KstProxyRole = "KstProxyRole";
            public static readonly string KstUserFiles = "KstUserFiles";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidActivityType",PropertyDefaultText="Name", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [Table("KstActivityType", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
	  public partial class KstActivityType:  ITrackable, IMyEntity{
	   public  KstActivityType(Guid? guidActivityType, String name)
        {
			if (guidActivityType != null ){
            this.GuidActivityType = guidActivityType.Value;
            this.Name = name;

			}
        }
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidActivityType.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidActivityType = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
			[NotMapped]
            public double? _CreatedDateTS
            {
                get
                {
                    if (this.CreatedDate != null)
                    {
                        return (this.CreatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public KstActivityType()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public KstActivityType(){
		#region 
			this.ModifiedProperties = new List<string>();
	this.KstActivities = new HashSet<KstActivity>();


	this.KstWorkTimes = new HashSet<KstWorkTime>();


		#endregion
		}
		#region
	
	//[DataMember]
	public virtual ICollection<KstActivity> KstActivities { get; set; }
	

	
	//[DataMember]
	public virtual ICollection<KstWorkTime> KstWorkTimes { get; set; }
	


//x1

	#endregion

	#region
	private Guid __GuidActivityType;
	[DataMember]
	
	public Guid GuidActivityType  { 
		get{
			return __GuidActivityType;
		}
		set{

			__GuidActivityType = value;
			
		}
	 }
	private String __Name;
	[DataMember]
	
	public String Name  { 
		get{
			return __Name;
		}
		set{

			__Name = value;
			
		}
	 }
	private Guid? __GuidCompany;
	[DataMember]
	
	public Guid? GuidCompany  { 
		get{
			return __GuidCompany;
		}
		set{

			__GuidCompany = value;
			
		}
	 }
	private Guid? __CreatedBy;
	[DataMember]
	
	public Guid? CreatedBy  { 
		get{
			return __CreatedBy;
		}
		set{

			__CreatedBy = value;
			
		}
	 }
	private Guid? __UpdatedBy;
	[DataMember]
	
	public Guid? UpdatedBy  { 
		get{
			return __UpdatedBy;
		}
		set{

			__UpdatedBy = value;
			
		}
	 }
	private Boolean? __IsDeleted;
	[DataMember]
	
	public Boolean? IsDeleted  { 
		get{
			return __IsDeleted;
		}
		set{

			__IsDeleted = value;
			
		}
	 }
	private String __BizKeyEngine;
	[DataMember]
	
	public String BizKeyEngine  { 
		get{
			return __BizKeyEngine;
		}
		set{

			__BizKeyEngine = value;
			
		}
	 }
	private DateTime? __CreatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? CreatedDate  { 
		get{
			return __CreatedDate;
		}
		set{

			__CreatedDate = value;
			
		}
	 }
	private DateTime? __UpdatedDate;
	[DataMember]
	[Column(TypeName = "datetime")]
	public DateTime? UpdatedDate  { 
		get{
			return __UpdatedDate;
		}
		set{

			__UpdatedDate = value;
			
		}
	 }
	private Int32? __Bytes;
	[DataMember]
	
	public Int32? Bytes  { 
		get{
			return __Bytes;
		}
		set{

			__Bytes = value;
			
		}
	 }
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      


	      #region propertyNames
		public static readonly string EntityName = "KstActivityType";
		public static readonly string EntitySetName = "KstActivityTypes";
        public struct PropertyNames {
            public static readonly string GuidActivityType = "GuidActivityType";
            public static readonly string Name = "Name";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string IsDeleted = "IsDeleted";
            public static readonly string BizKeyEngine = "BizKeyEngine";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string Bytes = "Bytes";
            public static readonly string KstActivities = "KstActivities";
            public static readonly string KstWorkTimes = "KstWorkTimes";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidBusinessObject",PropertyDefaultText="Name")]
	  [Table("unProxyBusinessObject", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
		[NotMapped]
	  public partial class unProxyBusinessObject:  ITrackable, IMyEntity{
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidBusinessObject.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidBusinessObject = Guid.Parse(value);
}
		}

		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public unProxyBusinessObject()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public unProxyBusinessObject(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1

	#endregion

	#region
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      
			[DataMember]
			//[System.Xml.Serialization.SoapIgnoreAttribute()]
			//[System.Xml.Serialization.XmlIgnoreAttribute()]
			public Guid GuidBusinessObject { get; set; }
			[DataMember]
          	 public String Name { get; set; }
			[DataMember]
          	 public String BusinessObjectKey { get; set; }
			[DataMember]
          	 public String EntitySetName { get; set; }


	      #region propertyNames
		public static readonly string EntityName = "unProxyBusinessObject";
		public static readonly string _EntitySetName = "unProxyBusinessObjects";
        public struct PropertyNames {
            public static readonly string GuidBusinessObject = "GuidBusinessObject";
            public static readonly string Name = "Name";
            public static readonly string BusinessObjectKey = "BusinessObjectKey";
            public static readonly string EntitySetName = "EntitySetName";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidUnProxyEvent",PropertyDefaultText="Title",UpdatedDatePropertyName="UpdatedDate")]
	  [Table("unProxyEvent", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
		[NotMapped]
	  public partial class unProxyEvent:  ITrackable, IMyEntity{
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidUnProxyEvent.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidUnProxyEvent = Guid.Parse(value);
}
		}

			[NotMapped]
            public double? _UpdatedDateTS
            {
                get
                {
                    if (this.UpdatedDate != null)
                    {
                        return (this.UpdatedDate.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    }else
                    {
                        return null;
                    }
                }
            }
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Title != null )		
            		return this.Title.ToString();
				else
					return String.Empty;
			}

		//public unProxyEvent()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public unProxyEvent(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1

	#endregion

	#region
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      
			[DataMember]
			//[System.Xml.Serialization.SoapIgnoreAttribute()]
			//[System.Xml.Serialization.XmlIgnoreAttribute()]
			public Guid GuidUnProxyEvent { get; set; }
			[DataMember]
          	 public String Title { get; set; }
			[DataMember]
          	 public String Message { get; set; }
			[DataMember]
          	 public String TypeEvent { get; set; }
			[DataMember]
          	 public Boolean? IsException { get; set; }
			[DataMember]
          	 public DateTime? UpdatedDate { get; set; }


	      #region propertyNames
		public static readonly string EntityName = "unProxyEvent";
		public static readonly string EntitySetName = "unProxyEvents";
        public struct PropertyNames {
            public static readonly string GuidUnProxyEvent = "GuidUnProxyEvent";
            public static readonly string Title = "Title";
            public static readonly string Message = "Message";
            public static readonly string TypeEvent = "TypeEvent";
            public static readonly string IsException = "IsException";
            public static readonly string UpdatedDate = "UpdatedDate";
		}
		#endregion
	}
		  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidUnProxySetting",PropertyDefaultText="SMTPServer")]
	  [Table("unProxySetting", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
		[NotMapped]
	  public partial class unProxySetting:  ITrackable, IMyEntity{
      [NotMapped]
	  public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidUnProxySetting.ToString());
                      return sb.ToString();
                } 
set{
	this.GuidUnProxySetting = Guid.Parse(value);
}
		}

		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.SMTPServer != null )		
            		return this.SMTPServer.ToString();
				else
					return String.Empty;
			}

		//public unProxySetting()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public unProxySetting(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1
            
				
	[DataMember]
          	 public Guid? SMTPServerId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPSSLEnabledId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPUserId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPPasswordId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPFromNameId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPPortId { get; set; }
            
				
	[DataMember]
          	 public Guid? SMTPFromEmailId { get; set; }
            
				
	[DataMember]
          	 public Guid? AzureBlobStorageConnectionId { get; set; }
            
				
	[DataMember]
          	 public Guid? SaveBlobInAzureStorageId { get; set; }
            
				
	[DataMember]
          	 public Guid? SaveBlobInDataBaseId { get; set; }
            
				
	[DataMember]
          	 public Guid? UserNameGeoNamesId { get; set; }
            
				
	[DataMember]
          	 public Guid? EngineURLId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_API_KEYId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_URLId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_USERId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_PWDId { get; set; }
            
				
	[DataMember]
          	 public Guid? KM_MAXIMOId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAP_KEYId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_OAUTH_CLIENT_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_OAUTH_LOGIN_URLId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_OAUTH_USERNAMEId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_OAUTH_PASSWORDId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_OAUTH_CLIENT_SECRETId { get; set; }
            
				
	[DataMember]
          	 public Guid? ENGINE_DEFINITION_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_DATOS_CLIENTE_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_DOCUMENTOS_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_DIRECCION_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_DATOS_FINANCIEROS_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_BENEFICIARIOS_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_CONTRATOS_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? CONTAINER_APROBACION_IDId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_CONTRATO_TEMPLATEIDId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_CARATULA_TEMPLATEIDId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_PAGARE_TEMPLATEIDId { get; set; }
            
				
	[DataMember]
          	 public Guid? MAMBU_REFERENCIASPAGO_TEMPLATEIDId { get; set; }
            
				
	[DataMember]
          	 public Guid? MATI_AUTH_HEADERId { get; set; }
            
				
	[DataMember]
          	 public Guid? WEBBHOOK_MATI_KEYId { get; set; }

	#endregion

	#region
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      
			[DataMember]
			//[System.Xml.Serialization.SoapIgnoreAttribute()]
			//[System.Xml.Serialization.XmlIgnoreAttribute()]
			public Guid GuidUnProxySetting { get; set; }
			[DataMember]
          	 public String SMTPServer { get; set; }
			[DataMember]
          	 public Boolean? SMTPSSLEnabled { get; set; }
			[DataMember]
          	 public String SMTPUser { get; set; }
			[DataMember]
          	 public String SMTPPassword { get; set; }
			[DataMember]
          	 public String SMTPFromName { get; set; }
			[DataMember]
          	 public String SMTPPort { get; set; }
			[DataMember]
          	 public String SMTPFromEmail { get; set; }
			[DataMember]
          	 public String AzureBlobStorageConnection { get; set; }
			[DataMember]
          	 public Boolean? SaveBlobInAzureStorage { get; set; }
			[DataMember]
          	 public Boolean? SaveBlobInDataBase { get; set; }
			[DataMember]
          	 public String UserNameGeoNames { get; set; }
			[DataMember]
          	 public String EngineURL { get; set; }
			[DataMember]
          	 public String ENGINE_API_KEY { get; set; }
			[DataMember]
          	 public String MAMBU_URL { get; set; }
			[DataMember]
          	 public String MAMBU_USER { get; set; }
			[DataMember]
          	 public String MAMBU_PWD { get; set; }
			[DataMember]
          	 public Int32? KM_MAXIMO { get; set; }
			[DataMember]
          	 public String MAP_KEY { get; set; }
			[DataMember]
          	 public String ENGINE_OAUTH_CLIENT_ID { get; set; }
			[DataMember]
          	 public String ENGINE_OAUTH_LOGIN_URL { get; set; }
			[DataMember]
          	 public String ENGINE_OAUTH_USERNAME { get; set; }
			[DataMember]
          	 public String ENGINE_OAUTH_PASSWORD { get; set; }
			[DataMember]
          	 public String ENGINE_OAUTH_CLIENT_SECRET { get; set; }
			[DataMember]
          	 public String ENGINE_DEFINITION_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_DATOS_CLIENTE_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_DOCUMENTOS_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_DIRECCION_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_DATOS_FINANCIEROS_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_BENEFICIARIOS_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_CONTRATOS_ID { get; set; }
			[DataMember]
          	 public String CONTAINER_APROBACION_ID { get; set; }
			[DataMember]
          	 public String MAMBU_CONTRATO_TEMPLATEID { get; set; }
			[DataMember]
          	 public String MAMBU_CARATULA_TEMPLATEID { get; set; }
			[DataMember]
          	 public String MAMBU_PAGARE_TEMPLATEID { get; set; }
			[DataMember]
          	 public String MAMBU_REFERENCIASPAGO_TEMPLATEID { get; set; }
			[DataMember]
          	 public String MATI_AUTH_HEADER { get; set; }
			[DataMember]
          	 public String WEBBHOOK_MATI_KEY { get; set; }


	      #region propertyNames
		public static readonly string EntityName = "unProxySetting";
		public static readonly string EntitySetName = "unProxySettings";
        public struct PropertyNames {
            public static readonly string GuidUnProxySetting = "GuidUnProxySetting";
            public static readonly string SMTPServer = "SMTPServer";
            public static readonly string SMTPSSLEnabled = "SMTPSSLEnabled";
            public static readonly string SMTPUser = "SMTPUser";
            public static readonly string SMTPPassword = "SMTPPassword";
            public static readonly string SMTPFromName = "SMTPFromName";
            public static readonly string SMTPPort = "SMTPPort";
            public static readonly string SMTPFromEmail = "SMTPFromEmail";
            public static readonly string AzureBlobStorageConnection = "AzureBlobStorageConnection";
            public static readonly string SaveBlobInAzureStorage = "SaveBlobInAzureStorage";
            public static readonly string SaveBlobInDataBase = "SaveBlobInDataBase";
            public static readonly string UserNameGeoNames = "UserNameGeoNames";
            public static readonly string EngineURL = "EngineURL";
            public static readonly string ENGINE_API_KEY = "ENGINE_API_KEY";
            public static readonly string MAMBU_URL = "MAMBU_URL";
            public static readonly string MAMBU_USER = "MAMBU_USER";
            public static readonly string MAMBU_PWD = "MAMBU_PWD";
            public static readonly string KM_MAXIMO = "KM_MAXIMO";
            public static readonly string MAP_KEY = "MAP_KEY";
            public static readonly string ENGINE_OAUTH_CLIENT_ID = "ENGINE_OAUTH_CLIENT_ID";
            public static readonly string ENGINE_OAUTH_LOGIN_URL = "ENGINE_OAUTH_LOGIN_URL";
            public static readonly string ENGINE_OAUTH_USERNAME = "ENGINE_OAUTH_USERNAME";
            public static readonly string ENGINE_OAUTH_PASSWORD = "ENGINE_OAUTH_PASSWORD";
            public static readonly string ENGINE_OAUTH_CLIENT_SECRET = "ENGINE_OAUTH_CLIENT_SECRET";
            public static readonly string ENGINE_DEFINITION_ID = "ENGINE_DEFINITION_ID";
            public static readonly string CONTAINER_DATOS_CLIENTE_ID = "CONTAINER_DATOS_CLIENTE_ID";
            public static readonly string CONTAINER_DOCUMENTOS_ID = "CONTAINER_DOCUMENTOS_ID";
            public static readonly string CONTAINER_DIRECCION_ID = "CONTAINER_DIRECCION_ID";
            public static readonly string CONTAINER_DATOS_FINANCIEROS_ID = "CONTAINER_DATOS_FINANCIEROS_ID";
            public static readonly string CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID";
            public static readonly string CONTAINER_BENEFICIARIOS_ID = "CONTAINER_BENEFICIARIOS_ID";
            public static readonly string CONTAINER_CONTRATOS_ID = "CONTAINER_CONTRATOS_ID";
            public static readonly string CONTAINER_APROBACION_ID = "CONTAINER_APROBACION_ID";
            public static readonly string MAMBU_CONTRATO_TEMPLATEID = "MAMBU_CONTRATO_TEMPLATEID";
            public static readonly string MAMBU_CARATULA_TEMPLATEID = "MAMBU_CARATULA_TEMPLATEID";
            public static readonly string MAMBU_PAGARE_TEMPLATEID = "MAMBU_PAGARE_TEMPLATEID";
            public static readonly string MAMBU_REFERENCIASPAGO_TEMPLATEID = "MAMBU_REFERENCIASPAGO_TEMPLATEID";
            public static readonly string MATI_AUTH_HEADER = "MATI_AUTH_HEADER";
            public static readonly string WEBBHOOK_MATI_KEY = "WEBBHOOK_MATI_KEY";
		}
		#endregion
	}
		  [Serializable()]
	  [Table("UploadFileResult", Schema = "Kst")]
	  [DynamicLinqType]
	  [JsonObject(IsReference = true)]
      [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
		[NotMapped]
	  public partial class UploadFileResult{
		[NotMapped]
		public SFS.Core.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.TotalRows != null )		
            		return this.TotalRows.ToString();
				else
					return String.Empty;
			}

		//public UploadFileResult()
        //  {

        //  }

	  #region Composite Key
	  
        #endregion

		public UploadFileResult(){
		#region 
			this.ModifiedProperties = new List<string>();
		#endregion
		}
		#region

//x1

	#endregion

	#region
    #endregion    
	
	//[DataMember]
	[NotMapped]
    public TrackingState TrackingState { get; set; }
    //[DataMember]
	[NotMapped]
   public ICollection<string> ModifiedProperties { get; set; }
   // [JsonProperty, DataMember]
   // private Guid EntityIdentifier { get; set; }

      
			[DataMember]
          	 public Int32 TotalRows { get; set; }
			[DataMember]
          	 public String UrlFileResult { get; set; }
			[DataMember]
          	 public Int32? Ignored { get; set; }


	      #region propertyNames
		public static readonly string EntityName = "UploadFileResult";
		public static readonly string EntitySetName = "UploadFileResult";
        public struct PropertyNames {
            public static readonly string TotalRows = "TotalRows";
            public static readonly string UrlFileResult = "UrlFileResult";
            public static readonly string Ignored = "Ignored";
		}
		#endregion
	}
	 
	
}
