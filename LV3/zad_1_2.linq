<Query Kind="SQL">
  <Connection>
    <ID>a651ad1e-8c8d-4247-8914-2938edbbd4f1</ID>
    <Persist>true</Persist>
    <Server>31.147.207.14</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>student</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAtIIlmhoixkOBMHjO4DZ4AgAAAAACAAAAAAAQZgAAAAEAACAAAACBf1Tv8cnX7gmkJ+RTDScFC6iagcsNYT2vz/kPyqSeJgAAAAAOgAAAAAIAACAAAABHh3NDCE6JGbWZUCpYAT6ZUmi9C8Nv2PNAuGEqEEOqrhAAAABwGEOs84Cc9Bw+4djCNM8eQAAAAKp+jtSt76uswkrSkHsrvPaemgshCUujzkkrR5Iquv5+4EQAfwXBXj7hoqZK+NERTtaQ4xOvyyh47QsmfRsEuts=</Password>
    <Database>student</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//zad 1
CREATE TABLE OsobaSavi (
indeks INT PRIMARY KEY,
ime VARCHAR(15) NOT NULL,
prezime VARCHAR(15) NOT NULL,
jmbg VARCHAR(13) UNIQUE NOT NULL,
datum_rodenja DATE NOT NULL,
visina DECIMAL(3,2),
spol CHAR(1) NOT NULL,
broj_cipela INT,
);

INSERT INTO OsobaSavi ( indeks, ime, prezime, jmbg, datum_rodenja, spol, visina, broj_cipela) VALUES
('1', 'Petar', 'Peric', '1112223334445', '1970-02-03', 'M', 1.75, 40),
('2', 'Mirko', 'Miric', '0002221112220', '2013-12-05', 'M', 1.80, 45),
('3', 'Andrej', 'Andresic', '4440004440', '2000-12-12', 'M', 1.90, 47),
('4', 'Dijana', 'Danilovic', '2303209430', '1998-04-06', 'Z', 1.69, 38),
('5', 'Sara', 'Sincic', '2220903035', '1999-1-16', 'Z', 1.70, 38);

//zad 2
SELECT * FROM OsobaSavi;

UPDATE OsobaSavi SET ime = 'Miroslav', prezime = 'Juric' WHERE indeks = 2;
UPDATE OsobaSavi SET broj_cipela = broj_cipela +1;

DELETE FROM OsobaSavi WHERE indeks = 3;

SELECT * FROM OsobaSavi;