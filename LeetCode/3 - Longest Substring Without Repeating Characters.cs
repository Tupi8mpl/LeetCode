namespace LeetCode;

// public class Solution {
//     public int LengthOfLongestSubstring(string s) {
//         var maxLength = 0;
//         var length = 0;
//         var builder = new StringBuilder(s.Length);
//         for(var i = 0; i < s.Length; i++)
//         {
//             if (builder.ToString().Contains(s[i]))
//             {
//                 if(maxLength < length)
//                     maxLength = length;
//                 builder.Clear();
//                 i -= length;
//                 length = 0;
//                 continue;
//             }
//             length++;
//             builder.Append(s[i]);
//         }
//
//         return maxLength > length ? maxLength : length;
//     }
// }