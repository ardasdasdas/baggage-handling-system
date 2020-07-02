# Bagaj Taşıma Sistemi
Bagaj Taşıma Sistemi havaalanlarında kontrol edilen bagajların hareket eden bir bant vasıtasıyla uçağa taşıma ve uçaktan bagaj teslim noktasına taşınma modelidir. Bu sistem Biçimsel Diller ve Otomata dersinde Sonlu Devinim Otomata (NFA) konusu ile alakalıdır.
Yapılan uygulama OPCAT üzerinde modellenerek C# üzerinde simülasyonu yapıldı.

## 1. NFA Diyagramı
NFA KABUL DURUMU (iki adet örnek verilmiştir):
ID OK OK OK OK OK NO-MORE-FLIGHT,
ID OK OK OK OK OK ANOTHER-FLIGHT OK OK NO-MORE-FLIGHT
DFA RET DURUMU (iki adet örnek verilmiştir):
ID OK OK OK OK OK
ID OK OK OK OK LOST-BAGGAGE

∑ {ID, OK, missing document,baggage overload,invalid item,lost baggage,no more flight,another flight}

![bhs_NFA](https://user-images.githubusercontent.com/53192718/86411175-efbd6480-bcc4-11ea-83c6-43ac1af96949.jpg)
## 2. Uygulama Yazılım Dizaynı
### 2.1 Giriş Ekranı
Simülasyonun karşımıza çıkan ilk arayüzü yukarıdaki görseldir. Bu arayüz de yolcunun uçuş numarası ve kimlik numarasına göre check-in işlemini gerçekleştiriyor. Eğer yolcu biletini henüz almamış ise biletini alması için add passenger arayüzüne geçiş yapmak zorundadır.

![giriş](https://user-images.githubusercontent.com/53192718/86411265-25624d80-bcc5-11ea-9038-04fa65a026f1.png)

### 2.2 Yolcu Ekleme Ekranı
Add Passenger arayüz tasarımı yukarıdaki görseldir. Burada kişinin bilgileri alınır ve yeni yolcu oluşturulur.Back Check -In  kısmı ile de yolcu check-in kısmına yönlendirilir.

![yolcu ekle](https://user-images.githubusercontent.com/53192718/86411319-475bd000-bcc5-11ea-9e94-c89d3a29e937.png)

### 2.3 Bagaj Taşıma Ekranı
Check-In işlemi tamamlandıktan sonra Baggage Handling System’in arayüzü karşımıza çıkmaktadır. Bu sistemde genel amaç bagajların başlangıç konumundan varış konumuna nasıl taşındığını göstermektir.

![bagaj taşıma](https://user-images.githubusercontent.com/53192718/86411415-825e0380-bcc5-11ea-8cf5-794503eda31b.png)

### 2.4 Bagaj Ağırlık Kontrol Ekranı
Check-in kısmını başarıyla geçen yolcu bu arayüz de bagajının ağırlığını kontrol ettirir.Eğer belirlenen kilogram sınırını aşmış ise fazladan bagaj hakkı satın alır.

![ağırlıkkontrol](https://user-images.githubusercontent.com/53192718/86411504-aa4d6700-bcc5-11ea-9c5a-8aef594ec447.png)

### 2.5 Güvenlik Ekranı
Baggage Check işlemini başarıyla geçen bagaj Securtiy arayüzüne gelir ve içerisinde şüpheli bir eşya var mı yok mu kontrol edilir. Eğer şüpheli bir eşya var ise çıkarılması beklenir.

![güvenlik](https://user-images.githubusercontent.com/53192718/86411587-d4068e00-bcc5-11ea-9690-78fb08d4b458.png)

### Bagaj Dağıtım Ekranı
Securtiy işlemini başarıyla geçen bagaj bu arayüz de Sort işlemine tabi tutulur. Bu Sort işlemi sırasında kaybolan bir bagaj var ise Lost Property Table kısmına yönlendirilir.

![sort](https://user-images.githubusercontent.com/53192718/86412050-d61d1c80-bcc6-11ea-8697-7cc80e59aefc.gif)









