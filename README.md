# Blazor

Blazor on Microsofti loodud veebiraamistik. See võimaldab arendajatel luua täisrakendusi (front-end ja back-end), kasutades C# keelt. See tähendab, et nii serveri infrastruktuur kui ka kliendipoolne kood on ehitatud ühes keeles ning ühendatud ühe koodibaasina. Ühtegi rida JavaScript'i ei ole vaja, sest Blazori kood on kompileeritud WebAssembly'isse [[1]](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0).

Blazor on väga sarnane teiste levinud ja kaasaegsete SPA (Single-Page-Application) raamistikega, nagu React, Vue ja Svelte. See võimaldab arendajatel luua komponente korduvkasutatavuse ja paindlikkuse tagamiseks, kasutades samal ajal ära WebAssembly'i kaasaegset võimsust ja potentsiaalset kiirust.

## Miks valida Blazor?

Kui on valik näiteks tavalise JavaScriptil põhineva raamistiku vastu või Blazor WebAssembly, siis nende eelised on järgmised:

### Blazori eelised

- Täispinu (full-stack) arendus: Blazor WebAssembly võimaldab kasutada sama keelt terves projektis, mis võib viia järjepidevama ja tõhusama arendusprotsessini. **See ei kehti, kui serveripoolse loogikaks on kasutusele võetus NodeJS/Express, Next.js, SvelteKit vms, kus peamiseks keeleks on JavaScript/TypeScript.**

- Tugeva tüübisüsteemiga keel: Kui võrrelda JavaScripiga, siis C# on enamasti palju turvalisem arenduskeel oma tüübi süsteemi tõttu. Tugev tüübisüsteem ei lase arendajal kompileerida koodi vigaste tüüpidega. **JavaScriptis aitab sel juhul TypeScript, kuid TypeScript-i tüübi süsteem on endiselt liigselt nõrk võrreldes C#-iga** 

 - .NET-i ja C# tundmine: kui meeskond on juba tuttav .NET-i raamistikuga ja C#-ga, võib Blazor WebAssembly olla loomulikum valik, kuna see võimaldab olemasolevaid teadmisi ja oskusi kasutada. **Küll aga tööturul on tohutult palju rohkem tavaliste JS raamistike spetsialiste, millest oleksid ilma jäänud.**

- Parem jõudlus: kuna Blazor WebAssembly töötab WebAssembly-ga, saab see ära kasutada brauseris omakoodi (native code) käitamisega kaasnevaid jõudluse eeliseid. **Tänapäeval see eelis ei ole veel nii tõsi, kuna WebAssembly ei saa veel DOM-i ise genereerida ning tihtipeale on ka aeglasem.**

- Arvamuslik struktuur: Blazor WebAssembly järgib kindlat failistruktuuri ning kasutab Razori lehti ja Razori komponente, mis võivad olla abiks rakenduse selge struktuuri loomisel. **Arvamuslik struktuur on vajadusel leitud ka teistes JS veebiraamistikes, näiteks Angular.**

### JavaScripti raamistikude eelised (nt Svelte või React vms)

- See on standartne: JavaScript veebiraamistikel on suured ja aktiivsed kogukonnad - saadaval on palju ressursse, teeke ja tööriistu. Väljakujunenud on suured ja küpsed raamistikud, mis on laialdaselt kasutusele võttud. See võib hõlbustada levinud probleemidele lahenduste leidmist ja vajaduse korral abi saamist.

- Tugev arendajate baas: JavaScript veebiraamistikega tegelevate arendaja kogus on kümmendkord suurem, kui C#, ning veelgi suurem spetsiifiline raamistik nagu Blazor. See võib lihtsustada vajalike oskustega arendajate leidmist.

- JavaScript'i tundmine: React, Svelte, Vue vms võib olla loomulikum valik, sest see võimaldab kasutada olemasolevaid teadmisi ja oskusi.

- Kuna Blazor tuleb koos minifitseeritud .NET käivituskeskkonnage kaasa, siis rakenduse suurus on tihtipeale kordades kõrgem, kui tavalisel JavaScript rakendusel. See tähendab, et algne laadimine võib olla aeglane.

## Võrdlus React.js-iga

