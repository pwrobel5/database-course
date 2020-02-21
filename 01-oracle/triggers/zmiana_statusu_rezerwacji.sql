CREATE OR REPLACE TRIGGER ZMIANA_STATUSU_REZERWACJI
AFTER UPDATE
ON REZERWACJE
FOR EACH ROW
DECLARE
    zmiana_wolnych_miejsc int;
BEGIN
    INSERT INTO REZERWACJE_LOG (ID_REZERWACJI, DATA, STATUS)
    VALUES (:NEW.NR_REZERWACJI, CURRENT_DATE, :NEW.STATUS);

    zmiana_wolnych_miejsc := 0;

    IF :NEW.STATUS <> 'A' THEN
        zmiana_wolnych_miejsc := -1;
    ELSIF :NEW.STATUS = 'A' THEN
        zmiana_wolnych_miejsc := 1;
    END IF;

    IF zmiana_wolnych_miejsc <> 0 THEN
        UPDATE WYCIECZKI
        SET LICZBA_WOLNYCH_MIEJSC = LICZBA_WOLNYCH_MIEJSC + zmiana_wolnych_miejsc
        WHERE ID_WYCIECZKI = :NEW.ID_WYCIECZKI;
    END IF;
END;
