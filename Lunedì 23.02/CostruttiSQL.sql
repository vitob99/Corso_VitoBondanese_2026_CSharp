/*
Alcuni dei comandi SQL più importanti:
    SELECT - estrae i dati da un database
        - WHERE => OPERATORI <,>,>=,!=,..., OPERATORI LOGICI(AND, OR, NOT), BETWEEN, LIKE, IN
        - GROUP BY c1,c2 
        - ORDER BY c1,c2,...,cn asc/desc


    INSERT INTO - inserisce nuovi dati in un database
    DELETE  FROM  - elimina i dati da un database

    UPDATE - aggiorna i dati in un database


    CREATE DATABASE - crea un nuovo database
    ALTER DATABASE - modifica un database
    CREATE TABLE - crea una nuova tabella
    ALTER TABLE - modifica una tabella
    DROP TABLE - elimina una tabella
    CREATE INDEX - crea un indice (chiave di ricerca)
    DROP INDEX - elimina un indice
*/




















/*
    1) Utilizzo di DISTINCT e WHERE:
    Elencare, senza ripetizioni, tutte le regioni (Region) dei paesi che appartengono al continente (Continent) 'Europe'

    select distinct Region 
    from Country 
    where Continent = 'Europe';
*/

/*
    2) Combinazione di WHERE, ORDER BY:
    Elencare i nomi (Name) e la popolazione (Population) delle città (City) degli Stati Uniti 
    (CountryCode = 'USA') che hanno una popolazione superiore a 1.000.000 abitanti, ordinando i risultati dalla città più popolosa alla meno popolosa.

    select Name, Population 
    from City
    where CountryCode = 'USA' AND Population > 1000000
    order by Population desc;
*/

/*
    3) GROUP BY con funzioni di aggregazione:
    Mostrare per ogni continente (Continent) presente nella tabella Country:
        Il numero totale di paesi appartenenti a ciascun continente.
        La popolazione totale del continente.
        Ordinare il risultato per popolazione totale in ordine decrescente.

    select Continent, Count(Continent), sum(Population) as Popolazione_totale
    from Country
    group by Continent
    order by Popolazione_totale desc;
*/

/*
    Esercizio sui comandi SQL: GROUP BY, ORDER BY e INSERT INTO
    Si consideri un database che contiene informazioni su una libreria. Nel database è presente una tabella chiamata Libri con la seguente struttura:
    Libri (
        id INT PRIMARY KEY,
        titolo VARCHAR(100),
        autore VARCHAR(100),
        genere VARCHAR(50),
        prezzo DECIMAL(5,2),
        anno_pubblicazione INT
    )

    1) Inserimento dati (INSERT INTO)
        Inserire almeno 6 nuovi libri nella tabella Libri usando il comando SQL INSERT INTO.
        I libri devono appartenere a generi e autori diversi, ed essere pubblicati in anni differenti.
    2) Aggregazione e raggruppamento (GROUP BY)
        Scrivere una query che, usando il comando GROUP BY, mostri per ogni genere:
            il numero totale di libri presenti;
            il prezzo medio dei libri appartenenti a quel genere.
        La query dovrà restituire il risultato ordinato alfabeticamente per genere.
    3) Ordinamento risultati (ORDER BY)
        Scrivere una query che elenchi tutti i libri pubblicati dopo l’anno 2010 ordinati in modo decrescente per anno di pubblicazione e, in
        caso di anno uguale, in ordine crescente per prezzo

    insert into Libri values(1, 'Senza titolo', 'Mario', 'Horror', 10.5, 2002);
    insert into Libri values(2, 'Bho non so', 'Luca', 'Avventura', 18.5, 2005);
    insert into Libri values(3, 'Titolo Inventato', 'Antonio', 'Azione', 9.5, 2022);
    insert into Libri values(4, 'Ciao titolo', 'Michele', 'Mistero', 7.5, 2025);
    insert into Libri values(5, 'Altro titolo', 'Gennaro', 'Romanzo', 5.0, 1999);
    insert into Libri values(6, 'Niente titolo', 'Giovanni', 'Fantascienza', 15.0, 2004);

    select genere, count(*) as Totale_Libri_Genere, avg(prezzo) as Prezzo_Medio
    from Libri
    group by genere
    order by genere asc;

    select * 
    from Libri
    where anno_pubblicazione > 2010 
    order by anno_pubblicazione desc, prezzo asc;
*/


