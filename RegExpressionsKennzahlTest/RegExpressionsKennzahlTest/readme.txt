Wichtige Methoden
- Match
Zum Durchsuchen eines Strings nach dem ersten Treffer des Musters. Der getroffene Textteil kann aus der Eigenschaft Match.Value ausgelesen werden. Rückgabewert ist Match.
- Matches
Zum Durchsuchen eines Strings nach allen Vorkommen des regulären Ausdrucks. Rückgabewert ist MatchCollection.
- IsMatch
Zum Überprüfen eines Strings auf Gültigkeit bezüglich eines Musters. Rückgabewert ist Bool.
- Replace
Zum Ersetzen von zeichenfolgen in einem String. Rückgabewert ist String.
- Split
Zum Splitten (Aufteilen) eines Strings. Rückgabewert ist String[]

Regex Optionen
- IgnoreCase
Zwischen Groß und Kleinschreibung wird nicht unterschieden. Sofern diese Option nicht explizit angegeben ist, wird zwischen Groß und Kleinschreibung unterschieden.
- MultiLine
Ändert die Bedeutung der Metazeichen ^ und $, sodass der Textteil jeweils ab dem Anfang und bis zum Ende einer beliebigen Zeile und nicht nur ab dem Anfang und bis zum Ende der gesamten Zeichenfolge dem Muster entsprechen muss.
- Compiled
Gibt an, dass der reguläre Ausdruck in eine Assembly kompiliert wird.Dies beschleunigt zwar die Ausführung, verlängert jedoch die Ladezeit.
- CultureInvariant
Gibt an, dass Unterschiede der Kultur bei der Sprache ignoriert werden.

Patternbeginn und Ende
Das Zeichen ^ bestimmt, wenn es zu Beginn des Patterns steht, dass der zu durchsuchende String ab Beginn(d. h. ab dem ersten Zeichen) dem Muster entsprechen muss. Dieses Zeichen wird auch Zeichenanker genannt. Muss der String bis zum Ende mit dem Muster übereinstimmen, so kennzeichnet man dies mit dem Dollar - Zeichen $ am Patternende.

On the fly Testprogramme
1. http://www.mycsharp.de/wbb2/thread.php?threadid=21580
2. http://www.codeproject.com/Articles/9099/The-Minute-Regex-Tutorial
3. http://odwn.brinkster.net/regex.aspx
