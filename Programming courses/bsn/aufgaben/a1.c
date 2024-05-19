#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <ctype.h>

int main()
{
    int fd[2];
    pipe(fd);
    char buffer[80];

    pid_t pid = fork();
    if (pid == 0)
    {
        close(fd[0]);
        read(fd[1], buffer, 80);
        for (size_t i = 0; i < 80; i++)
        {
            buffer[i] = toupper(buffer[i]);
        }
        printf("%s", buffer);
    }
    else if (pid > 0)
    {
        close(fd[1]);
        read(fd[0], buffer, 80);

        wait();
    }
    else if (pid == -1)
    {
        printf("%s", "Fehler meldung");
        return -1;
    }
    return 0;
}
