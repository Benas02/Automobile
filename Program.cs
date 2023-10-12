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

automobile.stampaDescrizione();

Console.WriteLine();

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
    public void stampaDescrizione() {
        Console.WriteLine(generaDescrizione());
    }

    private string generaDescrizione() {
        string result;

        result = "Marca: " + this.marca + "\n";
        result += $"Modello: {this.modello}\n";
        result += "Tipo Motore: " + this.tipoMotore + "\n";
        result += $"Colore: {this.colore}";

        return result;
    }
}