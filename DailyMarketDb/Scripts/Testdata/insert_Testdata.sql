INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Max', 'Muster', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Dominik', 'Sky', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Avo', 'Cado', 0, GETDATE(), 'initial deploy');
INSERT INTO Anbieter (vorname, nachname, IsMitglied, CreatedAt, CreatedBy) VALUES ('Alfredo', 'Mozarella', 0, GETDATE(), 'initial deploy');

INSERT INTO Standort (Bezeichnung, Strasse, Plz, Ort, CreatedAt, CreatedBy) VALUES ('Testort', 'Zürcherstrasse 34', '8000', 'Zürich', GETDATE(), 'initial deploy');

INSERT INTO Standplatz (StandortId, PreisProTag, CreatedAt, CreatedBy) VALUES (1, 99.95, GETDATE(), 'initial deploy');