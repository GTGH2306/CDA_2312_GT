DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE etudiants(
	id_etu INT AUTO_INCREMENT NOT NULL,
	nom_etu VARCHAR(20),
	pnom_etu VARCHAR(20),
	date_entree_etu DATE,
	CONSTRAINT pk_etu PRIMARY KEY (id_etu)
);

CREATE TABLE matieres(
	id_mat INT AUTO_INCREMENT NOT NULL,
	lib_mat VARCHAR(30) UNIQUE,
	coef_mat INT,
	CONSTRAINT pk_mat PRIMARY KEY (id_mat)
);

CREATE TABLE controles (
	moyenne_cont DECIMAL(4, 2),
	id_etu INT,
	id_mat INT,
	CONSTRAINT pk_controle PRIMARY KEY (id_etu, id_mat),
	CONSTRAINT fk_etu FOREIGN KEY (id_etu) REFERENCES etudiants(id_etu),
	CONSTRAINT fk_mat FOREIGN KEY (id_mat) REFERENCES matieres(id_mat)
);