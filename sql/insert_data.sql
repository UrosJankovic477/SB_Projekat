INSERT INTO TRAVNJAK (opstina, ugrozenost, adresa_zgrade, povrsina_a) VALUES ('Medijana', 'visoka', 'Bulevar dr. Zorana Djindjica', '10');
INSERT INTO TRAVNJAK (opstina, ugrozenost, adresa_zgrade, povrsina_a) VALUES ('Pantelej', 'srednja', 'Knjaževa?ka', '15');
INSERT INTO DRVORED (opstina, ugrozenost, ulica, br_stabala, vrsta_drveta) VALUES ('Medijana', 'srednja', 'Bulevar Vojvode Misica', 10, 'Javor');
INSERT INTO DRVORED (opstina, ugrozenost, ulica, br_stabala, vrsta_drveta) VALUES ('Medijana', 'niska', 'Bulevar dr. Zorana Djin?i?a', 20, 'Javor');
INSERT INTO DRVORED (opstina, ugrozenost, ulica, br_stabala, vrsta_drveta) VALUES ('Palilula', 'srednja', 'sample_ulica1', 10, 'Jablan');
INSERT INTO DRVORED (opstina, ugrozenost, ulica, br_stabala, vrsta_drveta) VALUES ('Medijana', 'niska', 'sample_ulica2', 12, 'Lipa');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('1204989731231', 'Petar', 'Dobrivoje', 'Petrovic', 'sample_ulica1', '12-APR-89', '4. stepen', '0', '1', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('1005989731231', 'Luka', 'Predrag', 'Lukic', 'sample_ulica2', '10-MAY-89', '4. stepen', '0', '0', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('2002988731231', 'Kosta', 'Gavrilo', 'Kostic', 'sample_ulica2', '20-FEB-88', '7. stepen', '1', '1', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('2102988731241', 'Darko', 'Atanas', 'Jovanovic', 'sample_ulica2', '21-FEB-88', '7. stepen', '1', '1', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('0101988731244', 'Miodrag', 'Radomir', 'Mu?ibabic', 'sample_ulica2', '01-JAN-88', '7. stepen', '1', '0', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('0101988731344', 'Jon', 'Joe', 'Doe', 'sample_ulica3', '01-JAN-88', '4. stepen', '0', '0', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('0201988731354', 'Jon2', 'Joe2', 'Doe2', 'sample_ulica4', '02-JAN-88', '4. stepen', '0', '0', '1');

INSERT INTO RADNIK (mbr, lime, sime, prezime, adresa, dat_rodjenja, strucna_sprema, odrzava_higijenu, odrzava_obj_parka, odrzava_zelenila) 
VALUES ('0202988731857', 'Jon3', 'Joe3', 'Doe3', 'sample_ulica5', '02-FEB-88', '7. stepen', '1', '0', '1');

INSERT INTO PARK (opstina, ugrozenost, naziv, povrsina_ha, id_sefa) VALUES ('Medijana', 'srednja', 'Cair', '30', '4');
INSERT INTO PARK (opstina, ugrozenost, naziv, povrsina_ha, id_sefa) VALUES ('Palilula', 'niska', 'Spomen-park Bubanj', '100', '3');
INSERT INTO PARK (opstina, ugrozenost, naziv, povrsina_ha, id_sefa) VALUES ('Niska Banja', 'niska', 'Park u Niskoj Banji', '20', '8');

UPDATE RADNIK SET BR_PARKA = 8 WHERE RADNIK.BR_RAD_KNJIZICE = '1';
UPDATE RADNIK SET BR_PARKA = 8 WHERE RADNIK.BR_RAD_KNJIZICE = '2';
UPDATE RADNIK SET BR_PARKA = 7 WHERE RADNIK.BR_RAD_KNJIZICE = '5';
UPDATE RADNIK SET BR_PARKA = 7 WHERE RADNIK.BR_RAD_KNJIZICE = '6';
UPDATE RADNIK SET BR_PARKA = 9 WHERE RADNIK.BR_RAD_KNJIZICE = '7';

INSERT INTO FONTANA (br_parka) VALUES ('9');
INSERT INTO KLUPA (br_parka) VALUES ('8');
INSERT INTO KLUPA (br_parka) VALUES ('8');
INSERT INTO KLUPA (br_parka) VALUES ('7');
INSERT INTO KLUPA (br_parka) VALUES ('9');
INSERT INTO SVETILJKA (br_parka) VALUES ('7');
INSERT INTO SVETILJKA (br_parka) VALUES ('7');
INSERT INTO SVETILJKA (br_parka) VALUES ('8');
INSERT INTO SVETILJKA (br_parka) VALUES ('8');

INSERT INTO DRVO (dat_sadjenja, obim_debla, povrsina_krosnje, visina_krosnje, vrsta, br_parka)
VALUES ('01-MAR-99', '1.5', '10', '10', 'Breza', '7');

INSERT INTO DRVO (dat_sadjenja, obim_debla, povrsina_krosnje, visina_krosnje, vrsta, br_parka)
VALUES ('01-MAR-99', '1.2', '12', '5', 'Bor', '7');

INSERT INTO DRVO (dat_sadjenja, obim_debla, povrsina_krosnje, visina_krosnje, vrsta, br_parka)
VALUES ('02-MAR-99', '1.5', '10', '12', 'Bor', '8');

INSERT INTO ZASTICENI_OBJ (opis, dat_stavljanja_pod_zastitu, institucija, god_troskovi)
VALUES ('Tri pesnice, simbol borbe protiv fasizma', '1-MAY-93', 'sample institucija1', '10000'); 

INSERT INTO ZASTICENI_OBJ (opis, dat_stavljanja_pod_zastitu, institucija, god_troskovi)
VALUES ('Beli dud u centru Niske Banje, najveci i najstariji dud u Niskoj Banji', '2-MAY-93', 'sample institucija2', '4000');

INSERT INTO ZASTICENI_OBJ (opis, dat_stavljanja_pod_zastitu, institucija, god_troskovi)
VALUES ('Sample spomenik', '3-MAY-93', 'sample institucija1', '6000');

INSERT INTO SKULPTURA (br_parka, zasticeni_obj_id) VALUES ('8', '1');

INSERT INTO DRVO (dat_sadjenja, obim_debla, povrsina_krosnje, visina_krosnje, vrsta, br_parka, zasticeni_obj_id)
VALUES ('01-MAR-99', '1.5', '10', '10', 'Beli dud', '9', '2');

INSERT INTO SPOMENIK (br_parka, zasticeni_obj_id) VALUES ('7', '3');

INSERT INTO IGRALISTE (br_igracaka, godine_od, godine_do, pesak, br_parka) VALUES ('10', '3', '12', 'Da', '7');
INSERT INTO IGRALISTE (br_igracaka, godine_od, godine_do, pesak, br_parka) VALUES ('5', '0', '6', 'Da', '9');
INSERT INTO IGRALISTE (br_igracaka, godine_od, godine_do, pesak, br_parka) VALUES ('8', '3', '12', 'Ne', '7');
