# BigData

This project is for shcool.

## Description

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

## Storage

One api call save around 0,650 MB

## Todo

Struct database for repeated data.

* Create entity for stations and Fk in propeties

* Create entity for parameter and Fk in propeties

* Create new entity for cordinate where you just FK to GeometryEntity so we dont dublicate data

* Create entity for type and Fk to all entity with type

* Create entity for rel and Fk in link

* Some data updates twize a day, some every hours and most every 10 min and program safe data every 10 min so make so it skips hour data and twize data when its in database.

Mapping

* Create new mapping after database struct is done

## ErDiagram

![image](https://github.com/ProKrillz/BigData/assets/93183911/73fdf035-dbde-4d49-9ce1-80b5db01a0b6)