/*
    Si consideri una tabella chiamata Vendite con la seguente struttura, almeno 20 elementi generati:
    Vendite (
        id INT,
        prodotto VARCHAR(100),
        categoria VARCHAR(50),
        quantita INT,
        prezzo_unitario DECIMAL(6,2),
        data_vendita DATE
    );
    Scrivi le query SQL per rispondere alle seguenti richieste:
        - Totale vendite per categoria
        Visualizza, per ogni categoria, il numero totale di vendite effettuate.
        - Prezzo medio per categoria
        Mostra, per ogni categoria, il prezzo medio dei prodotti venduti.
        - Quantità totale venduta per ogni prodotto
        Mostra il totale delle quantità vendute (SUM) per ciascun prodotto.
        - Prezzo massimo e minimo venduto nella tabella
        Mostra il prezzo massimo e il prezzo minimo tra tutti i prodotti venduti.
        - Numero totale di righe nella tabella
        Conta quante vendite sono state registrate nella tabella Vendite.
        - I 5 prodotti più costosi (in base al prezzo_unitario)
        Elenca i 5 prodotti più costosi ordinati in modo decrescente rispetto al prezzo.
        - I 3 prodotti meno venduti per quantità totale
        Mostra i nomi dei 3 prodotti con la quantità totale più bassa venduta (usa SUM e LIMIT).


        select count(*) as Totale_Vendite
        from Vendite
        group by categoria

        select avg(prezzo_unitario) as PrezzoMedio
        from Vendite
        group by categoria

        select sum(quantita) as TotQuantitaVendute
        from Vendite
        group by prodotto

        select max(prezzo_unitario) as PrezzoMassimo, min(prezzo_unitario) as PrezzoMinimo
        from Vendite

        select count(*) as Numero_Righe 
        from Vendite

        select prodotto as Prodotto, prezzo_unitario as Prezzo
        from vendite
        order by prezzo_unitario desc
        limit 5;

        select prodotto as NomeProdotto, sum(quantita) AS QuantitaTotale
        from Vendite
        group by prodotto
        order by QuantitaTotale asc
        limit 3;
*/


/*
    Si consideri una tabella chiamata Clienti con la seguente struttura, almeno 20 dati inseriti:
    Clienti (
        id INT,
        nome VARCHAR(100),
        cognome VARCHAR(100),
        email VARCHAR(100),
        eta INT,
        citta VARCHAR(100)
    );

    Scrivere le query SQL per rispondere alle seguenti richieste:
        - Clienti con email su dominio Gmail
        Seleziona tutti i clienti la cui email termina con @gmail.com.
        - Clienti con nome che inizia con la lettera 'A'
        Mostra tutti i clienti il cui nome comincia con la lettera A.
        - Clienti con cognome che contiene esattamente 5 lettere
        Mostra tutti i clienti il cui cognome è composto da esattamente 5 caratteri.
        - Clienti con età compresa tra 30 e 40 anni (inclusi)
        Elenca i clienti che hanno un'età compresa tra 30 e 40 anni, inclusi gli estremi.
        - Clienti che vivono in città il cui nome contiene 'roma' (maiuscole/minuscole ignorate)
        Mostra tutti i clienti che abitano in una città il cui nome contiene la stringa roma, indipendentemente da maiuscole o minuscole.

        select nome as NomeCliente, cognome as CognomeCliente, email as EMail
        from clienti
        where EMail like '%@gmail.com';

        select nome as NomeCliente, cognome as CognomeCliente
        from clienti
        where nome like 'A%'

        select nome as NomeCliente, cognome as CognomeCliente
        from clienti
        where length(cognome) = 5;

        select nome as NomeCliente, cognome as CognomeCliente, eta as Eta
        from clienti
        where eta BETWEEN 30 AND 40;

        select nome as NomeCliente, cognome as CognomeCliente, citta as Città
        from clienti
        where lower(citta) like '%roma%'
*/

