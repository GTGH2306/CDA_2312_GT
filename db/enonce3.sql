DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE etudiants(
	id_etu INT AUTO_INCREMENT,
	nom_etu VARCHAR(20) NOT NULL,
	pnom_etu VARCHAR(20) NOT NULL,
	date_entree_etu DATE NOT NULL DEFAULT (CURDATE()),
	CONSTRAINT pk_etu PRIMARY KEY (id_etu)
);

CREATE TABLE matieres(
	id_mat INT AUTO_INCREMENT,
	lib_mat VARCHAR(30) UNIQUE NOT NULL,
	coef_mat INT NOT NULL,
	CONSTRAINT coef_valide CHECK (coef_mat < 10),
	CONSTRAINT pk_mat PRIMARY KEY (id_mat)
);

CREATE TABLE controles (
	moyenne_cont DECIMAL(4, 2) NOT NULL,
	date_cont DATE NOT NULL,
	id_etu INT,
	id_mat INT,
	CONSTRAINT CHECK (moyenne_cont < 20),
	CONSTRAINT pk_controle PRIMARY KEY (id_etu, id_mat),
	CONSTRAINT fk_etu FOREIGN KEY (id_etu) REFERENCES etudiants(id_etu),
	CONSTRAINT fk_mat FOREIGN KEY (id_mat) REFERENCES matieres(id_mat)
);

INSERT INTO etudiants(nom_etu, pnom_etu)
VALUES
	('Dalton', 'Joe');
	
	
INSERT INTO matieres(lib_mat, coef_mat)
VALUES
	('Mathmemagique', 9),
	('Meteorologie', 3);
	
INSERT INTO controles(moyenne_cont, id_etu, id_mat, date_cont)
VALUES
	(13, 1, 1, '1985-08-16'),
	(15, 1, 2, '1753-07-12');