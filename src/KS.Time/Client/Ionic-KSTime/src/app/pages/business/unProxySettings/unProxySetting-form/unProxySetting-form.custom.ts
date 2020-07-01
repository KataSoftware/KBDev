import { unProxySettingModel } from 'src/app/models/business/models';
import { TableColumn } from 'sfscommon';
//import { sfsService } from './../../../../services/common/sfs.service';
import { sfsService } from 'src/app/services/common/sfs.service';
import { unProxySettingFormFields } from './unProxySetting-form.fields';
import { unProxySettingFormPage } from './unProxySetting-form.page';

import { FormGroup } from '@angular/forms';


export class unProxySettingFormCustom {

    /**
     * 
     */

    public static OnShowing(page: unProxySettingFormPage, e: any): void {
        page.title = "Configuración de sistema";
        page.defaultHref = "configuration";
       
       
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPServer } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPServerId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPSSLEnabled } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPSSLEnabledId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPPort } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPPortId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPUser } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPUserId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPPassword } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPPasswordId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPFromEmail } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPFromEmailId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SMTPFromName } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SMTPFromNameId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.AzureBlobStorageConnection } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.AzureBlobStorageConnectionId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SaveBlobInAzureStorage } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SaveBlobInAzureStorageId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.SaveBlobInDataBase } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.SaveBlobInDataBaseId);

      /*   page.setOrder( { Name: unProxySettingModel.PropertyNames.EngineURL } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.EngineURLId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_API_KEY } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_API_KEYId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_URL } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_URLId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_USER } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_USERId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_PWD } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_PWDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.KM_MAXIMO } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.KM_MAXIMOId);
        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAP_KEY } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAP_KEYId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URL } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URLId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAME } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAMEId);
       
        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORD } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORDId);
       

        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRET } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRETId);
       

        page.setOrder( { Name: unProxySettingModel.PropertyNames.ENGINE_DEFINITION_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.ENGINE_DEFINITION_IDId);
       

        page.setOrder( { Name: unProxySettingModel.PropertyNames.UserNameGeoNames } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.UserNameGeoNamesId);
       

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.CONTAINER_APROBACION_ID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.CONTAINER_APROBACION_IDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEIDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEIDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEIDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEID } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEIDId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.MATI_AUTH_HEADER } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.MATI_AUTH_HEADERId);

        page.setOrder( { Name: unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEY } );
        page.propertiesForUpdate.push(unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEYId);

 */

       
        
        
        
    }
   
}