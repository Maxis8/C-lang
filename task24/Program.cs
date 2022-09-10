// Напишите программу, которая будет преобразовывать десятичное число в двоичное

string Binary(int num)
{
    
    string binaryNum = String.Empty;
    while(num > 0)
    {
        
        if(num % 2 == 1) binaryNum +="1";
        else binaryNum +="0";
        num /=2;
        
    }
    return binaryNum;
}
string ReverseBinary(string stringNum)
{
    string temp = String.Empty;
    for(int i = stringNum.Length -1; i >= 0; i--)
    {
        temp += stringNum[i];
    }
    return temp;
}
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine(ReverseBinary(Binary(Num)));



// string convertnum = Binary(Num);
// char[] sReverse = convertnum.ToCharArray();
// Array.Reverse(sReverse);
// convertnum = new string(sReverse);
// Console.Write(convertnum);