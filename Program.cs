Console.Write("Ingrese la longitud del array: ");
int longitudArray = Convert.ToInt32(Console.ReadLine());

int[] numeros;
numeros = new int[longitudArray];

for(int i = 0; i< longitudArray; i++){
    Console.Write("Ingrese valor: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int max = numeros.Max();
int min = numeros.Min();


for(int i = 0; i< numeros.Count()-1;i++){
    if(numeros[i] > numeros[i+1]){
        int temp = numeros[i];
        numeros[i] = numeros[i+1];
        numeros[i+1]=temp;

    }
}

for(int i = 0; i< numeros.Count()-1;i++){
    Console.Write(numeros[i]);
}

// int resultado = max-min;
// int validador = 0;
// while(validador != 1){
//     if(resultado%2==0){
//         Console.WriteLine("longitud: "+ numeros.Count());
//     }
//     else{
//         if(numero)
//     }
// }