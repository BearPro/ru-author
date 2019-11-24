﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace Rauthor.UnitTests
{
    public class DatabaseTest
    {
        protected IConfiguration Config => new ConfigurationBuilder()
            .AddUserSecrets<Startup>()
            .Build();
        protected DbContextOptions<DatabaseContext> Options => new DbContextOptionsBuilder<DatabaseContext>()
            .UseMySQL(Config.GetConnectionString("Local MySQL")).Options;
        protected IMemoryCache Cache => null;
        protected DatabaseContext Database => new DatabaseContext(Options, Config, Cache);
    }

    /// <summary>
    /// В этом наборе тестов выполняется проверка на возможность загрузить список записей из таблицы.
    /// </summary>
    public class BasicDatabaseTests : DatabaseTest
    {
        protected void TestForEntity<T>(Func<DatabaseContext, DbSet<T>> entityFunc) where T : class
        {
            var entity = entityFunc(Database);
            Assert.All(entity, x => Assert.NotNull(x));
        }

        [Fact]
        public void CompetitionsLoading()
        {
            TestForEntity(db => db.Competitions);
        }

        [Fact]
        public void UsersLoading()
        {
            TestForEntity(db => db.Users);
        }

        [Fact]
        public void PoemsLoading()
        {
            TestForEntity(db => db.Poems);
        }

        [Fact]
        public void ParticipantsLoading()
        {
            TestForEntity(db => db.Participants);
        }

        [Fact]
        public void ParticipantAssessmentsLoading()
        {
            TestForEntity(db => db.ParticipantAssessments);
        }

        [Fact]
        public void CompetitionCategoriesLoading()
        {
            TestForEntity(db => db.CompetitionCategories);
        }

        [Fact]
        public void CompetitionConstraintsLoading()
        {
            TestForEntity(db => db.CompetitionConstraints);
        }

        [Fact]
        public void ProfilesLoading()
        {
            TestForEntity(db => db.Profiles);
        }

        [Fact]
        public void RolesLoading()
        {
            TestForEntity(db => db.Roles);
        }
    }
}
