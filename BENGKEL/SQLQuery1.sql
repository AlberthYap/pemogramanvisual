SELECT * from barang


INSERT INTO barang VALUES ('B0001','Ban Federal Supra X', '115000' , '135000', NULL)

CREATE TABLE barang
(
id_barang varchar(5) PRIMARY KEY,
nama_barang varchar(255) NOT NULL,
harga_jual decimal,
stock int
)

SELECT MAX(id_barang) AS MAXIMUM, COUNT(id_barang) AS JUMLAH FROM barang
 

create table pembelian2
(
beli_kd varchar(5) foreign key references pembelian1(kd_beli), 
barang_id varchar(5) foreign key references barang(id_barang),
harga_beli decimal,
qty_beli int
)
drop table pembelian1

create table pembelian1
(
kd_beli varchar(5) PRIMARY KEY,
waktu_beli datetime,
total_harga decimal,
)


create table jasa
(
id_jasa varchar (5) PRIMARY KEY,
nama_jasa varchar(128),
harga_jasa decimal,
)

INSERT INTO pembelian1 VALUES ('A0001', '05-25-2021' , 500000)

UPDATE barang set stock = stock + 4 where id_barang='B0002'

SELECT * FROM BARANG

CREATE TABLE mekanik
(
id_mekanik int IDENTITY(1,1) PRIMARY KEY,
nama_barang varchar(255) NOT NULL,
harga_jual decimal,
stock int
)

CREATE TABLE pengunjung
(
id_pengunjung varchar(6) PRIMARY KEY,
nama_pengunjung varchar(255),
alamat text,
nohp varchar(255),
nomor_kendaraan varchar(255),
tipe_motor varchar(255),
point decimal
)

drop table pengunjung

select * from pengunjung

delete pengunjung where id_pengunjung = 'P00001'

CREATE TABLE PENJUALAN1
(
kd_jual varchar (12) PRIMARY KEY,
waktu_jual datetime,
total_harga decimal, 
bayar decimal,
kembali decimal,
diskon decimal,
pengunjung_id varchar(6) foreign key references pengunjung(id_pengunjung),
)

CREATE TABLE PENJUALAN2
(
kd_jual varchar (12) foreign key references penjualan1(kd_jual),
id_item varchar (5),
harga_jual decimal,
qty int,
sub_total decimal
)

drop table PENJUALAN1


select * from barang
select * from jasa

insert into pengunjung values ('P00001', ' - ', ' - ', ' - ', ' - ', ' - ', null)

select * from pengunjung

SELECT MAX(kd_jual) AS MAXIMUM, COUNT(kd_jual) AS JUMLAH FROM penjualan1 WHERE kd_jual like '28052021%'

insert into PENJUALAN1 values ('280520210001', '05-28-2021', 20000, 20000, 100, 100, 'P00001')
insert into PENJUALAN1 values ('280520210002', '05-28-2021', 20000, 20000, 100, 100)
insert into PENJUALAN1 values ('280520210243', '05-28-2021', 20000, 20000, 100, 100)


delete PENJUALAN1 where kd_jual = '290520210004'
delete PENJUALAN1 where kd_jual = '290520210003'
delete PENJUALAN1 where kd_jual = '290520210002'
delete PENJUALAN1 where kd_jual = '300520210001'


INSERT INTO penjualan1 VALUES('290520210001','05-29-2021 11:49:43',135000,200000,65000, 0 , 'P00001')

SELECT MAX(kd_jual) AS MAXIMUM, COUNT(kd_jual) AS JUMLAH FROM penjualan1 WHERE kd_jual like '28052021%'

select * from PEnjualan2
select * from penjualan1
select * from barang

SELECT * from penjualan2 where kd_jual = '202105300001' and id_item = 'B0003' and id_item like 'B%'

select * from pengunjung

update pengunjung set point = '0' where id_pengunjung = 'p00001'

update penjualan1 set diskon = 375000 where kd_jual = '202105300001'
update penjualan1 set diskon = 14500 where kd_jual = '202105300003'


SELECT * FROM pengunjung WHERE id_pengunjung = 'P00002'

ALTER TABLE penjualan1
ADD total_akhir decimal;

SELECT * FROM pengunjung WHERE id_pengunjung = 'P00002'