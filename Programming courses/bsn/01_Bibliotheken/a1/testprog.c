#include <stdio.h>
#include "file1.h"
#include "file2.h"

int main(void)
{
    int x;
    printf("%s", "Bitte eine Zahl eingeben: ");
    scanf("%d", &x);
    printf("%d %s %d\n", x, " + 7 = ", addSeven(x));
    printf("%d %s %d", x, " + 2 = ", addTwo(x));
}