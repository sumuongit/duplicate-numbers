## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contributing](#contributing)
* [License](#license)

## General Info
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
To clone and run this repository you will need [Git](https://git-scm.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/sumuongit/duplicate-numbers.git
# Go into the repository
$ cd duplicate-numbers
```

## Contributing
* Fork the repository
* Create a topic branch
* Implement your feature or bug fix
* Add, commit, and push your changes
* Submit a pull request

## License
[MIT License](https://github.com/sumuongit/duplicate-numbers/blob/master/LICENSE)

