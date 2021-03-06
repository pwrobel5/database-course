CREATE VIEW wycieczki_przyszle
AS
    SELECT
        w.ID_WYCIECZKI,
        w.NAZWA,
        w.KRAJ,
        w.DATA,
        o.IMIE,
        o.NAZWISKO,
        r.STATUS
    FROM WYCIECZKI w
        JOIN REZERWACJE r ON w.ID_WYCIECZKI = r.ID_WYCIECZKI
        JOIN OSOBY o on r.ID_OSOBY = o.ID_OSOBY
        WHERE w.DATA > CURRENT_DATE;
