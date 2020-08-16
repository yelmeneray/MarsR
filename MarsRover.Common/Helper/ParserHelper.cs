using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Common.Helper
{
    public class ParserHelper
    {
        public static List<int> PlateauSizeParser(string plateauSize)
        {
            if (string.IsNullOrEmpty(plateauSize?.Trim()))
            {
                throw new NullReferenceException("Plateau Size Can't Be Blank");
            }

            return plateauSize.Split(' ').Select(int.Parse).ToList();
        }

        public static List<string> PositionParser(string roverPosition)
        {
            if (string.IsNullOrEmpty(roverPosition?.Trim()))
            {
                throw new NullReferenceException("Rover Position Can't Be Blank");
            }

            return roverPosition.Split(' ').ToList();
        }

        public static List<string> MovementParser(string movement)
        {
            if (string.IsNullOrEmpty(movement?.Trim()))
            {
                throw new NullReferenceException("Move Type Can't Be Blank");
            }

            var moveTypeList = new List<string>();

            moveTypeList.AddRange(movement.ToUpper().Select(c => c.ToString()));

            return moveTypeList;
        }
    }
}
