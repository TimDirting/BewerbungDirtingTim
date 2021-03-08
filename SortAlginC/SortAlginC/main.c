#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <math.h>
#define dim 40191	

int a[dim + 1];
int b[dim + 1];

void printfield() {
    for (int i = 0; i < dim; i++) {
        printf("%d", a[i]);
    }
}
/// <summary>
/// Filling the local field 
/// </summary>
/// <param name="i">1=Random numbers / 2= ascending / 3 = descending</param>
void fillField(int i) {
    if (i == 0) {
        for (int i = 0; i < dim; i++) {
            a[i] = rand() % dim;
        }
    }
    else if (i == 1) {
        for (int i = 0; i < dim; i++) {
            a[i] = i;
        }
    }
    else if (i == 2) {
        for (int i = 0; i < dim; i++) {
            a[i] = dim-i;
        }
    }
}


void downheap(int a[], int k, int N)
{
    int j, v;
    v = a[k];
    while (k <= N / 2)
    {
        j = k + k;
        if (j < N && a[j] < a[j + 1]) j++;
        if (v >= a[j]) break;
        a[k] = a[j]; k = j;
    }
    a[k] = v;
}

void selection(int Field[], int N)
{
    int i, j, min, t;
    for (i = 1; i < N; i++)
    {
        min = i;
        for (j = i + 1; j <= N; j++)
            if (Field[j] < Field[min]) min = j;
        t = Field[min]; Field[min] = Field[i]; Field[i] = t;
    }
}

/// <summary>
/// Insertionsort alg 
/// </summary>
/// <param name="Field">Field to be sorted</param>
/// <param name="N"> size of Field</param>
void insertion(int Field[], int N)
{
    int i, j, v;
    for (i = 2; i <= N; i++)
    {
        v = Field[i]; j = i;
        while (Field[j - 1] > v)
        {
            Field[j] = Field[j - 1]; j--;
        }
        Field[j] = v;
    }
}


/// <summary>
/// Heapsort alg
/// </summary>
/// <param name="a">Field to be sorted</param>
/// <param name="N">size of Field</param>
void heapsort(int a[], int N)
{
    int k, t;
    for (k = N / 2; k >= 1; k--) downheap(a, N, k);
    while (N > 1)
    {
        t = a[1]; a[1] = a[N]; a[N] = t;
        downheap(a, --N, 1);
    }
}



/// <summary>
/// mergesort alg
/// </summary>
/// <param name="a">Field to be sorted</param>
/// <param name="l"> splitpoint left start with 0</param>
/// <param name="r"> splitpoint right start with size of Field</param>
void mergesort(int a[], int l, int r)
{

    int i, j, k, m;

    if (r > l)
    {
        m = (r + l) / 2;
        mergesort(a, l, m);
        mergesort(a, m + 1, r);
        for (i = m + 1; i > l; i--) b[i - 1] = a[i - 1];
        for (j = m; j < r; j++) b[r + m - j] = a[j + 1];
        for (k = l; k <= r; k++)
            a[k] = (b[i] < b[j]) ? b[i++] : b[j--];
    }
}

/// <summary>
/// Is the Number prim?
/// </summary>
/// <param name="number">Number </param>
/// <returns>return 1 if is prim</returns>
unsigned long long is_prime(unsigned long long number) {
    unsigned long long i;
    for (i = 2; i <= number / 2; ++i) {

        // condition for non-prime
        if (number % i == 0) {
            return 0;
        }
    }
    return 1;
}




int main() {

    unsigned long long primenumber=2;
    unsigned long long testnumber = 2;
    clock_t start_t, end_t;
    double cpu_time_usedSS[3];
    double cpu_time_usedIS[3];
    double cpu_time_usedMS[3];
    double cpu_time_usedHS[3];
  
    
 
    

    srand(time(NULL));
    printf("Comparing Sorting Algorithms (Sorting %d Numbers)\n\n",dim);
    for (int i = 0; i < 3; ++i) {
        fillField(i);
        start_t = clock();
        heapsort(a, dim);
        end_t = clock();
        cpu_time_usedHS[i] = ( double)(end_t - start_t) / CLOCKS_PER_SEC;
    } printf("HeapSort 1/4 \n  Random:%f sec\n  Up:%f sec \n  Down:%f sec \n", cpu_time_usedHS[0], cpu_time_usedHS[1], cpu_time_usedHS[2]);
    for (int i = 0; i < 3; ++i) {
        fillField(i);
        start_t = clock();
        mergesort(a, 0, dim);
        end_t = clock();
        cpu_time_usedMS[i] = (double)(end_t - start_t) / CLOCKS_PER_SEC;
    } printf("MergeSort 2/4 \n  Random:%f sec\n  Up:%f sec\n  Down:%f sec \n", cpu_time_usedMS[0], cpu_time_usedMS[1], cpu_time_usedMS[2]);
    for (int i = 0; i < 3; ++i) {
        fillField(i);
        start_t = clock();
        insertion(a, dim);
        end_t = clock();
        cpu_time_usedIS[i] = (double)(end_t - start_t) / CLOCKS_PER_SEC;
    }printf("InsertionSort 3/4 \n  Random:%f sec \n  Up:%f sec\n  Down:%f sec \n", cpu_time_usedIS[0], cpu_time_usedIS[1], cpu_time_usedIS[2]);
    for (int i = 0; i < 3; ++i) {
        fillField(i);
        start_t = clock();
        selection(a, dim);
        end_t = clock();
        cpu_time_usedSS[i] = (double)(end_t - start_t) / CLOCKS_PER_SEC;
    }printf("SelectionSort 4/4 \n  Ran:%f sec \n  Up:%f sec \n  Down:%f sec \n", cpu_time_usedSS[0], cpu_time_usedSS[1], cpu_time_usedSS[2]);
    
    for (unsigned long long  m = 3; testnumber < ULLONG_MAX; m= m+2)
    {

        
        testnumber = pow(2,m)-1;

        if (is_prime(testnumber) )
            primenumber = testnumber;

        system("cls");
        printf("Comparing Sorting Algorithms (Sorting %d Numbers)\n\n", dim);
        printf("HeapSort 1/4 \n  Random:%f sec\n  Up:%f sec \n  Down:%f sec \n", cpu_time_usedHS[0], cpu_time_usedHS[1], cpu_time_usedHS[2]);
        printf("MergeSort 2/4 \n  Random:%f sec\n  Up:%f sec\n  Down:%f sec \n", cpu_time_usedMS[0], cpu_time_usedMS[1], cpu_time_usedMS[2]);
        printf("InsertionSort 3/4 \n  Random:%f sec \n  Up:%f sec\n  Down:%f sec \n", cpu_time_usedIS[0], cpu_time_usedIS[1], cpu_time_usedIS[2]);
        printf("SelectionSort 4/4 \n  Ran:%f sec \n  Up:%f sec \n  Down:%f sec \n", cpu_time_usedSS[0], cpu_time_usedSS[1], cpu_time_usedSS[2]);

        printf("Big Primnumber: %llu \n", primenumber);
     
        
    }

    getchar();

   
    return 0;
}






