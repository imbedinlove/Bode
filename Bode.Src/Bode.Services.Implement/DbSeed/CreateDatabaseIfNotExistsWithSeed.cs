﻿using OSharp.Data.Entity;
using OSharp.Data.Entity.Default;
using OSharp.Data.Entity.Migrations;


namespace Bode.Services.Implement.DbSeed
{
    public class CreateDatabaseIfNotExistsWithSeed : CreateDatabaseIfNotExistsWithSeedBase<DefaultDbContext>
    {
        public CreateDatabaseIfNotExistsWithSeed()
        {
            //SeedActions.Add(new CreateLabelSeedAction());
            //SeedActions.Add(new CreateSysRoleSeedAction());
            //SeedActions.Add(new CreateCitySeedAction());
            //SeedActions.Add(new CreateIndustrySeedAction());
            //SeedActions.Add(new CreateEducationSeedAction());
        }
    }
}