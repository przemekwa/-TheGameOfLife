namespace TheGameOfLifeNET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    namespace TheGameOfLifeNET
    {
        public class Board
        {
            public HashSet<Point> boardList { get; set; }

            public HashSet<Point> boardListNext { get; }

            public Board()
            {
                this.boardList = new HashSet<Point>(new PointComparer());
                this.boardListNext = new HashSet<Point>(new PointComparer());
            }

            public void Next()
            {
                var rule = new RuleChecker(boardList);

                var allNeighbors = new List<Point>();

                boardList.ToList().ForEach(p => allNeighbors.AddRange(rule.GetNeighbors(p)));

                boardList = new HashSet<Point>(
                    allNeighbors.Where(p => rule.IsLive(p) || rule.IsNew(p)),
                    new PointComparer());
            }
        }
    }
}
