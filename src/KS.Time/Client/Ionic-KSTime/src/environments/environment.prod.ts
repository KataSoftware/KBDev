import { addButtonPlace, addButtonFloatType } from 'sfscommon';

export const environment = {
  production: true,
  sfscommon: {
    AppNameKey: 'KSTime',
    GuidCompanyId: 'F8A6AAE5-624F-4D42-AF85-C1E71F6D769A',
    GeneralUrl: 'https://kstime.azurewebsites.net',
    LocalUrl: '/Shell',
    BlobStorageURL: 'https://*.blob.core.windows.net/kstime',
    IsDebug: true,
    BuildVersion: '1.0.1',
    ServerVersion: 3,
    GoogleLocationAPIKey: '***',
    FacebookConfigAuth: { permissions: ['public_profile', 'email', 'user_birthday'], clientId: '1333094310151842' },
    GoogleConfigAuth: { offline: true, webClientId: '241810682914-n2rflefn6mqfunf7arotpq5tdrkmgr3o.apps.googleusercontent.com' },
    uiSettingsMobile: {
       addButtonPlace:addButtonPlace.float,
       addButtonFloatType:addButtonFloatType.BR,
       useMaterialExpansionPanel: true
    },
    uiSettingsDesktop:{
     addButtonPlace:addButtonPlace.header,
     addButtonFloatType:addButtonFloatType.BR
    }
   
  }
};
