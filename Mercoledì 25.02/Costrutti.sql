/*
    1) Si vogliono recuperare dal database "world" la lingua e la nazione di ogni città.

        select city.name as NomeCitta, country.name as NomeNazione, countrylanguage.language as LinguaNazione
        from city
        inner join country on country.Code = city.CountryCode
        inner join countrylanguage on countrylanguage.CountryCode = country.code;


    2) Si vuole recuperare il numero di città per nazione dal database "world"
    mostrando anche il nome della nazione e ordinarli in base al numero di città.

        select country.name as NomeNazione, count(city.Name) as NumeroCittà
        from country
		inner join city on Country.code = city.CountryCode
        group by NomeNazione
        order by NumeroCittà desc;



    3) Si vuole conoscere la lista di repubbliche con aspettativa di vita maggiore dei 70 anni, inoltre si vuole visualizzare anche la lingua parlata.

       select country.Name as NomeCittà, countrylanguage.Language as LinguaParlata, country.LifeExpectancy as AspettativaDiVita, country.GovernmentForm as Governo
       from country
       inner join countrylanguage on countrylanguage.CountryCode = country.Code
       where lower(country.GovernmentForm) like '%republic%' and LifeExpectancy > 70;




    ESERCIZIO 1:
    Si vuole recuperare dal database WORLD le lingue parlate per nazione con la rispettiva percentuale di utilizzo;

    select c.Name as NomeNazione, cl.Language as NomeLingua, cl.percentage as PrcentualeLingua
    from countrylanguage cl
    inner join country c on c.code = cl.CountryCode;



    ESERCIZIO 2:
    Si vuole recuperare dal database WORLD le nazioni e la percentuale della lingua più parlata tra le nazioni;

    select c.Name as NomeNazione, cl.Language as Lingua, cl.Percentage as Percentuale
    from Country AS c
    inner join CountryLanguage as cl on cl.CountryCode = c.Code
    where cl.Percentage = (select max(cl2.Percentage) from CountryLanguage as cl2 where cl2.CountryCode = c.Code);

    



    ESERCIZIO 3:
    Unire gli esercizi 1e2 facendole diventare subQuery per mostrare la lingua più parlata di una nazione con la percentuale;
    select c.Name as NomeNazione, 
    (
           select cl.Language
           from CountryLanguage cl
           where cl.CountryCode = c.Code
           order by cl.Percentage desc
           limit 1
       ) as LinguaNazionePiuParlata,
       (
           select max(cl2.Percentage)
           from CountryLanguage cl2
           where cl2.CountryCode = c.Code
       ) as Percentuale
    from Country c
    order by Percentuale desc;


    EXTRA:
        Per ogni continente, (mostra le 3 lingue più parlate in termini di popolazione totale), 
        considerando la popolazione di ogni nazione moltiplicata per la percentuale della lingua.
        (Usa Country e CountryLanguage / Calcola la popolazione che parla ogni lingua (Population * Percentage / 100) / 
        Usa subquery per ottenere il ranking per continente / Ordina i risultati per continente e popolazione decrescente 

    

    //USO DI CASE

    Esercizio1:
    scrivere e mostrare con JDBC una query che vada a prendere le
    nazioni mostrando come riposta 
    se hanno o meno una superfice di
    100.000 e se hanno registrato un IndepYear, se è presente l'anno va mostrato altrimenti si indica che non è presente;

    select c.Name as NomeNazione, 
    case
        when c.SurfaceArea > 100000 then 'Superficie maggiore di 100000' 
        else 'Non ha una superficie maggiore di 10000'
    end as Superficie,
    case
		when c.IndepYear is not null then IndepYear
        else 'Non ha un anno di indipendenza'
	end as AnnoDiIndipendenza
	from country c;


    Esercizio2:
    recuperare e mostrare le città con il codice della nazione che indica l'utente. Inoltre l'utente può decidere:
        l'ordine con cui ordinare le città in maniera decrescente o meno;
        se filtrare le città per un minimo di popolazione;
        se mostrare il nome della nazione a cui fa riferimento il code;

    select city.Name as NomeCittà,
    case
        when city.Population >= 80000 then country.Name
    end as NomeNazione
    from city
    inner join country on country.Code = city.CountryCode
    where city.CountryCode = 'AFG'
    order by city.Name desc;


    Creare una view di city del database world su una query che mostra le città italiane.
    Su questa VIEW eseguire una query che mostra solo le città con una popolazione inferiore ai 100k.

    create view CittàItaliane as
    select city.Name as Città, city.Population as Popolazione
    from city
    inner join country on country.Code = city.CountryCode
    where country.Name = 'Italy';

    select *
    from CittàItaliane
    where Popolazione < 100000;
*/