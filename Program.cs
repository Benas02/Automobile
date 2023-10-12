/* L'App deve modellare un'Automobile, per farlo deve registrare le informazioni relative a:
 * - MARCA
 * - MODELLO
 * - TIPO DI MOTORE (BENZINA, DIESEL, ELETTRICO)
 * - COLORE
 * 
 * All'avvio l'app deve mostrare lo stato dell'Auto, stampando marca, modello, tipo di motore e colore.
 * Per modellare l'Automobile implementiamo una classe chiamata 'Auto'
*/

// --------------------------------------------------------------------------------------------------------

using prima_app;

Auto automobile = new Auto("Tesla", "X", Auto.Motore.Elettrico, "Bianco", 50);

/*automobile.marca = "Tesla";
automobile.modello = "X";
automobile.tipoMotore = Auto.Motore.Elettrico;
automobile.colore = "Bianca";*/

automobile.stampaDescrizione();
automobile.stampaStato();

automobile.accendi();
Console.WriteLine("\n- Tento di Accendere il Veicolo");
automobile.stampaStato();

automobile.spegni();
Console.WriteLine("\n- Spengo il Veicolo");
automobile.stampaStato();

Console.WriteLine();

// --------------------------------------------------------------------------------------------------------

/// <summary>
/// Costruisce la descrizione del Veicolo
/// </summary>


// --------------------------------------------------------------------------------------------------------
