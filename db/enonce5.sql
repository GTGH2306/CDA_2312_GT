DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE rayons (
	nom_rayon VARCHAR(50),
	CONSTRAINT pk_rayon PRIMARY KEY(nom_rayon)
);

CREATE TABLE magasins (
	code_mag INT AUTO_INCREMENT,
	nom_mag VARCHAR(50) NOT NULL,
	CONSTRAINT pk_mag PRIMARY KEY(code_mag)
);

CREATE TABLE articles (
	code_art INT AUTO_INCREMENT,
	nom_art VARCHAR(50) NOT NULL,
	type_art ENUM('P', 'L', 'D'),
	CONSTRAINT pk_art PRIMARY KEY(code_art)
);

CREATE TABLE stocks (
	nom_rayon VARCHAR(50),
	code_mag INT,
	code_art INT,
	qte_stock INT NOT NULL,
	CONSTRAINT fk_magasin FOREIGN KEY (code_mag) REFERENCES magasins(code_mag),
	CONSTRAINT fk_rayon FOREIGN KEY (nom_rayon) REFERENCES rayons(nom_rayon),
	CONSTRAINT fk_article FOREIGN KEY (code_art) REFERENCES articles(code_art),
	CONSTRAINT pk_stock PRIMARY KEY(code_mag, nom_rayon, code_art)
);