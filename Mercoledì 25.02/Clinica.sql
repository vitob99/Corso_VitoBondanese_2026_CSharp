create database ClinicaGruppo2;
use ClinicaGruppo2;

create table paziente(
    id_paziente int AUTO_INCREMENT PRIMARY KEY,
    nome varchar(255) not null,
    cognome varchar(255) not null,
    data_nascita date,
    codice_fiscale varchar(16) UNIQUE,
    telefono varchar(15),
    email varchar(255) UNIQUE,
    data_registrazione date
);


create table specializzazione(
	id_specializzazione int AUTO_INCREMENT PRIMARY KEY,
	nome varchar(50) UNIQUE
);


create table medico(
	id_medico int AUTO_INCREMENT PRIMARY KEY, 
	nome varchar(255) not null,
	cognome varchar(255) not null,
	id_specializzazione int,
	stipendio double CHECK (stipendio > 0),
	data_assunzione date,
    foreign key(id_specializzazione) references specializzazione(id_specializzazione) on delete cascade
);

CREATE TABLE reparto (
    id_reparto INT PRIMARY KEY auto_increment,
    nome VARCHAR(255),
    numero_posti int
);

CREATE TABLE ricovero (
    id_ricovero INT AUTO_INCREMENT PRIMARY KEY,
    id_paziente INT NOT NULL,
    id_reparto INT NOT NULL,
    data_ingresso DATE NOT NULL,
    data_dimissione DATE,
    CHECK (data_dimissione IS NULL OR data_dimissione > data_ingresso),
    FOREIGN KEY (id_paziente)
        REFERENCES Paziente(id_paziente)
        ON DELETE CASCADE,
    FOREIGN KEY (id_reparto)
        REFERENCES Reparto(id_reparto)
        ON DELETE RESTRICT
);

create table appuntamento (
    id_appuntamento INT PRIMARY KEY auto_increment,
    id_paziente INT,
    id_medico INT,
    data_appuntamento DATETIME,
    stato ENUM('Prenotato', 'completato', 'annullato'),
    costo NUMERIC(4,2),
    FOREIGN KEY (id_paziente) REFERENCES paziente(id_paziente),
    FOREIGN KEY (id_medico) REFERENCES medico(id_medico)
);

CREATE TABLE pagamento (
    id_pagamento INT AUTO_INCREMENT PRIMARY KEY,
    id_appuntamento INT NOT NULL,
    importo DECIMAL(8,2) NOT NULL CHECK (importo >= 0),
    metodo_pagamento VARCHAR(50) NOT NULL,
    data_pagamento DATE NOT NULL,
    FOREIGN KEY (id_appuntamento)
        REFERENCES Appuntamento(id_appuntamento)
        ON DELETE CASCADE
);

CREATE TABLE prescrizione (
    id_prescrizione INT PRIMARY KEY auto_increment,
    id_appuntamento INT,
    descrizione VARCHAR(255),
    data_prescrizione date,
    FOREIGN KEY (id_appuntamento) REFERENCES appuntamento(id_appuntamento) ON DELETE CASCADE
);



INSERT INTO specializzazione (nome) VALUES 
('Cardiologia'), ('Pediatria'), ('Neurologia'), ('Ortopedia'), ('Dermatologia');

INSERT INTO reparto (nome, numero_posti) VALUES 
('Terapia Intensiva', 10), ('Pediatria', 20), ('Chirurgia', 15), ('Medicina Generale', 30), ('Pronto Soccorso', 12);

