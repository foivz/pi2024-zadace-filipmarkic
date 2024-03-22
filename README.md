# Naziv projekta

## Podaci o studentu

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Filip Markić | fmarkic22@foi.hr | 0016157981 | filipmarkic


## Opis domene

## Specifikacija projekta

## Zadatak

## Resursi

Svi resursi nalaze se u mapi _Documentation_.

# Specifikacija korisničkih zahtjeva za Sustav upravljanja gradskim prijevozom
 ## Uvod

 ### Svrha
Svrha Software Requirements Specification (SRS) dokumenta je da precizno opiše funkcionalne i nefunkcionalne zahtjeve za softversko rješenje "AutobusniPuls", koje će digitalizirati poslovanje Gradskih autobusa Varaždin. Ovaj dokument namijenjen je čitateljima uključenima u proces razvoja, implementacije i održavanja aplikacije, uključujući programere, dizajnere, testere, menadžere projekta i klijente. Također, SRS dokument trebaju razumjeti i korisnici aplikacije, kao što su administrativni korisnici, dispečeri, osoblje korisničke podrške i putnici koji će koristiti aplikaciju za planiranje putovanja i pristup informacijama o javnom prijevozu. Glavni cilj SRS dokumenta je osigurati jasno definiranje zahtjeva kako bi se osigurala usklađenost između očekivanja korisnika i funkcionalnosti softverskog rješenja "AutobusniPuls", te olakšati proces razvoja, testiranja i implementacije aplikacije.

 ### Opseg 
Naziv softvera koji se čini prikladnim za ovaj projekt je "AutobusniPuls". "AutobusniPuls" će biti potpuno novo softversko rješenje za digitalizaciju poslovanja Gradskih autobusa Varaždin. Projekt obuhvaća širok spektar aktivnosti s ciljem unapređenja kvalitete usluge prijevoza putnika u gradu i prigradskim područjima. Ovaj softver će omogućiti precizno definiranje vozila i autobusnih stanica, praćenje lokacija autobusa u stvarnom vremenu te generiranje strukturiranih izvještaja o voznom parku, stanicama, linijama i voznom redu. Također, "AutobusniPuls" će pružati jasan prikaz autobusnih linija, voznog reda i procijenjenog vremena dolaska na autobusnim stanicama, kao i informacije putnicima o rutama, presjedanjima i procijenjenom vremenu putovanja do odredišta. Uvođenjem elektroničke prodaje karata putem kioska na autobusnim stanicama te automatiziranim očitavanjem karata pri ulasku u autobus, ovaj softver će ubrzati proces ukrcavanja putnika i omogućiti praćenje broja putnika u stvarnom vremenu. Međutim, važno je napomenuti da se "AutobusniPuls" neće baviti administrativnim ili financijskim poslovima tvrtke. Također, nije dio svrhe ovog softvera da se bavi radom vozača ili operatera autobusa, već će se fokusirati isključivo na digitalizaciju i optimizaciju operativnih procesa vezanih uz praćenje vozila, pružanje informacija putnicima i upravljanje poslovnim podacima relevantnim za javni prijevoz.

 ### Definicije, akronimi i skraćenice ///
SRS - Software Requirements Specification, dokument koji definira funkcionalne i nefunkcionalne zahtjeve softverskog sustava.
GPS - Global Positioning System, sustav za određivanje geografske lokacije koristeći satelite.
RFID - Radio-Frequency Identification, tehnologija koja omogućuje bežično prepoznavanje i praćenje objekata pomoću radio frekvencija.
UI - User Interface, sučelje koje omogućuje interakciju između korisnika i softverskog sustava. 
API - Application Programming Interface, sučelje koje omogućuje interakciju između različitih softverskih komponenti.
KPI - Key Performance Indicator, ključni pokazatelji performansi koji se koriste za mjerenje uspješnosti poslovanja.
Kiosk - Samoposlužni uređaj za obavljanje određenih funkcija poput prodaje karata ili pružanja informacija.
IoT - Internet of Things, koncept koji se odnosi na povezivanje fizičkih uređaja putem interneta radi razmjene podataka i kontrole.
GUI - Graphical User Interface, grafičko korisničko sučelje koje omogućuje interakciju putem grafičkih elemenata kao što su ikone, gumbi i prozori.

 ### Reference ///

 
