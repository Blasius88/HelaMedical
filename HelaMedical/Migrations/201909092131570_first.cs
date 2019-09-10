namespace HelaMedical.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alcoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Sex = c.String(),
                        Date = c.String(),
                        RegionCenterBLR = c.String(),
                        RaenCenterBLR = c.String(),
                        Life = c.String(),
                        Age = c.String(),
                        FamilyStatus = c.String(),
                        CostOfKids = c.String(),
                        FamilyComposition = c.String(),
                        Education = c.String(),
                        Profession = c.String(),
                        TheSkillLevelOfTheProfession = c.String(),
                        AddressOfRegistration = c.String(),
                        AddressAtTheTimeOfDeath = c.String(),
                        DataOfRegistration = c.String(),
                        ReRegistrationData = c.String(),
                        TypeOfRegistration = c.String(),
                        Heredity = c.String(),
                        DisabilityGroup = c.String(),
                        DisabilityStatus = c.String(),
                        ReasonForDisability = c.String(),
                        WorksStatus = c.String(),
                        AdmOtv = c.String(),
                        UgOtv = c.String(),
                        DlitsMLS = c.String(),
                        Stat107 = c.String(),
                        StatUKRB = c.String(),
                        RodPrav = c.String(),
                        NomLTP = c.String(),
                        LTPKol = c.String(),
                        Hospitel = c.String(),
                        EK = c.String(),
                        DateOfDeregistration = c.String(),
                        DateOfDead = c.String(),
                        PlaceOfDead = c.String(),
                        DeathCertificate = c.String(),
                        CauseOfDead = c.String(),
                        DeathCategory = c.String(),
                        OpeningPlace = c.String(),
                        HistoryOfParasucicides = c.String(),
                        FeaturesOfObservation = c.String(),
                        ExperienceAbuse = c.String(),
                        AlcoholicDrinks = c.String(),
                        IK = c.String(),
                        DrugDiagnosisAlc = c.String(),
                        AgeOfDead = c.String(),
                        AgeOfRegistration = c.String(),
                        DataInfo = c.String(),
                        Registrotor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Incitalizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pass = c.String(),
                        Pasition = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Narcomen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Sex = c.String(),
                        Date = c.String(),
                        RegionCenterBLR = c.String(),
                        RaenCenterBLR = c.String(),
                        Life = c.String(),
                        Age = c.String(),
                        FamilyStatus = c.String(),
                        CostOfKids = c.String(),
                        FamilyComposition = c.String(),
                        Education = c.String(),
                        Profession = c.String(),
                        TheSkillLevelOfTheProfession = c.String(),
                        AddressOfRegistration = c.String(),
                        AddressAtTheTimeOfDeath = c.String(),
                        DataOfRegistration = c.String(),
                        ReRegistrationData = c.String(),
                        TypeOfRegistration = c.String(),
                        Heredity = c.String(),
                        DisabilityGroup = c.String(),
                        DisabilityStatus = c.String(),
                        ReasonForDisability = c.String(),
                        WorksStatus = c.String(),
                        AdmOtv = c.String(),
                        UgOtv = c.String(),
                        DlitsMLS = c.String(),
                        Stat107 = c.String(),
                        StatUKRB = c.String(),
                        RodPrav = c.String(),
                        NomLTP = c.String(),
                        LTPKol = c.String(),
                        Hospitel = c.String(),
                        EK = c.String(),
                        DateOfDeregistration = c.String(),
                        DateOfDead = c.String(),
                        PlaceOfDead = c.String(),
                        DeathCertificate = c.String(),
                        CauseOfDead = c.String(),
                        DeathCategory = c.String(),
                        OpeningPlace = c.String(),
                        HistoryOfParasucicides = c.String(),
                        FeaturesOfObservation = c.String(),
                        IntranozologicalComorbidity = c.String(),
                        TypeOfDrug = c.String(),
                        DrugUse = c.String(),
                        YearOfFirstUse = c.String(),
                        ExperienceAbuseDrug = c.String(),
                        Remissions = c.String(),
                        RemissionNumber = c.String(),
                        RemissionTimer = c.String(),
                        DrugDiagnosisX = c.String(),
                        AgeOfDead = c.String(),
                        AgeOfRegistration = c.String(),
                        DataInfo = c.String(),
                        Registrotor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Polizavis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Sex = c.String(),
                        Date = c.String(),
                        RegionCenterBLR = c.String(),
                        RaenCentrBLR = c.String(),
                        Life = c.String(),
                        Age = c.String(),
                        FamilyStatus = c.String(),
                        CostOfKids = c.String(),
                        FamilyComposition = c.String(),
                        Education = c.String(),
                        Profession = c.String(),
                        TheSkillLevelOfTheProfession = c.String(),
                        AddressOfRegistration = c.String(),
                        AddressAtTheTimeOfDeath = c.String(),
                        DataOfRegistration = c.String(),
                        ReRegistrationData = c.String(),
                        TypeOfRegistration = c.String(),
                        Heredity = c.String(),
                        DisabilityGroup = c.String(),
                        DisabilityStatus = c.String(),
                        ReasonForDisability = c.String(),
                        WorksStatus = c.String(),
                        AdmOtv = c.String(),
                        UgOtv = c.String(),
                        DlitsMLS = c.String(),
                        Stat107 = c.String(),
                        StatUKRB = c.String(),
                        RodPrav = c.String(),
                        NomLTP = c.String(),
                        LTPKol = c.String(),
                        Hospitel = c.String(),
                        EK = c.String(),
                        DateOfDeregistration = c.String(),
                        DateOfDead = c.String(),
                        PlaceOfDead = c.String(),
                        DeathCertificate = c.String(),
                        CauseOfDead = c.String(),
                        DeathCategory = c.String(),
                        OpeningPlace = c.String(),
                        HistoryOfParasucicides = c.String(),
                        FeaturesOfObservation = c.String(),
                        ExperienceAbuse = c.String(),
                        AlcoholicDrinks = c.String(),
                        IK = c.String(),
                        DrugDiagnosisAlc = c.String(),
                        IntranozologicalComorbidity = c.String(),
                        TypeOfDrug = c.String(),
                        DrugUse = c.String(),
                        YearOfFirstUse = c.String(),
                        ExperienceAbuseDrug = c.String(),
                        Remissions = c.String(),
                        RemissionNumber = c.String(),
                        RemissionTimer = c.String(),
                        DrugDiagnosisX = c.String(),
                        AgeOfDead = c.String(),
                        AgeOfRegistration = c.String(),
                        DataInfo = c.String(),
                        Registrotor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Polizavis");
            DropTable("dbo.Narcomen");
            DropTable("dbo.Incitalizations");
            DropTable("dbo.Alcoes");
        }
    }
}
