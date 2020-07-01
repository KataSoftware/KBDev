import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     unProxySettingModel, 
  
} from 'src/app/models/business/models';

export class unProxySettingFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxySettingModel.PropertyNames.SMTPServer,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPServer,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPSSLEnabled,
    type: 'checkbox',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPSSLEnabled,
        placeholder: '',
        required: false,
		
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPUser,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPUser,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPPassword,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPPassword,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPFromName,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPFromName,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPPort,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPPort,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxySettingModel.PropertyNames.SMTPFromEmail,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SMTPFromEmail,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxySettingModel.PropertyNames.AzureBlobStorageConnection,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.AzureBlobStorageConnection,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.SaveBlobInAzureStorage,
    type: 'checkbox',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SaveBlobInAzureStorage,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.SaveBlobInDataBase,
    type: 'checkbox',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.SaveBlobInDataBase,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.UserNameGeoNames,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.UserNameGeoNames,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.EngineURL,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.EngineURL,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_API_KEY,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_API_KEY,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_URL,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_URL,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_USER,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_USER,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_PWD,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_PWD,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.KM_MAXIMO,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.KM_MAXIMO,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
{
    key: unProxySettingModel.PropertyNames.MAP_KEY,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAP_KEY,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URL,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URL,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAME,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAME,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORD,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORD,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRET,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRET,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.ENGINE_DEFINITION_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.ENGINE_DEFINITION_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.CONTAINER_APROBACION_ID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.CONTAINER_APROBACION_ID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEID,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEID,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.MATI_AUTH_HEADER,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.MATI_AUTH_HEADER,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEY,
    type: 'input',

    templateOptions: {
        label: unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEY,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
	];
    }
}

