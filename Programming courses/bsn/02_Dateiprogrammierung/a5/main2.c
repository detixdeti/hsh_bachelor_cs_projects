#include <stdio.h>
#include <unistd.h>
#include <string.h>

int main(void)
{
    FILE *input = fopen("test_input.txt", "r");
    FILE *output = fopen("test_output.txt", "w");
    char zeichen[100];
    while (fgets(zeichen, 100, input) != NULL)
    {
        printf("%d", fputs(zeichen, output));
        if (fputs(zeichen, output) == EOF)
        {
            printf("%s", "Ein Fehler ist beim Schreiben aufgetreten");
            return -1;
        }
    }
    fclose(input);
    fclose(output);
    return 0;
}
