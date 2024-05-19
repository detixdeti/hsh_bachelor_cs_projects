# Make file für Uebung 1
# 2022-09-15
#
# 1. Präprozessor (-E):
# #include, #define auswerten, Kommentare herausausnehmen
#
# 2. Kompiler (−S):
# C−> Assembler, Ergebnis .s
#
# 3. Assembler (−c):
# assembly −> object file, Ergebnis .o
#
# 4. Linker:
# Object−Dateien zusammenbringen und ein ausführbares Programm erstellen

# Bedeutung der Compiler−Optionen
#
# −c: kompiliert Quellen ohne Binder
# −Wall: alle Warnungen anzeigen
# −ansi: ANSI C Standard prüfen
# −fPIC: positionsunabhaengiger Code, nötig zum Erstellen von shared libraries
# −g: Standard Debug−Informationen hinzufuegen

# Compiler−Optionen setzen
CCOPTS=-Wall -fPIC -g -pedantic -errors

# ar: Werkzeug zum Erstellen von Bibliotheken
# r: replace or add
# c: keine Nachricht auf STDERR schreiben
# s: object−file index in das Archiv schreiben

# Optionen für AR setzen
AROPTS="rcs"

default: testprogs testprogd

# Object files bauen
file1.o: file1.c file1.h
	gcc $(CCOPTS) -c file1.c

file2.o: file2.c file2.h
	gcc $(CCOPTS) -c file2.c

# Statisch verlinkte Bibliothek bauen
libuebung1s.a: file1.o file2.o
	ar $(AROPTS) -o libuebung1s.a file1.o file2.o

# Dynamisch verlinkte Bibliothek bauen
libuebung1d.so: file1.o file2.o
	gcc $(CCOPTS) -shared -o libuebung1d.so file1.o file2.o

# Statisch verlinkte Version von uebung1 bauen
testprogs: testprog.c file1.h file2.h libuebung1s.a
	gcc $(CCOPTS) -static -L. testprog.c -o testprogs -luebung1s

# Dynamisch verlinkte Version von uebung1 bauen
testprogd: testprog.c file1.h file2.h libuebung1d.so
	gcc $(CCOPTS) -o testprogd testprog.c -L. -luebung1d

# Alle0 aufräumen
clean:
	rm -f *.o testprogs testprogd libuebung*