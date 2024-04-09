SELECT @@VERSION;

DROP DATABASE tp_avion;
CREATE DATABASE tp_avion;
USE tp_avion;

CREATE TABLE avions(
	id_av SMALLINT AUTO_INCREMENT,
	marq_av VARCHAR(20) NOT NULL,
	type_av VARCHAR(20) NOT NULL,
	cap_av SMALLINT NOT NULL,
	loc_av VARCHAR(30) NOT NULL,
	CONSTRAINT pk_av PRIMARY KEY(id_av)
);

ALTER TABLE avions AUTO_INCREMENT = 100;

CREATE TABLE pilotes(
	id_pil SMALLINT AUTO_INCREMENT,
	nom_pil VARCHAR(20) NOT NULL,
	adr_pil VARCHAR(30) NOT NULL,
	CONSTRAINT pk_pil PRIMARY KEY(id_pil)
);

CREATE TABLE vols(
	id_vol CHAR(5),
	vildep_vol VARCHAR(30) NOT NULL,
	vilarr_vol VARCHAR(30) NOT NULL,
	heuredep_vol TINYINT NOT NULL CHECK(heuredep_vol BETWEEN 0 AND 23),
	heurearr_vol TINYINT NOT NULL CHECK(heurearr_vol BETWEEN 0 AND 23),
	id_av SMALLINT(3) NOT NULL,
	id_pil SMALLINT NOT NULL,
	CONSTRAINT pk_vol PRIMARY KEY(id_vol),
	CONSTRAINT fk_av FOREIGN KEY(id_av) REFERENCES avions(id_av),
	CONSTRAINT fk_pil FOREIGN KEY(id_pil) REFERENCES pilotes(id_pil)
);

INSERT INTO avions
VALUES
	(id_av, 'AIRBUS', 'A320', 300, 'Nice'),
	(id_av, 'BOEING', 'B707', 250, 'Paris'),
	(id_av, 'AIRBUS', 'A320', 300, 'Toulouse'),
	(id_av, 'CARAVELLE', 'Caravelle', 200, 'Toulouse'),
	(id_av, 'BOEING', 'B747', 400, 'Paris'),
	(id_av, 'AIRBUS', 'A320', 300, 'Grenoble'),
	(id_av, 'ATR', 'ATR42', 50, 'Paris'),
	(id_av, 'BOEING', 'B727', 300, 'Lyon'),
	(id_av, 'BOEING', 'B727', 300, 'Nantes'),
	(id_av, 'AIRBUS', 'A340', 350, 'Bastia');
	
INSERT INTO pilotes
VALUES
	(id_pil, 'SERGE', 'Nice'),
	(id_pil, 'JEAN', 'Paris'),
	(id_pil, 'CLAUDE', 'Grenoble'),
	(id_pil, 'ROBERT', 'Nantes'),
	(id_pil, 'SIMON', 'Paris'),
	(id_pil, 'LUCIEN', 'Toulouse'),
	(id_pil, 'BERTRAND', 'Lyon'),
	(id_pil, 'HERVE', 'Bastia'),
	(id_pil, 'LUC', 'Paris');
	
INSERT INTO vols(id_vol, id_av, id_pil, vildep_vol, vilarr_vol, heuredep_vol, heurearr_vol)
VALUES
	('IT100', 100, 1, 'NICE', 'PARIS', 7, 9),
	('IT101', 100, 2, 'PARIS', 'TOULOUSE', 11, 12),
	('IT102', 101, 1, 'PARIS', 'NICE', 12, 14),
	('IT103', 105, 3, 'GRENOBLE', 'TOULOUSE', 9, 11),
	('IT104', 105, 3, 'TOULOUSE', 'GRENOBLE', 17, 19),
	('IT105', 107, 7, 'LYON', 'PARIS', 6, 7),
	('IT106', 109, 8, 'BASTIA', 'PARIS', 10, 13),
	('IT107', 106, 9, 'PARIS', 'BRIVE', 7, 8),
	('IT108', 106, 9, 'BRIVE', 'PARIS', 19, 20),
	('IT109', 107, 7, 'PARIS', 'LYON', 18, 19),
	('IT110', 102, 2, 'TOULOUSE', 'PARIS', 15, 16),
	('IT111', 101, 4, 'NICE', 'NANTES', 17, 19),
	('IT112', 103, 5, 'PARIS', 'NICE', 11, 13),
	('IT113', 104, 6, 'NICE', 'PARIS', 13, 15);
	

/* 1- Quels sont les vols au départ de Paris entre 12h et 14h ?*/
SELECT * FROM vols
WHERE vildep_vol = 'PARIS' AND heuredep_vol BETWEEN 12 AND 14;

