using System.Collections.Generic;
using MarsRover.Common.Model;

namespace MarsRover.Common.Interface
{
    public interface IRoverService
    {
        Position StartMoving(List<int> plateauPosition, List<string> moveTypeList, List<string> roverPosition);
    }
}
