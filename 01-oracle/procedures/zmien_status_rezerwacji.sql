CREATE OR REPLACE PROCEDURE ZMIEN_STATUS_REZERWACJI
    (id_rezerwacji IN REZERWACJE.NR_REZERWACJI%TYPE, status IN REZERWACJE.STATUS%TYPE)
AS
    id_rezerwacji_istnieje int;
    wolne_miejsca int;
    biezacy_status char(1);
BEGIN
    IF ZMIEN_STATUS_REZERWACJI.status = 'N' THEN
        raise_application_error(-20105, 'Nie można zmienić statusu 
        rezerwacji na nowy!');
    END IF;

    SELECT COUNT(*) INTO id_rezerwacji_istnieje
    FROM WYCIECZKI_PRZYSZLE wp
    JOIN REZERWACJE r ON r.ID_WYCIECZKI = wp.ID_WYCIECZKI
    WHERE r.NR_REZERWACJI = ZMIEN_STATUS_REZERWACJI.id_rezerwacji;

    IF id_rezerwacji_istnieje = 0 THEN
        raise_application_error(-20104, 'Rezerwacja nie istnieje
        lub dotyczy przeszłej wycieczki!');
    END IF;

    SELECT r.STATUS INTO biezacy_status
    FROM REZERWACJE r
    WHERE r.NR_REZERWACJI = ZMIEN_STATUS_REZERWACJI.id_rezerwacji;

    IF biezacy_status = ZMIEN_STATUS_REZERWACJI.status THEN
        raise_application_error(-20107, 'Nowy status jest identyczny jak bieżący!');
    END IF;

    IF biezacy_status = 'A' THEN
        SELECT wm.WOLNE_MIEJSCA INTO ZMIEN_STATUS_REZERWACJI.wolne_miejsca
        FROM WYCIECZKI_MIEJSCA wm
        JOIN REZERWACJE r ON r.ID_WYCIECZKI = wm.ID_WYCIECZKI
        WHERE r.NR_REZERWACJI = ZMIEN_STATUS_REZERWACJI.id_rezerwacji;

        IF wolne_miejsca = 0 THEN
            raise_application_error(-20106, 'Brak wolnych miejsc, 
            nie można zmienić statusu tej rezerwacji z anulowanego!');
        END IF;
    END IF;

    UPDATE REZERWACJE
    SET STATUS = ZMIEN_STATUS_REZERWACJI.status
    WHERE NR_REZERWACJI = ZMIEN_STATUS_REZERWACJI.id_rezerwacji;

    --modyfikacja - dziennikowanie zmiany
    INSERT INTO REZERWACJE_LOG 
    (REZERWACJE_LOG.ID_REZERWACJI, REZERWACJE_LOG.DATA, REZERWACJE_LOG.STATUS)
    VALUES (ZMIEN_STATUS_REZERWACJI.id_rezerwacji, 
        CURRENT_DATE, ZMIEN_STATUS_REZERWACJI.status);
END;
