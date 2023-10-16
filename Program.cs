/* L'App deve modellare un'Automobile, per farlo deve registrare le informazioni relative a:
 * - MARCA
 * - MODELLO
 * - TIPO DI MOTORE (BENZINA, DIESEL, ELETTRICO)
 * - COLORE
 * 
 * All'avvio l'app deve mostrare lo stato dell'Auto, stampando marca, modello, tipo di motore e colore.
 * Per modellare l'Automobile implementiamo una classe chiamata 'Auto'
 * 
 * Aggiungere all'applicazione un menu che consenta all'autore di selezionare l'operazione da fare:
 * 1) ACCENDI
 * 2) SPEGNI
 * 3) RIFORNISCI
 * 0) ESCI
*/

// --------------------------------------------------------------------------------------------------------

using prima_app;

Auto automobile = new Auto("Tesla", "X", Auto.Motore.Elettrico, "Bianco", 0);

automobile.stampaDescrizione();
automobile.stampaStato();

Console.WriteLine("\n---------------------------------");

automobile.setScelta();

// --------------------------------------------------------------------------------------------------------

Console.WriteLine("\n---------------------------------\n");

// --------------------------------------------------------------------------------------------------------
