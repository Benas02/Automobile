namespace TestAuto
{
    [TestClass]
    public class TestPrimaApp {
        #region "Test Turn ON"
        [TestMethod]
        public void testTurnON() {
            prima_app.Auto automobile = new prima_app.Auto();

            automobile.accendi();

            if(automobile.generaStato() == "Livello Carburante: 10 l\nStato Veicolo: Veicolo ACCESO") {
                // OK
            } else {
                throw new Exception("");
            }
        }
        #endregion

        #region "Test Turn Without Fuel"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testTurnWithoutFuel()
        {
            prima_app.Auto automobile = new prima_app.Auto("", "", prima_app.Auto.Motore.Elettrico, "", 0, 0);

            automobile.accendi();

            if (automobile.generaStato() == "Livello Carburante: 0 l\nStato Veicolo: Veicolo SPENTO")
            {
                // OK
            }
            else
            {
                throw new Exception("");
            }
        }
        #endregion

        #region "Test Accelera e Decelera"
        // --------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void testAccelera()
        {
            prima_app.Auto automobile = new prima_app.Auto("", "", prima_app.Auto.Motore.Elettrico, "", 100, 100, 0, 250);

            automobile.accelera(10);

            if (automobile.generaStato() == "Livello Carburante: 90 l\n" +
                     "Velocità: 10 km/h\nStato Veicolo: ACCESO")
            {
                // OK
            }
            else
            {
                throw new Exception("");
            }
        }
        #endregion
    }
}