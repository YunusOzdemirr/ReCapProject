CREATE TABLE Musteriler
(
	MusteriID INT IDENTITY PRIMARY KEY NOT NULL,
	Ad NVARCHAR(50) NOT NULL,  
	Soyad NVARCHAR(50) NOT NULL,
	Email NVARCHAR(100),
	Yas INT,
	TelefonNumarasi NVARCHAR(20),
	Cinsiyet NVARCHAR(10),
	UyelikTarihi DATETIME DEFAULT(getdate()),

);
CREATE TABLE Urunler
(
	UrunID INT IDENTITY PRIMARY KEY NOT NULL,
	UrunAdi NVARCHAR(150) NOT NULL,
	UrunStok INT NOT NULL,
	UrunKategori NVARCHAR(100) NOT NULL,
	UrunFiyat DECIMAL(12,2) NOT NULL,
	UrunRenk NVARCHAR(50) 
);
CREATE TABLE Satislar
(
	SatisID INT IDENTITY PRIMARY KEY NOT NULL,
	MID INT ,
	CONSTRAINT fkSatislarMusteriler FOREIGN KEY(MID) REFERENCES Musteriler(MusteriID),
	U_ID INT ,
	CONSTRAINT fkSatislarUrunler FOREIGN KEY(U_ID) REFERENCES Urunler(UrunID),
	SatisAdet INT NOT NULL,
	SatisTarihi DATETIME DEFAULT(getdate())
);

GO

--DROP TABLE Satislar
--DROP TABLE Musteriler
--DROP TABLE Urunler

SELECT * FROM Musteriler

