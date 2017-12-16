CREATE DATABASE QUANLIDKDAOTAO;

USE QUANLIDKDAOTAO;

select * from ACCOUNT where USERNAME='admin' and PASSWD='admin';

CREATE TABLE ACCOUNT(
ID_ACCOUNT INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
USERNAME VARCHAR(20) NOT NULL,
PASSWD VARCHAR(30) NOT NULL,
GRANTUSER INT NOT NULL,
NOTE NVARCHAR(40)
)

CREATE TABLE KHOA(
MaKhoa VARCHAR(10) NOT NULL PRIMARY KEY,
TenKhoa NVARCHAR(30) NOT NULL);

CREATE TABLE NGANH_DAOTAO(
MaNganhDT VARCHAR(10) NOT NULL PRIMARY KEY,
TenNganhDT NVARCHAR(30) NOT NULL);

CREATE TABLE HINHTHUC_DAOTAO(
MaHTDT VARCHAR(10) NOT NULL PRIMARY KEY,
TenHTDT NVARCHAR(30) NOT NULL);

CREATE TABLE DANTOC(
MaDanToc VARCHAR(10) NOT NULL PRIMARY KEY,
TenDanToc NVARCHAR(30) NOT NULL);

CREATE TABLE BOMON(
MaBM VARCHAR(10) NOT NULL PRIMARY KEY,
TenBM NVARCHAR(30) NOT NULL,
MaKhoa VARCHAR(10) FOREIGN KEY REFERENCES KHOA(MaKhoa) NOT NULL);

CREATE TABLE CHITIET_HTDT(
SttHTDT INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MaNganhDT VARCHAR(10) FOREIGN KEY REFERENCES NGANH_DAOTAO(MaNganhDT) NOT NULL,
MaHTDT VARCHAR(10) FOREIGN KEY REFERENCES HINHTHUC_DAOTAO(MaHTDT) NOT NULL,
Chitiet NVARCHAR(100) NOT NULL);

CREATE TABLE NOIDAOTAO(
MaNoiDT VARCHAR(10) NOT NULL PRIMARY KEY,
TenNoiDT NVARCHAR(30) NOT NULL);

CREATE TABLE BACDAOTAO(
MaBacDT VARCHAR(10) NOT NULL PRIMARY KEY,
TenBacDT NVARCHAR(30) NOT NULL);


CREATE TABLE GIANGVIEN(
MaGV VARCHAR(10) NOT NULL PRIMARY KEY,
Ho NVARCHAR(20) NOT NULL,
TenLot NVARCHAR(20) NOT NULL,
Ten NVARCHAR(20) NOT NULL,
GioiTinh NVARCHAR(3) NOT NULL,
NgaySinh DATE NOT NULL,
KinhPhi FLOAT NOT NULL,
TG_BatDau DATE NOT NULL,
TG_KetThuc DATE NOT NULL,
HuongBoTri NVARCHAR(30) NOT NULL,
MaBM VARCHAR(10) FOREIGN KEY REFERENCES BOMON(MaBM) NOT NULL,
MaDanToc VARCHAR(10) FOREIGN KEY REFERENCES DANTOC(MaDanToc) NOT NULL,
STTHTDT INT FOREIGN KEY REFERENCES CHITIET_HTDT(STTHTDT) NOT NULL,
MaNoiDT VARCHAR(10) FOREIGN KEY REFERENCES NOIDAOTAO(MaNoiDT) NOT NULL,
MaBacDT VARCHAR(10) FOREIGN KEY REFERENCES BACDAOTAO(MaBacDT) NOT NULL);

