CREATE TABLE PROPRIETAIRES(
   id_proprio INT AUTO_INCREMENT,
   nom_proprio VARCHAR(50)  NOT NULL,
   telephone_proprio VARCHAR(10)  NOT NULL,
   mail_proprio VARCHAR(50)  NOT NULL,
   status_proprio VARCHAR(50)  NOT NULL,
   office_notarial_proprio VARCHAR(50)  NOT NULL,
   pnom_proprio VARCHAR(50)  NOT NULL,
   adresse_proprio VARCHAR(100)  NOT NULL,
   PRIMARY KEY(id_proprio)
);

CREATE TABLE IMAGES(
   id_image INT AUTO_INCREMENT,
   titre_image VARCHAR(50)  NOT NULL,
   alt_image VARCHAR(100) ,
   source_image VARCHAR(150)  NOT NULL,
   extension_image VARCHAR(10)  NOT NULL,
   PRIMARY KEY(id_image)
);

CREATE TABLE UTILISATEURS(
   id_user INT AUTO_INCREMENT,
   nom_user VARCHAR(50)  NOT NULL,
   pnom_user VARCHAR(50)  NOT NULL,
   mail_user VARCHAR(50)  NOT NULL,
   niveau_user TINYINT NOT NULL,
   id_user_1 INT,
   PRIMARY KEY(id_user),
   FOREIGN KEY(id_user_1) REFERENCES UTILISATEURS(id_user)
);

CREATE TABLE TYPES_BIEN(
   id_type INT AUTO_INCREMENT,
   categorie VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_type)
);

CREATE TABLE DEPARTEMENTS(
   num_dep VARCHAR(3) ,
   lbl_dep VARCHAR(50)  NOT NULL,
   PRIMARY KEY(num_dep)
);

CREATE TABLE BIENS_IMMO(
   id INT AUTO_INCREMENT,
   titre VARCHAR(250) ,
   nb_pieces TINYINT NOT NULL,
   surface DECIMAL(8,2)   NOT NULL,
   prix DECIMAL(19,4) NOT NULL,
   description TEXT,
   ges CHAR(1)  NOT NULL,
   classe_eco CHAR(1) ,
   meubles BOOLEAN NOT NULL,
   localisation VARCHAR(250)  NOT NULL,
   ville VARCHAR(100)  NOT NULL,
   montant_charges DECIMAL(15,2)  ,
   num_dep VARCHAR(3)  NOT NULL,
   id_proprio INT NOT NULL,
   id_type INT NOT NULL,
   id_user INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(num_dep) REFERENCES DEPARTEMENTS(num_dep),
   FOREIGN KEY(id_proprio) REFERENCES PROPRIETAIRES(id_proprio),
   FOREIGN KEY(id_type) REFERENCES TYPES_BIEN(id_type),
   FOREIGN KEY(id_user) REFERENCES UTILISATEURS(id_user)
);

CREATE TABLE DOCUMENTS(
   id_document INT AUTO_INCREMENT,
   titre_document VARCHAR(50)  NOT NULL,
   source_document VARCHAR(100)  NOT NULL,
   extension_document VARCHAR(10)  NOT NULL,
   auteur_document VARCHAR(50)  NOT NULL,
   id INT NOT NULL,
   id_proprio INT NOT NULL,
   PRIMARY KEY(id_document),
   FOREIGN KEY(id) REFERENCES BIENS_IMMO(id),
   FOREIGN KEY(id_proprio) REFERENCES PROPRIETAIRES(id_proprio)
);

CREATE TABLE Imager(
   id INT,
   id_image INT,
   PRIMARY KEY(id, id_image),
   FOREIGN KEY(id) REFERENCES BIENS_IMMO(id),
   FOREIGN KEY(id_image) REFERENCES IMAGES(id_image)
);