INSERT INTO Musteriler(Ad,Soyad,Email,Yas,TelefonNumarasi,Cinsiyet) VALUES 
('Yunus','Özdemir','yunusozdemir468@gmail.com',18,'05393186864','Erkek')	  ,
('Furkan','Yılmaz','fuykan1041@icloud.com',18,'05112223344','Erkek')		  ,
('Kıvanç','Arda Kurban','Arda.kurban32@hotmail.com',18,'05393186864','Erkek') ,
('Emir','Uyar','Emiruya62r@hotmail.com',18,'05223334455','Erkek')			  ,
('Kenan','Kaya','KenanKaya161@gmail.com',21,'05443334455','Erkek')			  ,
('İlkay','Alacücük','ilkayalacücük178@gmail.com',23,'005887779988','Erkek')	  ,
('Fatih','Atış','Fatihatış967@gmail.com',31,'05227771133','Erkek')			  ,
('Eren','Öz','erenozzz@hotmail.com','18','05554443322','Erkek')				  ,
('Mert','Aslanbaş','MertAslanbas22@gmail.com',17,'05551112233','Erkek')		  ,
('Uğur','Ergin','UğurErgin123@gmail.com',28,'05559998877','Erkek')			  ,
('Yiğit','Bulut','YiğitBulut911@gmail.com',20,'05554445566','Erkek')		  ,
('Deniz','Canver','DenizCanver155@gmail.com',19,'05550003366','Kız')		  ,
('Hacı Sait','Akyol','HacıAkyol237@gmail.com',23,'05552228811','Erkek')		  ,
('Hilal','Acar','HilalAcar621@gmail.com',27,'05551112233','Kız')			  ,
('Muhammet','Gülşa','MuhammetGülşa546@gmail.com',24,'05559991155','Erkek')	  ,
('Nazlı','Kuytu','NazlıKuytu123234@gmail.com',26,'055588877711','Kız')		  ,
('Tugay','Kargı','TugayKargı5677312@gmail.com',18,'05558883366','Erkek')	  ,
('Helin','Duymaz','HelinDuymaz23476@gmail.com',29,'05554442299','Kız')		  ,
('Zeynep','Aydoğan','ZeynepAydoğan633@gmail.com',30,'05558881199','Kız')	  ,
('Mustafa','Akyol','MustafaAkyol4563@gmail.cm',18,'05556668811','Erkek')	  ,
('Sıddık','Durmuş','SıddıkDurmuş8790@gmail.com',17,'05553336677','Erkek')	  ,
('Ayşe','Kırılmaz','AyşeKırılmaz561@gmail.com',18,'','Kız')					  ,
('Tuğrul','Gümüş','TuğrulGümüş4656@gmail.com',17,'','Erkek')				  ,
('Ebubekir Sıddık','Güneş','BekirSıddık949@gmail.com',51,'','Erkek')		  ,
('Salih','Yaz','SalihYaz163@gmail.com',57,'','Erkek')						  ,
('Umutcan','Yurtseven','UmutcanYurtseven562@gmail.com',40,'','Erkek')		  ,
('Emircan','Açıkgöz','EmircanAçıkgöz021@gmail.com',38,'05987412560','Erkek')  ,
('Fatih','Öz','FatihÖz167@gmail.com',46,'','Erkek')							  ,
('Cansu','Demir','CansuDemir583@gmail.com',22,'05324897561','Kız')			  ,
('Banu','Kalas','',18,'05324897561','Kız')			  
INSERT INTO Musteriler VALUES('Yunus','Özdemir','yunusozdemir468@gmail.com',18,'05393186864','Erkek')
SELECT * FROM Urunler
--Urun Adı -- Urun Stok -- Urun Keywords -- Urun Fiyat
--1--
INSERT INTO Urunler(UrunAdi,UrunStok,UrunKategori ,UrunFiyat,UrunRenk) VALUES 
('Samsung LC24RG50FQMXUF 24 144Hz',20,'144hz, 1ms, 24inc, Gamer', '2000.00','Beyaz, Gri') , 
('Lassa 205/55 R16 91H Snoways 4 Oto Kış Lastiği ',100,'Lastik', '384.00','Siyah') , 
('Casper C350',15,'Bilgisayar', '1500.00','Siyah, Beyaz, Gri')	, 
('Petlas 205/55 R16 91H Imperium PT515 Oto Lastik',100,'Lastik', '320.00','Siyah') ,	
('Goodyear 205/55 R16 91V',100,'Lastik', '390.00','Siyah') ,	
('Pilsan Ranger Uzaktan Kumandalı 12V Akülü Araba',100,'Oyuncak', '1500.00' ,'Siyah'),
('Portakallı Meyve Suyu',100,'Meyve, İçecek, Portakal', '4.00','Belirlenmedi'),
('Casper H36 Laptop Klavye',250,'Klavye, Gamer, Bilgisayar','120.00','Siyah'),
('RTX 3080 Ekran Kartı',10,'Bilgisayar, Ekran Kartı, Gamer', '15000.00' ,'Belirlenmedi'),
('Playstation 5',5,'Oyun Konsolu, Gamer, Eğlence','8999.99','Siyah, Beyaz'),
('Mikrofon',250,'Bilgisayar, Ses, Gamer', '100.00','Belirlenmedi'),
('Pilsan Tery Bery Uzaktan Kumandalı 12V Akülü Araba Beyaz',100,'Oyuncak', '1500.00','Siyah, Beyaz, Gri, Sarı'),
('Gskill TridentZ 16GB 2x8',25,'Bilgisayar, RAM, Masaüstü, RGB, Gamer', '700.00','Belirlenmedi'),
('Watch Series 5',50,'iPhone, Saat, Akıllı Saat , Gold', '3000.00','Siyah, Beyaz, Gri, Mavi'),
('AirPods 2',100,'iPhone, Ses, Kulaklık, Gold', '1299.90','Siyah, Beyaz, Gri, Mavi'),
('Sigma Nabız Saati Pc 3.11 Yeşil',100,'Teknoloji, Saat', '1299.90','Siyah, Beyaz, Gri, Mavi, Yeşil'),
('Çikolata',500,'Atıştırmalık', '5.00','Belirlenmedi'),
('Rival 600',50,'Bilgisayar, Mouse, RGB, Gold, Gamer', '600.00','Siyah, Beyaz'),
('Karışık Meyve Suyu',80,'Meyve, İçecek', '5.00','Belirlenmedi'),
('Çikolata',500,'Atıştırmalık', '5.00','Belirlenmedi'),
('iPad PRO',50,'Tablet, Oyun, Eğlence', '5999.00','Siyah, Beyaz'),
('Ütü',100,'Ev Aletleri', '500.00','Siyah, Beyaz'),
('Klima',10,'Yaz, Ev Aletleri', '3000.00','Siyah, Beyaz'),
('Xlc PC-L04 Mandallı Sele Kelepçesi Kırmızı',100,'Spor Aletleri', '44.90','Siyah, Beyaz, Kırmızı'),
('Lixada Bisiklet Kilometre Kilometre Sayacı ',100,'Spor Aletleri', '87.00','Siyah, Beyaz, Kırmızı'),
('Delpino Su ve Rüzgar Geçirmez Softshell Mont ',200,'Spor Ürünleri', '199.00','Siyah, Beyaz, Gri'),
('Unco & Boror Su Geçirmez Softshell Erkek Spor Mont',100,'Spor Ürünleri', '219.00','Siyah, Beyaz, Gri'),
('Corsair 750W PSU',25,'Bilgisayar, PSU, Masaüstü, RGB, Gamer, Gold', '1200.00','Belirlenmedi'),
('Excalibur E24FHD-G 24.5',50,'144hz, 1ms, 24inc, Gamer, Monitör','1999.99','Siyah,Beyaz'),
('Ghassy Co. Tactical Army Erkek Polar Kapşonlu Ceket',100,'Spor Ürünleri', '129.00','Siyah, Beyaz, Gri'),
('Big King Siyah Outdoor Trekking Erkek Bot',100,'Spor Ürünleri', '129.00','Siyah, Beyaz, Gri'),
('Salomon Su Geçirmez Siyah Erkek Bot',200,'Spor Ürünleri', '855.00','Siyah, Beyaz, Gri'),
('Kadın Omuzu Taş Düğmeli Triko Kazak',100,'Kıyafet', '150.00','Siyah, Beyaz, Gri'),
('V Yaka Düğmeli Triko Hırka',250,'Kıyafet', '53.00','Siyah, Beyaz, Gri'),
('Avon Wish Of Love Edt 50 Ml Kadın Parfüm',250,'Parfüm, Kişisel', '30.00','Siyah, Pembe'),
('Chopard Wish Edp 75 Ml Kadın Parfüm',250,'Kişisel', '129.00','Siyah, Pembe, Yeşil'),
('Maybelline New York Super Stay ',200,'Kişisel', '41.00','Siyah, Pembe'),
('Maybelline Makyaj Seti',200,'Kişisel', '149.00','Siyah, Pembe'),
('Gliss Intense Theraphy Şampuan',100,'Kişisel', '19.00','Siyah, Pembe'),
('Schwarzkopf Gliss Serum Deep Repaır Şampuan',100,'Kişisel', '20.99','Siyah, Pembe'),
('Gliss Sun Protect Şampuan',100,'Kişisel', '17.99','Siyah, Pembe'),
('Samsung Galaxy S21 5G 128 GB',100,'Telefon, Samsung', '9999.99','Siyah, Pembe, Mavi, Beyaz'),
('iPhone 11 128 GB',100,'Telefon, İphone', '8099.99','Siyah, Pembe, Mavi, Beyaz'),
('iPhone 12 64 GB',100,'Telefon, İphone', '10999.99','Siyah, Pembe, Mavi, Beyaz'),
('Samsung Galaxy S20 FE 256 GB',100,'Telefon, Samsung', '6299.99','Siyah, Pembe, Mavi, Beyaz'),
('Xiaomi Mi 10T 128 GB 8 GB RAM',100,'Telefon, Xiaomi', '5399.99','Siyah, Pembe, Mavi, Beyaz'),
('Xiaomi Redmi Note 9 Pro 128 GB',100,'Telefon, Xiaomi', '3149.99','Siyah, Pembe, Mavi, Beyaz')

