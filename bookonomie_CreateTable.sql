drop database if exists bookonomie;

create database bookonomie;

use bookonomie;


CREATE TABLE Author (
    AuthorId INT AUTO_INCREMENT PRIMARY KEY,
    Authorname VARCHAR(255) NOT NULL
);

CREATE TABLE Book (
    BookId INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(45) NOT NULL,
    Description TEXT,
    Rating double,
    ReleaseYear INT,
    fk_AuthorId INT,
    FOREIGN KEY (fk_AuthorId) REFERENCES Author(AuthorId) ON DELETE CASCADE
);

CREATE TABLE Genre (
    GenreId INT AUTO_INCREMENT PRIMARY KEY,
    Genrename VARCHAR(255) NOT NULL
);

CREATE TABLE BookonomieUser (
    fk_BookId INT,
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    Username varchar(30),
    Userpassword varchar(30),
    FOREIGN KEY (fk_BookId) REFERENCES Book(BookId) ON DELETE CASCADE
);

CREATE TABLE BookUser (
	fk_BookId INT,
    fk_UserId INT,
    FOREIGN KEY (fk_BookId) REFERENCES Book(BookId) ON DELETE CASCADE,
    FOREIGN KEY (fk_UserId) REFERENCES BookonomieUser(UserId) ON DELETE CASCADE
);

CREATE TABLE BookGenre (
    fk_BookId INT,
    fk_GenreId INT,
    FOREIGN KEY (fk_BookId) REFERENCES Book(BookId) ON DELETE CASCADE,
    FOREIGN KEY (fk_GenreId) REFERENCES Genre(GenreId) ON DELETE CASCADE
);