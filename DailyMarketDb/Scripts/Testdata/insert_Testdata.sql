-- Mitarbeiter
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Pascal', 'Schaffner', 220, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Vincent', 'Ptak', 280, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Luca', 'Weber', 190, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Andreas', 'Hofstetter', 140, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('jasmin', 'Küngel', 230, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Tamara', 'Schmid', 170, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Sandra', 'Keller', 155, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Laura', 'Galli', 110, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Marco', 'Meier', 90, 1, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, IsActive, CreatedAt, CreatedBy) VALUES ('Urs', 'Müller', 225, 1, GETDATE(), 'initial deploy');

-- Anbieter
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Max', 'Muster', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Dominik', 'Sky', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Claire', 'Wyss', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Alfredo', 'Steiner', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Antonio', 'Giovanni', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Mario', 'Lombard', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Luigi', 'Bernasconi', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, [Status], CreatedAt, CreatedBy) VALUES ('Camille', 'Ferrière', 0, GETDATE(), 'initial deploy');

-- Standort & Standplatz
INSERT INTO Standort (Bezeichnung, Strasse, Plz, Ort, CreatedAt, CreatedBy) 
VALUES ('Testort', 'Zürcherstrasse 34', '8000', 'Zürich', GETDATE(), 'initial deploy');
INSERT INTO Standplatz (StandortId, PreisProTag, CreatedAt, CreatedBy) VALUES (1, 99.95, GETDATE(), 'initial deploy');

-- Abotyp
INSERT INTO Abotyp (Bezeichnung, Beschreibung, Mietdauer, AnzahlBelegungNoetig, GueltigVon, GueltigBis, RabattInProzent, CreatedAt, CreatedBy) 
VALUES ('Silver Abonnement', 'Miete an einem Standort für 6 Monate', 182, 1, GETDATE(), NULL, 10, GETDATE(), 'initial deploy');
INSERT INTO Abotyp (Bezeichnung, Beschreibung, Mietdauer, AnzahlBelegungNoetig, GueltigVon, GueltigBis, RabattInProzent, CreatedAt, CreatedBy) 
VALUES ('Gold Abonnement', 'Miete an einem Standort für 12 Monate', 365, 1, GETDATE(), NULL, 15, GETDATE(), 'initial deploy');
INSERT INTO Abotyp (Bezeichnung, Beschreibung, Mietdauer, AnzahlBelegungNoetig, GueltigVon, GueltigBis, RabattInProzent, CreatedAt, CreatedBy) 
VALUES ('Platin Abonnement', 'Miete an 3 Standorten für 6 Monate', 182, 3, GETDATE(), NULL, 20, GETDATE(), 'initial deploy');

--Mitgliedsanforderung
INSERT INTO Mitgliedsanforderung (Bezeichnung, Beschreibung, Gueltigkeitsdauer, CreatedAt, CreatedBy) 
VALUES ('Erklärungsunterschrift', 'Unterschrift der DailyMarket Mitgliedserklärung', NULL, GETDATE(), 'initial deploy');
INSERT INTO Mitgliedsanforderung (Bezeichnung, Beschreibung, Gueltigkeitsdauer, CreatedAt, CreatedBy) 
VALUES ('Bonitätsprüfung', 'Durchführung einer einfachen Bonitätsprüfung', NULL, GETDATE(), 'initial deploy');
INSERT INTO Mitgliedsanforderung (Bezeichnung, Beschreibung, Gueltigkeitsdauer, CreatedAt, CreatedBy) 
VALUES ('Persönlicher Besuch', 'Einen persönlichen Besuch beim Anbieter', NULL, GETDATE(), 'initial deploy');
INSERT INTO Mitgliedsanforderung (Bezeichnung, Beschreibung, Gueltigkeitsdauer, CreatedAt, CreatedBy) 
VALUES ('1. Q-Check', 'Erstmaliger Check durch unseren internen Qualitätsbeauftragten', 365, GETDATE(), 'initial deploy');
INSERT INTO Mitgliedsanforderung (Bezeichnung, Beschreibung, Gueltigkeitsdauer, CreatedAt, CreatedBy) 
VALUES ('2. Q-Check', 'Zweiter Check durch einen externen unabhängigen Qualitätsbeauftragten', 365, GETDATE(), 'initial deploy');