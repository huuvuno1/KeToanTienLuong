-- ketoantienluong.dbo.dmbp definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.dmbp;

CREATE TABLE dmbp (
	Mabp nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Tenbp nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sdt nvarchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	diachi nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	trangthai int NULL,
	CONSTRAINT PK__dmbp__27236993F72F500B PRIMARY KEY (Mabp)
);


-- ketoantienluong.dbo.dmcv definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.dmcv;

CREATE TABLE dmcv (
	macv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tencv nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	mota nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	trangthai int NULL,
	CONSTRAINT PK__dmcv__7A21F84882D21C20 PRIMARY KEY (macv)
);


-- ketoantienluong.dbo.dmnh definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.dmnh;

CREATE TABLE dmnh (
	so nchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	stk nchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tennh nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	chinhanh nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	trangthai int NULL,
	CONSTRAINT PK__dmnh__3214186DA518E567 PRIMARY KEY (so)
);


-- ketoantienluong.dbo.dmtk definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.dmtk;

CREATE TABLE dmtk (
	matk nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tentk nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkme nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	captk int NULL,
	trangthai int NULL,
	CONSTRAINT PK__dmtk__7A217E16FDED4E98 PRIMARY KEY (matk)
);


-- ketoantienluong.dbo.nguoidung definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.nguoidung;

CREATE TABLE nguoidung (
	id int IDENTITY(1,1) NOT NULL,
	tendangnhap varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tennguoidung nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	matkhau varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	quyen nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__nguoidun__3213E83FF3585DC1 PRIMARY KEY (id)
);


-- ketoantienluong.dbo.thamsoluong definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.thamsoluong;

CREATE TABLE thamsoluong (
	mats nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tents nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tyle float NULL,
	CONSTRAINT PK__thamsolu__7A217E1ED8D3F30D PRIMARY KEY (mats)
);


-- ketoantienluong.dbo.thamsothuetncn definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.thamsothuetncn;

CREATE TABLE thamsothuetncn (
	mucthue nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tientu float NULL,
	tienden float NULL,
	tyle float NULL,
	muc int NULL,
	CONSTRAINT PK__thamsoth__B272BB1D993A7FB5 PRIMARY KEY (mucthue)
);


-- ketoantienluong.dbo.vsocai definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.vsocai;

CREATE TABLE vsocai (
	ngaybatdau smalldatetime NULL,
	ngayketthuc smalldatetime NULL,
	matk nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	thoigian smalldatetime NULL,
	tentk nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkno nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__vsocai__7A217E16D3DBB035 PRIMARY KEY (matk)
);


-- ketoantienluong.dbo.bangcc definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.bangcc;

CREATE TABLE bangcc (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	thang int NULL,
	nam int NULL,
	ngaycong int NULL,
	mabp nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__bangcc__3214186DFB9114CB PRIMARY KEY (so),
	CONSTRAINT FK__bangcc__mabp__3D5E1FD2 FOREIGN KEY (mabp) REFERENCES dmbp(Mabp)
);


-- ketoantienluong.dbo.bangluongnhanvien definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.bangluongnhanvien;

CREATE TABLE bangluongnhanvien (
	thang int NULL,
	nam int NULL,
	Ngaycong int NULL,
	noidung nchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tienphucap numeric(18,0) NULL,
	tienthuong numeric(18,0) NULL,
	tienluongcoban numeric(18,0) NULL,
	bhxh numeric(18,0) NULL,
	bhyt numeric(18,0) NULL,
	bhtn numeric(18,0) NULL,
	tientamung numeric(18,0) NULL,
	tienluong numeric(18,0) NULL,
	tienbhxh numeric(18,0) NULL,
	tientruocthue numeric(18,0) NULL,
	tienthue numeric(18,0) NULL,
	tongbaohiem numeric(18,0) NULL,
	tienthuclinh numeric(18,0) NULL,
	giamtruphuthuoc numeric(18,0) NULL,
	giamtrucanhan numeric(18,0) NULL,
	tonggiamtru numeric(18,0) NULL,
	tienbhyt numeric(38,0) NULL,
	tienbhtn numeric(38,0) NULL,
	id int IDENTITY(0,1) NOT NULL,
	machitietbcc int NOT NULL,
	mabcc nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	congdoan numeric(38,0) NULL,
	tiencongdoan numeric(38,0) NULL,
	tienbhxhctytra numeric(38,0) NULL,
	tienbhytctytra numeric(38,0) NULL,
	tienbtntnctytra numeric(38,0) NULL,
	tiencongdoanctytra numeric(38,0) NULL,
	luongngoaigio numeric(38,0) NULL,
	phucapantrue numeric(38,0) NULL,
	phucapkhac numeric(38,0) NULL,
	CONSTRAINT PK__bangluon__3213E83FDEDCFC26 PRIMARY KEY (id),
	CONSTRAINT bangluongnhanvien_FK FOREIGN KEY (mabcc) REFERENCES bangcc(so) ON DELETE CASCADE ON UPDATE CASCADE
);


