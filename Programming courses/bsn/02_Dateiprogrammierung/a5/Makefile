GCC_ARGS = -g -std=c99 -Wall -pedantic-errors -fPIC

default: main1 main2

main1: main1.o
	gcc -o $@ $<

main2: main2.o
	gcc -o $@ $<

%.o: %.c
	gcc -c $<

clean:
	rm *.o main1 main2