INSERT INTO paziente (nome, cognome, data_nascita, codice_fiscale, telefono, email, data_registrazione) VALUES 
('Mario', 'Rossi', '1985-05-12', 'RSSMRA85E12H501Z', '3331234567', 'mario.rossi@email.it', '2023-01-10'),
('Giulia', 'Bianchi', '1992-08-23', 'BNCHGL92M63F205A', '3479876543', 'giulia.b@email.it', '2023-01-15'),
('Luca', 'Verdi', '1970-11-30', 'VRDLCU70S30L219X', '3355554444', 'luca.verdi@email.it', '2023-02-01'),
('Anna', 'Neri', '2000-01-15', 'NREANN00A55H501Y', '3401112223', 'anna.neri@email.it', '2023-02-10'),
('Marco', 'Galli', '1955-04-05', 'GLLMRC55D05F205K', '3283334445', 'marco.galli@email.it', '2023-03-05'),
('Sofia', 'Rizzo', '1988-12-12', 'RZZSFA88T52L219J', '3334445556', 'sofia.rizzo@email.it', '2023-03-20'),
('Paolo', 'Ferrari', '1962-07-07', 'FRRPLA62L07H501W', '3490001112', 'paolo.ferr@email.it', '2023-04-01'),
('Elena', 'Esposito', '1995-09-18', 'SPSLNE95P58F205Q', '3312223334', 'elena.espo@email.it', '2023-04-12'),
('Roberto', 'Romano', '1975-02-28', 'RMNRRT75B28L219P', '3203332221', 'rob.romano@email.it', '2023-05-05'),
('Chiara', 'Gallo', '2005-06-10', 'GLLCHR05H50F205V', '3471122334', 'chiara.g@email.it', '2023-05-15'),
('Antonio', 'Conti', '1980-03-15', 'CNTNTN80C15H501U', '3336667778', 'antonio.c@email.it', '2023-06-01'),
('Francesca', 'De Luca', '1991-10-25', 'DLCFNC91R65F205T', '3457778889', 'fran.deluca@email.it', '2023-06-10'),
('Stefano', 'Mancini', '1968-12-01', 'MNCSTF68T01L219S', '3388889990', 'stefano.m@email.it', '2023-07-01'),
('Laura', 'Costa', '1983-05-20', 'CSTLRA83E60H501R', '3409990001', 'laura.costa@email.it', '2023-07-15'),
('Giovanni', 'Bruno', '1972-08-14', 'BRNGNN72M14F205M', '3291110002', 'gio.bruno@email.it', '2023-08-01'),
('Alice', 'Serra', '1998-11-05', 'SRRLCA98S45L219L', '3310009998', 'alice.serra@email.it', '2023-08-20'),
('Pietro', 'Messina', '1959-01-30', 'MSSPTR59A30H501P', '3341112220', 'pietro.m@email.it', '2023-09-01'),
('Marta', 'Greco', '1994-04-12', 'GRCMRT94D52F205O', '3423334441', 'marta.greco@email.it', '2023-09-10'),
('Fabio', 'Vitale', '1987-07-22', 'VTLFBA87L22L219N', '3394445552', 'fabio.v@email.it', '2023-10-01'),
('Sara', 'Lombardi', '2001-09-09', 'LMBSRA01P49H501M', '3465556663', 'sara.lomb@email.it', '2023-10-15');

INSERT INTO medico (nome, cognome, id_specializzazione, stipendio, data_assunzione) VALUES 
('Alessandro', 'Basile', 1, 4500.00, '2015-05-10'),
('Beatrice', 'Sanna', 2, 4200.00, '2018-03-20'),
('Claudio', 'Villa', 3, 5000.00, '2010-09-15'),
('Daniela', 'Moretti', 4, 4800.00, '2012-06-01'),
('Enrico', 'Barbieri', 5, 4100.00, '2019-11-22'),
('Federica', 'Fontana', 1, 4600.00, '2016-02-14'),
('Giorgio', 'Santoro', 2, 4300.00, '2017-08-30'),
('Ilaria', 'Marini', 3, 5200.00, '2011-04-10'),
('Lorenzo', 'Rinaldi', 4, 4700.00, '2014-12-05'),
('Monica', 'Ferraro', 5, 4000.00, '2020-01-20');

