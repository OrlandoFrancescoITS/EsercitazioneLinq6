using EsercitazioneLinq6;

Cliente Mario = new Cliente("abc123", "Mario", "Rossi");
Automobile Cinquecento = new Automobile("AB476AS", "500", 10, 5);

Noleggio noleggio = new Noleggio(1,DateTime.Today, 5, Mario, Cinquecento);
Noleggio noleggio2 = new Noleggio(2, DateTime.Today.AddYears(50), 5, Mario, Cinquecento);

Autonoleggio autonoleggio = new Autonoleggio();
autonoleggio.Noleggi.Add(noleggio);
autonoleggio.Noleggi.Add(noleggio2);

// ricerca per targa
autonoleggio.MostraNoleggi("abc123");
Console.WriteLine("--------------------------");
// ricerca per codice fiscale
autonoleggio.MostraNoleggi("abc123");
Console.WriteLine("--------------------------");
// informazioni del singolo noleggio
Console.WriteLine(noleggio.ToString());
Console.WriteLine("--------------------------");
// mostra il costo del noleggio
noleggio.CostoNoleggio();
Console.WriteLine("--------------------------");
// aggiunta nuovo noleggio in file
autonoleggio.AggiungiNoleggio(new Noleggio(2, DateTime.Today, 5, Mario, Cinquecento));

// stampa il totale noleggi in euro con ricerca tramite targa 
autonoleggio.TotaleNoleggiTarga("AB476AS");
Console.WriteLine("--------------------------");
// stampa il totale noleggi in euro con ricerca tramite codice fiscale del cliente 
autonoleggio.TotaleNoleggiCF("abc123");
Console.WriteLine("--------------------------");
// stampa il totale noleggi in euro con ricerca tramite modello
autonoleggio.TotaleNoleggiModello("500");
