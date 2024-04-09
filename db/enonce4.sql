DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE livres(
	isbn_livre VARCHAR(15),
	titre_livre VARCHAR(50) NOT NULL,
	CONSTRAINT pk_livre PRIMARY KEY (isbn_livre)
);

CREATE TABLE exemplaires(
	num_exempl INT AUTO_INCREMENT,
	etat ENUM('D', 'E', 'P') DEFAULT 'D',
	isbn_livre VARCHAR(15) NOT NULL,
	CONSTRAINT pk_exempl PRIMARY KEY (num_exempl),
	CONSTRAINT fk_livre FOREIGN KEY (isbn_livre) REFERENCES livres(isbn_livre)
);

INSERT INTO livres (isbn_livre, titre_livre)
	VALUES
	('86547921495', 'Moby Dick'),
	('94564566853', 'Romeo et Juliette(version rap)');

INSERT INTO exemplaires (etat, isbn_livre)
	VALUES
	('P', '86547921495'),
	('E', '86547921495'),
	('E', '94564566853'),
	('D', '86547921495'),
	('D', '86547921495'),
	('P', '94564566853');
	