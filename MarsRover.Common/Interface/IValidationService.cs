using System.Collections.Generic;

namespace MarsRover.Common.Interface
{
    public interface IValidationService
    {
        void PlateauValidation(List<int> plateauPosition);

        void RoverValidation(List<string> roverPosition);
    }
}
