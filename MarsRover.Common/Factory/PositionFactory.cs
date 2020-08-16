using System;
using System.Collections.Generic;
using MarsRover.Common.Enum;
using MarsRover.Common.Interface;
using MarsRover.Common.Model;
using MarsRover.Common.Service;

namespace MarsRover.Common.Factory
{
    public class PositionFactory : BasePositionFactory
    {
        public override Position CreatePosition(List<int> plateauPosition, List<string> moveTypeList, Position position)
        {
            foreach (var moveType in moveTypeList)
            {
                IMovementService movementService;

                if (moveType == MoveType.M.ToString())
                {
                    movementService = new MoveInSameDirection();

                    movementService.UpdatePosition(position);
                }
                else if (moveType == MoveType.L.ToString())
                {
                    movementService = new Rotate90Left();

                    movementService.UpdatePosition(position);
                }
                else if (moveType == MoveType.R.ToString())
                {
                    movementService = new Rotate90Right();

                    movementService.UpdatePosition(position);
                }
                else
                {
                    throw new Exception($"Invalid Character {moveType}");
                }

                if (position.XCoordinate < 0 || position.XCoordinate > plateauPosition[0] || position.YCoordinate < 0 || position.YCoordinate > plateauPosition[1])
                {
                    throw new Exception($"Position can not be beyond (0 , 0) and ({plateauPosition[0]} , {plateauPosition[1]})");
                }
            }

            return position;
        }
    }
}
