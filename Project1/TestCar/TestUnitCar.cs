using Project1;

namespace TestCar
{
    [TestClass]
    public class TestUnitCar
    {
        #region Test Methods
        /// <summary>
        /// Test Car.start()
        /// </summary>
        [TestMethod]
        public void TestTurnOn()
        {
            // Declare and initialize myCar object
            Car testCar = new Car();

            // Call start() method
            testCar.start();

            // Check if the car is on
            if (testCar.carStatus() == "\nPetrol Level: " + testCar.petrolLevel + "\nThe Car is On\n") { }
                // good
            else
                // bad
                throw new Exception("Error on carStatus()");
        }

        /// <summary>
        /// Test Car.stop()
        /// </summary>
        [TestMethod]
        public void TestTurnOff()
        {
            // Declare and initialize myCar object
            Car testCar = new Car();

            // Call stop() method
            testCar.stop();

            // Check if the car is off
            if (testCar.carStatus() == "\nPetrol Level: " + testCar.petrolLevel + "\nThe Car is Off\n") {}
                // good
            else
                // bad
                throw new Exception("Error on carStatus()");
        }

        /// <summary>
        /// Test Car.slowDown()
        /// </summary>
        [TestMethod]
        public void TestSlowDown()
        {
            int control = 0;
            // Declare and initialize myCar object
            Car testCar = new Car();

            // Declare and initialize minSpeed randomly
            int minSpeed = new Random().Next(0, 10);

            // Declare and initialize testResult for test the method
            int testResult = testCar.deaccelerate(minSpeed, 50, 5);

            // check if the return of the method is correct
            if (testResult != minSpeed)
                throw new Exception("Error in slowDown()");

            //check if minspeed is greater of 0
            if (testResult < control)
                throw new Exception("error, you can't insert a negative number");
        }

        [TestMethod]
        public void TestAccelerate()
        {
            int control = 0;
            // Declare and initialize myCar object
            Car testCar = new Car();

            // Declare and initialize minSpeed randomly
            int maxspeed = new Random().Next(0, 10);

            // Declare and initialize testResult for test the method
            int testResult = testCar.Accelerate(maxspeed, 70, 10);

            //check if the return of the method is correct
            if (testResult != maxspeed)
                throw new Exception("error in accelerate() ");

            // check if minspeed is greater of 0
            if (testResult < control)
                throw new Exception("error, you can't insert a negative number");
        }
        #endregion
    }
}