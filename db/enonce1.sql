DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE personnes(
	id_personne INT AUTO_INCREMENT NOT NULL,
	nom_personne VARCHAR(20) NOT NULL,
	pnom_personne VARCHAR(20) NOT NULL,
	num_rue_personne SMALLINT NOT NULL,
	rue_personne VARCHAR(100) NOT NULL,
	cp_personne INT NOT NULL,
	ville_personne VARCHAR(50) NOT NULL,
	CONSTRAINT PK_PERSONNES PRIMARY KEY(id_personne)
);

ALTER TABLE personnes
	ADD CONSTRAINT CP_VALIDE CHECK (cp_personne < 96000);

INSERT INTO personnes(nom_personne, pnom_personne, num_rue_personne, rue_personne, cp_personne, ville_personne)
VALUES
	('Dalton', 'Joe', 3, 'rue des peupliers', 95000, 'Montpellier');

CREATE TABLE vehicules(
	immat_vehicule VARCHAR(15) NOT NULL,
	marque_vehicule VARCHAR(50) NOT NULL,
	km_vehicule INT NOT NULL,
	date_mise_service_vehicule DATE NOT NULL,
	id_personne INT NOT NULL,
	CONSTRAINT PK_VEHICULE PRIMARY KEY (immat_vehicule),
	CONSTRAINT FK_PERSONNE FOREIGN KEY (id_personne) REFERENCES personnes(id_personne)
);

