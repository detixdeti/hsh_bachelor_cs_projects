#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>

int main(void)
{
    char file[] = "test.txt";
    int fd = open(file, O_RDWR | O_SYNC);
    for (int i = 0; i < 1000; i++)
    {
        write(fd, "HS Hannover", 11);
    }
    close(fd);
}