### Struktura dokumenta 
Ostatak dokumenta daje pregled ključnih značajki proizvoda, korisničkih specifikacija i ograničenja. Dodatno, uključuje funkcionalne i nefunkcionalne zahtjeve kao i skice zaslona. Funkcionalni zahtjevi usmjereni su na značajke i ograničenja sustava, a svakom zahtjevu dodijeljen je jedinstveni identifikator. Za razliku od funkcionalnih zahtjeva, nefunkcionalni zahtjevi odnose se na izgled, performanse, vrijeme izvođenja i okruženje softvera, kao i na sigurnost i privatnost. Skice zaslona na kraju dokumenta pružaju vizualni prikaz funkcionalnosti između korisnika i softverskog rješenja. Skice zaslona izrađene su u wireframe-u. Cilj im je pružiti vizualni prikaz kako bi naš sustav trebao izgledati i opisati kako bi naša aplikacija trebala raditi.

## Općeniti opis
### Perspektiva proizvoda
Program “AutobusniPuls” inovativno je rješenje koje će transformirati rad gradskih autobusa u Varaždinu u svrhu poboljšanja kvalitete usluga javnog prijevoza. Od “AutobusniPulsa” se očekuje da značajno optimizira poslovanje tvrtke i osigura veću točnost i pouzdanost usluge. Uz trenutne zahtjeve, perspektiva proizvoda uzima u obzir buduće prilike za proširenje funkcionalnosti i integraciju s drugim sustavima. “AutobusniPuls” ima za cilj postati ključni alat za upravljanje javnim prijevozom, pružajući korisnicima intuitivno iskustvo putovanja, omogućujući tvrtki da zadrži visoke standarde kvalitete usluge. Ova proizvodna perspektiva čini temelj dugoročnog uspjeha “AutobusnogPulsea” kao ključnog čimbenika u modernizaciji i optimizaciji javnog prijevoza u gradu Varaždinu.

### Funkcija proizvoda 
Glavne funkcije sustava „AutobusniPuls“ koje bi htjeli integrirati su sljedeće:
1. Planiranje ruta - omogućuje korisnicima planiranje optimalnih ruta putovanja, uključujući prikaz različitih mogućnosti putovanja i procijenjeno vrijeme dolaska.
2. Praćenje lokacija autobusa u stvarnom vremenu - pruža mogućnost praćenja lokacije autobusa u realnom vremenu radi točnog informiranja putnika i optimizacije rasporeda vožnje.
3. Generiranje izvještaja - omogućuje generiranje strukturiranih izvještaja o voznom parku, stanicama, linijama i voznom redu radi olakšanog vođenja evidencije i donošenja poslovnih odluka.
4. Prikaz informacija na autobusnim stanicama - pruža jasan prikaz autobusnih linija, voznog reda i procijenjenog vremena dolaska autobusa na svakoj stanici radi informiranja putnika.
5. Informacije za putnike - pruža putnicima informacije o rutama, presjedanjima, procijenjenom vremenu putovanja do odredišta i sl., kako bi im olakšalo planiranje putovanja.
6. Elektronička prodaja karata - omogućuje putnicima elektroničku kupnju karata putem kioska na autobusnim stanicama radi ubrzanja procesa ukrcavanja.
7. Automatizirano očitavanje karata - osigurava automatizirano očitavanje karata putem čitača pri ulasku u autobus radi praćenja broja putnika u stvarnom vremenu.
8. Sustav za podršku korisnicima - pruža podršku korisnicima putem različitih kanala komunikacije poput telefona, e-pošte ili online chat-a radi rješavanja pitanja, pružanja informacija i rješavanja problema.
9. Sigurnosne značajke - uključuje sigurnosne značajke poput autentikacije korisnika, šifriranja podataka i zaštite od neovlaštenog pristupa radi osiguranja sigurnosti sustava i podataka korisnika.

### Karakteristike korisnika 
Karakteristike korisnika aplikacije “AutobusniPuls” razlikuju se ovisno o njihovoj ulozi i potrebama. Administrativni korisnici poput voditelja i dispečera Gradskih autobusa Varaždin trebaju pristup naprednim funkcijama sustava kako bi učinkovito upravljali poslovanjem i osigurali visokokvalitetne usluge prijevoza. Korisnici službe za korisnike trebaju alate za komunikaciju s putnicima i rješavanje njihovih pitanja. Putnici su glavni korisnici aplikacije i koriste intuitivno sučelje kako bi im olakšali planiranje putovanja, pregled voznih redova, kupnju karata i primanje obavijesti o promjenama usluge. Različite dobne skupine i tehničko znanje mogu utjecati na preferencije korištenja aplikacije. Stoga je važno osigurati responzivno i dostupno sučelje svim korisnicima. Umirovljenici ili osobe s posebnim potrebama mogu imati posebne zahtjeve u pogledu pristupačnosti, dok mlađi korisnici mogu preferirati značajke kao što su integracija s društvenim mrežama ili personalizirani sadržaj.

