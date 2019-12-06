namespace AdventOfCode.Days

open System
open System.IO
open AdventOfCode.AdventDay

module evaluation =
    let calculateFuel (mass : int) : int =
        int(Math.Floor(float(mass / 3))) - 2

    let readInput filePath = seq<int> {
        for line in File.ReadLines filePath do
            yield int line }

    type Day1' =
        interface IAdventDay with
            member __.Result =
                readInput("input.txt")
                |> Seq.sumBy(calculateFuel)