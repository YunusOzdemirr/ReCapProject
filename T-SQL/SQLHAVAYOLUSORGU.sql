--BETWEEN - AND operatörü 2 değer ile belirtilen aralığı sınar. Bu değerler sayı, metin veya tarih olabilir.
--Söz dizimi:
--SELECT <sütun adı> FROM <tablo adı> WHERE <sütun adı> BETWEEN <DEĞER 1> AND <değer 2>




---0001- Siparişteki uçak sayısı 40 ile 50 arası olanları listeleyiniz.
SELECT * FROM UcakBilgileri WHERE SiparistekiUcakSayisi BETWEEN 40 AND 50 
--0002 Airbus A320 tipi uçaklardan 30-70 arasında aktif kullanımda olan uçağa sahip olan firmaları listeleyiniz.
SELECT UcakTipi FROM UcakBilgileri WHERE KullanimdakiUcakSayisi BETWEEN 30 AND 70 AND UcakTipi='Airbus A320' ORDER BY KullanimdakiUcakSayisi DESC,AnaHavayoluMarkasi

--IN(BİR LİSTEDEKİ ELEMANLARIN ARANMASI)
--IN sözcüğünü bir listedeki elemanlardan herhangi biriyle eşleşen satırları görüntelemek için kullanırız.
--NOT IN arama kriterini ise listede olmayan değerleri aramak için kullanırız.
-- NOT koşul bildirimi diğer arama koşullarına göre biraz daha yavaş çalışır. Performans açısından çok sık kullanımı tavsiye edilmektedir.
-- IN İle elde ettiğimiz sonuçları OR kullanarak ta elde edebiliriz.

--0003 Thomson Airways,Flybe,Iberia,RyanAir Alt havayolu firmalarının aktif olarak kullanıdığı
--BOeing 737 tipi uçakları listeleyiniz.

SELECT AnaHavayoluMarkasi,AltHavayoluMarkasi,UcakTipi,KullanimdakiUcakSayisi
FROM UcakBilgileri
--Where AltHavayoluMarkasi='Thomson Airways' or AltHavayoluMarkasi='Flybee' or AltHavayoluMarkasi='Iberia' or AltHavayoluMarkasi='RyanAir' AND Ucaktipi='Boing 737'
WHERE AltHavayoluMarkasi IN('Thomson Airways','Flybe','Iberia','RyanAir') AND UcakTipi='Boeing 737'

--0004 Airbus A330,Airbus A321,Airbus A320,ATR 42/72,Airbus A319 tipi uçaklardan
--10 ve üzeri uçak kullanan firmaları uçak sayısına göre azalan şekilde görüntüleyiniz.

SELECT AnaHavayoluMarkasi,AltHavayoluMarkasi,UcakTipi,KullanimdakiUcakSayisi
FROM UcakBilgileri
WHERE UcakTipi IN('Airbus A330','Airbus A321','Airbus A320','ATR 42/72','Airbus A319')
ORDER BY AnaHavayoluMarkasi,AltHavayoluMarkasi,KullanimdakiUcakSayisi DESC
--0005 Toplam güncel fiyatı 1000 ila 5000 arasında olan,
--filo yaşı 0.1 ile 1 arasında olan,Turkish Airlines,IAG,Lufthansa,Southwest Airlines,All Nippon Airways gruplarına ait
--Airbus A330 tipi uçakları listeleyiniz.
SELECT *
FROM UcakBilgileri
WHERE (ToplamGuncelFiyat BETWEEN 1000 AND 5000) AND (FiloOrtalamaYasi BETWEEN 0.1 AND 10) AND AnaHavayoluMarkasi IN('Turkish Airlines','Southwest Airlines,','All Nippon Airways','Lufthansa','IAG') AND UcakTipi='Airbus A330'

--0006 Airbus A320 uçağından siparişi olmayan firmaları listeleyiniz.
SELECT AnaHavayoluMarkasi,AltHavayoluMarkasi,UcakTipi,KullanimdakiUcakSayisi,SiparistekiUcakSayisi
FROM UcakBilgileri
WHERE SiparistekiUcakSayisi is NULL AND UcakTipi='Airbus A320'

