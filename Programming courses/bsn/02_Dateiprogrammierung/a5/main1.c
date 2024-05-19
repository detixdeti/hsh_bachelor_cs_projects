#include <stdio.h>
#include <unistd.h>

int main(void)
{
    FILE *input = fopen("test_input.txt", "r");
    FILE *output = fopen("test_output.txt", "w");
    int zeichen = fgetc(input);
    while (zeichen != EOF)
    {
        if (fputc(zeichen, output) == EOF)
        {
            printf("%s", "Ein Fehler ist beim Schreiben aufgetreten");
            return -1;
        }
        zeichen = fgetc(input);
    }
    fclose(input);
    fclose(output);
    return 0;
}
