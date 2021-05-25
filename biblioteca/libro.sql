create database libro;

use libro;

create table libros (
	id integer primary key auto_increment,
    titulo text not null,
    author text not null,
    estado text not null
)