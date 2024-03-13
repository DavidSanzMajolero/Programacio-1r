using System;
namespace Ex13
{
    public class Program
    {
        public static void Main()
        {
            ExpertSystem expertSystem = new ExpertSystem(90);
            LandingSystem landingSystem = new LandingSystem(expertSystem);
            AI Ai = new AI(true);
            BoardComputer boardComputer = new BoardComputer(Ai);
            NavegationSystem navigationSystem = new NavegationSystem();
            Motor firstMotor = new Motor(11);
            Motor secondMotor = Motor.Fabricate();
            Rocket rocket = new Rocket("MolanoGasofa", 2);
            Astronaut pilot = new Astronaut("Bad", "Bunny");
            SubCommander subCommander = new SubCommander("Arnau", "Requena");
            SpaceShip spacheShip = new SpaceShip(boardComputer, navigationSystem, rocket, pilot);

        }
    }
}