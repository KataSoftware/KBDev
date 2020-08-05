// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

import { addButtonPlace, addButtonFloatType } from 'sfscommon';


export const environment = {
  production: false,
  sfscommon: {
    AppNameKey: 'KSTime',
    GuidCompanyId: 'F8A6AAE5-624F-4D42-AF85-C1E71F6D769A',
    GeneralUrl: 'https://7dc0bccbc091.ngrok.io/ShellTime',
    LocalUrl: '/Shell',
    BlobStorageURL: 'https://*.blob.core.windows.net/kstime',
    IsDebug: true,
    BuildVersion: '1.0.1',
    ServerVersion: 3,
    GoogleLocationAPIKey: '***',
    FacebookConfigAuth: { permissions: ['public_profile', 'email', 'user_birthday'], clientId: '1333094310151842' },
    GoogleConfigAuth: { offline: true, webClientId: '241810682914-n2rflefn6mqfunf7arotpq5tdrkmgr3o.apps.googleusercontent.com' },
    uiSettingsMobile: {
      addButtonPlace:addButtonPlace.header,
      addButtonFloatType:addButtonFloatType.BR
   },
   uiSettingsDesktop:{
    addButtonPlace:addButtonPlace.header,
    addButtonFloatType:addButtonFloatType.BR
   }
  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
