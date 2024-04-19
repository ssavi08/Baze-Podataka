<Query Kind="SQL">
  <Connection>
    <ID>3faabc11-860d-4eac-b8ae-849c7c4f5ccf</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>31.147.207.14</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <SqlSecurity>true</SqlSecurity>
    <UserName>student</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAJCfjqIjUVkac4SqkLk880wAAAAACAAAAAAAQZgAAAAEAACAAAAACxdRCJ3gkAoDT/ggqap8YGPYuougpobc0YSsTbJUARwAAAAAOgAAAAAIAACAAAABvbTksOdOa/nvwyANrZxzwerfsPvupjhxe47sFg4I5vBAAAADCMqMo817S9RsA6mNzgwbGQAAAANTHr0yWYDwH3n6Ca4kC2ADcGd617nUiw7uw7tHrzZLv1AP7cxsLzSoa96NkjkWJ1c+YNlFacKnzNWM/5z2UDzA=</Password>
    <Database>stuslu</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

/*1.zad*/

SELECT CONCAT(SUBSTRING(ime, 1, 1), SUBSTRING(prezime, 1, 1)) AS inicijali, YEAR(datRod) AS godina_rodenja
FROM student;

SELECT * FROM student ORDER BY datRod ASC;

SELECT TOP 1 ime, prezime, datRod FROM student WHERE spol = 'F' ORDER BY datRod ASC;

/*2. zad*/

SELECT COUNT(*) AS ukupan_broj_studenata FROM student;
SELECT COUNT(DISTINCT pbrPreb) AS broj_razlicitih_mjesta FROM student;

/*3.zad*/

SELECT ROUND(AVG(cast(ocjena AS float)),2) AS prosjecna_ocjena FROM ispit WHERE ocjena > 1;

/*4. zad*/

SELECT ime, prezime, AVG(cast(ocjena AS float)) AS prosjecna_ocjena1
FROM student JOIN ispit  ON mbr = mbrStud
WHERE ocjena > 1
GROUP BY mbr , ime, prezime
ORDER BY prosjecna_ocjena1 DESC;

SELECT 
ispit.mbrStud AS MaticniBroj,
AVG(ispit.ocjena) AS ProsjecnaOcjena
FROM ispit
WHERE ocjena > 1
GROUP BY ispit.mbrStud
HAVING AVG(ispit.ocjena) > 2.5
ORDER BY ProsjecnaOcjena DESC;

/*5.zad*/

CREATE VIEW saviPogled AS
SELECT ime AS ImeStudenta, prezime AS PrezimeStudenta, naziv AS NazivPredmeta, ocjena, datIspita
FROM ispit JOIN student s ON mbr = mbrStud JOIN predmet p ON sifra = sifPredmeta;


SELECT * from ispit
SELECT * from saviPogled

DROP VIEW saviPogled