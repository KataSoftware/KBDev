import { Injectable } from '@angular/core';
import { HttpService, DataService, EntityWrapper, ApiResponse, ServiceData, IGeoData, IUserDataModel, SystemCore, UserService } from 'sfscommon';
@Injectable({ providedIn: 'root' })
export class sfsService {
  url: string;
  constructor( private system: SystemCore,   private userService: UserService, public http: HttpService, public dataService: DataService) {
    this.url = http.generateUrl();
  }
  public async loginToSFSApp(userData: IUserDataModel): Promise<any> {

    // Se recupera el Header para la petición.
    const headers = await this.http.getHeaderOptions();

    // Se recuperan la Url y el GuidCompany.
    const url = this.http.generateUrl();

    userData.GetCompanyRoles = true;
    userData.AppKey = this.system.appNameKey;

    if (this.system.guidCompanyId != null && userData.IdCompany == null) {
      userData.IdCompany = this.system.guidCompanyId;
    }
    let apiPath = `${url}/Api/Login`;

    if (this.system.serverVersion === 3){
      apiPath = `${url}/Auth/Login`
    }
    const response = await this.http.post(apiPath, userData, headers);

    if (response['status'] !== 'error') {

      // Se guarda la información.
      await this.userService.setUserData(response['data']);
      await this.userService.setUserToken(response['data'].Token);
    }

    return response;
  }
  private NavigationData?:any=null;
  public GetNavigationData():any{
    return this.NavigationData;
  }
  public SetNavigationData(data:any){
    console.log('SetNavigationData', data);
    this.NavigationData=data;
  }
  public async  Create(entity: any, setName: any) {

    return this.dataService.create({ EntitySet: setName,OverrideAppNameKey: "KSTime",  RestServiceAppKey: "SFSCoreSecurity", Item: entity });
  }
  public async  Delete(ItemKeys: Array<string>, setName: any) {

    return this.dataService.delete({ EntitySet: setName,OverrideAppNameKey: "KSTime", RestServiceAppKey: "SFSCoreSecurity", ItemKeys: ItemKeys });
  }

  public async  Update(entity: any, setName: any, fields?: any) {

    return this.dataService.update({ EntitySet: setName, OverrideAppNameKey: "KSTime", RestServiceAppKey: "SFSCoreSecurity", Item: entity, Fields: fields });
  }

  public async  GetItem(id: any, setName: any): Promise<ApiResponse<any>> {

    let result = await this.dataService.get({ EntitySet: setName, OverrideAppNameKey: "KSTime",   RestServiceAppKey: "SFSCoreSecurity", ItemKey: id });
    return result;
  }
  public async  Get( serviceData: ServiceDataOptions) {
    serviceData.RestServiceAppKey = "SFSCoreSecurity";
    serviceData.OverrideAppNameKey = "KSTime";
    return   this.dataService.get(serviceData);
  
  }
 


  public async  IsEmailAvailable(email: any) {

    const requestParams = await this.http.generateFullParamsRequest();
    //data["OverrideAppNameKey"] = "KSTime";
    const data = {
      OverrideAppNameKey: "KSTime",
      Email: email
    };

    const response = await this.http.post(`${requestParams.url}/Auth/IsEmailAvailable`, data, requestParams.headers);
    if (response.status = "success") {
      if (response.reason == "email-available") {
        return true;
      } else {
        return false;

      }
    } else {
      return false;
    }
  }

  


  public async  CustomMethod(params?: any, setName?:string, actionMethod?:string):Promise<ApiResponse<any>>{

    const requestParams = await this.http.generateFullParamsRequest();
    requestParams.data["OverrideAppNameKey"] = "KSTime";
    requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/SFSCoreSecurity/${setName}/${actionMethod}`, requestParams.data, requestParams.headers);
    
    return response;
  }

  public async  RecoveryPassword(email?:string, appKey?:string):Promise<ApiResponse<any>>{

    const requestParams = await this.http.generateFullParamsRequest();
    requestParams.data["OverrideAppNameKey"] = "KSTime";
    requestParams.data["AppKey"] = "KSTime";
    requestParams.data["Email"] = email;
    //requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/Auth/RecoveryPassword`, requestParams.data, requestParams.headers);
    
    return response;
  }

  async getRolesOfUser(guidUser:string, guidCompany?:string){
    let serviceData = new ServiceDataOptions();
    serviceData.AppNameKey = "SFSCoreSecurity";
    serviceData.OverrideAppNameKey = "KSTime";
    serviceData.Query = `it.GuidUser = Guid("${guidUser}") AND it.GuidCompany = Guid("${guidCompany}") AND it.secModule.ModuleKey = "KSTime"`;
    serviceData.EntitySet = "secUserCompanies";
    serviceData.Fields  = "GuidRole,GuidCompany,GuidModule,GuidUser";
    serviceData.AllFields = true ;
    let response = await this.Get( serviceData );
    return response;
  }  

  public async  SetPassword(email?:string, code?:string, password?:string, appKey?:string):Promise<ApiResponse<any>>{

    const requestParams = await this.http.generateFullParamsRequest();
    requestParams.data["OverrideAppNameKey"] = "KSTime";
    requestParams.data["AppKey"] = "KSTime";
    requestParams.data["Email"] = email;
    requestParams.data["Username"] = email;
    requestParams.data["Code"] = code;
    requestParams.data["UseCode"] = true;
    requestParams.data["Password"] = password;
    requestParams.data["NewPassword"] = password;
    //requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/Auth/ChangePassword`, requestParams.data, requestParams.headers);
    
    return response;
  }


  public async  ActivateAccount(email?:string, code?:string,   appKey?:string):Promise<ApiResponse<any>>{

    const requestParams = await this.http.generateFullParamsRequest();
    requestParams.data["OverrideAppNameKey"] = "KSTime";
    requestParams.data["AppKey"] = "KSTime";
    requestParams.data["Email"] = email;
    requestParams.data["Username"] = email;
    requestParams.data["Code"] = code;
    requestParams.data["UseCode"] = true;
   
    //requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/Auth/ActivateAccount`, requestParams.data, requestParams.headers);
    
    return response;
  }
  
  
}
export class ServiceDataOptions extends ServiceData {
    EntityModel?:any=null;
}

