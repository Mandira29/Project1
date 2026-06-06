create table users
(
id int primary key identity(1, 1),
username varchar(max)  null,
password varchar(max)  null,
status varchar(max) null,
date_created date null
);

select * from users;

insert into users (username, password, status, date_created) values ('admin', 'admin123', 'Admin', '2025-01-24');

create table categories
(
id int primary key identity(1, 1),
category varchar(max) null,
status varchar(max) null,
date_created date null
)

select * from categories


create table products
(
id int primary key identity(1, 1),
product_id varchar(max) null,
product_name varchar(max) null,
category_id varchar(max) null,
stock int null,
price float,
status varchar(max) null,
image varchar(max) null,
date_created date null,
date_updated date null

)

select * from products

create table orders
(
id int primary key identity(1, 1),
CustomerId varchar(max) null,
product_ids varchar(max) null,
quantities varchar(max) null,
prices varchar(max) null,
total varchar(max) null,
date_order date null,
)

drop table orders

select * from orders