/*
    Si considerino le seguenti due tabelle con 20 dati l’una:
    Clienti (
        id INT,
        nome VARCHAR(100),
        città VARCHAR(100)
    )
    Ordini (
        id INT,
        id_cliente INT,
        data_ordine DATE,
        importo DECIMAL(7,2)
    )
    Le due tabelle sono collegate dalla relazione tra Clienti.id e Ordini.id_cliente.
    Esercizio 1 – INNER JOIN Obiettivo:
        Visualizza l’elenco dei ->clienti che hanno effettuato almeno un ordine.<-
        Per ciascuno, mostra: nome del cliente, data dell’ordine e importo.
    Esercizio 2 – LEFT JOIN Obiettivo:
        Visualizza tutti i clienti, ->inclusi quelli che non hanno mai effettuato ordini.<-
        Mostra per ciascuno: nome del cliente, data dell’ordine (se presente) e importo (se presente).
    Esercizio 3 – RIGHT JOIN Obiettivo:
        Visualizza tutti gli ordini, ->anche quelli che non hanno un cliente associato (caso anomalo).<-
        Mostra per ciascuno: nome del cliente (se esiste), data dell’ordine e importo.

    select Clienti.nome as NomeCliente, Ordini.data_ordine as DataOrdine, Ordini.importo as ImportoOrdine
    from Clienti
    inner join Ordini on Clienti.id = Ordini.id_cliente;
    
    select Clienti.nome as NomeCliente, Ordini.data_ordine as DataOrdine, Ordini.importo as ImportoOrdine
    from Clienti
    left join Ordini on Clienti.id = Ordini.id_cliente;

    select Clienti.nome as NomeCliente, Ordini.data_ordine as DataOrdine, Ordini.importo as ImportoOrdine
    from Clienti
    right join Ordini on Clienti.id = Ordini.id_cliente;    

*/

/*
Devi realizzare un report completo per il reparto vendite, che soddisfi tutte le seguenti condizioni usando correttamente e separatamente i tre tipi di JOIN:
    - Elenca i clienti attivi, cioè quelli che hanno effettuato almeno un ordine, mostrando per ciascuno:
        Nome del cliente
        Totale ordini effettuati
        Somma totale degli importi spesi
    - Elenca i clienti inattivi, cioè quelli che non hanno mai effettuato ordini, mostrando solo:
        Nome del cliente
        Città di residenza
    - Individua gli ordini orfani, cioè ordini presenti in tabella ma senza un cliente valido associato (es. cliente cancellato), e mostra:
        ID dell’ordine
        Data dell’ordine
        Importo

(Cliente = NULL)
Requisiti tecnici:
Per il punto 1: usa INNER JOIN.
Per il punto 2: usa LEFT JOIN con condizione su IS NULL.
Per il punto 3: usa RIGHT JOIN con condizione su IS NULL



select Clienti.nome as NomeCliente, Count(Ordini.id) as Numero_Ordini, sum(Ordini.importo) as ImportoTotale
from Clienti
inner join Ordini on Clienti.id = Ordini.id_cliente
group by Clienti.nome;

select Clienti.nome as NomeCliente, Clienti.citta as CittàCliente
from Clienti
left join Ordini on Clienti.id = Ordini.id_cliente
where Ordini.id_cliente is null;

select Ordini.id as idOrdine, Ordini.data_ordine as DataOrdine, Ordini.importo as ImportoOrdine
from Clienti
right join Ordini on Clienti.id = Ordini.id_cliente
where Ordini.id_cliente is null;
*/

/*
Esercizio 1 – INNER JOIN + WHERE + LIKE
    Visualizzare l’elenco dei libri venduti in almeno un negozio, mostrando:
        titolo del libro, autore, data_vendita, negozio.
    Includere solo i libri il cui autore contiene la stringa “King” (indipendentemente da maiuscole/minuscole).

Esercizio 2 – LEFT JOIN + WHERE + BETWEEN
Visualizzare tutti i libri, anche quelli che non hanno ancora vendite registrate, mostrando per ciascuno:
    titolo, anno_pubblicazione, prezzo, data_vendita (se presente).
Filtrare i risultati per anno_pubblicazione compreso tra 2000 e 2010.



select L.titolo as TitoloLibro, L.autore as AutoreLibro, V.data_vendita as DataVendita, V.negozio as Negozio
from Libri L
inner join Vendite V on L.id = V.id_libro 
where lower(L.autore) like '%king%'

select L.titolo as TitoloLibro, L.anno_pubblicazione as AnnoPubblicazione, L.prezzo as PrezzoLibro, V.data_vendita as DataVendita
from Libri L
left join Vendite V on L.id = V.id_libro
where L.anno_pubblicazione BETWEEN 2000 AND 2010;



*/