INSERT INTO appuntamento (id_paziente, id_medico, data_appuntamento, stato, costo) VALUES 
(1, 1, '2024-02-01 09:00:00', 'completato', 80.00), (2, 2, '2024-02-01 10:00:00', 'completato', 75.00),
(3, 3, '2024-02-02 11:30:00', 'completato', 99.00), (4, 4, '2024-02-02 15:00:00', 'completato', 90.00),
(5, 5, '2024-02-03 09:00:00', 'completato', 70.00), (6, 6, '2024-02-03 10:30:00', 'completato', 85.00),
(7, 7, '2024-02-04 12:00:00', 'completato', 75.00), (8, 8, '2024-02-04 16:00:00', 'completato', 95.00),
(9, 9, '2024-02-05 09:30:00', 'completato', 85.00), (10, 10, '2024-02-05 11:00:00', 'completato', 70.00),
(11, 1, '2024-02-06 14:30:00', 'completato', 80.00), (12, 2, '2024-02-06 15:30:00', 'completato', 75.00),
(13, 3, '2024-02-07 09:00:00', 'annullato', 99.00), (14, 4, '2024-02-07 10:00:00', 'completato', 90.00),
(15, 5, '2024-02-08 11:30:00', 'completato', 70.00), (16, 6, '2024-02-08 15:00:00', 'Prenotato', 85.00),
(17, 7, '2024-02-09 09:00:00', 'completato', 75.00), (18, 8, '2024-02-09 10:30:00', 'completato', 95.00),
(19, 9, '2024-02-10 12:00:00', 'completato', 85.00), (20, 10, '2024-02-10 16:00:00', 'completato', 70.00),
(1, 2, '2024-02-11 09:30:00', 'Prenotato', 75.00), (2, 3, '2024-02-11 11:00:00', 'Prenotato', 99.00),
(3, 1, '2024-02-12 14:30:00', 'completato', 80.00), (4, 5, '2024-02-12 15:30:00', 'completato', 70.00),
(5, 7, '2024-02-13 09:00:00', 'annullato', 75.00), (6, 9, '2024-02-13 10:00:00', 'completato', 85.00),
(7, 4, '2024-02-14 11:30:00', 'Prenotato', 90.00), (8, 6, '2024-02-14 15:00:00', 'completato', 85.00),
(9, 8, '2024-02-15 09:00:00', 'completato', 95.00), (10, 2, '2024-02-15 10:30:00', 'completato', 75.00);

INSERT INTO ricovero (id_paziente, id_reparto, data_ingresso, data_dimissione) VALUES 
(1, 1, '2024-01-05', '2024-01-12'), (5, 4, '2024-01-10', '2024-01-20'),
(10, 2, '2024-01-15', '2024-01-18'), (15, 3, '2024-01-20', '2024-01-30'),
(3, 4, '2024-01-25', '2024-02-05'), (7, 5, '2024-02-01', NULL),
(12, 3, '2024-02-05', '2024-02-10'), (18, 1, '2024-02-10', NULL),
(20, 2, '2024-02-12', '2024-02-15'), (2, 4, '2024-02-15', NULL);

INSERT INTO pagamento (id_appuntamento, importo, metodo_pagamento, data_pagamento) VALUES 
(1, 80.00, 'Carta di Credito', '2024-02-01'), (2, 75.00, 'Contanti', '2024-02-01'),
(3, 99.00, 'Bancomat', '2024-02-02'), (4, 90.00, 'Carta di Credito', '2024-02-02'),
(5, 70.00, 'Contanti', '2024-02-03'), (6, 85.00, 'Bancomat', '2024-02-03'),
(7, 75.00, 'Carta di Credito', '2024-02-04'), (8, 95.00, 'Bonifico', '2024-02-04'),
(9, 85.00, 'Contanti', '2024-02-05'), (10, 70.00, 'Bancomat', '2024-02-05'),
(11, 80.00, 'Carta di Credito', '2024-02-06'), (12, 75.00, 'Carta di Credito', '2024-02-06'),
(14, 90.00, 'Bancomat', '2024-02-07'), (15, 70.00, 'Contanti', '2024-02-08'),
(17, 75.00, 'Carta di Credito', '2024-02-09'), (18, 95.00, 'Bancomat', '2024-02-09'),
(19, 85.00, 'Contanti', '2024-02-10'), (20, 70.00, 'Carta di Credito', '2024-02-10'),
(23, 80.00, 'Bancomat', '2024-02-12'), (24, 70.00, 'Carta di Credito', '2024-02-12');

INSERT INTO prescrizione (id_appuntamento, descrizione, data_prescrizione) VALUES 
(1, 'Cardioaspirina 100mg - 1 volta al dì', '2024-02-01'),
(3, 'Risonanza Magnetica encefalo', '2024-02-02'),
(6, 'Controllo ECG sotto sforzo', '2024-02-03'),
(8, 'Analisi del sangue complete', '2024-02-04'),
(11, 'Visita di controllo tra 6 mesi', '2024-02-06'),
(20, 'Crema dermatologica per irritazione', '2024-02-10');







#QUERY 1
#Mostrare il numero di appuntamenti per ogni medico, ordinati dal più impegnato.

