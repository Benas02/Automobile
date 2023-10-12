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

Auto automobile = new Auto("Tesla", "X", Auto.Motore.Elettrico, "Bianco");

/*automobile.marca = "Tesla";
automobile.modello = "X";
automobile.tipoMotore = Auto.Motore.Elettrico;
automobile.colore = "Bianca";*/

automobile.stampaDescrizione();

Console.WriteLine();

// --------------------------------------------------------------------------------------------------------

/// <summary>
/// Costruisce la descrizione del Veicolo
/// </summary>

class Auto {
    // -------------------- Tipi personalizzati --------------------
    public enum Motore {
        Benzina,
        Diesel,
        Elettrico
    }

    // -------------------- Proprietà --------------------
    public string? marca;
    public string? modello;
    public Motore tipoMotore;
    public string? colore;

    // -------------------- Costruttore Vuoto --------------------
    public Auto() {}

    // -------------------- Costruttore Con Parametri --------------------
    /// <summary>
    /// Costruttore della Classe Auto
    /// </summary>
    /// <param name="marca">Marca del Veicolo</param>
    /// <param name="modello">Modello del Veicolo</param>
    /// <param name="tipoMotore">Tipoliga del Motore</param>
    /// <param name="colore">Colore del Veicolo</param>
    public Auto(string? marca, string? modello, Motore tipoMotore, string? colore) {
        this.marca = marca;
        this.modello = modello;
        this.tipoMotore = tipoMotore;
        this.colore = colore;
    }

    // -------------------- Motodo che Stampa la Descrizione dell'Auto --------------------
    public void stampaDescrizione() {
        Console.WriteLine(generaDescrizione());
    }

    // -------------------- Motodo che Genera la Descrizione dell'Auto --------------------
    private string generaDescrizione() {
        string result;

        result = "Marca: " + this.marca + "\n";
        result += $"Modello: {this.modello}\n";
        result += "Tipo Motore: " + this.tipoMotore + "\n";
        result += $"Colore: {this.colore}";

        return result;
    }
}