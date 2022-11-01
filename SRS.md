# Software Requirements Specification
 
## Mobilní aplikace Asteroids 

Verze: 0.0.1 

Shrnutí poslední verze: Vytvoření SRS 

Datum vytvoření: 4. 10. 2022 

Autoři: Tomáš Hanousek 

 

 

 

 

 

 

 

## Obsah

* Úvod 
  * 1.1. Účel 
  * 1.2. Konvence dokumentu 
  * 1.3. Pro koho je dokument určený 
  * 1.4. Další informace 
  * 1.5. Kontakty 
  * 1.6. Odkazy na ostatní dokumenty 
* Celkový popis 
  * 2.1. Produkt jako celek 
  * 2.2. Funkce 
  * 2.3. Uživatelské skupiny 
  * 2.4. Provozní prostředí 
  * 2.5. Uživatelské prostředí 
  * 2.6. Omezení návrhu a implementace 
  * 2.7. Předpoklady a závislosti 
* Požadavky na rozhraní 
  * 3.1. Uživatelská rozhraní 
  * 3.2. Hardwarová rozhraní 
  * 3.3. Softwarová rozhraní 
* Vlastnosti systému 
  * 4.1. Vlastnost A 
    * 4.1.1 Popis a důležitost 
    * 4.1.2 Vstupy – Akce – Výsledek 
    * 4.1.3 Funkční požadavky 
  * 4.2. Vlastnost B 
* Nefunkční požadavky 
  * 5.1. Výkonnost 
  * 5.2. Bezpečnost 
  * 5.3. Spolehlivost 
  * 5.4. Projektová dokumentace 
  * 5.5. Uživatelská dokumentace 
* Ostatní požadavky 

 

# Úvod 
## 1.1. Účel 
Účelem tohoto dokumentu je specifikace celé aplikace 

## 1.2. Konvence dokumentu 
### 1.2.1. Definice požadavků 
* Priorita: <vysoká, střední, nízká>
* Označení funkce: [XX] 

## 1.3. Pro koho je dokument určený  
Dokument je určen budoucím vývojářům a správcům této 	aplikace pro uvedení do problematiky. 

## 1.4. Další informace 
žádné 

## 1.5. Kontakty  
* Jméno řešitele: Tomáš Hanousek 
* Email: tomas.hanousek8@seznam.cz  
* Telefonní číslo: +420 603 738 538 
* Github: https://github.com/TomasHanousek1 

## 1.6. Odkazy na ostatní dokumenty 
žádné 

# Celkový popis 
## 2.1. Produkt jako celek 
Finálním produktem bude funkční mobilní aplikace, která bude 	zobrazovat data o tělesech pohybujících se v blízkosti Země  

## 2.2. Funkce 
* Uživatel si bude moci zobrazit informace o tělesech  
* Správce: editace 

## 2.3. Uživatelské skupiny 
Uživatel, správce 

## 2.4. Provozní prostředí 
Mobilní zařízení 

## 2.5. Uživatelské prostředí 
Mobilní aplikace 

## 2.6. Omezení návrhu a implementace 
žádné

## 2.7. Předpoklady a závislosti 
Závislost na NASA API. Aplikace bude zpracovávat veřejně 	přístupná data NASA poskytnutá ve formátu JSON. 

# Požadavky na rozhraní 

## 3.1. Uživatelská rozhraní 
Mobilní zařízení Android 9.0+ 

## 3.2. Hardwarová rozhraní 
Mobilní zařízení 

## 3.3. Softwarová rozhraní 
NASA Open API Server 

# Vlastnosti systému 

## 4.1. Seznam vesmírných těles [V1]  
### 4.1.1. Priorita: <Vysoká> 
### 4.1.2. Popis: Uživatel si bude moci zobrazit seznam vesmír těles, která se nacházejí v blízkosti Země a proklikávat mezi nimi 
### 4.1.3. Funkční požadavky: žádné 

## 4.2. Filtrovací systém [F1] 
### 4.2.1. Priorita: <Střední> 
### 4.2.2 Popis: Uživatel si vybere, podle jakých parametrů bude vesmírné objekty filtrovat. Uvidí pouze objekty, které vyhovují vybraným parametrům. 
### 4.2.3 Funkční požadavky: Seznam vesmírných těles [V1] 

## 4.3. Jednotlivá vesmírná tělesa 
### 4.3.1. Priorita: <Vysoká> 
### 4.3.2. Popis: po rozkliknutí jednotlivých těles se uživateli zobrazí podrobnější informace o tělesu 
### 4.3.3. Funkční požadavky: Seznam vesmírných těles [V1] 

 

# Nefunkční požadavky 

## 5.1. Výkonnost 
Bude doplněna 

## 5.2. Bezpečnost	 
Bude doplněna 

## 5.3. Spolehlivost 
Vysoká 

## 5.4. Projektová dokumentace 
Bude připojena 

## 5.5. Uživatelská dokumentace 
Žádná 

# Ostatní požadavky 
