using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_CORE_Query_Homework.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Debtors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debtors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Debtors",
                columns: new[] { "Id", "Address", "BirthDay", "Debt", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "3565 Eagles Nest Drive Woodland, CA 95695", new DateTime(1932, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2414, "ShirleyTQualls@teleworm.us", "Shirley T. Qualls", "530-662-7732" },
                    { 2, "1973 Stoneybrook Road Maitland, FL 32751", new DateTime(1953, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3599, "DanielleWGrier@rhyta.com", "Danielle W. Grier", "321-473-4178" },
                    { 3, "2432 Hannah Street Andrews, NC 28901", new DateTime(1963, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1219, "ConnieWLemire@rhyta.com", "Connie W. Lemire", "828-321-3751" },
                    { 4, "2411 Blue Spruce Lane Baltimore, MD 21202", new DateTime(1976, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3784, "CoyKAdams@dayrep.com", "Coy K. Adams", "410-347-1307" },
                    { 5, "4971 Austin Avenue Savannah, GA 31401", new DateTime(1988, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4060, "BerniceJMiles@armyspy.com", "Bernice J. Miles", "912-307-6797" },
                    { 6, "2031 Limer Street Augusta, GA 30901", new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6628, "BobLZambrano@armyspy.com", "Bob L. Zambrano", "706-446-1649" },
                    { 7, "2737 Rardin Drive San Jose, CA 95110", new DateTime(1950, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5412, "AdamDBartlett@rhyta.com", "Adam D. Bartlett", "650-693-1758" },
                    { 8, "16 Fraggle Drive Hickory Hills, IL 60457", new DateTime(1936, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11097, "PabloMSkinner@armyspy.com", "Pablo M. Skinner", "630-391-2034" },
                    { 9, "699 Harper Street Louisville, KY 40202", new DateTime(1971, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7956, "DorothyJBrown@rhyta.com", "Dorothy J. Brown", "270-456-3288" },
                    { 10, "2940 Adams Avenue Columbia, MD 21044", new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7150, "LarryAMiracle@jourrapide.com", "Larry A. Miracle", "301-621-3318" },
                    { 11, "4821 Elk Rd Little Tucson, AZ 85704", new DateTime(1944, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2910, "DonnaBMaynard@teleworm.us", "Donna B. Maynard", "520-297-0575" },
                    { 12, "2527 Terra Street Custer, WA 98240", new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11805, "JessicaJStoops@dayrep.com", "Jessica J. Stoops", "360-366-8101" },
                    { 13, "151 Christie Way Marlboro, MA 01752", new DateTime(1937, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1001, "AudryMStyles@jourrapide.com", "Audry M. Styles", "978-773-4802" },
                    { 14, "1460 Walt Nuzum Farm Road Rochester, NY 14620", new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9128, "VioletRAnguiano@dayrep.com", "Violet R. Anguiano", "585-340-7888" },
                    { 15, "1824 Roosevelt Street Fremont, CA 94539", new DateTime(1970, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5648, "CharlesPSegundo@dayrep.com", "Charles P. Segundo", "415-367-3341" },
                    { 16, "759 Havanna Street Saxapahaw, NC 27340", new DateTime(1944, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10437, "PaulHSturtz@dayrep.com", "Paul H. Sturtz", "336-376-1732" },
                    { 17, "3172 Bedford Street Birmingham, AL 35203", new DateTime(1978, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7230, "DorisBKing@rhyta.com", "Doris B. King", "205-231-8973" },
                    { 18, "1972 Orchard Street Bloomington, MN 55437", new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 515, "DeannaJDonofrio@rhyta.com", "Deanna J. Donofrio", "952-842-7576" },
                    { 19, "3749 Capitol Avenue New Castle, IN 47362", new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1816, "MartinSMalinowski@dayrep.com", "Martin S. Malinowski", "765-599-3523" },
                    { 20, "922 Hill Croft Farm Road Sacramento, CA 95814", new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5037, "MelissaRArner@armyspy.com", "Melissa R. Arner", "530-508-7328" },
                    { 21, "4738 Chapmans Lane Grants, NM 87020", new DateTime(1969, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7755, "KellyGHoffman@armyspy.com", "Kelly G. Hoffman", "505-876-8935" },
                    { 22, "124 Wood Street Saginaw, MI 48607", new DateTime(1986, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11657, "DoyleBShort@teleworm.us", "Doyle B. Short", "989-221-4363" },
                    { 23, "74 Pine Street Pittsburgh, PA 15222", new DateTime(1960, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9693, "LorrieRGilmore@teleworm.us", "Lorrie R. Gilmore", "724-306-7138" },
                    { 24, "29 Goldleaf Lane Red Bank, NJ 07701", new DateTime(1972, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2712, "LionelACook@jourrapide.com", "Lionel A. Cook", "201-627-5962" },
                    { 25, "4686 Renwick Drive Philadelphia, PA 19108", new DateTime(1990, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4016, "CharleneCBurke@armyspy.com", "Charlene C. Burke", "484-334-9729" },
                    { 26, "748 Rockford Road Westborough, MA 01581", new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 349, "TommyMPatton@rhyta.com", "Tommy M. Patton", "774-571-6481" },
                    { 27, "15 Hewes Avenue Towson, MD 21204", new DateTime(1944, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9824, "KristinSBloomer@dayrep.com", "Kristin S. Bloomer", "443-652-0734" },
                    { 28, "3052 Walton Street Salt Lake City, UT 84104", new DateTime(1997, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8215, "DanielKJames@rhyta.com", "Daniel K. James", "801-407-4693" },
                    { 29, "3575 Eagle Street Norris City, IL 62869", new DateTime(1976, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5766, "PaulaDHenry@rhyta.com", "Paula D. Henry", "618-378-5307" },
                    { 30, "675 Jehovah Drive Martinsville, VA 24112", new DateTime(1947, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8363, "DonnaCSandoval@rhyta.com", "Donna C. Sandoval", "540-482-5463" },
                    { 31, "2812 Rowes Lane Paducah, KY 42001", new DateTime(1932, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7785, "RobertTTaylor@armyspy.com", "Robert T. Taylor", "270-596-6442" },
                    { 32, "4367 Christie Way Marlboro, MA 01752", new DateTime(1948, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10030, "DonnaWAlamo@teleworm.us", "Donna W. Alamo", "978-778-2533" },
                    { 33, "85 Elmwood Avenue Chandler, AZ 85249", new DateTime(1995, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5347, "AmyRParmer@armyspy.com", "Amy R. Parmer", "480-883-4934" },
                    { 34, "3552 Columbia Road Greenwood Village, CO 80111", new DateTime(1986, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9838, "NewtonKEvans@rhyta.com", "Newton K. Evans", "303-207-9084" },
                    { 35, "316 Elsie Drive Fort Thompson, SD 57339", new DateTime(1949, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1672, "KathleenCChaney@rhyta.com", "Kathleen C. Chaney", "605-245-3513" },
                    { 36, "4146 May Street Sharpsburg, KY 40374", new DateTime(1957, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9195, "ManuelCJohnson@jourrapide.com", "Manuel C. Johnson", "606-247-2659" },
                    { 37, "3106 Bates Brothers Road Columbus, OH 43215", new DateTime(1988, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11271, "CarlaACreagh@dayrep.com", "Carla A. Creagh", "614-307-8974" },
                    { 38, "965 Metz Lane Woburn, MA 01801", new DateTime(1988, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9761, "NormaMNew@jourrapide.com", "Norma M. New", "857-492-8703" },
                    { 39, "401 Romrog Way Grand Island, NE 68801", new DateTime(1983, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 10771, "RoyDGreen@jourrapide.com", "Roy D. Green", "308-340-5981" },
                    { 40, "2177 Harley Vincent Drive Cleveland, OH 44113", new DateTime(1935, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5205, "CristyJJensen@jourrapide.com", "Cristy J. Jensen", "440-626-9550" },
                    { 41, "3584 Jadewood Drive Demotte, IN 46310", new DateTime(1993, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1276, "NancyJFergerson@dayrep.com", "Nancy J. Fergerson", "219-987-8498" },
                    { 42, "1890 Poco Mas Drive Dallas, TX 75247", new DateTime(1938, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9132, "DaveNRodriguez@rhyta.com", "Dave N. Rodriguez", "214-540-2499" },
                    { 43, "1444 Rose Avenue Metairie, LA 70001", new DateTime(1988, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8176, "JamesEDenning@jourrapide.com", "James E. Denning", "504-289-8640" },
                    { 44, "4454 Green Avenue Oakland, CA 94609", new DateTime(1972, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7875, "RichardMThomas@jourrapide.com", "Richard M. Thomas", "510-735-3359" },
                    { 45, "3121 Quarry Drive Montgomery, AL 36117", new DateTime(1973, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3088, "LakishaRForrest@armyspy.com", "Lakisha R. Forrest", "334-830-1181" },
                    { 46, "3239 Tori Lane Salt Lake City, UT 84104", new DateTime(1959, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6588, "PamelaHBeauchamp@jourrapide.com", "Pamela H. Beauchamp", "801-559-6347" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Debtors");
        }
    }
}
