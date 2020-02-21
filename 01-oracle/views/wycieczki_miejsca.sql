CREATE VIEW wycieczki_miejsca
AS
    SELECT
        w.ID_WYCIECZKI,
        w.NAZWA,
        w.KRAJ,
        w.DATA,
        w.LICZBA_MIEJSC,
        w.LICZBA_MIEJSC - COUNT(DISTINCT r.ID_OSOBY) AS WOLNE_MIEJSCA
    FROM WYCIECZKI w
    LEFT JOIN REZERWACJE r ON w.ID_WYCIECZKI = r.ID_WYCIECZKI
    WHERE r.STATUS <> 'A'
    GROUP BY w.ID_WYCIECZKI, w.NAZWA, w.KRAJ, w.DATA, w.LICZBA_MIEJSC;