Kuna React.js on juba pikemat aega kõige populaarsem veebirakendus veebiliideste loomiseks [[2]](https://insights.stackoverflow.com/trends?tags=reactjs%2Cvue.js%2Cangular%2Csvelte%2Cangularjs%2Cvuejs3), on õiglane seda lühidalt võrrelda Blazoriga.

Blazor WebAssembly ja React on mõlemad veebirakenduste loomise raamistikud, kuid neil on mõned olulised erinevused nende toimimises ja komponentide rakendamises.

Kõige suurem peamine erinevus on kasutatavad programmeerimiskeeled. Blazor WebAssembly on üles ehitatud .NET-i raamistikule ning kasutab komponentide jaoks C#-d ja Razorit, samas kui React kasutab komponentide jaoks JavaScripti ja JSX-i. Kui just ei ole kasutatud TypeScript, siis JavaScript on üldiselt nõrgem ja ohtlikum keel oma dünaamiliste tüüpide pärast.

Lisaks kasutab React komponentide jälgimiseks ja värskendamiseks **virtuaalset DOM-i**, samas kui Blazor WebAssembly kasutab sarnast mehhanismi nimega **RenderTree**. [[3]](https://blazor-university.com/components/render-trees/)

Vaikimisi Blazor on väga arvamuslik (opinionated) oma failistruktuuriga, samas kui React on paindlikum ja sellel pole konkreetset failistruktuuri. See kõik on aga konfigureeritav ning ülhjuhul sõltub arendusmeeskonna kokkulepetest.

Süntaktiliselt nad on väga erinevad, kuid põhimõtte on väga sarnane:

```csharp
// Blazor
<div>
    <p>The message is: @message</p>
</div>

@code {
    [Parameter]
    private string message { get; set; } = "Hello, World!";
}
```

```jsx
// React
import React from 'react';

function Message({message}) {
    message = 'Hello, World!'

    return (
        <div>
            <p>The message is: {message}</p>
        </div>
    );
}

export default Message;
```

## Elukestvus ja ebakindlus

Microsoft on kunagi loonud ka teisi veebiraamistike nagu Silverlight. Silverlight oli omal ajal väga populaarne ning aitas arendajatel lisada veebilehtedele dünaamilisust, animatsioone ja paremaid video esitluste võimalust - sarnane nagu Adobe Flash. Nii Flashi kui ka Silverlight kasutus arenduses vähenes, kui nende asemele tuli uus HTML5 standart [[4]](https://www.digitaltrends.com/computing/what-is-microsoft-silverlight/).

Silverlighti tugi ja arendus on nüüdseks ajaks lõpetatud. [[5]](https://support.microsoft.com/en-us/windows/silverlight-end-of-support-0a3be3c7-bead-e203-2dfd-74f0a64f1788). See tekitab järgmise küsimuse - kas Blazor on lihtsalt nišš ning mis on Blazori pikaajaline perspektiiv, vaadates tema eelkäija ajalugu?

Blazor on suhteliselt noor ning esimesed versioonid ilmusid aastal 2018 [([6]](https://devblogs.microsoft.com/dotnet/get-started-building-net-web-apps-in-the-browser-with-blazor/). Võrreldes näiteks Silverlightiga, siis Blazor on loodud avatud standardite põhjal nagu WebAssembly, mis ei ole ainulaadselt Microsofti kontrolli all ja on paigaldatud kõikides levinud brauserites [[7]](https://developer.mozilla.org/en-US/docs/WebAssembly). Silverlight oli aga piiratud standard ning arendada oli ainult võimalik läbi Microsoft Windowsi. Nii Silverlight kui ka Adobe vajasid kasutajapoolset installeerimist, et veebirakendused töötaksid - see tekitas ebamugavusi kasutajatele ning lisas lisaetappi rakenduse kasutamiseks.

Blazori kasutab enda süntaksis Razor Pages, mis eksisteerib juba aastast 2010 ning sama formaat on üle viidud ka Blazorile. See võib viitada sellele, et Microsoft on pühendunud sarnase süsteemiga jätkama ka edaspidi.



# Paigaldus

Näidisprojekti paigalduseks oli kasutatud JetBrains Rider IDE, kuid võimalik on kasutada ka teised IDE'd, kus Blazor on tugevalt toetatud ning uue projektina ilmub samasugune näidisprojekt, nagu Visual Studios.

## 1. Paigalda .NET 7+

Installeeri kõige uuem .NET Core raamistiku vastavalt oma operatsioonisüsteemile: https://dotnet.microsoft.com/en-us/download

Uuemad .NET versioonid toetavad arendust nii Mac kui ka Linux süsteemidele.

## 2. Paigalga Rider või Visual Studio

Microsoft soovitab Blazori arenduseks kasutada Visual Studio.

Linuxi ja Maci kasutajate jaoks on võimalik kasutada JetBrains Rider, mis on võimas arenduse IDE.

## 3. Kompileeri & käivita

IDE avades vali uue **Blazor WebAssembly App**-i. Seejärel kompileeri ning käivita rakendust.

Konsooli tuleb kirje `http://localhost:PORT`. Ava link brauseris ning ette tuleb lühike näidisrakendus, mis näitab paar Blazori põhifunktsionaalsust, nagu oleku muutmine (state management), marsruutimine ja HTTP päringud.

# Blazori analüüs ja põhimõted näidisprojekti baasil

## Failistruktuur

### **Program.cs**

Blazor WebAssembly (WASM) rakenduse `Program.cs` fail on rakenduse sisenemispunkt (entry-point). See vastutab rakenduse konfigureerimise ja käivitamise eest. Siin määratakse ka juurkomponenti.

Lisaks, ta võimaldab konfigureerida ka muid rakenduse aspekte, nagu logimine, vahemälu ja marsruutimine.

### **App.razor**

`App.razor` fail on rakenduse juurkomponent. See toimib rakenduse teiste komponentide ja lehekülgede konteinerina ning vastutab rakenduse üldise paigutuse ja struktuuri haldamise eest.

Lähenemine peaks olema väga sarnane ning tuttav teiste tradistriooniliste SPA veebiraamistike kasutajate jaoks, nagu React raamistikus on tavaliselt `App.tsx` juurkomponent.

### **wwwroot**

Kataloog sisaldab kliendipoolsed failid (CSS, pildid, andmed), mida serveeritakse brauseris või PWA-na.

`index.html` - standartne HTML fail, mis käivitab rakendust ning laadib kompileeritud JS/WASM failid.

Juhul, kui näidisprojektis on ka PWA (Progressive Web App) toetus, tuleb juurde veel paar faili:

`manifest.json` - on lihtne konfiguratsiooni fail, mis annab väikse ülevaade antud rakendusest ning annab võimalust rakendust käivitada PWA-na. See ei ole Microsofti spetsiifiline fail, vaid on üks PWA standarditest. PWA

`service-worker.js` - ütleb, kuidas PWA peaks käsitlema HTTP päringuid.

Loe rohkem: 
- https://developer.mozilla.org/en-US/docs/Mozilla/Add-ons/WebExtensions/manifest.json
- https://developer.mozilla.org/en-US/docs/Web/Manifest

### **Pages**

Blazor rakenduse `Pages` kataloog on lehekülgede organiseerimiseks kasutatav konventsioon ning Blazori puhul on iga lehekülg esindatud Razori komponendina.

### **Shared**

 Blazor rakenduse `Shared` kataloog on samuti konventsioon, et selles kataloogis hoitakse Razor komponente, mida jagavad mitu lehekülge või komponenti. Neid komponente kasutatakse sageli ühiste kasutajaliidese elementide, näiteks navigatsioonimenüüd või sisendelementide jaoks.

## Razor lehed (.razor failid)

Blazoris kasutatakse Razori komponente veebilehe kasutajaliidese määratlemiseks. Razori süntaks on C#-koodi ja HTML-märgistuse kombinatsioon, mis määratleb veebilehe konkreetse osa paigutuse ja käitumise. See võimaldab luua dünaamilisi veebilehti, mis võivad reageerida kasutaja sisendile ja kuvada andmeid andmebaasist.

### Süntaks
Razori lehekülgede põhiline süntaks hõlmab "@" sümboli kasutamist, mis näitab, et järgmine kood on C#. Näiteks muutuja kuvamiseks Razori lehel kasutate sümbolit "@", millele järgneb muutuja nimi, näiteks nii:

```less
<p>Hello, @username!</p>
```

Saab kasutada ka sümbolit "@", et lisada tingimuslauseid HTML-i, näiteks nii:
```less
@if (showWelcome) {
    <p>Welcome, @username!</p>
}
```

Razor pakub ka mitmeid sisseehitatud funktsioone ja direktiive, näiteks `@model` ja `@page`, mida saab kasutada lehe käitumise ja kujunduse määratlemiseks.

```less
@page "/welcome"
@model WelcomeModel
```

Razorit saab kasutada ka tsüklite loomiseks, näiteks nii:
```less
<ul>
    @foreach (var item in Model.Items) {
        <li>@item.Name</li>
    }
</ul>
```

Loe rohkem: 
- https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0
- https://learn.microsoft.com/en-us/aspnet/core/blazor/project-structure?view=aspnetcore-7.0

## Valmis projekti optimeerimine

Kui projekt on valmis, selle saab kompileerida optimeeritud kujul järgmiselt:

```bash
dotnet build -c Release
dotnet publish -c Release
```

Projekt on nüüd optimeeritud selleks, et elada veebis - rakendatud on kiiruse ja faili suuruse optimisatsioonid.


## Näidisprojekt

    `example` kataloogis on selle õpetuse raames valminud moodulrepositoorium, kus asub lihtne näidisprojekt. Näidisprojekt ühendab nii serveri kui ka front-end koodibaasi üheks. Läbi selle saab aimu Blazori rakenduse struktuurist (juhul, kui API pool on samas projektis) ning üldehitusest.

Näidisprojekt sisaldab:
- Blazori kasutamine näided ja koodijuppid
- Kuidas jagada sama koodibaasi (nt jagatud tüübid/klassid)
- Kuidas teha lihtsad CRUD (Create, Read, Update, Delete) operatsioone
- Erinevad Razor komponentide näited
- JavaScript funktsioonide väljakutsumine läbi C#.

Terve hulk näiteid on saadaval ka läbi [awesome-blazor](https://github.com/AdrienTorris/awesome-blazor#real-world-applications) GitHub repositooriumist.

# Allikad

1. https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0
2. https://insights.stackoverflow.com/trends?tags=reactjs%2Cvue.js%2Cangular%2Csvelte%2Cangularjs%2Cvuejs3
3. https://blazor-university.com/components/render-trees/
4. https://www.digitaltrends.com/computing/what-is-microsoft-silverlight/
5. https://support.microsoft.com/en-us/windows/silverlight-end-of-support-0a3be3c7-bead-e203-2dfd-74f0a64f1788
6. https://devblogs.microsoft.com/dotnet/get-started-building-net-web-apps-in-the-browser-with-blazor/
7. https://developer.mozilla.org/en-US/docs/WebAssembly
