string st = Console.ReadLine();
int i = 0;
bool exito = true;

while (exito && (i < st.Length - (i + 1)))
{
    if (st[i] == st[st.Length - (i + 1)])
    {
        i++;
    }
    else
    {
        exito = false;
    }
}
Console.WriteLine(exito);
Console.ReadKey(true);

