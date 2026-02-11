# 🗂 Munkabeosztó Rendszer – C# OOP Projekt

## 📌 Projekt leírás

Ez a projekt egy objektumorientált szemlélettel megvalósított munkabeosztó rendszer C# programnyelven.  
A rendszer lehetővé teszi alkalmazottak és munkacsoportok kezelését, terhelhetőség vizsgálatát, feladatkörök nyilvántartását, valamint esemény- és kivételkezelést.

## 🛠 Alkalmazott technológiák

- C#
- OOP
- Interface
- Absztrakt osztály
- Generikus osztály
- Delegáltak
- Eseménykezelés
- Egyedi kivételkezelés

## 🧱 Főbb osztályok

### IMunkaraAlkalmas
A munkára alkalmas entitások interfésze.

### Ember (absztrakt osztály)
Alap tulajdonságok: nem, teherbírás.

### Alkalmazott
Implementálja az IMunkaraAlkalmas interfészt.

### FeladatKor
Megnevezés + munkaidő.

### MunkaCsoport
Alkalmazottakat tárol RendezettLancoltLista segítségével.

### AlkalmazottKezelo
A rendszer központi kezelője.

### RendezettLancoltLista<T>
Saját generikus, rendezett láncolt lista implementáció.

## 🔔 Események

- MunkaCsoportMegszunese
- AlkalmazottEltavolitasa

## ⚠️ Egyedi kivételek

- SajatKivetelkezeles
- MunkacsoportKivetelKezeles
- AlkalmazottKezeloKivetelKezeles
- AlkalmazottKivetelKezeles

## 🎯 Projekt célja

OOP alapelvek, generikus adatszerkezetek, delegáltak és kivételkezelés gyakorlati alkalmazása C# nyelven.
