#include <stdio.h>

int main ()
{
    int columns, rows;

    printf ("Enter the number of columns: ");
    scanf ("%d", &columns);
    printf ("Enter the number of rows: ");
    scanf ("%d", &rows);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            printf ("(%d,%d) ", i, j);
        }

        printf ("\n");
    }

    return 0;
}