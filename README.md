# Cisimlerin Çarpışma Kontrolü (C# WinForms)

Bu proje, 2D ve 3D uzayda serbest halde duran cisimlerin çarpışma durumlarını kontrol eden bir **Windows Forms** uygulamasıdır.  
Çarpışma denetimleri, **C#** dilinde nesne tabanlı programlama (OOP) yaklaşımı ile sınıflar ve metotlar kullanılarak geliştirilmiştir.

## 🎯 Amaç
Farklı geometrik şekillerin (nokta, dikdörtgen, çember, küre, silindir, prizma vb.) koordinat sistemindeki konumlarını dikkate alarak, birbirleriyle çarpışıp çarpışmadıklarını tespit eden algoritmalar geliştirmek.

## 🛠 Kullanılan Teknolojiler
- **C#** (.NET Framework)
- **Windows Forms**
- Nesne Tabanlı Programlama (OOP)
- **List<T>** koleksiyonları
- **Math** sınıfı (mesafe hesaplamaları)
- Random veri üretimi

## 📌 Özellikler
Projede aşağıdaki çarpışma kontrol yöntemleri uygulanmıştır:

### 2D Çarpışma Denetimleri
1. **Nokta - Dikdörtgen**
2. **Nokta - Çember**
3. **Dikdörtgen - Dikdörtgen**
4. **Dikdörtgen - Çember**
5. **Çember - Çember**

### 3D Çarpışma Denetimleri
6. **Nokta - Küre**
7. **Nokta - Dikdörtgen Prizma**
8. **Nokta - Silindir**
9. **Silindir - Silindir**
10. **Küre - Küre**
11. **Küre - Silindir**
12. **Yüzey - Küre**
13. **Yüzey - Dikdörtgen Prizma**
14. **Yüzey - Silindir**
15. **Küre - Dikdörtgen Prizma**
16. **Dikdörtgen Prizma - Dikdörtgen Prizma**

## 🔍 Çalışma Mantığı
- Her geometrik şekil için merkez koordinatları (x, y, z), boyut bilgileri (genişlik, yükseklik, yarıçap vb.) tanımlanır.
- **List<T>** yapısı ile bu şekiller rastgele oluşturulur.
- Çarpışma kontrolü için ilgili matematiksel formüller kullanılır:
  - **Mesafe hesaplama**: İki nokta arasındaki mesafe veya mesafenin karesi
  - **Koordinat karşılaştırma**: Şekillerin sol, sağ, üst, alt, ön, arka sınırlarının kontrolü
  - **Kesişim şartları**: Mantıksal (if-else) yapılarla çarpışma koşullarının değerlendirilmesi
- Sonuçlar, Windows Forms arayüzünde kullanıcıya gösterilir.
