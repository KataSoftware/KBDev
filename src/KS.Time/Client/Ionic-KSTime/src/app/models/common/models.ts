export class AppSettingsModel{
    public SMTPSSLEnabledId?:string;
    public SMTPSSLEnabled?:boolean;
    public SMTPFromEmailId?:string;
    public SMTPFromEmail?:string;
    public SMTPPasswordId?:string;
    public SMTPPassword?:string;
    public SMTPFromNameId?:string;
    public  SMTPFromName?:string;
    public  SMTPServerId?:string;
    public  SMTPServer?:string;
    public  SMTPPortId?:string;
    public  SMTPPort?:string;
    public  SMTPUserId?:string;
    public  SMTPUser?:string;
    public  AzureBlobStorageConnectionId?:string;
    public  AzureBlobStorageConnection?:string;
    public  SaveBlobInAzureStorageId?:string;
    public  SaveBlobInAzureStorage?:boolean;
    public SaveBlobInDataBaseId?:string;
    public SaveBlobInDataBase?:boolean;
    public DefaultSizeThumbId?:string;
    public  DefaultSizeThumb?:string;
}

export class RegisterModel{
    public Email?:string;
    public CellPhone?: string;
    public Password?:string;
    public ConfirmPassword?: string;
}


export interface FileRecord {
    url?: string;
    name?: string;
    size?: number;
    type?: string;
    isUploading?: boolean;
    isDeleting?: boolean;
    brFile?: any;
    modelFile?: any;
    indexPlace?: number;
  }