/* 2- Quels sont les pilotes dont le nom commence par "S" ?*/
SELECT * FROM pilotes
WHERE LOWER(nom_pil) LIKE 's%';

/* 3- Pour chaque ville, donner le nombre et les capacités minimum et maximum des
avions qui s'y trouvent*/

DELIMITER |
CREATE PROCEDURE afficher_avions_cap()
BEGIN
	SELECT
		COUNT(id_av) AS 'Nb avions',
		MIN(cap_av) 'Capacité Min',
		MAX(cap_av) AS 'Capacité Max',
		loc_av AS 'Localisation'
	FROM avions
	GROUP BY loc_av;
END|
DELIMITER ;

CALL afficher_avions_cap();

/* 4- Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et
cela par type d'avion.*/
SELECT
	loc_av,
	AVG(cap_av),
	type_av
FROM avions
GROUP BY loc_av, type_av;

/* 5- Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1
avion ?*/
SELECT
	ROUND(AVG(cap_av))AS 'Capacité Moy',
	loc_av AS 'Localisation'
FROM avions
GROUP BY loc_av
HAVING COUNT(id_av) > 1;

/* 6- Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un
Airbus */
SELECT DISTINCT
	nom_pil,
	adr_pil,
	loc_av,
	marq_av
FROM pilotes
INNER JOIN avions ON
	loc_av = adr_pil
WHERE
	marq_av = 'AIRBUS';
	
/* 7- Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans
la ville de localisation d'un Airbus ? */
SELECT DISTINCT
	nom_pil,
	adr_pil,
	loc_av,
	marq_av
FROM vols AS vol
INNER JOIN avions AS av ON
	vol.id_av = av.id_av
INNER JOIN pilotes AS pil ON
	vol.id_pil = pil.id_pil
WHERE
	marq_av = 'AIRBUS' AND
	loc_av = adr_pil;
	
/* 8- Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans
la ville de localisation d'un Airbus ? */
SELECT DISTINCT
	nom_pil,
	adr_pil,
	loc_av,
	marq_av
FROM vols AS vol
INNER JOIN avions AS av ON
	vol.id_av = av.id_av
INNER JOIN pilotes AS pil ON
	vol.id_pil = pil.id_pil
WHERE
	marq_av = 'AIRBUS' OR
	loc_av = adr_pil;
	
/* 9- Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui
habitent dans la ville de localisation d'un Airbus ? */
SELECT DISTINCT
	nom_pil,
	adr_pil,
	loc_av,
	marq_av
FROM vols AS vol
INNER JOIN avions AS av ON
	vol.id_av = av.id_av
INNER JOIN pilotes AS pil ON
	vol.id_pil = pil.id_pil
WHERE
	marq_av = 'AIRBUS' AND
	loc_av <> adr_pil;
	
/* 10- Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par
Serge ?*/
SELECT
	*
FROM vols
NATURAL JOIN pilotes
WHERE
	(vildep_vol, vilarr_vol) IN (SELECT vildep_vol, vilarr_vol FROM vols NATURAL JOIN pilotes WHERE nom_pil = 'SERGE') AND
	nom_pil <> 'SERGE';
	
/* 11- Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).*/
SELECT
	pil1.nom_pil,
	pil1.adr_pil,
	pil2.adr_pil,
	pil2.nom_pil
FROM pilotes AS pil1
INNER JOIN pilotes AS pil2
ON pil1.adr_pil = pil2.adr_pil
WHERE
	pil1.id_pil <> pil2.id_pil;

/* 12- Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le
pilote n°1 ?*/

SELECT
pil.nom_pil
FROM pilotes AS pil
INNER JOIN vols AS vol ON vol.id_pil = pil.id_pil
WHERE
vol.id_av IN (SELECT id_av FROM pilotes NATURAL JOIN vols WHERE id_pil = 1) AND
pil.id_pil <> 1;

/* 13- Donner toutes les paires de villes telles qu'un avion localisé dans la ville de
départ soit conduit par un pilote résidant dans la ville d'arrivée.*/



/* 14- Sélectionner les numéros des pilotes qui conduisent tous les Airbus ?*/
SELECT
	id_vol,
	id_pil,
	marq_av
FROM vols
NATURAL JOIN avions
WHERE
	marq_av = 'AIRBUS';


/*test*/
SET @counter_test := 0;

DELIMITER |
CREATE PROCEDURE increment(IN to_increment INT)
BEGIN
	SET @counter_test := @counter_test + to_increment;
END|
DELIMITER ;

CALL increment(3);

SELECT @counter_test;

DROP PROCEDURE increment;