SELECT * FROM Satislar
--Satis Ekleme--
INSERT INTO Satislar(MID,U_ID,SatisAdet) VALUES 
('1','1',1),
('3','6',2)			 ,
('4','12',3)		 ,
('2','2',2)			 ,
('8','16',5)		 ,
('9','15',5)		 ,
('10','19',10)		 ,
('23','20',5)		 ,
('11','16',5)		 ,
('16','6',2)		 ,
('9','18',25)		 ,
('17','1',50)		 ,
('13','2',1)		 ,
('19','5',1)		 ,
('21','16',1)		 ,
('5','15',1)		 ,
('15','19',3)		 ,
('7','7',2)			 ,
('19','8',20)		 ,
('13','3',1)		 ,
('14','1',4)		 ,
('18','23',1)		 ,
('8','13',1)		 ,
('3','9',1)			 ,
('7','10',1)		 ,
('23','28',1)		 ,
('10','4',1)		 ,
('4','13',1)		 ,
('6','11',5)		 ,
('16','16',1)		 ,
('20','12',1)		 ,
('19','17',20)		 ,
('15','22',1)		 ,
('4','1',10)		 ,
('2','23',7)		 ,
('12','14',1)		 ,
('13','36',1)		 ,
('6','37',1)		 ,
('8','31',3)		 ,
('19','39',2)		 ,
('22','40',5)		 ,
('20','47',1)		 ,
('11','42',1)		 ,
('18','45',1)		 ,
('9','47',1)		 ,
('3','39',3)		 ,
('1','41',3)		 ,
('17','38',1)		 ,
('2','7',100)		

