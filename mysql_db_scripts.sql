create database bancouser;

use bancouser;

create table user
(
    Id varchar(20) auto_increment primary key NOT NULL,
    nameUser varchar(70) NOT NULL,
    loginUser varchar(15) NOT NULL,
    passwordUser varchar(20) NOT NULL,
    Email varchar(50) NOT NULL,
    Phone varchar(15) NOT NULL,
    CPF varchar(15) NOT NULL,
    birthDate varchar(15) NOT NULL,
    mothersName varchar(70) NOT NULL,
    statusUser varchar(11) NOT NULL,
    created_at varchar(15) NOT NULL,
    updated_at varchar(15) NOT NULL,
);