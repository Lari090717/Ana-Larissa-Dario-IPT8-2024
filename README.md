# Bookonomie

## Idee
Wir haben vor, eine Bücherliste zu machen. Diese Webseite wird Bücher beinhalten, die eine Kurzbeschreibung sowie Informationen darüber (Author, Genre, Datum der Veröffentlichung…) beinhalten. Es wird eine Filterfunktionen geben, um eine bessere Übersicht zu haben sowie ein Suchfeld. Man kann auch selber Bücher zur "persönlichen" Liste hinzufügen, die nicht auf der Webseite vorhanden sind.

## Gewählte Technologien
Asp .NET, C#, HTML, CSS, JavaScript, SQL

## Wieso Originell?
Das originelle von Bookonomy ist dass es eine Bücherliste ist, welche alle möglichen Genres enthält. 

## 1. Meilenstein
Unser erster Meilenstein ist, dass das Login funktioniert. Wir wollen die Ansicht, Funktionalität und die Datenbank erstellen.

## Entwickler-Doku
zuerst den Pfad kopieren vom Docker Ordner. Danach die Befehlszeile im Projekt öffnen. Dann gibt man cd und den kopierten Pfad ein. Zum  Schluss macht man noch docker-compose up.
Um sich mit der Datenbank in MYSQL Workbench zu verbinden, muss man auf neue Connection klicken, dann 'bookonomie' als Namen nehmen und beim Username und Password root eingeben. Zum Schluss muss man noch den Port auf 3308 wechseln. 

--> Fals root nicht funktioniert: Im Dockerfile MYSQL_Username und MYSQL_Password auf bookonomie wechseln und im MYSQL Workbench bei der Connection beim Username und Password bookonomie eingeben.
