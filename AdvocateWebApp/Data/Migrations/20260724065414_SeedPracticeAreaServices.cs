using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedPracticeAreaServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var createdDate = DateTime.Now;

            // 1. Criminal Matters
            InsertService(migrationBuilder, "Bail (Regular)", "bail-regular", "Criminal Matters", 1, "Expert legal assistance for regular bail applications.", createdDate);
            InsertService(migrationBuilder, "Anticipatory Bail", "anticipatory-bail", "Criminal Matters", 2, "Legal protection and anticipatory bail representation.", createdDate);
            InsertService(migrationBuilder, "Trial", "criminal-trial", "Criminal Matters", 3, "Comprehensive legal defense during criminal trials.", createdDate);
            InsertService(migrationBuilder, "Appeal", "criminal-appeal", "Criminal Matters", 4, "Filing and arguing criminal appeals in higher courts.", createdDate);
            InsertService(migrationBuilder, "Quashing Petition", "quashing-petition", "Criminal Matters", 5, "Petition under Section 482 for quashing FIR/proceedings.", createdDate);

            // 2. Civil Matters
            InsertService(migrationBuilder, "Recovery Suits", "recovery-suits", "Civil Matters", 1, "Legal proceedings for commercial and personal debt recovery.", createdDate);
            InsertService(migrationBuilder, "Specific Performance", "specific-performance", "Civil Matters", 2, "Suits for specific performance of contract obligations.", createdDate);
            InsertService(migrationBuilder, "Declaration Suits", "declaration-suits", "Civil Matters", 3, "Legal declaration suits regarding property rights and legal status.", createdDate);
            InsertService(migrationBuilder, "Partition Cases", "partition-cases", "Civil Matters", 4, "Property partition suits and family estate divisions.", createdDate);
            InsertService(migrationBuilder, "Injunction Matters", "injunction-matters", "Civil Matters", 5, "Temporary and permanent injunction petitions.", createdDate);

            // 3. Constitutional Law
            InsertService(migrationBuilder, "Writs", "writ-petitions", "Constitutional Law", 1, "Filing Habeas Corpus, Mandamus, Certiorari, and Prohibition writs.", createdDate);
            InsertService(migrationBuilder, "PILs", "public-interest-litigation", "Constitutional Law", 2, "Public Interest Litigation representation in High Courts & Supreme Court.", createdDate);
            InsertService(migrationBuilder, "Fundamental Rights", "fundamental-rights", "Constitutional Law", 3, "Protection and enforcement of fundamental rights.", createdDate);
            InsertService(migrationBuilder, "Other Matters", "constitutional-other-matters", "Constitutional Law", 4, "General constitutional law legal advice and litigation.", createdDate);

            // 4. Social & Service
            InsertService(migrationBuilder, "ACP MACP", "acp-macp-service", "Social & Service", 1, "Service matters related to ACP and MACP scale benefits.", createdDate);
            InsertService(migrationBuilder, "Pension & Promotion", "pension-and-promotion", "Social & Service", 2, "Legal disputes regarding pension releases and promotion delays.", createdDate);
            InsertService(migrationBuilder, "Departmental Inquiry", "departmental-inquiry", "Social & Service", 3, "Representation and defense in departmental inquiries.", createdDate);
            InsertService(migrationBuilder, "HPSC | HSSC", "hpsc-hssc-matters", "Social & Service", 4, "Recruitment disputes related to HPSC and HSSC exams.", createdDate);
            InsertService(migrationBuilder, "Writs Service", "writs-service-matters", "Social & Service", 5, "Service writ petitions for government employees.", createdDate);

            // 5. Family Law
            InsertService(migrationBuilder, "Divorce", "divorce-matters", "Family Law", 1, "Mutual and contested divorce petition representation.", createdDate);
            InsertService(migrationBuilder, "Maintenance", "maintenance-cases", "Family Law", 2, "Spousal and child maintenance petitions under Section 125 CrPC.", createdDate);
            InsertService(migrationBuilder, "Child Custody", "child-custody", "Family Law", 3, "Child custody, guardianship, and visitation rights litigation.", createdDate);
            InsertService(migrationBuilder, "Domestic Violence", "domestic-violence", "Family Law", 4, "Protection and defense in domestic violence proceedings.", createdDate);
            InsertService(migrationBuilder, "Succession", "succession-matters", "Family Law", 5, "Succession certificates and letter of administration.", createdDate);

            // 6. Corporate
            InsertService(migrationBuilder, "Contracts", "corporate-contracts", "Corporate", 1, "Drafting, reviewing, and handling commercial contract disputes.", createdDate);
            InsertService(migrationBuilder, "Compliance", "corporate-compliance", "Corporate", 2, "Regulatory and legal compliance management for businesses.", createdDate);
            InsertService(migrationBuilder, "Recovery", "corporate-recovery", "Corporate", 3, "NCLT and corporate debt recovery litigation.", createdDate);
            InsertService(migrationBuilder, "Commercial", "commercial-law", "Corporate", 4, "General corporate and commercial legal consulting.", createdDate);

            // 7. Arbitration
            InsertService(migrationBuilder, "Domestic Arbitration", "domestic-arbitration", "Arbitration", 1, "Representation in domestic commercial arbitration.", createdDate);
            InsertService(migrationBuilder, "Section 9 Petition", "section-9-petition", "Arbitration", 2, "Interim relief petitions under Section 9 of Arbitration Act.", createdDate);
            InsertService(migrationBuilder, "Section 11 Petition", "section-11-petition", "Arbitration", 3, "Appointment of arbitrator petitions under Section 11.", createdDate);
            InsertService(migrationBuilder, "Award Challenge", "arbitration-award-challenge", "Arbitration", 4, "Challenging arbitral awards under Section 34.", createdDate);
        }

        private static void InsertService(MigrationBuilder migrationBuilder, string title, string slug, string category, int displayOrder, string shortDesc, DateTime createdDate)
        {
            migrationBuilder.InsertData(
                table: "PracticeAreaServices",
                columns: new[] { "Title", "Slug", "CategoryName", "DisplayOrder", "ShortDescription", "FullContent", "IsActive", "IsFeatured", "CreatedDate" },
                values: new object[]
                {
                    title,
                    slug,
                    category,
                    displayOrder,
                    shortDesc,
                    $"<p>Welcome to our professional legal practice in <strong>{title}</strong>. We offer comprehensive legal assistance, drafting, and representation.</p>",
                    true,
                    false,
                    createdDate
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE [PracticeAreaServices]");
        }
    }
}