# 🗂️ Entity Framework DB First - Category & Product CRUD Uygulaması

Bu proje, Entity Framework **Database First** yaklaşımını öğrenmek amacıyla geliştirilmiştir. Uygulamada SQL Server üzerinde oluşturulmuş **Category** ve **Product** tabloları kullanılarak temel CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilmiştir.

---

## 🚀 Proje Özellikleri

- ✅ **Entity Framework Database First** kullanımı
- ✅ SQL Server veritabanı bağlantısı
- ✅ `Scaffold-DbContext` ile otomatik model üretimi
- ✅ `Category` ve `Product` tablolarında:
  - 🔄 Listeleme
  - ➕ Ekleme
  - 📝 Güncelleme
  - ❌ Silme
- ✅ ASP.NET MVC üzerinden arayüz 

---

## 🧱 Kullanılan Teknolojiler

- .NET Framework (versiyon: 4.x)
- C#
- Entity Framework 6 / Core (DB First)
- SQL Server
- Visual Studio

---

## 🗃️ Veritabanı Yapısı

### Category
| Kolon Adı   | Tipi       |
|-------------|------------|
| CategoryId  | int (PK)   |
| Name        | nvarchar   |

### Product
| Kolon Adı   | Tipi         |
|-------------|--------------|
| ProductId   | int (PK)     |
| Name        | nvarchar     |
| Price       | decimal      |
| Stock       | int          |
| CategoryId  | int (FK)     |

---
## Ekran Görüntüleri
<img width="1919" height="1079" alt="Screenshot 2025-07-23 234401" src="https://github.com/user-attachments/assets/62f29c67-0805-4463-9481-b5fcdc1ffbe6" />
<img width="1919" height="1079" alt="Screenshot 2025-07-23 234406" src="https://github.com/user-attachments/assets/e0313a97-86e4-4e38-a9a1-4f36d8d553e6" />
<img width="1919" height="1079" alt="Screenshot 2025-07-23 234413" src="https://github.com/user-attachments/assets/faddc25f-c14f-4943-b185-2fcf8dbcca0c" />
<img width="1919" height="1079" alt="Screenshot 2025-07-23 234426" src="https://github.com/user-attachments/assets/433280d1-a227-4211-8ee9-f13c7076cb13" />