SELECT M.nome, M.cognome, COUNT(A.id_appuntamento) AS numero_appuntamenti
FROM Medico M
LEFT JOIN Appuntamento A ON M.id_medico = A.id_medico
GROUP BY M.id_medico
ORDER BY numero_appuntamenti DESC;

#QUERY 2
#Mostrare i pazienti che hanno effettuato più di 3 appuntamenti.

SELECT P.nome, P.cognome, COUNT(A.id_appuntamento) AS numero_appuntamenti
FROM Paziente P
JOIN Appuntamento A ON P.id_paziente = A.id_paziente
GROUP BY P.id_paziente
HAVING COUNT(A.id_appuntamento) > 1;

#QUERY 3
#Calcolare l’incasso totale per ogni medico.

SELECT M.nome, M.cognome, SUM(Pag.importo) AS incasso_totale
FROM Medico M
JOIN Appuntamento A ON M.id_medico = A.id_medico
JOIN Pagamento Pag ON A.id_appuntamento = Pag.id_appuntamento
GROUP BY M.id_medico
ORDER BY incasso_totale DESC;

--QUERY 4 = Mostrare il medico con lo stipendio più alto per ogni specializzazione.(richiede subquery o window function)
    select M.nome as NomeMedico, M.cognome as CognomeMedico, M.stipendio as Stipendio, S.nome as Specializzazione
    from medico M
    join specializzazione S on M.id_specializzazione = S.id_specializzazione
    where M.stipendio = (select max(stipendio) from medico M2 where M2.id_specializzazione = M.id_specializzazione)
    order by M.stipendio desc;
--QUERY5 = Mostrare il paziente che ha speso di più in totale.(somma pagamenti + subquery)
    select P.nome as NomePaziente, P.cognome as CognomePaziente, sum(Pag.importo) as TotaleSpeso
    from paziente P
    join appuntamento A on P.id_paziente = A.id_paziente
    join pagamento Pag on A.id_appuntamento = Pag.id_appuntamento
    group by P.id_paziente
    order by TotaleSpeso desc
    LIMIT 1;
--QUERY 6 = Mostrare per ogni reparto il tasso di occpazione attuale. (tot ricoverati attuali / numero_posti)
    select 
        Rep.nome as NomeReparto, 
        Rep.numero_posti as PostiTotali,
        COUNT(case when Ric.data_dimissione is null then 1 end) as RicoveratiAttuali,
        round((COUNT(case when Ric.data_dimissione is null then 1 end) / Rep.numero_posti * 100),2) as '% TassoOccupazione'
    from reparto Rep
    left join ricovero Ric on Rep.id_reparto = Ric.id_reparto
    group by Rep.id_reparto, Rep.nome, Rep.numero_posti;

-- QUERY 7
SELECT * FROM medico
WHERE NOT EXISTS
(SELECT id_appuntamento FROM appuntamento
WHERE data_appuntamento BETWEEN CURRENT_DATE()-30 AND CURRENT_DATE() AND appuntamento.id_medico = medico.id_medico
);

-- QUERY 8
SELECT s.nome, SUM(p.importo) AS incasso
FROM pagamento p JOIN appuntamento a ON p.id_appuntamento = a.id_appuntamento JOIN medico m ON a.id_medico = m.id_medico JOIN specializzazione s ON m.id_specializzazione = s.id_specializzazione
GROUP BY s.nome
ORDER BY incasso DESC
LIMIT 1;

-- QUERY 9
SELECT MONTH(p.data_pagamento) AS mese, YEAR(p.data_pagamento) AS anno, SUM(p.importo) AS incasso_mensile, LAG(SUM(p.importo)) OVER (ORDER BY MONTH(p.data_pagamento)) AS vendite_mese_precedente,
((SUM(p.importo) - LAG(SUM(p.importo)) OVER (ORDER BY MONTH(p.data_pagamento))) / 
        LAG(SUM(p.importo)) OVER (ORDER BY MONTH(p.data_pagamento))) * 100 AS variazione_percentuale
FROM pagamento p
GROUP BY mese, anno;

--QUERY 10
#Mostrare i pazienti che:
#● hanno avuto almeno 2 ricoveri
#● e hanno effettuato almeno 5 appuntamenti
#● e hanno speso sopra la media dei pazienti




