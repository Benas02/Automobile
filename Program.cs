﻿/* L'App deve modellare un'Automobile, per farlo deve registrare le informazioni relative a:
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

automobile.stampaDescrizione();
automobile.stampaStato();

Console.WriteLine("\n---------------------------------");

automobile.accendi();
Console.WriteLine("\n- Tento di Accendere il Veicolo");
automobile.stampaStato();

Console.WriteLine("\n---------------------------------");

automobile.spegni();
Console.WriteLine("\n- Spengo il Veicolo");
automobile.stampaStato();

Console.WriteLine("\n---------------------------------\n");

// --------------------------------------------------------------------------------------------------------
