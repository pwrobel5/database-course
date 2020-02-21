CREATE VIEW wycieczki_miejsca_2
AS
    SELECT
        w.ID_WYCIECZKI,
        w.NAZWA,
        w.KRAJ,
        w.DATA,
        w.LICZBA_MIEJSC,
        w.LICZBA_WOLNYCH_MIEJSC
    FROM WYCIECZKI w;
