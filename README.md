# Çalışan Yönetim Paneli



Bu, bir çalışan yönetim paneli uygulamasıdır. Uygulamanın temel özellikleri şunlardır:

## Özellikler
- Çalışan listesi görüntüleme
- Yeni çalışan ekleme
- Mevcut çalışanları güncelleme
- Çalışanları silme
- Excel formatında çalışan listesi içe/dışa aktarma
- PDF formatında çalışan listesi dışa aktarma
- Departmanlara göre çalışan dağılımını gösteren grafiksel görselleştirme
- Çalışan listesinde arama yapabilme

## Kullanılan Teknolojiler
- .NET 6 Blazor Server
- MudBlazor UI Kütüphanesi
- ClosedXML Kütüphanesi (Excel işlemleri için)
- jsPDF Kütüphanesi (PDF dışa aktarma için)
- Entity Framework Core (Veri erişimi için)
- Microsoft SQL Server (Veritabanı)

İmport işlemi için örnek veri seti ve Seed dosyası : https://disk.yandex.com.tr/i/3W_glM091nn19Q

https://github.com/user-attachments/assets/6e19983e-69b4-488f-a5c6-42d169d7571e



## Kurulum ve Çalıştırma
1. Projeyi klonlayın:
2. 2. Veritabanı bağlantı ayarlarını düzenleyin:
   - `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi veritabanı bağlantı bilgilerinizle güncelleyin. ve migration işlemlerini yapın. Otomatik veriler için migration işleminden önce dosyası için seed dosyasını DataAccess kalsörü içine yerleştirin.
3. Uygulamayı derleyin ve çalıştırın:
 
