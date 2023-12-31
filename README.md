# Projekt-Dokumentation

<span style="background: azure">☝️ Alle Text-Stellen, welche hell-blau hinterlegt sind, dienen nur Ihrer Information. Sie können sie löschen, sobald Sie sie gelesen haben. </span>


Gruppe 5: Spaqi, Kistler, Biasco

| Datum | Version | Zusammenfassung |
| --- | --- | --- |
|     | 0.0.1 | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und erklären in *einem* griffigen Satz, was Sie an dem Tag erreicht haben. Diese Stelle gibt Ihnen und Ihrer Lehrperson eine einfache Möglichkeit, sich eine Übersicht über Ihr Projekt zu verschaffen. |
|     | ... |     |
|     | 1.0.0 |     |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Zeitrahmen möchten wir einen Fremdwährungsrechner programmieren, bei dem man 1-5 Währungen eingeben kann. Er soll diese in eine andere Währung umrechnen, zum Beispiel Euro in Schweizer Franken. 

### 1.2 Anforderungen

| №   | Verbindlichkeit | Typ | Beschreibung |
| --- | --- | --- | --- |
| 1   | Muss    | Funktionalität    | 1-5 Währungen eingeben können und entscheiden welche Währung verwaltet wird.    |
| 2   | Muss    | Funktionalität    | Das Programm soll über eine API Daten aus dem Internet beziehen können.    |
| 3   | Muss    | Funktionalität    | Er soll alle auswählbaren Währungen in z.B Fr. umrechnen können.    |
| 4   | Kann    | Funktinalität    | In einer Erweiterung, könnte das Programm ein Finanz Assistänt besitzen.    |
| 5   | Muss    | Randbedingung    | Das Programm soll bis am 27.11 fertig sein.    |
| 6   | Muss    | Randbedingung    | Das Programm soll mit c# geschriben sein.    |

<span style="background: azure">Jede Anforderung hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand).</span>

### 1.3 Testfälle

| TC-№ | Vorbereitung (*given*) | Eingabe (*when*) | Erwartete Ausgabe (*then*) |
| --- | --- | --- | --- |
| 1.1 | Programm Start    | xx CHF    | xx CHF    |
| 2.1 | Programm Start    | -    | aktelle Kurse ---    |
| 3.1 | Programm anfang    | 15 €    | 14 CHF    |
| 3.2 | Programm anfang    | 15 $    | 13 CHF    |
| 4.1 | Währung rechnen    | -    | -    |
| ... |     |     |     |

<span style="background: azure">Jede Anforderung hat mindestens einen dazugehörigen Testfall. Der erste Testfall, der zur Anforderung mit der Nummer 1 gehört, hat die Nummer 1.1, der zweite Testfall, der zur Anforderung 1 gehört, die 1.2; der erste Testfall zur Anforderung 2 die 2.1 und so weiter. </span>

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.
![image](https://github.com/Donis03ch/Fremdweahrungsrechner/assets/111046453/125a765c-4fd4-4827-b5c2-4e90dff45614)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung |
| --- | --- | --- | --- |
| 1.A |  45min   | Brandon    | GUI designen & erstellen    |
| 2.A |  60min   | Alle    | API Schnittstelle herunterladen |
| 2.B |  45min   | Vincent    | Währungs-Array erstellen    |
| 3.A | 60min    | Alle    | Die Umrechnungen programmieren    |
| 4.A | 45min    | Brandon    | Fehler abfangen    |
| ... |     |     |     |


## Feinplanung
-
- [ ] Wie kann man eine Schnittstelle in ein C# program einfügen (Brandon, Mattia und Vincent)
- [ ] Wie erstellt man die Währungs Array mit der Schnittstelle (Brandon)
- [ ] Wie erstellt und designed man eine GUI (Mattia und Vincent)


- [ ] Versuchen die Schnittstelle in die C# applikation zu implementieren (alle)
- [ ] Versuchen den Rechner in den code einzufügen (alle)
- [ ] Die GUI verbessern (alle)
      






✍️ Total: bspw. 26 Arbeitspakete

<span style="background: azure">Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. *Frist* bedeutet, wann das AP abgeschlossen sein muss; *Zuständig* bezeichnet die (haupt-)verantwortliche Person.</span>

<span style="background: azure">Die Arbeitspakete sind wie die Testfälle nummeriert; aber gebrauchen A, B, C, ... statt 1, 2, 3.... Das erste Arbeitspaket zur Anforderung 1 ist also 1.A, das zweite 1.B etc. </span>

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | tatsächliche Zeit |
| --- | --- | --- |
| 1.A |     |     |
| ... |     |     |

<span style="background: azure">Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten. </span>

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| --- | --- | --- | --- |
| 1.1 |     |     |     |
| ... |     |     |     |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Beschreiben Sie, was gut an Ihrem Projekt ging, und was Sie nächstes Mal anders machen würden.


