CREATE VIEW dostepne_wycieczki
AS
    SELECT * FROM wycieczki_miejsca WHERE WOLNE_MIEJSCA > 0 and DATA > CURRENT_DATE;
