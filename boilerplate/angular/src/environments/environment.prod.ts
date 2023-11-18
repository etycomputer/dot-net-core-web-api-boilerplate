import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'boilerplate',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44317/',
    redirectUri: baseUrl,
    clientId: 'boilerplate_App',
    responseType: 'code',
    scope: 'offline_access boilerplate',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44317',
      rootNamespace: 'boilerplate',
    },
  },
} as Environment;
