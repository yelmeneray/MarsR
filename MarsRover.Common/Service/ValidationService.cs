using System;
using System.Collections.Generic;
using MarsRover.Common.Interface;

namespace MarsRover.Common.Service
{
    public class ValidationService : IValidationService
    {
        public void PlateauValidation(List<int> plateauPosition)
        {
            if (plateauPosition == null || plateauPosition.Count != 2)
            {
                throw new Exception("Invalid Plateau Size");
            }
        }

        public void RoverValidation(List<string> roverPosition)
        {
            if (roverPosition == null || roverPosition.Count != 3)
            {
                throw new Exception("Invalid Rover Position");
            }
        }
    }
}
