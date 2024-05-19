#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>

int main(void)
{
    int pid = fork();
    if (pid == -1)
    {
        printf("%s", "Fehler beim forken!");
        exit(EXIT_FAILURE);
    }
    else if (pid == 0)
    {
        printf("%s %i\t %s %i\t %s %i\n", "Kind: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
    }
    else
    {
        printf("%s %i\t %s %i\t %s %i\n", "Eltern: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
    }
    return EXIT_SUCCESS;
}