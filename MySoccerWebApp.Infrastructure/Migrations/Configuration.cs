namespace MySoccerWebApp.Infrastructure.Migrations
{
    using MySoccerWebApp.Core.Entities;
    using MySoccerWebApp.Infrastructure.DatabaseContext;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MySoccerWebAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MySoccerWebAppDbContext context)
        {
            try
            {
                //var roles = new List<Role>
                //{
                //    new Role{RoleName = "Admin"}
                //};
                //context.Roles.AddRange(roles);

                //var users = new List<User>
                //{
                //    new User{Firstname="Michiel",Lastname="Goyvaerts",Email="michiel.goyvaerts@selligent.com",Password="5EI6qwqwqiq1DaCDWSVGURA0jhS9nqD/1xSUuzICXbp/p8cd",Salt="5EI6qwqwqiq1DaCDWSVGUQ=="}
                //};
                //context.Users.AddRange(users);

                //var userRoles = new List<UserRole>
                //{
                //    new UserRole{Role=roles.ElementAt(0),User=users.ElementAt(0)}
                //};
                //context.UserRoles.AddRange(userRoles);

                var countries = new List<Country>
                {
                    new Country{CountryName="België",CountryIsoCode="BE",IsDeleted=false},
                    new Country{CountryName="Nederland",CountryIsoCode="NL",IsDeleted=false},
                    new Country{CountryName="Engeland",CountryIsoCode="EN",IsDeleted=false},
                    new Country{CountryName="Frankrijk",CountryIsoCode="FR",IsDeleted=false},
                    new Country{CountryName="Duitsland",CountryIsoCode="DE",IsDeleted=false},
                    new Country{CountryName="Spanje",CountryIsoCode="ES",IsDeleted=false},
                    new Country{CountryName="Italië",CountryIsoCode="ET",IsDeleted=false},
                    new Country{CountryName="Portugal",CountryIsoCode="PT",IsDeleted=false}
                };
                context.Countries.AddRange(countries);

                var provinces = new List<Province>
                {
                    new Province{Provincename="Limburg",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Antwerpen",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Oost-Vlaanderen",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="West-Vlaanderen",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Vlaams-Brabant",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Waals-Brabant",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Luik",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Luxemburg",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Henegouwen",Country=countries.ElementAt(0),IsDeleted=false},
                    new Province{Provincename="Namen",Country=countries.ElementAt(0),IsDeleted=false}
                };
                context.Provinces.AddRange(provinces);

                var cities = new List<City>
                {
                    new City{Cityname="Diepenbeek",ZipCode="3590",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Bilzen",ZipCode="3740",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Genk",ZipCode="3600",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Dilsen-Stokkem",ZipCode="3650",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Maasmechelen",ZipCode="3630",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Lanaken",ZipCode="3620",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Riemst",ZipCode="3770",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Tongeren",ZipCode="3700",Province=provinces.ElementAt(0),IsDeleted=false},
                    new City{Cityname="Zutendaal",ZipCode="3690",Province=provinces.ElementAt(0),IsDeleted=false}
                };
                context.Cities.AddRange(cities);

                var contactpersons = new List<Contactperson>
                {

                };
                context.ClubContactpersons.AddRange(contactpersons);

                var divisions = new List<Division>
                {
                    new Division{Country=countries.ElementAt(0),DivisionName="1A",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="1B",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="1e Amateur",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="2e Amateur A",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="2e Amateur B",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="3e Amateur A",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="3e Amateur B",IsNational=true,IsProvincial=false,IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="1e Provinciaal",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="2e Provinciaal A",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="2e Provinciaal B",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="3e Provinciaal A",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="3e Provinciaal B",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="3e Provinciaal C",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="4e Provinciaal A",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="4e Provinciaal B",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="4e Provinciaal C",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false},
                    new Division{Country=countries.ElementAt(0),DivisionName="4e Provinciaal D",IsNational=false,IsProvincial=true, Province=provinces.ElementAt(0),IsDeleted=false}
                };
                context.Divisions.AddRange(divisions);

                var trainers = new List<Trainer>
                {
                    new Trainer{Firstname="Kristof",Lastname="Vandersmissen",IsDeleted=false},
                    new Trainer{Firstname="Kenneth",Lastname="Pirotte",IsDeleted=false},
                    new Trainer{Firstname="Yannick",Lastname="Digneffe",IsDeleted=false},
                    new Trainer{Firstname="Ives",Lastname="Dreesen",IsDeleted=false},
                    new Trainer{Firstname="Gaspare",Lastname="Randazzo",IsDeleted=false},
                    new Trainer{Firstname="Stijn",Lastname="Menten",IsDeleted=false},
                    new Trainer{Firstname="Ralf",Lastname="Wevers",IsDeleted=false},
                    new Trainer{Firstname="Jo",Lastname="Schoenaers",IsDeleted=false},
                    new Trainer{Firstname="Jurgen",Lastname="Wins",IsDeleted=false},
                    new Trainer{Firstname="Kurt",Lastname="Czornyj",IsDeleted=false},
                    new Trainer{Firstname="Kevin",Lastname="Czornyj",IsDeleted=false},
                    new Trainer{Firstname="Kevin",Lastname="Timmermans",IsDeleted=false},
                    new Trainer{Firstname="Steven",Lastname="Leduc",IsDeleted=false},
                    new Trainer{Firstname="Kristof",Lastname="Kellens",IsDeleted=false},
                    new Trainer{Firstname="Atilla",Lastname="Dokmeci",IsDeleted=false},
                    new Trainer{Firstname="Frank",Lastname="Wojciechowski",IsDeleted=false}
                };
                context.Trainers.AddRange(trainers);

                var clubs = new List<Club>
                {
                    new Club{ClubName="KMR Biesen A",Street="Biesenveldweg",Number="1",Logo="",Website="https://www.kmrbiesen.be",TotalPoints=32,MatchesPlayed=16,GamesDraw=2,GamesLost=4,GamesWon=10,GoalsConceeded=20,GoalsScored=39,GoalDifference=19,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(1),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(0),IsDeleted=false},
                    new Club{ClubName="RC Boxberg A",Street="Krommestraat",Number="",Logo="",Website="https://www.fcrb.club",TotalPoints=18,MatchesPlayed=16,GamesDraw=3,GamesLost=8,GamesWon=5,GoalsConceeded=30,GoalsScored=27,GoalDifference=-3,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(2),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(1),IsDeleted=false},
                    new Club{ClubName="KFC Diepenbeek A",Street="Wasserijstraat",Number="9",Logo="",Website="https://www.kfcdiepenbeek.be",TotalPoints=37,MatchesPlayed=15,GamesDraw=1,GamesLost=0,GamesWon=0,GoalsConceeded=14,GoalsScored=43,GoalDifference=29,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(0),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(2),IsDeleted=false},
                    new Club{ClubName="Dilsen Stokkem A",Street="Koeweerd",Number="",Logo="",Website="https://www.kvvdilsen-stokkem.be",TotalPoints=12,MatchesPlayed=16,GamesDraw=3,GamesLost=10,GamesWon=3,GoalsConceeded=44,GoalsScored=16,GoalDifference=-28,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(3),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(3),IsDeleted=false},
                    new Club{ClubName="STA Genk A",Street="Steenbeukstraat",Number="20C",Logo="",Website="https://www.sportingcalciogenk.be",TotalPoints=13,MatchesPlayed=16,GamesDraw=4,GamesLost=9,GamesWon=3,GoalsConceeded=36,GoalsScored=23,GoalDifference=-13,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(2),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(4),IsDeleted=false},
                    new Club{ClubName="Genk VV",Street="Kattevennen",Number="6A",Logo="",Website="https://www.genkervv.be",TotalPoints=17,MatchesPlayed=16,GamesDraw=2,GamesLost=9,GamesWon=5,GoalsConceeded=29,GoalsScored=25,GoalDifference=-4,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(2),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(5),IsDeleted=false},
                    new Club{ClubName="Grimbie 69",Street="Weg naar Zutendaal",Number="300",Logo="",Website="https://www.facebook.com/Grimbie-69",TotalPoints=17,MatchesPlayed=16,GamesDraw=5,GamesLost=7,GamesWon=4,GoalsConceeded=37,GoalsScored=26,GoalDifference=-11,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(4),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(6),IsDeleted=false},
                    new Club{ClubName="Heis Sport",Street="Sint-Jozefstraat",Number="32",Logo="",Website="https://www.heissport.be",TotalPoints=15,MatchesPlayed=15,GamesDraw=3,GamesLost=8,GamesWon=4,GoalsConceeded=32,GoalsScored=17,GoalDifference=-15,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(1),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(7),IsDeleted=false},
                    new Club{ClubName="VC Kesselt",Street="Kiezelweg",Number="",Logo="",Website="https://www.vckesselt.be",TotalPoints=15,MatchesPlayed=16,GamesDraw=3,GamesLost=9,GamesWon=4,GoalsConceeded=35,GoalsScored=26,GoalDifference=-9,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(5),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(8),IsDeleted=false},
                    new Club{ClubName="Lanaken VV",Street="Montaigneweg",Number="1",Logo="",Website="https://www.lanakenvv.be",TotalPoints=27,MatchesPlayed=16,GamesDraw=3,GamesLost=5,GamesWon=8,GoalsConceeded=24,GoalsScored=36,GoalDifference=12,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(5),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(9),IsDeleted=false},
                    new Club{ClubName="E. Maasmechelen A/D Maas B",Street="Oude Baan",Number="374",Logo="",Website="https://www.eendrachtmechelenaan-demaas.be",TotalPoints=26,MatchesPlayed=16,GamesDraw=2,GamesLost=6,GamesWon=8,GoalsConceeded=21,GoalsScored=35,GoalDifference=14,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(4),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(10),IsDeleted=false},
                    new Club{ClubName="Membruggen VV",Street="Op den Bonthof",Number="",Logo="",Website="https://www.facebook.com/membruggenvv",TotalPoints=31,MatchesPlayed=16,GamesDraw=4,GamesLost=3,GamesWon=9,GoalsConceeded=21,GoalsScored=32,GoalDifference=11,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(6),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(11),IsDeleted=false},
                    new Club{ClubName="KSK Munsterbilzen",Street="Appelboomgaardstraat",Number="6",Logo="",Website="https://www.kskmunsterbilzen.be",TotalPoints=31,MatchesPlayed=16,GamesDraw=1,GamesLost=5,GamesWon=10,GoalsConceeded=22,GoalsScored=36,GoalDifference=14,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(1),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(12),IsDeleted=false},
                    new Club{ClubName="Jekervallei Sluizen",Street="Tweemolenstraat",Number="",Logo="",Website="https://https://www.facebook.com/VC-Jekervallei-sluizen-147193589293439",TotalPoints=22,MatchesPlayed=15,GamesDraw=4,GamesLost=5,GamesWon=6,GoalsConceeded=21,GoalsScored=15,GoalDifference=-6,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(7),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(13),IsDeleted=false},
                    new Club{ClubName="Umitspor Maasmechelen A",Street="Valkenierstraat",Number="27",Logo="",Website="https://www.facebook.com/umitspormaasmechelen",TotalPoints=23,MatchesPlayed=16,GamesDraw=2,GamesLost=7,GamesWon=2,GoalsConceeded=37,GoalsScored=31,GoalDifference=-6,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(4),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(14),IsDeleted=false},
                    new Club{ClubName="Zutendaal VV A",Street="Blookbergstraat",Number="16",Logo="",Website="https://www.zvv.be",TotalPoints=20,MatchesPlayed=15,GamesDraw=2,GamesLost=7,GamesWon=6,GoalsConceeded=31,GoalsScored=27,GoalDifference=-4,TotalRedCards=0,TotalYellowCards=0,City=cities.ElementAt(8),Division=divisions.ElementAt(10),Trainer=trainers.ElementAt(15),IsDeleted=false}
                };
                context.Clubs.AddRange(clubs);

                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            base.Seed(context);
        }
    }
}
