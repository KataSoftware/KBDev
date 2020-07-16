import { Injectable } from '@angular/core';
import { HttpService, DataService, EntityWrapper, ApiResponse, ServiceData } from 'sfscommon';
import { ServiceDataOptions } from './sfs.service';

@Injectable({ providedIn: 'root' })
export class bizAppService {
  url: string;
  constructor(public http: HttpService, public dataService: DataService) {
    this.url = http.generateUrl();
  }
  
  
  public async  Create(entity: any, setName: any) {

    return this.dataService.create({ EntitySet: setName, RestServiceAppKey: "KSTime", Item: entity });
  }
  public async  Delete(ItemKeys: Array<string>, setName: any) {

    return this.dataService.delete({ EntitySet: setName, RestServiceAppKey: "KSTime", ItemKeys: ItemKeys });
  }
  public async  Update(entity: any, setName: any, fields?: any, usemode?:string) {

    return this.dataService.update({ EntitySet: setName, Usemode:usemode,  RestServiceAppKey: "KSTime", Item: entity, Fields: fields });
  }
  public async  GetCount(serviceData: ServiceDataOptions) {


    if (serviceData.EntitySet == null) {
      serviceData.EntitySet = serviceData.EntityModel["_EntitySetName"];
    }
    return this.dataService.getCount(serviceData);

  }
  public async  Get(serviceData: ServiceDataOptions) {

    if (serviceData.Fields == null) {
      serviceData.Fields = Object.getOwnPropertyNames(serviceData.EntityModel["PropertyNames"]).join(",");
    }
    if (serviceData.EntitySet == null) {
      serviceData.EntitySet = serviceData.EntityModel["_EntitySetName"];
    }
    return this.dataService.get(serviceData);

  }

  public async  GetItem(id: any, setName: any, fields?: string) {

    let result = await this.dataService.get({ EntitySet: setName, AllFields: true, Fields: fields, RestServiceAppKey: "KSTime", ItemKey: id });
    if (result.isSuccess() == true) {
      if (Array.isArray(result.data) == true && result.data.length == 1) {
        result.data = result.data[0];
      }
    }
    return result;

  }




  public async  CustomMethod(params?: any, setName?: string, actionMethod?: string) {

    const requestParams = await this.http.generateFullParamsRequest();

    requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/KSTime/${setName}/${actionMethod}`, requestParams.data, requestParams.headers);

    return response;
  }


    

}