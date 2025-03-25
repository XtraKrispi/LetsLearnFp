module TypeProviders

open FSharp.Data

[<Literal>]
let pokeApiBaseUrl = "https://pokeapi.co/api/v2/" // pokemon/ditto"

type PokemonApi = JsonProvider<"https://pokeapi.co/api/v2/pokemon/ditto">


let getPokemonInfo pokemonName =
    async {
        let! results = PokemonApi.AsyncLoad $"{pokeApiBaseUrl}pokemon/{pokemonName}"
        return results.Moves |> Array.map (fun move -> move.Move.Name)
    }

type MyCsv = CsvProvider<"/Users/mgold/Downloads/2025-03-11-securable-activity-log (1).csv">

let blah () =
    let x =
        MyCsv.Load "/Users/mgold/Downloads/2025-03-11-securable-activity-log (1).csv"

    x.Rows |> Seq.map (fun row -> row.Timestamp)



















// open FSharp.Data.Sql

// type Schema =
//     SqlDataProvider<
//         Common.DatabaseProviderTypes.POSTGRESQL,
//         "Server=127.0.0.1;Port=5432;Database=blog;User Id=postgres;",
//         UseOptionTypes=Common.NullableColumnType.OPTION
//      >

// let ctx = Schema.GetDataContext()

// let authorEmails () =
//     query {
//         for a in ctx.Public.Authors do
//             for p in a.``public.posts by author_id`` do
//                 select (a, p)
//     }
//     |> Seq.toList