### Ograničenja 
Zahtjev pouzdanosti - softversko rješenje mora biti stabilno i mora izdržat velik broj korisnika u vremenu
Mobilna podrška – sustav mora sadržavati mobilnu podršku kako naši korisnici mogu „na putu“ provjeriti raspored autobusnih linija
Sigurnost podataka – pošto se kupnja karata odvija online (bar dio), sustav mora bit siguran kako ne bi došlo do krađe bankovnih podataka ili identiteta
Prilagodljivost promjenama u infrastrukturi / prometu – ukoliko dođe do promjene u stajalištima ili rasporedu, mora bit sposoban brzim promjenama bez velikih poteškoća, mora bit prilagodljiv
Mora se uzeti u obzir kako ovaj sustav mogu koristiti osobe s slabom tehnološkom pismenošću ili umirovljenici ili djeca te mora bit jednostavan

### Pretpostavke i ovisnosti
Kao što je navedeno pod ograničenja, moramo pretpostaviti da će se u budućnosti mijenjati autobusne linije, stanice i rasporedi te sustav mora biti prilagodljiv te se brzo ažurirati ukoliko dođe to takvih promjena. Također može doći do ažuriranja podataka ukoliko dođe do kvara autobusa ili nemogućnost vozača.  Ukratko naš softver ovisi o API-ju te ćemo morati ažurirati sustav ukoliko dođe do promjene API-ja.

### Ostalo
Naš sustav bi trebao voditi evidenciju trenutnih putnika u autobusu. Svaki puta kada putnika skenira svoju kartu povećava se broj putnika no nije osmišljeno kako bi se evidentiralo ako je putnik izašao iz autobusa.  

## Funkcionalni zahtjevi 

Identifikator|FZ-1
-------------|----
Zahtjev|Korisnici će imati pravo stvoriti korisnički račun unutar aplikacije
Obrazloženje|Omogućavanje korisničko računa unutar aplikacije osigurava personalizirano iskustvo korisnika i olakšava upravljanje njihovim podacima i postavkama
Način provjere|Funkcionalnost stvaranja korisničkog računa bit će testirana provjerom mogućnosti korisnika da uspješno stvore računa te pristupe svojim podacima
Prioritet[1-5]|1
Izvor/porijeklo|

Identifikator|FZ-2
-------------|----
Zahtjev|Korisnici će moći izvršiti kupnju karata unutar aplikacije
Obrazloženje|Omogućavanje kupnje karata unutar aplikacije pruža korisnicima praktičan način rezervacije i osigurava glatko iskustvo korištenja usluge javnog prijevoza
Način provjere|Provjera će se obaviti kroz simulaciju procesa kupnje karata unutar aplikacije kako bi se osiguralo ispravno funkcioniranje sustava
Prioritet[1-5]|1
Izvor/porijeklo|Direktor društva Autobusni prijevoz

Identifikator|FZ-3
-------------|----
Zahtjev|Korisnicima je omogućen pregled detalja o autobusnim stanicama poput lokacije na karti, naziva stanice i pripadajućih autobusnih linija
Obrazloženje|Omogućavanje pregleda detalja o autobusnim stanicama korisnicima olakšava planiranje ruta putovanja i pruža im važne informacije o dostupnim linijama i lokacijama stanica
Način provjere|Funkcionalnost pregleda detalja o autobusnim stanicama bit će testirana kroz provjeru korisničkog sučelja aplikacije, osiguravajući da korisnici mogu lako pristupiti potrebnim informacijama
Prioritet[1-5]|3
Izvor/porijeklo|Direktor društva Autobusni prijevoz

Identifikator|FZ-4
-------------|----
Zahtjev|Korisnicima će biti omogućen pregled trenutne lokacije autobusa u stvarnom vremenu na karti
Obrazloženje|Omogućavanje pregleda trenutne lokacije autobusa korisnicima olakšava praćenje dolaska autobusa na određenu stanicu i planiranje putovanja
Način provjere|Funkcionalnost pregleda lokacije autobusa bit će testirana kroz simulaciju stvarnih situacija praćenja autobusa, kako bi se osigurala točnost prikaza lokacije
Prioritet[1-5]|4
Izvor/porijeklo|Uprava Autobusnog prijevoza

