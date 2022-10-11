# Functional Specification
 
## Mobilní aplikace Asteroids 

Verze: 0.0.1 

Shrnutí poslední verze: Vytvoření FS 

Datum vytvoření: 11. 10. 2022 

Autoři: Tomáš Hanousek 

* Úvod
  * 1.1 Účel
  * 1.2 Konvence dokumentu
  * 1.3 Pro koho je dokument určený
  * 1.4 Odkazy na ostatní dokumenty
  * 1.5 Kontakty na řešitele
* Scénáře
  * 2.1 Všechny reálné způsoby použití
  * 2.2 Typy uživatelských rolí, „personas“
  * 2.3 Detaily, motivace, „živé“ příklady
  * 2.4 Vymezení rozsahu – co v sw NEbude
  * 2.5 Na co se NEbude klást důraz (výkonnost)
* Celková hrubá architektura
  * 3.1 Pracovní tok
  * 3.2 Hlavní moduly
  * 3.3 Všechny detaily: obrazovky, okna, tisky, chybové zprávy, logování
  * 3.4 Všechny možné toky programu a jejich projevy
  * 3.5 Všechny dohodnuté principy
* Otevřené otázky 
  * 4.1 Poznámky pro realizaci



# Úvod 
## 1.1. Účel 
Účelem tohoto dokumentu je dohoda na fukcích a specifikacích projektu

## 1.2. Konvence dokumentu 
### 1.2.1. Definice požadavků 
* Priorita: <vysoká, střední, nízká>
* Označení funkce: [XX] 

## 1.3. Pro koho je dokument určený  
Dokument je určen pro  

## 1.4. Další informace 
žádné 

## 1.5. Kontakty na řešitele 
* Jméno řešitele: Tomáš Hanousek 
* Email: tomas.hanousek8@seznam.cz  
* Telefonní číslo: +420 603 738 538 
* Github: https://github.com/TomasHanousek1 

# Scénáře
## 2.1 Všechny reálné způsoby použití
Hlavní způsob využití této aplikace je rychlý přehled a zisk informací pro uživatele.

## 2.2 Typy uživatelských rolí, „personas“
* Uživatel - možnost zobrazit informace o tělesech, filtrování objektů

## 2.3 Detaily, motivace, „živé“ příklady
* Motivace - umožnit široké veřejnosti jednoduše a přehledně sledovat vesmírné objekty, které jsou v okolí Země
* Příklad - Ve Zprávách jsem viděl, že se kolem naší Země ve vzdálenosti 123.000km proletí ateroid B-36. Otevřu aplikace, vyberu podle názvu nebo tělesa ve vzdálenosti menší než 200.000km od Země. Zakliknu těleso a vidím veškeré informace o tělesu.
## 2.4 Vymezení rozsahu – co v sw NEbude
### SW bude obsahovat
* Zobrazení vesmírných těles v tabulce
* Možnost filtrovat tělesa podle těchto parametrů: název objektu, vzdálenost od Země
* Možnost vybrat určité vesmírné těleso a zobrazit bližší informace o tělesu

### SW NEbude obsahovat
* Možnost upravovat informace o tělesech
* Možnost smazat těleso z databáze
* Filtrování nebude obsahovat parametry, které nejsou zapsané v OBSAHU SW
* Přihlašovací systém

## 2.5 Na co se NEbude klást důraz (výkonnost)
* Real-time aktualizace databáze

# Celková hrubá architektura
## 3.1 Pracovní tok
## 3.2 Hlavní moduly
## 3.3 Všechny detaily: obrazovky, okna, tisky, chybové zprávy, logování
## 3.4 Všechny možné toky programu a jejich projevy
## 3.5 Všechny dohodnuté principy
