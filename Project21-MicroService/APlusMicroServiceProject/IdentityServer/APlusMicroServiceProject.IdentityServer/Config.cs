// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace APlusMicroServiceProject.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
            {
                new ApiResource("resource_catalog") {Scopes={"catalog_fullpermission"}},
                    new ApiResource("resource_photostock") {Scopes={"photostock_fullpermission"}},
                        new ApiResource("resource_basket") {Scopes={"basket_fullpermission"}},
                            new ApiResource("discount_basket") {Scopes={"discount_fullpermission"}},
                                new ApiResource("order_basket") {Scopes={"order_fullpermission"}},
                                    new ApiResource("payment_basket") {Scopes={"payment_fullpermission"}},
                                        new ApiResource("gateway_basket") {Scopes={"gateway_fullpermission"}},
                                            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
            };
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("catalog_fullpermission", "Catalog Api için tam yetkili erişim"),
                    new ApiScope("photostock_fullpermission", "PhotoStock Api için tam yetkili erişim"),
                        new ApiScope("basket_fullpermission", "Basket Api için tam yetkili erişim"),
                            new ApiScope("discount_fullpermission", "Discount Api için tam yetkili erişim"),
                                new ApiScope("order_fullpermission", "Order Api için tam yetkili erişim"),
                                    new ApiScope("payment_fullpermission", "Payment Api için tam yetkili erişim"),
                                        new ApiScope("gateway_fullpermission", "Gateway Api için tam yetkili erişim"),
                                            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "AkademiPlus",
                    ClientId = "AkademiPlusClient",
                    ClientSecrets = {new Secret ("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "catalog_fullpermission" , "photostock_fullpermission" , IdentityServerConstants.LocalApi.ScopeName }
                }
            };
    }
}