<Query Kind="SQL">
  <Connection>
    <ID>97e700ab-29e8-4705-8cd7-01eb398f2c7b</ID>
    <Persist>true</Persist>
    <Server>31.147.207.14</Server>
    <SqlSecurity>true</SqlSecurity>
    <NoPluralization>true</NoPluralization>
    <UserName>student</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAfIWgwUeiiEamPHhXpUE1QgAAAAACAAAAAAAQZgAAAAEAACAAAACiLrExlg/ZZilR5+CqHbhx9sW5yIFFzOfdD6dl+L7AUAAAAAAOgAAAAAIAACAAAACNz0tX0lSbSwv1tXuQyF2pSuiwzBlLx7SwevHoOZ7QRRAAAAAhOBAzV9Q035tLvG0BkvTHQAAAAGdWGlPuSg+kzNy1qykKXT4EpWcX8bvaaUr2TLfVZP6FhFMjnmX8Iotarel/AhyoVXFjcnUi7O6NRjOgbza2Jb0=</Password>
    <Database>student</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

/*Zad 2.*/
CREATE PROCEDURE Horoskop78 (@datum DATE)
AS
BEGIN
DECLARE @znak VARCHAR(29);
    DECLARE @mjesecc INT;
	DECLARE @dann INT;
	
	SET @mjesecc = MONTH (@datum);
	SET @dann = DAY (@datum);
	
    SET @znak =  
        CASE 
            WHEN @dann  > 21 AND @mjesecc = 12 OR @dann < 21 AND @mjesecc = 1 THEN 'Jarac'
            WHEN @dann > 20 AND @mjesecc = 1 OR @dann <21 AND @mjesecc = 2 THEN 'Vodenjak'
			WHEN @dann > 20 AND @mjesecc = 2 OR @dann <21 AND @mjesecc = 3 THEN 'Ribe'
			WHEN @dann > 20 AND @mjesecc = 3 OR @dann <21 AND @mjesecc = 4 THEN 'Ovan'
			WHEN @dann > 20 AND @mjesecc = 4 OR @dann <22 AND @mjesecc = 5 THEN 'Bik'
			WHEN @dann > 20 AND @mjesecc = 5 OR @dann <23 AND @mjesecc = 6 THEN 'Blizanci'
			WHEN @dann > 21 AND @mjesecc = 6 OR @dann <23 AND @mjesecc = 7 THEN 'Rak'
			WHEN @dann > 22 AND @mjesecc = 7 OR @dann <23 AND @mjesecc = 8 THEN 'Lav'
			WHEN @dann > 22 AND @mjesecc = 8 OR @dann <23 AND @mjesecc = 9 THEN 'Djevica'
			WHEN @dann > 22 AND @mjesecc = 9 OR @dann <23 AND @mjesecc = 10 THEN 'Vaga'
			WHEN @dann > 22 AND @mjesecc = 10 OR @dann <23 AND @mjesecc = 11 THEN 'Škorpion'	
        
            ELSE 'Strijelac'
        END;

    PRINT 'Horoskopski znak za datum ' + CONVERT(VARCHAR, @datum, 104) + ' je ' + @znak;
END;

drop procedure Horoskop78
EXEC Horoskop78 '1985-08-16';