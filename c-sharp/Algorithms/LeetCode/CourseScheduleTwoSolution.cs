using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class CourseScheduleTwoSolution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            CourseNode[] nodes = new CourseNode[numCourses];

            foreach (var pre in prerequisites)
            {
                if (nodes[pre[0]] is null)
                {
                    nodes[pre[0]] = new CourseNode(pre[0]);
                }

                if (nodes[pre[1]] is null)
                {
                    nodes[pre[1]] = new CourseNode(pre[1]);
                }
                
                nodes[pre[0]].Dependencies.Add(nodes[pre[1]]);
            }

            bool[] visited = new bool[numCourses];

            return new int[]{};
        }

        public bool DFS(CourseNode node, bool[] visited)
        {
            if (visited[node.Value])
            {
                return true;
            }
            else
            {
                foreach (var child in node.Dependencies)
                {
                    if (DFS(child, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public class CourseNode
        {
            public int Value;
            public IList<CourseNode> Dependencies;

            public CourseNode(int value)
            {
                Value = value;
                Dependencies = new List<CourseNode>();
            }
        }
    }
}