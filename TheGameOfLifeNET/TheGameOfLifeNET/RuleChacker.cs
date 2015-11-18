using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLifeNET
{
    public class RuleChecker
    {
        private HashSet<Point> board;

        public RuleChecker(HashSet<Point> board)
        {
            this.board = board;
        }

        public bool IsLive(Point point)
        {
            if (!this.board.Contains(point))
            {
                return false;
            }

            var liveNeighbors = this.GetNeighbors(point).Count(n => this.board.Contains(n));

            return liveNeighbors == 2 || liveNeighbors == 3;
        }

        public bool IsNew(Point point) =>
            this.GetNeighbors(point).Count(n => this.board.Contains(n)) == 3;

        public List<Point> GetNeighbors(Point point) =>
            new List<Point>
            {
                new Point(point.X-1, point.Y-1),
                new Point(point.X-1, point.Y),
                new Point(point.X-1, point.Y+1),
                new Point(point.X+1, point.Y-1),
                new Point(point.X+1, point.Y),
                new Point(point.X+1, point.Y+1),
                new Point(point.X, point.Y-1),
                new Point(point.X, point.Y+1),
            };

    }
}