int[] numbers = {44, 5, 78};
int max = numbers[0];
int index = 0;
int size = 3;
while (index < size) {
    if (numbers[index] > max) {
        max = numbers[index];
        index ++;
    }
    else {
        index ++;
    }
}
Console.Write(max);