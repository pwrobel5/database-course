CREATE OR REPLACE TYPE uczestnicy_wycieczki_row AS OBJECT
(
    id_wycieczki INT,
    nazwa_wycieczki VARCHAR2(100),
    kraj VARCHAR2(50),
    data_wycieczki DATE,
    imie VARCHAR2(50),
    nazwisko VARCHAR2(50),
    status_rezerwacji CHAR(1)
);

CREATE OR REPLACE TYPE uczestnicy_wycieczki_table AS TABLE OF uczestnicy_wycieczki_row;

CREATE OR REPLACE FUNCTION UCZESTNICY_WYCIECZKI
(id_wycieczki IN WYCIECZKI.ID_WYCIECZKI%TYPE)
RETURN uczestnicy_wycieczki_table
AS
    uczestnicy_t uczestnicy_wycieczki_table;
    id_istnieje int;
BEGIN
    SELECT COUNT(*) INTO id_istnieje 
    FROM WYCIECZKI 
    WHERE WYCIECZKI.ID_WYCIECZKI = UCZESTNICY_WYCIECZKI.id_wycieczki;

    IF id_istnieje = 0 THEN
        raise_application_error(-20100, 'Wycieczka o podanym ID nie istnieje!');
    END IF;

    SELECT uczestnicy_wycieczki_row(w.ID_WYCIECZKI, w.NAZWA, w.KRAJ, 
                                w.DATA, o.IMIE, o.NAZWISKO, r.STATUS)
    BULK COLLECT INTO uczestnicy_t
    FROM WYCIECZKI w
    JOIN REZERWACJE r ON w.ID_WYCIECZKI = r.ID_WYCIECZKI
    JOIN OSOBY o ON r.ID_OSOBY = o.ID_OSOBY
    WHERE r.STATUS <> 'A' AND w.ID_WYCIECZKI = UCZESTNICY_WYCIECZKI.id_wycieczki;

    RETURN uczestnicy_t;
END;
