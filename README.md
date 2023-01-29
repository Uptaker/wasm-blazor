# Blazor

Blazor on Microsofti loodud veebiraamistik. See võimaldab arendajatel luua täisrakendusi (front-end ja back-end), kasutades C# keelt. See tähendab, et nii serveri infrastruktuur kui ka kliendipoolne kood on ehitatud ühes keeles ning ühendatud ühe koodibaasina. Ühtegi rida JavaScript'i ei ole vaja, sest Blazori kood on kompileeritud WebAssembly'isse.

Blazor on väga sarnane teiste levinud ja kaasaegsete SPA (Single-Page-Application) raamistikega, nagu React, Vue ja Svelte. See võimaldab arendajatel luua komponente korduvkasutatavuse ja paindlikkuse tagamiseks, kasutades samal ajal ära WebAssembly'i kaasaegset võimsust ja potentsiaalset kiirust.

## Paigaldus

Näidisprojekti paigalduseks oli kasutatud JetBrains Rider IDE, kuid võimalik on kasutada ka teised IDE'd, kus Blazor on tugevalt toetatud ning on samasugune näidisprojekt, nagu näiteks Visual Studio.

### 1. Paigalda .NET 7+

Installeeri kõige uuem .NET Core raamistiku vastavalt oma operatsioonisüsteemile: https://dotnet.microsoft.com/en-us/download

Uuemad .NET versioonid toetavad arendust nii Mac kui ka Linux süsteemidele.

### 2. Paigalga Rider või Visual Studio

Rider on väga hea JetBrains'i poolt loodud C# IDE, mis toetab ka erinevad Linux distributsioone.

### 3. Kompileeri & käivita

IDE avades vali uue **Blazor WebAssembly App**-i. Seejärel kompileeri ning käivita rakendust.

Konsooli tuleb kirje `http://localhost:PORT`. Ava link brauseris ning ette tuleb lühike näidisrakendus, mis näitab paar Blazori põhifunktsionaalsust, nagu oleku muutmine (state management), marsruutimine ja HTTP päringud.

## Näidisprojekti analüüs TODO

TODO Razor pages, file structure, examples compared with other frameworks maybe?

## Uus projekt TODO
