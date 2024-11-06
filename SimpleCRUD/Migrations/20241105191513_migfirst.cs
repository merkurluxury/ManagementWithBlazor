using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleCRUD.Migrations
{
    /// <inheritdoc />
    public partial class migfirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 36, 41, new DateTime(1982, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Yasemin Polat", "+1 6178291847" },
                    { 37, 33, new DateTime(1990, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Üretim", "Bülent Karataş", "+1 7259614823" },
                    { 38, 49, new DateTime(1974, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe", "Sibel Aydın", "+1 3640916825" },
                    { 39, 35, new DateTime(1988, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "İş Geliştirme", "Cenk Durmaz", "+1 4762910483" },
                    { 40, 28, new DateTime(1995, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Deniz Özsoy", "+1 5287369172" },
                    { 41, 37, new DateTime(1986, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satın Alma", "Zehra Duman", "+1 9842376184" },
                    { 42, 58, new DateTime(1965, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Serkan Özdemir", "+1 6382047185" },
                    { 43, 42, new DateTime(1981, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalite Güvence", "Ceyda Çalışkan", "+1 4861920743" },
                    { 44, 30, new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eğitim ve Gelişim", "Emre Taş", "+1 2759816274" },
                    { 45, 54, new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Mehmet Karabacak", "+1 1538476093" },
                    { 46, 40, new DateTime(1983, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Zeynep Gün", "+1 5374829187" },
                    { 47, 51, new DateTime(1972, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Aslı Kılıç", "+1 8391025739" },
                    { 48, 45, new DateTime(1978, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesis Yönetimi", "Eren Özkan", "+1 6247391085" },
                    { 49, 27, new DateTime(1996, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", "Tuna Tekin", "+1 2938165092" },
                    { 50, 38, new DateTime(1985, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Gizem Kaya", "+1 5284017623" },
                    { 51, 43, new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "Hüseyin Çelik", "+1 3461920847" },
                    { 52, 31, new DateTime(1992, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Özge Kara", "+1 5748392015" },
                    { 53, 34, new DateTime(1989, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Tolga Demir", "+1 6174382915" },
                    { 54, 48, new DateTime(1975, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Melih Öz", "+1 8291630482" },
                    { 55, 29, new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe", "Yelda Arslan", "+1 2748193607" },
                    { 56, 51, new DateTime(1972, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Kerem Güçlü", "+1 7251746384" },
                    { 57, 25, new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Gizem Koç", "+1 6291843765" },
                    { 58, 48, new DateTime(1975, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hukuk", "Merve Aydın", "+1 2851473912" },
                    { 59, 32, new DateTime(1991, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Burak Işık", "+1 3917248375" },
                    { 60, 56, new DateTime(1967, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Seda Tunç", "+1 1932487163" },
                    { 61, 41, new DateTime(1982, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalite Güvence", "Aylin Güven", "+1 6394715286" },
                    { 62, 33, new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Cem Karaca", "+1 9274315078" },
                    { 63, 52, new DateTime(1971, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "İlker Kaya", "+1 3871956240" },
                    { 64, 43, new DateTime(1980, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mühendislik", "Derya Ekinci", "+1 7261847360" },
                    { 65, 50, new DateTime(1973, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "İş Geliştirme", "Cihan Arslan", "+1 4871326059" },
                    { 66, 35, new DateTime(1988, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veri Analitiği", "Ayhan Çelik", "+1 3729146720" },
                    { 67, 30, new DateTime(1993, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Selma Özkan", "+1 1837416583" },
                    { 68, 60, new DateTime(1963, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Sinan Yıldırım", "+1 5273916428" },
                    { 69, 47, new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eğitim ve Gelişim", "Feride Eroğlu", "+1 8467129354" },
                    { 70, 28, new DateTime(1995, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün Yönetimi", "Onur Bayram", "+1 6294712835" },
                    { 71, 42, new DateTime(1981, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Nilay Keskin", "+1 9371246853" },
                    { 72, 31, new DateTime(1992, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalite Güvence", "Esra Erkan", "+1 4718392750" },
                    { 73, 63, new DateTime(1960, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Araştırma ve Geliştirme (Ar-Ge)", "Mehmet Akça", "+1 5273194826" },
                    { 74, 36, new DateTime(1987, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operasyon", "Rukiye Coşkun", "+1 6182379450" },
                    { 75, 48, new DateTime(1975, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "İdari İşler", "Mete Bayat", "+1 9732186405" },
                    { 76, 24, new DateTime(1999, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hukuk", "Nur Şahin", "+1 8362815496" },
                    { 77, 54, new DateTime(1969, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Kerem Taş", "+1 1924671530" },
                    { 78, 39, new DateTime(1984, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Destek", "Sibel Özbek", "+1 9387154260" },
                    { 79, 44, new DateTime(1979, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veri Analitiği", "Enes Kar", "+1 5271938406" },
                    { 80, 39, new DateTime(1985, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Özlem Aydın", "+1 9238471562" },
                    { 81, 34, new DateTime(1990, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Murat Kaya", "+1 9238471563" },
                    { 82, 36, new DateTime(1988, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Elif Yılmaz", "+1 9238471564" },
                    { 83, 41, new DateTime(1983, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Ahmet Demir", "+1 9238471565" },
                    { 84, 32, new DateTime(1992, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Ayşe Karaca", "+1 9238471566" },
                    { 85, 39, new DateTime(1985, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Emre Can", "+1 9238471567" },
                    { 86, 33, new DateTime(1991, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Hizmetleri", "Gözde Akın", "+1 9238471568" },
                    { 87, 37, new DateTime(1987, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Hakan Yıldız", "+1 9238471569" },
                    { 88, 35, new DateTime(1989, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe", "Seda Acar", "+1 9238471570" },
                    { 89, 40, new DateTime(1984, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar-Ge", "Levent Çelik", "+1 9238471571" },
                    { 90, 31, new DateTime(1993, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Deniz Şahin", "+1 9238471572" },
                    { 91, 38, new DateTime(1986, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Berkay Uzun", "+1 9238471573" },
                    { 92, 30, new DateTime(1994, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Esra Güven", "+1 9238471574" },
                    { 93, 42, new DateTime(1982, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Selim Aksoy", "+1 9238471575" },
                    { 94, 37, new DateTime(1987, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Derya Öztürk", "+1 9238471576" },
                    { 95, 35, new DateTime(1989, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Hizmetleri", "Onur Yavuz", "+1 9238471577" },
                    { 96, 33, new DateTime(1991, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Serap Akbulut", "+1 9238471578" },
                    { 97, 41, new DateTime(1983, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Canan Özdemir", "+1 9238471579" },
                    { 98, 29, new DateTime(1995, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar-Ge", "Metin Alkan", "+1 9238471580" },
                    { 99, 36, new DateTime(1988, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe", "Gizem Kılıç", "+1 9238471581" },
                    { 100, 39, new DateTime(1985, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Tamer Çetin", "+1 9238471582" },
                    { 101, 32, new DateTime(1992, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Zeynep Şen", "+1 9238471583" },
                    { 102, 40, new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finans", "Furkan Tekin", "+1 9238471584" },
                    { 103, 31, new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satış", "Ceren Koç", "+1 9238471585" },
                    { 104, 38, new DateTime(1986, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müşteri Hizmetleri", "Yusuf Er", "+1 9238471586" },
                    { 105, 34, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları (İK)", "Ece Aydın", "+1 9238471587" },
                    { 106, 37, new DateTime(1987, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lojistik", "Selda Çelik", "+1 9238471588" },
                    { 107, 33, new DateTime(1991, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar-Ge", "Rıza Tan", "+1 9238471589" },
                    { 108, 41, new DateTime(1983, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe", "Mine Sezer", "+1 9238471590" },
                    { 109, 35, new DateTime(1989, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi Teknolojileri (BT)", "Emel Korkmaz", "+1 9238471591" },
                    { 110, 30, new DateTime(1994, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pazarlama", "Orhan Öz", "+1 9238471592" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 110);
        }
    }
}
