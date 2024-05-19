GCC_ARGS = -g -std=c99 -Wall -pedantic-errors -fPIC

main: main.o
	gcc -o $@ $<

%.o: %.c
	gcc -c $<

clean:
	rm *.o main