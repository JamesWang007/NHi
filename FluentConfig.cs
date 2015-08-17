using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using Commencement_Mvc_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data
{
    public static class FluentConfig
    {

        public static Configuration Configure(Configuration config)
        {
            return Fluently.Configure(config)
                .Database(
                    OracleDataClientConfiguration.Oracle10
                        .ConnectionString(c => c

                            .FromConnectionStringWithKey("APPS"))

                            .ShowSql()
                            .FormatSql())
                    .Mappings(m =>
                    {
                        m.FluentMappings.AddFromAssemblyOf<Snippet>();
                    }).ExposeConfiguration(cfg => new NHibernate.Tool.hbm2ddl.SchemaUpdate(cfg).Execute(false, true)).
                    BuildConfiguration();
        }
    }
}