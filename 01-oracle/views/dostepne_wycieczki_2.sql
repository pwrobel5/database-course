CREATE VIEW dostepne_wycieczki_2
AS
    SELECT * FROM wycieczki_miejsca_2 
    WHERE LICZBA_WOLNYCH_MIEJSC > 0 
    AND DATA > CURRENT_DATE;
