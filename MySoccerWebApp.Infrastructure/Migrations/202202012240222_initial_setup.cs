namespace MySoccerWebApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Cityname = c.String(nullable: false, maxLength: 50),
                        ZipCode = c.String(nullable: false, maxLength: 10),
                        IsDeleted = c.Boolean(nullable: false),
                        Province_ProvinceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceID, cascadeDelete: true)
                .Index(t => t.Province_ProvinceID);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubID = c.Int(nullable: false),
                        RootNumber = c.String(maxLength: 10),
                        ClubName = c.String(nullable: false, maxLength: 50),
                        Logo = c.String(maxLength: 100),
                        Street = c.String(nullable: false, maxLength: 50),
                        Number = c.String(maxLength: 10),
                        Website = c.String(maxLength: 1000),
                        TotalPoints = c.Int(nullable: false),
                        MatchesPlayed = c.Int(nullable: false),
                        GamesWon = c.Int(nullable: false),
                        GamesDraw = c.Int(nullable: false),
                        GamesLost = c.Int(nullable: false),
                        GoalsScored = c.Int(nullable: false),
                        GoalsConceeded = c.Int(nullable: false),
                        GoalDifference = c.Int(nullable: false),
                        TotalYellowCards = c.Int(nullable: false),
                        TotalRedCards = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Division_DivisionID = c.Int(nullable: false),
                        City_CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClubID)
                .ForeignKey("dbo.Divisions", t => t.Division_DivisionID)
                .ForeignKey("dbo.Trainers", t => t.ClubID)
                .ForeignKey("dbo.Cities", t => t.City_CityID)
                .Index(t => t.ClubID)
                .Index(t => t.Division_DivisionID)
                .Index(t => t.City_CityID);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        DivisionID = c.Int(nullable: false, identity: true),
                        DivisionName = c.String(nullable: false, maxLength: 50),
                        IsNational = c.Boolean(nullable: false),
                        IsProvincial = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Province_ProvinceID = c.Int(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.DivisionID)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Province_ProvinceID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 50),
                        CountryIsoCode = c.String(nullable: false, maxLength: 2),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        Provincename = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        Country_CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinceID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        IsCurrentClub = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TrainerID);
            
            CreateTable(
                "dbo.Contactpersons",
                c => new
                    {
                        ContactpersonID = c.Int(nullable: false, identity: true),
                        ContactpersonFirstname = c.String(nullable: false, maxLength: 50),
                        ContactpersonName = c.String(nullable: false, maxLength: 50),
                        ContactpersonPhoneNumber = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                        Club_ClubID = c.Int(),
                    })
                .PrimaryKey(t => t.ContactpersonID)
                .ForeignKey("dbo.Clubs", t => t.Club_ClubID)
                .Index(t => t.Club_ClubID);
            
            CreateTable(
                "dbo.Gameweeks",
                c => new
                    {
                        GameweekID = c.Int(nullable: false, identity: true),
                        GameweekNumber = c.String(nullable: false, maxLength: 2),
                        HomeTeamGoals = c.Int(nullable: false),
                        AwayTeamGoals = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        AwayTeam_ClubID = c.Int(),
                        HomeTeam_ClubID = c.Int(),
                        Season_SeasonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameweekID)
                .ForeignKey("dbo.Clubs", t => t.AwayTeam_ClubID)
                .ForeignKey("dbo.Clubs", t => t.HomeTeam_ClubID)
                .ForeignKey("dbo.Seasons", t => t.Season_SeasonID, cascadeDelete: true)
                .Index(t => t.AwayTeam_ClubID)
                .Index(t => t.HomeTeam_ClubID)
                .Index(t => t.Season_SeasonID);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonID = c.Int(nullable: false, identity: true),
                        SeasonYear = c.String(nullable: false, maxLength: 10),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonID);
            
            CreateTable(
                "dbo.PlayerPositions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        Position = c.String(nullable: false, maxLength: 50),
                        PositionNumber = c.String(nullable: false, maxLength: 2),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PositionID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Birthday = c.DateTime(nullable: false),
                        YellowCards = c.Int(nullable: false),
                        RedCards = c.Int(nullable: false),
                        Goals = c.Int(nullable: false),
                        MinutesPlayed = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Club_ClubID = c.Int(),
                        Position_PositionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerID)
                .ForeignKey("dbo.Clubs", t => t.Club_ClubID)
                .ForeignKey("dbo.PlayerPositions", t => t.Position_PositionID, cascadeDelete: true)
                .Index(t => t.Club_ClubID)
                .Index(t => t.Position_PositionID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        User_UserID = c.Int(),
                        Role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.UserRoleID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Role_RoleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        Salt = c.String(nullable: false),
                        LoggedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Players", "Position_PositionID", "dbo.PlayerPositions");
            DropForeignKey("dbo.Players", "Club_ClubID", "dbo.Clubs");
            DropForeignKey("dbo.Gameweeks", "Season_SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.Gameweeks", "HomeTeam_ClubID", "dbo.Clubs");
            DropForeignKey("dbo.Gameweeks", "AwayTeam_ClubID", "dbo.Clubs");
            DropForeignKey("dbo.Contactpersons", "Club_ClubID", "dbo.Clubs");
            DropForeignKey("dbo.Clubs", "City_CityID", "dbo.Cities");
            DropForeignKey("dbo.Clubs", "ClubID", "dbo.Trainers");
            DropForeignKey("dbo.Divisions", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Provinces", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Divisions", "Province_ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Cities", "Province_ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Clubs", "Division_DivisionID", "dbo.Divisions");
            DropIndex("dbo.UserRoles", new[] { "Role_RoleID" });
            DropIndex("dbo.UserRoles", new[] { "User_UserID" });
            DropIndex("dbo.Players", new[] { "Position_PositionID" });
            DropIndex("dbo.Players", new[] { "Club_ClubID" });
            DropIndex("dbo.Gameweeks", new[] { "Season_SeasonID" });
            DropIndex("dbo.Gameweeks", new[] { "HomeTeam_ClubID" });
            DropIndex("dbo.Gameweeks", new[] { "AwayTeam_ClubID" });
            DropIndex("dbo.Contactpersons", new[] { "Club_ClubID" });
            DropIndex("dbo.Provinces", new[] { "Country_CountryID" });
            DropIndex("dbo.Divisions", new[] { "Country_CountryID" });
            DropIndex("dbo.Divisions", new[] { "Province_ProvinceID" });
            DropIndex("dbo.Clubs", new[] { "City_CityID" });
            DropIndex("dbo.Clubs", new[] { "Division_DivisionID" });
            DropIndex("dbo.Clubs", new[] { "ClubID" });
            DropIndex("dbo.Cities", new[] { "Province_ProvinceID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Players");
            DropTable("dbo.PlayerPositions");
            DropTable("dbo.Seasons");
            DropTable("dbo.Gameweeks");
            DropTable("dbo.Contactpersons");
            DropTable("dbo.Trainers");
            DropTable("dbo.Provinces");
            DropTable("dbo.Countries");
            DropTable("dbo.Divisions");
            DropTable("dbo.Clubs");
            DropTable("dbo.Cities");
        }
    }
}
