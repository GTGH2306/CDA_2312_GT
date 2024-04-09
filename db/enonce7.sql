DROP DATABASE tp1;
CREATE DATABASE tp1;
USE tp1;

CREATE TABLE vignerons(
	num_vig INT AUTO_INCREMENT,
	nom_vig VARCHAR(20) NOT NULL,
	prenom_vig VARCHAR(20) NOT NULL,
	ville_vig VARCHAR(30) NOT NULL,
	CONSTRAINT pk_vig PRIMARY KEY (num_vig),
	CONSTRAINT nom_pnom UNIQUE (nom_vig, prenom_vig)
);

CREATE TABLE entente(
	num_vig_ressenti INT,
	num_vig_etre_ressenti INT,
	critere_ressenti VARCHAR(50) NOT NULL,
	CONSTRAINT fk_ressenti FOREIGN KEY (num_vig_ressenti) REFERENCES vignerons(num_vig),
	CONSTRAINT fk_etre_ressenti FOREIGN KEY (num_vig_etre_ressenti) REFERENCES vignerons(num_vig),
	CONSTRAINT pk_ressenti PRIMARY KEY (num_vig_ressenti, num_vig_etre_ressenti)
);

CREATE TABLE vins(
	num_vin INT AUTO_INCREMENT,
	cru_vin VARCHAR(30) NOT NULL,
	milesime_vin VARCHAR(30) NOT NULL,
	num_vig INT,
	CONSTRAINT pk_vin PRIMARY KEY (num_vin),
	CONSTRAINT fk_vig FOREIGN KEY (num_vig) REFERENCES vignerons(num_vig)
);

CREATE TABLE buveurs(
	num_buv INT AUTO_INCREMENT,
	nom_buv VARCHAR(20) NOT NULL,
	prenom_buv VARCHAR(20) NOT NULL,
	ville_buv VARCHAR(30) NOT NULL,
	CONSTRAINT pk_buv PRIMARY KEY (num_buv)
);

CREATE TABLE commandes(
	num_com INT AUTO_INCREMENT,
	date_com DATE NOT NULL,
	num_buv INT,
	CONSTRAINT pk_com PRIMARY KEY (num_com),
	CONSTRAINT fk_buv FOREIGN KEY (num_buv) REFERENCES buveurs(num_buv)
);

CREATE TABLE vin_commandes(
	num_vin INT,
	num_com INT,
	quantite_vin_comm INT NOT NULL,
	CONSTRAINT fk_vin FOREIGN KEY (num_vin) REFERENCES vins(num_vin),
	CONSTRAINT fk_com FOREIGN KEY (num_com) REFERENCES commandes(num_com),
	CONSTRAINT pk_vin_com PRIMARY KEY (num_vin, num_com)
);

CREATE INDEX nom_pnom_buv ON buveurs (nom_buv, prenom_buv);
CREATE VIEW view_buv AS
	SELECT * FROM buveurs;