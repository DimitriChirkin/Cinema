create database Cinema ;
use Cinema;

create table Film
(id_film tinyint AUTO_INCREMENT PRIMARY Key ,
name_film char(100) NOT NULL,
lasting int(4) NOT NULL,
producer char(100) NOT NULL,
photo longblob NOT NULL,
description text not null,
limitation varchar(3) not null ) engine InnoDB character set utf8;

create table FilmGenre
(id_filmgenre tinyint AUTO_INCREMENT PRIMARY Key ,
id_genre tinyint not null,
id_film tinyint not null,
foreign key (id_film) references Film(id_film),
foreign key (id_genre) references Genre(id_genre))  engine InnoDB character set utf8;

create table Genre
(id_genre tinyint AUTO_INCREMENT PRIMARY Key ,
Genre  char(50) not null)  engine InnoDB character set utf8;

create table Actor
(id_actor tinyint AUTO_INCREMENT PRIMARY Key ,
id_film tinyint not null,
Main_male_role char(50) not null,
Main_female_role char (50) not null,
foreign key (id_film) references Film (id_film)) engine InnoDB character set utf8;

create table Employees
(id_employees tinyint AUTO_INCREMENT PRIMARY Key ,
surname char(50) not null,
name_employees char(50) not null,
patronicym char(50) not null,
id_position tinyint not null,
phone int(13) not null,
foreign key (id_position) references Position (id_position))  engine InnoDB character set utf8;

create table Position
(id_position tinyint AUTO_INCREMENT PRIMARY Key ,
Position char(50) not null)engine InnoDB character set utf8;

create table Timetable
(id_timetable tinyint AUTO_INCREMENT PRIMARY Key ,
id_film tinyint not null,
id_seance tinyint not null,
date_timetable date not null,
foreign key (id_film) references Film (id_film),
foreign key (id_seance) references Seance (id_seance))engine InnoDB character set utf8;  

create table  Seance
(id_seance tinyint AUTO_INCREMENT PRIMARY Key ,
id_hall tinyint not null,
time_seance time not null,
price decimal (10,2) not null,
foreign key (id_hall) references Hall (id_hall))engine InnoDB character set utf8; 
 
 create table Hall
 (id_hall tinyint AUTO_INCREMENT PRIMARY Key ,
 name_hall char(50) not null,
 id_measuring tinyint not null,
 Number_of_seats int(35) not null,
 foreign key ( id_measuring) references Measuring( id_measuring))engine InnoDB character set utf8;
 
 create table Measuring
(id_measuring tinyint AUTO_INCREMENT PRIMARY Key,
Measuring char(12) not null) engine InnoDB character set utf8;

create table Place
(id_place tinyint AUTO_INCREMENT PRIMARY Key,
 id_measuring tinyint not null,
 row_place int(10) not null,
 place int(10) not null,
  foreign key ( id_measuring) references Measuring( id_measuring))  engine InnoDB character set utf8;
 
 create table Ticket
(barcode tinyint AUTO_INCREMENT PRIMARY Key, 
id_tab tinyint not null,
id_timetable tinyint ,
id_place tinyint not null,
foreign key ( id_tab) references Tab( id_tab),
foreign key (id_timetable) references Timetable ( id_timetable),
foreign key (id_place) references Place( id_place))  engine InnoDB character set utf8;

 create table Tab
(id_tab tinyint AUTO_INCREMENT PRIMARY Key,
id_employees tinyint not null, 
date_sale date not null,
time_sale time not null,
foreign key (id_employees) references Employees( id_employees))  engine InnoDB character set utf8;

