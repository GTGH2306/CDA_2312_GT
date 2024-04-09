DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE rayons(
	nom_ray VARCHAR(50),
	etage_ray INT,
	CONSTRAINT pk_ray PRIMARY KEY(nom_ray)
);

CREATE TABLE employes (
	code_emp INT AUTO_INCREMENT,
	nom_emp VARCHAR(50) NOT NULL,
	sal_emp DECIMAL(8, 2) NOT NULL,
	code_emp_chef INT,
	nom_ray VARCHAR(50),
	CONSTRAINT fk_emp_chef FOREIGN KEY (code_emp_chef) REFERENCES employes(code_emp),
	CONSTRAINT fk_emp_ray FOREIGN KEY (nom_ray) REFERENCES rayons(nom_ray),
	CONSTRAINT pk_emp PRIMARY KEY(code_emp)
);

CREATE TABLE articles (
	code_art INT AUTO_INCREMENT,
	nom_art VARCHAR(50),
	type_art VARCHAR(30),
	nom_ray VARCHAR(50),
	CONSTRAINT pk_art PRIMARY KEY (code_art),
	CONSTRAINT fk_art_ray FOREIGN KEY (nom_ray) REFERENCES rayons(nom_ray)
);

CREATE TABLE fournisseurs(
	code_fourn INT AUTO_INCREMENT,
	adr_fourn VARCHAR(50),
	nom_fourn VARCHAR(50),
	CONSTRAINT pk_fourn PRIMARY KEY(code_fourn)
);

CREATE TABLE fourn_art (
	code_fourn INT,
	code_art INT,
	quantites_fourn_art INT NOT NULL,
	CONSTRAINT fk_fourn_art_fourn FOREIGN KEY (code_fourn) REFERENCES fournisseurs(code_fourn),
	CONSTRAINT fk_fourn_art_art FOREIGN KEY (code_art) REFERENCES articles(code_art),
	CONSTRAINT pk_fourn_art PRIMARY KEY (code_art, code_fourn)
);

CREATE INDEX index_emp ON employes (nom_emp);
CREATE INDEX index_art ON articles (nom_art);