using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_algo_lib_cs;

namespace ce100_hw2_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void MatrixMultiplicationRec_Test1()
        {
            int row1 = 2, col1 = 2;
            int row2 = 2, col2 = 2;

            int[,] A = {{4, 8},
                       {6, 3}};

            int[,] B = {{6, 3},
                       {4, 9}};

            int[,] c = new int[row1, col2];

            Class1.a = 0; Class1.b = 0; Class1.c = 0;
            Class1.MatrixMultiplicationRec(row1, col1, A, row2, col2, B, c);
            int[,] expected = {{56, 84},
                              {48, 45}};
            CollectionAssert.AreEqual(c, expected);
        }


        [TestMethod]
       
        public void MatrixMultiplicationRec_Test2()
        {
            int row1 = 3, col1 = 3;
            int row2 = 3, col2 = 3;

            int[,] A = {{2, 3, 1},
                       {5, 6, 2},
                       {7, 4, 3}};

            int[,] B = {{3, 4, 1},
                       {6, 2, 7},
                       {5, 4, 1}};

            int[,] c = new int[row1, col2];

            Class1.a = 0; Class1.b = 0; Class1.c = 0;
            Class1.MatrixMultiplicationRec(row1, col1, A, row2, col2, B, c);
            int[,] expected = {{29, 18, 24},
                              {61, 40, 49},
                              {60, 48, 38}};
            CollectionAssert.AreEqual(c, expected);
        }
      
        [TestMethod]
        public void MatrixMultiplicationRec_Test3()
        {
            int row1 = 4, col1 = 4;
            int row2 = 4, col2 = 4;

            int[,] A = {{5, 6, 7, 2},
                       {1, 4, 3, 6},
                       {2, 5, 3, 1},
                       {8, 3, 2, 1}};

            int[,] B = {{4, 6, 2, 1},
                       {5, 2, 3, 6},
                       {1, 2, 4, 7},
                       {3, 5, 2, 4}};

            int[,] c = new int[row1, col2];

            Class1.a = 0; Class1.b = 0; Class1.c = 0;
            Class1.MatrixMultiplicationRec(row1, col1, A, row2, col2, B, c);
            int[,] expected = {{63, 66, 60, 98},
                              {45, 50, 38, 70},
                              {39, 33, 33, 57},
                              {52, 63, 35, 44}};
            CollectionAssert.AreEqual(c, expected);
        }
       
        [TestMethod]
        public void MatrixMultiplicationIterative_Test1()
        {

            int[,] a = {{7, 6},
                       {3, 5}};

            int[,] b = {{2, 8},
                       {4, 7}};

            int row = 2, col = 2;

            int[,] result = {{38, 98 },
                             {26, 59 }};
            CollectionAssert.AreEqual(Class1.Matrixmultiplicationıterative(a, b, row, col), result);

        }

        [TestMethod]
        
        public void MatrixMultiplicationIterative_Test2()
        {

            int[,] a = {{3, 5, 6},
                       {2, 1, 2},
                       {4, 7, 3}};

            int[,] b = {{4, 1, 2},
                       {3, 4, 6},
                       {4, 1, 2}};

            int row = 3, col = 3;

            int[,] result = {{51, 29, 48},
                             {19, 8, 14},
                             {49, 35, 56}};
            CollectionAssert.AreEqual(Class1.Matrixmultiplicationıterative(a, b, row, col), result);
        }

        [TestMethod]
       
        public void MatrixMultiplicationIterative_Test3()
        {

            int[,] a = {{4,5,2,3},
                       {6,1,4,3},
                       { 1,2,6,2},
                       {5,3,2,1}};

            int[,] b = {{2,3,1,6},
                       {6,1,4,6},
                       {5,2,3,1},
                       {1,5,2,7}};

            int row = 4, col = 4;

            int[,] result = {{51,36,36,77},
                             {41,42,28,67},
                             {46,27,31,38},
                             {39,27,25,57} };
            CollectionAssert.AreEqual(Class1.Matrixmultiplicationıterative(a, b, row, col), result);
        }

        [TestMethod]
        public void MatrixMultiplicationStrassen_Test1()
        {

            float[,] a = {{6, 2},
                       {7, 5}};

            float[,] b = {{3, 4},
                       {4, 7 }};

            int n = 2;
            float[,] result = {{26, 38},
                              {41, 63}};

            CollectionAssert.AreEqual(Class1.MatrixMultiplicationstrassen(a, b, n), result);
        }

        [TestMethod]
        public void MatrixMultiplicationStrassen_Test2()
        {

            float[,] a = {{2, 6},
                       {4, 6}};

            float[,] b = {{3, 1},
                       {6, 3}};

            int n = 2;
            float[,] result = {{42, 20},
                              {48, 22}};

            CollectionAssert.AreEqual(Class1.MatrixMultiplicationstrassen(a, b, n), result);
        }

        [TestMethod]
        public void MatrixMultiplicationStrassen_Test3()
        {

            float[,] a = {{8, 1 },
                       {8, 0}};

            float[,] b = {{3, 4},
                       {0, 6}};

            int n = 2;
            float[,] result = {{24, 38},
                              {24, 32}};

            CollectionAssert.AreEqual(Class1.MatrixMultiplicationstrassen(a, b, n), result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test1()
        {
            int[] array = { 1, 6, 9, 8, 4, 5, 3, 7 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 1, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test2()
        {
            int[] array = { 21, 54, 45, 12, 56, 78, 96, 69 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 12, 21, 45, 54, 56, 69, 78, 96 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test3()
        {
            int[] array = { 52, 7, 8, 96, 25, 63, 31, 46 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 7, 8, 25, 31, 46, 52, 63, 96 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test1()
        {
            int[] array = {21, 1, 54, 69, 8, 5, 12, 36 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 1, 5, 8, 12, 21, 36, 54, 69 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test2()
        {
            int[] array = { 8, 12, 45, 56, 78, 10, 5, 9 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 5, 8, 9, 10, 12, 45, 56, 78 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test3()
        {
            int[] array = { 7, 89, 45, 69, 21, 36, 18, 3 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 3, 7, 18, 21, 36, 45, 69, 89 };
            CollectionAssert.AreEqual(array, result);

        }
        [TestMethod]
        public void randomQuickSortHoarePartition_Test1()
        {
            int[] array = { 2, 47, 4, 3, 87, 75, 987, 154 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            int[] result = { 2, 3, 4, 47, 75, 87, 154, 987 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void randomQuickSortHoarePartition_Test2()
        {
            int[] array = { 46, 31, 61, 53, 73, 7896, 7412, 120 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            int[] result = { 31, 46, 53, 61, 73, 120, 7412, 7896 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void randomQuickSortHoarePartition_Test3()
        {
            int[] array = { 9, 7, 5, 1, 3, 78, 96, 11 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            int[] result = { 1, 3, 5, 7, 9, 11, 78, 96 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void randomQuickSortLomutoPartition_Test1()
        {
            int[] array = { 7, 8, 1, 5, 99, 78, 54, 32 };
            int n = array.Length;
            Class1.randomQuicksortLomuto(array, 0, n - 1);
            int[] result = { 1, 5, 7, 8, 32, 54, 78, 99 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void randomQuickSortLomutoPartition_Test2()
        {
            int[] array = { 9, 5, 78, 25, 144, 23, 85, 654 };
            int n = array.Length;
            Class1.randomQuicksortLomuto(array, 0, n - 1);
            int[] result = { 5, 9, 23, 25, 78, 85, 144, 654 };
            CollectionAssert.AreEqual(array, result);
        }
        [TestMethod]
        public void randomQuickSortLomutoPartition_Test3()
        {
            int[] array = { 541, 544, 532, 145, 875, 963, 74, 58 };
            int n = array.Length;
            Class1.randomQuicksortLomuto(array, 0, n - 1);
            int[] result = { 58, 74, 145, 532, 541, 544, 875, 963 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void SelectionProblem_Test1()
        {
            int[] array = { 8, 23, 5, 7, 9, 12 };
            int n = array.Length;
            int k = 2;
            Assert.AreEqual(Class1.SelectionProblem(array, 0, n - 1, k), 7);
        }

        [TestMethod]
        public void SelectionProblem_Test2()
        {
            int[] array = { 12, 24, 54, 1, 6, 2, 76 };
            int n = array.Length;
            int k = 4;
            Assert.AreEqual(Class1.SelectionProblem(array, 0, n - 1, k), 12);
        }

        [TestMethod]
        public void SelectionProblem_Test3()
        {
            int[] array = { 61, 12, 14, 26, 3, 6, 67, 78, 34 };
            int n = array.Length;
            int k = 8;
            Assert.AreEqual(Class1.SelectionProblem(array, 0, n - 1, k), 67);
        }

        [TestMethod]
        public void HeapSort_Test1()
        {
            int[] array = { 29, 39, 49, 59, 69, 79, 85, 1 };
            Class1.HeapSort(array);
            int[] result = { 1, 29, 39, 49, 59, 69, 79, 85 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void HeapSort_Test2()
        {
            int[] array = { 45, 12, 6, 4, 2, 7, 46, 55 };
            Class1.HeapSort(array);
            int[] result = { 2, 4, 6, 7, 12, 45, 46, 55 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void HeapSort_Test3()
        {
            int[] array = { 545, 69, 74, 852, 147, 1010, 1975, 1966 };
            Class1.HeapSort(array);
            int[] result = { 69, 74, 147, 545, 852, 1010, 1966, 1975 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void PriorityQueueWithHeap_Parent_Test1()
        {
            /*       45
                  /     \
                 31        14
                / \        / \
               13  20     7   11
                 / \
                12  7
            */

            // Insert the element to the
            // priority queue
            // index zero
            Class1.InsertValue(45);
            // index one 
            Class1.InsertValue(20);
            // index two
            Class1.InsertValue(14);
            Class1.InsertValue(12);
            // index four
            Class1.InsertValue(31);
            Class1.InsertValue(7);
            Class1.InsertValue(11);
            Class1.InsertValue(13);
            Class1.InsertValue(7);
            // Get parent of a node
            Assert.AreEqual(Class1.H[1], Class1.H[Class1.Parent(4)]);
        }

        [TestMethod]
        public void PriorityQueueWithHeap_LeftChild_Test1()
        {
            /*       45
                  /     \
                 31        14
                / \        / \
               13  20     7   11
                 / \
                12  7
            */

            // Insert the element to the
            // priority queue
            // index zero
            Class1.InsertValue(45);
            // index one 
            Class1.InsertValue(20);
            // index two
            Class1.InsertValue(14);
            Class1.InsertValue(12);
            // index four
            Class1.InsertValue(31);
            Class1.InsertValue(7);
            Class1.InsertValue(11);
            Class1.InsertValue(13);
            Class1.InsertValue(7);
            // Get parent of a node
            Assert.AreEqual(Class1.H[11], Class1.H[Class1.LeftChild(5)]);
        }

        [TestMethod]
        public void PriorityQueueWithHeap_RightChild_Test1()
        {
            /*       42
                  /     \
                 35        15
                / \        / \
               16  23     8   13
                 / \
                10  8
            */

            // Insert the element to the
            // priority queue
            // index zero
            Class1.InsertValue(42);
            // index one 
            Class1.InsertValue(35);
            // index two
            Class1.InsertValue(15);
            Class1.InsertValue(16);
            // index four
            Class1.InsertValue(23);
            Class1.InsertValue(8);
            Class1.InsertValue(13);
            Class1.InsertValue(10);
            Class1.InsertValue(8);
            // Get parent of a node
            Assert.AreEqual(Class1.H[2], Class1.H[Class1.RightChild(0)]);
        }

        [TestMethod]
        public void PriorityQueueWithHeap_extractmax_Test1()
        {
            /*       42
                  /     \
                 35        15
                / \        / \
               16  23     8   13
                 / \
                10  8
            */

            // Insert the element to the
            // priority queue
            // index zero
            Class1.InsertValue(42);
            // index one 
            Class1.InsertValue(35);
            // index two
            Class1.InsertValue(15);
            Class1.InsertValue(16);
            // index four
            Class1.InsertValue(23);
            Class1.InsertValue(8);
            Class1.InsertValue(13);
            Class1.InsertValue(10);
            Class1.InsertValue(8);
            Class1.ExtractMaxPriority();
            // Get parent of a node
            Assert.AreEqual(Class1.H[2], Class1.H[0]);
        }

        [TestMethod]
        public void PriorityQueueWithHeap_changepriority_Test1()
        {
            /*       42
                  /     \
                 35        15
                / \        / \
               16  23     8   13
                 / \
                10  8
            */

            // Insert the element to the
            // priority queue
            // index zero
            Class1.InsertValue(42);
            // index one 
            Class1.InsertValue(35);
            // index two
            Class1.InsertValue(15);
            Class1.InsertValue(16);
            // index four
            Class1.InsertValue(23);
            Class1.InsertValue(8);
            Class1.InsertValue(13);
            Class1.InsertValue(10);
            Class1.InsertValue(8);
            Class1.ExtractMaxPriority();
            // Get parent of a node
            int i = 8, p = 10;
            Class1.ChangePriorityQueue(i, p);
            Class1.Remove(15);
            Assert.AreEqual(45, Class1.H[0]);
        }

        [TestMethod]
        public void CountingSort_Test1()
        {
            int[] array = { 1, 21, 3, 11, 54, 52, 85, 74 };
            Class1.CountingSort(array);
            int[] result = { 1, 3, 11, 21, 52, 54, 74, 85 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void CountingSort_Test2()
        {
            int[] array = { 741, 524, 654, 854, 963, 102, 11, 2 };
            Class1.CountingSort(array);
            int[] result = { 2, 11, 102, 524, 654, 741, 854, 963 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void CountingSort_Test3()
        {
            int[] array = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Class1.CountingSort(array);
            int[] result = { 10, 20, 30, 40, 50, 60, 70, 80 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RadixSort_Test1()
        {
            int[] array = { 7, 5, 321, 123, 456, 654, 987, 789 };
            int n = array.Length;
            Class1.RadixSort(array, n);
            int[] result = { 5, 7, 123, 321, 456, 654, 789, 987 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RadixSort_Test2()
        {
            int[] array = { 85, 12, 45, 11, 36, 77, 54, 63 };
            int n = array.Length;
            Class1.RadixSort(array, n);
            int[] result = { 11, 12, 36, 45, 54, 63, 77, 85 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RadixSort_Test3()
        {
            int[] array = { 10, 25, 36, 54, 58, 96, 63, 4 };
            int n = array.Length;
            Class1.RadixSort(array, n);
            int[] result = { 4, 10, 25, 36, 54, 58, 63, 96 };
            CollectionAssert.AreEqual(array, result);
        }                                      
    }
}
