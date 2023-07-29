Author : Raihan Annafi

# StringManipulatorTests

StringManipulatorTests is a set of unit tests written in C# using Xunit to test the functionalities of the `StringManipulator` class. The `StringManipulator` class contains various string manipulation methods, and these tests ensure that the methods are working as expected.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Test Descriptions](#test-descriptions)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

Before running the unit tests, ensure you have the following installed:

- .NET Core SDK

## Installation

1. Clone the repository to your local machine:

```bash
git clone https://github.com/your-username/your-repo.git
```

2. Navigate to the `StringManipulatorTests` directory:

```bash
cd StringManipulatorTests
```

3. Restore the project dependencies:

```bash
dotnet restore
```

## Usage

To execute the unit tests, run the following command from the `StringManipulatorTests` directory:

```bash
dotnet test
```

The tests will be executed, and the results will be displayed in the console.

## Test Descriptions

The unit tests are written to ensure the correctness of the `StringManipulator` class methods. Each test has a descriptive name indicating the scenario being tested. Here is a brief overview of the test scenarios:

1. **ReverseString_ShouldReverseEmptyString**: Reversing an empty input string should return an empty string.

2. **ReverseString_ShouldReverseSingleCharacterString**: Reversing a single-character input string should return the same character.

3. **ReverseString_ShouldReverseString**: Reversing a longer input string with multiple characters and non-alphanumeric characters should return the reversed string.

4. **CapitalizeString_ShouldCapitalizeEmptyString**: Capitalizing an empty input string should return an empty string.

5. **CapitalizeString_ShouldCapitalizeString**: Capitalizing a string with multiple characters and non-alphanumeric characters should return the string with all characters capitalized.

6. **CountOccurrences_ShouldReturnCorrectCount**: Counting the occurrences of the specified character in the input string should return the correct count.

7. **IsPalindrome_ShouldReturnCorrectResult**: Identifying whether the input string is a palindrome should return the correct result (true or false).

Total testcase is `15 testcases` with detail : 

1. `ReverseString_ShouldReverseEmptyString`: Reversing an empty input string should return an empty string.
2. `ReverseString_ShouldReverseSingleCharacterString`: Reversing a single-character input string should return the same character.
3. `ReverseString_ShouldReverseString`: Reversing a longer input string with multiple characters and non-alphanumeric characters.
4. `CapitalizeString_ShouldCapitalizeEmptyString`: Capitalizing an empty input string should return an empty string.
5. `CapitalizeString_ShouldCapitalizeString`: Capitalizing a string with multiple characters and non-alphanumeric characters.
6. `CountOccurrences_h_in_hello_ShouldReturnTwo`: Counting the occurrences of the character 'l' in the input string "hello" should return 2.
7. `CountOccurrences_o_in_hello_world_ShouldReturnTwo`: Counting the occurrences of the character 'o' in the input string "hello, world!" should return 2.
8. `CountOccurrences_x_in_hello_ShouldReturnZero`: Counting the occurrences of the character 'x' in the input string "hello" should return 0.
9. `CountOccurrences_a_in_emptyString_ShouldReturnZero`: Counting the occurrences of the character 'a' in an empty input string should return 0.
10. `IsPalindrome_Radar_ShouldReturnTrue`: Identifying the input string "radar" as a palindrome should return true.
11. `IsPalindrome_Hello_ShouldReturnFalse`: Identifying the input string "hello" as not a palindrome should return false.
12. `IsPalindrome_Racecar_ShouldReturnTrue`: Identifying the input string "Racecar" as a palindrome should return true.
13. `IsPalindrome_Was_it_a_car_or_a_cat_I_saw_ShouldReturnTrue`: Identifying the input string "Was it a car or a cat I saw?" as a palindrome should return true.
14. `IsPalindrome_A_man_a_plan_a_canal_Panama_ShouldReturnTrue`: Identifying the input string "A man, a plan, a canal, Panama!" as a palindrome should return true.
15. `IsPalindrome_Hello_world_ShouldReturnFalse`: Identifying the input string "hello, world!" as not a palindrome should return false.