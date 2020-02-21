CREATE OR REPLACE TYPE dostepne_wycieczki_row AS OBJECT
(
    id_wycieczki INT,
    nazwa_wycieczki VARCHAR2(100),
    kraj VARCHAR2(50),
    data_wycieczki DATE,
    liczba_miejsc INT,
    liczba_wolnych_miejsc INT
);

CREATE OR REPLACE TYPE dostepne_wycieczki_table AS TABLE OF dostepne_wycieczki_row;

CREATE OR REPLACE FUNCTION DOSTEPNE_WYCIECZKI_FUN
    (kraj IN WYCIECZKI.KRAJ%TYPE, data_od IN DATE, data_do IN DATE)
RETURN dostepne_wycieczki_table
AS
    dostepne_wycieczki_t dostepne_wycieczki_table;
BEGIN
    IF data_od > data_do THEN
        raise_application_error(-20102, 
        'Podano niepoprawne daty: data końca przedziału 
        jest wcześniejsza niż jego początek');
    END IF;

    SELECT dostepne_wycieczki_row(w.ID_WYCIECZKI, w.NAZWA, w.KRAJ, w.DATA, 
        w.LICZBA_MIEJSC,
        w.LICZBA_MIEJSC - 
            (SELECT COUNT(*) FROM REZERWACJE r 
             WHERE r.STATUS <> 'A' AND r.ID_WYCIECZKI = w.ID_WYCIECZKI))
    BULK COLLECT INTO dostepne_wycieczki_t
    FROM WYCIECZKI w
    WHERE w.KRAJ = DOSTEPNE_WYCIECZKI_FUN.kraj
    AND w.DATA BETWEEN DOSTEPNE_WYCIECZKI_FUN.data_od 
    AND DOSTEPNE_WYCIECZKI_FUN.data_do
    AND w.LICZBA_MIEJSC - 
    (SELECT COUNT(*) FROM REZERWACJE r 
     WHERE r.STATUS <> 'A' AND r.ID_WYCIECZKI = w.ID_WYCIECZKI) > 0;

    RETURN dostepne_wycieczki_t;
END;
