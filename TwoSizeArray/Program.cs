
//Task1  nxn ikiölçülü arrayin elementlərin olduğu kimi print etmək
//int[,] nums =
//{
//    {10,20,30,32 },
//     {10,50,40,18},
//     {10,35,11,7}
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        Console.Write(nums[i,j] +" ");
//    }
//    Console.WriteLine();
//}


// Task2 2 ölçülü nxn array-də bütün ədədlərin cəmini tapmaq.
//int[,] nums =
//{
//    {10,20,30 },
//    {5,10,15 },
//    {1,2,3 }
//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int y = 0; y < nums.GetLength(1); y++)
//    {
//      sum+= nums[i, y];
//    }
//}
//Console.WriteLine(sum);


//Task3  .2 ölçülü nxn arraydə 1-ci sütunun cəmini tapmaq. 
//int[,] nums =
//{
//    {10,20,30 },
//    {5,10,15 },
//    {1,2,3 }
//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//   sum+= nums[i,0];
//}
//Console.WriteLine(sum);

//Task4  2 ölçülü nxn arraydə neqativ ədədləri göstərən ədədləri print etmək
//int[,] nums =
//{
//    {10,20,-30 },
//    {5,10,15 },
//    {1,-2,3 }
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (nums[i,j]<0)
//        {
//            Console.WriteLine(nums[i,j]);
//        }
//    }

//}

//task5 2 ölçülü nxn arraydə minimum və maksimum elementi tapmaq
//int[,] nums =
//{
//    {10,20,-30 },
//    {5,10,15 },
//    {1,546,3 }
//};
//int max = 0;
//int min = nums[0, 0];

//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (nums[i, j] < min)
//        {
//            min = nums[i, j];
//        }
//        if (nums[i, j] > max) { max = nums[i, j]; }

//    }
//}
//Console.WriteLine("minimum deyer:" + min);
//Console.WriteLine("max deyer:" + max);

//task6 2 ölçülü nxn array-də musbet cüt ədədləri 2-ə, musbet tək ədədləri 1-ə, menfi cut ededleri -2e, menfi tek ededleri -1e çevirmək
//Arraydəki hər hansı ədədin 0 olma ehtimalını da nəzərə alın.

//int[,] nums = 
//{
//  {10,15,7 },
//  {4,3,-7 },
//  {-10,0,7 }
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0;  j < nums.GetLength(1);  j++)
//    {
//        if (nums[i,j]==0) { nums[i, j] = nums[i, j]; }
//         else if (nums[i,j]>0 && nums[i,j]%2==0) { nums[i, j] = 2; }
//        else if (nums[i,j]>0 && nums[i,j]%2!=0) { nums[i, j] = 1; }
//        else if (nums[i,j]<0 && nums[i,j]%2==0) { nums[i, j] = -2; }
//        else if (nums[i,j]<0 && nums[i,j]%2!=0) { nums[i, j] = -1; }
//    }
//}
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        Console.Write(nums[i,j]+" ");
//    }
//    Console.WriteLine();
//}


//Task7  4x4 ikiölçülü arrayin 2-ci sırasını 0-a çevirin.
//int[,] nums =
//{
//  {10,15,7,9 },
//  {4,3,-7 ,10},
//  {-10,0,7,12 },
//  {50,40,70,121 }
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (i==1)
//        {
//            nums[i,j] = 0;  
//        }
//    }

//}


//for (int a = 0; a < nums.GetLength(0); a++)
//{
//    for (int b = 0; b < nums.GetLength(1); b++)
//    {
//        Console.Write(nums[a, b] + " ");
//    }
//    Console.WriteLine();
//}


//task8 3x3 ikiölçülü arrayin 3-cü sütununu 0-a çevirin.

//int[,] nums =
//{
//  {10,15,17 },
//  {40,30 ,10},
//  {50,71,12 },
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (j == 2)
//        {
//            nums[i, j] = 0;
//        }
//    }

//}

//for (int a = 0; a < nums.GetLength(0); a++)
//{
//    for (int b = 0; b < nums.GetLength(1); b++)
//    {
//        Console.Write(nums[a, b] + " ");
//    }
//    Console.WriteLine();
//}


//Task9 3x3 ikiölçülü arrayin sol diaqonalındakı ədədlərin cəmini tapın .
//int[,] nums =
//{
//  {10,20,30 },
//  {3,4,5 },
//  {20,11,25 }

//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = i; j < nums.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += nums[i, j];
//        }
//    }
//}
//Console.WriteLine(sum);


//Task10 4x4 ikiölçülü arrayin sağ diaqonalındakı ədədlərin cəmini tapın .
//int[,] nums =
//{
//    { 10,20,30,14 },
//    { 3,4,5 ,6},
//    { 20,11,25,27 }
//    { 22,12,61,2 }

//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
// sum += nums[i,nums.GetLength(0)-1-i];
//}
//Console.WriteLine(sum);

//Task11 5x5 ikiölçülü arraydə sol diaqonaldan aşağıda qalan hissəni 0-a çevirin
//int[,] nums =
//{
//    {1,2,3,4,5},
//    {70,1,2,3,4},
//    {1,2,40,5,4},
//    {30,2,10,20,5},
//    {1,5,10,2,90}
//};

