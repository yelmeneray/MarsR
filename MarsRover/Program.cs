using MarsRover.Common.Interface;
using System;
using MarsRover.Common.Helper;
using MarsRover.Common.Service;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRoverService, RoverService>()
                .AddSingleton<IValidationService, ValidationService>()
                .BuildServiceProvider();

            var roverService = serviceProvider.GetService<IRoverService>();
            var validationService = serviceProvider.GetService<IValidationService>();

            Console.WriteLine("Mars Plateau Size:");

            var plateauSize = ParserHelper.PlateauSizeParser(Console.ReadLine());

            validationService.PlateauValidation(plateauSize);

            Console.WriteLine("Rover Position:");

            var roverPosition = ParserHelper.PositionParser(Console.ReadLine());

            validationService.RoverValidation(roverPosition);

            Console.WriteLine("Movement:");

            var moveTypeList = ParserHelper.MovementParser(Console.ReadLine());

            var newRoverPosition = roverService.StartMoving(plateauSize, moveTypeList, roverPosition);

            Console.WriteLine($"{newRoverPosition.XCoordinate} {newRoverPosition.YCoordinate} {newRoverPosition.Direction}");

            Console.ReadLine();
        }

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
