/* L'App deve modellare un'Automobile, per farlo deve registrare le informazioni relative a:
 * - MARCA
 * - MODELLO
 * - TIPO DI MOTORE (BENZINA, DIESEL, ELETTRICO)
 * - COLORE
 * 
 * All'avvio l'app deve mostrare lo stato dell'Auto, stampando marca, modello, tipo di motore e colore.
 * Per modellare l'Automobile implementiamo una classe chiamata 'Auto'
*/
// ----------------------------------------------------------------------------------------------------------

Auto automobile = new Auto();

automobile.marca = "Tesla";
automobile.modello = "X";
automobile.tipoMotore = Auto.Motore.Elettrico;
automobile.colore = "Bianca";

automobile.stampa();

//Console.ReadLine();

// ----------------------------------------------------------------------------------------------------------
class Auto {
    // ---------- Tipi personalizzati ----------
    public enum Motore {
        Benzina,
        Diesel,
        Elettrico
    }

    // ---------- Proprietà ----------
    public string? marca;
    public string? modello;
    public Motore tipoMotore;
    public string? colore;

    public Auto() {}

    public Auto(string? marca, string? modello, Motore tipoMotore, string? colore) {
        this.marca = marca;
        this.modello = modello;
        this.tipoMotore = tipoMotore;
        this.colore = colore;
    }

    // ---------- Motodo che Stampa le Caratteristiche dell'Auto ----------
    public void stampa() {
        Console.WriteLine("Marca: " + this.marca);
        Console.WriteLine("Modello: " + this.modello);
        Console.WriteLine("Tipo Motore: " + this.tipoMotore);
        Console.WriteLine("Colore: " + this.colore);
    }
}