
CREATE PROCEDURE [dbo].[spCreatePendenz] 
    @AnbieterId int
AS
BEGIN
    -- procedure --
	BEGIN TRAN
    DECLARE @AmountPendenzenToAdd INT;
	DECLARE @anforderung VARCHAR(50);
	DECLARE @cnt INT = 1;

	DECLARE @PendenzToAdd TABLE(
		rownumber int,
		Id int,
		Bezeichnung VARCHAR(50),
		Beschreibung VARCHAR(MAX)
	);

	INSERT INTO @PendenzToAdd 
		SELECT ROW_NUMBER() OVER (ORDER BY Mitgliedsanforderung.Id) AS rownumber, Mitgliedsanforderung.Id, Bezeichnung, Mitgliedsanforderung.Beschreibung 
		FROM Mitgliedsanforderung 
		WHERE Mitgliedsanforderung.Id NOT IN (SELECT Pendenz.MitgliedsanforderungId FROM Pendenz WHERE AnbieterId = @AnbieterId)

	SET @AmountPendenzenToAdd = (SELECT count(*) FROM Mitgliedsanforderung);

	WHILE @cnt <= @AmountPendenzenToAdd
	BEGIN
	   INSERT INTO Pendenz (AnbieterId, MitgliedsanforderungId, Titel, Beschreibung, IsOffen, CreatedAt, CreatedBy) 
			SELECT @AnbieterId, Id, 'Mitgliedsprüfung: "'+Bezeichnung+'"', Beschreibung, 1, GETDATE(), 'Initial Pendenz' FROM @PendenzToAdd where rownumber = @cnt

	   SET @anforderung = (SELECT Bezeichnung FROM @PendenzToAdd where rownumber = @cnt);
	   PRINT 'Pendenz für Anforderung '+@anforderung+' erstellt.'
	   SET @cnt = @cnt + 1;
	END;

	IF @@ERROR <> 0
		BEGIN
			-- Rollback the transaction
			ROLLBACK;

			-- Raise an error and return
			RAISERROR ('Fehler beim Erstellen von Pendenzen. Rollback auf der Tabelle Pendenz durchgeführt!',1,1);
			RETURN
		END

	COMMIT;
	PRINT CAST(@AmountPendenzenToAdd AS VARCHAR)+' Pendenzen wurden erfolgreich erstellt.';

END