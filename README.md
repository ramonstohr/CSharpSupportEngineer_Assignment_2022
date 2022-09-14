# Assignment

Die Fehler wurden in weniger als einer Stunde gefunden.

Es gibt jedoch noch ein paar Verbesserungen, welche man in Betracht ziehen könnte.

## Vorschläge

### Allgemein

Die ganze DecimalSeperator Problematik, könnte man mit String Interpolation lösen oder konsequent die Selbe schreibweise verwenden. 
Oder man benutzt an jeder Stelle aus der ein String zu einer Nummer gecastet werden soll, *new CultureInfo("de-CH")*

### Program Klasse

In der SumNumbers Funktion könnte man beim instanzieren der List<Number> die Kapazität direkt mitgeben.
```c
var numbers = new List<Number>(4);
```
Hat in diesem Beispiel nicht viel Einfluss, kann aber mit grösseren Mengen ein bisschen Performance bringen.

### Calculator Klasse

In der SumNumbers Funktion könnte man die doppelte Iteration über die List<Number> sparen, in dem man es in einem Schwung macht:
```c
 public decimal SumNumbers(List<Number> numbers)
 {
     _output.WriteLine("Summing numbers from:");
     decimal sum = 0;
     _numberCache.BuildCache(numbers);
     numbers.ForEach(s =>
     {
         _output.WriteLine(s.Value);
         sum += s.Value;
     });

     _output.WriteLine($"Sum numbers: '{sum}'");
     return sum;
  }
```
Dies würde natürlich im **nicht** gefixten Falle, also beim Verändern der Originalzahlen, dazu führen, dass die geänderte Zahl ausgegeben wird und nicht die "Originale".


### Testing

Sinnvoll wäre vermutlich auch, dass man die einzelnen Funktionen gut mit Testing abdeckt.
Ich habe dies mal testweise auf einen eigenen Branch eingecheckt -> Testing
Dazu habe ich einen MockupOutput gemacht, da ich dort vielleicht keinen Output benötige oder diesen anders bewerkstellige. (Logs etc..)
Dort habe ich mal ein paar Tests für die einzelnen Funktionen des Calculators geschrieben, jedoch nicht alle Möglichkeiten abgedeckt.