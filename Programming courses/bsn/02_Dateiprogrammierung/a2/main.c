#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <string.h>

int main(void)
{
    char file[] = "text.txt";
    printf("%s %s\n", "Öffne Datei in read-write-mode", file);
    int fd = open(file, O_RDWR);
    if (fd <= 0)
    {
        printf("%s\n", "Öffnen der Datei ist fehlgeschlagen");
        return -1;
    }

    char text[] = "Hallo";
    printf("%s %s\n", "Schreibe in Datei:", text);
    int bytesWritten = write(fd, text, strlen(text));
    if (bytesWritten != strlen(text))
    {
        printf("%s\n", "Schreiben in der Datei ist fehlgeschlagen");
        return -1;
    }

    printf("%s\n", "Datei wird geschlossen");
    close(fd);

    printf("%s %s\n", "Öffne Datei in read-mode", file);
    fd = open(file, O_RDONLY);
    if (fd <= 0)
    {
        printf("%s\n", "Öffnen der Datei ist fehlgeschlagen");
        return -1;
    }

    printf("%s %s\n", "Schreibe in Datei:", text);
    bytesWritten = write(fd, text, strlen(text));
    if (bytesWritten != strlen(text))
    {
        printf("%s\n", "Schreiben in der Datei ist fehlgeschlagen");
        return -1;
    }

    close(fd);

    return 0;
}
