using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp;

namespace MyApp.Tests
{
    [TestClass]
    public class TestLab1Methods
    {
        [TestMethod]
        [Description("QSort: Обычный неотсортированный массив")]
        public void TestQSort_StandardArray()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };
            Lab1Methods.QSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        [Description("QSort: Массив, отсортированный в обратном порядке")]
        public void TestQSort_ReverseSorted()
        {
            int[] arr = { 10, 9, 8, 7, 6 };
            int[] expected = { 6, 7, 8, 9, 10 };
            Lab1Methods.QSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        [Description("QSort: Массив с одинаковыми элементами")]
        public void TestQSort_AllDuplicates()
        {
            int[] arr = { 3, 3, 3, 3 };
            int[] expected = { 3, 3, 3, 3 };
            Lab1Methods.QSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        [Description("QSort: Null массив вызывает исключение")]
        public void TestQSort_NullArray_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => Lab1Methods.QSort(null));
        }

        [TestMethod]
        [Description("QSort(Overload): Сортировка части массива")]
        public void TestQSortOverload_PartialSort()
        {
            int[] arr = { 9, 5, 2, 8, 1 };
            Lab1Methods.QSort(arr, 1, 3);
            int[] expected = { 9, 2, 5, 8, 1 };
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        [Description("QSort(Overload): Некорректные границы вызывают исключение")]
        public void TestQSortOverload_InvalidBounds_ThrowsException()
        {
            int[] arr = { 1, 2, 3 };
            Assert.ThrowsException<ArgumentException>(() => Lab1Methods.QSort(arr, -1, 2));
        }

        [TestMethod]
        [Description("QSort(Overload): Start >= End (ничего не делает)")]
        public void TestQSortOverload_NoOp()
        {
            int[] arr = { 3, 2, 1 };
            int[] expected = { 3, 2, 1 };
            Lab1Methods.QSort(arr, 1, 1);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        [Description("QSort(Overload): Null массив вызывает исключение")]
        public void TestQSortOverload_NullArray_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => Lab1Methods.QSort(null, 0, 5));
        }

        [TestMethod]
        [Description("IsPalindrome: Переворот обычной строки")]
        public void TestIsPalindrome_NormalString()
        {
            string input = "hello";
            string expected = "olleh";
            Assert.AreEqual(expected, Lab1Methods.IsPalindrome(input));
        }

        [TestMethod]
        [Description("IsPalindrome: Переворот палиндрома")]
        public void TestIsPalindrome_PalindromeString()
        {
            string input = "racecar";
            string expected = "racecar";
            Assert.AreEqual(expected, Lab1Methods.IsPalindrome(input));
        }

        [TestMethod]
        [Description("IsPalindrome: Пустая строка")]
        public void TestIsPalindrome_EmptyString()
        {
            string input = "";
            string expected = "";
            Assert.AreEqual(expected, Lab1Methods.IsPalindrome(input));
        }