--Sorgu--

--1 Stok sayısı 200ün altında olanlar--
SELECT * FROM Urunler WHERE UrunStok<200
--2 Renkler arasında Mavi olan ürünler
SELECT * FROM Urunler WHERE UrunRenk LIKE '%Mavi%'
--3 Renkleri olmayan ürünler
SELECT * FROM Urunler WHERE UrunRenk='Belirlenmedi'
--4 Fiyatı 100 altında olan ürünler
SELECT * FROM Urunler WHERE UrunFiyat<100
--5 Ürün Kategorisi Kişisel olan ürünler
SELECT * FROM Urunler WHERE UrunKategori LIKE '%Kişisel%'
--6 Ürün Kategorisi Spor olan ürünler ve fiyatları azalan şekilde 
SELECT * FROM Urunler WHERE UrunKategori LIKE '%Spor%' ORDER BY UrunFiyat DESC
--7 Ürun Kategorisi Kıyafet olan ürünler arasında en çok satan ürün
SELECT TOP 1 UrunAdi,SatisAdet FROM Urunler, Satislar WHERE UrunKategori LIKE '%Kıyafet%' ORDER BY SatisAdet
--8 En az stokta olan ürün
SELECT TOP 1 * FROM Urunler ORDER BY UrunStok
--9 Furkan Yılmaz'ın aldığı ürünler
SELECT * FROM Musteriler, Satislar, Urunler WHERE MID = MusteriID AND U_ID = UrunID AND Ad='Furkan' AND Soyad='Yılmaz'
--10 Ses kategorisinden ürün alan müşteriler
SELECT * FROM Musteriler, Urunler, Satislar WHERE UrunKategori LIKE '%Ses%' AND U_ID = UrunID AND MID = MusteriID
--11 Spor kategorisinden en çok satan ürün
SELECT TOP 1 * FROM Urunler, Satislar WHERE U_ID = UrunID AND UrunKategori LIKE '%Spor%'
--12 Oyuncak kategorisinden satılan en pahalı oyuncak
SELECT TOP 1 * FROM Urunler, Satislar WHERE U_ID = UrunID AND UrunKategori LIKE '%Oyuncak%' ORDER BY UrunFiyat
--13 Müşterilerin yaşını küçükten büyüğe sıralama
SELECT * FROM Musteriler ORDER BY Yas 
--14 Müşterilerin yaşını büyükten küçüğe sıralama
SELECT * FROM Musteriler ORDER BY Yas DESC
--15 Telefon Numarası Olmayan Müşteriler
SELECT * FROM Musteriler WHERE TelefonNumarasi=''
--16 En çok satan ürün
SELECT TOP 1 * FROM Satislar, Urunler, Musteriler WHERE MusteriID = MID AND UrunID = U_ID ORDER BY SatisAdet DESC
--17 Stok Sayısı 100 ila 200 olan ürünler ve Spor kategorisinden olan ürünler
SELECT * FROM Urunler WHERE UrunStok BETWEEN 100 AND 200 AND UrunKategori LIKE '%Spor%'
--18 Yunus Özdemirin Gamer kategorisinden aldığı ürünler
SELECT * FROM Musteriler, Satislar, Urunler WHERE MID = MusteriID AND U_ID = UrunID AND Ad='Yunus' AND Soyad='Özdemir' AND UrunKategori LIKE '%Gamer%'
--19 En fazla stokta olan ürün
SELECT TOP 1 * FROM Urunler ORDER BY UrunStok DESC
--20 Ortalama Stok Sayisi
SELECT AVG(UrunStok) FROM Urunler
--21 ilk kayıt olan kullanıcı ve aldığı ürün
SELECT TOP 1  * FROM Musteriler, Urunler ORDER BY UyelikTarihi DESC 
--22 adının ilk harfi Y olan ve Bilgisayar alan kullanıcılar
SELECT * FROM Musteriler, Urunler WHERE Ad LIKE 'Y%' AND UrunKategori LIKE 'Bilgisayar'
--23 Maili olmayan kullanıcılar 
SELECT * FROM Musteriler WHERE Email='' 
--24 En çok çikolata alan kişi
SELECT TOP 1 * FROM Musteriler,Urunler, Satislar WHERE UrunAdi='Çikolata' AND UrunID=U_ID AND MusteriID=MID ORDER BY SatisAdet
--25 Bilgisayar parçalarının ortalama fiyatı
SELECT AVG(UrunFiyat) FROM Urunler WHERE UrunKategori LIKE '%Bilgisayar%' 
--26 Bilgisayar parçası haricindeki ürünlerin fiyatları azalan şekilde
SELECT * FROM Urunler WHERE UrunKategori NOT LIKE '%Bilgisayar%' ORDER BY UrunFiyat DESC
--27 Bilgisayar parçası ürünlerinin fiyatları azalan şekilde
SELECT * FROM Urunler WHERE UrunKategori LIKE '%Bilgisayar%' ORDER BY UrunFiyat DESC
--28 Markası samsung olan telefon modelleri
SELECT * FROM Urunler WHERE UrunKategori LIKE '%Samsung%' 
--29 yaşı 30 altında olan müşteriler
SELECT * FROM Musteriler WHERE YAS < 30
--30 müşteriler arasındaki ortalama yaş
SELECT AVG(Yas) FROM Musteriler
--31 cinsiyeti kız olan müşteriler
SELECT * FROM Musteriler WHERE Cinsiyet = 'Kız'
--32  Mailinin içinde 1 sayısını bulunduran müşteriler
SELECT * FROM Musteriler WHERE Email LIKE '%1%'
--33 Mağazadan en çok eşya alan müşteri ve o ürün
SELECT TOP 1 * FROM Musteriler,Urunler,Satislar WHERE MusteriID=MID AND UrunID=U_ID ORDER BY SatisAdet DESC
--34 Mağazadaki ürünlerin ortalama fiyatı
SELECT AVG(UrunFiyat) FROM Urunler
--35 Hiç satamayan ürün 
SELECT TOP 1 * FROM Urunler, Satislar WHERE U_ID != UrunID	
