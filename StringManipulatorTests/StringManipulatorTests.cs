using System;
using Xunit;

public class StringManipulatorTests
{
    [Fact]
    public void ReverseString_ShouldReverseEmptyString()
    {
        //  When the input is an empty string, should return an empty string (reversed).
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "";

        // Act
        string result = manipulator.ReverseString(input);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ReverseString_ShouldReverseSingleCharacterString()
    {
        //  When the input is a single-character string, should return the same character (reversed).
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "H";

        // Act
        string result = manipulator.ReverseString(input);

        // Assert
        Assert.Equal("H", result);
    }

    [Fact]
    public void ReverseString_ShouldReverseString()
    {
        //  When the input is a longer string with multiple characters and non-alphanumeric characters,
        // should return the reversed string.
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "Hello, World!";

        // Act
        string result = manipulator.ReverseString(input);

        // Assert
        Assert.Equal("!dlroW ,olleH", result);
    }

    [Fact]
    public void CapitalizeString_ShouldCapitalizeEmptyString()
    {
        //  When the input is an empty string, should return an empty string (capitalized).
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "";

        // Act
        string result = manipulator.CapitalizeString(input);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void CapitalizeString_ShouldCapitalizeString()
    {
        //  When the input is a string with multiple characters and non-alphanumeric characters,
        // should return the string with all characters capitalized.
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "hello, world!";

        // Act
        string result = manipulator.CapitalizeString(input);

        // Assert
        Assert.Equal("HELLO, WORLD!", result);
    }

    [Theory]
    [InlineData("hello", 'l', 2)]
    [InlineData("hello, world!", 'o', 2)]
    [InlineData("hello", 'x', 0)]
    [InlineData("", 'a', 0)]
    public void CountOccurrences_ShouldReturnCorrectCount(string input, char character, int expectedCount)
    {
        //  When counting the occurrences of the specified character in the input string,
        // should return the correct count.
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();

        // Act
        int result = manipulator.CountOccurrences(input, character);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    [Theory]
    [InlineData("radar", true)]
    [InlineData("hello", false)]
    [InlineData("Racecar", true)]
    [InlineData("Was it a car or a cat I saw?", true)]
    [InlineData("A man, a plan, a canal, Panama!", true)]
    [InlineData("hello, world!", false)]
    public void IsPalindrome_ShouldReturnCorrectResult(string input, bool expectedResult)
    {
        //  When identifying whether the input string is a palindrome,
        // should return the correct result (true or false).
        
        // Arrange
        StringManipulator manipulator = new StringManipulator();

        // Act
        bool result = manipulator.IsPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
