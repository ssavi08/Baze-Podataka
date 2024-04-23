<Query Kind="SQL">
  <Connection>
    <ID>47c015ec-55d4-4ae2-9a40-e016c934203c</ID>
    <Persist>true</Persist>
    <Server>31.147.207.14</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>student</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAADTySCznKCU2Frdmg+ZtLMgAAAAACAAAAAAAQZgAAAAEAACAAAABHGi4TpiH3JRVfgEqIqajAOileCsxpiE3UuIZMfbfLOAAAAAAOgAAAAAIAACAAAACKeetlCF1ANMnLuiK/xc7vQkpVN2NbPQ8K0+BAiyOepRAAAAB4lsROhBmRBD6+YXOK9fpUQAAAAFdE3Ub23SyYfQRTCTj5+oGhMvqZ2owC5PWdMk0sJE99CYibsQyBha5xpUBP8uHbrBVCm84xN2svdoEdQ4WqzKk=</Password>
    <Database>student</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

/*Zad 1. i pod zadatci*/
CREATE TABLE Imena (
    ime VARCHAR(20),
    naopako_ime VARCHAR(20)
);

CREATE FUNCTION OkreniIme(@ulaz VARCHAR(20))
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @izlaz VARCHAR(20);
    SET @izlaz = REVERSE(@ulaz);
    RETURN @izlaz;
END;

CREATE PROCEDURE IspisiOkrenutoIme(@ulaz VARCHAR(20))
AS
BEGIN
    DECLARE @okrenuto_ime VARCHAR(20);
    SET @okrenuto_ime = dbo.OkreniIme(@ulaz);
    PRINT 'Okrenuto ime: ' + @okrenuto_ime;
END;

CREATE TRIGGER PopuniNaopakoIme
ON Imena
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO Imena (ime, naopako_ime)
    SELECT ime, dbo.OkreniIme(ime) FROM inserted;
END;


/*funkcija*/
DECLARE @test_ulaz VARCHAR(20) = 'ivan';
DECLARE @okrenuto VARCHAR(20);
SET @okrenuto = dbo.OkreniIme(@test_ulaz);
PRINT 'Okrenuto ime: ' + @okrenuto;

/*procedura*/
EXEC IspisiOkrenutoIme @ulaz = 'Sandro';
/*okidač*/
INSERT INTO Imena (ime) VALUES ('Benjo');

SELECT * FROM Imena;