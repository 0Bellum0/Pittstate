#include<stdio.h>

int main (){
    char arr[8] = {'m', 'n', 'd', 'p', 'o', 's', 't', 'a'};
    int i, j, min, aux;
    for(i=0; i<8; i++){
        min = i;
        for(j=i+1; j<8; j++){
            if(arr[min] > arr[j]){
                min = j;
            }
            /*
            if(min != i){
                aux = arr[min];
                arr[min] = arr[i];
                arr[i] = aux;
            } Ineficiente por trocar toda vez que encontra um mínimo
            */
        }
        if(min != i){
                aux = arr[min];
                arr[min] = arr[i];
                arr[i] = aux;
            } // Eficiente por so trocar quando encontra o real mínimo.
    }
    for(i=0; i<7; i++){
        printf("%c", arr[i]);
        printf("\n");
    }
    return 0;
}