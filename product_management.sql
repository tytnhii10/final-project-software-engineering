CREATE DATABASE mg_product
USE mg_product

CREATE TABLE [product](
	[idProduct]		varchar(10)		NOT NULL,
	[nameProduct]	varchar(50)		NULL,
	PRIMARY KEY (idProduct)
)

CREATE TABLE [agents](
	[idAgents]		varchar(10)		NOT NULL,
	[nameAgents]	varchar(50)		NULL,
	[address]		varchar(50)		NULL,
	[phone]			int			NULL,
	PRIMARY KEY (idAgents)
)

CREATE TABLE [staffs] (
	[idStaffs]		varchar(10)		NOT NULL,
	[nameStaffs]	varchar(50)		NULL,
	PRIMARY KEY (idStaffs)
)


CREATE TABLE [export](
	[idExport]	varchar(10)		NOT NULL,
	[dateExport]	datetime		NULL,
	[idStaffs]		varchar(10)		NOT NULL,
	[idAgents]		varchar(10)		NOT NULL,
	PRIMARY KEY (idExport),
	FOREIGN KEY (idAgents) REFERENCES agents(idAgents),
	FOREIGN KEY (idStaffs) REFERENCES staffs(idStaffs)
)

CREATE TABLE [detailexport](
	[idDetailexport]	varchar(10)		NOT NULL,
	[idExport]			varchar(10)		NOT NULL,
	[idProduct]			varchar(10)		NOT NULL,
	[numberofExport]	float(50)		NULL,
	[price]				float(50)		NULL,
	PRIMARY KEY (idDetailexport),
	FOREIGN KEY (idExport) REFERENCES export(idExport),
	FOREIGN KEY (idProduct) REFERENCES product(idProduct)
)

CREATE TABLE [import](
	[idImport]		varchar(10)		NOT NULL,
	[idStaffs]		varchar(10)		NOT NULL,
	[dateImport]	datetime			NULL,
	PRIMARY KEY (idImport),
	FOREIGN KEY (idStaffs) REFERENCES staffs(idStaffs)
)

CREATE TABLE [detailimport](
	[iddetailimport]	varchar(10)		NOT NULL,
	[idImport]			varchar(10)		NOT NULL,
	[idProduct]			varchar(10)		NOT NULL,
	[number]			float(50)		NULL,
	[price]				float(50)		NULL,
	PRIMARY KEY (iddetailimport),
	FOREIGN KEY (idImport) REFERENCES import(idImport),
	FOREIGN KEY (idProduct) REFERENCES product(idProduct)
)
