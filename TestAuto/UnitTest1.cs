namespace TestAuto
{
    [TestClass]
    public class TestPrimaApp {
        #region "Test Turn ON"
        [TestMethod]
        public void testTurnON() {
            prima_app.Auto automobile = new prima_app.Auto();

            automobile.accendi();

            if(automobile.generaStato() == "Livello Carburante: 9 l\nVelocità: 0 km/h\nStato Veicolo: ACCESO") {
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

            if (automobile.generaStato() == "Livello Carburante: 0 l\nVelocità: 0 km/h\nStato Veicolo: SPENTO")
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

            if (automobile.generaStatoNoStato() == "Livello Carburante: 90 l\nVelocità: 10 km/h")
            {
                // OK
            }
            else
            {
                throw new Exception("");
            }
        }

        [TestMethod]
        public void testDecelera()
        {
            prima_app.Auto automobile = new prima_app.Auto("", "", prima_app.Auto.Motore.Elettrico, "", 100, 100, 20, 250);

            automobile.accendi();
            automobile.decelera(10);

            if (automobile.generaStatoNoStato() == "Livello Carburante: 99 l\nVelocità: 10 km/h")
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