-- ketoantienluong.dbo.chitietsocai definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.chitietsocai;

CREATE TABLE chitietsocai (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ngay smalldatetime NULL,
	lydo nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkdu nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tienno float NULL,
	tienco float NULL,
	CONSTRAINT PK__chitiets__3214186DA933BC5F PRIMARY KEY (so),
	CONSTRAINT chitietsocai_FK FOREIGN KEY (so) REFERENCES vsocai(matk)
);


-- ketoantienluong.dbo.dmnv definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.dmnv;

CREATE TABLE dmnv (
	manv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tenv nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ngaysinh smalldatetime NULL,
	diachi nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	masothue nvarchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	gioitinh nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	macv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	mabp nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	bangcap nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	trinhdo nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	songuoiphuthuoc int NULL,
	trangthai int NULL,
	luongcoban numeric(38,0) NULL,
	CONSTRAINT PK__dmnv__7A21B37D99948285 PRIMARY KEY (manv),
	CONSTRAINT FK__dmnv__mabp__48CFD27E FOREIGN KEY (mabp) REFERENCES dmbp(Mabp),
	CONSTRAINT FK__dmnv__macv__47DBAE45 FOREIGN KEY (macv) REFERENCES dmcv(macv)
);


-- ketoantienluong.dbo.giaybaono definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.giaybaono;

CREATE TABLE giaybaono (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ngay smalldatetime NULL,
	manv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ctlq nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	manh nchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tien numeric(38,0) NULL,
	tkco nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkno nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__giaybaon__3214186D5F3EF4B2 PRIMARY KEY (so),
	CONSTRAINT FK__giaybaono__manh__06CD04F7 FOREIGN KEY (manh) REFERENCES dmnh(so),
	CONSTRAINT FK__giaybaono__manv__05D8E0BE FOREIGN KEY (manv) REFERENCES dmnv(manv),
	CONSTRAINT giaybaono_FK FOREIGN KEY (tkco) REFERENCES dmtk(matk),
	CONSTRAINT giaybaono_FK_1 FOREIGN KEY (tkno) REFERENCES dmtk(matk)
);


-- ketoantienluong.dbo.phieuchi definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.phieuchi;

CREATE TABLE phieuchi (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ngay smalldatetime NULL,
	manv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ctlq nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkno nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkco nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tien numeric(38,0) NULL,
	CONSTRAINT PK__phieuchi__3214186DF5CF3AAC PRIMARY KEY (so),
	CONSTRAINT FK__phieuchi__manv__66603565 FOREIGN KEY (manv) REFERENCES dmnv(manv),
	CONSTRAINT phieuchi_FK FOREIGN KEY (tkco) REFERENCES dmtk(matk),
	CONSTRAINT phieuchi_FK_1 FOREIGN KEY (tkno) REFERENCES dmtk(matk)
);


-- ketoantienluong.dbo.phieuketoan definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.phieuketoan;

CREATE TABLE phieuketoan (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ngay smalldatetime NULL,
	manv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ctlq nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__phieuket__3214186DA0F5430F PRIMARY KEY (so),
	CONSTRAINT FK__phieuketoa__manv__0C85DE4D FOREIGN KEY (manv) REFERENCES dmnv(manv)
);


-- ketoantienluong.dbo.chitietbangcc definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.chitietbangcc;

CREATE TABLE chitietbangcc (
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	manv nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ngaycong float NULL,
	ngayphep float NULL,
	ngaykhongphep float NULL,
	tienphucap float NULL,
	tienthuong float NULL,
	id int IDENTITY(0,1) NOT NULL,
	CONSTRAINT chitietbangcc_PK PRIMARY KEY (id),
	CONSTRAINT FK__chitietban__manv__6D0D32F4 FOREIGN KEY (manv) REFERENCES dmnv(manv),
	CONSTRAINT chitietbangcc_FK FOREIGN KEY (so) REFERENCES bangcc(so) ON DELETE CASCADE ON UPDATE CASCADE
);


-- ketoantienluong.dbo.chitietphieuketoan definition

-- Drop table

-- DROP TABLE ketoantienluong.dbo.chitietphieuketoan;

CREATE TABLE chitietphieuketoan (
	id int IDENTITY(1,1) NOT NULL,
	so nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	tkno nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tkco nchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	noidung nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	tien float NULL,
	CONSTRAINT PK__chitietp__3213E83FEBEAA2D9 PRIMARY KEY (id),
	CONSTRAINT FK__chitietphieu__so__0F624AF8 FOREIGN KEY (so) REFERENCES phieuketoan(so)
);