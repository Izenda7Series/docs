﻿namespace MVCCoreStarterKit.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }

        // This corresponds to the 'TenantID' field in the IzendaTenant table
        public string TenantUniqueName { get; set; }
    }
}
