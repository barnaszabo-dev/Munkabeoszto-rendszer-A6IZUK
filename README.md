C# programnyelven Munkabeosztó rendszer feladat 

IMunkaraAlkalmas Interface: Ez az interface azoknak az entitásoknak a deklarációját tartalmazza, amelyek alkalmasak valamilyen munka elvégzésére. Tartalmazza a dolgozó nevét, azonosítóját, munkadíját, terhelését, teherbírását és eldönti, hogy még terhelhető-e. Valamint tartalmazza a dolgozó feladatköreit is. 
FeladatKor Osztály: Ez a osztály a különböző feladatokat reprezentálja, mint például a megnevezést és a munkaidőt. 
MunkaCsoport Osztály: Ebben az osztályban tárolódnak az egyes munkacsoportok, amelyek a RendezettLancoltLista-ban tárolt Alkalmazott objektumokat tartalmazzák. Lehetőség van új alkalmazott hozzáadására, és ellenőrizhető, hogy egy adott alkalmazott benne van-e a csoportban. 
AlkalmazottKezelo Osztály: Ez az osztály kezeli az alkalmazottakat és a munkacsoportokat. Lehetőség van új alkalmazottak és munkacsoportok hozzáadására, valamint egy adott indexű munkacsoport vagy alkalmazott lekérdezésére. 
RendezettLancoltLista Osztály: Ez egy generikus osztály, ami rendezett láncolt listaként működik. Tartalmazza az elemek számát, és lehetőséget biztosít az elemek hozzáadására, törlésére, valamint az egyes elemek elérésére az indexük alapján. 
Alkalmazott Osztály: Ez az osztály az egyes alkalmazottakat reprezentálja, implementálva az IMunkaraAlkalmas interface-t. Tartalmazza az alkalmazott nevét, azonosítóját, feladatköreit, munkaóráit, óradíját és a terhelhetőségét. 
Ez az osztály a Alkalmazott osztály számára alapot biztosít. 
Ember Absztrakt Osztály: Ez egy alaposztály, ami az alapvető tulajdonságokat tartalmazza, mint a nem és a teherbírás határa. 
MegszunesJelzese Delegált: Ez egy delegált típus, amelyet a AlkalmazottKezelo osztály használ az események jelzésére. Ebben az esetben a delegált egy string paramétert vár, ami üzenetként szolgál. Ezt a delegált típust használják például a MunkaCsoportMegszunese eseményhez, amely akkor váltódik ki, amikor egy munkacsoport megszűnik (például amikor nincs több alkalmazott a csoportban). 
AlkalmazottEltavolitasa Delegált: Ez egy másik delegált típus, ami az alkalmazottak eltávolítására használható eseményekhez kapcsolódik. Ebben az esetben a delegáltus egy Alkalmazott típusú objektumot vár paraméterként. Ez a delegált 
Main metódus: Ez a program belépési pontja, ahol létrehoznak munkacsoportokat és alkalmazottakat, majd kezelik őket az AlkalmazottKezelo segítségével.
Egy kivételkezelési rendszert ír le, amely specifikus kivételek kezelésére szolgál a munkabeosztó rendszerben. A kivételkezelési osztályok a következők: 
SajatKivetelkezeles Osztály: 
Egy saját kivétel osztály, amely az Exception osztályból származik. 
A konstruktora lehetővé teszi egy üzenet továbbítását, amely részletezi a kivételt. 
MunkacsoportKivetelKezeles Osztály: 
Ez egy speciális kivételkezelő osztály, amely a SajatKivetelkezeles osztályból származik. 
Kivételek kezelésére szolgál, amelyek a MunkaCsoport osztályhoz kapcsolódnak. 
A konstruktora a hibaüzenetet egy MunkaCsoport nevével egészíti ki. 
AlkalmazottKezeloKivetelKezeles Osztály: 
Egy másik specializált kivételkezelő osztály, amely a SajatKivetelkezeles osztályt bővíti ki. 
Az AlkalmazottKezelo osztályban keletkező kivételek kezelésére szolgál. 
A konstruktora a hibaüzenetet az "Alkalmazott kezelőnél" prefixszel látja el. 
AlkalmazottKivetelKezeles Osztály: 
Egy további specializált kivételkezelő osztály, amely szintén a SajatKivetelkezeles osztályból származik. 
Konkrét Alkalmazott objektumokhoz kapcsolódó kivételek kezelésére szolgál. 
A konstruktora lehetővé teszi, hogy az alkalmazott azonosítójával együtt adjunk meg egy hibaüzenetet. 
