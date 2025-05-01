using mywebapi.Models;
using mywebapi.Repositories.IRepositories;

namespace mywebapi.Repositories;

public class WoordenschatRepository : IWoordenschatRepository
{
    public Task<IEnumerable<Woorden>> GetWoordenAsync()
    {
        var Woordenlijst = new List<Woorden> { 
            new Woorden { Woord = "Ad rem", Betekenis = "Direct, onmiddellijk, meteen, spontaan, met een antwoord, opmerking of weerwoord" },
            new Woorden { Woord = "Cultiveren", Betekenis = "Aanbouwen, aankweken" },
            new Woorden { Woord = "Vendetta", Betekenis = "Straf, wraak" },
            new Woorden { Woord = "Arbitrair", Betekenis = "Willekeurig, toevallig" },
            new Woorden { Woord = "Cognitief", Betekenis = "Wat betreft het kennen, weten, begrijpen" },
            new Woorden { Woord = "Dilemma", Betekenis = "Keuze tussen twee of meer mogelijkheden" },
            new Woorden { Woord = "Eloquent", Betekenis = "Welsprekend, spraakzaam" },
            new Woorden { Woord = "Filosofie", Betekenis = "Wijsbegeerte, levensbeschouwing" },
            new Woorden { Woord = "Hypothese", Betekenis = "Veronderstelling, aanname" },
            new Woorden { Woord = "Introspectie", Betekenis = "Zelfreflectie, zelfonderzoek" },
            new Woorden { Woord = "Juxtapositie", Betekenis = "Tegenover elkaar plaatsen" },
            new Woorden { Woord = "Kwantificeren", Betekenis = "In getallen uitdrukken, tellen" },
        };
        return Task.FromResult<IEnumerable<Woorden>>(Woordenlijst);
    }
}
