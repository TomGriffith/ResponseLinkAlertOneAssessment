"use strict";
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
Object.defineProperty(exports, "__esModule", { value: true });
exports.ApiPaths = exports.environment = void 0;
exports.environment = {
    production: false,
    apiUrl: 'https://localhost:44321/api'
};
var ApiPaths;
(function (ApiPaths) {
    ApiPaths["Order"] = "/Order";
    ApiPaths["Jwt"] = "/Jwt";
})(ApiPaths = exports.ApiPaths || (exports.ApiPaths = {}));
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
//# sourceMappingURL=environment.js.map