using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Tests
{
    [TestClass()]
    public class Task1Tests
    {
        [TestMethod()]
        public void Task1ReverseAndOmmitRegex_SomeWord_ReturnReverseWord()
        {
            //Arrange
            string input = "krishan";
            string expected = "nahsirk";

            //Act
            string actual = Task1.ReverseAndOmmit_REGEX(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task1ReverseAndOmmitRegex_SomeWordAndNumbers_ReturnReverseWordAndOmmitNonAlhpabet()
        {
            //Arrange
            string input = "ultr53o?n ";
            string expected = "nortlu";

            //Act
            string actual = Task1.ReverseAndOmmit_REGEX(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task1ReverseAndOmmitRegex_EmptyString_Return()
        {
            //Arrange
            string input = "";
            string expected = "";
            //Act
            string actual = Task1.ReverseAndOmmit_REGEX(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Task1.ReverseAndOmmit_LINQ

        [TestMethod()]
        public void Task1ReverseAndOmmitLINQ_SomeWord_ReturnReverseWord()
        {
            //Arrange
            string input = "5332";
            string expected = "";

            //Act
            string actual = Task1.ReverseAndOmmit_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task1ReverseAndOmmitLINQ_SomeWordAndNumbers_ReturnReverseWordAndOmmitNonAlhpabet()
        {
            //Arrange
            string input = "ultr53o?n ";
            string expected = "nortlu";

            //Act
            string actual = Task1.ReverseAndOmmit_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task1ReverseAndOmmitLINQ_EmptyString_ReturnEmptyString()
        {
            //Arrange
            string input = "";
            string expected = "";
            //Act
            string actual = Task1.ReverseAndOmmit_LINQ(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class Task2Tests
    {
        [TestMethod()]
        public void Cats_EasyAlgorithm_1and5_Return2()
        {
            //Arrange
            int Start = 1;
            int Finish = 5;
            int expected = 2;

            //Act
            int actual = Task2.Cats_EasyAlgorithm(Start, Finish);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Cats_EasyAlgorithm_12and4_Return0()
        {
            //Arrange
            int Start = 12;
            int Finish = 4;
            int expected = 0;

            //Act
            int actual = Task2.Cats_EasyAlgorithm(Start, Finish);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class Task3Tests
    {
        [TestMethod()]
        public void FirstLetterWordToUpRegex_should_return_capitalized_words_on_valid_input()
        {
            //Arrange
            string input = "How can mirrors be real if our eyes aren't real";
            string expected = "How Can Mirrors Be Real If Our Eyes Aren't Real";

            //Act
            string actual = Task3.FirstLetterWordToUp_Regex(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FirstLetterWordToUpRegex_should_return_empty_string_on_empty_input()
        {
            //Arrange 
            string input = "";
            string expected = "";

            //Act
            string actual = Task3.FirstLetterWordToUp_Regex(input);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void FirstLetterWordToUpLinq_should_return_capitalized_words_on_valid_input()
        {
            //Arrange
            string input = "How can mirrors be real if our eyes aren't real";
            string expected = "How Can Mirrors Be Real If Our Eyes Aren't Real";

            //Act
            string actual = Task3.FirstLetterWordToUp_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FirstLetterWordToUpLinq_should_return_empty_string_on_empty_input()
        {
            //Arrange 
            string input = "";
            string expected = "";

            //Act
            string actual = Task3.FirstLetterWordToUp_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }

    [TestClass()]
    public class Task4Tests
    {
        [TestMethod()]
        public void Find_the_odd_int_that_appears_an_odd_time_LINQ_should_return_4_on_valid_array()
        {
            //Arrange 
            int[] input = new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            int expected = 4;

            //Act
            int actual = Task4.Find_the_odd_int_that_appears_an_odd_time_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Find_the_odd_int_that_appears_an_odd_time_LINQ_should_return_2_on_valid_array()
        {
            //Arrange 
            int[] input = new int[] { 1, 1, 2 };
            int expected = 2;

            //Act
            int actual = Task4.Find_the_odd_int_that_appears_an_odd_time_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Find_the_odd_int_that_appears_an_odd_time_LINQ_should_return_0_on_valid_array()
        {
            //Arrange
            int[] input = new int[] { 0 };
            int expected = 0;

            //Act
            int actual = Task4.Find_the_odd_int_that_appears_an_odd_time_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Find_the_odd_int_that_appears_an_odd_time_LINQ_should_return_0_on_invalid_array()
        {
            //Arrange
            int[] input = new int[] { };
            int expected = 0;

            //Act
            int actual = Task4.Find_the_odd_int_that_appears_an_odd_time_LINQ(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class Task5Tests
    {
        [TestMethod()]
        public void Numbers_of_time_multiply_until_single_digit_Recursion_should_return_4_on_valid_int()
        {
            //Arrange
            int input = 999;
            int expected = 4;

            //Act
            int actual = Task5.Numbers_of_time_multiply_until_single_digit_Recursion(input);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Numbers_of_time_multiply_until_single_digit_Recursion_should_return_0_on_valid_int()
        {
            //Arrange
            int input = 4;
            int expected = 0;

            //Act
            int actual = Task5.Numbers_of_time_multiply_until_single_digit_Recursion(input);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Numbers_of_time_multiply_until_single_digit_Recursion_should_return_0_on_invalid_int()
        {
            //Arrange
            int Input = -55;
            int expected = 0;

            //Act
            int actual = Task5.Numbers_of_time_multiply_until_single_digit_Recursion(Input);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }

    [TestClass()]
    public class Task6Tests
    {
        [TestMethod()]
        public void Convert_first_char_into_title_case_with_except_Regex_should_return_convertString_on_valid_input_with_filter()
        {
            //Arrange
            string maininput = "a clash of KINGS";
            string filterinput = "a an the of";
            string expected = "A Clash of Kings";

            //Act
            string actual = Task6.Convert_first_char_into_title_case_with_except_Regex(maininput, filterinput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Convert_first_char_into_title_case_with_except_Regex_should_return_convertString_on_valid_input_without_filter()
        {
            //Arrange
            string maininput = "the quick brown fox";
            // string filterinput = "The In";
            string expected = "The Quick Brown Fox";

            //Act
            string actual = Task6.Convert_first_char_into_title_case_with_except_Regex(maininput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Convert_first_char_into_title_case_with_except_Regex_should_return_convertString_on_invalid_input_with_filter()
        {
            //Arrange
            string maininput = "";
            string filterinput = "";
            string expected = "";

            //Act
            string actual = Task6.Convert_first_char_into_title_case_with_except_Regex(maininput, filterinput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class Task7Tests
    {
        [TestMethod()]
        public void Is_integer_prime_should_return_true_on_input_11()
        {
            //Arrange
            int input = 2;
            bool expected = true;

            //Act
            bool actual = Task7.Is_integer_prime(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Is_integer_prime_should_return_false_on_input_0()
        {
            //Arrange
            int input = 0;
            bool expected = false;

            //Act
            bool actual = Task7.Is_integer_prime(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Is_integer_prime_should_return_false_on_input_negative_number()
        {
            //Arrange
            int input = -57;
            bool expected = false;

            //Act
            bool actual = Task7.Is_integer_prime(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class Task8Tests
    {
        [TestMethod()]
        public void Move_Zeros_to_end_should_return_sorted_array_on_valid_input()
        {
            //Arrange
            int[] input = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };

            //Act
            int[] actual = Task8.Move_Zeros_to_end(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Move_Zeros_to_end_should_return_nosorted_array_on_input_without_0()
        {
            //Arrange
            int[] input = new int[] { 1, 2, 1, 1, 3, 1 };
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1 };

            //Act
            int[] actual = Task8.Move_Zeros_to_end(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Move_Zeros_to_end_should_return_nosorted_array_on_input_without_0_and_with_negative()
        {
            //Arrange
            int[] input = new int[] { 1, 2, 1, 1, 3, 1,-1,-3,-2 };
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1, -1, -3, -2};

            //Act
            int[] actual = Task8.Move_Zeros_to_end(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Move_Zeros_to_end_should_return_empty_array_on_input_empty_array()
        {
            //Arrange
            int[] input = new int[] {};
            int[] expected = new int[] {};

            //Act
            int[] actual = Task8.Move_Zeros_to_end(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}