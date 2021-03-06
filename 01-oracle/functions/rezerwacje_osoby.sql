CREATE OR REPLACE FUNCTION REZERWACJE_OSOBY(id_osoby IN OSOBY.ID_OSOBY%TYPE)
RETURN uczestnicy_wycieczki_table
AS
    rezerwacje_t uczestnicy_wycieczki_table;
    id_istnieje int;
BEGIN
    SELECT COUNT(*) INTO id_istnieje 
    FROM OSOBY 
    WHERE OSOBY.ID_OSOBY = REZERWACJE_OSOBY.id_osoby;

    IF id_istnieje = 0 THEN
        raise_application_error(-20101, 'Osoba o podanym ID nie istnieje!');
    END IF;

    SELECT uczestnicy_wycieczki_row(w.ID_WYCIECZKI, w.NAZWA, w.KRAJ, 
                                w.DATA, o.IMIE, o.NAZWISKO, r.STATUS)
    BULK COLLECT INTO rezerwacje_t
    FROM WYCIECZKI w
    JOIN REZERWACJE r ON w.ID_WYCIECZKI = r.ID_WYCIECZKI
    JOIN OSOBY o ON r.ID_OSOBY = o.ID_OSOBY
    WHERE o.ID_OSOBY = REZERWACJE_OSOBY.id_osoby;

    RETURN rezerwacje_t;
END;
