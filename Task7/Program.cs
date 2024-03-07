int cnt = 0;
for(;;)
{
    string a = Console.ReadLine();
    if(a == "end")
    {
        System.Console.WriteLine(cnt);
        break;
    }
    cnt++;
}
