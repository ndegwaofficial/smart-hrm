﻿using Microsoft.AspNetCore.Authorization;

namespace SmartHRM.DataAccess.Permission
{
public class PermissionRequirement : IAuthorizationRequirement
{
    public string Permission { get; private set; }

    public PermissionRequirement(string permission)
    {
        Permission = permission;
    }
}
}