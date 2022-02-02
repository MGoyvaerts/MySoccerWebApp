// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MySoccerWebApp.DependencyResolution {
    using AutoMapper;
    using MySoccerWebApp.Business.Domains;
    using MySoccerWebApp.Infrastructure.Mapper;
    using MySoccerWebApp.Infrastructure.Repositories;
    using MySoccerWebApp.Infrastructure.UnitOfWork;
    using MySoccerWebApp.Interfaces.Domains;
    using MySoccerWebApp.Interfaces.Repositories;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using System;
    using System.Linq;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });
            //For<IExample>().Use<Example>();

            #region Automapper
            //Register mapping profiles
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClubMappingProfile());
                cfg.AddProfile(new UserMappingProfile());
            });

            //Create a mapper that will be used by the DI container
            var mapper = config.CreateMapper();

            //Register the DI interfaces with their implementation
            For<MapperConfiguration>().Use(config);
            For<IMapper>().Use(mapper);
            #endregion

            #region UnitOfWork
            For<IUnitOfWork>().Use<UnitOfWork>();
            #endregion            

            #region Repositories
            For<IClubRepository>().Use<ClubRepository>();
            For<ICountryRepository>().Use<CountryRepository>();
            For<IUserRepository>().Use<UserRepository>();
            #endregion

            #region Domains
            For<IClubDomain>().Use<ClubDomain>();
            For<ICountryDomain>().Use<CountryDomain>();
            For<IUserDomain>().Use<UserDomain>();
            #endregion
        }

        #endregion
    }
}