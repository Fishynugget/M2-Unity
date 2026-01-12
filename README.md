# M2-Unity
## Titel (werktitel)
### Peggle


## Genre
### Physics-based arcade puzzelgame.


## Beschrijving
### De speler moet het cannon richten en dan afvuren zodat de balletjes kapot gaan en daarmee gaat de score omhoog.


## Gameplaykern
### Bal: dat design komt later want ik ben er nog niet over uit.
### Targets of bumps: de balletjes met de rare tekens.
### Score: je krijgt 15 punt per kapotgeschoten target.
### Doel: level is klaar als alle targets kapot zijn


## Stijl en sfeer
### felle kleuren en veel contrast erin en geinspireerd door een aflevering van een netflixserie.


## Structuur van het level
### Bovenaan: schietplek.
### Midden: veld met targets.
### Onderaan: opvang of doelgebied voor het einde van de beurt.


## Levelschets
![levelschets](nohzdyve.png)

## 2.1: forces & collision.
### Bal gemaakt en targets toegevoegd.
![2.1](gifs/M2_gdv_2.1.gif)
### [ShootBall](Peggle_game\Assets\scripts_peggle\ShootBall.cs)
### [TargetCollision](Peggle_game\Assets\scripts_peggle\TargetCollision.cs)


## 2.2: Aim, Shoot en Line.
### Werkend kanon gemaakt.
![2.2](gifs/M2_gdv_2.2.gif)
### [Aim](Peggle_game\Assets\scripts_peggle\Aim.cs)
### [Shoot](Peggle_game\Assets\scripts_peggle\Shoot.cs)


## 3.1: Score & Triggers.
### Score toegevoegd en peggles kunnen nu kapot.
![3.1](gifs/M2_gdv_3.1.gif)
### [Peggle](Peggle_game\Assets\scripts_peggle\Peggle.cs)
### [ScoreManager](Peggle_game\Assets\scripts_peggle\ScoreManager.cs)


## 3.2: Bumpers en Combo Systeem.
### Score kan nu veranderen met combos.
![3.2](gifs/M2_gdv_3.2.gif)
### [BumperHit](Peggle_game\Assets\scripts_peggle\BumperHit.cs)
### [ComboSysteem](Peggle_game\Assets\scripts_peggle\ComboSysteem.cs)

## 4.1: Leveldesign en UI.
### UI gemaakt.
### De game heeft nu een startscherm, een laadscherm en de game zelf (het laadscherm is gewoon voor tussen de scenes in tijdens het switchen van scenes)
![4.1](4.1.png)
### Heb nog hulp nodig met de resoluties dus deze gif komt later.

## 4.2: Scores versturen.
### UI verder gemaakt en nu laat het de score en multiplier zien.
![4.2](gifs/M2_gdv_4.2.gif)
### [UIScoreBoard](Peggle_game\Assets\scripts_peggle\UIScoreBoard.cs)


## 5.2: Particles, Sounds en Shakes.
### Particles en audio toegevoegd aan de bumpers.

### [BumperHit](Peggle_game\Assets\scripts_peggle\BumperHit.cs)

## 6.1:


## Reflectie – Week 1

### Beantwoord kort in je README:
#### ik heb deze week de schets gemaakt.
#### ik heb plezier gehad in canva(heel fijn programma).
#### ik liep nergens tegenaan maar het duurde gewoon best lang om te maken.
#### geen, daar waren we nog niet mee bezig.

## Reflectie - Week 2

#### Bal, kanon en targets gemaakt.
#### Vooral docent om hulp gevraagd maar ook op internet opgezocht.
#### Het ging prima maar ik liep soms vast.
#### Alles afgekregen.

## Reflectie - Week 3

#### Deze week score, bumpers en combosysteem gemaakt.
#### Docent om hulp gevraagd.
#### Het ging wel prima.
#### Alles af.

## Reflectie - Week 4

#### Ik heb de UI gemaakt en de mogelijkheid om tussen scenes te switchen toegepast.
#### Ik heb online dingen opgezocht.
#### Het ging vrijwel allemaal goed behalve dat ik nog met de resoluties bezig moet omdat ik die niet helemaal snap.
#### Alles gebruikt behalve de font.


## Idee(Hoort niet bij het conceptformat en is dus niet belangrijk)
### Een Colin Ritman inspired design maken? dus bijvoorbeeld iets met hetzelfde soort physieke design als Nohzdyve of mischien zelfs Bandersnatch?