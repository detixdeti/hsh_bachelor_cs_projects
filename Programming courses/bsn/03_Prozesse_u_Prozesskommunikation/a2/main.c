#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/wait.h>
#define SIZE 80

int createChildRecursive(int counter)
{
    int wait_status;
    pid_t pid;
    if (counter < SIZE)
    {
        pid = fork();
        if (pid == -1)
        {
            printf("%s", "Fehler beim forken!");
            exit(EXIT_FAILURE);
        }
        else if (pid == 0)
        {
            pid_t tmp_pid;
            tmp_pid = createChildRecursive(++counter);
            waitpid(tmp_pid, &wait_status, 0);
            printf("%s %i\t %s %i\t %s %i\n", "Kind: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
            if (counter >= SIZE - 1)
            {
                char c;
                scanf("%c", &c);
            }
            return pid;
        }
        else
        {
            waitpid(pid, &wait_status, 0);
            if (counter == 0)
            {
                printf("%s %i\t %s %i\t %s %i\n", "Eltern: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
            }
        }
    }
    return pid;
}

int main(void)
{
    // createChildRecursive(0);
    int wait_status;
    pid_t pid;
    for (int i = 0; i < SIZE; ++i)
    {
        pid = fork();
        if (pid == -1)
        {
            printf("%s", "Fehler beim forken!");
            exit(EXIT_FAILURE);
        }
        else if (pid == 0)
        {
            // last child prints
            if (i == SIZE - 1)
            {
                printf("%s %i\t %s %i\t %s %i\n", "Kind: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
                char c;
                scanf("%c", &c);
            }
        }
        else
        {
            // wait for child
            waitpid(pid, &wait_status, 0);
            // first parent printing at the end. i == 0 being skipped by childs
            if (i == 0)
            {
                printf("%s %i\t %s %i\t %s %i\n", "Eltern: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
            }
            else
            {
                // childs who got childs end up being parent needed to get printed
                printf("%s %i\t %s %i\t %s %i\n", "Kind: fork() =", pid, "PID =", getpid(), " PPID =", getppid());
            }
            break;
        }
    }
    return EXIT_SUCCESS;
}
