# statsbomb

Linq queries against statsbomb data in C#
See https://statsbomb.com/
See https://github.com/statsbomb/open-data

Premise:
We wanted to run some queries across the data provided in statsbomb. Specifically around xG (expected goals)

So looking at the json in the events directory we query each match (json file) for all the shots, all the shots that result in goals and all the shots xG rating accoording to statsbomb.

As a twist we devised 8 zones in one half of the pitch (locations on the pitch), categoried each of the data points into the zones

Project consists:
Command Line program to make the queries and kick things off
Library which provides the data modelling of the statsbomb Events (used https://json2csharp.com/ to help with this), as well as the code to read the event json files.
