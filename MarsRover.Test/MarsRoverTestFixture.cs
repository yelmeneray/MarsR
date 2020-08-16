using System.Collections.Generic;
using System.Linq;
using MarsRover.Common.Service;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class MarsRoverTestFixture
    {
        [TestCase("5 5", "1 2 N", "LMLMLMLMM", "1 3 N")]
        [TestCase("5 5", "3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void StartMoving_WhenUseTestCases_ReturnExpectedResult(string plateauSize, string roverPosition, string movement, string expected)
        {
            var moveTypeList = new List<string>();

            moveTypeList.AddRange(movement.ToUpper().Select(c => c.ToString()));

            var roverService = new RoverService();

            var position = roverService.StartMoving(plateauSize.Split(' ').Select(int.Parse).ToList(), moveTypeList, roverPosition.Split(' ').ToList());

            Assert.AreEqual(expected, $"{position.XCoordinate} {position.YCoordinate} {position.Direction}");
        }
    }
}
