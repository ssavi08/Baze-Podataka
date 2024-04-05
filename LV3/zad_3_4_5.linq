<Query Kind="SQL">
  <Connection>
    <ID>a651ad1e-8c8d-4247-8914-2938edbbd4f1</ID>
    <Persist>true</Persist>
    <Server>31.147.207.14</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>student</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAtIIlmhoixkOBMHjO4DZ4AgAAAAACAAAAAAAQZgAAAAEAACAAAACBf1Tv8cnX7gmkJ+RTDScFC6iagcsNYT2vz/kPyqSeJgAAAAAOgAAAAAIAACAAAABHh3NDCE6JGbWZUCpYAT6ZUmi9C8Nv2PNAuGEqEEOqrhAAAABwGEOs84Cc9Bw+4djCNM8eQAAAAKp+jtSt76uswkrSkHsrvPaemgshCUujzkkrR5Iquv5+4EQAfwXBXj7hoqZK+NERTtaQ4xOvyyh47QsmfRsEuts=</Password>
    <Database>stuslu</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//zad 3
SELECT * FROM student ORDER BY  datUpis ASC;

SELECT 
ime AS Ime,
prezime AS Prezime,
datRod AS 'Datum rođenja',
datUpis AS 'Datum upisa'
FROM student WHERE datRod < '1994-01-01' ;

//zad 4
SELECT s.ime, s.prezime, p.naziv FROM student s
JOIN ispit i ON s.mbr = i.mbrStud
JOIN predmet p ON i.sifPredmeta = p.sifra
WHERE i.ocjena >=4;

//zad 5
SELECT * FROM mjesto ORDER BY pbr ASC;
