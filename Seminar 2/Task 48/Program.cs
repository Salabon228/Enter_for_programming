using System.Linq;                                                                   //использует расширение Linq
int[] myArray = { 13, 24, 12, 31, 34, 36, 13, 23, 15, 12, 31 };
int[] result = myArray.Distinct().ToArray();