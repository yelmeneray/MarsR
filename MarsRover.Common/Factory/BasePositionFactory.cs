using System.Collections.Generic;
using MarsRover.Common.Model;

namespace MarsRover.Common.Factory
{
    public abstract class BasePositionFactory
    {
        public abstract Position CreatePosition(List<int> plateauPosition, List<string> moveTypeList, Position position);
    }
}
