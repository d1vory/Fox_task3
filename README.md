# Maximal Sum of Elements Console Application

## Description

This project is a console application that reads a file containing lines of numbers and finds the line with the maximum sum of elements. The user can input the file path either through the console or as a command line argument. Each line in the file contains a set of numbers separated by commas. If a line contains non-numeric elements, it is marked as broken. The application also provides an enhanced feature to find the line with the minimal sum of elements if the `-min` argument is provided.

## Features

- Reads a file containing lines of numbers.
- Finds the line with the maximum sum of elements.
- Marks lines with non-numeric elements as broken.
- Provides the number of lines with non-numeric elements.
- Enhanced feature: Finds the line with the minimal sum of elements if the `-min` argument is provided.

### Examples

**Example 1: Maximum Sum**

Input file (`numbers.txt`):
```
1.5,2.5,3.0
2.0,4.0,1.0
a,b,c
3.5,2.5
```

Output:
```
Line with maximum sum: 1
Sum: 7.0
Broken lines: 1 (line 3)
```