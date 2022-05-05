#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define PAN_LENGTH 16

int main()
{
    char pan[PAN_LENGTH];
    int tot = 0;
    printf("Inserisci PAN carta: ");
    scanf("%s", pan);
    for (int i = PAN_LENGTH - 1; i >= 0; i--)
    {
        if (i % 2 == 0)
        {
            tot += 2 * (pan[i] - '0');
        }
        else
        {
            tot += pan[i] - '0';
        }
    }

    if (tot % 10 != 0)
    {
        printf("\nNumero PAN non valido\n");
        return -1;
    }
    printf("\nNumero PAN valido\n");
    return 0;
}