//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (i>j)
//        {
//            nums[i, j] = 0; 
//        }
//    }
//}
//for (int a = 0; a < nums.GetLength(0); a++)
//{
//    for (int b = 0; b < nums.GetLength(1); b++)
//    {
//        Console.Write(nums[a,b] +" ");
//    }
//    Console.WriteLine();
//}

//Task12 5x5 ikiölçülü arraydə sol diaqonaldan yuxarıda qalan hissəni 0-a çevirin
//int[,] nums =
//{
//    {1,2,3,4,5},
//    {70,1,2,3,4},
//    {1,2,40,5,4},
//    {30,2,10,20,5},
//    {1,5,10,2,90}
//};

//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (i < j)
//        {
//            nums[i, j] = 0;
//        }
//    }
//}
//for (int a = 0; a < nums.GetLength(0); a++)
//{
//    for (int b = 0; b < nums.GetLength(1); b++)
//    {
//        Console.Write(nums[a, b] + " ");
//    }
//    Console.WriteLine();
//}

//13 Verilmiş iki nxn ölçülü arrayin uygun elementlerini cemleyib 3cu array yaradin
//int[,] nums1 = 
//{
//    {12,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};
//int[,] nums2 =
//{
//    {12,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};

//int[,] nums3 = new int[3, 3];

//for (int i = 0; i < nums1.GetLength(0); i++)
//{
//    for (int j = 0; j < nums1.GetLength(1); j++)
//    {
//        nums3[i,j] = nums1[i, j] + nums2[i,j];
//    }
//}

//for (int a = 0; a < nums3.GetLength(0); a++)
//{
//    for (int b = 0; b < nums3.GetLength(1); b++)
//    {
//        Console.Write(nums3[a,b]+" ");
//    }
//    Console.WriteLine();
//}


//Task14 2 ölçülü nxn arraydə hər bir row-un ayrılıqda cəmini tapın
//int[,] nums =
//{
//    {12,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        sum += nums[i, j];
//    }
//    Console.WriteLine(sum);
//    sum = 0;
//}


//Task15 2 ölçülü nxn arraydə hər bir column-un ayrılıqda cəmini tapın
//int[,] nums =
//{
//    {12,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};
//int sum = 0;
//for (int i = 0; i < nums.GetLength(1); i++)
//{


//    for (int j = 0; j < nums.GetLength(0); j++)
//    {
//        sum += nums[j, i];
//    }
//    Console.WriteLine(sum);
//    sum = 0;
//}


//Task16 -------------- shift taski
//int[,] nums =
//{
//    {12,15,20,21},
//    {12,15,20,21},
//    {11,15,20,21},
//    {19,15,20,21}
//};
//int shift = 3;
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j =  nums.GetLength(1)-1; j>=0; j--)
//    {
//        if (j-shift >=0)
//        {
//            nums[i, j] = nums[i, j - shift];
//        }
//        else
//        {
//            nums[i, j] = 0;
//        }
//    }
//}

//for (int a = 0; a < nums.GetLength(0); a++)
//{
//    for (int b = 0; b < nums.GetLength(1); b++)
//    {
//        Console.Write(nums[a, b] + " ");
//    }
//    Console.WriteLine();
//}


//int[,] newarr = new int[4, 4];

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if (j == 3)
//        {
//            newarr[i, j] = nums[i, 0];
//        }
//        else if (i == 0)
//        {
//            newarr[i, j] = 0;
//        }
//        else
//        {
//            newarr[i, j] = 0;
//        }
//    }
//}


//Task17 Iki nxn eyniolculu arrayin hasilini tapib 3cu arraye menimsedin
//int[,] nums1 =
//{
//    {1,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};
//int[,] nums2 =
//{
//    {12,11,10 },
//    {12,13,14 },
//    {12,14,15 }
//};

//int[,] nums3 = new int[3, 3];

//for (int i = 0; i < nums1.GetLength(0); i++)
//{
//    for (int j = 0; j < nums1.GetLength(1); j++)
//    {
//        nums3[i, j] = nums1[i, j] * nums2[i, j];
//    }
//}

//for (int a = 0; a < nums3.GetLength(0); a++)
//{
//    for (int b = 0; b < nums3.GetLength(1); b++)
//    {
//        Console.Write(nums3[a, b] + " ");
//    }
//    Console.WriteLine();
//}

//Task 18. Iki nxn arrayde sade ededleri tapib print etmek
//bool isComplex =true;
//int[,] nums =
//{
//   {10,20,1 },
//   {2,11,18 },
//   {27,19,67 }
//};
//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {
//        if (nums[i,j]<=1)
//        {
//            continue; 
//        }
//        else
//        {
//            isComplex = false;
//            int sq = Convert.ToInt32(Math.Sqrt(nums[i,j]));
//            for (int k = 2; k < sq; k++)
//            {
//                if (nums[i,j]%k==0)
//                {
//                    isComplex = true;
//                }
//            }
//            if (!isComplex) {
//                Console.WriteLine(nums[i,j]);
//            }
//        }
//    }
//}