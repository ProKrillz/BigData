# BigData

## Description

This project is for shcool.

Call API (https://confluence.govcloud.dk/display/FDAPI), map data and save on sql database.

Technologies: 
* <a href="https://learn.microsoft.com/en-us/dotnet/csharp/" target="_blank">C#</a>
* <a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads" target="_blank">SQL</a>
 * <a href="https://learn.microsoft.com/en-us/ef/core" target="_blank">EF core</a>

## Requirements

* <a href="https://code.visualstudio.com/" target="_blank">Visual Studio IDE</a> (recommend Code) to compile
* <a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads" target="_blank">Microsoft SQL</a>

## Api documentation

Station documentation 
https://confluence.govcloud.dk/pages/viewpage.action?pageId=41717704

Parameter documentation
https://confluence.govcloud.dk/pages/viewpage.action?pageId=26476616

## Todo

Struct database for repeated data.

Create entity for stations and Fk in propeties

Create entity for parameter and Fk in propeties

Some data updates twize a day, some every hours and most every 10 min and program safe data every 10 min so make so it skips hour data and twize data when its in database.
