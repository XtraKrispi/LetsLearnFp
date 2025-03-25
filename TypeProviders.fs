module TypeProviders

[<Literal>]
let pokeApiBaseUrl = "https://pokeapi.co/api/v2/" // pokemon/ditto"























open FSharp.Data.Sql

type Schema =
    SqlDataProvider<
        Common.DatabaseProviderTypes.POSTGRESQL,
        "Server=127.0.0.1;Port=5432;Database=blog;User Id=postgres;",
        UseOptionTypes=Common.NullableColumnType.OPTION
     >

let ctx = Schema.GetDataContext()

let authorEmails () =
    query {
        for a in ctx.Public.Authors do
            select a
    }
    |> Seq.toList
