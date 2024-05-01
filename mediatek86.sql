//Configuration du nouvel utilisateur et de la base de données utilisée par l'application

CREATE USER 'dbadmin'@'localhost' IDENTIFIED BY 'P@$$word2';
CREATE DATABASE mediatek86;
GRANT PRIVILEGE ON mediatek86 TO 'dbadmin'@'localhost';

//Création du schéma de la base de données

CREATE TABLE service(
   idservice INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   PRIMARY KEY(idservice)
);

CREATE TABLE motif(
   idmotif INT AUTO_INCREMENT,
   libelle VARCHAR(128) ,
   PRIMARY KEY(idmotif)
);

CREATE TABLE personnel(
   idpersonnel INT AUTO_INCREMENT,
   nom VARCHAR(50) ,
   prenom VARCHAR(50) ,
   tel VARCHAR(15) ,
   mail VARCHAR(128) ,
   idservice INT NOT NULL,
   PRIMARY KEY(idpersonnel),
   FOREIGN KEY(idservice) REFERENCES service(idservice) ON DELETE CASCADE
);

CREATE TABLE absence(
   idpersonnel INT,
   datedebut DATETIME,
   datefin DATETIME,
   idmotif INT NOT NULL,
   PRIMARY KEY(idpersonnel, datedebut),
   FOREIGN KEY(idpersonnel) REFERENCES personnel(idpersonnel) ON DELETE CASCADE,
   FOREIGN KEY(idmotif) REFERENCES motif(idmotif) ON DELETE CASCADE
);
CREATE TABLE responsable
(
   login VARCHAR(50),
   pwd VARCHAR(255)
);


//Peuplement de la base de données avec des données générées pseudo-aléatoirement.

//responsable

INSERT INTO responsable (login, pwd) VALUES("admin", SHA2("P@$$word1", 256));


//motifs

INSERT INTO motif (idmotif, libelle) VALUES(1, "vacances");
INSERT INTO motif (idmotif, libelle) VALUES(2, "maladie");
INSERT INTO motif (idmotif, libelle) VALUES(3, "motif familial");
INSERT INTO motif (idmotif, libelle) VALUES(4, "congé parental");

//services

INSERT INTO service (idservice, nom) VALUES(1, "administratif");
INSERT INTO service (idservice, nom) VALUES(2, "médiation culturelle");
INSERT INTO service (idservice, nom) VALUES(3, prêt);

//personnel

INSERT INTO `personnel` (`idpersonnel`,`nom`,`prenom`,`tel`,`mail`,`idservice`)
VALUES
  (1,"Kylan","Collins","06 75 03 05 64","donec@aol.couk",2),
  (2,"Kenyon","Flores","04 55 89 10 79","facilisis.suspendisse@aol.com",1),
  (3,"Sage","Padilla","07 74 41 45 65","dui@outlook.edu",1),
  (4,"Gabriel","Gould","05 08 25 16 11","sit.amet@protonmail.ca",3),
  (5,"Lacota","Griffin","05 61 49 57 45","eros@icloud.com",1),
  (6,"Madison","Stark","02 85 51 88 18","pede.praesent@hotmail.net",3),
  (7,"Lawrence","Pollard","05 33 67 57 56","vehicula.aliquet@protonmail.couk",1),
  (8,"Zane","Garrison","02 69 07 22 83","rutrum@hotmail.ca",2),
  (9,"Brynn","Ellis","01 48 72 34 90","elit@outlook.edu",1),
  (10,"Jarrod","Fields","04 74 32 02 91","ornare.libero@aol.ca",1);

//absence

INSERT INTO `absence` (`idpersonnel`,`datedebut`,`datefin`,`idmotif`)
VALUES
  (5,"2024-10-14 17:42:01","2023-09-22 21:36:31",3),
  (7,"2024-09-02 06:33:13","2024-12-12 16:22:07",2),
  (10,"2024-01-11 22:56:08","2025-03-25 17:22:53",3),
  (9,"2024-08-17 19:15:11","2024-08-26 17:18:01",1),
  (3,"2024-07-07 10:50:30","2025-02-22 10:45:18",4),
  (2,"2024-08-14 20:33:32","2023-10-25 13:16:15",2),
  (4,"2025-03-26 23:53:47","2024-08-25 02:23:01",3),
  (3,"2025-04-13 13:11:20","2023-10-26 02:33:43",3),
  (7,"2023-11-19 04:31:26","2025-02-08 13:11:10",1),
  (3,"2023-09-09 14:40:40","2024-08-31 11:47:51",1);
