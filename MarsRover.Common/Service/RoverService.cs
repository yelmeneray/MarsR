using MarsRover.Common.Interface;
using System;
using System.Collections.Generic;
using MarsRover.Common.Enum;
using MarsRover.Common.Factory;
using MarsRover.Common.Model;

namespace MarsRover.Common.Service
{
    public class RoverService : IRoverService
    {
        public Position StartMoving(List<int> plateauPosition, List<string> moveTypeList, List<string> roverPosition)
        {
            var position = new Position
            {
                XCoordinate = Convert.ToInt32(roverPosition[0]),
                YCoordinate = Convert.ToInt32(roverPosition[1]),
                Direction = (Direction)System.Enum.Parse(typeof(Direction), roverPosition[2])
            };

            BasePositionFactory positionFactory = new PositionFactory();

            return positionFactory.CreatePosition(plateauPosition, moveTypeList, position);
        }
    }
}
