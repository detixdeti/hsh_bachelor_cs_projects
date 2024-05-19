#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>

int main(void)
{
    char file[] = "test.txt";
    printf("%s %s\n", "Öffne Datei", file);
    int fd = open(file, O_RDONLY);
    if (fd <= 0)
    {
        printf("%s\n", "Öffnen der Datei ist fehlgeschlagen");
        return -1;
    }
    // new line important due to terminal is line buffered
    printf("%s %d\n", "file descriptor: ", fd);
    // alternative if not line buffered e.g. file then this
    // fflush(STDOUT_FILENO)

    // schlafe 1min
    printf("%s\n", "schlafe 1min");
    sleep(60);

    close(fd);

    return EXIT_SUCCESS;
}
