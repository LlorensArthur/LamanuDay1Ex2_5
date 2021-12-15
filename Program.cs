Console.WriteLine("Indiquez un mois parmi : janvier, février, mars, avril, mai, juin, juillet, août, septembre, octobre, novembre et décembre");
string mois = Console.ReadLine();
if (mois == "décembre"
    || mois == "janvier"
    || mois == "février")
{
    Console.WriteLine("La saison du mois saisi est l'HIVER.");
}
if (mois == "mars"
    || mois == "avril"
    || mois == "mai")
{
    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
}
if (mois == "juin"
    || mois == "juillet"
    || mois == "aout")
{
    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
}
if (mois == "septembre"
    || mois == "octobre"
    || mois == "novembre")
{
    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
}