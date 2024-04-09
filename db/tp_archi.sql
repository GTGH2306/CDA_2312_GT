USE db_architecte;

/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */
SELECT
	client_ref,
	client_nom,
	client_telephone
FROM clients
WHERE client_telephone LIKE '04%'
;

/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */
SELECT
	cli.client_ref,
	cli.client_nom,
	type_cli.type_client_libelle
FROM clients AS cli
INNER JOIN type_clients AS type_cli ON
cli.type_client_id = type_cli.type_client_id
WHERE (LOWER(type_cli.type_client_libelle) = 'particulier');


/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */
SELECT
	cli.client_ref,
	cli.client_nom,
	type_cli.type_client_libelle
FROM clients AS cli
INNER JOIN type_clients AS type_cli ON
cli.type_client_id = type_cli.type_client_id
WHERE (LOWER(type_cli.type_client_libelle) != 'particulier');

/* 4. Sélectionner les projets qui ont été livrés en retard */
SELECT
	projet_ref,
	projet_date_fin_prevue,
	projet_date_fin_effective
FROM projets
WHERE projet_date_fin_effective > projet_date_fin_prevue;

/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets
 avec le nom du client et le nom de l'architecte associés au projet */
SELECT
	proj.projet_date_depot AS 'Date dépôt',
	proj.projet_date_fin_prevue AS 'Fin prévue',
	proj.projet_superficie_totale,
	proj.projet_superficie_batie,
	cli.client_nom AS 'Nom Client',
	emp.emp_nom AS 'Nom Architecte'
FROM projets AS proj
INNER JOIN clients AS cli ON
proj.client_ref = cli.client_ref
INNER JOIN employes AS emp ON
proj.emp_matricule = emp.emp_matricule
;

/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */
SELECT
	proj.projet_date_depot,
	proj.projet_date_fin_prevue,
	proj.projet_superficie_totale,
	proj.projet_superficie_batie,
	proj.projet_prix AS 'Prix',
	COUNT(part.emp_matricule) AS 'Intervenant'
FROM projets AS proj
INNER JOIN participer AS part ON
proj.projet_ref = part.projet_ref
GROUP BY
	proj.projet_ref;


/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */
SELECT
	tproj.type_projet_libelle AS 'Type projet',
	COUNT(proj.type_projet_id) 'Nombre de ce type',
	AVG(proj.projet_prix) AS 'Prix moyen'
FROM type_projets AS tproj
INNER JOIN projets AS proj ON 
tproj.type_projet_id = proj.type_projet_id
GROUP BY tproj.type_projet_libelle;

/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */
SELECT
	ttrav.type_travaux_libelle AS 'Type travaux',
	COUNT(proj.type_projet_id) 'Nombre de ce type',
	MAX(proj.projet_superficie_totale) AS 'Superficie Max'
FROM type_travaux AS ttrav
INNER JOIN projets AS proj ON 
ttrav.type_travaux_id = proj.type_travaux_id
GROUP BY ttrav.type_travaux_libelle;


/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */
SELECT
	proj.projet_date_depot AS 'Date depot',
	proj.projet_date_fin_prevue AS 'Fin prévue',
	proj.projet_prix AS 'Prix',
	cli.client_nom AS 'Nom client',
	cli.client_telephone AS 'Tel',
	cli.adresse AS 'Adresse',
	ttrav.type_travaux_libelle AS 'Type Travaux',
	tproj.type_projet_libelle AS 'Type Projet'
FROM projets AS proj
INNER JOIN (
	SELECT
		clinner.client_ref,
		clinner.client_nom,
		clinner.client_telephone,
		CONCAT(adr.adresse_num_voie, ' ', adr.adresse_voie, ', ', adr.adresse_code_postal, ' ' , adr.adresse_ville) AS 'adresse'
	FROM clients AS clinner
	INNER JOIN adresses AS adr ON
	clinner.adresse_id = adr.adresse_id
	) AS cli ON
proj.client_ref = cli.client_ref
INNER JOIN type_travaux AS ttrav ON
proj.type_travaux_id = ttrav.type_travaux_id
INNER JOIN type_projets AS tproj ON
proj.type_projet_id = tproj.type_projet_id


/* 10. Sélectionner les projets dont l'adresse est identique au client associé */
SELECT * FROM projets AS proj
INNER JOIN clients AS cli ON
proj.client_ref = cli.client_ref
WHERE
proj.adresse_id = cli.adresse_id

/* 11. Procedure pour selectionnner les projets dont un nom d'architecte donné est responsable*/
DROP PROCEDURE archiproj;
DELIMITER |
CREATE PROCEDURE archiproj(IN archinom_ VARCHAR(50))
BEGIN
	SELECT projet_ref
	FROM projets
	NATURAL JOIN employes
	WHERE emp_nom = archinom_;
END |
DELIMITER ;

CALL archiproj('Roussotte');
CALL archiproj('Golay');

/* 12- Cree une procedure stocke qui pour un nom de salarié renvoie dans une variable le budget total des projets dont
il est responsable, et renvoie 0 si pas de projet en responsabilité */
DELIMITER |
CREATE PROCEDURE budget_projet(IN archinom_ VARCHAR(50), OUT budget_ DECIMAL(20,2))
BEGIN
	SELECT
		IFNULL(SUM(projet_prix), 0)
	INTO budget_
	FROM
		projets
	INNER JOIN employes ON
		employes.emp_matricule = projets.emp_matricule
	WHERE
		employes.emp_nom = archinom_;
END |
DELIMITER ;

SET @budget = 0;

CALL budget_projet('Roussotte', @budget);
SELECT @budget;

CALL budget_projet('Golay', @budget);
SELECT @budget;

CALL budget_projet('Neymar', @budget);
SELECT @budget;