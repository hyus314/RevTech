﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevTech.Data.Models.PerformanceParts;
using RevTech.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Configuration
{
    public class ExhaustKitEntityTypeConfiguration : IEntityTypeConfiguration<ExhaustKit>
    {
        private readonly ExhaustKitSeeder seeder = new ExhaustKitSeeder();

        public void Configure(EntityTypeBuilder<ExhaustKit> builder)
        {
            builder.HasData(seeder.GenerateExhausts());
        }
    }
}
