﻿using Elsa.EntityFrameworkCore.Abstractions;
using Elsa.EntityFrameworkCore.Extensions;
using Elsa.EntityFrameworkCore.Modules.Alterations;
using Elsa.EntityFrameworkCore.Modules.Identity;
using Elsa.EntityFrameworkCore.Modules.Labels;
using Elsa.EntityFrameworkCore.Modules.Management;
using Elsa.EntityFrameworkCore.Modules.Runtime;
using Elsa.EntityFrameworkCore.Modules.Tenants;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Elsa.EntityFrameworkCore.Oracle;

[UsedImplicitly]
public class IdentityDbContextFactory : OracleDesignTimeDbContextFactory<IdentityElsaDbContext>;

[UsedImplicitly]
public class ManagementDbContextFactory : OracleDesignTimeDbContextFactory<ManagementElsaDbContext>;

[UsedImplicitly]
public class RuntimeDbContextFactory : OracleDesignTimeDbContextFactory<RuntimeElsaDbContext>;

[UsedImplicitly]
public class LabelsDbContextFactory : OracleDesignTimeDbContextFactory<LabelsElsaDbContext>;

[UsedImplicitly]
public class AlterationsDbContextFactories : OracleDesignTimeDbContextFactory<AlterationsElsaDbContext>;

[UsedImplicitly]
public class TenantsDbContextFactories : OracleDesignTimeDbContextFactory<TenantsElsaDbContext>;

public class OracleDesignTimeDbContextFactory<TDbContext> : DesignTimeDbContextFactoryBase<TDbContext> where TDbContext : DbContext
{
    protected override void ConfigureBuilder(DbContextOptionsBuilder<TDbContext> builder, string connectionString)
    {
        var options = new ElsaDbContextOptions().Configure();
        builder.UseElsaOracle(GetType().Assembly, connectionString, options);
    }
}