namespace ListaHuto;

class Program
{
    private static List<string> MiVanBenne = new List<string>();
    
    
    
    static void Main(string[] args)
    {
        char valasz;
        do
        {
            Console.WriteLine("menu: \n 1.listazas \n 2. etel be \n 3 etel ki \n 4 huto clear \n 5 huto to file \n 6 file to huto \n 7 clear");
            valasz = Console.ReadLine()[0];
            switch(valasz)
            {
                case '1':
                
                    foreach (string cucc in MiVanBenne)
                    {
                        Console.WriteLine(cucc);
                    }
                    break;
                  
                
                case '2':
                    string internalvalasz;
                        do
                        {
                            Console.WriteLine("mit akarsz berakni");
                            internalvalasz = Console.ReadLine();
                            if (internalvalasz != "")
                            {
                                MiVanBenne.Add(internalvalasz);
                            }
                        } while (internalvalasz != "");
                        break;
                
                case '3':
                    string internalvalasz2;
                    do
                    {
                        Console.WriteLine("mit szeretnel kivenni?");
                        internalvalasz2 = Console.ReadLine();
                        if (MiVanBenne.Contains(internalvalasz2))
                        {
                            MiVanBenne.Remove(internalvalasz2);
                        }
                    } while (internalvalasz2 != "");

                    break;
                case '4':
                    MiVanBenne.Clear();
                    break;
                case '5':
                    StreamWriter sr = new StreamWriter("mivanbenne.txt");
                    foreach (var kiirando in MiVanBenne)
                    {
                        string s = $"{kiirando}\n";
                        sr.Write(kiirando);
                    }

                    sr.Close();
                    break;
                case '6':
                    StreamReader sr2 = new StreamReader("mivanbenne.txt");
                    while (!sr2.EndOfStream)
                    {
                        MiVanBenne.Add(sr2.ReadLine());
                    }
                    sr2.Close();
                    break;

            }
        } while (valasz != '7');
    }
}