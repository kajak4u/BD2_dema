insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Caracas', 'Lololo', 15, 1)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Miscatonic', 50, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Krakowska', 6, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Brukselka', 'Wybuchowa', 3, 2)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Bytom', 'Chorzowska', 5, 78)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Bytom', 'Katowicka', 35, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Chorzów', 'Opolska', 19, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Katowice', 'Marszałkowska', 75, 15)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Zadupie', 'Wiejska', 0, -1)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Bagno', 3, 2)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Asylum', 35, 14)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Arkham', 'Independence Square', 7, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('San Francisco', 'Times Square', 147, 789)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 4, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 6, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Warszawa', 'Wiejska', 8, null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Gdynia', 'Wojskowa', 123, 456)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Gdańsk', 'Stoczniowa', 5090, 4887)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Hel', 'Argon', 4, 2)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Toaleta', 'Publiczna', -3, -15)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('San Francisco', 'Times Square', 100, 7)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Kolumbia', 'Bogota',0,null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Kapsztad', 'RPA',-404,null)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Sydney', 'Kangurków',705,1)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Rosja', 'Cmentarna',12,34)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Lądek Zdrój', 'Brytyjska',1,999)
insert into [BD2_2].[dbo].[Address] (City, Street, House_number, Flat_number) values ('Tokio', 'Chińskich Bajek',1,2)
GO
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('registrar','Grażyna','Polak',null,'grazyna@plaza.pl','+48801802803','39081198741',11,'grazyna','grazyna', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('registrar','Dżessika','Stonoga',null,'jess.super.och@loffe.com','+48123456789','90081198741',7,'horom','curke', CAST(N'2017-09-15 00:00:01.000' AS DateTime))
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('registrar','Test','Imienia',null,'jestemtestem@jestętesterę.de','+49876589358','01234567890',20,'rej','rej', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('doctor','Janusz','Zsunaj',97,'janusz.tzsunami@thaivan.jp','+48798456123','98752198741',9,'janusz','janusz', CAST(N'2017-10-01 00:00:01.000' AS DateTime))
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('doctor','Jajami','Omate',3594,'zapasnik@japonja.pl','+11365723495','64897244932',13,'jaja','mata', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('doctor','Janusz','Cebula',1348,'jan.cebula@polsza.pl','+48987654329','61135998741',14,'doktorek','janeczek', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('doctor','Janusz','Pierwszy',1348,'krol.sosnowca@polsza.pl','+48987650329','55135998741',7,'krol','krol', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('doctor','Proktolog','Nekrolog',124,'nekrofil@hemoroid.xd','+9765498310','51641375791',14,'nekropolis','nekropolis', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('lab','Za','Salata',null,'salata@lodowka.kuchnia','+48264034987','95165487011',13,'kapucha','kapucha', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('lab','Przydupas','Grej',null,'50@twarzy.greja','+18234567890','00010487011',13,'grej','grej', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('lab','Andrzej','Dudel',null,'andrzejek@kancelariaprezydencka.pl','+48987654234','77051648701',10,'dupa','dupa',CAST(N'2015-08-06 23:00:00.000' AS DateTime))
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('klab','Napoleon','Bo-naparte',null,'maly@powstaniec.fr','FFFFFFFFFFFF','-0000000404',16,'kieruj','kieruj', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('klab','Brajan','Nieopisany',null,'500+@beatka.pis','+48500500500','16091689646',7,'brajan','brajan', null)
insert into [BD2_2].[dbo].[Worker] (Role, First_name, Last_name, NPWZ, [E-mail_Address], Phone_number, PESEL, address_id, Login, Password, Expiration_date) values ('admin','Właściciel','Świata',null,'admin@jestembogiem.sql','+0000000000','00000000000',20,'admin','admin', null)
GO
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Charlie','Kane','+48111111111','00000000001',21)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Tony','Morgan','+48111111111','00000000002',22)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jacqueline','Fine','+48111111111','00000000003',2)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Mark','Harrigan','+48111111111','00000000004',19)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Akachi','Onyele','+48111111111','00000000005',23)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Silas','Marsh','+48111111111','00000000006',24)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Zoey','Samaras','+48111111111','00000000007',12)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Trish','Scarborough','+48111111111','00000000008',21)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Michael','McGlen','+48111111111','00000000009',26)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jenny','Barnes','+48111111111','00000000010',4)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Wendy','Adams','+48111111111','00000000011',17)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jim','Culver','+48111111111','00000000012',17)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Dexter','Drake','+48111111111','00000000013',27)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Marie','Lambeau','+48111111111','00000000014',27)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Lola','Hayes','+48111111111','00000000015',27)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Norman','Withers','+48111111111','00000000016',2)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Diana','Stanley','+48111111111','00000000017',2)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Lily','Chen','+48111111111','00000000018',27)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Leo','Anderson','+48111111111','00000000019',18)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Ślizg','O"Toole','+48111111111','00000000011',5)

insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jan','Kowalski','+48111111111','00000000001',21)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Jan','Kowalski','+48111111111','00000000099',22)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Andrzej','Nowak','+48111111111','00000000100',5)
insert into [BD2_2].[dbo].[Patient] (First_name, Last_name, Phone_number, PESEL, address_id) values ('Adam','Nowak','+48111111111','00000000101',1)
GO
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2015-01-10 10:34:09.000' AS DateTime),CAST(N'2017-07-19 10:00:00.000' AS DateTime),9,4,2)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2012-12-31 06:30:00.000' AS DateTime),CAST(N'2017-07-19 11:00:09.000' AS DateTime),18,7,3)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values (null,null,'REJ',CAST(N'2010-02-22 17:28:00.000' AS DateTime),CAST(N'2017-07-19 12:00:09.000' AS DateTime),5,5,1)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent jest ułomny. Bo tak.','Hora curka','ZAK',CAST(N'2010-01-10 10:34:09.000' AS DateTime),CAST(N'2017-07-19 12:00:09.000' AS DateTime),14,6,3)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Yyy... Nie mam pomysłu, co wpisać... Studiowałem prawo i medycynę.','OK','ZAK',CAST(N'2010-05-15 20:34:09.000' AS DateTime),CAST(N'2017-07-19 13:00:09.000' AS DateTime),1,4,2)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Zabieg się udał, pacjent zmarł.','Wszystko OK','ZAK',CAST(N'2010-03-20 15:34:09.000' AS DateTime),CAST(N'2017-07-19 14:00:09.000' AS DateTime),16,6,3)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Skierowanie na badanie nerki przed sprzedażą. Najlepiej określić grupę krwi i czy nie jest chory, bo może być przypau.','Nadpobudliwość','ZAK',CAST(N'2000-05-20 09:00:00.000' AS DateTime),CAST(N'2017-08-10 19:00:09.000' AS DateTime),19,7,3)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent nie przyszedł','Nieobecny','ANUL',CAST(N'2011-06-11 10:05:00.000' AS DateTime),CAST(N'2017-07-19 15:00:09.000' AS DateTime),11,7,1)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent być agresywny.','Wyrzucony','ANUL',CAST(N'2013-05-13 10:09:00.000' AS DateTime),CAST(N'2017-07-19 16:00:09.000' AS DateTime),4,5,1)
insert into [BD2_2].[dbo].[Visit] (description, diagnosis, status, registration_date, ending_date, patient_id, doctor_id, registerer_id) values ('Pacjent został wywalony na zbity pysk.','Wyrzucony','ANUL',CAST(N'2017-04-19 19:59:00.000' AS DateTime),CAST(N'2017-07-19 23:00:09.000' AS DateTime),13,5,2)
GO
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A01','L','Badanie ogólne moczu (profil)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A03','L','Badanie płynu mózgowo-rdzeniowego')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A05','L','Badanie płynu z jamy ciała (opłucnej, otrzewnej)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A07','L','Białko w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A09','L','Bilirubina w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A11','L','Ciała ketonowe w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A12','L','Ciężar właściwy moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A13','L','Erytrocyty/ hemoglobina w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A14','L','Leukocyty w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A15','L','Glukoza w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A17','L','Krew utajona w kale')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A19','L','Osad moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A21','L','Pasożyty/ jaja pasożytów w kale')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A23','L','Resztki pokarmowe w kale')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('A25','L','Urobilinogen w moczu')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C01','L','Erytroblasty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C02','L','Erytrocyty - liczba')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C03','L','Erytrocyty ?- oporność osmotyczna')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C05','L','Erytrocyty - próba Hama')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C07','L','Erytrocyty - próba sacharozowa')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C09','L','Erytrogram')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C10','L','Inne antygeny grupowe krwinek czerwonych')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C11','L','Fosfataza zasadowa granulocytów')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C13','L','Granulocyty ?- badanie aktywności fagocytarnej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C15','L','Granulocyty zasadochłonne ?- test bezpośredniej degranulacji')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C19','L','Hemoglobina, rozdział')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C21','L','Leukocyty ?- badanie aktywności peroksydazy (POX)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C23','L','Leukocyty ?- badanie aktywności esterazy nieswoistej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C27','L','Leukocyty ?- badanie immunofenotypowe komórek blastycznych')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C29','L','Leukocyty ?- barwienie sudanem czarnym B')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C30','L','Leukocyty ?- liczba')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C31','L','Leukocyty ?- reakcja PAS')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C32','L','Leukocyty ?- obraz odsetkowy')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C33','L','Limfadenogram')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C35','L','Limfoblasty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C37','L','Limfocyty B')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C39','L','Limfocyty BCD5+')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C41','L','Limfocyty T')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C43','L','Limfocyty TCD4+')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C45','L','Limfocyty TCD8+')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C47','L','Metamielocyty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C49','L','Mieloblasty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C51','L','Mielogram')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C53','L','Morfologia krwi 8-parametrowa')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C55','L','Morfologia krwi, z pełnym różnicowaniem granulocytów')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C57','L','Objętość krwi krążącej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C59','L','Odczyn opadania krwinek czerwonych')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C61','L','Płytki krwi - badanie adhezji')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C63','L','Płytki krwi - badanie agregacji')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C65','L','Płytki krwi - czas przeżycia')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C66','L','Płytki krwi - ?liczba')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C67','L','Promielocyty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C69','L','Retykulocyty')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C71','L','Splenogram')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('C73','L','Test hamowania migracji makrofagów')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E05','L','Badanie w kierunku nieregularnych przeciwciał')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E20','L','Próba zgodności serologicznej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E21','L','Diagnostyka konfliktu matczyno-płodowego')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E31','L','Kwalifikacja do podania immunoglobuliny anty-Rh(D)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E64','L','Diagnostyka niedokrwistości autoimmunohemolitycznej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('E65','L','Oznaczenie grupy krwi układu ABO i Rh')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W01','L','Aspergillus spp. Antygen rozpuszczalny - galaktomannan')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W03','L','Aspergillus spp. Przeciwciała IgA')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W05','L','Aspergillus spp. Przeciwciała IgG')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W07','L','Aspergillus spp. Przeciwciała IgM')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W09','L','Aspergillus fumigatus Przeciwciała')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W11','L','Aspergillus fumigatus Przeciwciała IgG/ IgM')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W13','L','A. niger, A. nidulans, A. flavus, A. terreus Przeciwciała')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W15','L','Blastomyces dermatididis DNA')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W17','L','Candida spp. Antygen rozpuszczalny ?- mannan')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W19','L','Candida albicans Przeciwciała IgG/ IgM (antymannanowe)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W21','L','Candida spp. Przeciwciała IgG')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W23','L','Candida albicans Przeciwciała IgA')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W25','L','Candida spp. Przeciwciała IgM')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W27','L','Candida albicans Przeciwciała')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W29','L','Coccidioides immitis DNA')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W31','L','Cryptococcus neoformans Antygen (glycuronoxylomannan)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W33','L','Histoplasma capsulatum DNA')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('W35','L','Pneumocystis carinii (jirovecii) Antygen (oocysty)')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('Y90','L','Badanie histopatologiczne')
GO
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('79','F','Nastawienie złamania i zwichnięcia')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.0','F','Badania rtg tkanek miękkich twarzy, głowy i szyi')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.1','F','Inne badania rtg twarzy, głowy i szyi')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.2','F','Badanie rtg kręgosłupa')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.3','F','Badanie rtg tkanek miękkich klatki piersiowej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.4','F','Inne badania rtg klatki piersiowej')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.5','F','Badanie rtg dróg żółciowych')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.6','F','Inne badanie rtg układu pokarmowego')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('87.7','F','Badanie rtg układu moczowego')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('89.00','F','Porada lekarska, konsultacja, asysta')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('89.01','F','Profilaktyka i promocja zdrowia')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('89.02','F','Porada lekarska, inne')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('89.03','F','Porada, personel pomocniczy')
insert into [BD2_2].[dbo].[Examination_dictionary] (Examination_code, Examiantion_type, Examination_name) values ('89.04','F','Opieka pielęgniarki lub położnej')
GO
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('E65','Określić grupę krwi, żeby nie było przypału przy sprzedaży nerki.',null,CAST(N'2017-08-21 10:00:00.000' AS DateTime),null,null,null,null,null,'ZLE',7)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('A01','Sprawdzić, czy nerka jeszcze sprawna. Bo jak tak sprzedać zużytą...to chyba na targowisku.',10,CAST(N'2017-08-11 10:00:00.000' AS DateTime),'Mocz w porządku - nerka nadaje się.',CAST(N'2017-08-11 10:15:00.000' AS DateTime),12,'Potwierdzam - nadaje się.',CAST(N'2017-08-12 09:00:00.000' AS DateTime),'AKC',7)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('A13','Czy nerka nie przepuszcza?',11,CAST(N'2017-08-11 12:00:00.000' AS DateTime),'Nerka upadła...',CAST(N'2017-08-11 12:01:00.000' AS DateTime),12,'Laborant - debil, nerki nie zauważył. Do powtórki.',CAST(N'2017-08-11 21:00:00.000' AS DateTime),'AN_K',7)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('A13','Na drugą zmianę, bo ten poprzedni to debil.',9,CAST(N'2017-08-13 10:00:00.000' AS DateTime),'Krew...dużo krwi...',CAST(N'2017-08-13 13:00:00.000' AS DateTime),13,'O jprd, ten to WYPIŁ!!!',CAST(N'2017-08-14 00:00:01.000' AS DateTime),'AN_L',7)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('W27','Nie wiem, co to, ale może się przydać.',10,CAST(N'2017-08-12 15:06:00.000' AS DateTime),'Coś wyszło...tak sądzę.',CAST(N'2017-08-12 15:15:15.000' AS DateTime),null,null,null,'WYK',7)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('E65','Określić grupę krwi, bo crossfit.',null,CAST(N'2017-07-21 10:00:00.000' AS DateTime),null,null,null,null,null,'ZLE',5)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('A01','Sprawdzić, czy pacjent jeszcze sika.',11,CAST(N'2017-07-22 10:00:00.000' AS DateTime),'Mocz śmierdzi.',CAST(N'2017-07-23 10:15:00.000' AS DateTime),13,'Z kim ja pracuję...GDZIE WYNIKI?!',CAST(N'2017-07-23 11:00:00.000' AS DateTime),'AN_K',5)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('C39','Coś tam.',10,CAST(N'2017-07-21 00:00:01.000' AS DateTime),'Wyniki na 5+',CAST(N'2017-07-21 12:00:00.000' AS DateTime),12,'Bardzo pozytywne. Wszytkie.',CAST(N'2017-08-11 21:00:00.000' AS DateTime),'AKC',6)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('Y90','Jestem lekarzem',9,CAST(N'2017-07-30 10:00:00.000' AS DateTime),'Jestem laborantem',CAST(N'2017-08-10 01:00:00.000' AS DateTime),13,'Nie piję z nimi więcej.',CAST(N'2017-08-14 00:00:01.000' AS DateTime),'AN_L',6)
insert into [BD2_2].[dbo].[LAB_examination] (LAB_examination_code, doctor_notes, LAB_worker_id, commission_examination_date, LAB_examination_result, LAB_examination_date, LAB_manager_id, LAB_manager_notes, ending_examination_date, status, visit_id) 
values ('W29','Brzmi w porządku.',11,CAST(N'2017-07-31 15:07:00.000' AS DateTime),'Fszystko jes POZYTYWNE.',CAST(N'2017-08-12 15:15:15.000' AS DateTime),null,null,null,'WYK',5)
GO
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('89.00','Należy się 250 zł.',5)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('89.00','Należy się 50 zł.',6)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('89.00','Należy się 150 zł.',7)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('79','Nastawiono, ale z małymi komplikacjami...',6)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('87.5','Coś już widać.',5)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('89.01','Doradzono, gdzie najlepiej sprzedać nerkę wraz z jądrami.',7)
insert into [BD2_2].[dbo].[Physical_examination] (Physical_examination_code, Result, visit_id) values ('89.01','Przekazano bardzo cenne uwagi.',5)
GO