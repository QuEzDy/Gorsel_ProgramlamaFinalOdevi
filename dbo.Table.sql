-- create database car_db
create database car_db;
use car_db;

-- create table car
create table car(
    id int not null auto_increment primary key,
    marka varchar(255) not null,
    model int not null,
    fiyat int not null,
    yil varchar(255) not null,
    sehir varchar(255) not null,
    aciklama varchar(255) not null
);

-- create procedure addCar 
delimiter //
create procedure addCar(
    in marka varchar(255),
    in model int,
    in fiyat int,
    in yil varchar(255),
    in sehir varchar(255),
    in aciklama varchar(255)
)
begin
    insert into car(marka, model, fiyat, yil, sehir, aciklama)
    values(marka, model, fiyat, yil, sehir, aciklama);
end //
delimiter ;

-- create procedure deleteCar
delimiter //
create procedure deleteCar(
    in id int
)
begin
    delete from car where id = id;
end //
delimiter ;

-- create procedure updateCar
delimiter //
create procedure updateCar(
    in id int,
    in marka varchar(255),
    in model int,
    in fiyat int,
    in yil varchar(255),
    in sehir varchar(255),
    in aciklama varchar(255)
)
begin
    update car set marka = marka, model = model, fiyat = fiyat, yil = yil, sehir = sehir, aciklama = aciklama where id = id;
end //
delimiter ;


-- create procedure getCar
delimiter //
create procedure getCar(
    in id int
)
begin
    select * from car where id = id;
end //
delimiter ;


-- create procedure getAllCar
delimiter //
create procedure getAllCar()
begin
    select * from car;
end //
delimiter ;


-- create customer table
create table customer(
    id int not null auto_increment primary key,
    adi varchar(255) not null,
    soyadi varchar(255) not null,
    telefon varchar(255) not null,
    mail varchar(255) not null,
    adres varchar(255) not null
);

-- create procedure addCustomer
delimiter //
create procedure addCustomer(
    in adi varchar(255),
    in soyadi varchar(255),
    in telefon varchar(255),
    in mail varchar(255),
    in adres varchar(255)
)
begin
    insert into customer(adi, soyadi, telefon, mail, adres)
    values(adi, soyadi, telefon, mail, adres);
end //
delimiter ;

-- create procedure deleteCustomer
delimiter //
create procedure deleteCustomer(
    in id int
)
begin
    delete from customer where id = id;
end //
delimiter ;

-- create procedure updateCustomer
delimiter //
create procedure updateCustomer(
    in id int,
    in adi varchar(255),
    in soyadi varchar(255),
    in telefon varchar(255),
    in mail varchar(255),
    in adres varchar(255)
)
begin
    update customer set adi = adi, soyadi = soyadi, telefon = telefon, mail = mail, adres = adres where id = id;
end //
delimiter ;


-- create procedure getCustomer
delimiter //
create procedure getCustomer(
    in id int
)
begin
    select * from customer where id = id;
end //
delimiter ;


-- create procedure getAllCustomer
delimiter //
create procedure getAllCustomer()
begin
    select * from customer;
end //
delimiter ;


-- create sale table
create table sale(
    id int not null auto_increment primary key,
    car_id int not null,
    customer_id int not null,
    date_time varchar(255) not null,
    price int not null
);

-- create procedure addSale
delimiter //
create procedure addSale(
    in car_id int,
    in customer_id int,
    in date_time varchar(255),
    in price int
)
begin
    insert into sale(car_id, customer_id, date_time, price)
    values(car_id, customer_id, date_time, price);
end //
delimiter ;

-- create procedure deleteSale
delimiter //
create procedure deleteSale(
    in id int
)
begin
    delete from sale where id = id;
end //
delimiter ;

-- create procedure updateSale
delimiter //
create procedure updateSale(
    in id int,
    in car_id int,
    in customer_id int,
    in date_time varchar(255),
    in price int
)
begin
    update sale set car_id = car_id, customer_id = customer_id, date_time = date_time, price = price where id = id;
end //
delimiter ;

-- create procedure getSale
delimiter //
create procedure getSale(
    in id int
)
begin
    select * from sale where id = id;
end //
delimiter ;


-- create procedure getAllSale
delimiter //
create procedure getAllSale()
begin
    select * from sale;
end //
delimiter ;


-- create payment table
create table payment(
    id int not null auto_increment primary key,
    sale_id int not null,
    date_time varchar(255) not null,
    price int not null,
    payment_type varchar(255) not null,
    descriptions varchar(255) not null
);

-- create procedure addPayment
delimiter //
create procedure addPayment(
    in sale_id int,
    in date_time varchar(255),
    in price int,
    in payment_type varchar(50),
    in descriptionn  varchar(50)
)
begin
    insert into payment(sale_id, date_time, price, payment_type, descriptionn)
    values(sale_id, date_time, price, payment_type, descriptionn);
end //
delimiter ;


-- create procedure deletePayment
delimiter //
create procedure deletePayment(
    in id int
)
begin
    delete from payment where id = id;
end //
delimiter ;


-- create procedure updatePayment
delimiter //
create procedure updatePayment(
    in id int,
    in sale_id int,
    in date_time varchar(255),
    in price int,
    in payment_type varchar(50),
    in descriptionn varchar(50)
)
begin
    update payment set sale_id = sale_id, date_time = date_time, price = price, payment_type = payment_type , descriptions = descriptions where id = id;
end //
delimiter ;

-- create procedure getPayment
delimiter //
create procedure getPayment(
    in id int
)
begin
    select * from payment where id = id;
end //
delimiter ;


-- create procedure getAllPayment
delimiter //
create procedure getAllPayment()
begin
    select * from payment;
end //
delimiter ;

