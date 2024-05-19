#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>

int main(void)
{
    char file[] = "test.txt";
    int fd = open(file, O_RDONLY);
    // 0: offset
    int curr_pos = lseek(fd, 0, SEEK_END);
    printf("%s %d", "Aktuelle Position des Zugriffzeigers:", curr_pos);
    close(fd);
}
