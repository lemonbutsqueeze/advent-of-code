﻿namespace AdventOfCode

module Main =

    open AdventOfCode.Days

    [<EntryPoint>]
    let main argv =
        let day1 = Day1.Day.Day1("Days\Day1\input.txt")
        (day1 :> DataStructure.IAdventDay).PrintResults

        let day2 = Day2.Day.Day2("Days\Day1\input.txt")
        (day2 :> DataStructure.IAdventDay).PrintResults


        0