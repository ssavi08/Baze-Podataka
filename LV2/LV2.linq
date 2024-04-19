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

/*zad 1*/
CREATE TABLE grupaSavi(
id_grupe INT PRIMARY KEY,
oznaka_grupe VARCHAR(10) UNIQUE,
smjer VARCHAR(20),
broj_studenata INT
)

/*zad 2*/
CREATE TABLE studentSavi(
br_indeksa INT PRIMARY KEY,
ime VARCHAR(20),
prezime VARCHAR(20),
grupa VARCHAR(10),
godina_upisa SMALLDATETIME,
godina_studija TINYINT
CONSTRAINT grupa_fk FOREIGN KEY(grupa)  REFERENCES grupaSavi(oznaka_grupe)
)

DROP TABLE studentSavi;

/*zad 3*/
ALTER TABLE studentSavi ADD prosjek DECIMAL(4,2) CHECK(prosjek > 1 and prosjek <= 5);
ALTER TABLE studentSavi DROP COLUMN godina_studija;

/*zad 4*/
CREATE TABLE tel_imenikSavi(
broj_telefona INT,
ime VARCHAR(20),
prezime VARCHAR(20),
email VARCHAR(20),
datum_unosa DATETIME,
CONSTRAINT pk PRIMARY KEY (broj_telefona, datum_unosa)
)

/*zad 5*/
CREATE INDEX prosjek_index On studentSavi(prosjek);
CREATE UNIQUE INDEX broj_telefona_i_datum_unosa On tel_imenikSavi(broj_telefona, datum_unosa);