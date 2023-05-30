create table daftarmenu(
no_makanan int(10) primary key,
nama_makanan varchar(60),
harga int(60)
);

create table user(
userid int(10) primary key,
fullname varchar(60),
bdate date,
address varchar(60),
username varchar(60),
password varchar(60)
);

create table history(
no_makanan int(10),
user_id int(10),
nama_makanan varchar(60),
jumlah int(10),
harga int(60),
total int(60),
waktu timestamp
);

alter table history add foreign key(no_makanan) references daftarmenu(no_makanan);
alter table history add foreign key(user_id) references user(userid);

insert into daftarmenu values
('1', "Onigiri Ayam Suwir", '12000'),
('2', "Onigiri Ikan Tongkol", '12000'),
('3', "Onigiri Tuna Mayo", '12000'),
('4', "Onigiri Rendang", '12000');