## 📚 Solid Principles

SOLID prensiplerini benimsemek, bir yazılım mimarının ve geliştiricinin kariyerinde belirleyici bir faktördür. Bu prensipler, yazılımın gelecekteki değişikliklere karşı direncini artırır, kodun okunabilirliğini ve anlaşılırlığını geliştirir ve yeniden kullanılabilirliği teşvik eder. Özellikle ASP.NET Core gibi modern uygulamalarda, SOLID ilkelerinin uygulanması modülerlik, sürdürülebilirlik ve ölçeklenebilirlik açısından hayati bir rol oynar. Bu ilkeler sayesinde, geliştiriciler esnek ve sürdürülebilir nesne yönelimli sistemler oluşturabilirler ki bu da günümüz iş piyasasında aranan önemli bir gerekliliktir.  

- **S** - Single Responsibility Principle (Tek Sorumluluk Prensibi)
- **O** - Open/Closed Principle (Açık/Kapalı Prensibi)
- **L** - Liskov Substitution Principle (Liskov Yerine Koyma Prensibi)
- **I** - Interface Segregation Principle (Arayüz Ayırma Prensibi)
- **D** - Dependency Inversion Principle (Bağımlılık Tersine Çevirme Prensibi)

---

**🧱 S - Single Responsibility Principle (SRP)**

**Bir sınıfın sadece tek bir sorumluluğu olmalı.**

- Her sınıf, sadece tek bir iş yapmalı.
- Bir değişiklik olduğunda, sınıf tek bir nedenle değiştirilmeli.

**✅ Örnek:** ReportGenerator sadece rapor üretir, ReportSaver sadece kaydeder.

![image](https://github.com/user-attachments/assets/02e4a039-b387-4a4e-b771-70ba117c195c)

---

**🚪 O - Open/Closed Principle (OCP)**

**Sınıflar genişlemeye açık, değişikliğe kapalı olmalı.**

- Yeni davranışlar eklerken mevcut kodu değiştirmeden genişletebilmeliyiz.

**✅ Örnek:** PaymentProcessor sınıfını değiştirmeden yeni ödeme yöntemleri (GooglePay, ApplePay) ekleyebilirsin.

![image](https://github.com/user-attachments/assets/42b6e1ee-9526-44d2-8e32-92b058d024f6)

---

**🦅 L - Liskov Substitution Principle (LSP)**

**Türetilmiş sınıflar, base sınıf gibi davranabilmeli.**

- Alt sınıflar, üst sınıfın yerine sorunsuz kullanılabilmeli.

**✅ Örnek:** Eagle sınıfı Bird ve IFlyingBird gibi kullanılabilir, ama Ostrich uçamadığı için sadece Bird.

![image](https://github.com/user-attachments/assets/0ec2adda-a577-4b5b-aeb0-9a2c4e011756)

---

 **🧩I - Interface Segregation Principle (ISP)**

**İstemciler kullanmadıkları metotlara bağımlı kalmamalı.**

- Arayüzler küçük ve odaklı olmalı.

✅ Örnek: RobotWorker sadece IWorkable, ama HumanWorker hem IWorkable, IEatable hem de ISleepable.

![image](https://github.com/user-attachments/assets/227d2101-ff3a-4865-88fe-9479552d74a3)

---

**🔌 D - Dependency Inversion Principle (DIP)**

**Yüksek seviyeli sınıflar, düşük seviyeli sınıflara değil; soyutlamalara bağımlı olmalı.**

- Sınıflar, doğrudan somut bağımlılıklara değil, arayüzlere (interface) bağlı olmalı.

✅ Örnek: SmartSwitch, LightBulb veya LedStrip yerine ILightDevice arayüzüne bağlıdır.

![image](https://github.com/user-attachments/assets/28e95c4c-c0fa-49d1-a2e8-d5792b026ae9)

---
