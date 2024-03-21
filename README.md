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
1. Planiranje ruta: Omogućuje korisnicima planiranje optimalnih ruta putovanja, uključujući prikaz različitih mogućnosti putovanja i procijenjeno vrijeme dolaska.
2. Praćenje lokacija autobusa u stvarnom vremenu: Pruža mogućnost praćenja lokacije autobusa u realnom vremenu radi točnog informiranja putnika i optimizacije rasporeda vožnje.
3. Generiranje izvještaja: Omogućuje generiranje strukturiranih izvještaja o voznom parku, stanicama, linijama i voznom redu radi olakšanog vođenja evidencije i donošenja poslovnih odluka.
4. Prikaz informacija na autobusnim stanicama: Pruža jasan prikaz autobusnih linija, voznog reda i procijenjenog vremena dolaska autobusa na svakoj stanici radi informiranja putnika.
5. Informacije za putnike: Pruža putnicima informacije o rutama, presjedanjima, procijenjenom vremenu putovanja do odredišta i sl., kako bi im olakšalo planiranje putovanja.
6. Elektronička prodaja karata: Omogućuje putnicima elektroničku kupnju karata putem kioska na autobusnim stanicama radi ubrzanja procesa ukrcavanja.
7. Automatizirano očitavanje karata: Osigurava automatizirano očitavanje karata putem čitača pri ulasku u autobus radi praćenja broja putnika u stvarnom vremenu.
8. Sustav za podršku korisnicima: Pruža podršku korisnicima putem različitih kanala komunikacije poput telefona, e-pošte ili online chat-a radi rješavanja pitanja, pružanja informacija i rješavanja problema.
9. Sigurnosne značajke: Uključuje sigurnosne značajke poput autentikacije korisnika, šifriranja podataka i zaštite od neovlaštenog pristupa radi osiguranja sigurnosti sustava i podataka korisnika.

### Karakteristike korisnika 
Karakteristike korisnika aplikacije “AutobusniPuls” razlikuju se ovisno o njihovoj ulozi i potrebama. Administrativni korisnici poput voditelja i dispečera Gradskih autobusa Varaždin trebaju pristup naprednim funkcijama sustava kako bi učinkovito upravljali poslovanjem i osigurali visokokvalitetne usluge prijevoza. Korisnici službe za korisnike trebaju alate za komunikaciju s putnicima i rješavanje njihovih pitanja. Putnici su glavni korisnici aplikacije i koriste intuitivno sučelje kako bi im olakšali planiranje putovanja, pregled voznih redova, kupnju karata i primanje obavijesti o promjenama usluge. Različite dobne skupine i tehničko znanje mogu utjecati na preferencije korištenja aplikacije. Stoga je važno osigurati responzivno i dostupno sučelje svim korisnicima. Umirovljenici ili osobe s posebnim potrebama mogu imati posebne zahtjeve u pogledu pristupačnosti, dok mlađi korisnici mogu preferirati značajke kao što su integracija s društvenim mrežama ili personalizirani sadržaj.

### Ograničenja 
Zahtjev pouzdanosti - Softversko rješenje mora biti stabilno i mora izdržat velik broj korisnika u vremenu
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
Zahtjev|Korisnici će imati pravo kreirati svoj račun te odabrati svoj status (umirovljenik, student...)
Obrazloženje|Ovisno je li korisnički račun od putnika ili zaposlenika, korisnik će imati različite funkcije
Način provjere|Zaposlenici će imati drugačije sučelje sa drugačijim funkcijama od putnika i njihovih računa
Prioritet[1-5]|1
Izvor/porijeklo|Direktor društva Autobusni prijevoz

Identifikator|FZ-2
-------------|----
Zahtjev|Pregled/definiranje voznih linija, stanica ovisno o korisničkom računu
Obrazloženje|Zaposlenici će moći definirati/ažurirati vozne linije i stanice dok će putnici moći pregledati ih
Način provjere|Zaposlenik će imati opciju edit dok će putnik imati opciju sort i filter
Prioritet[1-5]|1
Izvor/porijeklo|Direktor društva Autobusni prijevoz

Identifikator|FZ-3
-------------|----
Zahtjev|Pregled/definiranje rasporeda
Obrazloženje|Zaposlenici može dodavati rasporede buseva (polazak, dolazak, stajanja...) dok će putnici samo pregledavati te rasporede
Način provjere|Zaposlenici će imati opciju edit, dok će putnik imati opciju sort i filter
Prioritet[1-5]|1
Izvor/porijeklo|Direktor društva Autobusni prijevoz

Identifikator|FZ-4
-------------|----
Zahtjev|Strukturiran ispis
Obrazloženje|Zaposlenici imaju opciju ispisati sve prikupljene podatke za pojedina stajališta, linije i sl.
Način provjere|Zaposlenik će birati opciju ispis te će odabrati podatke koje žele da se ispišu
Prioritet[1-5]|2
Izvor/porijeklo|Uprava Autobusnog prijevoza

Identifikator|FZ-5
-------------|----
Zahtjev|xxx
Obrazloženje|xxx
Način provjere|xxx
Prioritet[1-5]|xxx
Izvor/porijeklo|xxx

Identifikator|FZ-6
-------------|----
Zahtjev|xxx
Obrazloženje|xxx
Način provjere|xxx
Prioritet[1-5]|xxx
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





