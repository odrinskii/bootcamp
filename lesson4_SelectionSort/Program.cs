﻿// MIN -> MAX

//     7 6 3 4 5 1 2 3 <| 0
//     1 6 3 4 5 7 2 3 <| 1
//     1 2 3 4 5 7 6 3 <| 2
//     1 2 3 4 5 7 6 3 <| 3
//     1 2 3 3 5 7 6 4 <| 4
//     1 2 3 3 4 7 6 5 <| 5
//     1 2 3 3 4 5 6 7 <| 6
//     1 2 3 3 4 5 6 7 <| 7
//     1 2 3 3 4 5 6 7 <| 8

using static Sorting;
using static Infrastructure;

int[] array = CreateArray(10);
Print(array);
SortSelection(array);
Print(array); 
