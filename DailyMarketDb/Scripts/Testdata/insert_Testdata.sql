-- Mitarbeiter
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Pascal', 'Schaffner', 220, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Vincent', 'Ptak', 280, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Luca', 'Weber', 190, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Andreas', 'Hofstetter', 140, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('jasmin', 'Küngel', 230, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Tamara', 'Schmid', 170, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Sandra', 'Keller', 155, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Laura', 'Galli', 110, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Marco', 'Meier', 90, GETDATE(), 'initial deploy');
INSERT INTO Mitarbeiter (Vorname, Nachname, Stundensatz, CreatedAt, CreatedBy) VALUES ('Urs', 'Müller', 225, GETDATE(), 'initial deploy');

-- Anbieter
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Max', 'Muster', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Dominik', 'Sky', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Claire', 'Wyss', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Alfredo', 'Steiner', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Antonio', 'Giovanni', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Mario', 'Lombard', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Luigi', 'Bernasconi', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Camille', 'Ferrière', 0, GETDATE(), 'initial deploy');

-- Standort & Standplatz
INSERT INTO Standort (Bezeichnung, Strasse, Plz, Ort, CreatedAt, CreatedBy) VALUES ('Testort', 'Zürcherstrasse 34', '8000', 'Zürich', GETDATE(), 'initial deploy');
INSERT INTO Standplatz (StandortId, PreisProTag, CreatedAt, CreatedBy) VALUES (1, 99.95, GETDATE(), 'initial deploy');