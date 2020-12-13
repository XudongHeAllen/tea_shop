create database tea_store
use tea_store

create table tbl_sale(
	sale_id INT PRIMARY KEY IDENTITY(1,1),
	name	VARCHAR(50)		      NOT NULL,
	price	FLOAT			      NOT NULL
);

create table tbl_product(
	product_id  INT PRIMARY KEY IDENTITY(1,1),
	type	    VARCHAR(50)       NOT NULL,
	description NVARCHAR(500),
	price		FLOAT		      NOT NULL,
	inventory	INT			      NOT NULL
);

create table tbl_emp(
	emp_id			 INT		  NOT NULL PRIMARY KEY IDENTITY(1,1),
	first_name		 NVARCHAR(10) NOT NULL,
	last_name		 NVARCHAR(10) NOT NULL,
	gender			 VARCHAR(6)   NOT NULL, -- Male, Female, Others.
	email			 VARCHAR(100) NOT NULL,
	address			 NVARCHAR(50) NOT NULL,
	country			 NVARCHAR(15) NOT NULL,
	state			 NVARCHAR(20) NOT NULL, -- State/Province.
	city			 NVARCHAR(20) NOT NULL,
	postal_code		 VARCHAR(10)  NOT NULL,
	phone			 VARCHAR(15)  NOT NULL,
	birth			 DATE		  NOT NULL
);

-- INSERT STATEMENT

-- tbl_sale
INSERT INTO tbl_sale (name, price) VALUES('Black Tea', 3);
INSERT INTO tbl_sale (name, price) VALUES('Green Tea', 4);
INSERT INTO tbl_sale (name, price) VALUES('Herbal Tea', 3);
INSERT INTO tbl_sale (name, price) VALUES('White Tea', 2.5);
INSERT INTO tbl_sale (name, price) VALUES('Oolong Tea', 4);
INSERT INTO tbl_sale (name, price) VALUES('Rooibos Tea', 3.5);

-- tbl_product
INSERT INTO tbl_product (type, description, price, inventory) VALUES('Black Tea', 'Delicious', 3, 20);
INSERT INTO tbl_product (type, description, price, inventory) VALUES('Green Tea', 'Good', 4, 7);
INSERT INTO tbl_product (type, description, price, inventory) VALUES('Herbal Tea', 'Good', 3, 3);
INSERT INTO tbl_product (type, description, price, inventory) VALUES('White Tea', 'Delicious', 2.5, 13);
INSERT INTO tbl_product (type, description, price, inventory) VALUES('Oolong Tea', 'Good', 4, 9);
INSERT INTO tbl_product (type, description, price, inventory) VALUES('Rooibos Tea', 'Delicious', 3.5, 11);

--tbl _emp
INSERT INTO tbl_emp (first_name, last_name, gender, email, address, country, state, city, postal_code, phone, birth)
       VALUES ('Hung', 'Phung', 'Male', '200452314@student.georgianc.on.ca', '123 Eglinton St', 'Vietnam', 'SouthSide', 'SaiGon', '100000', '1234567890','2000-01-01'),
			  ('XuDong', 'He', 'Male', '111111111@student.georgianc.on.ca', '444 Bloor St', 'Taiwan', 'Aaa', 'Aaa', '200000', '2345678900','2000-01-02');

