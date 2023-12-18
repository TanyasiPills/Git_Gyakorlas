namespace Git_Gyakorlas;
class Program
{

    static void Main(string[] args)
    {
        bool megal = false;
        int szam;
        List<int> szamok = new List<int>();

        while(megal == false){
            

            Console.Write("Adjon meg egy számot: ");
            if(int.TryParse(Console.ReadLine(), out szam)){
            if(szam == 0) megal = true;
            szamok.Add(szam);
            }
            else{
                Console.WriteLine("Hibás érték\n");
            }

            szamok.ForEach(e => {Console.Write($"{e}, ");});
            Console.WriteLine();
        }
    }
}