        [TestMethod]
        [Description("IsPalindrome: Null вызывает исключение")]
        public void TestIsPalindrome_Null_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => Lab1Methods.IsPalindrome(null));
        }

        [TestMethod]
        [Description("Factorial: Стандартное значение (5! = 120)")]
        public void TestFactorial_Standard()
        {
            long result = Lab1Methods.Factorial(5);
            Assert.AreEqual(120L, result);
        }

        [TestMethod]
        [Description("Factorial: Факториал нуля равен 1")]
        public void TestFactorial_Zero()
        {
            long result = Lab1Methods.Factorial(0);
            Assert.AreEqual(1L, result);
        }

        [TestMethod]
        [Description("Factorial: Факториал единицы равен 1")]
        public void TestFactorial_One()
        {
            long result = Lab1Methods.Factorial(1);
            Assert.AreEqual(1L, result);
        }

        [TestMethod]
        [Description("Factorial: Отрицательное число вызывает исключение")]
        public void TestFactorial_Negative_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => Lab1Methods.Factorial(-5));
        }

        [TestMethod]
        [Description("Fibonacci: 0-й элемент равен 0")]
        public void TestFibonacci_Zero()
        {
            Assert.AreEqual(0L, Lab1Methods.Fibonacci(0));
        }

        [TestMethod]
        [Description("Fibonacci: 1-й элемент равен 1")]
        public void TestFibonacci_One()
        {
            Assert.AreEqual(1L, Lab1Methods.Fibonacci(1));
        }

        [TestMethod]
        [Description("Fibonacci: 10-й элемент равен 55")]
        public void TestFibonacci_Ten()
        {
            Assert.AreEqual(55L, Lab1Methods.Fibonacci(10));
        }

        [TestMethod]
        [Description("Fibonacci: Отрицательный индекс вызывает исключение")]
        public void TestFibonacci_Negative_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => Lab1Methods.Fibonacci(-1));
        }

        [TestMethod]
        [Description("SubstringSearch: Подстрока найдена в середине")]
        public void TestSubstringSearch_FoundNormal()
        {
            int index = Lab1Methods.SubstringSearch("hello world", "world");
            Assert.AreEqual(6, index);
        }

        [TestMethod]
        [Description("SubstringSearch: Подстрока не найдена")]
        public void TestSubstringSearch_NotFound()
        {
            int index = Lab1Methods.SubstringSearch("hello world", "sky");
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        [Description("SubstringSearch: Поиск пустой подстроки (должен вернуть 0)")]
        public void TestSubstringSearch_EmptySub()
        {
            int index = Lab1Methods.SubstringSearch("any string", "");
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        [Description("SubstringSearch: Null строки вызывают исключение")]
        public void TestSubstringSearch_Null_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => Lab1Methods.SubstringSearch(null, "abc"));
        }

        [TestMethod]
        [Description("IsPrime: Простое число (17)")]
        public void TestIsPrime_True()
        {
            Assert.IsTrue(Lab1Methods.IsPrime(17));
        }

        [TestMethod]
        [Description("IsPrime: Составное число (10)")]
        public void TestIsPrime_Composite()
        {
            Assert.IsFalse(Lab1Methods.IsPrime(10));
        }

        [TestMethod]
        [Description("IsPrime: Граничное значение (2 - простое)")]
        public void TestIsPrime_Two()
        {
            Assert.IsTrue(Lab1Methods.IsPrime(2));
        }

        [TestMethod]
        [Description("IsPrime: Числа меньше 2 (1, 0, отрицательные) - не простые")]
        public void TestIsPrime_LessThanTwo()
        {
            Assert.IsFalse(Lab1Methods.IsPrime(1));
            Assert.IsFalse(Lab1Methods.IsPrime(0));
            Assert.IsFalse(Lab1Methods.IsPrime(-5));
        }

        [TestMethod]
        [Description("ReversedInt: Положительное число")]
        public void TestReversedInt_Positive()
        {
            Assert.AreEqual(321, Lab1Methods.ReversedInt(123));
        }

        [TestMethod]
        [Description("ReversedInt: Отрицательное число")]
        public void TestReversedInt_Negative()
        {
            Assert.AreEqual(-321, Lab1Methods.ReversedInt(-123));
        }

        [TestMethod]
        [Description("ReversedInt: Число с нулем на конце (120 -> 21)")]
        public void TestReversedInt_TrailingZero()
        {
            Assert.AreEqual(21, Lab1Methods.ReversedInt(120));
        }

        [TestMethod]
        [Description("ReversedInt: Ноль остается нулем")]
        public void TestReversedInt_Zero()
        {
            Assert.AreEqual(0, Lab1Methods.ReversedInt(0));
        }

        [TestMethod]
        [Description("IntToRoman: Сложное число (1994 -> MCMXCIV)")]
        public void TestIntToRoman_Complex()
        {
            Assert.AreEqual("MCMXCIV", Lab1Methods.IntToRoman(1994));
        }

        [TestMethod]
        [Description("IntToRoman: Минимальное значение (1 -> I)")]
        public void TestIntToRoman_Min()
        {
            Assert.AreEqual("I", Lab1Methods.IntToRoman(1));
        }

        [TestMethod]
        [Description("IntToRoman: Максимальное значение (3999 -> MMMCMXCIX)")]
        public void TestIntToRoman_Max()
        {
            Assert.AreEqual("MMMCMXCIX", Lab1Methods.IntToRoman(3999));
        }

        [TestMethod]
        [Description("IntToRoman: Выход за границы диапазона вызывает исключение")]
        public void TestIntToRoman_OutOfRange_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => Lab1Methods.IntToRoman(4000));
            Assert.ThrowsException<ArgumentException>(() => Lab1Methods.IntToRoman(0));
        }
    }
}
