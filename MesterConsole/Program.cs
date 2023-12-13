using MesterEmberLibary;

var mesterek = File
    .ReadLines("input.txt")
    .Select(x => MesterFactory.Factory(x))
    .Where(x => x != null)
    .Select(x => x!)
    .ToList();

Random rnd = new Random();
using var output = new StreamWriter("megrendelesek.txt");
void MegrendelesSzimulal(MesterEmber mester,int db)
{
    for (int i = 0; i < db; i++)
    {
        try 
        {
            int nap = rnd.Next(1, 31);
            bool sikeres = mester.MunkaVallal(nap);
            output.WriteLine($"{mester} munkavallasa {nap} {(sikeres ? "sikeres" : "sikertelen")}");
        }
        catch (TulSokElfoglaltsagException ex)
            { output.WriteLine(ex.Message);}
        catch(ArgumentOutOfRangeException ex)
            { output.WriteLine(ex.Message);}
    }
}
 foreach (var mester in mesterek)
{
    if (mester is Burkolo)
    {
        MegrendelesSzimulal(mester, 25);
    }
    if (mester is VizvezetekSzerelo)
    {
        MegrendelesSzimulal(mester, 10);
    }
}