Identifikator|FZ-5
-------------|----
Zahtjev|Sustav će automatski slati korisnicima obavijesti o kašnjenju autobusa
Obrazloženje|Automatsko slanje obavijesti o kašnjenju autobusa korisnicima pruža praktičan način obavještavanja, olakšavajući im planiranje putovanja bez potrebe za aktivnim ulaskom u aplikaciju
Način provjere|Funkcionalnost automatskog slanja obavijesti bit će testirana kroz simulaciju različitih scenarija kašnjenja, provjeravajući pouzdanost i pravovremenost dostave obavijesti
Prioritet[1-5]|5
Izvor/porijeklo|xxx

Identifikator|FZ-6
-------------|----
Zahtjev|Administratorima će biti omogućeno definiranje novih tarifnih zona, uključujući unos informacija o cijenama karata, posebnim popustima ili tarifama
Obrazloženje|Omogućavanje administratorima da definiraju nove tarifne zone olakšava prilagodbu cijena karata i upravljanje posebnim tarifama, što doprinosi fleksibilnosti i pravednosti sustava naplate
Način provjere|Definiranje novih tarifnih zona zona bit će testirana provjerom mogućnosti administatora da uspješno unesu i ažuriraju informacije o tarifama
Prioritet[1-5]|2
Izvor/porijeklo|xxx

Identifikator|FZ-7
-------------|----
Zahtjev|Administratorima će biti omogućeno upravljanje korisničkim računima, što uključuje dodavanje novih korisničkih računa za zaposlenike ili druge ovlaštene osobe s pristupom sustavu
Obrazloženje|Omogućavanje administratorima da upravljaju korisničkim računima olakšava kontrolu pristupa sustavu i osigurava sigurnost te učinkovito upravljanje korisnicima
Način provjere|Funkcionalnost upravljanja korisničkim računima bit će testirana provjerom mogućnosti administratora da uspješno dodaju, uređuju i brišu korisničke račune
Prioritet[1-5]|3
Izvor/porijeklo|xxx

Identifikator|FZ-8
-------------|----
Zahtjev|Aplikacija će omogućiti generiranje izvještaja o kašnjenjima autobusa, pružajući informacije o trajanju kašnjenja i njihovim uzrocima
Obrazloženje|Omogućavanje generiranja izvještaja o kašnjenjima autobusa pruža uvid u performanse sustava javnog prijevoza, olakšavajući identifikaciju problema i donošenje odluka za poboljšanje
Način provjere|Funkcionalnost generiranja izvještaja o kašnjenjima autobusa bit će testirana provjerom mogućnosti sustava da automatski generira detaljne izvještaje na zahtjev korisnika
Prioritet[1-5]|4
Izvor/porijeklo|xxx

Identifikator|FZ-9
-------------|----
Zahtjev|Aplikacija će omogućiti generiranje izvještaja o putničkim statistikama za određeni vremenski period, uključujući informacije o broju putnika po liniji, najfrekventnijim stanicama i prosječnoj popunjenosti autobusa
Obrazloženje|Generiranje izvještaja o putničkim statistikama omogućuje analizu korištenja javnog prijevoza, pružajući relevantne podatke za planiranje i poboljšanje usluga
Način provjere|Funkcionalnost generiranja izvještaja o putničkim statistikama bit će testirana provjerom mogućnosti sustava da automatski generira detaljne izvještaje za željeni vremenski period
Prioritet[1-5]|3
Izvor/porijeklo|xxx

Identifikator|FZ-10
-------------|----
Zahtjev|Aplikacija će prikazivati prosječan broj putnika koji koriste svaku autobusnu liniju tijekom određenog vremenskog razdoblja
Obrazloženje|Prikaz prosječnog broja putnika po autobusnoj liniji omogućuje analizu opterećenosti pojedinih linija i prilagođavanje kapaciteta prema potrebama korisnika
Način provjere|Funkcionalnost prikaza prosječnog broja putnika po autobusnoj liniji bit će testirana provjerom mogućnosti sustava da točno izračuna prosječan broj putnika za svaku liniju u željenom vremenskom razdoblju
Prioritet[1-5]|3
Izvor/porijeklo|xxx

Identifikator|FZ-11
-------------|----
Zahtjev|
Obrazloženje|
Način provjere|
Prioritet[1-5]|2
Izvor/porijeklo|xxx

### Dinamika realizacije zahtjeva ///petak


## Nefunkcionalni zahtjevi ///petak
### Izgled softvera ///petak
### Upotrebljivost softvera ///petak
### Perfomanse softvera ///petak
### Izvođenje softvera i okruženje ///petak 
### Sigurnost i privatnost ///petak
### Ostalo ///petak 
## Skice zaslona ///petak 
***





