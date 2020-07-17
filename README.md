# Bagaj Taşıma Sistemi
Bagaj Taşıma Sistemi havaalanlarında kontrol edilen bagajların hareket eden bir bant vasıtasıyla uçağa taşıma ve uçaktan bagaj teslim noktasına taşınma modelidir. Bu sistem Biçimsel Diller ve Otomata dersinde Sonlu Devinim Otomata (NFA) konusu ile alakalıdır.
Yapılan uygulama OPCAT üzerinde modellenerek C# üzerinde simülasyonu yapıldı.
### 1 - [NFA Diyagramı](https://github.com/ardasdasdas/baggage-handling-system#1-nfa-diyagram%C4%B1)
### 2 - [Uygulama Yazılım Dizaynı](https://github.com/ardasdasdas/baggage-handling-system#2-uygulama-yaz%C4%B1l%C4%B1m-dizayn%C4%B1)
### 3 - [Opcat Tasarım Ekran Görüntüleri](https://github.com/ardasdasdas/baggage-handling-system#3-opcat-tasar%C4%B1m-ekran-g%C3%B6r%C3%BCnt%C3%BCleri)
### 4 - [Takım Üyeleri](https://github.com/ardasdasdas/baggage-handling-system#4-tak%C4%B1m-%C3%BCyeleri)
## 1. NFA Diyagramı
NFA KABUL DURUMU (iki adet örnek verilmiştir):
ID OK OK OK OK OK NO-MORE-FLIGHT,
ID OK OK OK OK OK ANOTHER-FLIGHT OK OK NO-MORE-FLIGHT
DFA RET DURUMU (iki adet örnek verilmiştir):
ID OK OK OK OK OK
ID OK OK OK OK LOST-BAGGAGE

∑ {ID, OK, missing document,baggage overload,invalid item,lost baggage,no more flight,another flight}