--0007 Aktif olarak Embraer ERJ-145 ve ATR 42/72 kullanmayan ve aktif uçak sayısı 50 ve altında olan firmaları listeleyiniz.
SELECT AnaHavayoluMarkasi,KullanimdakiUcakSayisi,UcakTipi
FROM UcakBilgileri
WHERE (UcakTipi!='Embraer ERJ-145' AND UcakTipi!='ATR 42/72') AND KullanimdakiUcakSayisi>=50 

--SQL Select Distinct
--DISTINCT kelimesi bir sütundaki benzersiz kayıtları listeler
--Distinct anahtar kelimesi ile her tekrarlanan kelime sadece bir kez listelenir.
--SÖZ Dizimi
--SELECT DISTINCT <sütun adı> FROM <tabloadı> [Where <kosul>]

--0008 Uçak tiplerini görüntüleyiniz.
SELECT DISTINCT UcakTipi
FROM UcakBilgileri
ORDER BY UcakTipi

--0009 Ana Havayollarını ve alt markalarını ve kullandıkları uçakları listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi,AltHavayoluMarkasi
FROM UcakBilgileri
ORDER BY AnaHavayoluMarkasi,AltHavayoluMarkasi

--0010 Boeing 737 kullanan,Ana havayollarını ve alt markaları listeleyiniz
SELECT DISTINCT AnaHavayoluMarkasi,AltHavayoluMarkasi,UcakTipi
FROM UcakBilgileri
WHERE UcakTipi='Boeing 737'
ORDER BY AnaHavayoluMarkasi,AltHavayoluMarkasi

------------------------------------------------------------------------------------------------------------------------
--LIKE ifadesi
--LIKE kelimesi sütundaki değerlerin,joker karakterler kullanılarak oluşturduğumuz
-- bir arama koşulu ile karşılaştırılmasını sağlar.
-- söz dizimi:
-- SELECT <sütun adı> FROM <tablo adı> WHERE <aranacak sütun> LIKE <kriter>
--JOKER KARAKTER ANLAMI
-- % Herhangi uzunlukta karakter
-- _ herhangi tek karakter
-- [] belirtilen aralıkta herhangi bir karakter
--[^] Belirtilen aralıkta olmayan bir karakter

-- Örnek arama koşulları
-- LIKE 'Br%' İlk iki harfi Br olan tüm kayıtlar
-- LIKE '%een' Son üç harfi een olan tüm kayıtlar
-- LIKE '%en%' İçerisinde en ifadesi geçen tüm kayıtlar
-- LIKE '_en' Son iki harfi en olan üç harften oluşan tüm kayıtlar
-- LIKE '[CK]%' C veya X harfleriyle başlayan tüm kayıtlar
-- LIKE '[S-V]_ng ng ile biten ve ilk harfi S ile V harfleri arasında olan dört harfli herhangi kelime
-- LIKE 'M[^c]%' M ile başlayan ikinci harfi c olmayan tüm kayıtlar

--0011 A harfi ile başlayan havayolu gruplarını listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi FROM UcakBilgileri WHERE AnaHavayoluMarkasi LIKE 'A%' ORDER BY AnaHavayoluMarkasi
--0012 Airlines ile biten havayolu gruplarını listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi FROM UcakBilgileri WHERE AnaHavayoluMarkasi LIKE '%Airlines' ORDER BY AnaHavayoluMarkasi
--0013 Uçak tipi Airbus olan uçakları aktif kullanan firmaları listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi FROM UcakBilgileri WHERE UcakTipi LIKE '%airbus%' and KullanimdakiUcakSayisi is not  null
--0014 Havayolu grupları içerisinde K-T arasında isimle başlayan şirketleri listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi FROM UcakBilgileri WHERE AnaHavayoluMarkasi LIKE '[K-T]%' ORDER BY AnaHavayoluMarkasi
--0015 A ile başlamayan airlines  ile biten havayolu gruplarını listeleyiniz.
SELECT DISTINCT AnaHavayoluMarkasi FROM UcakBilgileri WHERE AnaHavayoluMarkasi LIKE '[^a]%airlines' ORDER BY AnaHavayoluMarkasi
