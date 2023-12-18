namespace Git_Gyakorlas;
class Program
{
    public bool megal = false;
    public int szam;
    public List<int> szamok = new List<int>();

    void Main(string[] args)
    {
        while(megal == false){
            Console.Write("Adjon meg egy számot: ");
            if(int.TryParse(Console.ReadLine(), out szam)){
            if(szam == 0) megal = true;
            szamok.Append(szam);
            }
            else{
                Console.WriteLine("Hibás érték\n");
            }
        }
    }
}