![bhs_NFA](https://user-images.githubusercontent.com/53192718/86411175-efbd6480-bcc4-11ea-83c6-43ac1af96949.jpg)

### 1.1 Geçiş Tablosu
![transitiontable1](https://user-images.githubusercontent.com/53192718/86413064-fc43bc00-bcc8-11ea-973a-57258cc698a9.png)
![transitiontable2](https://user-images.githubusercontent.com/53192718/86413066-fcdc5280-bcc8-11ea-9add-d315515e0baf.png)

## 2. Uygulama Yazılım Dizaynı
### 2.1 Giriş Ekranı
Simülasyonun karşımıza çıkan ilk arayüzü aşağıdaki görseldir. Bu arayüz de yolcunun uçuş numarası ve kimlik numarasına göre check-in işlemini gerçekleştiriyor. Eğer yolcu biletini henüz almamış ise biletini alması için add passenger arayüzüne geçiş yapmak zorundadır.

![giriş](https://user-images.githubusercontent.com/53192718/86411265-25624d80-bcc5-11ea-9038-04fa65a026f1.png)

### 2.2 Yolcu Ekleme Ekranı
Add Passenger arayüz tasarımı aşağıdaki görseldir. Burada kişinin bilgileri alınır ve yeni yolcu oluşturulur. Back Check -In  kısmı ile de yolcu check-in kısmına yönlendirilir.

![yolcu ekle](https://user-images.githubusercontent.com/53192718/86411319-475bd000-bcc5-11ea-9e94-c89d3a29e937.png)

### 2.3 Bagaj Taşıma Ekranı
Check-In işlemi tamamlandıktan sonra Baggage Handling System’in arayüzü karşımıza çıkmaktadır. Bu sistemde genel amaç bagajların başlangıç konumundan varış konumuna nasıl taşındığını göstermektir.

![bagaj taşıma](https://user-images.githubusercontent.com/53192718/86411415-825e0380-bcc5-11ea-8cf5-794503eda31b.png)

### 2.4 Bagaj Ağırlık Kontrol Ekranı
Check-in kısmını başarıyla geçen yolcu bu arayüzde bagajının ağırlığını kontrol ettirir. Eğer belirlenen kilogram sınırını aşmış ise fazladan bagaj hakkı satın alır.

![ağırlıkkontrol](https://user-images.githubusercontent.com/53192718/86411504-aa4d6700-bcc5-11ea-9c5a-8aef594ec447.png)

### 2.5 Güvenlik Ekranı
Baggage Check işlemini başarıyla geçen bagaj Securtiy arayüzüne gelir ve içerisinde şüpheli bir eşya var mı yok mu kontrol edilir. Eğer şüpheli bir eşya var ise çıkarılması beklenir.

![luggage1](https://user-images.githubusercontent.com/53192718/86413628-5729e300-bcca-11ea-8a72-166972115625.png)

### 2.6 Bagaj Dağıtım Ekranı
Securtiy işlemini başarıyla geçen bagaj bu arayüzde Sort işlemine tabi tutulur. Bu Sort işlemi sırasında kaybolan bir bagaj var ise Lost Property Table kısmına yönlendirilir.

![sort](https://user-images.githubusercontent.com/53192718/86412050-d61d1c80-bcc6-11ea-8697-7cc80e59aefc.gif)

### 2.7 Bagaj Yükleme Ekranı
Sort işlemini başarıyla geçen bagaj bu arayüzde uçağa yüklenir. Eğer yükleme aşamasında kaybolan bir bagaj var ise Lost Property Table kısmına yönlendirilir.

![Load](https://user-images.githubusercontent.com/53192718/86412136-02d13400-bcc7-11ea-80f9-079059bae568.gif)

### 2.8 Bagaj İndirme Ekranı
Uçak varış noktasına geldiğinde bu arayüzde bagajların indirme işlemi yapılır.


![unload](https://user-images.githubusercontent.com/53192718/86413330-973c9600-bcc9-11ea-8efe-3f791667a9ed.gif)

### 2.9 Bagaj Transfer Ekranı
Transfer olacak bagaj burada bantlar üzerinde valiz taşıma tabi tutulur.

![baggagesTransfer](https://user-images.githubusercontent.com/53192718/86412689-3496ca80-bcc8-11ea-8924-eecc2cfb6007.gif)

### 2.10 Kayıp Bagaj Ekranı
Kaybolan bagajlar bu kısma gelerek Baggage ID bilgisine göre yolcuya verilir.

![kayıp bagaj ekranı](https://user-images.githubusercontent.com/53192718/86412775-5c862e00-bcc8-11ea-95cc-4729d84720e6.png)

### 2.11 Bagaj Teslim Ekranı
Bütün işlemlerden başarıyla geçen bagaj Baggage Claim’e gelerek yolcuya verilir.

![Arrival](https://user-images.githubusercontent.com/53192718/86412815-6e67d100-bcc8-11ea-9e2a-51ff84e5a30a.png)

## 3. Opcat Tasarım Ekran Görüntüleri
![OPD OPL_1](https://user-images.githubusercontent.com/53192718/86412925-a40cba00-bcc8-11ea-8b9b-a5e848ed6f79.png)
![OPD_2](https://user-images.githubusercontent.com/53192718/86412961-bdae0180-bcc8-11ea-9a1d-496fe8b4afb7.png)
![OPL_2](https://user-images.githubusercontent.com/53192718/86412968-c272b580-bcc8-11ea-9463-3cec57d74e8a.png)
![OPD_3](https://user-images.githubusercontent.com/53192718/86412978-c7d00000-bcc8-11ea-8afb-27322c748d18.png)
![OPL_3](https://user-images.githubusercontent.com/53192718/86412989-cf8fa480-bcc8-11ea-9eda-e3cce2a1c918.png)

## 4. Takım Üyeleri
* [İsmail Demircan](https://github.com/ismaildemircann)
* [Muzaffer Arda Uslu](https://github.com/ardasdasdas)
* [Onur Akkepenek](https://github.com/OnurAkkepenekk)
* [Gökhan Samet Albayrak](https://github.com/gokhansamet)
