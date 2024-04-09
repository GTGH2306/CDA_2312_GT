DROP DATABASE tp_voyage;
CREATE DATABASE tp_voyage;
USE tp_voyage;


CREATE TABLE sales(
	com_code CHAR(5),
	com_name VARCHAR(64) NOT NULL,
	com_password CHAR(60) NOT NULL,
	com_sub CHAR(5),
	CONSTRAINT com_pk PRIMARY KEY(com_code),
	CONSTRAINT com_sub_fk FOREIGN KEY(com_sub) REFERENCES sales(com_code)
);

CREATE TABLE clients(
	client_id INT AUTO_INCREMENT,
	client_lastname VARCHAR(32) NOT NULL,
	client_firstname VARCHAR(32) NOT NULL,
	client_email VARCHAR(128) NOT NULL,
	client_phone CHAR(16) NOT NULL,
	client_added DATE NOT NULL,
	client_password CHAR(60) NOT NULL,
	com_code CHAR(5) NOT NULL,
	CONSTRAINT client_pk PRIMARY KEY(client_id),
	CONSTRAINT com_fk FOREIGN KEY(com_code) REFERENCES sales(com_code)
);

CREATE TABLE countries(
	country_code CHAR(2),
	country_name VARCHAR(128),
	CONSTRAINT country_pk PRIMARY KEY(country_code)
);

CREATE TABLE cities(
	city_code INT,
	city_name VARCHAR(128),
	country_code CHAR(2) NOT NULL,
	CONSTRAINT city_pk PRIMARY KEY(city_code),
	CONSTRAINT country_fk FOREIGN KEY(country_code) REFERENCES countries(country_code)
);

CREATE TABLE trips(
	trip_code INT,
	trip_title VARCHAR(128) NOT NULL,
	trip_available INT NOT NULL,
	trip_start DATETIME NOT NULL,
	trip_end DATETIME NOT NULL,
	trip_price DECIMAL(7,2) NOT NULL,
	trip_overview TEXT NOT NULL,
	trip_description TEXT NOT NULL,
	city_code INT NOT NULL,
	CONSTRAINT trip_pk PRIMARY KEY(trip_code),
	CONSTRAINT city_fk FOREIGN KEY(city_code) REFERENCES cities(city_code)
);

ALTER TABLE trips CHANGE trip_code trip_code INT AUTO_INCREMENT;

CREATE TABLE steps(
	city_code INT AUTO_INCREMENT,
	trip_code INT,
	step_start DATETIME NOT NULL,
	step_end DATETIME NOT NULL,
	CONSTRAINT city_step_fk FOREIGN KEY(city_code) REFERENCES cities(city_code),
	CONSTRAINT trip_step_fk FOREIGN KEY(trip_code) REFERENCES trips(trip_code),
	CONSTRAINT step_pk PRIMARY KEY(city_code, trip_code)
);

CREATE TABLE themes(
	theme_code INT AUTO_INCREMENT,
	theme_name VARCHAR(32) NOT NULL,
	theme_description TEXT NOT NULL,
	CONSTRAINT theme_pk PRIMARY KEY(theme_code)
);

CREATE TABLE suggest(
	theme_code INT,
	trip_code INT,
	CONSTRAINT theme_suggest_fk FOREIGN KEY(theme_code) REFERENCES themes(theme_code),
	CONSTRAINT trip_suggest_fk FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
);

CREATE TABLE orders(
	order_quantity TINYINT NOT NULL,
	order_paid BOOL NOT NULL,
	client_id INT,
	trip_code INT,
	CONSTRAINT client_order_fk FOREIGN KEY(client_id) REFERENCES clients(client_id),
	CONSTRAINT trip_order_fk FOREIGN KEY(trip_code) REFERENCES trips(trip_code),
	CONSTRAINT order_pk PRIMARY KEY(client_id, trip_code)
);

CREATE TABLE services(
	service_code INT AUTO_INCREMENT,
	service_name VARCHAR(32) NOT NULL,
	service_description TEXT NOT NULL,
	CONSTRAINT service_pk PRIMARY KEY(service_code)
);

CREATE TABLE note(
	service_score TINYINT NOT NULL,
	service_code INT,
	trip_code INT,
	client_id INT,
	CONSTRAINT service_note_fk FOREIGN KEY(service_code) REFERENCES services(service_code),
	CONSTRAINT trip_note_fk FOREIGN KEY(trip_code) REFERENCES trips(trip_code),
	CONSTRAINT client_cote_fk FOREIGN KEY(client_id) REFERENCES clients(client_id),
	CONSTRAINT note_pk PRIMARY KEY(service_code, trip_code, client_id)
);