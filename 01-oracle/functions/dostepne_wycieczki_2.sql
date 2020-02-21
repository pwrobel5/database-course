CREATE OR REPLACE FUNCTION DOSTEPNE_WYCIECZKI_FUN_2
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
        w.LICZBA_WOLNYCH_MIEJSC)
    BULK COLLECT INTO dostepne_wycieczki_t
    FROM WYCIECZKI w
    WHERE w.KRAJ = DOSTEPNE_WYCIECZKI_FUN_2.kraj
    AND w.DATA BETWEEN DOSTEPNE_WYCIECZKI_FUN_2.data_od 
    AND DOSTEPNE_WYCIECZKI_FUN_2.data_do
    AND w.LICZBA_WOLNYCH_MIEJSC > 0;

    RETURN dostepne_wycieczki_t;
END;
