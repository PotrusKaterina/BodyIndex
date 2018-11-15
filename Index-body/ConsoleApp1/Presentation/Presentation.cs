using ConsoleApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Presentation
{
    class PresentationLayer : IPresentation
    {
        public void Start()
        {
            Suggest();
        }

        private void Suggest()
        {
            string userResponse;
            WriteToConsole("I can count your body mass index\nDo you want to know this?(yes/no)");
            userResponse = Console.ReadLine();
            switch (userResponse)
            {
                case "yes":
                    CountWeight();
                    break;
                case "no":
                    Exit();
                        break;
                default:
                    IncorrectData();
                        break;
            }
        }

        private void Exit()
        {
            WriteToConsole("Goodbye");
            Console.ReadKey();
        }

        private void IncorrectData()
        {
            WriteToConsole("Incorrect data");
            Suggest();
        }

        private void CountWeight()
        {
            IHuman human = new Human();
            double height = geHeightFromConsole();
            double weight = getWeightFromConsole();
            human.setValues(height, weight);
            WriteResult(human.getWeightState());
            Suggest();
        }

        private void WriteResult(HumanState humanState)
        {
            switch (humanState)
            {
                case HumanState.STRONG_DEFICIT: WriteToConsole("\nSevere body mass deficiency"); break;
                case HumanState.DEFICIT: WriteToConsole("\nInsufficient (deficit) body weight"); break;
                case HumanState.NORMAL: WriteToConsole("\nNormal"); break;
                case HumanState.OVERWEIGHT: WriteToConsole("\nOverweight (pre-obesity)"); break;
                case HumanState.OBESITY: WriteToConsole("\nObesity"); break;
            }
        }

        private void WriteToConsole(string value)
        {
            Console.WriteLine(value);
        }

        private double geHeightFromConsole()
        {
            double result = 0;
            WriteToConsole("\nEnter your height in meters:");
            try
            {
                result = double.Parse(Console.ReadLine());
            } 
            catch (Exception ex)
            {
                WriteToConsole("Incorrect");
                Suggest();
            }
            return result;
        }

        private double getWeightFromConsole()
        {
            double result = 0;
            WriteToConsole("\nEnter your weight:");
            try
            {
                result = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                WriteToConsole("Incorrect");
                Suggest();
            }
            return result;
        }

    }
}
