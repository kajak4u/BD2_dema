insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Caracas', 'Lololo', 15, 1)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Miscatonic', 50, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Krakowska', 6, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Brukselka', 'Wybuchowa', 3, 2)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Bytom', 'Chorzowska', 5, 78)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Bytom', 'Katowicka', 35, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Chorz�w', 'Opolska', 19, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Katowice', 'Marsza�kowska', 75, 15)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Zadupie', 'Wiejska', 0, -1)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Bagno', 3, 2)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Asylum', 35, 14)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Independence Square', 7, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('San Francisco', 'Times Square', 147, 789)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 4, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 6, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 8, null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Gdynia', 'Wojskowa', 123, 456)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Gda�sk', 'Stoczniowa', 5090, 4887)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Hel', 'Argon', 4, 2)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Toaleta', 'Publiczna', -3, -15)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('San Francisco', 'Times Square', 100, 7)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Kolumbia', 'Bogota',0,null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Kapsztad', 'RPA',-404,null)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Sydney', 'Kangurk�w',705,1)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Rosja', 'Cmentarna',12,34)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('L�dek Zdr�j', 'Brytyjska',1,999)
insert into [BD_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Tokio', 'Chi�skich Bajek',1,2)
GO
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('registrar','Gra�yna','Polak',null,'grazyna@plaza.pl','+48801802803','39081198741',11,'grazyna','grazyna')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('registrar','D�essika','Stonoga',null,'jess.super.och@loffe.com','+48123456789','90081198741',7,'horom','curke')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('registrar','Test','Imienia',null,'jestemtestem@jest�tester�.de','+49876589358','01234567890',20,'rej','rej')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('doctor','Janusz','Zsunaj',97,'janusz.tzsunami@thaivan.jp','+48798456123','98752198741',9,'janusz','janusz')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('doctor','Jajami','Omate',3594,'zapasnik@japonja.pl','+11365723495','64897244932',13,'jaja','mata')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('doctor','Janusz','Cebula',1348,'jan.cebula@polsza.pl','+48987654329','61135998741',14,'doktorek','janeczek')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('doctor','Janusz','Pierwszy',1348,'krol.sosnowca@polsza.pl','+48987650329','55135998741',7,'krol','krol')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('doctor','Proktolog','Nekrolog',124,'nekrofil@hemoroid.xd','+9765498310','51641375791',14,'nekropolis','nekropolis')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('lab','Za','Salata',null,'salata@lodowka.kuchnia','+48264034987','95165487011',13,'kapucha','kapucha')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('lab','Przydupas','Grej',null,'50@twarzy.greja','+18234567890','00010487011',13,'grej','grej')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('lab','Andrzej','Dudel',null,'andrzejek@kancelariaprezydencka.pl','+48987654234','77051648701',10,'dupa','dupa')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('klab','Napoleon','Bo-naparte',null,'maly@powstaniec.fr','FFFFFFFFFFFF','-0000000404',16,'kieruj','kieruj')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('klab','Brajan','Nieopisany',null,'500+@beatka.pis','+48500500500','16091689646',7,'brajan','brajan')
insert into [BD_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password) values ('admin','W�a�ciciel','�wiata',null,'admin@jestembogiem.sql','+0000000000','00000000000',20,'admin','admin')
GO
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Charlie','Kane','+48111111111','00000000001',21)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Tony','Morgan','+48111111111','00000000002',22)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jacqueline','Fine','+48111111111','00000000003',2)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Mark','Harrigan','+48111111111','00000000004',19)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Akachi','Onyele','+48111111111','00000000005',23)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Silas','Marsh','+48111111111','00000000006',24)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Zoey','Samaras','+48111111111','00000000007',12)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Trish','Scarborough','+48111111111','00000000008',21)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Michael','McGlen','+48111111111','00000000009',26)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jenny','Barnes','+48111111111','00000000010',4)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Wendy','Adams','+48111111111','00000000011',17)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jim','Culver','+48111111111','00000000012',17)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Dexter','Drake','+48111111111','00000000013',27)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Marie','Lambeau','+48111111111','00000000014',27)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Lola','Hayes','+48111111111','00000000015',27)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Norman','Withers','+48111111111','00000000016',2)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Diana','Stanley','+48111111111','00000000017',2)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Lily','Chen','+48111111111','00000000018',27)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Leo','Anderson','+48111111111','00000000019',18)
insert into [BD_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('�lizg','O"Toole','+48111111111','00000000011',5)
GO
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2015-01-10 10:34:09.000' AS DateTime),CAST(N'2017-07-19 10:00:00.000' AS DateTime),9,4,2)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2012-12-31 06:30:00.000' AS DateTime),CAST(N'2017-07-19 11:00:09.000' AS DateTime),18,7,3)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2010-02-22 17:28:00.000' AS DateTime),CAST(N'2017-07-19 12:00:09.000' AS DateTime),5,5,1)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent jest u�omny. Bo tak.','Hora curka','ZAK',CAST(N'2010-01-10 10:34:09.000' AS DateTime),CAST(N'2017-07-19 12:00:09.000' AS DateTime),14,6,3)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Yyy... Nie mam pomys�u, co wpisa�... Studiowa�em prawo i medycyn�.','OK','ZAK',CAST(N'2010-05-15 20:34:09.000' AS DateTime),CAST(N'2017-07-19 13:00:09.000' AS DateTime),1,4,2)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Zabieg si� uda�, pacjent zmar�.','Wszystko OK','ZAK',CAST(N'2010-03-20 15:34:09.000' AS DateTime),CAST(N'2017-07-19 14:00:09.000' AS DateTime),16,6,3)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent nie przyszed�','Nieobecny','ANUL',CAST(N'2011-06-11 10:05:00.000' AS DateTime),CAST(N'2017-07-19 15:00:09.000' AS DateTime),11,7,1)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent by� agresywny.','Wyrzucony','ANUL',CAST(N'2013-05-13 10:09:00.000' AS DateTime),CAST(N'2017-07-19 16:00:09.000' AS DateTime),4,5,1)
insert into [BD_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent zosta� wywalony na zbity pysk.','Wyrzucony','ANUL',CAST(N'2017-04-19 19:59:00.000' AS DateTime),CAST(N'2017-07-19 23:00:09.000' AS DateTime),13,5,2)
GO
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A01','A','Badanie og�lne moczu (profil)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A03','A','Badanie p�ynu m�zgowo-rdzeniowego')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A05','A','Badanie p�ynu z jamy cia�a (op�ucnej, otrzewnej)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A07','A','Bia�ko w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A09','A','Bilirubina w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A11','A','Cia�a ketonowe w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A12','A','Ci�ar w�a�ciwy moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A13','A','Erytrocyty/ hemoglobina w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A14','A','Leukocyty w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A15','A','Glukoza w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A17','A','Krew utajona w kale')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A19','A','Osad moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A21','A','Paso�yty/ jaja paso�yt�w w kale')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A23','A','Resztki pokarmowe w kale')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A25','A','Urobilinogen w moczu')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C01','C','Erytroblasty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C02','C','Erytrocyty - liczba')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C03','C','Erytrocyty ?- oporno�� osmotyczna')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C05','C','Erytrocyty - pr�ba Hama')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C07','C','Erytrocyty - pr�ba sacharozowa')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C09','C','Erytrogram')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C10','C','Inne antygeny grupowe krwinek czerwonych')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C11','C','Fosfataza zasadowa granulocyt�w')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C13','C','Granulocyty ?- badanie aktywno�ci fagocytarnej')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C15','C','Granulocyty zasadoch�onne ?- test bezpo�redniej degranulacji')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C19','C','Hemoglobina, rozdzia�')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C21','C','Leukocyty ?- badanie aktywno�ci peroksydazy (POX)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C23','C','Leukocyty ?- badanie aktywno�ci esterazy nieswoistej')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C27','C','Leukocyty ?- badanie immunofenotypowe kom�rek blastycznych')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C29','C','Leukocyty ?- barwienie sudanem czarnym B')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C30','C','Leukocyty ?- liczba')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C31','C','Leukocyty ?- reakcja PAS')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C32','C','Leukocyty ?- obraz odsetkowy')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C33','C','Limfadenogram')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C35','C','Limfoblasty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C37','C','Limfocyty B')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C39','C','Limfocyty BCD5+')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C41','C','Limfocyty T')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C43','C','Limfocyty TCD4+')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C45','C','Limfocyty TCD8+')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C47','C','Metamielocyty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C49','C','Mieloblasty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C51','C','Mielogram')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C53','C','Morfologia krwi 8-parametrowa')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C55','C','Morfologia krwi, z pe�nym r�nicowaniem granulocyt�w')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C57','C','Obj�to�� krwi kr���cej')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C59','C','Odczyn opadania krwinek czerwonych')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C61','C','P�ytki krwi - badanie adhezji')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C63','C','P�ytki krwi - badanie agregacji')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C65','C','P�ytki krwi - czas prze�ycia')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C66','C','P�ytki krwi - ?liczba')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C67','C','Promielocyty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C69','C','Retykulocyty')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C71','C','Splenogram')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C73','C','Test hamowania migracji makrofag�w')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E05','E','Badanie w kierunku nieregularnych przeciwcia�')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E20','E','Pr�ba zgodno�ci serologicznej')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E21','E','Diagnostyka konfliktu matczyno-p�odowego')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E31','E','Kwalifikacja do podania immunoglobuliny anty-Rh(D)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E64','E','Diagnostyka niedokrwisto�ci autoimmunohemolitycznej')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E65','E','Oznaczenie grupy krwi uk�adu ABO i Rh')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W01','W','Aspergillus spp. Antygen rozpuszczalny - galaktomannan')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W03','W','Aspergillus spp. Przeciwcia�a IgA')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W05','W','Aspergillus spp. Przeciwcia�a IgG')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W07','W','Aspergillus spp. Przeciwcia�a IgM')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W09','W','Aspergillus fumigatus Przeciwcia�a')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W11','W','Aspergillus fumigatus Przeciwcia�a IgG/ IgM')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W13','W','A. niger, A. nidulans, A. flavus, A. terreus Przeciwcia�a')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W15','W','Blastomyces dermatididis DNA')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W17','W','Candida spp. Antygen rozpuszczalny ?- mannan')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W19','W','Candida albicans Przeciwcia�a IgG/ IgM (antymannanowe)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W21','W','Candida spp. Przeciwcia�a IgG')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W23','W','Candida albicans Przeciwcia�a IgA')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W25','W','Candida spp. Przeciwcia�a IgM')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W27','W','Candida albicans Przeciwcia�a')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W29','W','Coccidioides immitis DNA')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W31','W','Cryptococcus neoformans Antygen (glycuronoxylomannan)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W33','W','Histoplasma capsulatum DNA')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W35','W','Pneumocystis carinii (jirovecii) Antygen (oocysty)')
insert into [BD_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('Y90','Y','Badanie histopatologiczne')
GO



