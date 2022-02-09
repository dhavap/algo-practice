// Given an integer numRows, return the first numRows of Pascal's triangle.
// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
// Example 1:
// Input: numRows = 5
// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
// [Problem from leetcode.com]

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> output = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            IList<int> row = new List<int>();
            row.Add(1); 
            if (i == 0)
            {
                output.Add(row);
            } else if (i == 1)
            {
                row.Add(1);
                output.Add(row);
            } else {
                IList<int> prevRow = output[i-1];
                for (int j = 0; j < prevRow.Count; j++) 
                {
                    if ((j + 1) == prevRow.Count)
                    {
                        break;
                    } else {
                        row.Add(prevRow[j] + prevRow[j+1]); 
                    }
                    
                }
                row.Add(1);
                output.Add(row);  
            }
        }
        return output;
    }
}
