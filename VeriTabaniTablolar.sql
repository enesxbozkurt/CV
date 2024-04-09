CREATE DATABASE db_cv

USE db_cv

CREATE TABLE tbl_deneyim(
deneyim_id_PK int primary key identity(1,1),
baslik varchar(100),
alt_baslik varchar(100),
aciklama varchar(max),
tarih varchar(100)
)

CREATE TABLE tbl_egitim(
egitim_id_PK int primary key identity(1,1),
baslik varchar(100),
alt_baslik varchar(100),
alt_baslik_2 varchar(100),
gnortalama varchar(100),
tarih varchar(100)
)

CREATE TABLE tbl_giris(
giris_id_PK int primary key identity(1,1),
kullanici_adi varchar(20),
sifre varchar(20)
)

CREATE TABLE tbl_hakkimda(
hakkimda_id_PK int primary key identity(1,1),
isim varchar(40),
soyisim varchar(40),
adres varchar(90),
telefon varchar(40),
mail varchar(40),
aciklama varchar(max),
resim varchar(150)
)

CREATE TABLE tbl_hobi(
hobi_id_PK int primary key identity(1,1),
aciklama_1 varchar(500),
aciklama_2 varchar(400)
)

CREATE TABLE tbl_iletisim(
iletisim_id_PK int primary key identity(1,1),
ad_soyad varchar(100),
mail varchar(50),
konu varchar(100),
mesaj varchar(1000),
tarih date
)

CREATE TABLE tbl_sertifika(
sertifika_id_PK int primary key identity(1,1),
aciklama varchar(250)
)

CREATE TABLE tbl_yetenek(
yetenek_id_PK int primary key identity(1,1),
yetenek_adi varchar(100)
)

INSERT INTO tbl_deneyim(baslik,alt_baslik,aciklama,tarih) VALUES('�st','�st','�st','�st')
INSERT INTO tbl_egitim(baslik,alt_baslik,alt_baslik_2,gnortalama,tarih) VALUES('ist','ist','ist','ist','ist')
INSERT INTO tbl_giris(kullanici_adi,sifre) VALUES('ist','ist')
INSERT INTO tbl_hakkimda(isim,soyisim,adres,telefon,mail,aciklama,resim) VALUES('ist','ist','ist','ist','ist','ist','ist')
INSERT INTO tbl_hobi(aciklama_1,aciklama_2) VALUES('ist','ist')
INSERT INTO tbl_iletisim(ad_soyad,mail,konu,mesaj,tarih) VALUES('ist','ist','ist','ist',getdate())
INSERT INTO tbl_sertifika(aciklama) VALUES('ist')
INSERT INTO tbl_yetenek(yetenek_adi) VALUES('ist')



SELECT * FROM tbl_hakkimda

DELETE FROM tbl_iletisim

DROP TABLE tbl_iletisim

SET IDENTITY_INSERT tbl_deneyim ON;


INSERT INTO tbl_deneyim(deneyim_id_PK, baslik, alt_baslik, aciklama, tarih)
VALUES (2, 'G�r�nt� Teknisyeni', 'Sunu Proje - Visio Vox', 'Projeksiyon cihazlar� ile belirli mekanlara istenilen g�r�nt�y� uzakl�k ve lens mesafelerini hesaplayarak yans�tt�m. Fiber optik kablolar ile g�r�nt�y� uzaktan ta��d�m. Cat kablolar� ile fiber extenderlar kullanarak g�r�nt�n�n sa�l�kl� bi�imde ula�mas�n� sa�lad�m. Resolume ve Watchout gibi programlardan g�r�nt�n�n geli� a��s�na g�re gerekli ayarlamalar� yapt�m.','A�ustos 2023 - Devam Etmekteyim ');

SET IDENTITY_INSERT tbl_deneyim OFF;

CREATE TABLE tbl_sosyal_medya(
sosyal_medya_id_PK int primary key identity(1,1),
ad varchar(30),
link varchar(50)
)