import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'abpWorkerServiceDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44372',
    redirectUri: baseUrl,
    clientId: 'abpWorkerServiceDemo_App',
    responseType: 'code',
    scope: 'offline_access abpWorkerServiceDemo',
  },
  apis: {
    default: {
      url: 'https://localhost:44372',
      rootNamespace: 'abpWorkerServiceDemo',
    },
  },
} as Config.Environment;
