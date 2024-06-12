using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotrap.Core.AnalisiTesto;

static public class ExtensionMethodAnalisiTesti
{
    static List<string> paroleDaRimuovere = new List<string> { "il", "lo", "la", "i", "gli", "le", "in", "con", "su", "per", "di", "a", "da", "tra","fra","1",
                                                        "L", "è", "una", "sul", "La",
                                                        "al",
                                                        "che",
                                                        "e",
                                                        "1",
                                                        "2",
                                                        "3",
                                                        "4",
                                                        "5",
                                                        "6",
                                                        "7",
                                                        "8",
                                                        "9",
                                                        "della",
                                                        "Art",
                                                        "dei",
                                                        "del",
                                                        "o",
                                                        "l",
                                                        "delle",
                                                        "non",
                                                        "Il",
                                                        "sono",
                                                        "dalla",
                                                        "può",
                                                        "alla","un",
                                                        "alle",
                                                        "ed",
                                                        "I",
                                                        "*",
                                                        "dell",
                                                        "loro",
                                                        "se", "nei", "sia", "sua", "come", "Le", "degli", "hanno", "ogni", "dello", "ad", "\""};

    static private bool RimuoviCarattereSpeciale(string parola)
    {
        foreach (char c in parola)
        {
            if ((int)c == 8217)
            {
                return true;
            }
        }
        return false;
    }

    static public Dictionary<string, int> TrovaParolePiuFrequenti(this string testo, int n)
    {
        string[] separators = new string[] { " ", ".", ",", "\'", "#####", "#", "##", "\n", "\r", "\t" };
        string[] parole = testo.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var DizionarioParole = new Dictionary<string, int>();
        foreach (string s in parole)
        {
            if (!RimuoviParoleInutili(s) && !RimuoviCarattereSpeciale(s))
            {
                if (!DizionarioParole.ContainsKey(s))
                {
                    DizionarioParole.Add(s, 1);
                }
                else
                {
                    DizionarioParole[s]++;
                }
            }
        }

        return DizionarioParole.OrderByDescending(x => x.Value).Skip(0).Take(n).ToDictionary();
    }
    

    static public bool RimuoviParoleInutili(string parola)
    {
        return paroleDaRimuovere.Contains(parola);
    }

    static public string ParolaPiuLunga(this string testo)
    {
        string[] separators = new string[] { " ", ".", ",", "\'", "#####", "#", "##", "\n", "\r", "\t" };
        string[] parole = testo.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var DizionarioParole = new Dictionary<string, int>();
        foreach (string s in parole)
        {
            if (!RimuoviParoleInutili(s) && !RimuoviCarattereSpeciale(s))
            {
                if (!DizionarioParole.ContainsKey(s))
                {
                    DizionarioParole.Add(s, s.Length);
                }
            }
        }

        return DizionarioParole.OrderByDescending(x => x.Value).Skip(0).Take(1).ToDictionary().First().Key;
    }
}
