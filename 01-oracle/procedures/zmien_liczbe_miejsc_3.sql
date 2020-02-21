CREATE OR REPLACE PROCEDURE ZMIEN_LICZBE_MIEJSC_3
    (id_wycieczki IN WYCIECZKI.ID_WYCIECZKI%TYPE, 
     liczba_miejsc IN WYCIECZKI.LICZBA_MIEJSC%TYPE)
AS
    id_wycieczki_istnieje int;
    liczba_zajetych_miejsc int;
BEGIN
    SELECT COUNT(*) INTO id_wycieczki_istnieje
    FROM WYCIECZKI_PRZYSZLE wp
    WHERE wp.ID_WYCIECZKI = ZMIEN_LICZBE_MIEJSC_3.id_wycieczki;

    IF id_wycieczki_istnieje = 0 THEN
        raise_application_error(-20107, 'Wycieczka o podanym ID 
        nie istnieje lub już się odbyła!');
    END IF;

    SELECT w.LICZBA_MIEJSC - w.LICZBA_WOLNYCH_MIEJSC INTO liczba_zajetych_miejsc
    FROM WYCIECZKI w
    WHERE w.ID_WYCIECZKI = ZMIEN_LICZBE_MIEJSC_3.id_wycieczki;

    IF ZMIEN_LICZBE_MIEJSC_3.liczba_miejsc < liczba_zajetych_miejsc THEN
        raise_application_error(-20108, 'Nowa liczba miejsc jest mniejsza 
        niż liczba miejsc zajętych!');
    END IF;

    UPDATE WYCIECZKI
    SET LICZBA_MIEJSC = ZMIEN_LICZBE_MIEJSC_3.liczba_miejsc
    WHERE ID_WYCIECZKI = ZMIEN_LICZBE_MIEJSC_3.id_wycieczki;
END;
