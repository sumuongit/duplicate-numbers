## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [License](#license)

## General info
This application finds duplicate numbers from a given set of numbers

The following illustration depicts the mechanism of finding the duplicate numbers from a given array.

 | 11 | 15 | 3 | 18 | 30 | 22 | 37 | 7 | 11 | 8 | 22 | 2 | |
 |----|----|---|----|----|----|----|---|----|---|----|---|---|
 | `11` | 11 | 11 | 11 | 11 | 11 | 11 | 11 | `11` | 11 | 11 | 11 | Duplicity found as there are more than one occurrences |
 | 15 | `15` | 15 | 15 | 15 | 15 | 15 | 15 | 15 | 15 | 15 | 15 | |
 | 3 | 3 | `3`| 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | |
 | 18 | 18 | 18 | `18` | 18 | 18 | 18 | 18 | 18 | 18 | 18 | 18 | |
 | 30 | 30 | 30 | 30 | `30` | 30 | 30 | 30 | 30 | 30 | 30 | 30 | |
 | 22 | 22 | 22 | 22 | 22 | `22` | 22 | 22 | 22 | 22 | `22` | 22 | Duplicity found as there are more than one occurrences |
 | 37 | 37 | 37 | 37 | 37 | 37 | `37` | 37 | 37 | 37 | 37 | 37 | |
 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | `7` | 7 | 7 | 7 | 7 | |
 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | 11 | This level of comparision is omitted as it is already done |
 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | `8` | 8 | 8 | |
 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | 22 | This level of comparision is omitted as it is already done |
 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | `2`| |
  	
## Technologies
This application is created with:
* Visual Studio 2013
* C# 
	
## Setup
To run this application, building the source locally using git:

```
$ git clone https://github.com/sumuongit/duplicate-numbers.git

```

## License
[MIT License](https://github.com/sumuongit/duplicate-numbers/blob/master/LICENSE)

