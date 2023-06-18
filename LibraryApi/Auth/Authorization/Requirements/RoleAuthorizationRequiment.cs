﻿using Microsoft.AspNetCore.Authorization;

namespace LibraryApi.Auth.Authorization.Requirements;

public class RoleAuthorizationRequiment : IAuthorizationRequirement
{
    public string Permission { get; private set; }
    public RoleAuthorizationRequiment(string permission)
    {
        Permission = permission;
    }
}
