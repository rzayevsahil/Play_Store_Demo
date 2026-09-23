# Play Store Demo

## TR | Proje Hakkında
Bu projede, oyun mağazası işlevselliğini simüle eden bir uygulama geliştirilmiştir.  
Amaç, oyuncu yönetimi, e-devlet doğrulaması, oyun satışı ve kampanya yönetimi süreçlerini temel düzeyde modellemektir.

### Gereksinimler
1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği ve kayıtlarını silebileceği bir ortam simüle edilmelidir.  
   Müşteri bilgilerinin doğruluğu, e-devlet sistemlerinde kullanılan TcNo, Ad, Soyad ve Doğum Yılı bilgileriyle doğrulanmalıdır (Bu servis simüle edilecektir).  
2. Oyun satışı yapılabilecek bir satış ortamı simüle edilmelidir. Satışlar oyuncu ile ilişkilendirilmelidir (Oyuncu metot parametresi olarak kullanılacaktır).  
3. Sisteme yeni kampanya ekleme, kampanya silme ve güncelleme işlemleri simüle edilmelidir.  
4. Satışlarda kampanya entegrasyonu simüle edilmelidir (kampanya indirimleri vb.).

---

## EN | About the Project
This project simulates a play store application.  
The goal is to model basic player management, e-government verification, game sales, and campaign management processes.

### Requirements
1. Simulate an environment where players can register, update their information, and delete their records.  
   Customer information verification should be done using TcNo, Name, Surname, and Year of Birth as in e-government systems (this service will be simulated).  
2. Simulate a sales environment where games can be sold. Sales must be associated with the player (player will be a method parameter).  
3. Simulate adding, deleting, and updating campaigns in the system.  
4. Simulate campaign integration in sales (e.g., applying discounts).

---

## Kurulum ve Çalıştırma / Installation and Running

1. Depoyu klonlayın / Clone the repository:  
   `git clone <repository-url>`
2. Proje dizinine gidin / Navigate to project folder:  
   `cd Play_Store_Demo`
3. Bağımlılıkları yükleyin ve projeyi derleyin / Restore dependencies and build the project:  
   `dotnet restore`  
   `dotnet build`
4. Uygulamayı çalıştırın / Run the application:  
   `dotnet run --project PlayStoreOdev`

---

## Kullanım / Usage

- Oyuncu kayıt, güncelleme ve silme işlemleri için ilgili servis metotları kullanılabilir.  
- E-devlet doğrulama servisi simüle edilmiştir, oyuncu bilgileri bu servisle doğrulanır.  
- Oyun satışı yapılırken oyuncu bilgisi parametre olarak verilir ve kampanyalar satışa uygulanır.  
- Kampanya yönetimi için kampanya ekleme, güncelleme ve silme metotları mevcuttur.

---

## Proje Yapısı / Project Structure

- `PlayStoreOdev/` — Ana proje klasörü  
- `PlayStoreOdev.sln` — Visual Studio çözüm dosyası  
- `.gitignore`, `.gitattributes` — Git yapılandırma dosyaları  
- `README.md` — Proje dokümantasyonu

---

## Katkıda Bulunma / Contributing

Katkılarınızı bekliyoruz!  
Lütfen yeni özellikler veya düzeltmeler için bir branch oluşturup pull request gönderin.

---

## Lisans / License

Bu proje için lisans bilgisi belirtilmemiştir.  
İsterseniz uygun bir lisans ekleyebilirsiniz (örneğin MIT).

---

## Görseller / Screenshots

![1](https://user-images.githubusercontent.com/58303745/106641389-95f58380-65a0-11eb-9422-5eb4f94c5695.jpg)  
![2](https://user-images.githubusercontent.com/58303745/106641472-b1608e80-65a0-11eb-8a30-1781ac57a63c.jpg)  
![3](https://user-images.githubusercontent.com/58303745/106641538-c1786e00-65a0-11eb-951c-7a589a7a50ba.jpg)

---

Herhangi bir ekleme veya detaylandırma isterseniz, yardımcı olmaya hazırım.
