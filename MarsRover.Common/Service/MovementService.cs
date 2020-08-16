using System.Collections.Generic;
using MarsRover.Common.Enum;
using MarsRover.Common.Interface;
using MarsRover.Common.Model;

namespace MarsRover.Common.Service
{
    public class Rotate90Left : IMovementService
    {
        public void UpdatePosition(Position position)
        {
            var rotateLeftDictionary = new Dictionary<Direction, Direction>
            {
                {Direction.N,Direction.W},
                {Direction.S,Direction.E},
                {Direction.E,Direction.N},
                {Direction.W,Direction.S}
            };

            position.Direction = rotateLeftDictionary[position.Direction];
        }
    }

    public class Rotate90Right : IMovementService
    {
        public void UpdatePosition(Position position)
        {
            var rotateRightDictionary = new Dictionary<Direction, Direction>
            {
                {Direction.N,Direction.E},
                {Direction.S,Direction.W},
                {Direction.E,Direction.S},
                {Direction.W,Direction.N}
            };

            position.Direction = rotateRightDictionary[position.Direction];
        }
    }

    public class MoveInSameDirection : IMovementService
    {
        public void UpdatePosition(Position position)
        {
            switch (position.Direction)
            {
                case Direction.N:
                    position.YCoordinate += 1;
                    break;
                case Direction.S:
                    position.YCoordinate -= 1;
                    break;
                case Direction.E:
                    position.XCoordinate += 1;
                    break;
                case Direction.W:
                    position.XCoordinate -= 1;
                    break;
            }
        }
    }
}