INSERT INTO `absence` (`idpersonnel`,`datedebut`,`datefin`,`idmotif`)
VALUES
  (2,"2024-10-06 23:00:18","2024-08-25 20:13:14",1),
  (9,"2024-06-25 15:39:01","2023-08-11 00:15:47",2),
  (6,"2023-06-21 05:13:36","2025-01-15 13:28:41",3),
  (6,"2024-06-15 08:54:12","2023-07-04 19:18:21",4),
  (6,"2023-06-21 20:47:42","2023-11-05 06:36:00",4),
  (4,"2024-11-12 15:14:07","2023-09-30 09:13:32",2),
  (5,"2023-12-15 07:44:11","2023-11-13 05:44:31",2),
  (2,"2025-02-12 01:53:02","2024-01-09 00:57:39",1),
  (4,"2024-05-12 14:52:48","2023-05-31 19:36:42",3),
  (7,"2024-10-05 08:57:22","2024-04-10 00:11:26",3);
INSERT INTO `absence` (`idpersonnel`,`datedebut`,`datefin`,`idmotif`)
VALUES
  (1,"2024-03-08 03:27:35","2024-07-12 18:57:48",2),
  (3,"2024-08-21 23:46:23","2024-06-13 14:37:50",3),
  (3,"2024-06-26 18:35:54","2024-08-16 21:33:00",2),
  (7,"2024-12-26 02:55:33","2024-10-27 17:50:55",4),
  (4,"2025-04-11 05:29:13","2023-10-25 01:59:04",4),
  (5,"2024-08-25 10:20:44","2024-03-31 10:03:21",3),
  (8,"2023-07-31 16:11:41","2025-03-20 07:13:31",2),
  (1,"2023-05-09 04:30:08","2024-08-13 14:08:56",3),
  (4,"2025-03-24 20:36:56","2024-02-08 12:46:42",4),
  (8,"2024-09-29 15:50:43","2024-06-19 09:32:20",2);
INSERT INTO `absence` (`idpersonnel`,`datedebut`,`datefin`,`idmotif`)
VALUES
  (6,"2024-06-22 16:54:54","2024-12-30 14:30:58",2),
  (6,"2023-09-08 11:58:43","2023-05-19 03:26:07",3),
  (3,"2023-12-21 12:44:35","2025-01-07 18:56:43",3),
  (7,"2024-10-28 05:45:29","2024-04-12 14:32:58",4),
  (5,"2024-06-24 12:59:10","2025-04-13 13:48:02",2),
  (1,"2024-06-10 15:20:29","2023-12-21 22:08:05",4),
  (1,"2024-11-13 00:35:43","2023-11-15 20:45:49",4),
  (4,"2024-10-08 16:51:08","2023-12-10 10:23:30",3),
  (3,"2024-10-20 07:38:57","2024-02-25 06:42:02",4),
  (5,"2024-08-26 22:34:07","2024-09-22 00:45:29",3);
INSERT INTO `absence` (`idpersonnel`,`datedebut`,`datefin`,`idmotif`)
VALUES
  (4,"2024-09-15 17:28:05","2024-01-04 16:26:37",1),
  (7,"2024-05-21 02:06:09","2023-07-31 07:34:11",4),
  (6,"2023-11-26 18:22:48","2024-03-28 18:47:07",2),
  (2,"2024-01-25 15:43:34","2025-03-18 02:56:33",4),
  (8,"2023-06-05 12:46:53","2023-04-22 04:24:22",2),
  (3,"2024-05-04 18:29:27","2024-12-22 18:03:22",2),
  (7,"2023-09-29 12:18:09","2024-11-05 09:25:55",2),
  (2,"2024-07-05 10:52:29","2024-06-24 02:25:48",2),
  (4,"2024-05-17 00:41:21","2025-04-07 21:54:32",1),
  (6,"2023-06-21 01:56:33","2024-06-09 18:29:43",2);


