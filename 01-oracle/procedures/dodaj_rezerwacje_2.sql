CREATE OR REPLACE PROCEDURE DODAJ_REZERWACJE_2
    (id_wycieczki IN WYCIECZKI.ID_WYCIECZKI%TYPE, id_osoby IN OSOBY.ID_OSOBY%TYPE)
AS
    id_osoby_istnieje int;
    id_wycieczki_istnieje int;
    rezerwacja_istnieje int;
    wolne_miejsca int;
    id_nowej_rezerwacji int;
BEGIN
    SELECT COUNT(*) INTO id_osoby_istnieje 
    FROM OSOBY 
    WHERE OSOBY.ID_OSOBY = DODAJ_REZERWACJE_2.id_osoby;
    IF id_osoby_istnieje = 0 THEN
        raise_application_error(-20101, 'Osoba o podanym ID nie istnieje!');
    END IF;

    SELECT COUNT(*) INTO id_wycieczki_istnieje 
    FROM WYCIECZKI_PRZYSZLE 
    WHERE WYCIECZKI_PRZYSZLE.ID_WYCIECZKI = DODAJ_REZERWACJE_2.id_wycieczki;
    IF id_wycieczki_istnieje = 0 THEN
        raise_application_error(-20100, 'Wycieczka o podanym ID 
        nie istnieje lub już się odbyła!');
    END IF;

    SELECT COUNT(*) INTO rezerwacja_istnieje 
    FROM REZERWACJE r 
    WHERE r.ID_WYCIECZKI = DODAJ_REZERWACJE_2.id_wycieczki 
    AND r.ID_OSOBY = DODAJ_REZERWACJE_2.id_osoby;
    IF rezerwacja_istnieje <> 0 THEN
        raise_application_error(-20103, 'Rezerwacja już istnieje!');
    END IF;

    SELECT LICZBA_WOLNYCH_MIEJSC INTO wolne_miejsca
    FROM WYCIECZKI w
    WHERE w.ID_WYCIECZKI = DODAJ_REZERWACJE_2.id_wycieczki;

    IF wolne_miejsca = 0 THEN
        raise_application_error(-20106, 'Nie można dodać rezerwacji 
        - brak wolnych miejsc!');
    END IF;

    INSERT INTO REZERWACJE (REZERWACJE.ID_WYCIECZKI, REZERWACJE.ID_OSOBY, STATUS)
    VALUES (DODAJ_REZERWACJE_2.id_wycieczki, DODAJ_REZERWACJE_2.id_osoby, 'N');

    UPDATE WYCIECZKI
    SET LICZBA_WOLNYCH_MIEJSC = LICZBA_WOLNYCH_MIEJSC - 1
    WHERE ID_WYCIECZKI = DODAJ_REZERWACJE_2.id_wycieczki;

    SELECT ISEQ$$_78687.currval INTO DODAJ_REZERWACJE_2.id_nowej_rezerwacji FROM DUAL;

    INSERT INTO REZERWACJE_LOG (ID_REZERWACJI, DATA, STATUS)
    VALUES (DODAJ_REZERWACJE_2.id_nowej_rezerwacji, CURRENT_DATE, 'N');
END;
