using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleCRUD.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 49, new DateTime(1974, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Serhat Demircioğlu", "+1 1774867925" },
                    { 2, 44, new DateTime(1979, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Gökçen Yılmaz", "+1 1280221170" },
                    { 3, 43, new DateTime(1980, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halkla İlişkiler", "Cem Yıldız", "+1 6391420937" },
                    { 4, 55, new DateTime(1968, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalite Güvence", "Berke Doğan", "+1 1634119861" },
                    { 5, 70, new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Hakan Tekin", "+1 7644917715" },
                    { 6, 70, new DateTime(1953, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Özlem Kara", "+1 5082755411" },
                    { 7, 60, new DateTime(1963, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eğitim ve Gelişim", "Ediz Koç", "+1 5745426751" },
                    { 8, 43, new DateTime(1980, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Arda Yalçın", "+1 5367480161" },
                    { 9, 53, new DateTime(1970, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Ziya Çetinkaya", "+1 2379992102" },
                    { 10, 18, new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halkla İlişkiler", "Furkan Çelik", "+1 2495860935" },
                    { 11, 56, new DateTime(1967, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesis Yönetimi", "Ebru Çetiner", "+1 3911316611" },
                    { 12, 39, new DateTime(1984, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Raşit Demirtaş", "+1 5182461859" },
                    { 13, 23, new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operasyon", "Selim Akgün", "+1 2635917946" },
                    { 14, 36, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Mete İçöz", "+1 5049298944" },
                    { 15, 50, new DateTime(1973, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Arif Yıldırım", "+1 9252292089" },
                    { 16, 47, new DateTime(1976, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hukuk", "Mert Kanada", "+1 1824118974" },
                    { 17, 26, new DateTime(1997, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Aylin Altun", "+1 6395646874" },
                    { 18, 72, new DateTime(1951, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halkla İlişkiler", "Mustafa Yıldız", "+1 1375269492" },
                    { 19, 64, new DateTime(1959, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalite Güvence", "Seda Koç", "+1 3458476129" },
                    { 20, 72, new DateTime(1951, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", "Cengiz Güneş", "+1 4486306495" },
                    { 21, 62, new DateTime(1961, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eğitim ve Gelişim", "Eren Toprak", "+1 1280221170" },
                    { 22, 32, new DateTime(1991, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Furkan Doğan", "+1 6391420937" },
                    { 23, 52, new DateTime(1971, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Meltem İnce", "+1 1634119861" },
                    { 24, 57, new DateTime(1966, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veri Analitiği", "Serdar Kaplan", "+1 7644917715" },
                    { 25, 30, new DateTime(1993, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hukuk", "Gökhan Kaya", "+1 5082755411" },
                    { 26, 53, new DateTime(1970, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "Emir Özkan", "+1 5745426751" },
                    { 27, 66, new DateTime(1957, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Begüm Kurt", "+1 5367480161" },
                    { 28, 55, new DateTime(1968, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Deniz Aydın", "+1 2379992102" },
                    { 29, 26, new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Oğuz Kaan", "+1 2495860935" },
                    { 30, 47, new DateTime(1976, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "Aslı Tuncel", "+1 3911316611" },
                    { 31, 44, new DateTime(1979, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "İş Geliştirme", "Burak Demir", "+1 5182461859" },
                    { 32, 24, new DateTime(1999, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Çağla Sarı", "+1 2635917946" },
                    { 33, 47, new DateTime(1976, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Yunus Emre", "+1 5049298944" },
                    { 34, 37, new DateTime(1986, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satın Alma", "Okan Çelik", "+1 9252292089" },
                    { 35, 56, new DateTime(1967, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "Ece Gündoğdu", "+1 1824118974" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
